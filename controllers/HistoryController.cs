using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoices.src.DataObjects;
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
            historyView.initialiazeHistoryTab();
            historyView.populateHistoryMonths(historyModel.getInvoiceMonths());
            //historyView.populateAllHistoryInvoicesGrid(historyModel.getInvoiceHistory());
        }

        public void invoiceSelected(string invoiceNumber, string month, DateTime invoiceDate)
        {
            historyModel.loadInvoiceItems(invoiceNumber, month, invoiceDate);
            historyView.populateHistoryGrids(historyModel.getInvoiceItems(), historyModel.getScopeItems(), historyModel.getAttachments());
            historyView.insertHistoryInvoiceTotal(historyModel.invoiceTotal());
        }

        public void historyMonthSelected(string month) 
        {
            historyView.populateAllHistoryInvoicesGrid(historyModel.getInvoiceHistory(month));
        }

        public void newInvoiceAdded()
        {
            //historyView.populateAllHistoryInvoicesGrid(historyModel.getInvoiceHistory());
        }

        public void addAttachements(InvoiceFileInfo invoiceQuoteFile)
        {
            bool added = historyModel.addAttachments(invoiceQuoteFile);
            if (added == true) {
                string month = invoiceQuoteFile.Date.ToString("MMMM yyy");
                invoiceSelected(invoiceQuoteFile.Number, month, invoiceQuoteFile.Date); 
            }
        }

        public void viewAttachement(string attachmentName, string invoiceNumber)
        {
            historyModel.openAttachment(attachmentName, invoiceNumber);
        }

        public void deleteAttachment(string attachmentName, string invoiceNumber, string month, DateTime invoiceDate)
        {
            historyModel.deleteAttachment(attachmentName, invoiceNumber);
            invoiceSelected(invoiceNumber, month, invoiceDate);
        }
    }
}
