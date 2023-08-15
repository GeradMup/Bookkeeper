using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoices.src.models;
using Invoices.src.views;

namespace Invoices.src.controllers
{

    public class SetupController
    {
        SetupModel setupModel;
        MainWindow setupView;
        
        public SetupController(SetupModel model, MainWindow view) 
        {
            setupModel = model;
            setupView = view;
            setupView.assignSetupController(this);
            setupView.populateCompaniesList(setupModel.getOurCompanyNames());
            setupView.setSelectedCompany(setupModel.getSelectedCompany());
        }

        public void companySelected(string name) 
        {
            setupView.updateCompanyDetails(setupModel.getCompanyDetails(name));
        }

    }
}
