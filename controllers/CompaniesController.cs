using System;
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

        public void editCompanies() 
        {
            bool companiesUpdated = companiesModel.updateCompanies();
            if (companiesUpdated == true)
            {
                companiesWindow.populateCompaniesGrid(companiesModel.getCompanies());
                updatedInvoiceCompanies(true);  //This is a callback function from the Invoices Controller
            }
        }
    }
}
