using FastMember;
using Invoices.src.DataObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoices.src.models
{
    public class HistoryModel
    {
        TextFiles textFiles = new TextFiles();
        List<List<String>> invoiceInformation = new List<List<String>>();
        List<InvoiceItem> invoiceItems = new List<InvoiceItem>();
        List<ScopeItem> scopeItems = new List<ScopeItem>();
        List<String> quoteInvoiceFileNames = new List<String>();
        List<InvoiceFileInfo> invoiceFileInfos = new List<InvoiceFileInfo>();
        List<InvoiceAttachement> invoiceAttachements = new List<InvoiceAttachement>();
        FileExplorer fileExplorer = new FileExplorer();
        List<String> invoiceFilesMonths = new List<String>();

        public HistoryModel()
        {
            //string monthInvoicesFolder Constants.INVOICES_PATH;   // + "\\" + Constants.CURRENT_MONTH_YEAR;
            if (Directory.Exists(Constants.INVOICES_PATH) == false) Directory.CreateDirectory(Constants.INVOICES_PATH);
            //if ()

            string monthInvoicesTextFilesFolder = Constants.INVOICE_TEXT_FILES_PATH + "\\" + Constants.CURRENT_MONTH_YEAR;
            if (Directory.Exists(monthInvoicesTextFilesFolder) == false) Directory.CreateDirectory(monthInvoicesTextFilesFolder);

            invoiceFilesMonths = fileExplorer.getSubfolderNames(Constants.INVOICE_TEXT_FILES_PATH);
        }

        public DataTable getInvoiceHistory(string month)
        {

            invoiceFileInfos.Clear();
            quoteInvoiceFileNames.Clear();
            quoteInvoiceFileNames = textFiles.getFileNamesInFolder(Constants.INVOICE_TEXT_FILES_PATH + "\\" + month);

            int indexOfFourthSpace;
            int indexOfLastSpace;

            string dateString;
            string companyName;
            string invoiceNumber;
            int companyNameLength;

            foreach (string invoiceFile in quoteInvoiceFileNames)
            {
                indexOfFourthSpace = invoiceFile.IndexOf(" ");                          //First Space
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

        public List<string> getInvoiceMonths() 
        {
            return invoiceFilesMonths;
        }

        public void loadInvoiceItems(string invoiceNumber, string month, DateTime invoiceDate)
        {
            invoiceItems.Clear();
            scopeItems.Clear();
            invoiceInformation.Clear();
            invoiceAttachements.Clear();

            InvoiceFileInfo fileInfo = invoiceFileInfos.FirstOrDefault(obj => obj.Date == invoiceDate);
            string invoiceDateString = invoiceDate.ToString(Constants.INVOICE_TEXTFILES_DATE_FORMAT);
            string pathToInvoiceFile = Constants.INVOICE_TEXT_FILES_PATH + "\\" + month + "\\" +  invoiceNumber + "\\" + invoiceDateString + " " + fileInfo.Company + " " + invoiceNumber + ".txt";
            invoiceInformation = textFiles.readTextFile(pathToInvoiceFile);

            foreach (List<string> lines in invoiceInformation)
            {
                if (lines.Count == 4) { invoiceItems.Add(new InvoiceItem(lines[0], decimal.Parse(lines[1]), decimal.Parse(lines[2]))); }
                else if (lines.Count == 2) { scopeItems.Add(new ScopeItem(lines[0], lines[1])); }
            }

            loadAttachments(invoiceNumber);
        }

        private void loadAttachments(string invoiceNumber)
        {
            string path = Constants.INVOICES_PATH + invoiceNumber;
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileInfo[] Files = directoryInfo.GetFiles("*", SearchOption.AllDirectories);

            //int nameLength;
            foreach (FileInfo file in Files)
            {
                //nameLength = fileName.Length - 4;
                ////This is to remove the .txt extension
                //fileName = fileName.Substring(0, nameLength);
                invoiceAttachements.Add(new InvoiceAttachement(file.FullName, file.Name));
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

        public List<InvoiceAttachement> getAttachments()
        {
            return invoiceAttachements;
        }

        public bool addAttachments(InvoiceFileInfo invoice)
        {
            //Let's first try to get our attachments.
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = fileDialog.FileName;
                string fileName = Path.GetFileName(filePath);
                string folderPath = Constants.INVOICES_PATH + invoice.Number + "\\";
                bool overwrite = true;
                
                File.Copy(filePath, folderPath + fileName, overwrite);

                return true;
            }
            return false;
        }

        public void openAttachment(string attachmentName, string invoiceNumber)
        {
            string filePath = Constants.INVOICES_PATH + invoiceNumber + "\\" + attachmentName;
            System.Diagnostics.Process.Start(Constants.INVOICES_PATH + invoiceNumber);
            System.Diagnostics.Process.Start(filePath);
        }

        public void deleteAttachment(string attachmentName, string invoiceNumber)
        {
            string filePath = Constants.INVOICES_PATH + invoiceNumber + "\\" + attachmentName;
            File.Delete(filePath);
        }
    }
}
