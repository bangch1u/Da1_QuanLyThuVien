using B_Bus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Prl
{
    public partial class fLogin : Form
    {

        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int? acc = svc.services.GetTaiKhoans(txtTK.Text, txtMK.Text);
            if (acc == null)
            {
                MessageBox.Show("Tài khoản || mật khẩu không hợp lệ!!!");
                return;
            }
            if (acc == 3)
            {
                MessageBox.Show("Tài khoản đã bị khóa!");
                return;
            }
            if (acc != null)
            {
                //MessageBox.Show(acc.ToString());
                this.Hide();
                fMainView2 main = new fMainView2(acc);
                main.FormClosed += (sender, e) => { this.Show(); };
                main.Show();

            }
        }
    }
}
