using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.src.DataObjects
{
    public class Company
    {
        public Company(List<String> allValues = null)
        {
            if (allValues != null)
            {
                Number = Int16.Parse(allValues[0].Trim());
                Name = allValues[1].Trim();
                Address = allValues[2].Trim();
                Vat = allValues[3].Trim();
                Town = allValues[4].Trim();
                AreaCode = Int32.Parse(allValues[5].Trim());
                ContactPerson = allValues[6].Trim();
                Title = allValues[7].Trim();
                Numbers = allValues[8].Trim();
                Email = allValues[9].Trim();
            }
        }

        public Int16 Number { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Vat { get; set; }
        public string Town { get; set; }
        public Int32 AreaCode { get; set; }
        public string ContactPerson { get; set; }
        public string Title { get; set; }
        public string Numbers { get; set; }
        public string Email { get; set; }

        //Checks if this company is equal to another company
        public bool isEqualTo(Company company)
        {
            if (this.Number == company.Number
                && this.Name == company.Name
                && this.Address == company.Address
                && this.Vat == company.Vat
                && this.Town == company.Town
                && this.AreaCode == company.AreaCode
                && this.ContactPerson == company.ContactPerson
                && this.Title == company.Title
                && this.Numbers == company.Numbers
                && this.Email == company.Email) return true;
            else return false;
        }

        //Equates this company to another company
        public void equateTo(Company company)
        {
            this.Number = company.Number;
            this.Name = company.Name;
            this.Address = company.Address;
            this.Vat = company.Vat;
            this.Town = company.Town;
            this.AreaCode = company.AreaCode;
            this.ContactPerson = company.ContactPerson;
            this.Title = company.Title;
            this.Numbers = company.Numbers;
            this.Email = company.Email;
        }

        /// <summary>
        /// Returns all the attributes of the company in a list of strings
        /// </summary>
        /// <returns>List<string></string></returns>
        public List<string> companyToList()
        {
            List<String> myList = new List<string>();
            myList.Add(this.Number.ToString());
            myList.Add(this.Name);
            myList.Add(this.Address);
            myList.Add(this.Vat);
            myList.Add(this.Town);
            myList.Add(this.AreaCode.ToString());
            myList.Add(this.ContactPerson);
            myList.Add(this.Title);
            myList.Add(this.Numbers);
            myList.Add(this.Email);
            return myList;
        }
    }
}
