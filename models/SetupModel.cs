﻿using Invoices.src.DataObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoices.src.models
{
    public class SetupModel
    {

        List<OurCompany> ourCompanies = new List<OurCompany>();
        TextFiles textFiles = new TextFiles();
        String logoImageName;
        String footerImageName;

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
            OurCompany selectedCompany = ourCompanies.FirstOrDefault(comp => comp.CurrentlySelected == "true");
            logoImageName = selectedCompany.LogoImage;
            footerImageName = selectedCompany.FooterImage;
            return selectedCompany.Name;
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

        private void deselectAllOurCompanies() 
        {
            foreach (OurCompany company in ourCompanies)
            {
                company.CurrentlySelected = "false";
            }

        }

        public OurCompany getCompanyDetails(string name) 
        {
            deselectAllOurCompanies();
            OurCompany selectedCompany = ourCompanies.FirstOrDefault(comp => comp.Name == name);
            selectedCompany.CurrentlySelected = "true";

            saveAllCompanies();

            return selectedCompany;
        }

        public string getLogoImageName(string currentLogo) 
        {
            logoImageName = fileNameFromDialogBox();
            return logoImageName == "" ? currentLogo : logoImageName;
        }

        public string getFooterImageName(string currentFooter) 
        {
            footerImageName = fileNameFromDialogBox();
            return logoImageName == "" ? currentFooter : footerImageName;
        }

        private string fileNameFromDialogBox() 
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string fullFilePath = openFileDialog.FileName;
                string fileName = Path.GetFileName(fullFilePath);

                //First copy the image from wherever it is into the resources folder.
                string newFilePath = Constants.RESOURCES_DIRECTORY + fileName;
                bool overwrite = true;
                if (fullFilePath != newFilePath) File.Copy(fullFilePath, newFilePath, overwrite);

                return fileName;
            }
            return "";
        }

        public void editOurCompany(OurCompany modifiedCompany) 
        {
            OurCompany company = ourCompanies.FirstOrDefault(comp => comp.Number == modifiedCompany.Number);
            company.equateTo(modifiedCompany);

            saveAllCompanies();
        }

        public void addNewOurCompany(OurCompany company) 
        {

            Int16 nextCompanyNumber = (Int16)(ourCompanies.Count() + 1);
            company.Number = nextCompanyNumber;

            //The newly added company should automatically become the selected one.
            deselectAllOurCompanies();
            company.CurrentlySelected = "true";
            ourCompanies.Add(company);
            saveAllCompanies();
        }
    }
}
