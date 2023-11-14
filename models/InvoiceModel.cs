using Invoices.src.DataObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Invoices.src.controllers;

namespace Invoices.src.models
{
    public class InvoiceModel
    {
//        InvoiceController invoiceController;
        TextFiles textFiles;
        List<Company> companies = new List<Company>();
        List<OurCompany> ourCompanies = new List<OurCompany>();
        List<InvoiceItem> invoiceItems = new List<InvoiceItem>();
        List<ScopeItem> scopeItems = new List<ScopeItem>();
        private decimal receiptTotal;
        private decimal vat;
        private decimal grandTotal;

        string pathToPreviousInvoiceQuote;
        public InvoiceModel() 
        {
            textFiles = new TextFiles();
            // When the class is constructed, we need to read the csv files that contain all the information needed by the invoices tab

            //Create the list of companies
            
            
            //Read companies
            //MessageBox.Show(companiesPath);
            readCompanies();
            loadOurCompanies();

            //Read the prices

        }

        private void readCompanies() 
        {
            List<List<String>> allCompanies = textFiles.readTextFile(Constants.COMPANIES_PATH);
            
            companies.Clear();
            foreach(List<String> companyInfo in allCompanies) 
            {
                companies.Add(new Company(companyInfo));
            }
        }

        private void loadOurCompanies()
        {
            List<List<String>> ourCompaniesList = textFiles.readTextFile(Constants.OUR_COMPANIES_PATH);

            ourCompanies.Clear();
            foreach (List<String> companyInfo in ourCompaniesList)
            {
                ourCompanies.Add(new OurCompany(companyInfo));
            }
        }

        public string getOurCompany() 
        {
            loadOurCompanies();
            return ourCompanies.FirstOrDefault(comp => comp.CurrentlySelected == "true").Name;
        }

        public List<String> getCompanyNames(bool readFirst = false) 
        {
            //Check if we need to read the companies first before updating
            if (readFirst == true) readCompanies();

            List<String> companyNames = new List<string>();
            foreach (Company company in companies) 
            {
                companyNames.Add(company.Name);
            }
            return companyNames;
        }

        public List<string> getCompanyDetails(string name) 
        {
            if (name == "") return new Company().companyToList();
            return companies.FirstOrDefault(comp => comp.Name == name).companyToList();
        }

        //Works out the total amounts on the invoice
        void calculateTotals() 
        {
            receiptTotal = invoiceItems.Sum(item => item.TotalPrice);
            vat = (Constants.VAT_PERCENTAGE / 100) * receiptTotal;
            grandTotal = receiptTotal + vat;
        }

        public void addItem(string name, decimal quantity, decimal unitPrice) 
        {
            InvoiceItem newItem = new InvoiceItem(name, quantity, unitPrice);
            invoiceItems.Add(newItem);
            calculateTotals();
        }

        //We need to re-calcutate the total for each item if the ivoice gets edited.
        public void invoiceEdited() 
        {
            foreach (InvoiceItem item in invoiceItems) 
            {
                item.recalculateTotalPrice();
            }
            calculateTotals();
        }

        public void removeItem(int rowNumber) 
        {
            invoiceItems.RemoveAt(rowNumber);
            calculateTotals();
        }

        public void removeScopeItem(int rowNumber) 
        {
            scopeItems.RemoveAt(rowNumber);
        }

        public List<InvoiceItem> getInvoiceItems() 
        {
            return invoiceItems;
        }

        public decimal getVat() 
        {
            return vat;
        }

        public decimal getGrandTotal() 
        {
            return grandTotal;
        }

        public decimal getReceiptTotal() 
        {
            return receiptTotal;
        }

