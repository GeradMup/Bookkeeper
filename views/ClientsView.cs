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
        ClientsController clientsController;
        private bool newClient;

        public void assignclientsController(ClientsController controller) 
        {
            clientsController = controller;
        }

        public void populateCompaniesGrid<GridData>(List<GridData> gridData) 
        {
            if (gridData.Count == 0) return;
            ClientsGridView.DataSource = null;
            //This is binding the data grid view to the source gridData.
            //To change modify the data grid view, you need to modify the source.
            ClientsGridView.DataSource = gridData;

            ClientsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ClientsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ClientsGridView.Columns[0].FillWeight = 0.5F;     //Company Number
            ClientsGridView.Columns[1].FillWeight = 1.5F;     //Company Name
            ClientsGridView.Columns[2].FillWeight = 3.5F;     //Address
            ClientsGridView.Columns[3].FillWeight = 1;        //Vat Number
            ClientsGridView.Columns[4].FillWeight = 1;        //Town
            ClientsGridView.Columns[5].FillWeight = 0.7F;     //Zip Code
            ClientsGridView.Columns[6].FillWeight = 1.5F;     //Contact Person
            ClientsGridView.Columns[7].FillWeight = 1;        //Title
            ClientsGridView.Columns[8].FillWeight = 1;        //Contact Numbers
            ClientsGridView.Columns[9].FillWeight = 2;        //Email Address

            //Let's also change the currently selected item on the invoice page so that the displayed company details can be updated.
            CompanyList.SelectedItem = null;

        }

        private void EditCompaniesOptions_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                int currentRow = ClientsGridView.CurrentCell.RowIndex;
                if (e.ClickedItem.ToString() == "EDIT")
                {
                    newClient = false;
                    EditCompaniesPanel.Visible = true;

                    NewClientName.Text = ClientsGridView.Rows[currentRow].Cells[1].Value.ToString();
                    NewClientAddress.Text = ClientsGridView.Rows[currentRow].Cells[2].Value.ToString();
                    NewClientVat.Text = ClientsGridView.Rows[currentRow].Cells[3].Value.ToString();
                    NewClientCity.Text = ClientsGridView.Rows[currentRow].Cells[4].Value.ToString();
                    NewClientZipCode.Value = Decimal.Parse(ClientsGridView.Rows[currentRow].Cells[5].Value.ToString());
                    NewClientContactPerson.Text = ClientsGridView.Rows[currentRow].Cells[6].Value.ToString();
                    NewClientContactTitle.Text = ClientsGridView.Rows[currentRow].Cells[7].Value.ToString();
                    NewClientContactNumbers.Text = ClientsGridView.Rows[currentRow].Cells[8].Value.ToString();
                    NewClientContactEmail.Text = ClientsGridView.Rows[currentRow].Cells[9].Value.ToString();
                }
                else if (e.ClickedItem.ToString() == "ADD")
                {
                    newClient = true;
                    EditCompaniesPanel.Visible = true;
                }
                else if (e.ClickedItem.ToString() == "DELETE")
                {
                    string companyName = ClientsGridView.Rows[currentRow].Cells[1].Value.ToString();
                    string warning = $"Are you sure you want to delete the company: { companyName }";

                    if (warningConfirmation(warning) == true) clientsController.deleteCompany(currentRow);
                }
            }
            catch (Exception exception) 
            {
                showErrorMessage(exception.Message);
            }
        }

        //This is to ignore all commas and points
        private void NewCompanyZipCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('.') || e.KeyChar.Equals(',')) e.Handled = true;
        }

        private void NewCompanyDoneButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validNewCompanyInputs()) return;

                List<string> companyInfo = new List<string>();
                companyInfo.Add(NewClientName.Text);
                companyInfo.Add(NewClientAddress.Text);
                companyInfo.Add(NewClientVat.Text);
                companyInfo.Add(NewClientCity.Text);
                companyInfo.Add(NewClientZipCode.Value.ToString());
                companyInfo.Add(NewClientContactPerson.Text);
                companyInfo.Add(NewClientContactTitle.Text);
                companyInfo.Add(NewClientContactNumbers.Text);
                companyInfo.Add(NewClientContactEmail.Text);

                if (newClient == false)
                {
                    int currentRow = ClientsGridView.CurrentCell.RowIndex;
                    clientsController.editCompanies(currentRow, companyInfo);
                }
                else
                {
                    clientsController.addCompany(companyInfo);
                }

                ClientsGridView.Refresh();
                resetNewCompanyPanel();
                EditCompaniesPanel.Visible = false;
            }
            catch (Exception exception) 
            {
                showErrorMessage(exception.Message);
            }
        }
        //Checks if the NewCompany inputs are valid
        private bool validNewCompanyInputs() 
        {
            try
            {
                resetNewCompanyPanelColours();

                Color errorColour = Color.LightPink;
                if (NewClientName.Text == "") { NewClientName.BackColor = errorColour; return false; }
                if (NewClientAddress.Text == "") { NewClientAddress.BackColor = errorColour; return false; }
                if (NewClientCity.Text == "") { NewClientCity.BackColor = errorColour; return false; }
                if (NewClientZipCode.Value == 0) { NewClientZipCode.BackColor = errorColour; return false; }
            }
            catch (Exception exception) 
            {
                showErrorMessage(exception.Message);
            }   
                return true;
        }

        private void NewCompanyCancelButton_Click(object sender, EventArgs e)
        {
            resetNewCompanyPanel();
            EditCompaniesPanel.Visible = false;
        }


        private void resetNewCompanyPanelColours() 
        {
            NewClientName.BackColor = Color.White;
            NewClientAddress.BackColor = Color.White;
            NewClientCity.BackColor = Color.White;
            NewClientZipCode.BackColor = Color.White;
        }

        //Sets all the controls to their default states
        private void resetNewCompanyPanel() 
        {
            resetNewCompanyPanelColours();

            NewClientName.Text = "";
            NewClientAddress.Text = "";
            NewClientVat.Text = "";
            NewClientCity.Text = "";
            NewClientZipCode.Value = 0;
            NewClientContactPerson.Text = "";
            NewClientContactNumbers.Text = "";
            NewClientContactTitle.Text = "";
            NewClientContactEmail.Text = "";
        }
    }
}
