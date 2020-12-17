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


            /*---------------------------           Writing to doc            ------------------------------------*/

            /* Open Document */
            doc.Open();
  
            /* Create Content */


            Paragraph paragraph = new Paragraph("This is my first time using Paragraph! \n hi hello");
            //Now add the above created text using different class object to our pdf document


            /* Add Content to Document */
            doc.Add(paragraph);

            /* Close Document */
            doc.Close();
        }
    }
}
