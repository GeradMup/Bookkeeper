using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Invoices.src.controllers;

namespace Invoices.src.models
{
    public class InvoiceModel
    {
//        InvoiceController invoiceController;
        TextFiles textFiles;
        List<Company> companies = new List<Company>();
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
    }
}
