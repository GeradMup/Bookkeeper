using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.src.models
{
    public class CompaniesModel
    {
        TextFiles textFiles;
        List<Company> companies = new List<Company>();
        List<Company> companiesCopy = new List<Company>();
        public CompaniesModel()
        {
            textFiles = new TextFiles();
            // When the class is constructed, we need to read the csv files that contain all the information needed by the invoices tab

            //Create the list of companies


            //Read companies
            //MessageBox.Show(companiesPath);
            readCompanies();


            //Read the prices

        }

        private void readCompanies()
        {
            List<List<String>> allCompanies = textFiles.readTextFile(Constants.COMPANIES_PATH);
            companies.Clear();
            companiesCopy.Clear();
            foreach (List<String> companyInfo in allCompanies)
            {
                companies.Add(new Company(companyInfo));
                companiesCopy.Add(new Company(companyInfo));
            }
        }

        public List<Company> getCompanies() 
        {
            return companiesCopy;
        }

        /// <summary>
        /// Updates the companies.
        /// </summary>
        /// <returns>True if the companies were successfully modified, false otherwise</returns>
        public bool updateCompanies() 
        {
            //First check if any of the data was changed or not. If not, there is nothing to do, so exit.
            if (Enumerable.SequenceEqual(companies, companiesCopy) == true) return false;

            List<List<String>> allCompanies = new List<List<string>>();

            foreach (Company company in companiesCopy) 
            {
                allCompanies.Add(company.companyToString());
            }

            //Save the new information to the file and then read the file again
            textFiles.writeTextFile(Constants.COMPANIES_PATH, allCompanies);
            readCompanies();
            return true;

        }
    }
}

