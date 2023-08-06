using System;
using System.Collections.Generic;
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
    }
}
