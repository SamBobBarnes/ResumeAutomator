﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.IO;
//using iTextSharp.text;
//using iTextSharp.text.pdf;

namespace ResumeAutomator
{
    public partial class ResumeAutomator : Form
    {
        public ResumeAutomator()
        {
            InitializeComponent();
        }

        private void createResume_Click(object sender, EventArgs e)
        {
            DocumentBuilder doc = new DocumentBuilder(); // Create new DocumentBuilder 
            JSONHandler js = new JSONHandler();

        }
    }
}
