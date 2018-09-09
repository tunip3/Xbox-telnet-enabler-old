using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet.Common;
using Renci.SshNet;

namespace Xbox_Telnet_enabler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IP.Text = "XBOXONE"; 
        }
        public string ip = "XBOXONE";
        public string code;
        private void IP_TextChanged(object sender, EventArgs e)
        {
            ip = IP.Text;
        }
        private void vspaircode_TextChanged(object sender, EventArgs e)
        {
            code = vspaircode.Text;
        }

        private void enable_Click(object sender, EventArgs e)
        {
            var client = new SshClient(ip, "DevToolsUser", vspaircode.Text);
            client.Connect();
            client.RunCommand("devtoolslauncher LaunchForProfiling telnetd \"cmd.exe 24\"");
            client.Disconnect();
            MessageBox.Show("Telnet is now available on port 24.");
        }
    }
}
