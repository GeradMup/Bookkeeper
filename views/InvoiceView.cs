﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invoices.src.controllers;
using Invoices.src.DataObjects;

namespace Invoices.src.views
{
    public partial class MainWindow
    {
        InvoiceController invoiceController;
        Color errorColour = Color.LightPink;
        Object previousCellValue = null;
        Object previousScopeCellValue = null;
        InvoiceFileInfo referenceInvoiceInfo = null;

        public void initializeReceipt() 
        {
            ReceiptGrandTotal.Controls[0].Visible = false;
            ReceiptTotal.Controls[0].Visible = false;
            ReceiptVat.Controls[0].Visible = false;
            InvoiceCheckbox.Checked = false;
        }

        public void updateQuotingCompany(string companyName = "") 
        {
            if (companyName == "") { invoiceController.ourCompanyChanged(); return; }
            QuotingCompany.Text = companyName;
        }

        public void assignInvoiceController(InvoiceController controller)
        {
            invoiceController = controller;
        }

        public void populateCompanies(List<string> companyNames)
        {
            CompanyList.Items.Clear();
            CompanyList.Items.AddRange(companyNames.ToArray<object>());
        }

        public void populateItems(List<string> itemNames)
        {
            ItemsList.Items.AddRange(itemNames.ToArray<object>());
        }

        //Updates the unit price currently being displayed
        public void changeUnitPrice(decimal price)
        {
            UnitPrice.Value = price;
        }

        //Updates the total amount currently being displayed
        public void changeTotalPrice(decimal price)
        {
            TotalPrice.Value = price;
        }

        //What happens when the selected company changes.
        private void CompanyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            invoiceController.recipientChanged(CompanyList.Text);
        }

        public void updateRecipientDetails(List<string> companyInfo) 
        {
            string colon = ": ";
            RecipientName.Text = colon + companyInfo[1];
            RecipientAddress.Text = colon + companyInfo[2];
            RecipientVat.Text = colon + companyInfo[3];
            RecipientTown.Text = colon + companyInfo[4];
            RecipientZipCode.Text = colon + companyInfo[5];
            RecipientRepresentative.Text = colon + companyInfo[6];
            RecipientTitle.Text = colon + companyInfo[7];
            RecipientNumbers.Text = colon + companyInfo[8];
            RecipientEmail.Text = colon + companyInfo[9];
        }

