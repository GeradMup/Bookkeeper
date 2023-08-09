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
            InvoiceItemsGrid.DataSource = gridData;
            InvoiceItemsGrid.Columns[0].FillWeight = 8;
            InvoiceItemsGrid.Columns[1].FillWeight = 2;
            InvoiceItemsGrid.Columns[2].FillWeight = 3;
            InvoiceItemsGrid.Columns[3].FillWeight = 3.5F;
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
            CompanyList.Text = "";
            InvoiceExpiryDate.Value = DateTime.Now;
            resetReceiptInputsColours();
        }

        private void GenerateInvoiceButton_Click(object sender, EventArgs e)
        {
            resetReceiptInputsColours();
            if (CompanyList.Text == "") { CompanyList.BackColor = errorColour; return; }

            invoiceController.generateInvoice(CompanyList.Text);
        }
    }
}
