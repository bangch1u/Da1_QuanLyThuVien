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

namespace C_Prl.qlyConNguoi
{
    public partial class fQuanLyTheThuVien : Form
    {
        List<TheThuVien> lstTTV;
        public fQuanLyTheThuVien()
        {
            InitializeComponent();
            dtgShow.CellClick += dtgShow_CellContentClick;
            ShowData();
        }
        void ConfigData()
        {
            dtgShow.Rows.Clear();
            for (int i = 1; i <= lstTTV.Count; i++)
            {
                var ttv = lstTTV[i - 1];
                string tt;
                if (ttv.TrangThai == 0)
                {
                    tt = "Chưa có phiếu mượn";
                }
                else
                {
                    tt = "Đã có phiếu mượn";
                }
                if (ttv.TrangThai == 4)
                {
                    continue;
                }

                dtgShow.Rows.Add(
                i.ToString(),
                ttv.IdTheThuVien,
                ttv.HoTen,
                ttv.SoDienThoai,
                ttv.DiemUyTin,
                tt

                );
            }
        }

        void ShowData()
        {
            lstTTV = svc.services.GetAllTheThuVien();

            ConfigData();
        }

        private void btnNap_Click(object sender, EventArgs e)
        {
            fNapDiem fNapDiem = new fNapDiem();
            fNapDiem.Show();
        }
        static string GenerateMaTTV()
        {
            Random random = new Random();
            int randomNumber = random.Next(1000, 9999); // Số ngẫu nhiên từ 1000 đến 9999

            string maTTV = "TTV" + randomNumber.ToString();
            return maTTV;
        }
        private void btnThemThe_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "" || txtSdt.Text == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống các trường!!");
                return;
            }
            TheThuVien ttv = new TheThuVien()
            {
                IdTheThuVien = GenerateMaTTV(),
                HoTen = txtHoTen.Text,
                SoDienThoai = txtSdt.Text,
                DiemUyTin = 0,
                TrangThai = 0 // 0: chưa có phiếu mượn, 1: đã có phiếu mượn
            };
            var addThe = svc.services.AddTheThuVien(ttv);
            if (addThe)
            {
                MessageBox.Show("Thêm thành công");

            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
            ShowData();
        }

        private void dtgShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdThe.Text = dtgShow.CurrentRow.Cells[1].Value.ToString();
            txtHoTen.Text = dtgShow.CurrentRow.Cells[2].Value.ToString();
            txtSdt.Text = dtgShow.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnSuaThe_Click(object sender, EventArgs e)
        {
            var ttv = svc.services.GetAllTheThuVien().FirstOrDefault(t => t.IdTheThuVien == txtIdThe.Text);
            if (ttv == null)
            {
                MessageBox.Show("Vui lòng chọn thẻ thư viện muốn sửa!!!");
                return;
            }
            if (txtHoTen.Text == "" || txtSdt.Text == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống các trường!!");
                return;
            }
            ttv.HoTen = txtHoTen.Text;
            ttv.SoDienThoai = txtSdt.Text;
            var updateTTV = svc.services.UpdateTheThuVien(ttv);
            if (updateTTV)
            {
                MessageBox.Show("Cập Nhập Thành Công!");
            }
            ShowData();
        }

        private void btnF5_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            txtIdThe.Text = "";
            txtSdt.Text = "";
            ShowData();
        }

        private void btnXoaThe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdThe.Text))
            {
                MessageBox.Show("Vui lòng chọn thẻ thư viện muốn xóa!");
                return ;
            }
            var ttv = svc.services.GetAllTheThuVien().FirstOrDefault(t => t.IdTheThuVien == txtIdThe.Text);
            ttv.TrangThai = 4; // 4: trạng thái xóa thẻ thư viện
            var updateTTV = svc.services.UpdateTheThuVien(ttv);
            if (updateTTV)
            {
                MessageBox.Show("Xóa Thành Công!");
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
            ShowData();

        }
    }
}
