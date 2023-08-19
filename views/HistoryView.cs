using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoices.src.controllers;

namespace Invoices.src.views
{
    public partial class MainWindow
    {
        HistoryController historyController;
        //**********************************************************************************************************************
        // EVENT HANDLERS FOR THE HISTORY TAB
        //**********************************************************************************************************************

        private void HistoryUseButton_Click(object sender, EventArgs e)
        {
            //if (HistoryInvoicesList.SelectedItem == null) return;


        }

        private void HistoryDateFilter_TextChanged(object sender, EventArgs e)
        {
            string filterField = HistoryAllInvoicesGrid.Columns[0].HeaderText;
            string filterString = "Convert([{0}], 'System.String') LIKE '%{1}%'";
            (HistoryAllInvoicesGrid.DataSource as DataTable).DefaultView.RowFilter = string.Format(filterString, filterField, HistoryDateFilter.Text);
        }

        private void HistoryCompanyFilter_TextChanged(object sender, EventArgs e)
        {
            string filterField = HistoryAllInvoicesGrid.Columns[1].HeaderText;
            string filterString = "Convert([{0}], 'System.String') LIKE '%{1}%'";
            (HistoryAllInvoicesGrid.DataSource as DataTable).DefaultView.RowFilter = string.Format(filterString, filterField, HistoryCompanyFilter.Text);
        }

        private void HistoryNumberFilter_TextChanged(object sender, EventArgs e)
        {
            string filterField = HistoryAllInvoicesGrid.Columns[2].HeaderText;
            string filterString = "Convert([{0}], 'System.String') LIKE '%{1}%'";
            (HistoryAllInvoicesGrid.DataSource as DataTable).DefaultView.RowFilter = string.Format(filterString, filterField, HistoryNumberFilter.Text);
        }

        //**********************************************************************************************************************
        // END OF EVENT HANDLERS FOR THE HISTORY TAB
        //**********************************************************************************************************************

        public void assignHistoryController(HistoryController controller)
        {
            historyController = controller;
        }

        public void populateAllHistoryInvoicesGrid(Object data)
        {
            //HistoryInvoicesList.Items.Clear();
            //HistoryInvoicesList.Items.AddRange(invoiceNames.ToArray());
            HistoryAllInvoicesGrid.DataSource = null;
            HistoryAllInvoicesGrid.DataSource = data;

            HistoryAllInvoicesGrid.Columns[0].FillWeight = 1;
            HistoryAllInvoicesGrid.Columns[1].FillWeight = 1.5F;
            HistoryAllInvoicesGrid.Columns[2].FillWeight = 1;
        }

        public void newInvoiceAdded() 
        {
            historyController.newInvoiceAdded();
        }

        public void populateHistoryGrids(Object invoiceData, Object scopeData) 
        {
            HistoryInvoicesGrid.DataSource = null;
            HistoryInvoicesGrid.DataSource = invoiceData;
            HistoryInvoicesGrid.Columns[0].FillWeight = 3.0F;
            HistoryInvoicesGrid.Columns[1].FillWeight = 1.5F;
            HistoryInvoicesGrid.Columns[2].FillWeight = 1.5F;
            HistoryInvoicesGrid.Columns[3].FillWeight = 2.0F;


            HistoryInvoicesGrid.Columns[2].DefaultCellStyle.Format = "#,0.###";    //String formatted to comma seperate thousands
            HistoryInvoicesGrid.Columns[3].DefaultCellStyle.Format = "#,0.###";    //String formatted to comma seperate thousands

            HistoryScopeItemsGrid.DataSource = null;
            HistoryScopeItemsGrid.DataSource = scopeData;
            HistoryScopeItemsGrid.Columns[0].FillWeight = 1;
            HistoryScopeItemsGrid.Columns[1].FillWeight = 2;
        }

        public void insertHistoryInvoiceTotal(decimal total) 
        {
            HistoryInvoiceTotal.Value = total;
        }

    }
}
