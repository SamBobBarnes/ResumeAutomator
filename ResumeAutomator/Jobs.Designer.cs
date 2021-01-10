
namespace ResumeAutomator
{
    partial class Jobs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jobs));
            this.addBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.jobBox = new System.Windows.Forms.ListBox();
            this.downBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.jobTitleBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startMonth = new System.Windows.Forms.NumericUpDown();
            this.endMonth = new System.Windows.Forms.NumericUpDown();
            this.startYear = new System.Windows.Forms.NumericUpDown();
            this.endYear = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.startMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endYear)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(75, 352);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(57, 23);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // delBtn
            // 
            this.delBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtn.Location = new System.Drawing.Point(12, 352);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(57, 23);
            this.delBtn.TabIndex = 1;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = true;
            // 
            // jobBox
            // 
            this.jobBox.FormattingEnabled = true;
            this.jobBox.Location = new System.Drawing.Point(12, 12);
            this.jobBox.Name = "jobBox";
            this.jobBox.Size = new System.Drawing.Size(200, 329);
            this.jobBox.TabIndex = 2;
            this.jobBox.SelectedIndexChanged += new System.EventHandler(this.jobBox_SelectedIndexChanged);
            // 
            // downBtn
            // 
            this.downBtn.Location = new System.Drawing.Point(218, 41);
            this.downBtn.Name = "downBtn";
            this.downBtn.Size = new System.Drawing.Size(75, 23);
            this.downBtn.TabIndex = 3;
            this.downBtn.Text = "V";
            this.downBtn.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(218, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Ʌ";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(368, 12);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(404, 20);
            this.titleBox.TabIndex = 5;
            this.titleBox.TextChanged += new System.EventHandler(this.titleBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Company:";
            // 
            // jobTitleBox
            // 
            this.jobTitleBox.Location = new System.Drawing.Point(368, 38);
            this.jobTitleBox.Name = "jobTitleBox";
            this.jobTitleBox.Size = new System.Drawing.Size(404, 20);
            this.jobTitleBox.TabIndex = 7;
            this.jobTitleBox.TextChanged += new System.EventHandler(this.jobTitleBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Job Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Start Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(611, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "End Date:";
            // 
            // startMonth
            // 
            this.startMonth.Location = new System.Drawing.Point(489, 64);
            this.startMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.startMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startMonth.Name = "startMonth";
            this.startMonth.Size = new System.Drawing.Size(32, 20);
            this.startMonth.TabIndex = 11;
            this.startMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startMonth.ValueChanged += new System.EventHandler(this.startMonth_ValueChanged);
            // 
            // endMonth
            // 
            this.endMonth.Location = new System.Drawing.Point(672, 64);
            this.endMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.endMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endMonth.Name = "endMonth";
            this.endMonth.Size = new System.Drawing.Size(32, 20);
            this.endMonth.TabIndex = 12;
            this.endMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endMonth.ValueChanged += new System.EventHandler(this.endMonth_ValueChanged);
            // 
            // startYear
            // 
            this.startYear.Location = new System.Drawing.Point(545, 64);
            this.startYear.Maximum = new decimal(new int[] {
            2200,
            0,
            0,
            0});
            this.startYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.startYear.Name = "startYear";
            this.startYear.Size = new System.Drawing.Size(44, 20);
            this.startYear.TabIndex = 13;
            this.startYear.Value = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.startYear.ValueChanged += new System.EventHandler(this.startYear_ValueChanged);
            // 
            // endYear
            // 
            this.endYear.Location = new System.Drawing.Point(728, 64);
            this.endYear.Maximum = new decimal(new int[] {
            2200,
            0,
            0,
            0});
            this.endYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.endYear.Name = "endYear";
            this.endYear.Size = new System.Drawing.Size(44, 20);
            this.endYear.TabIndex = 14;
            this.endYear.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.endYear.ValueChanged += new System.EventHandler(this.endYear_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(710, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "/";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(527, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(595, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "-";
            // 
            // Jobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.endYear);
            this.Controls.Add(this.startYear);
            this.Controls.Add(this.endMonth);
            this.Controls.Add(this.startMonth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jobTitleBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.downBtn);
            this.Controls.Add(this.jobBox);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.addBtn);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Jobs";
            this.Text = "Jobs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Jobs_FormClosing);
            this.Load += new System.EventHandler(this.Jobs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.startMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.ListBox jobBox;
        private System.Windows.Forms.Button downBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox jobTitleBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown startMonth;
        private System.Windows.Forms.NumericUpDown endMonth;
        private System.Windows.Forms.NumericUpDown startYear;
        private System.Windows.Forms.NumericUpDown endYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}