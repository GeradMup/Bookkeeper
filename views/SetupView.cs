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
        bool updatingCompanies = false;
        Color editingColour = Color.LightBlue;


        //************************************************************************************************************************
        //EVENT HANDLERS FOR THE SETUP TAB
        //************************************************************************************************************************
        private void OurCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            //There is no need to check if valid data has been inserted because the user does not type the data
            //So that means data selected will always be valid.
            if (updatingCompanies == true) return;
            if (OurCompanies.Text == "") return;
            setupController.companySelected(OurCompanies.Text);
            updateQuotingCompany();
        }

        private void OurCompanyEditButton_Click(object sender, EventArgs e)
        {
            newOurCompany = false;
            editingOurCompany = true;
            OurCompanyNewButton.Enabled = false;
            allowEditing();
        }

        private void OurCompanySubmitButton_Click(object sender, EventArgs e)
        {
            if (validInputs() == false) return;
            models.OurCompany ourCompany = new models.OurCompany();

            ourCompany.Name = OurCompanies.Text;
            ourCompany.VatNumber = OurCompanyVatNumber.Text;
            ourCompany.VendorNumber = OurCompanyVendorNumber.Text;
            ourCompany.LogoImage = OurCompanyLogo.Text;
            ourCompany.FooterImage = OurCompanyFooter.Text;
            ourCompany.Number = Int16.Parse(OurCompanyNumber.Text);

            if (editingOurCompany == true)
            {
                setupController.editOurCompany(ourCompany);
            }
            else if (newOurCompany == true)
            {
                setupController.addNewOurCompany(ourCompany);
            }

            disableEditingOurCompany();
            editingOurCompany = false;
            newOurCompany = false;
        }

        private void OurCompanyLogo_Enter(object sender, EventArgs e)
        {
            if (OurCompanyLogo.ReadOnly == true) return;
            string logoName = setupController.invoiceLogo(OurCompanyLogo.Text);
            OurCompanyLogo.Text = logoName;
            OurCompanyLogo.ReadOnly = true;
        }

        private void OurCompanyFooter_Enter(object sender, EventArgs e)
        {
            if (OurCompanyFooter.ReadOnly == true) return;
            string footerName = setupController.invoiceFooter(OurCompanyFooter.Text);
            OurCompanyFooter.Text = footerName;
            OurCompanyFooter.ReadOnly = true;
        }

        private void OurCompanyNewButton_Click(object sender, EventArgs e)
        {
            newOurCompany = true;
            editingOurCompany = false;
            OurCompanyEditButton.Enabled = false;
            clearOurCompanyInputFields();
            allowEditing();
        }

        private void OurCompanyCancelButton_Click(object sender, EventArgs e)
        {
            disableEditingOurCompany();
            newOurCompany = false;
            editingOurCompany = false;
            setupController.editingCancelled();
        }
        //*************************************************************************************************************************
        // END OF EVENT HANDLERS
        //*************************************************************************************************************************

        public void assignSetupController(SetupController controller)
        {
            setupController = controller;
        }

        public void populateCompaniesList(List<string> companyNames)
        {
            OurCompanies.Items.Clear();
            OurCompanies.Items.AddRange(companyNames.ToArray());
        }

        public void updateCompanyDetails(models.OurCompany ourCompany) 
        {
            updatingCompanies = true;
            OurCompanies.Text = ourCompany.Name;
            OurCompanyVatNumber.Text = ourCompany.VatNumber;
            OurCompanyVendorNumber.Text = ourCompany.VendorNumber;
            OurCompanyLogo.Text = ourCompany.LogoImage;
            OurCompanyFooter.Text = ourCompany.FooterImage;
            OurCompanyNumber.Text = ourCompany.Number.ToString();
            updatingCompanies = false;
        }

        public void setSelectedCompany(string name) 
        {
            OurCompanies.Text = name;
        }

        private void allowEditing(bool newCompany = false) 
        {
            OurCompanies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            OurCompanyVatNumber.ReadOnly = false;
            OurCompanyVendorNumber.ReadOnly = false;
            OurCompanyLogo.ReadOnly = false;
            OurCompanyFooter.ReadOnly = false;

            showEditingColours();
        }

        private void disableEditingOurCompany()
        {
            string currentlySelectedCompany = OurCompanies.Text;
            OurCompanies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            OurCompanies.Text = currentlySelectedCompany;
            OurCompanyVatNumber.ReadOnly = true;
            OurCompanyVendorNumber.ReadOnly = true;
            OurCompanyLogo.ReadOnly = true;
            OurCompanyFooter.ReadOnly = true;

            OurCompanyNewButton.Enabled = true;
            OurCompanyEditButton.Enabled = true;

            resetOurCompanyInputColours();
        }

        private void clearOurCompanyInputFields() 
        {
            OurCompanies.SelectedItem = null;
            OurCompanyVatNumber.Text = "";
            OurCompanyVendorNumber.Text = "";
            OurCompanyFooter.Text = "";
            OurCompanyLogo.Text = "";
        }

        private bool validInputs() 
        {
            showEditingColours();
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

        private void showEditingColours() 
        {
            OurCompanies.BackColor = editingColour;
            OurCompanyVatNumber.BackColor = editingColour;
            OurCompanyVendorNumber.BackColor = editingColour;
            OurCompanyLogo.BackColor = editingColour;
            OurCompanyFooter.BackColor = editingColour;
        }
    }
}
