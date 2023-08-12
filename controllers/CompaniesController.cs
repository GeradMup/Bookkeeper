﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoices.src.views;
using Invoices.src.models;

namespace Invoices.src.controllers
{
    public class CompaniesController
    {
        CompaniesModel companiesModel;
        MainWindow companiesWindow;
        Action<bool> updatedInvoiceCompanies;   //This is a callback function from the InvoiceController.

        public CompaniesController(CompaniesModel model, MainWindow window, Action<bool> invCompanies) 
        {
            updatedInvoiceCompanies = invCompanies;
            companiesModel = model;
            companiesWindow = window;
            initializeCompanies();
        }

        private void initializeCompanies() 
        {
            companiesWindow.assignCompaniesController(this);
            companiesWindow.populateCompaniesGrid(companiesModel.getCompanies());
        }

        public void editCompanies(int number, List<string> companyinfo) 
        {
            bool companiesUpdated = companiesModel.updateCompanies(number, companyinfo);
            if (companiesUpdated == true)
            {
                bool readFirst = true;
                companiesWindow.populateCompaniesGrid(companiesModel.getCompanies(readFirst));
                updatedInvoiceCompanies(readFirst);  //This is a callback function from the Invoices Controller
            }
        }

        public void addCompany(List<string> companyinfo) 
        {
            companiesModel.addCompany(companyinfo);
            bool readFirst = true;
            companiesWindow.populateCompaniesGrid(companiesModel.getCompanies(readFirst));
            updatedInvoiceCompanies(readFirst);
        }

        public void deleteCompany(int number) 
        {
            companiesModel.deleteCompany(number);
            bool readFirst = true;
            companiesWindow.populateCompaniesGrid(companiesModel.getCompanies(readFirst));
            updatedInvoiceCompanies(readFirst);
        }
    }
}
