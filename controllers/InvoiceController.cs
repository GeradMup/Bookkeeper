using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoices.src.models;
using Invoices.src.views;

namespace Invoices.src.controllers
{
    /// <summary>
    /// This partial class of main controller will handle everything to do with the invoices tab
    /// </summary>
    public class InvoiceController
    {
     
        List<string> items;
        MainWindow invoiceView;
        InvoiceModel invoiceModel;


        public InvoiceController(MainWindow invoiceTab, InvoiceModel invoiceModel_) 
        {
            invoiceModel = invoiceModel_;
            invoiceView = invoiceTab;
            
        }

        //public delegate void UpdateCompanies(bool readFirst);

        public Action<bool> getCallBack() 
        {
            return updateCompanies;
        }

        public void updateCompanies(bool readFirst = false) 
        {
            invoiceView.populateCompanies(invoiceModel.getCompanyNames(readFirst));
        }

        public void initializeInvoice() 
        {
            items = new List<string>() {"Sugar", "Salt", "Beans", "Bananas", "Apples"};

            invoiceView.assignInvoiceController(this);
            updateCompanies();
            invoiceView.populateItems(items);
            invoiceView.initializeReceipt();
        }

        public void itemChanged(string itemName) 
        {
            decimal price = 0.0M;
            if (itemName == items[0]) price = 2.3M;
            else if (itemName == items[1]) price = 4.5M;
            else if (itemName == items[2]) price = 30.5M;
            else if (itemName == items[3]) price = 25.5M;
            else if (itemName == items[4]) price = 12.5M;

            invoiceView.changeUnitPrice(price);
        }

        public void quantityChanged(decimal quantity, decimal price) 
        {
            decimal totalAmount = 0.0M;
            totalAmount = quantity * price;
            invoiceView.changeTotalPrice(totalAmount);
        }

        public void addItem(string itemName, decimal quantity, decimal unitPrice) 
        {
            invoiceModel.addItem(itemName, quantity, unitPrice);
            invoiceView.populateItemsGrid(invoiceModel.getInvoiceItems());
            invoiceView.updateReceiptTotals(invoiceModel.getReceiptTotal(), invoiceModel.getVat(), invoiceModel.getGrandTotal());
        }

        public void clearReceipt() 
        {
            invoiceModel.clearReceipt();
            invoiceView.populateItemsGrid(invoiceModel.getInvoiceItems());
            invoiceView.updateReceiptTotals(invoiceModel.getReceiptTotal(), invoiceModel.getVat(), invoiceModel.getGrandTotal());
        }

        public void generateInvoice(string companyName) 
        {
            bool generated = invoiceModel.generateReceipt(companyName);
            if (generated == true) 
            {
                invoiceModel.clearReceipt();
                invoiceView.populateItemsGrid(invoiceModel.getInvoiceItems());
                invoiceView.populateScopeGrid(invoiceModel.getScopeItems());
                invoiceView.updateReceiptTotals(invoiceModel.getReceiptTotal(), invoiceModel.getVat(), invoiceModel.getGrandTotal());
                invoiceView.showSuccess();
                return;
            }

        }

        public void addScopeItem(string scope, string description) 
        {
            invoiceModel.addScopeItem(scope, description);
            invoiceView.populateScopeGrid(invoiceModel.getScopeItems());
        }

    }
}
