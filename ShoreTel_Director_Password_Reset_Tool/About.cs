using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace ShoreTel_Director_Password_Reset_Tool
{
    public partial class frmAbout : Form
    {
        private License License;
        public frmAbout()
        {
            InitializeComponent();
            License = new License();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://goallcomm.com");
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            bgWorkLicense.RunWorkerAsync();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:support@goallcomm.com");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("tel:8664625526");
        }

        private void bgWorkLicense_DoWork(object sender, DoWorkEventArgs e)
        {
            bool isLicensed = false;
            var LicArray = new string[4];
            string HardKey = License.Value();
            string MD5Hash = License.GetMd5Sum(HardKey);
            LicArray[0] = HardKey;
            LicArray[1] = MD5Hash;
            try
            {
                string KeyFile = File.ReadAllText("KeyFile").Trim();

                if(KeyFile.Trim() == MD5Hash)
                {
                    isLicensed = true;
                }
                else
                {
                    isLicensed = false;
                }

                LicArray[2] = isLicensed.ToString();
                LicArray[3] = KeyFile;

            }
            catch (Exception)
            {

            }
            e.Result = LicArray;
        }

        private void bgWorkLicense_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string[] LicArray = (e.Result as string[]);
            int i = 0;
            foreach (var item in LicArray)
            {
                LicArray[i] = item;
                i++;
            }

            lblKey.Text = LicArray[0];
            lblLic.Text = LicArray[1];
           

            if(LicArray[1] == LicArray[3])
            {
                lblKey.ForeColor = Color.Green;
                lblLic.ForeColor = Color.Green;
            }
            else
            {
                lblKey.ForeColor = Color.Red;
                lblLic.ForeColor = Color.Red;
            }
        }

        private void lblLic_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblLic.Text);
        }

        private void lblKey_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblKey.Text);
        }

        private void btnActivateLicense_Click(object sender, EventArgs e)
        {
            var ActivateLicense = new frmActivateLicense();
            ActivateLicense.ShowDialog();
        }
    }
}
