using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.src.DataObjects
{
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
}
