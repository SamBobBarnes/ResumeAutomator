using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ResumeAutomator
{
    public partial class ResumeAutomator : Form
    {
        public ResumeAutomator()
        {
            InitializeComponent();
        }

        private void createResume_Click(object sender, EventArgs e)
        {
            // Documentation @ https://afterlogic.com/mailbee-net/docs-itextsharp/
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            String docname = "Test";
            int numretrys = 0;
            bool tryreadingfile = true;
            do
            {
                try
                {
                    if (numretrys == 0)
                    {
                        PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(docname + ".pdf", FileMode.Create));
                        tryreadingfile = false;
                    }
                    else
                    {
                        numretrys += 1;
                        PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(docname + numretrys.ToString() + ".pdf", FileMode.Create));
                        tryreadingfile = false;
                    }
                }
                catch (IOException ex)
                {
                    Console.WriteLine("Please close the pdf file that is open");
                }
            } while (tryreadingfile);
            
            doc.Open();// Open Document to write
                       // write some content
            Paragraph paragraph = new Paragraph("This is my first time using Paragraph! \n hi hello");
            //Now add the above created text using different class object to our pdf document
            doc.Add(paragraph);
            doc.Close(); //Close Document

        }
    }
}