        public bool generateInvoice(string companyName, string ourCompanyName, bool quote, DateTime expiryDate, InvoiceFileInfo referenceFile, string PONumber) 
        {
            if (invoiceItems.Count == 0) return false;
            string date = DateTime.Now.ToString("dddd dd MMMM yyyy");
            string quoteInvoice = quoteOrInvoice(quote);

            string fileName = companyName + " " + date + " " + quoteInvoice;
           

            //Get company details based on user selection
            Company selectedCompany = companies.FirstOrDefault(comp => comp.Name == companyName);
            OurCompany ourCompany = ourCompanies.FirstOrDefault(comp => comp.Name == ourCompanyName);
            List<decimal> totals = new List<decimal> { receiptTotal, vat, grandTotal };
            string quoteInvoiceNumber;

            if (referenceFile == null) quoteInvoiceNumber = quoteOrInvoiceNumber(quote);
            else
            {
                quoteInvoiceNumber = referenceFile.Number;
                string refDate = referenceFile.Date.ToString(Constants.INVOICE_TEXTFILES_DATE_FORMAT);
                string previousInvoicePath = Constants.INVOICE_TEXT_FILES_PATH + refDate + " " + referenceFile.Company + " " + quoteInvoiceNumber + ".txt";

                File.Delete(previousInvoicePath);
            }

            PDF pdf = new PDF(fileName, quoteInvoiceNumber);
            pathToPreviousInvoiceQuote = pdf.createPDF(
                                            selectedCompany, 
                                            scopeItems, 
                                            invoiceItems, 
                                            totals, 
                                            ourCompany, 
                                            quoteInvoice,
                                            quoteInvoiceNumber,
                                            expiryDate,
                                            PONumber);


            createInvoiceFile(quoteInvoiceNumber, selectedCompany.Name, PONumber);
            return true;
        }

        public void createInvoiceFile(string invoiceNumber, string companyName, string poNumber) 
        {
            List<List<string>> invoiceFileItems = new List<List<string>>();
        
            invoiceFileItems.Add(new List<string> { poNumber });
            foreach (InvoiceItem item in invoiceItems) invoiceFileItems.Add(item.invoiceItemToList());
            foreach (ScopeItem item in scopeItems) invoiceFileItems.Add(item.scopeItemToList()); 

            string dateAndTime = DateTime.Now.ToString(Constants.INVOICE_TEXTFILES_DATE_FORMAT);
            string folder = Constants.INVOICE_TEXT_FILES_PATH + "\\" + Constants.CURRENT_MONTH_YEAR + "\\" + invoiceNumber + "\\";

            //Create the directory needed for the invoices.
            if (System.IO.Directory.Exists(folder) == false) { System.IO.Directory.CreateDirectory(folder); }

            string pathToFile = folder + dateAndTime + " " + companyName + " " + invoiceNumber + ".txt";
            bool createFile = true;
            textFiles.writeTextFile(pathToFile, invoiceFileItems, createFile);
        }

        private string quoteOrInvoice(bool invoice) 
        {
            return invoice == true ? "TAX INVOICE" : "QUOTE";
        }

        private string quoteOrInvoiceNumber(bool invoice) 
        {
            string pathToFile;
            string prefix;

            if (invoice == false) 
            { 
                pathToFile = Constants.QUOTE_NUMBER_PATH;
                prefix = "Q";
            }
            else 
            { 
                pathToFile = Constants.INVOICE_NUMBER_PATH;
                prefix = "INV";
            }

            List<List<string>> fileLines = textFiles.readTextFile(pathToFile);
            string storedDateAndMonth = fileLines[0][0].Substring(0, 6);
            string lastNumber = fileLines[0][0].Substring(6);
            int number = int.Parse(lastNumber) + 1;

            string currentDateAndMonth = DateTime.Now.ToString("MMyyyy");

            if (storedDateAndMonth != currentDateAndMonth) 
            { 
                storedDateAndMonth = currentDateAndMonth;
                number = 1;
            }

            fileLines[0][0] = storedDateAndMonth + number;
            textFiles.writeTextFile(pathToFile, fileLines);

            string quoteInvoiceNumber = prefix + storedDateAndMonth + number.ToString();
            return quoteInvoiceNumber;
        } 

        //Opens the folder where the newly generated invoice will be.
        public void showGeneratedInvoice()
        {
            //Open the folder where the new invoice has been created and stored.
            Process.Start(pathToPreviousInvoiceQuote);
        }

        public void clearReceipt() 
        {
            invoiceItems.Clear();
            scopeItems.Clear();
            receiptTotal = 0;
            vat = 0;
            grandTotal = 0;
    }

        public void addScopeItem(string scope, string description) 
        {
            ScopeItem newItem = new ScopeItem(scope, description);
            scopeItems.Add(newItem);
        }

        public List<ScopeItem> getScopeItems() 
        {
            return scopeItems;
        }

        public void recallInvoice(Object invoiceDataSource, Object scopeDataSource) 
        {
            clearReceipt();
            invoiceItems.Clear();
            scopeItems.Clear();
            invoiceItems = new List<InvoiceItem>((List<InvoiceItem>)invoiceDataSource);
            scopeItems = new List<ScopeItem>((List<ScopeItem>)scopeDataSource);

            calculateTotals();
        }
        
    }
}
