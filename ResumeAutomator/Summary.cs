using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResumeAutomator
{
    public partial class Summary : Form
    {

        private ResumeData data;
        private JSONHandler jhandle;
        private bool Loaded;

        public Summary()
        {
            InitializeComponent();
        }

        private void Summary_Load(object sender, EventArgs e)
        {
            jhandle = new JSONHandler();
            data = jhandle.ReadFromJSON();

            /* Load data into TextBoxs */
            Loaded = false;

            SummaryBox.Text = data.Summary;

            Loaded = true;
        }

        private void Summary_FormClosing(object sender, FormClosingEventArgs e)
        {
            data.Summary = SummaryBox.Text;
            jhandle.WriteToJSON(data);
        }
    }
}
