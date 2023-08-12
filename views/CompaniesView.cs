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
        private bool newCompany;

        public void assignCompaniesController(CompaniesController controller) 
        {
            companiesController = controller;
        }

        public void populateCompaniesGrid<GridData>(List<GridData> gridData) 
        {
            if (gridData.Count == 0) return;
            CompaniesGridView.DataSource = null;
            //This is binding the data grid view to the source gridData.
            //To change modify the data grid view, you need to modify the source.
            CompaniesGridView.DataSource = gridData;

            CompaniesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CompaniesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CompaniesGridView.Columns[0].FillWeight = 0.5F;
            CompaniesGridView.Columns[1].FillWeight = 1.5F;
            CompaniesGridView.Columns[2].FillWeight = 4;
            CompaniesGridView.Columns[3].FillWeight = 1;
            CompaniesGridView.Columns[4].FillWeight = 1;
            CompaniesGridView.Columns[5].FillWeight = 1.5F;
            CompaniesGridView.Columns[6].FillWeight = 1;
            CompaniesGridView.Columns[7].FillWeight = 1;
            CompaniesGridView.Columns[8].FillWeight = 2;

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
                newCompany = false;
                EditCompaniesPanel.Visible = true;

                int currentRow = CompaniesGridView.CurrentCell.RowIndex;
                NewCompanyName.Text = CompaniesGridView.Rows[currentRow].Cells[1].Value.ToString();
                NewCompanyAddress.Text = CompaniesGridView.Rows[currentRow].Cells[2].Value.ToString();
                NewCompanyCity.Text = CompaniesGridView.Rows[currentRow].Cells[3].Value.ToString();
                NewCompanyZipCode.Value = Decimal.Parse(CompaniesGridView.Rows[currentRow].Cells[4].Value.ToString());
                NewCompanyContactPerson.Text = CompaniesGridView.Rows[currentRow].Cells[5].Value.ToString();
                NewCompanyContactTitle.Text = CompaniesGridView.Rows[currentRow].Cells[6].Value.ToString();
                NewCompanyContactNumbers.Text = CompaniesGridView.Rows[currentRow].Cells[7].Value.ToString();
                NewCompanyContactEmail.Text = CompaniesGridView.Rows[currentRow].Cells[8].Value.ToString();
            }
            else if (e.ClickedItem.ToString() == "ADD")
            {
                newCompany = true;
                EditCompaniesPanel.Visible = true;
            }
            else if (e.ClickedItem.ToString() == "DELETE") 
            {
                int currentRow = CompaniesGridView.CurrentCell.RowIndex;
                companiesController.deleteCompany(currentRow);
            }
        }

        //This is to ignore all commas and points
        private void NewCompanyZipCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('.') || e.KeyChar.Equals(',')) e.Handled = true;
        }

        private void NewCompanyDoneButton_Click(object sender, EventArgs e)
        {
            if (!validNewCompanyInputs()) return;

            List<string> companyInfo = new List<string>();
            companyInfo.Add(NewCompanyName.Text);
            companyInfo.Add(NewCompanyAddress.Text);
            companyInfo.Add(NewCompanyCity.Text);
            companyInfo.Add(NewCompanyZipCode.Value.ToString());
            companyInfo.Add(NewCompanyContactPerson.Text);
            companyInfo.Add(NewCompanyContactTitle.Text);
            companyInfo.Add(NewCompanyContactNumbers.Text);
            companyInfo.Add(NewCompanyContactEmail.Text);

            if (newCompany == false)
            {
                int currentRow = CompaniesGridView.CurrentCell.RowIndex;
                companiesController.editCompanies(currentRow, companyInfo);
            }
            else 
            {
                companiesController.addCompany(companyInfo);
            }

            CompaniesGridView.Refresh();
            resetNewCompanyPanel();
            EditCompaniesPanel.Visible = false;
        }

        //Checks if the NewCompany inputs are valid
        private bool validNewCompanyInputs() 
        {
            resetNewCompanyPanelColours();

            Color errorColour = Color.LightPink;
            if (NewCompanyName.Text == "") { NewCompanyName.BackColor = errorColour; return false; }
            if (NewCompanyAddress.Text == "") { NewCompanyAddress.BackColor = errorColour; return false; }
            if (NewCompanyCity.Text == "") { NewCompanyCity.BackColor = errorColour; return false; }
            if (NewCompanyZipCode.Value == 0) { NewCompanyZipCode.BackColor = errorColour; return false; }
            return true;
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
            NewCompanyContactPerson.Text = "";
            NewCompanyContactNumbers.Text = "";
            NewCompanyContactTitle.Text = "";
            NewCompanyContactEmail.Text = "";
        }
    }
}
