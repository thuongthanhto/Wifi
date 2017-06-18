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
    public partial class frmDelete : Form
    {
        public frmDelete()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
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
            ProcessStartInfo proc4 = new ProcessStartInfo("cmd", "/c netsh wlan set hostednetwork mode=disallow ssid=" + txtWifiName.Text + " key=" + txtPass.Text);
            proc4.RedirectStandardOutput = true;
            proc4.UseShellExecute = false;
            proc4.CreateNoWindow = true;
            Process a = new Process();
            a.StartInfo = proc4;
            a.Start();
            string result = a.StandardOutput.ReadToEnd();
            MessageBox.Show(this, result, @"Thông tin khởi tạo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
