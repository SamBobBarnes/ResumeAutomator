
namespace ResumeAutomator
{
    partial class ResumeAutomator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.createResume = new System.Windows.Forms.Button();
            this.BasicInfoBtn = new System.Windows.Forms.Button();
            this.SummaryBtn = new System.Windows.Forms.Button();
            this.EducationBtn = new System.Windows.Forms.Button();
            this.WorkExperienceBtn = new System.Windows.Forms.Button();
            this.SpecialCategoryBtn = new System.Windows.Forms.Button();
            this.SkillsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createResume
            // 
            this.createResume.Enabled = false;
            this.createResume.Location = new System.Drawing.Point(668, 393);
            this.createResume.Name = "createResume";
            this.createResume.Size = new System.Drawing.Size(120, 45);
            this.createResume.TabIndex = 0;
            this.createResume.Text = "Create Resume";
            this.createResume.UseVisualStyleBackColor = true;
            this.createResume.Click += new System.EventHandler(this.createResume_Click);
            // 
            // BasicInfoBtn
            // 
            this.BasicInfoBtn.Location = new System.Drawing.Point(12, 51);
            this.BasicInfoBtn.Name = "BasicInfoBtn";
            this.BasicInfoBtn.Size = new System.Drawing.Size(150, 23);
            this.BasicInfoBtn.TabIndex = 1;
            this.BasicInfoBtn.Text = "Basic Info";
            this.BasicInfoBtn.UseVisualStyleBackColor = true;
            this.BasicInfoBtn.Click += new System.EventHandler(this.BasicInfoBtn_Click);
            // 
            // SummaryBtn
            // 
            this.SummaryBtn.Location = new System.Drawing.Point(12, 80);
            this.SummaryBtn.Name = "SummaryBtn";
            this.SummaryBtn.Size = new System.Drawing.Size(150, 23);
            this.SummaryBtn.TabIndex = 2;
            this.SummaryBtn.Text = "Summary";
            this.SummaryBtn.UseVisualStyleBackColor = true;
            this.SummaryBtn.Click += new System.EventHandler(this.SummaryBtn_Click);
            // 
            // EducationBtn
            // 
            this.EducationBtn.Location = new System.Drawing.Point(12, 109);
            this.EducationBtn.Name = "EducationBtn";
            this.EducationBtn.Size = new System.Drawing.Size(150, 23);
            this.EducationBtn.TabIndex = 3;
            this.EducationBtn.Text = "Education";
            this.EducationBtn.UseVisualStyleBackColor = true;
            // 
            // WorkExperienceBtn
            // 
            this.WorkExperienceBtn.Location = new System.Drawing.Point(12, 138);
            this.WorkExperienceBtn.Name = "WorkExperienceBtn";
            this.WorkExperienceBtn.Size = new System.Drawing.Size(150, 23);
            this.WorkExperienceBtn.TabIndex = 4;
            this.WorkExperienceBtn.Text = "Work Experience";
            this.WorkExperienceBtn.UseVisualStyleBackColor = true;
            this.WorkExperienceBtn.Click += new System.EventHandler(this.WorkExperienceBtn_Click);
            // 
            // SpecialCategoryBtn
            // 
            this.SpecialCategoryBtn.Location = new System.Drawing.Point(12, 196);
            this.SpecialCategoryBtn.Name = "SpecialCategoryBtn";
            this.SpecialCategoryBtn.Size = new System.Drawing.Size(150, 23);
            this.SpecialCategoryBtn.TabIndex = 5;
            this.SpecialCategoryBtn.Text = "Special Category";
            this.SpecialCategoryBtn.UseVisualStyleBackColor = true;
            this.SpecialCategoryBtn.Click += new System.EventHandler(this.SpecialCategoryBtn_Click);
            // 
            // SkillsBtn
            // 
            this.SkillsBtn.Location = new System.Drawing.Point(12, 167);
            this.SkillsBtn.Name = "SkillsBtn";
            this.SkillsBtn.Size = new System.Drawing.Size(150, 23);
            this.SkillsBtn.TabIndex = 6;
            this.SkillsBtn.Text = "Skills";
            this.SkillsBtn.UseVisualStyleBackColor = true;
            this.SkillsBtn.Click += new System.EventHandler(this.SkillsBtn_Click);
            // 
            // ResumeAutomator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SkillsBtn);
            this.Controls.Add(this.SpecialCategoryBtn);
            this.Controls.Add(this.WorkExperienceBtn);
            this.Controls.Add(this.EducationBtn);
            this.Controls.Add(this.SummaryBtn);
            this.Controls.Add(this.BasicInfoBtn);
            this.Controls.Add(this.createResume);
            this.Name = "ResumeAutomator";
            this.Text = "Resume Automator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createResume;
        private System.Windows.Forms.Button BasicInfoBtn;
        private System.Windows.Forms.Button SummaryBtn;
        private System.Windows.Forms.Button EducationBtn;
        private System.Windows.Forms.Button WorkExperienceBtn;
        private System.Windows.Forms.Button SpecialCategoryBtn;
        private System.Windows.Forms.Button SkillsBtn;
    }
}

