using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.src.models
{
    //***************************************************************************************************************************************
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
    //***************************************************************************************************************************************
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

        public void recalculateTotalPrice() 
        {
            this.TotalPrice = this.Quantity * this.UnitPrice;
        }

        public List<string> invoiceItemToList() 
        {
            List<string> itemList = new List<string>();
            itemList.Add(this.Name);
            itemList.Add(this.Quantity.ToString());
            itemList.Add(this.UnitPrice.ToString());
            itemList.Add(this.TotalPrice.ToString());
            return itemList;
        }
    }
    //***************************************************************************************************************************************
    public class ScopeItem 
    {
        public ScopeItem(string title, string comment) 
        {
            this.Title = title;
            this.Comment = comment;
        }

        public string Title { get; set; }
        public string Comment { get; set; }

        public List<string> scopeItemToList() 
        {
            List<string> itemList = new List<string>();
            itemList.Add(this.Title);
            itemList.Add(this.Comment);
            return itemList;
        }
        
    }
    //***************************************************************************************************************************************
    public class OurCompany 
    {
        public OurCompany(List<string> companyInfo = null)
        {
            if (companyInfo == null) { return; }
            (Name, VatNumber, VendorNumber, CurrentlySelected, LogoImage, FooterImage, Number) =
            (companyInfo[0], companyInfo[1], companyInfo[2], companyInfo[3], companyInfo[4], companyInfo[5], Int16.Parse(companyInfo[6]));
        }
        public string Name { get; set; }
        public string VatNumber { get; set; }
        public string VendorNumber { get; set; }
        public string CurrentlySelected { get; set; }
        public string LogoImage { get; set; }
        public string FooterImage { get; set; }
        public Int16 Number { get; set; }

        public List<string> companyToList() 
        {
            List<string> companyDetails = new List<string>();

            companyDetails.Add(this.Name);
            companyDetails.Add(this.VatNumber);
            companyDetails.Add(this.VendorNumber);
            companyDetails.Add(this.CurrentlySelected);
            companyDetails.Add(this.LogoImage);
            companyDetails.Add(this.FooterImage);
            companyDetails.Add(this.Number.ToString());

            return companyDetails;
        }

        public void equateTo(OurCompany company) 
        {
            this.Name = company.Name;
            this.VatNumber = company.VatNumber;
            this.VendorNumber = company.VendorNumber;
            this.FooterImage = company.FooterImage;
            this.LogoImage = company.LogoImage;
        }

        public bool isEqualTo(OurCompany company) 
        {
            if (this.Name == company.Name
                || this.VatNumber == company.VatNumber
                || this.VendorNumber == company.VendorNumber
               ) return true;
            else return false;
        }
    }
    //***************************************************************************************************************************************
    public class InvoiceFileInfo 
    {
        public InvoiceFileInfo(DateTime date, string company, string number) 
        {
            (Date, Company, Number) = (date, company, number);
        }

        public DateTime Date { get; }
        public string Company { get; }
        public string Number { get; }
    }
    //***************************************************************************************************************************************
    public class InvoiceAttachement
    {
        public InvoiceAttachement(string attachmentPath, string name) =>
            (Path, Name) = (attachmentPath, name);

        public string Path{ get; }
        public string Name { get; }
    }
}
