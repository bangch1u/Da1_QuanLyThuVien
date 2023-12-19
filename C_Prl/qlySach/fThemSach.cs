using A_Dal.DomainClass;
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

namespace C_Prl.qlySach
{
    public partial class fThemSach : Form
    {
        public fThemSach()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var obj = svc.services.GetAllSach().FirstOrDefault(s => s.BarCodeSach == tbBarcode.Text);
            if (obj != null)
            {
                MessageBox.Show("Barcode đã tồn tại!");
                return;
            }
            Sach sach = new Sach()
            {
                BarCodeSach = tbBarcode.Text,
                TenSach = tbName.Text,
                SoLuong = 0,
                GiaTien = Convert.ToDecimal(tbGiaTien.Text),
                NamXuatBan = dateTimePicker1.Value
            };
            var s = svc.services.AddSach(sach);
            if (s)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btnRescan_Click(object sender, EventArgs e)
        {
            tbBarcode.Text = "";
            tbName.Text = "";
            tbGiaTien.Text = "";
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close(); // if form open is close
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;  // close form firt
            childForm.FormBorderStyle = FormBorderStyle.None; // of window controls
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.BringToFront();
            childForm.Show();
        }

        private void btnThemTG_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fThemTacGiaSach());
        }

        private void btnThemTL_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fThemTheLoaiSach());
        }
    }
}
