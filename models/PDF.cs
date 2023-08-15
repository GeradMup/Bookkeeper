using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoices.src.models;
using iText.IO.Font;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Pdfa;
using iText;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Events;
using iText.Kernel.Geom;
using iText.Layout.Borders;
using System.Globalization;
using System.Diagnostics;

namespace Invoices.src.models
{
    //*************************************************************************************************************************
    class DocumentHeaderAndFooter : IEventHandler
    {
        private Document document;
        string logoPath;
        string footerPath;
        public DocumentHeaderAndFooter(Document doc, string logo, string footer)
        {
            logoPath = logo;
            footerPath = footer;
            document = doc;
        }

        public void HandleEvent(Event currentEvent)
        {
            //PdfDocumentEvent docEvent = (PdfDocumentEvent)currentEvent;
            //Rectangle pageSize = docEvent.GetPage().GetPageSize();
            firstPage();

        }

        public void firstPage() 
        {
            ImageData headerImageData = ImageDataFactory.Create(logoPath);
            Image headerImage = new Image(headerImageData);

            float headerImageWidth = 590;
            float headerImageheight = 400;
            float headerImageY = 723;
            float headerImageX = 0;

            headerImage.ScaleToFit(headerImageWidth, headerImageheight);
            headerImage.SetFixedPosition(headerImageX, headerImageY);


            ImageData footerImageData = ImageDataFactory.Create(footerPath);
            Image footerImage = new Image(footerImageData);

            float footerImageWidth = 600;
            float footerImageHeight = 250;
            float footerImageY = 0;
            float footerImageX = 0;

            footerImage.ScaleToFit(footerImageWidth, footerImageHeight);
            footerImage.SetFixedPosition(footerImageX, footerImageY);

            document.Add(headerImage);
            document.Add(footerImage);
        }


    }

    //*************************************************************************************************************************

    public class PDF
    {
        string filePath;
        const int STANDARD_FONT_SIZE = 12;
        const int BIG_FONT_SIZE = 15;
        const int HORIZONTAL_MARGIN = 40;
        const int VERTICAL_MARGIN = 10;
        public PDF(string fileName)
        {
            //Let's start by making sure that there is folder for our invoices.
            System.IO.Directory.CreateDirectory(Constants.INVOICES_PATH);
            filePath = Constants.INVOICES_PATH + fileName + ".pdf";
        }

        public void createPDF(Company company, List<ScopeItem> scopeItems, List<InvoiceItem> invoiceItems, List<decimal> totals, string logoPath, string footerPath)
        {
            // Must have write permissions to the path folder
            PdfDocument pdf = new PdfDocument(new PdfWriter(filePath));
            

            Document document = new Document(pdf);
            document.SetMargins(150f, 0f, 100f, 0f);
            //PdfFont docFont = PdfFontFactory.CreateFont(FontProgram.)
            //document.SetFont(new PdfFont())

            //pdf.AddEventHandler(PdfDocumentEvent.START_PAGE, new DocumentHeaderAndFooter(document));
            DocumentHeaderAndFooter firstPage = new DocumentHeaderAndFooter(document, logoPath, footerPath);
            firstPage.firstPage();
            pdf.AddEventHandler(PdfDocumentEvent.END_PAGE, new DocumentHeaderAndFooter(document, logoPath, footerPath));

            addCompanyInfo(document);
            addCustomerInfo(document, company);
            addScopeItems(document, scopeItems);
            addPricesTable(document, invoiceItems, totals);
            addFinalComment(document);
            document.Close();
        }

        private void addCompanyInfo(Document document) 
        {
            Paragraph companyInfo = creatParagraph(TextAlignment.RIGHT);

            Text quote = new Text("Quote:\n");
            quote.SetFontSize(15);
            quote.SetBold();
            quote.SetFontColor(ColorConstants.RED);

            string dateString = DateTime.Now.ToString("dd MMMM yyyy");
            Text line1 = new Text($"Dory/0082\n VAT: 4780313955\n Vendor Number: 58545826 \n { dateString }");
            line1.SetFontSize(STANDARD_FONT_SIZE);
            line1.SetBold();
                
            companyInfo.Add(quote);
            companyInfo.Add(line1);
            document.Add(companyInfo);
        }

