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
 
            Int16 companyIndex = 1;
            foreach (List<String> companyInfo in allCompanies)
            {
                companyIndex++;
                companies.Add(new Company(companyInfo));
            }
        }

        //Specify if we need to first do a read before getting companies
        //Reading again is necessary if we have edited our list companies
        public List<Company> getCompanies(bool readFirst = false) 
        {
            if (readFirst == true) readCompanies();
            return companies;
        }

        /// <summary>
        /// Updates the companies.
        /// </summary>
        /// <returns>True if the companies were successfully modified, false otherwise</returns>
        public bool updateCompanies(int number, string name, string address, string city, decimal zipCode) 
        {
            //First check if any of the data was changed or not. If not, there is nothing to do, so exit.
            string companyNumber = (number + 1).ToString();
            Company modifiedCompany = new Company(new List<String> { companyNumber, name, address, city, zipCode.ToString() });
            if (companies[number].isEqualTo(modifiedCompany)) return false;

            companies[number].equateTo(modifiedCompany);


            List<List<String>> allCompanies = new List<List<string>>();

            //First convert the company information to a list of strings
            foreach (Company company in companies)
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

