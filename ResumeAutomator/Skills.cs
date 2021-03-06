﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResumeAutomator
{
    public partial class Skills : Form
    {
        private int highestbox = 6;
        private int lowestBox = 32;
        private int boxDiff = 26;
        private int tabTracker = 0;
        private int addButX = 272;
        private int delButX = 248;

        private ResumeData data;
        private JSONHandler jhandle;

        public Skills()
        {
            InitializeComponent();
        }

        private void LoadSkills()
        {

        }

        private void SaveSkills()
        {
            List<string> skillList = new List<string>();
            foreach(TextBox skill in SkillBoxList)
            {
                if (skill.Text != "")
                {
                    skillList.Add(skill.Text);
                }
            }
            data.Skills = skillList;
            jhandle.WriteToJSON(data);
        }

        private void Skills_Load(object sender, EventArgs e)
        {
            // Load Data
            jhandle = new JSONHandler();
            data = jhandle.ReadFromJSON();

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
            DeleteBtnList[0].Click += delegate (object senderLoc, EventArgs eLoc) { DeleteBtn_Click(senderLoc, eLoc, 0); }; //new System.EventHandler(this.DeleteBtn_Click);
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


            // Add text to SkillBoxes
            if (data.Skills.Count != 0)
            {
                for (int i = 0; i < data.Skills.Count - 1; i++)
                {
                    AddRow();
                }
                for (int i = 0; i < data.Skills.Count; i++)
                {
                    SkillBoxList[i].Text = data.Skills[i];
                }

                // Add Extra Row
                AddRow();
            }

            
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            

            // Add next Text Box
            int index = SkillBoxList.Count;
            SkillBoxList.Add(new TextBox());
            SkillBoxList[index].Location = new System.Drawing.Point(6, lowestBox);
            SkillBoxList[index].Size = new System.Drawing.Size(238, 20);
            SkillBoxList[index].TabIndex = tabTracker;
            this.Controls.Add(SkillBoxList[index]);
            tabTracker += 1;
            int skillIndex = index;

            // Add next Delete Button
            index = DeleteBtnList.Count;
            DeleteBtnList.Add(new Button());
            DeleteBtnList[index].Location = new System.Drawing.Point(248, lowestBox);
            DeleteBtnList[index].Size = new System.Drawing.Size(20, 20);
            DeleteBtnList[index].Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            DeleteBtnList[index].Text = "-";
            DeleteBtnList[index].UseVisualStyleBackColor = true;
            DeleteBtnList[index].TabIndex = tabTracker;

            DeleteBtnList[index].Click += delegate (object senderLoc, EventArgs eLoc) { DeleteBtn_Click(senderLoc, eLoc, index); }; //new System.EventHandler(this.DeleteBtn_Click);
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

            // Disable Add Buttons Except Last
            foreach (Button but in AddButtonList) {
                this.Controls.Remove(but);
            }
            AddButtonList = DisableUnlessLast(AddButtonList);
            foreach (Button but in AddButtonList)
            {
                this.Controls.Add(but);
            }

            // Enable First Delete Button When List > 1
            if(DeleteBtnList.Count == 2)
            {
                DeleteBtnList[0].Enabled = true;
            }

            lowestBox += boxDiff;

        }

        private void AddRow()
        {


            // Add next Text Box
            int index = SkillBoxList.Count;
            SkillBoxList.Add(new TextBox());
            SkillBoxList[index].Location = new System.Drawing.Point(6, lowestBox);
            SkillBoxList[index].Size = new System.Drawing.Size(238, 20);
            SkillBoxList[index].TabIndex = tabTracker;
            this.Controls.Add(SkillBoxList[index]);
            tabTracker += 1;
            int skillIndex = index;

            // Add next Delete Button
            index = DeleteBtnList.Count;
            DeleteBtnList.Add(new Button());
            DeleteBtnList[index].Location = new System.Drawing.Point(248, lowestBox);
            DeleteBtnList[index].Size = new System.Drawing.Size(20, 20);
            DeleteBtnList[index].Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            DeleteBtnList[index].Text = "-";
            DeleteBtnList[index].UseVisualStyleBackColor = true;
            DeleteBtnList[index].TabIndex = tabTracker;

            DeleteBtnList[index].Click += delegate (object senderLoc, EventArgs eLoc) { DeleteBtn_Click(senderLoc, eLoc, index); }; //new System.EventHandler(this.DeleteBtn_Click);
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

            // Disable Add Buttons Except Last
            foreach (Button but in AddButtonList)
            {
                this.Controls.Remove(but);
            }
            AddButtonList = DisableUnlessLast(AddButtonList);
            foreach (Button but in AddButtonList)
            {
                this.Controls.Add(but);
            }

            // Enable First Delete Button When List > 1
            if (DeleteBtnList.Count == 2)
            {
                DeleteBtnList[0].Enabled = true;
            }

            lowestBox += boxDiff;

        }

        private void DeleteBtn_Click(object sender, EventArgs e, int index)
        {
            this.Controls.Remove(DeleteBtnList[DeleteBtnList.Count - 1]);
            this.Controls.Remove(AddButtonList[AddButtonList.Count - 1]);
            this.Controls.Remove(SkillBoxList[index]);
            DeleteBtnList.RemoveAt(DeleteBtnList.Count - 1);
            AddButtonList.RemoveAt(AddButtonList.Count - 1);
            SkillBoxList.RemoveAt(index);
            if(DeleteBtnList.Count == 1)
            {
                DeleteBtnList[0].Enabled = false;
            }
            foreach (Button but in AddButtonList)   // Remove all add buttons from controls
            {
                this.Controls.Remove(but);
            }
            foreach (Button but in DeleteBtnList)   // Remove all delete buttons from controls
            {
                this.Controls.Remove(but);
            }
            foreach (TextBox skill in SkillBoxList) // Remove all skill boxes from controls
            {
                this.Controls.Remove(skill);
            }
            AddButtonList = DisableUnlessLast(AddButtonList); 
            AddButtonList = RewriteButtonYandIndex(AddButtonList, true);
            DeleteBtnList = RewriteButtonYandIndex(DeleteBtnList, false);
            SkillBoxList = RewriteTextYandIndex(SkillBoxList);
            foreach (Button but in AddButtonList)   // Add all add buttons to controls
            {
                this.Controls.Add(but);
            }
            foreach (Button but in DeleteBtnList)   // Add all delete buttons to controls
            {
                this.Controls.Add(but);
            }
            foreach (TextBox skill in SkillBoxList) // Add all skill boxes to controls
            {
                this.Controls.Add(skill);
            }


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

        private List<Button> RewriteButtonYandIndex(List<Button> buts, bool isAddBut)
        {
            lowestBox = highestbox;
            for(int i = 0; i == buts.Count - 1; i++)
            {
                RemoveClickEvent(buts[i]);
                buts[i].Location = new System.Drawing.Point(addDel ? addButX : delButX, lowestBox);
                if (addDel)
                {
                    buts[i].Click += delegate (object senderLoc, EventArgs eLoc) { DeleteBtn_Click(senderLoc, eLoc, i); };
                }
                else
                {
                    buts[i].Click += new System.EventHandler(this.AddButton_Click);
                }
                
                buts[i].Location = new System.Drawing.Point(isAddBut ? addButX : delButX, lowestBox);
                if (!isAddBut)
                {
                    RemoveClickEvent(buts[i]);
                    buts[i].Click += delegate (object senderLoc, EventArgs eLoc) { DeleteBtn_Click(senderLoc, eLoc, i); };
                }
                
                lowestBox += boxDiff;
            }
            return buts;
        }

        private List<TextBox> RewriteTextYandIndex(List<TextBox> skills)
        {
            lowestBox = highestbox;
            for (int i = 0; i < skills.Count; i++)
            {
                //Console.WriteLine("rewriting skill box");  // Debug
                skills[i].Location = new System.Drawing.Point(6, lowestBox);
                //skills[i].Text = lowestBox.ToString(); // Debug
                lowestBox += boxDiff;
            }
            return skills;
        }

        private void RemoveClickEvent(Button b)
        {
            FieldInfo f1 = typeof(Control).GetField("EventClick",
                BindingFlags.Static | BindingFlags.NonPublic);

            object obj = f1.GetValue(b);
            PropertyInfo pi = b.GetType().GetProperty("Events",
                BindingFlags.NonPublic | BindingFlags.Instance);

            EventHandlerList list = (EventHandlerList)pi.GetValue(b, null);
            list.RemoveHandler(obj, list[obj]);
        }

        private void Skills_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSkills();
        }
    }
}
