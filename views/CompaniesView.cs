using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invoices.src.controllers;
using Invoices.src.DataObjects;
using Invoices.src.models;

namespace Invoices.src.views
{
    public partial class MainWindow
    {
        CompaniesController setupController;
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
            try
            {
                if (validInputs() == false) return;
                OurCompany ourCompany = new OurCompany();

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
            catch (Exception exception) 
            {
                showErrorMessage(exception.Message);
            }
        }

        private void OurCompanyLogo_Enter(object sender, EventArgs e)
        {
            try
            {
                if (OurCompanyLogo.ReadOnly == true) return;
                string logoName = setupController.invoiceLogo(OurCompanyLogo.Text);
                OurCompanyLogo.Text = logoName;
                OurCompanyLogo.ReadOnly = true;
            }
            catch (Exception exception) 
            {
                showErrorMessage(exception.Message);
            }
        }

        private void OurCompanyFooter_Enter(object sender, EventArgs e)
        {
            try 
            { 
                if (OurCompanyFooter.ReadOnly == true) return;
                string footerName = setupController.invoiceFooter(OurCompanyFooter.Text);
                OurCompanyFooter.Text = footerName;
                OurCompanyFooter.ReadOnly = true;
            }
            catch (Exception exception) 
            {
                showErrorMessage(exception.Message);
            }
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

        /// <summary>
        /// Handles the Click event of the BankDetailsNewButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BankDetailsNewButton_Click(object sender, EventArgs e)
        {
//            BankAccount account = new BankAccount();
//            setupController.editBankDetails(account);
            clearBankDetailsFields();   //Clear all the fields if we are trying to add new banking details.    
            editBankDetails(true);      //Activate the banking details fields so that they are editable.
        }

        /// <summary>
        /// Handles the Click event of the BankDetailsSaveButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BankDetailsSaveButton_Click(object sender, EventArgs e)
        {
            string accountHolderError = "Please enter a valid Account Holder Name!";
            string bankNameError = "Please enter a valid Bank Name!";
            string bankBranchError = "Please enter a valid Bank Branch Name!";
            string bankBranchCodeError = "Please enter a valid Bank Branch Code!";
            string bankAccountError = "Please enter a valid Bank Account Number!";
            string companyNameError = "Please select a company to assign the account details to!";

            if (BankAccountHolder.Text.Trim() == "") { showErrorMessage(accountHolderError); return; }
            if (BankName.Text.Trim() == "") { showErrorMessage(bankNameError); return; }
            if (BankBranch.Text.Trim() == "") { showErrorMessage(bankBranchError); return; }
            if (BankBranchCode.Text.Trim() == "") { showErrorMessage(bankBranchCodeError); return; }
            if (BankAccountNumber.Text.Trim() == "") { showErrorMessage(bankAccountError); return; }
            if (OurCompanies.Text.Trim() == "") { showErrorMessage(companyNameError); return; }
            
            BankAccount account = new BankAccount();
            account.AccountHolder = BankAccountHolder.Text;
            account.BankName = BankName.Text;
            account.BranchCode = BankBranchCode.Text;
            account.BranchName = BankBranch.Text;
            account.AccountNumber = BankAccountNumber.Text;
            account.Company = OurCompanies.Text;
            try
            {
                string bankDetailsUpdated = "Bank details have been successfully updated!";
                setupController.editBankDetails(account);
                showSuccessMessage(bankDetailsUpdated);
                editBankDetails(false);
            }
            catch (Exception ex) 
            {
                showErrorMessage(ex.Message);
            }
            
        }

        /// <summary>
        /// Handles the click event of the BankDetailsCancelButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BankDetailsCancelButton_Click(object sender, EventArgs e)
        {
            editBankDetails(false);
            setSelectedCompany(OurCompanies.Text);
        }

        /// <summary>
        /// Handles the KeyPress event of the BankBranchCode control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void BankBranchCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only accept numeric values in the Bank Branch Code field
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        /// <summary>
        /// Handles the KeyPress event of the BankAccountNumber control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void BankAccountNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only accept numeric values in the Bank Account Number field
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        //*************************************************************************************************************************
        // END OF EVENT HANDLERS
        //*************************************************************************************************************************

        public void assignSetupController(CompaniesController controller)
        {
            setupController = controller;
        }

        /// <summary>
        /// Populates the bank names.
        /// </summary>
        /// <param name="bankNames">The bank names.</param>
        public void populateBankNames(string[] bankNames) 
        {
            BankName.Items.AddRange(bankNames);
        }

        public void populateCompaniesList(List<string> companyNames)
        {
            OurCompanies.Items.Clear();
            OurCompanies.Items.AddRange(companyNames.ToArray());
        }

        public void updateCompanyDetails(OurCompany ourCompany) 
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
            BankAccount account = setupController.getBankingDetails(name);
            if (account != null) 
            {
                BankAccountHolder.Text = account.AccountHolder;
                BankAccountNumber.Text = account.AccountNumber;
                BankBranch.Text = account.BranchName;
                BankBranchCode.Text = account.BranchCode;
                BankName.Text = account.BankName;
            }
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

        /// <summary>
        /// Enables or disables the editing of banking details on the Companies Tab.
        /// </summary>
        /// <param name="editing">if set to <c>true</c> [editing].</param>
        private void editBankDetails(bool editing) 
        {
            BankAccountHolder.ReadOnly = !editing;
            BankAccountNumber.ReadOnly = !editing;
            BankBranch.ReadOnly = !editing;
            BankBranchCode.ReadOnly = !editing;
            //BankName.ReadOnly = !editing;
        }

        /// <summary>
        /// Clears the bank details fields.
        /// </summary>
        private void clearBankDetailsFields() 
        {
            BankAccountHolder.Clear();
            BankAccountNumber.Clear();
            BankBranch.Clear();
            BankBranchCode.Clear();
            //BankName.Clear();
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
