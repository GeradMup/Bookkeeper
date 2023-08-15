using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoices.src.controllers;

namespace Invoices.src.views
{
    public partial class MainWindow
    {
        SetupController setupController;
        bool newOurCompany = false;
        bool editingOurCompany = false;
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
            newOurCompany = false;
            editingOurCompany = true;
            allowEditing();
        }

        //*************************************************************************************************************************

        public void updateCompanyDetails(List<string> details) 
        {
            OurCompanyVatNumber.Text = details[1];
            OurCompanyVendorNumber.Text = details[2];
            OurCompanyLogo.Text = details[4];
            OurCompanyFooter.Text = details[5];
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
            OurCompanyLogo.ReadOnly = false;
            OurCompanyFooter.ReadOnly = false;
        }

        private void disableEditingOurCompany()
        {
            OurCompanies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            OurCompanyVatNumber.ReadOnly = true;
            OurCompanyVendorNumber.ReadOnly = true;
            OurCompanyLogo.ReadOnly = true;
            OurCompanyFooter.ReadOnly = true;
        }


        private void clearOurCompanyInputFields() 
        {
            OurCompanies.SelectedItem = null;
            OurCompanyVatNumber.Text = "";
            OurCompanyVendorNumber.Text = "";
            OurCompanyFooter.Text = "";
            OurCompanyLogo.Text = "";
        }

        private void OurCompanySubmitButton_Click(object sender, EventArgs e)
        {
            if(validInputs() == false) return;
            models.OurCompany ourCompany = new models.OurCompany();
            
            ourCompany.Name = OurCompanies.Text;
            ourCompany.VatNumber = OurCompanyVatNumber.Text;
            ourCompany.VendorNumber = OurCompanyVendorNumber.Text;
            ourCompany.LogoImage = OurCompanyLogo.Text;
            ourCompany.FooterImage = OurCompanyFooter.Text;
            
            if (editingOurCompany == true)
            {
                setupController.editOurCompany(ourCompany);   
            }
            else if (newOurCompany == true) 
            {
                
            }
            disableEditingOurCompany();


            editingOurCompany = false;
            newOurCompany = false;
        }

        private bool validInputs() 
        {
            resetOurCompanyInputColours();
            if (OurCompanies.Text == "") { OurCompanies.BackColor = errorColour; return false; }
            if (OurCompanyVatNumber.Text == "") { OurCompanyVatNumber.BackColor = errorColour; return false; }
            if (OurCompanyVendorNumber.Text == "") { OurCompanyVendorNumber.BackColor = errorColour; return false; }
            if (OurCompanyLogo.Text == "") { OurCompanyLogo.BackColor = errorColour; return false; }
            if (OurCompanyFooter.Text == "") { OurCompanyFooter.BackColor = errorColour; return false; }
            return true;
        }

        private void resetOurCompanyInputColours() 
        {
            OurCompanies.BackColor = Color.White;
            OurCompanyVatNumber.BackColor = Color.White;
            OurCompanyVendorNumber.BackColor = Color.White;
            OurCompanyLogo.BackColor = Color.White;
            OurCompanyFooter.BackColor = Color.White;
        }


        private void OurCompanyLogo_Enter(object sender, EventArgs e)
        {
            string logoName = setupController.invoiceLogo(OurCompanyLogo.Text);
            OurCompanyLogo.Text = logoName;
            OurCompanyLogo.ReadOnly = true;
        }

        private void OurCompanyFooter_Enter(object sender, EventArgs e)
        {
            string footerName = setupController.invoiceFooter(OurCompanyFooter.Text);
            OurCompanyFooter.Text = footerName;
            OurCompanyFooter.ReadOnly = true;
        }
    }
}
