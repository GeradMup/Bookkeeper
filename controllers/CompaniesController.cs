using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoices.src.DataObjects;
using Invoices.src.models;
using Invoices.src.views;

namespace Invoices.src.controllers
{

    public class CompaniesController
    {
        CompaniesModel companiesModel;
        MainWindow companiesView;
        
        public CompaniesController(CompaniesModel model, MainWindow view) 
        {
            companiesModel = model;
            companiesView = view;
            companiesView.assignSetupController(this);
            companiesView.populateBankNames(companiesModel.getBankNames());
            companiesView.populateCompaniesList(companiesModel.getOurCompanyNames());
            companiesView.setSelectedCompany(companiesModel.getSelectedCompany());
        }

        public void companySelected(string name) 
        {
            companiesView.updateCompanyDetails(companiesModel.getCompanyDetails(name));
        }

        public BankAccount getBankingDetails(string companyName) 
        {
            return companiesModel.getBankingDetails(companyName);
        }

        public string invoiceLogo(string currentLogo) 
        {
            return companiesModel.getLogoImageName(currentLogo);
        }

        public string invoiceFooter(string currentFooter) 
        {
            return companiesModel.getFooterImageName(currentFooter);
        }

        public void editOurCompany(OurCompany company) 
        {
            companiesModel.editOurCompany(company);
            companiesView.populateCompaniesList(companiesModel.getOurCompanyNames());
        }

        public void addNewOurCompany(OurCompany company) 
        {
            companiesModel.addNewOurCompany(company);
            companiesView.populateCompaniesList(companiesModel.getOurCompanyNames());
            companiesView.setSelectedCompany(companiesModel.getSelectedCompany());
        }

        public void editingCancelled() 
        {
            companiesView.populateCompaniesList(companiesModel.getOurCompanyNames());
            companiesView.setSelectedCompany(companiesModel.getSelectedCompany());
        }

        /// <summary>
        /// Edits the bank details.
        /// </summary>
        /// <param name="account">The account.</param>
        public void editBankDetails(BankAccount account) 
        {
            companiesModel.aditBankDetails(account);
        }
    }
}
