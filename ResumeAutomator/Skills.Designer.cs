
using System.Collections.Generic;
using System.Windows.Forms;

namespace ResumeAutomator
{
    partial class Skills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Skills));
            this.SuspendLayout();
            // 
            // Skills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(314, 291);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Skills";
            this.Text = "Skills";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Skills_FormClosing);
            this.Load += new System.EventHandler(this.Skills_Load);
            this.ResumeLayout(false);

        }

        #endregion
        //private System.Windows.Forms.TextBox SkillBox1;
        //private System.Windows.Forms.Button DeleteBtn1;
        //private System.Windows.Forms.Button AddButton1;
        private List<TextBox> SkillBoxList = new List<TextBox> { };
        private List<Button> DeleteBtnList = new List<Button> { };
        private List<Button> AddButtonList = new List<Button> { };
    }
}