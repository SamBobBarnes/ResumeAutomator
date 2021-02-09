
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
            this.moveDownBtn = new System.Windows.Forms.Button();
            this.moveUpBtn = new System.Windows.Forms.Button();
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
            this.dutiesBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.locBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.currentCheck = new System.Windows.Forms.CheckBox();
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
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
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
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
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
            // moveDownBtn
            // 
            this.moveDownBtn.Location = new System.Drawing.Point(218, 41);
            this.moveDownBtn.Name = "moveDownBtn";
            this.moveDownBtn.Size = new System.Drawing.Size(75, 23);
            this.moveDownBtn.TabIndex = 3;
            this.moveDownBtn.Text = "V";
            this.moveDownBtn.UseVisualStyleBackColor = true;
            this.moveDownBtn.Click += new System.EventHandler(this.moveDownBtn_Click);
            // 
            // moveUpBtn
            // 
            this.moveUpBtn.Location = new System.Drawing.Point(218, 12);
            this.moveUpBtn.Name = "moveUpBtn";
            this.moveUpBtn.Size = new System.Drawing.Size(75, 23);
            this.moveUpBtn.TabIndex = 4;
            this.moveUpBtn.Text = "Ʌ";
            this.moveUpBtn.UseVisualStyleBackColor = true;
            this.moveUpBtn.Click += new System.EventHandler(this.moveUpBtn_Click);
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
            this.label3.Location = new System.Drawing.Point(304, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Start Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "End Date:";
            // 
            // startMonth
            // 
            this.startMonth.Location = new System.Drawing.Point(368, 64);
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
            this.endMonth.Location = new System.Drawing.Point(551, 64);
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
            this.startYear.Location = new System.Drawing.Point(424, 64);
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
            this.endYear.Location = new System.Drawing.Point(607, 64);
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
            this.label5.Location = new System.Drawing.Point(589, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "/";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(474, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "-";
            // 
            // dutiesBox
            // 
            this.dutiesBox.Location = new System.Drawing.Point(368, 116);
            this.dutiesBox.Multiline = true;
            this.dutiesBox.Name = "dutiesBox";
            this.dutiesBox.Size = new System.Drawing.Size(404, 225);
            this.dutiesBox.TabIndex = 18;
            this.dutiesBox.TextChanged += new System.EventHandler(this.dutiesBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(293, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Work Duties:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(365, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Each line will be a separate bullet point.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(697, 389);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Save on close";
            // 
            // locBox
            // 
            this.locBox.Location = new System.Drawing.Point(368, 90);
            this.locBox.Name = "locBox";
            this.locBox.Size = new System.Drawing.Size(404, 20);
            this.locBox.TabIndex = 22;
            this.locBox.TextChanged += new System.EventHandler(this.locBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(311, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Location:";
            // 
            // currentCheck
            // 
            this.currentCheck.AutoSize = true;
            this.currentCheck.Location = new System.Drawing.Point(692, 65);
            this.currentCheck.Name = "currentCheck";
            this.currentCheck.Size = new System.Drawing.Size(80, 17);
            this.currentCheck.TabIndex = 25;
            this.currentCheck.Text = "Current Job";
            this.currentCheck.UseVisualStyleBackColor = true;
            this.currentCheck.CheckedChanged += new System.EventHandler(this.currentCheck_CheckedChanged);
            // 
            // Jobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.currentCheck);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.locBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dutiesBox);
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
            this.Controls.Add(this.moveUpBtn);
            this.Controls.Add(this.moveDownBtn);
            this.Controls.Add(this.jobBox);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.addBtn);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Jobs";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
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
        private System.Windows.Forms.Button moveDownBtn;
        private System.Windows.Forms.Button moveUpBtn;
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
        private System.Windows.Forms.TextBox dutiesBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox locBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox currentCheck;
    }
}