        //What happens when the selected item changes
        private void ItemsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            invoiceController.itemChanged(ItemsList.Text);
        }

        //What happens when the quantity changes
        private void Quantity_ValueChanged(object sender, EventArgs e)
        {
            invoiceController.quantityChanged(Quantity.Value, UnitPrice.Value);
        }

        //What happens when the unit price changes
        private void UnitPrice_ValueChanged(object sender, EventArgs e)
        {
            invoiceController.quantityChanged(Quantity.Value, UnitPrice.Value);
        }

        private void UnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {

            // invoiceController.quantityChanged(Quantity.Value, UnitPrice.Value);
        }

        public void populateItemsGrid<T>(List<T> gridData)
        {
            InvoiceItemsGrid.DataSource = null;
            if (gridData.Count == 0) return;
            
            InvoiceItemsGrid.DataSource = gridData;
            InvoiceItemsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InvoiceItemsGrid.Columns[0].FillWeight = 8;     //Description
            InvoiceItemsGrid.Columns[1].FillWeight = 2;     //Quantity
            InvoiceItemsGrid.Columns[2].FillWeight = 3;     //Unit Price
            InvoiceItemsGrid.Columns[3].FillWeight = 3.5F;  //Total Price

            InvoiceItemsGrid.Columns[2].DefaultCellStyle.Format = "#,0.###";    //String formatted to comma seperate thousands
            InvoiceItemsGrid.Columns[3].DefaultCellStyle.Format = "#,0.###";

            InvoiceItemsGrid.Columns[3].ReadOnly = true;

            InvoiceItemsGrid.ClearSelection();
        }

        public void populateScopeGrid<T>(List<T> gridData)
        {
            ScopeGrid.DataSource = null;
            if (gridData.Count == 0) return;
           
            ScopeGrid.DataSource = gridData;
            ScopeGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ScopeGrid.Columns[0].FillWeight = 1;
            ScopeGrid.Columns[1].FillWeight = 4;
            ScopeGrid.ClearSelection();
        }


        public void  updateReceiptTotals(decimal totalExVat, decimal Vat, decimal grandTotal) 
        {
            ReceiptTotal.Value = totalExVat;
            ReceiptVat.Value = Vat;
            ReceiptGrandTotal.Value = grandTotal;
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            if (!validInvoiceItemInputs()) return;

            invoiceController.addItem(ItemsList.Text, Quantity.Value, UnitPrice.Value);
            clearReceiptInputs();
        }

        private bool validInvoiceItemInputs() 
        {
            resetReceiptInputsColours();
            if(ItemsList.Text == "") { ItemsList.BackColor = errorColour; return false; }
            if(Quantity.Value == 0) { Quantity.BackColor = errorColour; return false; }
            if(UnitPrice.Value == 0) { UnitPrice.BackColor = errorColour; return false; }

            return true;
        }

        private void resetReceiptInputsColours() 
        {
            CompanyList.BackColor = Color.White;
            ItemsList.BackColor = Color.White;
            Quantity.BackColor = Color.White;
            UnitPrice.BackColor = Color.White;
            InvoiceItemsGrid.BackgroundColor = Color.White;
            ScopeGrid.BackgroundColor = Color.White;
            Scope.BackColor = Color.White;
            ScopeDescription.BackColor = Color.White;
            InvoiceExpiryDate.CalendarForeColor = Color.White;
        }

        private void clearReceiptInputs() 
        {
            //CompanyList.Text = "";
            ItemsList.Text = "";
            Quantity.Value = 0;
            UnitPrice.Value = 0;
            InvoiceCheckbox.Checked = false;
   
            //InvoiceExpiryDate.Value = DateTime.Now;
            RefInvoice.Text = "";
            //InvoiceExpiryDate.Value = DateTime.Now;
        }

        private void ClearReceiptButton_Click(object sender, EventArgs e)
        {
            string warningMessage = "Are you sure you want to clear the receipt?";
            DialogResult dialogResult = CustomMessageBox.Show(this, warningMessage, MessageType.SevereWarning);

            if (dialogResult == DialogResult.No) return; 

            invoiceController.clearReceipt();
            CompanyList.SelectedItem = null;
            InvoiceExpiryDate.Value = DateTime.Now;
            resetReceiptInputsColours();
            ScopeGrid.DataSource = null;
            InvoiceItemsGrid.DataSource = null;
        }

        private void GenerateInvoiceButton_Click(object sender, EventArgs e)
        {
            try
            {
                resetReceiptInputsColours();
                if (CompanyList.Text == "") { CompanyList.BackColor = errorColour; return; }
                if (InvoiceExpiryDate.Value.ToString(models.Constants.DATE_FORMAT) == DateTime.Now.ToString(models.Constants.DATE_FORMAT))
                {
                    string error = "Please pick a valid expiry date!";
                    showErrorMessage(error);
                    return;
                }

                if (InvoiceItemsGrid.RowCount == 0) { InvoiceItemsGrid.BackgroundColor = errorColour; return; }
                if (ScopeGrid.RowCount == 0) { ScopeGrid.BackgroundColor = errorColour; return; }

                InvoiceFileInfo refInvoiceFile = null;
                if (referenceInvoiceInfo != null)
                {
                    string message = $"Would you like to re-use the invoice/quote number {referenceInvoiceInfo.Number}";
                    if (warningConfirmation(message) == true) refInvoiceFile = referenceInvoiceInfo;
                }

                string PONumber = "";

                if (InvoiceCheckbox.Checked == true) 
                {
                    if (InvoicePoNumber.Text.Trim() == "")
                    {
                        string warningMessage = "Please insert a PO Number!";
                        CustomMessageBox.Show(this, warningMessage, MessageType.MildWarning);
                        return;
                    }
                    else 
                    {
                        PONumber = InvoicePoNumber.Text;
                    }
                }

                invoiceController.generateInvoice(CompanyList.Text, QuotingCompany.Text, InvoiceCheckbox.Checked, InvoiceExpiryDate.Value, refInvoiceFile, PONumber);
                CompanyList.SelectedItem = null;
                clearReceiptInputs();
                InvoiceExpiryDate.Value = DateTime.Now;
                referenceInvoiceInfo = null;
            }
            catch (Exception exception) 
            {
                showErrorMessage(exception.Message);
            }
        }
        public void showSuccess() 
        {
            string message = "You invoice has been generated successfully!";
            showSuccessMessage(message);

            //disableAllControlls();
            //SuccessPanel.Visible = true;
            //SuccessPanel.Enabled = true;
            //SuccessPanel

            enableAllControls();
            invoiceController.invoiceGenerationCompleted();
            newInvoiceAdded();
        }

        private void SuccessOkButton_Click(object sender, EventArgs e)
        {
            enableAllControls();
            invoiceController.invoiceGenerationCompleted();
            newInvoiceAdded();      //This is a function in the histories views.      
        }

        private void AddScopeButton_Click(object sender, EventArgs e)
        {
            resetReceiptInputsColours();
            if (Scope.Text == "") { Scope.BackColor = errorColour; return; }
            if (ScopeDescription.Text == "") { ScopeDescription.BackColor = errorColour; return; }

            invoiceController.addScopeItem(Scope.Text, ScopeDescription.Text);
            resetScope();
        }

        private void resetScope() 
        {
            Scope.Text = "";
            ScopeDescription.Text = "";
        }

        private void incorrectDataError(string errorMessage = "Incorrect Data!") 
        {
            showErrorMessage(errorMessage);
        }

        private void InvoiceItemsGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            incorrectDataError();
        }

        private void InvoiceItemsGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string inputData = "";

            if (InvoiceItemsGrid.CurrentCell.Value != null)
            {
                inputData = InvoiceItemsGrid.CurrentCell.Value.ToString().Trim();
                if (inputData == "")
                {
                    incorrectDataError();
                    InvoiceItemsGrid.CurrentCell.Value = previousCellValue;
                    return;
                }
                else
                {
                    invoiceController.invoiceEdited();
                }
            }

            else 
            {
                incorrectDataError();
                InvoiceItemsGrid.CurrentCell.Value = previousCellValue;
            }
            
        }

        private void InvoiceItemsGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            previousCellValue = InvoiceItemsGrid.CurrentCell.Value;
        }

        private void ScopeGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            previousScopeCellValue = ScopeGrid.CurrentCell.Value;
        }

        private void ScopeGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (ScopeGrid.CurrentCell.Value == null) 
            {
                ScopeGrid.CurrentCell.Value = previousScopeCellValue;
                incorrectDataError();
                return; 
            }

            if (ScopeGrid.CurrentCell.Value.ToString().Trim() == "")
            {
                ScopeGrid.CurrentCell.Value = previousScopeCellValue;
                incorrectDataError();
                return;
            }
        }

        private void ScopeGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            incorrectDataError();
        }

        private void InvoiceItemsOptions_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(InvoiceItemsGrid.RowCount == 0) { return; }
            invoiceController.removeInvoiceItem(InvoiceItemsGrid.CurrentCell.RowIndex);
        }

        private void ScopeItemsOptions_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (ScopeGrid.RowCount == 0) { return; }
            invoiceController.removeScopeItem(ScopeGrid.CurrentCell.RowIndex);
        }


        //When we are showing the progress bar or the sucess message box, we would like disable the rest of the controls.
        void disableAllControlls() 
        {
            foreach (Control control in Invoices.Controls)
            {
                if (control.Name == "InvoiceItemsGrid" || control.Name == "ScopeGrid") { } //Do nothing
                else control.Enabled = false;
            }
        }

        void enableAllControls() 
        {
            foreach (Control control in Invoices.Controls)
            {
                if (control.Name == "InvoiceItemsGrid" || control.Name == "ScopeGrid") { } //Do nothing
                else control.Enabled = true;
            }
        }

        public void showLoadingCursor() 
        {
            disableAllControlls();
            Cursor = Cursors.WaitCursor;
        }

        public void showNormalCursor() 
        {
            Cursor = Cursors.Default;
            enableAllControls();
        }

        private void ItemsList_Enter(object sender, EventArgs e)
        {
            resetReceiptInputsColours();
        }

        private void referenceInvoice(Object invoiceDataSource, Object scopeDataSource, InvoiceFileInfo invoiceInfo, string poNumber) 
        {

            referenceInvoiceInfo = invoiceInfo;
            RefInvoice.Text = "Reference Invoice/Quote Number : " + invoiceInfo.Number;

            invoiceController.referenceInvoice(invoiceDataSource, scopeDataSource);
            showSuccessMessage("You data has been copied!");
            Tabs.SelectedTab = Invoices; //Change to the invoice tab

            if (poNumber != "") 
            {
                InvoicePoNumber.Visible = true;
                InvoicePoNumberLabel.Visible = true;
                InvoicePoNumber.Text = poNumber;
            }
        }

        private void InvoiceCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (InvoiceCheckbox.Checked == true)
            {
                InvoiceQuoteToggleLabel.Text = "INVOICE";

                InvoicePoNumber.Visible = true;
                InvoicePoNumberLabel.Visible = true;
                
            }
            else 
            {
                InvoiceQuoteToggleLabel.Text = "QUOTE";

                InvoicePoNumber.Visible = false;
                InvoicePoNumberLabel.Visible = false;
                
            }
            
        }
    }
}
