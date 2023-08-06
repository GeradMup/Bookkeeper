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
        CompaniesController companiesController;

        public void assignCompaniesController(CompaniesController controller) 
        {
            companiesController = controller;
        }

        public void populateCompaniesGrid<GridData>(List<GridData> gridData) 
        {
            CompaniesGridView.DataSource = gridData;

            CompaniesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CompaniesGridView.Columns[0].FillWeight = 0.5F;
            CompaniesGridView.Columns[1].FillWeight = 2;
            CompaniesGridView.Columns[2].FillWeight = 6;
            CompaniesGridView.Columns[3].FillWeight = 2;
            CompaniesGridView.Columns[4].FillWeight = 1;

            CompaniesGridView.Columns[0].ReadOnly = true;
        }

        private void CompaniesGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            companiesController.editCompanies();
        }
    }
}
