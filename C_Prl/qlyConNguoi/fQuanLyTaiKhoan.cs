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
    public partial class fQuanLyTaiKhoan : Form
    {
        List<NhanVien> lstNV;
        public fQuanLyTaiKhoan()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            ShowData();
        }
        public bool checkTrong()
        {
            if (string.IsNullOrEmpty(txtTK.Text) ||
            string.IsNullOrEmpty(txtMK.Text) ||
            cmbRole.SelectedItem == null)
            {
                return false;
            }

            return true;
        }
        static string GenerateMaTK()
        {
            Random random = new Random();
            int randomNumber = random.Next(1000, 9999); // Số ngẫu nhiên từ 1000 đến 9999

            string maTK = "TK" + randomNumber.ToString();
            return maTK;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            var lstNV = svc.services.GetAllNhanVien().FirstOrDefault(nv => nv.TrangThai != 4);
            if (lstNV == null)
            {
                MessageBox.Show("Chưa có nhân viên nào để tạo tài khoản!");
                return;
            }
            if (checkTrong() != true)
            {
                MessageBox.Show("Không bỏ trống các trường!");
                return;
            }
            var obj = svc.services.GetAllNhanVien().FirstOrDefault(nv => nv.IdNhanVien == txtMNV.Text);
             if (obj == null)
            {
                MessageBox.Show("Mã nhân viên không tồn tại !!!");
                return;
            }
            if (obj.TrangThai == 1)
            {
                MessageBox.Show("Nhân viên này đã có tài khoản !!!");
                return;
            }
            else if(obj.TrangThai == 4)
            {
                MessageBox.Show("Nhân viên này đã nghỉ việc !!!");
                return ;
            }
           
            int role;
            if (cmbRole.SelectedItem.ToString() == "Nhân Viên")
            {
                role = 2;
            }
            else
            {
                role=1;
            }

            TaiKhoan taiKhoan = new TaiKhoan()
            {
                IdTaiKhoan = GenerateMaTK(),
                UserName = txtTK.Text,
                PassWord = txtMK.Text,
                IdNhanVien = txtMNV.Text,
                Role = role
               
            };
            var addTK = svc.services.AddTaiKhoan(taiKhoan);
            //update trạng thái cho nhân viên (0: chưa có tài khoản, 1: đã có tài khoản, 4: nghỉ việc
            var objNhanVien = svc.services.GetAllNhanVien().FirstOrDefault(nv => nv.IdNhanVien == txtMNV.Text);
            objNhanVien.TrangThai = 1;
            var upTaiKhoan = svc.services.UpdateNhanVien(objNhanVien);
            if (addTK && upTaiKhoan)
            {
                MessageBox.Show("Tạo tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Tạo tài khoản thất bại"); 
            }
            ShowData();
        }
        void ConfigData()
        {
            dataGridView1.Rows.Clear();
            for (int i = 1; i <= lstNV.Count; i++)
            {
                var nv = lstNV[i - 1];
                string tt;
                if (nv.TrangThai == 1)
                {
                    tt = "Đã có tài khoản";
                }
                else if (nv.TrangThai == 0)
                {
                    tt = "Chưa có tài khoản";
                }
                else
                {
                    tt = "Đã nghỉ việc";
                }
                var tk = svc.services.GetAllTaiKhoan2(nv.IdNhanVien);
                string trangThaiTk;
                if (tk == 3)
                {
                    trangThaiTk = "Bị Khóa";
                }
                else if (nv.TrangThai == 0)
                {
                    trangThaiTk = "";
                }
                else
                {
                    trangThaiTk = "Hoạt Động";
                }
               
                dataGridView1.Rows.Add(
                i.ToString(),
                nv.IdNhanVien,
                nv.HoTen,              
                tt,
                trangThaiTk
                

                );
            }
        }

        void ShowData()
        {
            lstNV = svc.services.GetAllNhanVien();

            ConfigData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMNV.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            var objTK = svc.services.GetAllTaiKhoan().FirstOrDefault(t => t.IdNhanVien == dataGridView1.CurrentRow.Cells[1].Value.ToString());
            if (objTK != null)
            {
                txtTK.Text = objTK.UserName;
                txtMK.Text = objTK.PassWord;
                txtMaTK.Text = objTK.IdTaiKhoan;
            }
            else
            {
                txtTK.Text = "";
                txtMK.Text = "";
                txtMaTK.Text = "";
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkTrong() != true)
            {
                MessageBox.Show("Không bỏ trống các trường");
                return;
            }
            if (string.IsNullOrEmpty(txtMaTK.Text))
            {
                MessageBox.Show("Chưa chọn tài khoản muốn sửa!");
                return ;
            }
            int role;
            if (cmbRole.SelectedItem.ToString() == "Nhân Viên")
            {
                role = 2;
            }
            else
            {
                role = 1;
            }
           
            var obj = svc.services.GetAllTaiKhoan().FirstOrDefault(t => t.IdTaiKhoan == txtMaTK.Text);
            obj.UserName = txtTK.Text;
            obj.PassWord = txtMK.Text;
            obj.Role = role;
            var upTK = svc.services.UpdateTaiKhoan(obj);
            if (upTK)
            {
                MessageBox.Show("Cập nhập tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhập thất bại");
            }
            ShowData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTK.Text))
            {
                MessageBox.Show("Chưa chọn tài khoản muốn khóa!");
                return;
            }
            var obj = svc.services.GetAllTaiKhoan().FirstOrDefault(t => t.IdTaiKhoan == txtMaTK.Text);
           
            obj.Role = 3;//role 3: tài khoản đã bị khóa
            var upTK = svc.services.UpdateTaiKhoan(obj);
            if (upTK)
            {
                MessageBox.Show("Khóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Khóa tài khoản thất bại thất bại");
            }
            ShowData();

        }
    }
}
