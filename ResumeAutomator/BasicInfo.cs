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
    public partial class BasicInfo : Form
    {

        private ResumeData data;
        private JSONHandler jhandle;
        private bool AllowChanges;
        public BasicInfo()
        {
            InitializeComponent();
        }

        private void BasicInfo_Load(object sender, EventArgs e)
        {
            jhandle = new JSONHandler();
            data = jhandle.ReadFromJSON();

            /* Load data into TextBoxs */
            AllowChanges = false;

            NameTxt.Text = data.Name;
            if(data.Phone != null && data.Phone.Length == 14)
            {
                PhoneTxt1.Text = data.Phone.Substring(1, 3);
                PhoneTxt2.Text = data.Phone.Substring(6, 3);
                PhoneTxt3.Text = data.Phone.Substring(10, 4);
            }

            AllowChanges = true;
        }

        private void BasicInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            jhandle.WriteToJSON(data);
        }

        private void NameTxt_TextChanged(object sender, EventArgs e)
        {
            if (AllowChanges)
            {
                data.Name = NameTxt.Text;

            }
        }

        private void PhoneTxt1_TextChanged(object sender, EventArgs e)
        {
            if (AllowChanges)
            {
                HandlePhoneNumChange();
                if (PhoneTxt1.TextLength == 3)
                {
                    PhoneTxt2.Focus();
                }
            }
        }

        private void PhoneTxt2_TextChanged(object sender, EventArgs e)
        {
            if (AllowChanges)
            {
                HandlePhoneNumChange();
                if (PhoneTxt2.TextLength == 3)
                {
                    PhoneTxt3.Focus();
                }
            }
        }

        private void PhoneTxt3_TextChanged(object sender, EventArgs e)
        {
            if (AllowChanges)
            {
                HandlePhoneNumChange();
                if (PhoneTxt3.TextLength == 4)
                {
                    EmailTxt.Focus();
                }
            }
        }

        private void HandlePhoneNumChange()
        {
            data.Phone = "(" + PhoneTxt1.Text + ") " + PhoneTxt2.Text + "-" + PhoneTxt3.Text;
        }
    }
}
