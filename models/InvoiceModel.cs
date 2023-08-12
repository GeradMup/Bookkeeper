using System;
using System.Collections.Generic;
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
        List<InvoiceItem> invoiceItems = new List<InvoiceItem>();
        List<ScopeItem> scopeItems = new List<ScopeItem>();
        private decimal receiptTotal;
        private decimal vat;
        private decimal grandTotal;
        public InvoiceModel() 
        {
            textFiles = new TextFiles();
            // When the class is constructed, we need to read the csv files that contain all the information needed by the invoices tab

            //Create the list of companies
            
            
            //Read companies
            //MessageBox.Show(companiesPath);
            readCompanies();
            

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

        public void addItem(string name, decimal quantity, decimal unitPrice) 
        {
            InvoiceItem newItem = new InvoiceItem(name, quantity, unitPrice);
            invoiceItems.Add(newItem);
            receiptTotal = invoiceItems.Sum(item => item.TotalPrice);
            vat = (Constants.VAT_PERCENTAGE/100) * receiptTotal;
            grandTotal = receiptTotal + vat;
        }

        //We need to re-calcutate the total for each item if the ivoice gets edited.
        public void invoiceEdited() 
        {
            foreach (InvoiceItem item in invoiceItems) 
            {
                item.recalculateTotalPrice();
            }

            receiptTotal = invoiceItems.Sum(item => item.TotalPrice);
            vat = (Constants.VAT_PERCENTAGE / 100) * receiptTotal;
            grandTotal = receiptTotal + vat;
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

        public bool generateReceipt(string companyName) 
        {
            if (invoiceItems.Count == 0) return false;
            string date = DateTime.Now.ToString("dddd dd MMMM yyyy");
            string fileName = companyName + " " + date;
            PDF pdf = new PDF(fileName);

            //Get company details based on user selection
            Company selectedCompany = companies.FirstOrDefault(comp => comp.Name == companyName);

            List<decimal> totals = new List<decimal> { receiptTotal, vat, grandTotal };
            
            pdf.createPDF(selectedCompany, scopeItems, invoiceItems, totals);
            return true;
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
        
    }
}
