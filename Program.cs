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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Instantiate the main controller
            MainController mainController = new MainController();
            Application.Run(mainController.GetWindow());

            //PDF pdf = new PDF("TEST");
            //List<string> companyInfo = new List<string> { "1", "Envoroserv", "Chloorkop Landfill Facility, Klipfontein 12-LR", "Edenvale", "1245"};
            //Company company = new Company(companyInfo);
            //List<ScopeItem> comments = new List<ScopeItem>();
            //ScopeItem comment1 = new ScopeItem("Engine", "Oil and filter changes, air filter replacement, fuel system inspection and spark plug checks");
            //ScopeItem comment2 = new ScopeItem("Fuel System", "Checking and cleaning the fuel tank, replacing fuel filters, inspecting fuel lines, and ensuring the fuel injectors are functioning correctly");
            //ScopeItem comment3 = new ScopeItem("Cooling System", "Checked cooling system for leaks and blockages. Radiator cleaning and coolant level checks");
            //comments.Add(comment1);
            //comments.Add(comment2);
            //comments.Add(comment3);
            //comments.Add(comment3);
            ////comments.Add(comment3);
            ////comments.Add(comment3);
            ////comments.Add(comment3);
            ////comments.Add(comment3);
            ////comments.Add(comment3);
            ////comments.Add(comment3);
            ////comments.Add(comment3);
            ////comments.Add(comment3);
            ////comments.Add(comment3);


            //List<InvoiceItem> items = new List<InvoiceItem>();

            //items.Add(new InvoiceItem("Major Generator maintenance and parts replacement", 1, 271750));
            //items.Add(new InvoiceItem("Transportation offsite, storage, and back to the site", 1, 4800));
            //items.Add(new InvoiceItem("Consumables", 1, 4800));
            //items.Add(new InvoiceItem("Transportation offsite, storage, and back to the site ", 2, 7000));
            //items.Add(new InvoiceItem("Technician", 1, 8600));
            //items.Add(new InvoiceItem("Technician", 1, 8600));
            //items.Add(new InvoiceItem("Technician", 1, 8600));
            //items.Add(new InvoiceItem("Technician", 1, 8600));

            //pdf.createPDF(company, comments, items);
        }
    }
}
