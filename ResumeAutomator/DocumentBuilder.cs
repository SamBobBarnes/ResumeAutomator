using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Font;
using iText.Kernel.Pdf.Action;
using iText.Kernel.Pdf.Canvas.Draw;

namespace ResumeAutomator
{
    public class DocumentBuilder
    {
        public DocumentBuilder()
        {
            // Documentation @ https://afterlogic.com/mailbee-net/docs-itextsharp/
            //Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            
            String docname = "Test";
            PdfWriter writer = null;
            bool read = false;
            try  // Try writing to file
            {
                writer = new PdfWriter(docname + ".pdf");
                read = true;
            }
            catch  // Catch if file is open and display message to user
            {
                string message = "Please close the open PDF or save using a different name.";
                string caption = "Active PDF Open in Another Window";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult msg;
                msg = MessageBox.Show(message, caption, buttons);
                Console.WriteLine("Please close the pdf file that is open");
            }
            if (read)
            {
                PdfDocument pdf = new PdfDocument(writer);
                Document doc = new Document(pdf);

                /* Import Data */
                JSONHandler jhandle = new JSONHandler();
                ResumeData data = jhandle.ReadFromJSON();


                /*---------------------------           Writing to doc            ------------------------------------*/

                /* Open Document */
                //doc.Open();

                /* Register Fonts */
                PdfFontFactory.RegisterDirectory("C:\\Windows\\Fonts");
                PdfFont Courier = PdfFontFactory.CreateRegisteredFont("Courier New");
                PdfFont Gothic = PdfFontFactory.CreateRegisteredFont("Century Gothic");

                /* Create Content */
                Paragraph Name = new Paragraph(data.Name)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFont(Courier)
                    .SetFontSize(34);

                Paragraph Bio = new Paragraph(data.Email + " | " + data.Phone + " | " + data.Address)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFont(Gothic)
                    .SetFontSize(9);

                Paragraph Site = new Paragraph()
                   .Add(new Link("Barnes7619.com", PdfAction.CreateURI("https://Barnes7619.com")).SetUnderline())
                   .SetTextAlignment(TextAlignment.CENTER)
                   .SetFont(Gothic)
                   .SetFontSize(9);

                DottedLine dots = new DottedLine();
                dots.SetGap(1);
                dots.SetLineWidth(1);

                LineSeparator line = new LineSeparator(dots);


                Table SummaryHead = CreateSeparator("Summary")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFont(Courier)
                    .SetFontSize(12);





                ///* Formatting */
                //Name.Alignment = Element.ALIGN_CENTER;
                //Bio.Alignment = Element.ALIGN_CENTER;
                //Site.Alignment = Element.ALIGN_CENTER;

                /* Add Content to Document */
                doc.Add(Name);
                doc.Add(Bio);
                doc.Add(Site);
                doc.Add(line);
                doc.Add(SummaryHead);

                /* Close Document */
                doc.Close();




                /* -------------------------  Completed Message  --------------------------- */
                string message = "Resume Generated!";
                string caption = "Finished";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult msg;
                msg = MessageBox.Show(message, caption, buttons);
            }
        }

        private Table CreateSeparator(string txt)
        {
            txt = "  " + txt + "  ";
            DottedLine dots = new DottedLine();
            dots.SetGap(1);
            dots.SetLineWidth(1);

            LineSeparator line = new LineSeparator(dots);

            Table sep = new Table(UnitValue.CreatePercentArray(100), false).UseAllAvailableWidth()
                .AddCell(new Cell(1, 2).Add(line))
                .AddCell(new Cell(1,1).Add(new Paragraph(txt)))
                .AddCell(new Cell(1, 2).Add(line));
            return sep;
        }
    }
}
