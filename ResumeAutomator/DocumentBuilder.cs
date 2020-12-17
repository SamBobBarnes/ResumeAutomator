using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ResumeAutomator
{
    public class DocumentBuilder
    {
        public DocumentBuilder()
        {
            // Documentation @ https://afterlogic.com/mailbee-net/docs-itextsharp/
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            String docname = "Test";

            try  // Try writing to file
            {
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(docname + ".pdf", FileMode.Create));
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

            /* Import Data */
            JSONHandler jhandle = new JSONHandler();
            ResumeData data = jhandle.ReadFromJSON();


            /*---------------------------           Writing to doc            ------------------------------------*/

            /* Open Document */
            doc.Open();

            /* Register Fonts */
            FontFactory.RegisterDirectory("C:\\Windows\\Fonts");
            Font Courier34 = FontFactory.GetFont("Courier New", 34);
            Font Courier12 = FontFactory.GetFont("Courier New", 12);
            Font Gothic9 = FontFactory.GetFont("Century Gothic", 9);

            /* Create Content */
            Paragraph Name = new Paragraph(data.Name, Courier34);
            Paragraph Bio = new Paragraph(data.Email + " | " + data.Phone + " | " + data.Address, Gothic9);

            Paragraph Site = new Paragraph();
            Site.Add(new Chunk(data.Site, Gothic9).SetAnchor("https://Barnes7619.com"));

            Paragraph SummaryHead = CreateSeparator("Summary");
            
            


            /* Formatting */
            Name.Alignment = Element.ALIGN_CENTER;
            Bio.Alignment = Element.ALIGN_CENTER;
            Site.Alignment = Element.ALIGN_CENTER;

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
            
            Chunk line = new Chunk("                                        ");
            line.SetUnderline(1.5f, 3.5f);

            Paragraph sep = new Paragraph(line + "  " + txt + "  " + line);
            return sep;
        }
    }
}
