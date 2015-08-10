using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.IO;
using System.Text.RegularExpressions;

namespace ShoreTel_Director_Password_Reset_Tool
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private string GetServer_FQDN()
        {
            string domainName = IPGlobalProperties.GetIPGlobalProperties().DomainName;
            string hostName = Dns.GetHostName();
            string FQDN = hostName + domainName;
            return FQDN;
        }
        private string GetServer_LAN_IP()
        {
            string FQDN = GetServer_FQDN();

            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(FQDN);

            foreach (IPAddress ipAddress in ipEntry.AddressList)
            {
                if (ipAddress.AddressFamily.ToString() == "InterNetwork")
                {
                    return ipAddress.ToString();
                }
            }

            return "No IP Address detected!";
        }

        private string Get_External_IP()
        {
            string ipAddress;
            using (WebClient wc = new WebClient())
            {
                ipAddress = wc.DownloadString("http://icanhazip.com/");
            }
            return ipAddress;
        }

        private void bgWorkerInfoGather_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] ServerInfo = new string[] { GetServer_FQDN(), GetServer_LAN_IP(), Get_External_IP() };
            e.Result = ServerInfo;
        }

        private void bgWorkerInfoGather_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string[] ServerInfo = (e.Result as string[]);
            string FQDN = ServerInfo[0];
            string InternalIP = ServerInfo[1];
            string ExternalIP = ServerInfo[2];
            txtHostname.Text = FQDN;
            txtInternalIP.Text = InternalIP;
            txtExternalIP.Text = ExternalIP;
        }

        private void bgWorkerInfoGather_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            bgWorkerInfoGather.RunWorkerAsync();
        }
    }
}
