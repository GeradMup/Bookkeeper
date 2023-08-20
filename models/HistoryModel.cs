﻿using FastMember;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.src.models
{
    public class HistoryModel
    {
        TextFiles textFiles;
        List<List<string>> invoiceInformation = new List<List<string>>();
        List<InvoiceItem> invoiceItems = new List<InvoiceItem>();
        List<ScopeItem> scopeItems = new List<ScopeItem>();
        List<string> quoteInvoiceFileNames = new List<string>();
        List<InvoiceFileInfo> invoiceFileInfos = new List<InvoiceFileInfo>();

        public HistoryModel() 
        {
            textFiles = new TextFiles();
        }

        public DataTable getInvoiceHistory() 
        {

            invoiceFileInfos.Clear();
            quoteInvoiceFileNames.Clear();
            quoteInvoiceFileNames = textFiles.getFileNamesInFolder(Constants.INVOICE_TEXT_FILES_PATH);

            int indexOfFourthSpace;
            int indexOfLastSpace;

            string dateString;
            string companyName;
            string invoiceNumber;
            int companyNameLength;
            
            foreach (string invoiceFile in quoteInvoiceFileNames) 
            {
                indexOfFourthSpace = invoiceFile.IndexOf(" ");                    //First Space
                indexOfFourthSpace = invoiceFile.IndexOf(" ", indexOfFourthSpace + 1);  //Second Space
                indexOfFourthSpace = invoiceFile.IndexOf(" ", indexOfFourthSpace + 1);  //Third Space
                indexOfFourthSpace = invoiceFile.IndexOf(" ", indexOfFourthSpace + 1);  //Fourth Space
                indexOfLastSpace = invoiceFile.LastIndexOf(" ");
                companyNameLength = indexOfLastSpace - indexOfFourthSpace - 1;

                dateString = invoiceFile.Substring(0, indexOfFourthSpace);
                companyName = invoiceFile.Substring(indexOfFourthSpace + 1, companyNameLength);
                invoiceNumber = invoiceFile.Substring(indexOfLastSpace + 1);

                DateTime date = DateTime.ParseExact(dateString, Constants.INVOICE_TEXTFILES_DATE_FORMAT, CultureInfo.InvariantCulture);
                invoiceFileInfos.Add(new InvoiceFileInfo(date, companyName, invoiceNumber));
            }

            DataTable table = new DataTable();

            using (var reader = ObjectReader.Create(invoiceFileInfos, "Date", "Company", "Number")) { table.Load(reader); }
            table.DefaultView.Sort = "Date desc";

            return table;
        }

        public void loadInvoiceItems(string invoiceNumber) 
        {
            invoiceItems.Clear();
            scopeItems.Clear();
            invoiceInformation.Clear();

            InvoiceFileInfo fileInfo = invoiceFileInfos.FirstOrDefault(obj => obj.Number == invoiceNumber);
            string invoiceDate = fileInfo.Date.ToString(Constants.INVOICE_TEXTFILES_DATE_FORMAT);
            string pathToInvoiceFile = Constants.INVOICE_TEXT_FILES_PATH + invoiceDate + " " + fileInfo.Company + " " + invoiceNumber + ".txt";
            invoiceInformation = textFiles.readTextFile(pathToInvoiceFile);

            foreach (List<string> lines in invoiceInformation) 
            {
                if (lines.Count == 4) { invoiceItems.Add(new InvoiceItem(lines[0], decimal.Parse(lines[1]), decimal.Parse(lines[2]))); }
                else if (lines.Count == 2) { scopeItems.Add(new ScopeItem(lines[0], lines[1])); }
            }
        }

        public decimal invoiceTotal() 
        {
            return invoiceItems.Sum(it => it.TotalPrice);
        }

        public List<InvoiceItem> getInvoiceItems() 
        {
            return invoiceItems;
        }

        public List<ScopeItem> getScopeItems() 
        {
            return scopeItems;
        }
    }
}