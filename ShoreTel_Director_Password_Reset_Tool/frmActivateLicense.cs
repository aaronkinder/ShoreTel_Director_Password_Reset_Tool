using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ShoreTel_Director_Password_Reset_Tool
{
    public partial class frmActivateLicense : Form
    {
        private License License;
        public frmActivateLicense()
        {
            InitializeComponent();
            License = new License();
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this license?",
        "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Delete the require record according to the user command.  
                File.Delete("KeyFile");
            }
            
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            string code = "1999." + DateTime.Now.Year.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Hour.ToString();
            if (txtActivationCode.Text == code)
            {
                License.SaveKeyFile();
                MessageBox.Show("Activated");
            }
            else
            {
                MessageBox.Show("Invalid Activation Code", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
