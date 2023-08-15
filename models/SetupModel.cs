using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.src.models
{
    public class SetupModel
    {

        List<OurCompany> ourCompanies = new List<OurCompany>();
        TextFiles textFiles = new TextFiles();
        public SetupModel()
        {
            loadOurCompanies();
        }

        private void loadOurCompanies() 
        {
            List<List<String>> ourCompaniesList = textFiles.readTextFile(Constants.OUR_COMPANIES_PATH);

            ourCompanies.Clear();
            foreach (List<String> companyInfo in ourCompaniesList)
            {
                ourCompanies.Add(new OurCompany(companyInfo));
            }
        }

        public List<String> getOurCompanyNames(bool readFirst = false)
        {
            //Check if we need to read the companies first before updating
            if (readFirst == true) loadOurCompanies();

            List<String> companyNames = new List<string>();
            foreach (OurCompany company in ourCompanies)
            {
                companyNames.Add(company.Name);
            }
            return companyNames;
        }

        public string getSelectedCompany() 
        {
            return ourCompanies.FirstOrDefault(comp => comp.CurrentlySelected == "true").Name;
        }

        public void saveAllCompanies() 
        {
            List<List<string>> ourCompaniesList = new List<List<string>>();
            foreach (OurCompany company in ourCompanies)
            {
                ourCompaniesList.Add(company.companyToList());
            }

            textFiles.writeTextFile(Constants.OUR_COMPANIES_PATH, ourCompaniesList);
        }

        public List<string> getCompanyDetails(string name) 
        {
            foreach (OurCompany company in ourCompanies) 
            {
                company.CurrentlySelected = "false";
            }

            OurCompany selectedCompany = ourCompanies.FirstOrDefault(comp => comp.Name == name);
            selectedCompany.CurrentlySelected = "true";

            saveAllCompanies();

            return selectedCompany.companyToList();
        }
    }
}
