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
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Test.pdf", FileMode.Create));
            doc.Open();// Open Document to write
            // write some content
            Paragraph paragraph = new Paragraph("This is my first time using Paragraph! \n hi hello");
            //Now add the above created text using different class object to our pdf document
            doc.Add(paragraph);
            doc.Close(); //Close Document
            
        }
    }
}
