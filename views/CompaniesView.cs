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
        private bool newClient;

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
            CompaniesGridView.Columns[0].FillWeight = 0.5F;     //Company Number
            CompaniesGridView.Columns[1].FillWeight = 1.5F;     //Company Name
            CompaniesGridView.Columns[2].FillWeight = 3.5F;     //Address
            CompaniesGridView.Columns[3].FillWeight = 1;        //Vat Number
            CompaniesGridView.Columns[4].FillWeight = 1;        //Town
            CompaniesGridView.Columns[5].FillWeight = 0.7F;     //Zip Code
            CompaniesGridView.Columns[6].FillWeight = 1.5F;     //Contact Person
            CompaniesGridView.Columns[7].FillWeight = 1;        //Title
            CompaniesGridView.Columns[8].FillWeight = 1;        //Contact Numbers
            CompaniesGridView.Columns[9].FillWeight = 2;        //Email Address

            //Let's also change the currently selected item on the invoice page so that the displayed company details can be updated.
            CompanyList.SelectedItem = null;

        }

        private void EditCompaniesOptions_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            int currentRow = CompaniesGridView.CurrentCell.RowIndex;
            if (e.ClickedItem.ToString() == "EDIT")
            {
                newClient = false;
                EditCompaniesPanel.Visible = true;

                NewCompanyName.Text = CompaniesGridView.Rows[currentRow].Cells[1].Value.ToString();
                NewCompanyAddress.Text = CompaniesGridView.Rows[currentRow].Cells[2].Value.ToString();
                NewCompanyVat.Text = CompaniesGridView.Rows[currentRow].Cells[3].Value.ToString();
                NewCompanyCity.Text = CompaniesGridView.Rows[currentRow].Cells[4].Value.ToString();
                NewCompanyZipCode.Value = Decimal.Parse(CompaniesGridView.Rows[currentRow].Cells[5].Value.ToString());
                NewCompanyContactPerson.Text = CompaniesGridView.Rows[currentRow].Cells[6].Value.ToString();
                NewCompanyContactTitle.Text = CompaniesGridView.Rows[currentRow].Cells[7].Value.ToString();
                NewCompanyContactNumbers.Text = CompaniesGridView.Rows[currentRow].Cells[8].Value.ToString();
                NewCompanyContactEmail.Text = CompaniesGridView.Rows[currentRow].Cells[9].Value.ToString();
            }
            else if (e.ClickedItem.ToString() == "ADD")
            {
                newClient = true;
                EditCompaniesPanel.Visible = true;
            }
            else if (e.ClickedItem.ToString() == "DELETE") 
            {
                string warning = "Are you sure you want to delete the company:";
                string companyName = CompaniesGridView.Rows[currentRow].Cells[1].Value.ToString();
                DialogResult dialogResult = MessageBox.Show($"{warning} {companyName}", "Warning!", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    companiesController.deleteCompany(currentRow);
                }    
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
            companyInfo.Add(NewCompanyVat.Text);
            companyInfo.Add(NewCompanyCity.Text);
            companyInfo.Add(NewCompanyZipCode.Value.ToString());
            companyInfo.Add(NewCompanyContactPerson.Text);
            companyInfo.Add(NewCompanyContactTitle.Text);
            companyInfo.Add(NewCompanyContactNumbers.Text);
            companyInfo.Add(NewCompanyContactEmail.Text);

            if (newClient == false)
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
            NewCompanyVat.Text = "";
            NewCompanyCity.Text = "";
            NewCompanyZipCode.Value = 0;
            NewCompanyContactPerson.Text = "";
            NewCompanyContactNumbers.Text = "";
            NewCompanyContactTitle.Text = "";
            NewCompanyContactEmail.Text = "";
        }
    }
}