        private void addCustomerInfo(Document document, Company company) 
        {
            Paragraph customerInfoP = creatParagraph(TextAlignment.LEFT);

            string address = company.Address.Replace(",", "\n");
            string customerInfoText = "To:\n" + company.Name + "\n" + address + "\n" + company.Town + "\n" + company.AreaCode + "\n\n" ;

            if (company.ContactPerson != "") customerInfoText = customerInfoText + company.ContactPerson + "\n";
            if (company.Title != "") customerInfoText = customerInfoText + company.Title + "\n";
            if (company.Numbers != "") customerInfoText = customerInfoText + company.Numbers + "\n";
            if (company.Email != "") customerInfoText = customerInfoText + company.Email + "\n";

            Text customerText = new Text(customerInfoText);
            customerText.SetFontSize(STANDARD_FONT_SIZE);
            customerText.SetBold();

            customerInfoP.Add(customerText);
            document.Add(customerInfoP);
        }

        private void addScopeItems(Document document, List<ScopeItem> scopeItems) 
        {
            Paragraph commentParagraph = creatParagraph(TextAlignment.LEFT);
            List itemsList = new List(ListNumberingType.DECIMAL);
            itemsList.SetMarginTop(VERTICAL_MARGIN);
            itemsList.SetMarginBottom(VERTICAL_MARGIN);
            itemsList.SetMarginLeft(HORIZONTAL_MARGIN);
            itemsList.SetMarginRight(HORIZONTAL_MARGIN);
            
            foreach (ScopeItem comment in scopeItems) 
            {
               
                Text titleText = new Text(comment.Title + " : ");
                Text commetText = new Text(comment.Comment);
                ListItem item = new ListItem();

                titleText.SetFontSize(STANDARD_FONT_SIZE);
                titleText.SetBold();

                Paragraph itemParagraph = new Paragraph();
                itemParagraph.Add(titleText);
                itemParagraph.Add(commetText);

                item.Add(itemParagraph);

                itemsList.Add(item);
               
            }

            Text scopeText = new Text("Scope of Work");
            scopeText.SetBold();
            scopeText.SetUnderline();

            commentParagraph.Add(scopeText);
            document.Add(commentParagraph);
            document.Add(itemsList);

        }

        private void addPricesTable(Document document, List<InvoiceItem> items, List<decimal> totals = null) 
        {
            float[] columnWidths = { 300f, 20f, 90f, 110f };
            Table pricesTable = new Table(columnWidths);
            pricesTable.UseAllAvailableWidth();
            pricesTable.SetFontSize(STANDARD_FONT_SIZE - 1);

            pricesTable.AddHeaderCell(tableHeader("Description"));
            pricesTable.AddHeaderCell(tableHeader("QTY"));
            pricesTable.AddHeaderCell(tableHeader("Price/Unit"));
            pricesTable.AddHeaderCell(tableHeader("Total Price"));

            foreach (InvoiceItem item in items) 
            {
                pricesTable.AddCell(item.Name);
                pricesTable.AddCell(item.Quantity.ToString());
                pricesTable.AddCell(formatAmount(item.UnitPrice));
                pricesTable.AddCell(formatAmount(item.TotalPrice));
            }

            addTableTotals(totals, pricesTable);


            Paragraph pricesTableParagraph = creatParagraph(TextAlignment.LEFT);
            pricesTableParagraph.Add(pricesTable);
            document.Add(pricesTableParagraph);
        }

