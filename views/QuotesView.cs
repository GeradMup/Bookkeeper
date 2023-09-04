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
        QuotesController quotesController;
        public void assignQuotesController(QuotesController controller) 
        {
            quotesController = controller;
        }

        public void populateQuoteMonths(List<string> quoteMonths)
        {
            QuotesMonthFilter.Items.Clear();
            QuotesMonthFilter.Items.AddRange(quoteMonths.ToArray());
        }

        public void populateQuotesGrid(Object quotesData) 
        {
            QuotesGrid.DataSource = null;
            if (quotesData == null) return;

            QuotesGrid.DataSource = quotesData;
        }

        //*********************************************************************************************************************************************
        // EVENT HANDLERS FOR THE QUOTES TAB
        //*********************************************************************************************************************************************
        private void QuotesMonthFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (QuotesMonthFilter.SelectedItem == null) return;

            quotesController.monthSelected(QuotesMonthFilter.Text);

        }

        private void QuotesAddButton_Click(object sender, EventArgs e)
        {
            quotesController.addQuote();
        }

        private void QuotesGridOptions_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                if (validGridViewSelection(QuotesGrid) == false) return;
                if (e.ClickedItem.Name == "VIEW_QUOTE")
                {
                    string selectedQuote = QuotesGrid.CurrentRow.Cells[0].Value.ToString();
                    string month = QuotesMonthFilter.Text;
                    quotesController.viewQuote(selectedQuote, month);
                }
            }
            catch (Exception exception) 
            {
                showErrorMessage(exception.Message);
            }
        }

    }
}
