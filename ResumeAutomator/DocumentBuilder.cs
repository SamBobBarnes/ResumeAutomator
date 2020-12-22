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
using iText.Layout.Borders;

namespace ResumeAutomator
{
    public class DocumentBuilder
    {
        //static private ResumeData data;   
        public DocumentBuilder()//ResumeData import)
        {

            //data = import;

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

               

                /* Register Fonts */
                PdfFontFactory.RegisterDirectory("C:\\Windows\\Fonts");
                PdfFont Courier = PdfFontFactory.CreateRegisteredFont("Courier New");
                PdfFont Gothic = PdfFontFactory.CreateRegisteredFont("Century Gothic");

                /* Create Content */
                Paragraph Name = new Paragraph(data.Name)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFont(Courier)
                    .SetFontSize(34);

                Paragraph Bio = new Paragraph(data.Email + " | " + data.Phone + " | " + data.Address1)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFont(Gothic)
                    .SetFontSize(9);

                Paragraph Site = new Paragraph()
                   .Add(new Link("Barnes7619.com", PdfAction.CreateURI("https://Barnes7619.com")).SetUnderline())
                   .SetTextAlignment(TextAlignment.CENTER)
                   .SetFont(Gothic)
                   .SetFontSize(9);


                Table SummaryHead = CreateSeparator("Summary", Courier);

                Table EducationHead = CreateSeparator("Education & Training", Courier);

                Table SoftwareHead = CreateSeparator("Software Experience", Courier);

                Table ExperienceHead = CreateSeparator("Experience", Courier);

                Table SkillsHead = CreateSeparator("Skills", Courier);




                ///* Formatting */
                //Name.Alignment = Element.ALIGN_CENTER;
                //Bio.Alignment = Element.ALIGN_CENTER;
                //Site.Alignment = Element.ALIGN_CENTER;

                /* Add Content to Document */
                doc.Add(Name);
                doc.Add(Bio);
                doc.Add(Site);
                doc.Add(SummaryHead);
                doc.Add(EducationHead);
                doc.Add(SoftwareHead);
                doc.Add(ExperienceHead);
                doc.Add(SkillsHead);

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

        private Table CreateSeparator(string txt, PdfFont font)
        {
            txt = "  " + txt + "  ";
            int txtLength = txt.Length;
            DottedLine dots = new DottedLine();
            dots.SetGap((float)0.5);
            dots.SetLineWidth(1);

            LineSeparator line = new LineSeparator(dots).SetMarginTop(8);

            float sepPer;
            float txtPer;

            if (txtLength < 12) { sepPer = 45; txtPer = 10; }
            else if (txtLength < 22) { sepPer = 40; txtPer = 20; }
            else if (txtLength < 32) { sepPer = 35; txtPer = 30; }
            else { sepPer = 30; txtPer = 40; }

            

            UnitValue[] colVals = new UnitValue[] { UnitValue.CreatePercentValue(sepPer), UnitValue.CreatePercentValue(txtPer), UnitValue.CreatePercentValue(sepPer) };

            Table sep = new Table(colVals).UseAllAvailableWidth()
                .AddCell(new Cell(1, 1).Add(line).SetBorder(Border.NO_BORDER))
                .AddCell(new Cell(1,1).Add(new Paragraph(txt)).SetBorder(Border.NO_BORDER))
                .AddCell(new Cell(1, 1).Add(line).SetBorder(Border.NO_BORDER))
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFont(font)
                .SetFontSize(12);
            return sep;
        }
    }
}
