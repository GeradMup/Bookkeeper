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

namespace Invoices.src.models
{
    //*************************************************************************************************************************
    class DocumentHeaderAndFooter : IEventHandler
    {
        private Document document;
        public DocumentHeaderAndFooter(Document doc)
        {
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
            ImageData headerImageData = ImageDataFactory.Create(Constants.LOGO_PATH);
            Image headerImage = new Image(headerImageData);

            float headerImageWidth = 590;
            float headerImageheight = 400;
            float headerImageY = 723;
            float headerImageX = 0;

            headerImage.ScaleToFit(headerImageWidth, headerImageheight);
            headerImage.SetFixedPosition(headerImageX, headerImageY);


            ImageData footerImageData = ImageDataFactory.Create(Constants.FOOTER_PATH);
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

        public void createPDF(Company company, List<InvoiceComment> comments, List<InvoiceItem> invoiceItems)
        {
            // Must have write permissions to the path folder
            PdfDocument pdf = new PdfDocument(new PdfWriter(filePath));
            

            Document document = new Document(pdf);
            document.SetMargins(150f, 0f, 100f, 0f);

            //pdf.AddEventHandler(PdfDocumentEvent.START_PAGE, new DocumentHeaderAndFooter(document));
            DocumentHeaderAndFooter firstPage = new DocumentHeaderAndFooter(document);
            firstPage.firstPage();
            pdf.AddEventHandler(PdfDocumentEvent.END_PAGE, new DocumentHeaderAndFooter(document));

            

            addCompanyInfo(document);
            addCustomerInfo(document, company);
            addComments(document, comments);
            addPricesTable(document, invoiceItems);
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
            Text line1 = new Text($"Dory/0082\n VAT: 4780313955\n { dateString }");
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
            string customerInfoText = "To:\n" + company.Name + "\n" + address + "\n" + company.Town;
            Text customerText = new Text(customerInfoText);
            customerText.SetFontSize(STANDARD_FONT_SIZE);
            customerText.SetBold();

            customerInfoP.Add(customerText);
            document.Add(customerInfoP);
        }

        private void addComments(Document document, List<InvoiceComment> comments) 
        {
            Paragraph commentParagraph = creatParagraph(TextAlignment.LEFT);
            List itemsList = new List(ListNumberingType.DECIMAL);
            itemsList.SetMarginTop(VERTICAL_MARGIN);
            itemsList.SetMarginBottom(VERTICAL_MARGIN);
            itemsList.SetMarginLeft(HORIZONTAL_MARGIN);
            itemsList.SetMarginRight(HORIZONTAL_MARGIN);
            
            foreach (InvoiceComment comment in comments) 
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

        private void addPricesTable(Document document, List<InvoiceItem> items) 
        {
            float[] columnWidths = { 300f, 20f, 90f, 90f };
            Table pricesTable = new Table(columnWidths);
            pricesTable.UseAllAvailableWidth();

            pricesTable.AddHeaderCell(tableHeader("Description"));
            pricesTable.AddHeaderCell(tableHeader("QTY"));
            pricesTable.AddHeaderCell(tableHeader("Price/Unit"));
            pricesTable.AddHeaderCell(tableHeader("Total Price"));

            foreach (InvoiceItem item in items) 
            {
                pricesTable.AddCell(item.Name);
                pricesTable.AddCell(item.Quantity.ToString());
                pricesTable.AddCell(item.UnitPrice.ToString());
                pricesTable.AddCell(item.TotalPrice.ToString());
            }

            Paragraph pricesTableParagraph = creatParagraph(TextAlignment.LEFT);
            pricesTableParagraph.Add(pricesTable);
            document.Add(pricesTableParagraph);
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



