using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invoices.src.controllers;
using Invoices.src.DataObjects;
using Invoices.src.models;

namespace Invoices.src.views
{
    public partial class MainWindow
    {
        HistoryController historyController;
        //**********************************************************************************************************************
        // EVENT HANDLERS FOR THE HISTORY TAB
        //**********************************************************************************************************************
        private void HistoryAllInvoicesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1) return;
                if (HistoryMonths.SelectedItem == null) return;
                string month = HistoryMonths.Text;
                string selectedInvoice = HistoryAllInvoicesGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                DateTime invoiceDate = (DateTime)HistoryAllInvoicesGrid.Rows[e.RowIndex].Cells[0].Value;
                historyController.invoiceSelected(selectedInvoice, month, invoiceDate);
            }
            catch (Exception exception) 
            {
                showErrorMessage(exception.Message);
            }
        }

        private void UseAsReferenceButton_Click(object sender, EventArgs e)
        {
            useAsReference();
        }

        private void HistoryAllInvoicesGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           // useAsReference();
        }

        private void HistoryDateFilter_TextChanged(object sender, EventArgs e)
        {
            filterHistoryGridView();
        }

        private void HistoryCompanyFilter_TextChanged(object sender, EventArgs e)
        {
            filterHistoryGridView();
        }

        private void HistoryNumberFilter_TextChanged(object sender, EventArgs e)
        {
            filterHistoryGridView();
        }
        private void HistoryAddAttachments_Click(object sender, EventArgs e)
        {
            try
            {
                if ((HistoryAllInvoicesGrid.DataSource as DataTable).Rows.Count < 1) return;
                if (HistoryAllInvoicesGrid.CurrentRow.Index == -1) return;

                DateTime invoiceDate = (DateTime)HistoryAllInvoicesGrid.CurrentRow.Cells[0].Value;
                string company = HistoryAllInvoicesGrid.CurrentRow.Cells[1].Value.ToString();
                string invoiceNumber = HistoryAllInvoicesGrid.CurrentRow.Cells[2].Value.ToString();

                InvoiceFileInfo invoiceQuoteFile = new InvoiceFileInfo(invoiceDate, company, invoiceNumber);
                historyController.addAttachements(invoiceQuoteFile);

            }
            catch (Exception exception) 
            {
                showErrorMessage(exception.Message);
            }
        }
        private void HistoryAttachmentsOptions_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                if ((HistoryAllInvoicesGrid.DataSource as DataTable).Rows.Count < 1) return;
                if (HistoryAllInvoicesGrid.CurrentRow.Index == -1) return;

                if ((HistoryAllInvoicesGrid.DataSource as DataTable).Rows.Count < 1) return;
                if (HistoryAllInvoicesGrid.CurrentRow.Index == -1) return;

                if (HistoryMonths.SelectedItem == null) return;
                string month = HistoryMonths.Text;

                string attachmentName = HistoryAttachmentsGrid.CurrentRow.Cells[1].Value.ToString();
                string invoiceNumber = HistoryAllInvoicesGrid.CurrentRow.Cells[2].Value.ToString();
                DateTime invoiceDate = (DateTime)HistoryAllInvoicesGrid.CurrentRow.Cells[0].Value;

                if (e.ClickedItem.Name == "DELETE_ATTACHMENT")
                {
                    string deletionWarning = $"Are you sure you want to delete the attachment: { attachmentName }";
                    if (warningConfirmation(deletionWarning) == true) historyController.deleteAttachment(attachmentName, invoiceNumber, month, invoiceDate);
                }
                else if (e.ClickedItem.Name == "VIEW_ATTACHMENT")
                {
                    historyController.viewAttachement(attachmentName, invoiceNumber);
                }
            }
            catch (Exception exception) 
            {
                showErrorMessage(exception.Message);
            }
        }

        private void HistoryMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HistoryMonths.SelectedItem == null) return;
            clearAllHistoryInvoiceGrids();
            historyController.historyMonthSelected(HistoryMonths.Text);
        }

        //**********************************************************************************************************************
        // END OF EVENT HANDLERS FOR THE HISTORY TAB
        //**********************************************************************************************************************

        public void populateHistoryMonths(List<string> months) 
        {
            HistoryMonths.Items.Clear();
            HistoryMonths.Items.AddRange(months.ToArray());
        }

        private void useAsReference()
        {
            if ((HistoryAllInvoicesGrid.DataSource as DataTable).Rows.Count < 1) return;
            if (HistoryAllInvoicesGrid.CurrentRow.Index == -1) return;

            string referenceInvoiceNumber = HistoryAllInvoicesGrid.CurrentRow.Cells[2].Value.ToString();
            string referenceCompany = HistoryAllInvoicesGrid.CurrentRow.Cells[1].Value.ToString();
            DateTime referenceDate = (DateTime)HistoryAllInvoicesGrid.CurrentRow.Cells[0].Value;

            InvoiceFileInfo invoiceFileInfo = new InvoiceFileInfo(referenceDate, referenceCompany, referenceInvoiceNumber);
            referenceInvoice(HistoryInvoicesGrid.DataSource, HistoryScopeItemsGrid.DataSource, invoiceFileInfo);     //This is a function from the Invoice Views Tab.

            Object invoiceData = null;
            Object scopeData = null;
            Object attachmentsData = null;
            populateHistoryGrids(invoiceData, scopeData, attachmentsData);
            HistoryAllInvoicesGrid.ClearSelection();
        }

        private void filterHistoryGridView()
        {
            string dateField = HistoryAllInvoicesGrid.Columns[0].HeaderText;
            string companyField = HistoryAllInvoicesGrid.Columns[1].HeaderText;
            string invoiceField = HistoryAllInvoicesGrid.Columns[2].HeaderText;
            string dateFilter = HistoryDateFilter.Text;
            string companyFilter = HistoryCompanyFilter.Text;
            string invoiceFilter = HistoryNumberFilter.Text;

            string filterString = "Convert([{0}], 'System.String') LIKE '%{1}%' AND Convert([{2}], 'System.String') LIKE '%{3}%' AND Convert([{4}], 'System.String') LIKE '%{5}%'";

            (HistoryAllInvoicesGrid.DataSource as DataTable).DefaultView.RowFilter = string.Format(filterString, dateField, dateFilter, companyField, companyFilter, invoiceField, invoiceFilter);
        }

        public void initialiazeHistoryTab() 
        {
            HistoryInvoiceTotal.Controls[0].Visible = false;
        }

        public void assignHistoryController(HistoryController controller)
        {
            historyController = controller;
        }

        public void populateAllHistoryInvoicesGrid(Object data)
        {
            //HistoryInvoicesList.Items.Clear();
            //HistoryInvoicesList.Items.AddRange(invoiceNames.ToArray());
            HistoryAllInvoicesGrid.DataSource = null;
            if (data == null) return;

            HistoryAllInvoicesGrid.DataSource = data;

            HistoryAllInvoicesGrid.Columns[0].FillWeight = 1;
            HistoryAllInvoicesGrid.Columns[1].FillWeight = 1.5F;
            HistoryAllInvoicesGrid.Columns[2].FillWeight = 1;

            HistoryAllInvoicesGrid.Columns[0].DefaultCellStyle.Format = "dd MMM yyyy (hh:mm)";

            HistoryAllInvoicesGrid.ClearSelection();
        }

        public void newInvoiceAdded() 
        {
            historyController.newInvoiceAdded();
        }

        public void populateHistoryGrids(Object invoiceData, Object scopeData, Object attachmentsData) 
        {
            clearAllHistoryInvoiceGrids();
            if (invoiceData == null || scopeData == null) return;

            HistoryInvoicesGrid.DataSource = invoiceData;
            HistoryInvoicesGrid.Columns[0].FillWeight = 3.0F;
            HistoryInvoicesGrid.Columns[1].FillWeight = 1.5F;
            HistoryInvoicesGrid.Columns[2].FillWeight = 1.5F;
            HistoryInvoicesGrid.Columns[3].FillWeight = 2.0F;
            HistoryInvoicesGrid.ClearSelection();

            HistoryInvoicesGrid.Columns[2].DefaultCellStyle.Format = "#,0.###";    //String formatted to comma seperate thousands
            HistoryInvoicesGrid.Columns[3].DefaultCellStyle.Format = "#,0.###";    //String formatted to comma seperate thousands

           
            HistoryScopeItemsGrid.DataSource = scopeData;
            HistoryScopeItemsGrid.Columns[0].FillWeight = 1;
            HistoryScopeItemsGrid.Columns[1].FillWeight = 2;
            HistoryScopeItemsGrid.ClearSelection();

            HistoryAttachmentsGrid.DataSource = attachmentsData;
            HistoryAttachmentsGrid.Columns[0].FillWeight = 0.1F;
            HistoryAttachmentsGrid.Columns[1].FillWeight = 5F;
            HistoryAttachmentsGrid.ClearSelection();
        }

        private void clearAllHistoryInvoiceGrids() 
        {
            HistoryInvoicesGrid.DataSource = null;
            HistoryScopeItemsGrid.DataSource = null;
            HistoryAttachmentsGrid.DataSource = null; 
        }

        public void insertHistoryInvoiceTotal(decimal total) 
        {
            HistoryInvoiceTotal.Value = total;
        }

        /// <summary>
        /// Resets the history tab.
        /// This function is used when the history tab is de-selected. That way, when we come back into the tab, everything would have been reset again.
        /// </summary>
        public void resetHistoryTab() 
        {
            clearAllHistoryInvoiceGrids();
            HistoryAllInvoicesGrid.DataSource = null;
            HistoryMonths.SelectedItem = null;
            HistoryNumberFilter.Text = "";
            HistoryDateFilter.Text = "";
            HistoryCompanyFilter.Text = "";
        }

    }
}
