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
        private Dictionary<string, string> newDict = new Dictionary<string, string>()
                {
                    {"LISTTITLE","" },
                    {"TITLE",""},
                    {"JOBTITLE",""},
                    {"STARTMONTH",""},
                    {"STARTYEAR",""},
                    {"ENDMONTH",""},
                    {"ENDYEAR",""},
                    {"LOC",""},
                    {"DUTIES",""},
                    {"CURRENT","false"}
                };

        private void Jobs_Load(object sender, EventArgs e)
        {
            jhandle = new JSONHandler();
            data = jhandle.ReadFromJSON();

            if(data.Jobs == null)
            {
                
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
            locBox.Text = data.Jobs[index]["LOC"];
            dutiesBox.Text = data.Jobs[index]["DUTIES"];
            if (data.Jobs[index]["CURRENT"] == "true")
            {
                currentCheck.Checked = true;
            }
            else
            {
                currentCheck.Checked = false;
            }
                
        }

        private void jobBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listIndex = jobBox.SelectedIndex;
            allowUpdate = false;
            LoadTextFromIndex(listIndex);
            allowUpdate = true;
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

        private void locBox_TextChanged(object sender, EventArgs e)
        {
            if (data.Jobs[listIndex].ContainsKey("LOC"))
            {
                data.Jobs[listIndex]["LOC"] = locBox.Text;
            }
            else
            {
                data.Jobs[listIndex].Add("LOC", locBox.Text);
            }
        }

        private void dutiesBox_TextChanged(object sender, EventArgs e)
        {
            if (data.Jobs[listIndex].ContainsKey("DUTIES"))
            {
                data.Jobs[listIndex]["DUTIES"] = dutiesBox.Text;
            }
            else
            {
                data.Jobs[listIndex].Add("DUTIES", dutiesBox.Text);
            }
        }

        private void moveUpBtn_Click(object sender, EventArgs e)
        {

        }

        private void moveDownBtn_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddJob("New Job");
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            RemoveJob(listIndex);
        }

        private void ResetTextBoxes()
        {
            titleBox.Text = null;
            jobTitleBox.Text = null;
            startMonth.Value = 1;
            startYear.Value = 2019;
            endMonth.Value = 1;
            endYear.Value = 2020;
            locBox.Text = null;
            dutiesBox.Text = null;
        }

        private void AddJob(string name)
        {
            allowUpdate = false;
            data.Jobs.Add(newDict);
            jobBox.Items.Add(name);
            listIndex = jobBox.Items.Count - 1;
            jobBox.SelectedIndex = listIndex;
            ResetTextBoxes();
            allowUpdate = true;
        }

        private void RemoveJob(int index)
        {
            allowUpdate = false;
            data.Jobs.RemoveAt(index);
            listIndex = 0;
            jobBox.Items.RemoveAt(index);
            jobBox.SelectedIndex = listIndex;
            




            allowUpdate = true;
        }

        private void currentCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (data.Jobs[listIndex].ContainsKey("CURRENT"))
            {
                if (currentCheck.Checked)
                {
                    data.Jobs[listIndex]["CURRENT"] = "true";
                }
                else
                {
                    data.Jobs[listIndex]["CURRENT"] = "false";
                }
            }
            else
            {
                if (currentCheck.Checked)
                {
                    data.Jobs[listIndex].Add("CURRENT", "true");
                }
                else
                {
                    data.Jobs[listIndex].Add("CURRENT", "false");
                }
                
            }
        }
    }
}