        private void addTableTotals(List<decimal> amounts, Table table) 
        {
            string[] descriptions = { "Total", "VAT", "Grand Total" };
            
            for (int totalsRow = 0; totalsRow < 3; totalsRow++) 
            {
                Cell blankCell = new Cell();
                blankCell.SetBorder(Border.NO_BORDER);

                table.AddCell(blankCell);
                table.AddCell(blankCell);

                Paragraph totalsDescription = new Paragraph();
                Text totalsText = new Text(descriptions[totalsRow]);
                totalsText.SetBold();
                totalsDescription.Add(totalsText);

                table.AddCell(totalsDescription);

                Paragraph totalsAmount = new Paragraph();
                Text totalsAmountText = new Text(formatAmount(amounts[totalsRow]));
                totalsAmountText.SetBold();
                totalsAmount.Add(totalsAmountText);

                table.AddCell(totalsAmount);
            }
        }

        private string formatAmount(decimal amount) 
        {
            var nfi = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
            nfi.NumberGroupSeparator = " ";
            string number ="R " +  amount.ToString("#,0.00", nfi);
            return number;
        }

        private void addFinalComment(Document document) 
        {
            string finalComment = "We trust that all the above is correct. Please contact the office for any queries.\nThis quote is valid for 30 days.";
            Paragraph paragraph = creatParagraph(TextAlignment.LEFT);
            
            paragraph.SetBorder(new SolidBorder(Border.SOLID));
            paragraph.SetPadding(3);

            Text text = new Text(finalComment);
            text.SetBold();
            

            paragraph.Add(text);
            document.Add(paragraph);
        }

        Paragraph creatParagraph(TextAlignment alignment) 
        {
            Paragraph newParagraph = new Paragraph();
            newParagraph.SetTextAlignment(alignment);
            newParagraph.SetMarginRight(HORIZONTAL_MARGIN);
            newParagraph.SetMarginLeft(HORIZONTAL_MARGIN);
            newParagraph.SetMarginTop(VERTICAL_MARGIN);
            newParagraph.SetMarginBottom(VERTICAL_MARGIN);

            newParagraph.SetFixedLeading(15f);
            return newParagraph;
        }

        Cell tableHeader(string headerName) 
        {
            Cell headerCell = new Cell();
            Text headerText = new Text(headerName);
            headerText.SetBold();
            headerText.SetFontSize(STANDARD_FONT_SIZE);

            headerCell.Add(new Paragraph(headerText));

            return headerCell;
        }
    }
}


        //private void button1_Click(object sender, EventArgs e)
        //{
        //            if (File.Exists(save.FileName))
        //            {
        //                try
        //                {
        //                    File.Delete(save.FileName);
        //                }
        //                catch (Exception ex)
        //                {
        //                    ErrorMessage = true;
        //                    MessageBox.Show("Unable to wride data in disk" + ex.Message);
        //                }
        //            }
        //            if (!ErrorMessage)
        //            {
        //                try
        //                {
        //                    PdfPTable pTable = new PdfPTable(dataGridView1.Columns.Count);
        //                    pTable.DefaultCell.Padding = 2;
        //                    pTable.WidthPercentage = 100;
        //                    pTable.HorizontalAlignment = Element.ALIGN_LEFT;
        //                    foreach (DataGridViewColumn col in dataGridView1.Columns)
        //                    {
        //                        PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
        //                        pTable.AddCell(pCell);
        //                    }
        //                    foreach (DataGridViewRow viewRow in dataGridView1.Rows)
        //                    {
        //                        foreach (DataGridViewCell dcell in viewRow.Cells)
        //                        {
        //                            pTable.AddCell(dcell.Value.ToString());
        //                        }
        //                    }
        //                    using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
        //                    {
        //                        Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
        //                        PdfWriter.GetInstance(document, fileStream);
        //                        document.Open();
        //                        document.Add(pTable);
        //                        document.Close();
        //                        fileStream.Close();
        //                    }
        //                    MessageBox.Show("Data Export Successfully", "info");
        //                }
        //                catch (Exception ex)
        //                {
        //                    MessageBox.Show("Error while exporting Data" + ex.Message);
        //                }
        //            }



