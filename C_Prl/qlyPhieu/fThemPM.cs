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

namespace C_Prl.qlyPhieu
{
    public partial class fThemPM : Form
    {
        public fThemPM()
        {
            InitializeComponent();
        }
        static string GenerateMaPM()
        {
            Random random = new Random();
            int randomNumber = random.Next(1000, 9999); // Số ngẫu nhiên từ 1000 đến 9999

            string maPM = "PM" + randomNumber.ToString();
            return maPM;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            var obj = svc.services.GetAllPhieuMuon(null).FirstOrDefault(pm => pm.IdTheThuVien == tbIDTheTV.Text);
            if (obj != null)
            {
                MessageBox.Show("Id thẻ thư viện này đã được cấp phiếu mượn");
                return;
            }
            var theTV = svc.services.GetAllTheThuVien().FirstOrDefault(ttv => ttv.IdTheThuVien == tbIDTheTV.Text);
            if (theTV == null)
            {
                MessageBox.Show("Thẻ thư viện không tồn tại!");
                return;
            }
            if (cmbTrangThai.SelectedItem == null)
            {
                return;
            }
            PhieuMuon pm = new PhieuMuon()
            {
                IdTheThuVien = tbIDTheTV.Text,
                IdPhieuMuon = GenerateMaPM(),
                TongSachMuon = 0,
                NgayTaoPhieu = dateTimePicker1.Value,
                TrangThai = cmbTrangThai.SelectedItem.ToString() == "Hoạt Động" ? true : false
            };
            var a = svc.services.AddPhieuMuon(pm);
            //update trạng thái của thẻ thư viện: 0(chưa có pm) || 1(đã có pm)
            theTV.TrangThai = 1;
            var upTheTV = svc.services.UpdateTheThuVien(theTV);
            if (a && upTheTV)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại do phiếu mượn đã tồn tại");
            }
        }
    }
}
