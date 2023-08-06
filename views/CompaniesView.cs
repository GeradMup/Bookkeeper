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
        CompaniesController companiesController;

        public void assignCompaniesController(CompaniesController controller) 
        {
            companiesController = controller;
        }

        public void populateCompaniesGrid<GridData>(List<GridData> gridData) 
        {
            //This is binding the data grid view to the source gridData.
            //To change modify the data grid view, you need to modify the source.
            CompaniesGridView.DataSource = gridData;

            CompaniesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CompaniesGridView.Columns[0].FillWeight = 0.5F;
            CompaniesGridView.Columns[1].FillWeight = 2;
            CompaniesGridView.Columns[2].FillWeight = 6;
            CompaniesGridView.Columns[3].FillWeight = 2;
            CompaniesGridView.Columns[4].FillWeight = 1;

            CompaniesGridView.Columns[0].ReadOnly = true;
            CompaniesGridView.AllowUserToAddRows = true;
            
        }

        private void CompaniesGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //CompaniesGridView.CurrentCell = null;
            //First check that all the columns of the grid view are filled before moving on
            DataGridViewRow selectedRow = CompaniesGridView.Rows[e.RowIndex];
            int lastColumn = CompaniesGridView.Columns.Count;
            int selecondLastColumn = lastColumn - 1;
            int lastRow = CompaniesGridView.Rows.Count - 1;

            selectedRow.DefaultCellStyle.BackColor = Color.White;
            for (int row = 1; row < selecondLastColumn; row++) 
            {
                if (selectedRow.Cells[row].Value == null)
                {
                    selectedRow.DefaultCellStyle.BackColor = Color.LightPink;
                    return;
                }
            }
    
            if (selectedRow.Cells[selecondLastColumn].Value.ToString() == "0")
            {
                selectedRow.DefaultCellStyle.BackColor = Color.LightPink;
                return;
            }

            //companiesController.editCompanies();
        }

        private void EditCompaniesOptions_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.ToString() == "EDIT")
            {
                EditCompaniesPanel.Visible = true;

                int currentRow = CompaniesGridView.CurrentCell.RowIndex;
                NewCompanyName.Text = CompaniesGridView.Rows[currentRow].Cells[1].Value.ToString();
                NewCompanyAddress.Text = CompaniesGridView.Rows[currentRow].Cells[2].Value.ToString();
                NewCompanyCity.Text = CompaniesGridView.Rows[currentRow].Cells[3].Value.ToString();
                NewCompanyZipCode.Value = Decimal.Parse(CompaniesGridView.Rows[currentRow].Cells[4].Value.ToString());
            }
            else if (e.ClickedItem.ToString() == "ADD")
            {
                EditCompaniesPanel.Visible = true;
            }
            else if (e.ClickedItem.ToString() == "DELETE") 
            {
                
            }
        }

        //This is to ignore all commas and points
        private void NewCompanyZipCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('.') || e.KeyChar.Equals(',')) e.Handled = true;
        }

        private void NewCompanyDoneButton_Click(object sender, EventArgs e)
        {
            resetNewCompanyPanelColours();

            Color errorColour = Color.LightPink;
            if(NewCompanyName.Text == "") { NewCompanyName.BackColor = errorColour; return; }
            if(NewCompanyAddress.Text == "") { NewCompanyAddress.BackColor = errorColour; return; }
            if(NewCompanyCity.Text == "") { NewCompanyCity.BackColor = errorColour; return; }
            if(NewCompanyZipCode.Value == 0) { NewCompanyZipCode.BackColor = errorColour; return; }

            int currentRow = CompaniesGridView.CurrentCell.RowIndex;

            companiesController.editCompanies(currentRow, NewCompanyName.Text, NewCompanyAddress.Text, NewCompanyCity.Text, NewCompanyZipCode.Value);
            CompaniesGridView.Refresh();

            resetNewCompanyPanel();
            EditCompaniesPanel.Visible = false;
        }

        private void NewCompanyCancelButton_Click(object sender, EventArgs e)
        {
            resetNewCompanyPanel();
            EditCompaniesPanel.Visible = false;
        }


        private void resetNewCompanyPanelColours() 
        {
            NewCompanyName.BackColor = Color.White;
            NewCompanyAddress.BackColor = Color.White;
            NewCompanyCity.BackColor = Color.White;
            NewCompanyZipCode.BackColor = Color.White;
        }

        //Sets all the controls to their default states
        private void resetNewCompanyPanel() 
        {
            resetNewCompanyPanelColours();

            NewCompanyName.Text = "";
            NewCompanyAddress.Text = "";
            NewCompanyCity.Text = "";
            NewCompanyZipCode.Value = 0;
        }
    }
}
