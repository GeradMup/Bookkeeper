using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.src.models
{
    public static class Constants
    {
        public readonly static string BASE_DIRECTORY = AppDomain.CurrentDomain.BaseDirectory;
        public readonly static string RESOURCES_DIRECTORY = BASE_DIRECTORY + "Resources\\";
        public readonly static string COMPANIES_PATH = RESOURCES_DIRECTORY + "Companies.txt";
        public readonly static decimal VAT_PERCENTAGE = 15;
        public readonly static string DOCUMENTS = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public readonly static string INVOICES_PATH = DOCUMENTS + "\\Invoices\\";
        public readonly static string LOGO_PATH = RESOURCES_DIRECTORY + "Logo2.png";
        public readonly static string FOOTER_PATH = RESOURCES_DIRECTORY + "Footer.jpg";
    }
}
