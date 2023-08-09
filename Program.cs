using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invoices.src.controllers;
using Invoices.src.models;

namespace Invoices
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            ////Instantiate the main controller
            //MainController mainController = new MainController();
            //Application.Run(mainController.GetWindow());

            PDF pdf = new PDF("TEST");
            List<string> companyInfo = new List<string> { "1", "Envoroserv", "Chloorkop Landfill Facility, Klipfontein 12-LR", "Edenvale", "1245"};
            Company company = new Company(companyInfo);
            List<InvoiceComment> comments = new List<InvoiceComment>();
            InvoiceComment comment1 = new InvoiceComment("Engine", "Oil and filter changes, air filter replacement, fuel system inspection and spark plug checks");
            InvoiceComment comment2 = new InvoiceComment("Fuel System", "Checking and cleaning the fuel tank, replacing fuel filters, inspecting fuel lines, and ensuring the fuel injectors are functioning correctly");
            InvoiceComment comment3 = new InvoiceComment("Cooling System", "Checked cooling system for leaks and blockages. Radiator cleaning and coolant level checks");
            comments.Add(comment1);
            comments.Add(comment2);
            comments.Add(comment3);
            pdf.createPDF(company, comments);
        }
    }
}
