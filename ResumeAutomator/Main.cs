using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.IO;
//using iTextSharp.text;
//using iTextSharp.text.pdf;

namespace ResumeAutomator
{
    public partial class ResumeAutomator : Form
    {
        private ResumeData data;
        public ResumeAutomator()
        {
            InitializeComponent();
            data = new ResumeData();
        }

        private void createResume_Click(object sender, EventArgs e)
        {
            DocumentBuilder doc = new DocumentBuilder();//data); // Create new DocumentBuilder
        }

        private void BasicInfoBtn_Click(object sender, EventArgs e)
        {
            BasicInfo basicWindow = new BasicInfo();
            basicWindow.ShowDialog();
        }

        private void SummaryBtn_Click(object sender, EventArgs e)
        {
            Summary summaryWindow = new Summary();
            summaryWindow.ShowDialog();
        }

        private void SpecialCategoryBtn_Click(object sender, EventArgs e)
        {

        }

        private void WorkExperienceBtn_Click(object sender, EventArgs e)
        {
            Jobs jobsWindow = new Jobs();
            jobsWindow.ShowDialog();
        }

        private void SkillsBtn_Click(object sender, EventArgs e)
        {
            Skills skillsWindow = new Skills();
            skillsWindow.ShowDialog();
        }
        
        // Only use CurrentData.json within program.
        // When using other data, load into CurrentData and export out of CurrentData
    }
}
