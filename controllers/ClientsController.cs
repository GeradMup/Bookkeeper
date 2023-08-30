using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoices.src.views;
using Invoices.src.models;

namespace Invoices.src.controllers
{
    public class ClientsController
    {
        ClientsModel clientsModel;
        MainWindow companiesWindow;
        Action<bool> updatedInvoiceCompanies;   //This is a callback function from the InvoiceController.

        public ClientsController(ClientsModel model, MainWindow window, Action<bool> invCompanies) 
        {
            updatedInvoiceCompanies = invCompanies;
            clientsModel = model;
            companiesWindow = window;
            initializeCompanies();
        }

        private void initializeCompanies() 
        {
            companiesWindow.assignclientsController(this);
            companiesWindow.populateCompaniesGrid(clientsModel.getCompanies());
        }

        public void editCompanies(int number, List<string> companyinfo) 
        {
            bool companiesUpdated = clientsModel.updateCompanies(number, companyinfo);
            if (companiesUpdated == true)
            {
                bool readFirst = true;
                companiesWindow.populateCompaniesGrid(clientsModel.getCompanies(readFirst));
                updatedInvoiceCompanies(readFirst);  //This is a callback function from the Invoices Controller
            }
        }

        public void addCompany(List<string> companyinfo) 
        {
            clientsModel.addCompany(companyinfo);
            bool readFirst = true;
            companiesWindow.populateCompaniesGrid(clientsModel.getCompanies(readFirst));
            updatedInvoiceCompanies(readFirst);
        }

        public void deleteCompany(int number) 
        {
            clientsModel.deleteCompany(number);
            bool readFirst = true;
            companiesWindow.populateCompaniesGrid(clientsModel.getCompanies(readFirst));
            updatedInvoiceCompanies(readFirst);
        }
    }
}
