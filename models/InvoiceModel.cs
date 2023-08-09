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
        List<ReceiptItem> invoiceItems = new List<ReceiptItem>();
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
            ReceiptItem newItem = new ReceiptItem(name, quantity, unitPrice);
            invoiceItems.Add(newItem);
            receiptTotal = invoiceItems.Sum(item => item.TotalPrice);
            vat = (Constants.VAT_PERCENTAGE/100) * receiptTotal;
            grandTotal = receiptTotal + vat;
        }

        public void clearReceipt() 
        {
            invoiceItems.Clear();
            receiptTotal = 0;
            vat = 0;
            grandTotal = 0;
        }

        public List<ReceiptItem> getInvoiceItems() 
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

        public void generateReceipt(string companyName) 
        {
            if (invoiceItems.Count == 0) return;
            string date = DateTime.Now.ToString("dddd dd MMMM yyyy");
            string fileName = companyName + " " + date;
            PDF pdf = new PDF(fileName);

            //pdf.createPDF();
        }
        
    }
}
