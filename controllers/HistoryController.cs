using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoices.src.models;
using Invoices.src.views;

namespace Invoices.src.controllers
{
    public class HistoryController
    {
        HistoryModel historyModel;
        MainWindow historyView;

        public HistoryController(MainWindow view, HistoryModel model) 
        {
            historyModel = model;
            historyView = view;

            historyView.assignHistoryController(this);
            historyView.populateAllHistoryInvoicesGrid(historyModel.getInvoiceHistory());
        }

        public void invoiceSelected(string invoiceNumber) 
        {
            historyModel.loadInvoiceItems(invoiceNumber);
            historyView.populateHistoryGrids(historyModel.getInvoiceItems(), historyModel.getScopeItems());
            historyView.insertHistoryInvoiceTotal(historyModel.invoiceTotal());
        }

        public void newInvoiceAdded() 
        {
            historyView.populateAllHistoryInvoicesGrid(historyModel.getInvoiceHistory());
        }
    }
}
