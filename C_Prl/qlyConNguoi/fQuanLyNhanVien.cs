using A_Dal.DomainClass;
using B_Bus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Prl.qlyConNguoi
{
    public partial class fQuanLyNhanVien : Form
    {
        List<NhanVien> lstNhanVien;
        public fQuanLyNhanVien()
        {
            InitializeComponent();
            ShowData();
            dtgShow.CellClick += dtgShow_CellContentClick;
        }
        void ConfigData()
        {
            dtgShow.Rows.Clear();
            for (int i = 1; i <= lstNhanVien.Count; i++)
            {
                var nv = lstNhanVien[i - 1];
                string gioiTinh;
                if (nv.GioiTinh == true)
                {
                    gioiTinh = "Nam";
                }
                else
                {
                    gioiTinh = "Nữ";
                }
                if (nv.TrangThai == 4)//trạng thái 0: chưa có tài khoản, 1: đã có tài khoản, 4: nghỉ việc
                {
                    continue;
                }
                string tt;
                if (nv.TrangThai == 0)
                {
                    tt = "Chưa có tài khoản";
                }
                else if (nv.TrangThai == 1)
                {
                    tt = "Đã có tài khoản";
                }
                else
                {
                    tt = "Nghỉ";
                }

                dtgShow.Rows.Add(
                i.ToString(),
                 nv.IdNhanVien,
                 nv.HoTen,
                 gioiTinh,
                 nv.SoDienThoai,
                 nv.DiaChi,
                 nv.NgaySinh,
                 nv.Email,
                 tt
                );
            }
        }

        void ShowData()
        {
            lstNhanVien = svc.services.GetAllNhanVien();
            ConfigData();
        }
        static string GenerateMaPM()
        {
            Random random = new Random();
            int randomNumber = random.Next(1000, 9999); // Số ngẫu nhiên từ 1000 đến 9999

            string maNV = "NV" + randomNumber.ToString();
            return maNV;
        }
        public bool checkTrong()
        {
            if (string.IsNullOrEmpty(txtHoTen.Text) ||
               string.IsNullOrEmpty(txtDiaChi.Text) ||
               string.IsNullOrEmpty(txtSdt.Text) ||
               string.IsNullOrEmpty(dtpNgaySinh.Text) ||
               cmbGioiTinh.SelectedItem == null)
            {
                return false;
            }
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkTrong() != true)
            {
                MessageBox.Show("Vui lòng không để trống các trường!");
                return;
            }
            Regex regex = new Regex(@"^\d+$");
            if (regex.IsMatch(txtSdt.Text) != true)
            {
                MessageBox.Show("Số điện thoại sai định dạng!");
                return ;
            }
            string gioiTinh = cmbGioiTinh.SelectedItem.ToString();
            bool gt;
            if (gioiTinh == "Nam")
            {
                gt = true;
            }
            else
            {
                gt = false;
            }
            NhanVien nv = new NhanVien()
            {
                IdNhanVien = GenerateMaPM(),
                HoTen = txtHoTen.Text,
                GioiTinh = gt,
                SoDienThoai = txtSdt.Text,
                DiaChi = txtDiaChi.Text,
                NgaySinh = dtpNgaySinh.Value,
                Email = txtEmail.Text,
                TrangThai = 0 // trạng thái 0: chưa có tài khoản, 1: đã có tài khoản, 4: nghỉ việc
            };
            var addNv = svc.services.AddNhanVien(nv);
            if (addNv)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
            ShowData();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Chưa chọn nhân viên muốn sửa!");
                return;
            }
            if (checkTrong() != true)
            {
                MessageBox.Show("Vui lòng không để trống các trường!");
                return;
            }
            Regex regex = new Regex(@"^\d+$");
            if (regex.IsMatch(txtSdt.Text) != true)
            {
                MessageBox.Show("Số điện thoại sai định dạng!");
                return;
            }
            string gioiTinh = cmbGioiTinh.SelectedItem.ToString();
            bool gt;
            if (gioiTinh == "Nam")
            {
                gt = true;
            }
            else
            {
                gt = false;
            }
            var obj = svc.services.GetAllNhanVien().FirstOrDefault(nv => nv.IdNhanVien == dtgShow.CurrentRow.Cells[1].Value.ToString());
            obj.HoTen = txtHoTen.Text;
            obj.GioiTinh = gt;
            obj.SoDienThoai = txtSdt.Text;
            obj.DiaChi = txtDiaChi.Text;
            obj.NgaySinh = dtpNgaySinh.Value;
            obj.Email = txtEmail.Text;
            var upNv = svc.services.UpdateNhanVien(obj);
            if (upNv)
            {
                MessageBox.Show("Cập nhập thành công");
            }
            else
            {
                MessageBox.Show("Cập nhập thất bại");
            }
            ShowData();
        }

        private void dtgShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dtgShow.CurrentRow.Cells[1].Value.ToString();
            txtHoTen.Text = dtgShow.CurrentRow.Cells[2].Value.ToString();
            txtSdt.Text = dtgShow.CurrentRow.Cells[4].Value.ToString();
            string gioiTinh = dtgShow.CurrentRow.Cells[3].Value.ToString();
            if (gioiTinh == "Nam")
            {
                cmbGioiTinh.SelectedIndex = 0;
            }
            else
            {
                cmbGioiTinh.SelectedIndex = 1;
            }
            txtDiaChi.Text = dtgShow.CurrentRow.Cells[5].Value.ToString();
            dtpNgaySinh.Value = Convert.ToDateTime(dtgShow.CurrentRow.Cells[6].Value.ToString());
            txtEmail.Text = dtgShow.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Chưa chọn nhân viên muốn xóa!");
                return;
            }
            var obj = svc.services.GetAllNhanVien().FirstOrDefault(nv => nv.IdNhanVien == dtgShow.CurrentRow.Cells[1].Value.ToString());
            obj.TrangThai = 4; // 0: trạng thái chưa có tk, 1 : đã có tài khoản, 4: nghỉ việc
            var xoa = svc.services.UpdateNhanVien(obj);
            if (xoa)
            {
                MessageBox.Show("Xóa thành công");
            }
            ShowData();

        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            var lstNV = svc.services.GetAllNhanVien().FirstOrDefault(nv => nv.TrangThai != 4);
            if (lstNV == null)
            {
                MessageBox.Show("Chưa có nhân viên nào để tạo tài khoản!");
                return ;
            }
            fQuanLyTaiKhoan fQuanLyTaiKhoan = new fQuanLyTaiKhoan();
            fQuanLyTaiKhoan.Show();
        }
    }
}
