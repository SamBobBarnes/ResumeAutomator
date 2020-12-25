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
    public partial class Skills : Form
    {
        private int lowestBox = 6;
        private int boxDiff = 26;
        private int tabTracker = 0;

        public Skills()
        {
            InitializeComponent();
        }

        private void Skills_Load(object sender, EventArgs e)
        {
            // Add First Text Box
            SkillBoxList.Add(new TextBox());
            SkillBoxList[0].Location = new System.Drawing.Point(6, 6);
            SkillBoxList[0].Size = new System.Drawing.Size(238, 20);
            SkillBoxList[0].TabIndex = tabTracker;
            this.Controls.Add(SkillBoxList[SkillBoxList.Count - 1]);
            tabTracker += 1;
            

            // Add First Delete Button
            DeleteBtnList.Add(new Button());
            DeleteBtnList[0].Location = new System.Drawing.Point(248, 6);
            DeleteBtnList[0].Size = new System.Drawing.Size(20, 20);
            DeleteBtnList[0].Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            DeleteBtnList[0].Text = "-";
            DeleteBtnList[0].UseVisualStyleBackColor = true;
            DeleteBtnList[0].Click += new System.EventHandler(this.DeleteBtn_Click);
            DeleteBtnList[0].TabIndex = tabTracker;
            DeleteBtnList[0].Enabled = false;
            this.Controls.Add(DeleteBtnList[DeleteBtnList.Count - 1]);
            tabTracker += 1;

            // Add First Add Button
            AddButtonList.Add(new Button());
            AddButtonList[0].Location = new System.Drawing.Point(272, 6);
            AddButtonList[0].Size = new System.Drawing.Size(20, 20);
            AddButtonList[0].Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            AddButtonList[0].Text = "+";
            AddButtonList[0].UseVisualStyleBackColor = true;
            AddButtonList[0].Click += new System.EventHandler(this.AddButton_Click);
            AddButtonList[0].TabIndex = tabTracker;
            this.Controls.Add(AddButtonList[AddButtonList.Count - 1]);
            tabTracker += 1;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            lowestBox += boxDiff;

            // Add next Text Box
            int index = SkillBoxList.Count;
            SkillBoxList.Add(new TextBox());
            SkillBoxList[index].Location = new System.Drawing.Point(6, lowestBox);
            SkillBoxList[index].Size = new System.Drawing.Size(238, 20);
            SkillBoxList[index].TabIndex = tabTracker;
            this.Controls.Add(SkillBoxList[index]);
            tabTracker += 1;

            // Add next Delete Button
            index = DeleteBtnList.Count;
            DeleteBtnList.Add(new Button());
            DeleteBtnList[index].Location = new System.Drawing.Point(248, lowestBox);
            DeleteBtnList[index].Size = new System.Drawing.Size(20, 20);
            DeleteBtnList[index].Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            DeleteBtnList[index].Text = "-";
            DeleteBtnList[index].UseVisualStyleBackColor = true;
            DeleteBtnList[index].TabIndex = tabTracker;
            DeleteBtnList[index].Click += new System.EventHandler(this.DeleteBtn_Click);
            this.Controls.Add(DeleteBtnList[index]);
            tabTracker += 1;


            // Add next Add Button
            index = AddButtonList.Count;
            AddButtonList.Add(new Button());
            AddButtonList[index].Location = new System.Drawing.Point(272, lowestBox);
            AddButtonList[index].Size = new System.Drawing.Size(20, 20);
            AddButtonList[index].Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            AddButtonList[index].Text = "+";
            AddButtonList[index].UseVisualStyleBackColor = true;
            AddButtonList[index].Click += new System.EventHandler(this.AddButton_Click);
            AddButtonList[index].TabIndex = tabTracker;
            this.Controls.Add(AddButtonList[index]);
            tabTracker += 1;

            // Disable Add Buttons
            foreach (Button but in AddButtonList) {
                this.Controls.Remove(but);
            }
            AddButtonList = DisableUnlessLast(AddButtonList);
            foreach (Button but in AddButtonList)
            {
                this.Controls.Add(but);
            }

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }

        private List<Button> DisableUnlessLast(List<Button> buts)
        {
            int lastIndex = buts.Count - 1;
            foreach (Button but in buts)
            {
                but.Visible = false;
            }
            buts[lastIndex].Visible = true;
            return buts;
        }

        private void Skills_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
