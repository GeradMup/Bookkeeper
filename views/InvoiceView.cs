using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invoices.src.controllers;

namespace Invoices.src.views
{
    public partial class MainWindow
    {
        InvoiceController invoiceController;
        Color errorColour = Color.LightPink;

        public void initializeReceipt() 
        {
            ReceiptGrandTotal.Controls[0].Visible = false;
            ReceiptTotal.Controls[0].Visible = false;
            ReceiptVat.Controls[0].Visible = false;
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
            InvoiceItemsGrid.Columns[0].FillWeight = 8;
            InvoiceItemsGrid.Columns[1].FillWeight = 2;
            InvoiceItemsGrid.Columns[2].FillWeight = 3;
            InvoiceItemsGrid.Columns[3].FillWeight = 3.5F;

            InvoiceItemsGrid.Columns[2].DefaultCellStyle.Format = "#,0.###";
            InvoiceItemsGrid.Columns[3].DefaultCellStyle.Format = "#,0.###";

            InvoiceItemsGrid.Columns[3].ReadOnly = true;
        }

        public void populateScopeGrid<T>(List<T> gridData)
        {
            ScopeGrid.DataSource = null;
            if (gridData.Count == 0) return;
           
            ScopeGrid.DataSource = gridData;
            ScopeGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ScopeGrid.Columns[0].FillWeight = 1;
            ScopeGrid.Columns[1].FillWeight = 4;

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
        }

        private void clearReceiptInputs() 
        {
            //CompanyList.Text = "";
            ItemsList.Text = "";
            Quantity.Value = 0;
            UnitPrice.Value = 0;
            //InvoiceExpiryDate.Value = DateTime.Now;
        }

        private void ClearReceiptButton_Click(object sender, EventArgs e)
        {
            invoiceController.clearReceipt();
            CompanyList.SelectedItem = null;
            InvoiceExpiryDate.Value = DateTime.Now;
            resetReceiptInputsColours();
            ScopeGrid.DataSource = null;
            InvoiceItemsGrid.DataSource = null;
        }

        private void GenerateInvoiceButton_Click(object sender, EventArgs e)
        {
            resetReceiptInputsColours();
            if (CompanyList.Text == "") { CompanyList.BackColor = errorColour; return; }
            if (InvoiceItemsGrid.RowCount == 0) { InvoiceItemsGrid.BackgroundColor = errorColour; return; }
            if (ScopeGrid.RowCount == 0) { ScopeGrid.BackgroundColor = errorColour; return; }

            invoiceController.generateInvoice(CompanyList.Text);
            CompanyList.SelectedItem = null;
        }

        public void showSuccess() 
        {
            
            foreach (Control control in Invoices.Controls) 
            {
                if (control.Name == "InvoiceItemsGrid" || control.Name == "ScopeGrid") { } //Do nothing
                else control.Enabled = false;
                
            }
            SuccessPanel.Visible = true;
            SuccessPanel.Enabled = true;
            //SuccessPanel
        }

        private void SuccessOkButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in Invoices.Controls)
            {
                if (control.Name == "InvoiceItemsGrid" || control.Name == "ScopeGrid") { } //Do nothing
                else control.Enabled = true;
            }
            SuccessPanel.Visible = false;
            SuccessPanel.Visible = false;
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

        private void InvoiceItemsGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
            MessageBox.Show("Incorrect Value. Please enter a number!");
        }

        private void InvoiceItemsGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (InvoiceItemsGrid.CurrentCell.Value.ToString() == "") 
            {
                MessageBox.Show("Incorrect Value. Please enter a number!");
                return;
            }

            invoiceController.invoiceEdited();
        }
    }
}
