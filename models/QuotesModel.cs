﻿using FastMember;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoices.src.models
{
    public class QuotesModel
    {
        string currentMonth = DateTime.Now.ToString("MMMM yyyy");
        FileExplorer fileExplorer = new FileExplorer();

        List<string> quotes = new List<string>();
        public QuotesModel() 
        {
            //Let's start by creating the folder where our Quotes need to go.
            string quotesFolder = Constants.QUOTES_PATH + $"\\{currentMonth}";
            if (Directory.Exists(quotesFolder) == false) { Directory.CreateDirectory(quotesFolder); }
        }

        public List<string> getQuoteMonths() 
        {
            return fileExplorer.getSubfolderNames(Constants.QUOTES_PATH);
        }

        public void addQuote() 
        {
            string destinationfolder = Constants.QUOTES_PATH + $"\\{currentMonth}" + "\\";
            fileExplorer.copyFileThroughDialogBox(destinationfolder);
        }

        public void monthSelected(string selectedMonth) 
        {
            quotes.Clear();

            string folderPath = Constants.QUOTES_PATH + selectedMonth;
            quotes = fileExplorer.getFilesInFolder(folderPath);
        }

        public DataTable getQuotesData() 
        {
            DataTable quotesTable = new DataTable();
            string quotesRowName = "Quotes";
            quotesTable.Columns.Add(quotesRowName, typeof(string));
            foreach (string quote in quotes)
            {
                DataRow row = quotesTable.NewRow();
                row[quotesRowName] = quote;
                quotesTable.Rows.Add(row);
            }

            return quotesTable;
        }

        public void viewQuote(string selectedQuote, string month) 
        {
            string pathToQuote = Constants.QUOTES_PATH + month + "\\" + selectedQuote;
            System.Diagnostics.Process.Start(pathToQuote);
        }
    }
}
