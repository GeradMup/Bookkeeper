using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoices.src.models;
using Invoices.src.views;

namespace Invoices.src.controllers
{
    public class QuotesController
    {
        QuotesModel quotesModel;
        MainWindow quotesView;

        public QuotesController(QuotesModel qModel, MainWindow qView) 
        {
            quotesModel = qModel;
            quotesView = qView;
            quotesView.assignQuotesController(this);
            quotesView.populateQuoteMonths(quotesModel.getQuoteMonths());
        }

        public void addQuote() 
        {
            quotesModel.addQuote();
            quotesView.populateQuoteMonths(quotesModel.getQuoteMonths());
        }

        public void monthSelected(string selectedMonth) 
        {
            quotesModel.monthSelected(selectedMonth);
            quotesView.populateQuotesGrid(quotesModel.getQuotesData());
        }

        public void viewQuote(string selectedQuote, string month) 
        {
            quotesModel.viewQuote(selectedQuote, month);
        }
    }
}
