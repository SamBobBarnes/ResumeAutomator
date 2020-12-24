
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
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DeleteBtn1 = new System.Windows.Forms.Button();
            this.AddButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(490, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(34, 479);
            this.vScrollBar1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(401, 31);
            this.textBox1.TabIndex = 1;
            // 
            // DeleteBtn1
            // 
            this.DeleteBtn1.Location = new System.Drawing.Point(419, 12);
            this.DeleteBtn1.Name = "DeleteBtn1";
            this.DeleteBtn1.Size = new System.Drawing.Size(31, 31);
            this.DeleteBtn1.TabIndex = 2;
            this.DeleteBtn1.Text = "-";
            this.DeleteBtn1.UseVisualStyleBackColor = true;
            // 
            // AddButton1
            // 
            this.AddButton1.Location = new System.Drawing.Point(456, 12);
            this.AddButton1.Name = "AddButton1";
            this.AddButton1.Size = new System.Drawing.Size(31, 31);
            this.AddButton1.TabIndex = 3;
            this.AddButton1.Text = "+";
            this.AddButton1.UseVisualStyleBackColor = true;
            // 
            // Skills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 479);
            this.Controls.Add(this.AddButton1);
            this.Controls.Add(this.DeleteBtn1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.vScrollBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Skills";
            this.Text = "Skills";
            this.Load += new System.EventHandler(this.Skills_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button DeleteBtn1;
        private System.Windows.Forms.Button AddButton1;
    }
}