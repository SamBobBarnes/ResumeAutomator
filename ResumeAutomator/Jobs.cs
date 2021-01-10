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
    public partial class Jobs : Form
    {
        public Jobs()
        {
            InitializeComponent();
        }

        private ResumeData data;
        private JSONHandler jhandle;
        private int listIndex;
        private bool allowUpdate = false;

        private void Jobs_Load(object sender, EventArgs e)
        {
            jhandle = new JSONHandler();
            data = jhandle.ReadFromJSON();

            if(data.Jobs == null)
            {
                Dictionary<string, string> newDict = new Dictionary<string, string>()
                {
                    {"LISTTITLE","First Job" }
                };
                jobBox.Items.Add("First Job");
                data.Jobs = new List<Dictionary<string, string>>();
                data.Jobs.Add(newDict);
            }
            else
            {
                foreach (Dictionary<string,string> dict in data.Jobs)
                {
                    jobBox.Items.Add(dict["LISTTITLE"]);
                }
                LoadTextFromIndex(0);
            }

            jobBox.SelectedIndex = 0;

            allowUpdate = true;

        }

        private void titleBox_TextChanged(object sender, EventArgs e)
        {
            UpdateJobText();

            // add text to data
            if (data.Jobs[listIndex].ContainsKey("TITLE"))
            {
                data.Jobs[listIndex]["TITLE"] = titleBox.Text;
            }
            else
            {
                data.Jobs[listIndex].Add("TITLE", titleBox.Text);
            }
            
        }

        private void jobTitleBox_TextChanged(object sender, EventArgs e)
        {
            UpdateJobText();

            // add text to data
            if (data.Jobs[listIndex].ContainsKey("JOBTITLE"))
            {
                data.Jobs[listIndex]["JOBTITLE"] = jobTitleBox.Text;
            }
            else
            {
                data.Jobs[listIndex].Add("JOBTITLE", jobTitleBox.Text);
            }
        }

        private void UpdateJobText()
        {
            if (allowUpdate)
            {
                string jobText;

                if (jobTitleBox.Text != "" && titleBox.Text != "")
                {
                    jobText = titleBox.Text + " - " + jobTitleBox.Text;
                }
                else if (titleBox.Text == "")
                {
                    jobText = jobTitleBox.Text;
                }
                else
                {
                    jobText = titleBox.Text;
                }
                jobBox.Items[jobBox.SelectedIndex] = jobText;
                data.Jobs[listIndex]["LISTTITLE"] = jobText;
            }
            
        }

        private void LoadTextFromIndex(int index)
        {
            titleBox.Text = data.Jobs[index]["TITLE"];
            jobTitleBox.Text = data.Jobs[index]["JOBTITLE"];
            startMonth.Value = Int32.Parse(data.Jobs[index]["STARTMONTH"]);
            startYear.Value = Int32.Parse(data.Jobs[index]["STARTYEAR"]);
            endMonth.Value = Int32.Parse(data.Jobs[index]["ENDMONTH"]);
            endYear.Value = Int32.Parse(data.Jobs[index]["ENDYEAR"]);
        }

        private void jobBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listIndex = jobBox.SelectedIndex;
        }

        private void Jobs_FormClosing(object sender, FormClosingEventArgs e)
        {
            jhandle.WriteToJSON(data);
        }

        private void startMonth_ValueChanged(object sender, EventArgs e)
        {
            if (data.Jobs[listIndex].ContainsKey("STARTMONTH"))
            {
                data.Jobs[listIndex]["STARTMONTH"] = startMonth.Value.ToString();
            }
            else
            {
                data.Jobs[listIndex].Add("STARTMONTH", startMonth.Value.ToString());
            }
        }

        private void startYear_ValueChanged(object sender, EventArgs e)
        {
            if (data.Jobs[listIndex].ContainsKey("STARTYEAR"))
            {
                data.Jobs[listIndex]["STARTYEAR"] = startYear.Value.ToString();
            }
            else
            {
                data.Jobs[listIndex].Add("STARTYEAR", startYear.Value.ToString());
            }
        }

        private void endMonth_ValueChanged(object sender, EventArgs e)
        {
            if (data.Jobs[listIndex].ContainsKey("ENDMONTH"))
            {
                data.Jobs[listIndex]["ENDMONTH"] = endMonth.Value.ToString();
            }
            else
            {
                data.Jobs[listIndex].Add("ENDMONTH", endMonth.Value.ToString());
            }
        }

        private void endYear_ValueChanged(object sender, EventArgs e)
        {
            if (data.Jobs[listIndex].ContainsKey("ENDYEAR"))
            {
                data.Jobs[listIndex]["ENDYEAR"] = endYear.Value.ToString();
            }
            else
            {
                data.Jobs[listIndex].Add("ENDYEAR", endYear.Value.ToString());
            }
        }
    }
}
