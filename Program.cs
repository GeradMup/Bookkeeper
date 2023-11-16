using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invoices.src.controllers;
using Invoices.src.views;

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

            string projectPath = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
            projectPath = System.Reflection.Assembly.GetEntryAssembly().Location;
            string databasePath = Path.GetDirectoryName(projectPath) + "\\Resources\\Data\\";
            AppDomain.CurrentDomain.SetData("DataDirectory", databasePath); 
           // MessageBox.Show(AppDomain.CurrentDomain.GetData("DataDirectory").ToString());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Instantiate the main controller
            MainController mainController = new MainController();
            try
            {
                Application.Run(mainController.GetWindow());
            }
            catch (Exception ex) 
            {
                CustomMessageBox.Show(mainController.GetWindow(), ex.Message, MessageType.MildWarning);
            }
        }
    }
}
