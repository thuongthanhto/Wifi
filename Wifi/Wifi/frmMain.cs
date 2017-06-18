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
    public partial class frmMain : Form
    {
        // Dùng để di chuyển form vì mặc định form không di chuyển được 
        int _togMove; // Cho biết pnlTitle có được click chuột vào hay không (1 là có, 0 là không có)
        int _mValX; // Khoảng cách chuột di chuyển theo phương x
        int _mValY; // Khoảng cách chuột di chuyển theo phương y
        public frmMain()
        {
            InitializeComponent();

            // Mặc định show form use
            frmUse use = new frmUse {MdiParent = this, Dock = DockStyle.Fill};
            use.Show();
        }

        // Sự kiện khi pnlTitle được nhấn
        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            _togMove = 1;
            _mValX = e.X;
            _mValY = e.Y;
        }

        // Sự kiện khi pnlTitle được thả ra
        private void pnlTitle_MouseUp(object sender, MouseEventArgs e)
        {
            _togMove = 0;
        }

        // Sự kiện khi pnlTitle di chuyển bằng cách giữ chuột
        private void pnlTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (_togMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - _mValX, MousePosition.Y - _mValY);
            }
        }

        // Sự kiện khi button x được nhấn
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Sự kiện khi button thu nhỏ được nhấn
        private void btnMininize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Sự kiện khi button Add được nhấn
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd add = new frmAdd {MdiParent = this, Dock = DockStyle.Fill};
            add.Show();     
        }

        // Sự kiện khi button Detail được nhấn
        private void btnShowDetail_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo("cmd", "/c netsh wlan show hostednetwork")
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            Process a = new Process {StartInfo = proc};
            a.Start();
            string result = a.StandardOutput.ReadToEnd();
            MessageBox.Show(this, result, @"Thông tin wifi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Sự kiện khi button delete được nhấn
        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmDelete del = new frmDelete { MdiParent = this, Dock = DockStyle.Fill };
            del.Show();
        }
    }
}
