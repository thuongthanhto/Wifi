using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wifi
{
    public partial class frmUse : Form
    {
        public frmUse()
        {
            InitializeComponent();
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc1 = new ProcessStartInfo("cmd", "/c netsh wlan start hostednetwork")
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            Process a = new Process {StartInfo = proc1};
            a.Start();
            string result = a.StandardOutput.ReadToEnd();
            MessageBox.Show(this, result, @"Thông tin Kết Nối", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc2 = new ProcessStartInfo("cmd", "/c netsh wlan stop hostednetwork")
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            Process a = new Process {StartInfo = proc2};
            a.Start();
            string result = a.StandardOutput.ReadToEnd();
            MessageBox.Show(this, result, @"Thông tin Kết Nối", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
