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

namespace Invoices.src.models
{
    public class PDF
    {
        string filePath;

        public PDF(string fileName)
        {
            //Let's start by making sure that there is folder for our invoices.
            System.IO.Directory.CreateDirectory(Constants.INVOICES_PATH);
            filePath = Constants.INVOICES_PATH + fileName + ".pdf";
        }

        public void createPDF()
        {
            // Must have write permissions to the path folder
            PdfDocument pdf = new PdfDocument(new PdfWriter(filePath));
            Document document = new Document(pdf);
            String line = "I am now pissed";
            document.Add(new Paragraph(line));
            addLogo(document);
            document.Close();
        }

        private void addLogo(Document document) 
        {
            ImageData imageData = ImageDataFactory.Create(Constants.LOGO_PATH);
            Image image = new Image(imageData);
            document.Add(image);
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



