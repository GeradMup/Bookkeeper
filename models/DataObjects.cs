using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.src.models
{
    public class Company
    {
        public Company(List<String> allValues = null)
        {
            if (allValues != null)
            {
                Number = Int16.Parse(allValues[0]);
                Name = allValues[1];
                Address = allValues[2];
                Town = allValues[3];
                AreaCode = Int32.Parse(allValues[4]);
            }
        }

        public Int16 Number { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }
        public Int32 AreaCode { get; set; }

        //Checks if this company is equal to another company
        public bool isEqualTo(Company company)
        {
            if (this.Number == company.Number
                && this.Name == company.Name
                && this.Address == company.Address
                && this.Town == company.Town
                && this.AreaCode == company.AreaCode) return true;
            else return false;
        }

        //Equates this company to another company
        public void equateTo(Company company) 
        {
            this.Number = company.Number;
            this.Name = company.Name;
            this.Address = company.Address;
            this.Town = company.Town;
            this.AreaCode = company.AreaCode;
        }

        //Sets all the properties of the class from a list of strings
        public void setAll(List<String> allValues) 
        {
            Number = Int16.Parse(allValues[0]);
            Name = allValues[1];
            Address = allValues[2];
            Town = allValues[3];
            AreaCode = Int32.Parse(allValues[4]);
        }

        public List<string> companyToString() 
        {
            List<String> myList = new List<string>();
            myList.Add(this.Number.ToString());
            myList.Add(this.Name.ToString());
            myList.Add(this.Address.ToString());
            myList.Add(this.Town.ToString());
            myList.Add(this.AreaCode.ToString());
            return myList;
        }
    }

    public class InvoiceItem
    {
        public InvoiceItem(string name, decimal quantity, decimal unitPrice) 
        {
            this.Name = name;
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
            this.TotalPrice = quantity * unitPrice;
        }

            public string Name { get; set; }
            public decimal Quantity { get; set; }
            public decimal UnitPrice { get; set; }
            public decimal TotalPrice { get; set; }
    }

    public class InvoiceComment 
    {
        public InvoiceComment(string title, string comment) 
        {
            this.Title = title;
            this.Comment = comment;
        }

        public string Title { get; set; }
        public string Comment { get; set; }
    }
}
