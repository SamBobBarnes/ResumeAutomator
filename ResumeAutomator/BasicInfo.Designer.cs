
namespace ResumeAutomator
{
    partial class BasicInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.PhoneTxt1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.StateBox = new System.Windows.Forms.ComboBox();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.AddressTxt1 = new System.Windows.Forms.TextBox();
            this.AddressTxt2 = new System.Windows.Forms.TextBox();
            this.CityTxt = new System.Windows.Forms.TextBox();
            this.ZipTxt = new System.Windows.Forms.TextBox();
            this.PhoneTxt2 = new System.Windows.Forms.TextBox();
            this.PhoneTxt3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(184, 45);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(242, 20);
            this.NameTxt.TabIndex = 1;
            this.NameTxt.TextChanged += new System.EventHandler(this.NameTxt_TextChanged);
            // 
            // PhoneTxt1
            // 
            this.PhoneTxt1.Location = new System.Drawing.Point(184, 71);
            this.PhoneTxt1.MaxLength = 3;
            this.PhoneTxt1.Name = "PhoneTxt1";
            this.PhoneTxt1.Size = new System.Drawing.Size(25, 20);
            this.PhoneTxt1.TabIndex = 3;
            this.PhoneTxt1.TextChanged += new System.EventHandler(this.PhoneTxt1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone #:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Address Line 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Address Line 2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "City:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "State:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Zip Code:";
            // 
            // StateBox
            // 
            this.StateBox.FormattingEnabled = true;
            this.StateBox.Items.AddRange(new object[] {
            "Alabama - AL",
            "Alaska - AK",
            "Arizona - AZ",
            "Arkansas - AR",
            "California - CA",
            "Colorado - CO",
            "Connecticut - CT",
            "Delaware - DE",
            "Florida - FL",
            "Georgia - GA",
            "Hawaii - HI",
            "Idaho - ID",
            "Illinois - IL",
            "Indiana - IN",
            "Iowa - IA",
            "Kansas - KS",
            "Kentucky - KY",
            "Louisiana - LA",
            "Maine - ME",
            "Maryland - MD",
            "Massachusetts - MA",
            "Michigan - MI",
            "Minnesota - MN",
            "Mississippi - MS",
            "Missouri - MO",
            "Montana - MT",
            "Nebraska - NE",
            "Nevada - NV",
            "New Hampshire - NH",
            "New Jersey - NJ",
            "New Mexico - NM",
            "New York - NY",
            "North Carolina - NC",
            "North Dakota - ND",
            "Ohio - OH",
            "Oklahoma - OK",
            "Oregon - OR",
            "Pennsylvania - PA",
            "Rhode Island - RI",
            "South Carolina - SC",
            "South Dakota - SD",
            "Tennessee - TN",
            "Texas - TX",
            "Utah - UT",
            "Vermont - VT",
            "Virginia - VA",
            "Washington - WA",
            "West Virginia - WV",
            "Wisconsin - WI",
            "Wyoming - WY"});
            this.StateBox.Location = new System.Drawing.Point(184, 207);
            this.StateBox.Name = "StateBox";
            this.StateBox.Size = new System.Drawing.Size(128, 21);
            this.StateBox.TabIndex = 10;
            this.StateBox.Text = "Select State";
            // 
            // EmailTxt
            // 
            this.EmailTxt.Location = new System.Drawing.Point(184, 99);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(242, 20);
            this.EmailTxt.TabIndex = 11;
            // 
            // AddressTxt1
            // 
            this.AddressTxt1.Location = new System.Drawing.Point(184, 129);
            this.AddressTxt1.Name = "AddressTxt1";
            this.AddressTxt1.Size = new System.Drawing.Size(242, 20);
            this.AddressTxt1.TabIndex = 12;
            // 
            // AddressTxt2
            // 
            this.AddressTxt2.Location = new System.Drawing.Point(184, 156);
            this.AddressTxt2.Name = "AddressTxt2";
            this.AddressTxt2.Size = new System.Drawing.Size(242, 20);
            this.AddressTxt2.TabIndex = 13;
            // 
            // CityTxt
            // 
            this.CityTxt.Location = new System.Drawing.Point(184, 182);
            this.CityTxt.Name = "CityTxt";
            this.CityTxt.Size = new System.Drawing.Size(242, 20);
            this.CityTxt.TabIndex = 14;
            // 
            // ZipTxt
            // 
            this.ZipTxt.Location = new System.Drawing.Point(184, 234);
            this.ZipTxt.MaxLength = 5;
            this.ZipTxt.Name = "ZipTxt";
            this.ZipTxt.Size = new System.Drawing.Size(59, 20);
            this.ZipTxt.TabIndex = 15;
            this.ZipTxt.WordWrap = false;
            // 
            // PhoneTxt2
            // 
            this.PhoneTxt2.Location = new System.Drawing.Point(225, 71);
            this.PhoneTxt2.MaxLength = 3;
            this.PhoneTxt2.Name = "PhoneTxt2";
            this.PhoneTxt2.Size = new System.Drawing.Size(25, 20);
            this.PhoneTxt2.TabIndex = 16;
            this.PhoneTxt2.TextChanged += new System.EventHandler(this.PhoneTxt2_TextChanged);
            // 
            // PhoneTxt3
            // 
            this.PhoneTxt3.Location = new System.Drawing.Point(266, 71);
            this.PhoneTxt3.MaxLength = 4;
            this.PhoneTxt3.Name = "PhoneTxt3";
            this.PhoneTxt3.Size = new System.Drawing.Size(30, 20);
            this.PhoneTxt3.TabIndex = 17;
            this.PhoneTxt3.TextChanged += new System.EventHandler(this.PhoneTxt3_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(212, 74);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(253, 74);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "-";
            // 
            // BasicInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PhoneTxt3);
            this.Controls.Add(this.PhoneTxt2);
            this.Controls.Add(this.ZipTxt);
            this.Controls.Add(this.CityTxt);
            this.Controls.Add(this.AddressTxt2);
            this.Controls.Add(this.AddressTxt1);
            this.Controls.Add(this.EmailTxt);
            this.Controls.Add(this.StateBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PhoneTxt1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.label1);
            this.Name = "BasicInfo";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BasicInfo_FormClosing);
            this.Load += new System.EventHandler(this.BasicInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox PhoneTxt1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox StateBox;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.TextBox AddressTxt1;
        private System.Windows.Forms.TextBox AddressTxt2;
        private System.Windows.Forms.TextBox CityTxt;
        private System.Windows.Forms.TextBox ZipTxt;
        private System.Windows.Forms.TextBox PhoneTxt2;
        private System.Windows.Forms.TextBox PhoneTxt3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}