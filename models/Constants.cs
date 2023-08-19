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
        public readonly static string OUR_COMPANIES_PATH = RESOURCES_DIRECTORY + "OurCompanies.txt";
        public readonly static string QUOTE_NUMBER_PATH = RESOURCES_DIRECTORY + "Quote Numbers.txt";
        public readonly static string INVOICE_NUMBER_PATH = RESOURCES_DIRECTORY + "Invoice Numbers.txt";
        public readonly static string INVOICE_TEXT_FILES_PATH = RESOURCES_DIRECTORY + "\\Invoices\\";
    }
}
