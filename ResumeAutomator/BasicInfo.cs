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
        private bool Loaded;
        private List<string> stateList = new List<string>() { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY" };
        public BasicInfo()
        {
            InitializeComponent();
        }

        private void BasicInfo_Load(object sender, EventArgs e)
        {

            PhoneTxt1.BringToFront();
            PhoneTxt2.BringToFront();
            PhoneTxt3.BringToFront();




            jhandle = new JSONHandler();
            data = jhandle.ReadFromJSON();

            /* Load data into TextBoxs */
            Loaded = false;

            NameTxt.Text = data.Name;
            if (data.Phone != null && data.Phone.Length == 14)
            {
                PhoneTxt1.Text = data.Phone.Substring(1, 3);
                PhoneTxt2.Text = data.Phone.Substring(6, 3);
                PhoneTxt3.Text = data.Phone.Substring(10, 4);
            }
            EmailTxt.Text = data.Email;
            SiteTxt.Text = data.Site;
            AddressTxt1.Text = data.Address1;
            AddressTxt2.Text = data.Address2;
            CityTxt.Text = data.City;
            ZipTxt.Text = data.Zip;
            if (data.State != null)
            {
                for (int i = 0; i < 50; i++)
                {
                    if (data.State == stateList[i])
                    {
                        StateBox.SelectedIndex = i;
                    }

                    if (i == 50)
                    {
                        Console.WriteLine("Last Line Reached");
                    }
                }
            }

            Loaded = true;
        }

        private void BasicInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            jhandle.WriteToJSON(data);
        }

        private void NameTxt_TextChanged(object sender, EventArgs e)
        {
            if (Loaded)
            {
                data.Name = NameTxt.Text;

            }
        }

        private void PhoneTxt1_TextChanged(object sender, EventArgs e)
        {
            if (Loaded)
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
            if (Loaded)
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
            if (Loaded)
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

        private void EmailTxt_TextChanged(object sender, EventArgs e)
        {
            if (Loaded)
            {
                data.Email = EmailTxt.Text;
            }

        }

        private void SiteTxt_TextChanged(object sender, EventArgs e)
        {
            if (Loaded)
            {
                data.Site = SiteTxt.Text;
            }
        }

        private void AddressTxt1_TextChanged(object sender, EventArgs e)
        {
            if (Loaded)
            {
                data.Address1 = AddressTxt1.Text;
            }
        }

        private void AddressTxt2_TextChanged(object sender, EventArgs e)
        {
            if (Loaded)
            {
                data.Address2 = AddressTxt2.Text;
            }
        }

        private void CityTxt_TextChanged(object sender, EventArgs e)
        {
            if (Loaded)
            {
                data.City = CityTxt.Text;
            }
        }

        private void ZipTxt_TextChanged(object sender, EventArgs e)
        {
            if (Loaded)
            {
                data.Zip = ZipTxt.Text;
            }
        }

        private void StateBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Loaded)
            {
                int stateIndex = StateBox.SelectedIndex;
                data.State = stateList[stateIndex];
            }
        }

        private void NameTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PhoneTxt1.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void PhoneTxt1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PhoneTxt2.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void PhoneTxt2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PhoneTxt3.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void PhoneTxt3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EmailTxt.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void EmailTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SiteTxt.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void SiteTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddressTxt1.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void AddressTxt1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddressTxt2.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void AddressTxt2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CityTxt.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void CityTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StateBox.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void StateBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ZipTxt.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void ZipTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Close();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}