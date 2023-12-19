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

namespace C_Prl.qlySach
{
    public partial class fThemNhaXuatBan : Form
    {
        List<NhaXuatBan> lstNXB;
        public fThemNhaXuatBan()
        {
            InitializeComponent();
            ShowData();
            dataGridView1.CellClick += dataGridView1_CellContentClick;
        }
        void ConfigData()
        {
            dataGridView1.Rows.Clear();
            for (int i = 1; i <= lstNXB.Count; i++)
            {
                var nxb = lstNXB[i - 1];
                if (nxb.TenNxb == "Đã xóa!")
                {
                    continue;
                }
                dataGridView1.Rows.Add(
                i.ToString(),
                nxb.IdNxb,
                nxb.TenNxb,
                nxb.DiaChi,
                nxb.SoDienThoai


                );
            }
        }

        void ShowData()
        {
            lstNXB = svc.services.GetAllNXB();
            ConfigData();
        }
        static string GenerateMaNXB()
        {
            Random random = new Random();
            int randomNumber = random.Next(1000, 9999); // Số ngẫu nhiên từ 1000 đến 9999

            string maNXB = "NXB" + randomNumber.ToString();
            return maNXB;
        }
        private bool checkTrong()
        {
            if (string.IsNullOrEmpty(txtTenNXB.Text) ||
            string.IsNullOrEmpty(txtDiaChi.Text) ||
            string.IsNullOrEmpty(txtSDT.Text))            
            {
                return false;
            }

            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            
            if (checkTrong() != true)
            {
                MessageBox.Show("Vui lòng không bỏ trống các trường!");
                return;
            }
            Regex regex = new Regex(@"^\d+$");

            if (!regex.IsMatch(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng sdt nhập kí tự số nguyên liền nhau!");
                return;
            }
            NhaXuatBan nxb = new NhaXuatBan()
            {
                IdNxb = GenerateMaNXB(),
                TenNxb = txtTenNXB.Text,
                DiaChi = txtDiaChi.Text,
                SoDienThoai = txtSDT.Text
            };
            var result = svc.services.AddNhaXuatBan(nxb);
            if (result)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
            ShowData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkTrong() != true)
            {
                MessageBox.Show("Vui lòng không bỏ trống các trường!");
                return;
            }
            Regex regex = new Regex(@"^\d+$");

            if (!regex.IsMatch(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng sdt nhập kí tự số nguyên liền nhau!");
                return;
            }
            if (string.IsNullOrEmpty(txtMaNXB.Text))
            {
                MessageBox.Show("Vui lòng chọn nhà xuất bản cần sửa");
                return;
            }
            var obj = svc.services.GetAllNXB().FirstOrDefault(tg => tg.IdNxb == txtMaNXB.Text);
            obj.TenNxb = txtTenNXB.Text;
            obj.DiaChi = txtDiaChi.Text;
            obj.SoDienThoai = txtSDT.Text;
            var update = svc.services.UpdateNhaXuatBan(obj);
            if (update)
            {
                MessageBox.Show("Cập Nhập Thành Công");
            }
            ShowData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNXB.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtTenNXB.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtDiaChi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtSDT.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNXB.Text))
            {
                MessageBox.Show("Vui lòng chọn nhà xuất bản cần xóa");
                return;
            }
            var obj = svc.services.GetAllNXB().FirstOrDefault(tg => tg.IdNxb == txtMaNXB.Text);
            obj.TenNxb = "Đã xóa!";
            var remove = svc.services.UpdateNhaXuatBan(obj);
            //cập nhập nhà xuất bản của sách chi tiết
            var sachCT = svc.services.GetAllSachCT2().FirstOrDefault(n => n.IdNxb == txtMaNXB.Text);
            sachCT.IdNxb = null;
            var updateSCT = svc.services.UpdateSCT(sachCT);
            if (remove && updateSCT)
            {
                MessageBox.Show("Xóa Thành Công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
            ShowData();
        }
    }
}
