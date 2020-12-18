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

namespace ResumeAutomator
{
    public class DocumentBuilder
    {
        public DocumentBuilder()
        {
            // Documentation @ https://afterlogic.com/mailbee-net/docs-itextsharp/
            //Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            
            String docname = "Test";
            PdfWriter writer = new PdfWriter(docname + ".pdf");

            try  // Try writing to file
            {
                //PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(docname + ".pdf", FileMode.Create));
                //writer = new PdfWriter(docname + ".pdf");
            }
            catch (IOException ex)  // Catch if file is open and display message to user
            {
                string message = "Please close the open PDF or save using a different name.";
                string caption = "Active PDF Open in Another Window";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult msg;
                msg = MessageBox.Show(message, caption, buttons);
                Console.WriteLine("Please close the pdf file that is open");
            }

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
            //Paragraph Name = new Paragraph(data.Name, Courier34);
            Paragraph Name = new Paragraph(data.Name)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFont(Courier)
                .SetFontSize(34);
            //Paragraph Bio = new Paragraph(data.Email + " | " + data.Phone + " | " + data.Address, Gothic9);
            Paragraph Bio = new Paragraph(data.Email + " | " + data.Phone + " | " + data.Address)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFont(Courier)
                .SetFontSize(9);
            //Paragraph Site = new Paragraph();
            //Site.Add(new Chunk(data.Site, Gothic9).SetAnchor("https://Barnes7619.com"));
            Paragraph Site = new Paragraph()
               .Add(new Link("Barnes7619.com", PdfAction.CreateURI("https://Barnes7619.com")).SetUnderline())
               .SetTextAlignment(TextAlignment.CENTER)
               .SetFont(Courier)
               .SetFontSize(9);


            //Paragraph SummaryHead = CreateSeparator("Summary");
            Paragraph SummaryHead = CreateSeparator("Summary")
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
            doc.Add(SummaryHead);

            /* Close Document */
            doc.Close();
        }

        private Paragraph CreateSeparator(string txt)
        {
            string line = "---------------------";

            Paragraph sep = new Paragraph(line + "  " + txt + "  " + line);
            return sep;
        }
    }
}
