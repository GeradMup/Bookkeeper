﻿using System;
using System.Collections.Generic;
using Invoices.src.DataObjects;
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

            invoiceView.assignInvoiceController(this);
            invoiceView.initializeReceipt();
            string companyName = "";
            invoiceView.updateRecipientDetails(invoiceModel.getCompanyDetails(companyName));
            updateCompanies();
        }

        //public delegate void UpdateCompanies(bool readFirst);

        public Action<bool> getCallBack() 
        {
            return updateCompanies;
        }

        public void updateCompanies(bool readFirst = false) 
        {
            invoiceView.populateCompanies(invoiceModel.getCompanyNames(readFirst));
            invoiceView.updateQuotingCompany(invoiceModel.getOurCompany());
        }

        public void ourCompanyChanged() 
        {
            invoiceView.updateQuotingCompany(invoiceModel.getOurCompany());
        }

        public void initializeInvoice() 
        {
            items = new List<string>() {"Sugar", "Salt", "Beans", "Bananas", "Apples"};
                       
            
            invoiceView.populateItems(items);

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

        public void generateInvoice(string companyName, string ourCompany, bool isQuote, DateTime expiryDate, InvoiceFileInfo referenceInvoice, string PONumber) 
        {
            invoiceView.showLoadingCursor();
            bool generated = invoiceModel.generateInvoice(companyName, ourCompany, isQuote, expiryDate, referenceInvoice, PONumber);
            if (generated == true) 
            {
                invoiceModel.clearReceipt();
                invoiceView.populateItemsGrid(invoiceModel.getInvoiceItems());
                invoiceView.populateScopeGrid(invoiceModel.getScopeItems());
                invoiceView.updateReceiptTotals(invoiceModel.getReceiptTotal(), invoiceModel.getVat(), invoiceModel.getGrandTotal());
                invoiceView.showNormalCursor();
                invoiceView.showSuccess();
                return;
            }
            invoiceView.showNormalCursor();
        }

        public void recipientChanged(string companyName) 
        {
            invoiceView.updateRecipientDetails(invoiceModel.getCompanyDetails(companyName));
        }

        public void invoiceGenerationCompleted() 
        {
            invoiceModel.showGeneratedInvoice();
        }


        public void addScopeItem(string scope, string description) 
        {
            invoiceModel.addScopeItem(scope, description);
            invoiceView.populateScopeGrid(invoiceModel.getScopeItems());
        }

        public void invoiceEdited() 
        {
            invoiceModel.invoiceEdited();
            invoiceView.populateItemsGrid(invoiceModel.getInvoiceItems());
            invoiceView.updateReceiptTotals(invoiceModel.getReceiptTotal(), invoiceModel.getVat(), invoiceModel.getGrandTotal());
        }

        public void removeInvoiceItem(int rowNumber) 
        {
            invoiceModel.removeItem(rowNumber);
            invoiceView.populateItemsGrid(invoiceModel.getInvoiceItems());
            invoiceView.updateReceiptTotals(invoiceModel.getReceiptTotal(), invoiceModel.getVat(), invoiceModel.getGrandTotal());
        }

        public void removeScopeItem(int rowNumber) 
        {
            invoiceModel.removeScopeItem(rowNumber);
            invoiceView.populateScopeGrid(invoiceModel.getScopeItems());
        }

        public void referenceInvoice(Object invoiceDataSource, Object scopeDataSource) 
        {
            invoiceModel.recallInvoice(invoiceDataSource, scopeDataSource);
            invoiceView.populateItemsGrid(invoiceModel.getInvoiceItems());
            invoiceView.updateReceiptTotals(invoiceModel.getReceiptTotal(), invoiceModel.getVat(), invoiceModel.getGrandTotal());
            invoiceView.populateScopeGrid(invoiceModel.getScopeItems());
        }
    }
}
