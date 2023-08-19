using FastMember;
using System;
using System.Collections.Generic;
using System.Data;
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

            int indexOfThirdSpace;
            int indexOfLastSpace;

            string dateString;
            string companyName;
            string invoiceNumber;
            int companyNameLength;
            
            foreach (string invoiceFile in quoteInvoiceFileNames) 
            {
                indexOfThirdSpace = invoiceFile.IndexOf(" ");                    //First Space
                indexOfThirdSpace = invoiceFile.IndexOf(" ", indexOfThirdSpace + 1);  //Second Space
                indexOfThirdSpace = invoiceFile.IndexOf(" ", indexOfThirdSpace + 1);  //Third Space
                indexOfLastSpace = invoiceFile.LastIndexOf(" ");
                companyNameLength = indexOfLastSpace - indexOfThirdSpace - 1;

                dateString = invoiceFile.Substring(0, indexOfThirdSpace);
                companyName = invoiceFile.Substring(indexOfThirdSpace + 1, companyNameLength);
                invoiceNumber = invoiceFile.Substring(indexOfLastSpace + 1);

                invoiceFileInfos.Add(new InvoiceFileInfo(DateTime.Parse(dateString), companyName, invoiceNumber));
            }

            DataTable table = new DataTable();

            using (var reader = ObjectReader.Create(invoiceFileInfos, "Date", "Company", "Number")) { table.Load(reader); }


            return table;
        }

        public void loadInvoiceItems(string invoiceNumber) 
        {
            invoiceItems.Clear();
            scopeItems.Clear();
            invoiceInformation.Clear();

            string pathToInvoiceFile = Constants.INVOICE_TEXT_FILES_PATH + invoiceNumber + ".txt";
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
