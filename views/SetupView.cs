using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoices.src.controllers;

namespace Invoices.src.views
{
    public partial class MainWindow
    {
        SetupController setupController;
        public void assignSetupController(SetupController controller) 
        {
            setupController = controller;
        }

        public void populateCompaniesList(List<string> companyNames) 
        {
            OurCompanies.Items.Clear();
            OurCompanies.Items.AddRange(companyNames.ToArray());
        }

        //************************************************************************************************************************
        //EVENT HANDLERS FOR THE SETUP TAB
        //************************************************************************************************************************
        private void OurCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            //There is no need to check if valid data has been inserted because the user does not type the data
            //So that means data selected will always be valid.
            setupController.companySelected(OurCompanies.Text);
            updateQuotingCompany();
        }

        private void OurCompanyEditButton_Click(object sender, EventArgs e)
        {
            allowEditing();
        }

        //*************************************************************************************************************************

        public void updateCompanyDetails(List<string> details) 
        {
            OurCompanyVatNumber.Text = details[1];
            OurCompanyVendorNumber.Text = details[2];
        }

        public void setSelectedCompany(string name) 
        {
            OurCompanies.Text = name;
        }

        private void allowEditing(bool newCompany = false) 
        {
            if (newCompany == true) 
            {
                clearOurCompanyInputFields();
            }

            OurCompanies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            OurCompanyVatNumber.ReadOnly = false;
            OurCompanyVendorNumber.ReadOnly = false;
        }

        private void clearOurCompanyInputFields() 
        {
            OurCompanies.SelectedItem = null;
            OurCompanyVatNumber.Text = "";
            OurCompanyVendorNumber.Text = "";
        }
    }
}
