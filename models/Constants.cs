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
    }
}
