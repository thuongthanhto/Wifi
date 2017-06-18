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
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtWifiName.Text == "")
            {
                MessageBox.Show(this, @"Phải nhập tên wifi", @"Tên wifi trống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtWifiName.Focus();
            }
            if (txtPass.Text == "")
            {
                MessageBox.Show(this, @"Phải nhập mật khẩu", @"mật khẩu trống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Focus();
            }
            ProcessStartInfo proc3 = new ProcessStartInfo("cmd",
                "/c netsh wlan set hostednetwork mode=allow ssid=" + txtWifiName.Text + " key=" + txtPass.Text)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            Process a = new Process {StartInfo = proc3};
            a.Start();
            string result = a.StandardOutput.ReadToEnd();
            MessageBox.Show(this, result, @"Thông tin khỏi tạo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiParent.MdiChildren)
            {
                frm.Close();
            }
            frmUse use = new frmUse {MdiParent = frmMain.ActiveForm, Dock = DockStyle.Fill};
            use.Show();
        }
    }
}
