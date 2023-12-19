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
    public partial class fQuanLyThietHai : Form
    {
        List<ThietHai> lstThietHai;
        public fQuanLyThietHai()
        {
            InitializeComponent();
            dtgShow.CellClick += dtgShow_CellContentClick;
            ShowData();
        }
        void ConfigData()
        {
            dtgShow.Rows.Clear();
            for (int i = 1; i <= lstThietHai.Count; i++)
            {
                var thietHai = lstThietHai[i - 1];
                if (thietHai.DiemTruUyTin == 0)
                {
                    continue;
                }
                dtgShow.Rows.Add(
                i.ToString(),
                thietHai.IdThietHai,
                thietHai.TenThietHai,
                thietHai.DiemTruUyTin              

                );
            }
        }
        static bool IsInteger(string input)
        {
            // Biểu thức chính quy kiểm tra xem chuỗi có chỉ chứa số nguyên không
            Regex regex = new Regex(@"^\d+$");

            return regex.IsMatch(input);
        }
        private bool checkTrong()
        {
            if (string.IsNullOrEmpty(txtTenThietHai.Text) ||
            string.IsNullOrEmpty(txtDiemUT.Text))
            {
                return false;
            }

            return true;
        }

        void ShowData()
        {
            lstThietHai = svc.services.GetAllThietHai();

            ConfigData();
        }
        static string GenerateMaTL()
        {
            Random random = new Random();
            int randomNumber = random.Next(1000, 9999); // Số ngẫu nhiên từ 1000 đến 9999

            string maTL = "TL" + randomNumber.ToString();
            return maTL;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkTrong() != true)
            {
                MessageBox.Show("Vui lòng không bỏ qua các trường!");
                return;
            }
            if (!IsInteger(txtDiemUT.Text))
            {
                MessageBox.Show("Vui lòng nhập số nguyên ở trường điểm trừ uy tín!");
                return ;
            }
            ThietHai thietHai = new ThietHai()
            {
                IdThietHai = GenerateMaTL(),
                TenThietHai = txtTenThietHai.Text,
                DiemTruUyTin = Convert.ToInt32(txtDiemUT.Text)
            };
            var addTH = svc.services.AddThietHai(thietHai);
            if (addTH)
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
                MessageBox.Show("Vui lòng không bỏ qua các trường!");
                return;
            }
            if (string.IsNullOrEmpty(txtMaTH.Text))
            {
                MessageBox.Show("Vui lòng chọn loại thiệt hại muốn sửa!");
                return;
            }
            if (!IsInteger(txtDiemUT.Text))
            {
                MessageBox.Show("Vui lòng nhập số nguyên ở trường điểm trừ uy tín!");
                return;
            }
            var obj = svc.services.GetAllThietHai().FirstOrDefault(th => th.IdThietHai == txtMaTH.Text);
            obj.TenThietHai = txtTenThietHai.Text;
            obj.DiemTruUyTin = Convert.ToInt32(txtDiemUT.Text);
            var upTH = svc.services.UpdateThietHai(obj);
            if (upTH)
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
            txtMaTH.Text = dtgShow.CurrentRow.Cells[1].Value.ToString();
            txtTenThietHai.Text = dtgShow.CurrentRow.Cells[2].Value.ToString();
            txtDiemUT.Text = dtgShow.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTH.Text))
            {
                MessageBox.Show("Vui lòng chọn loại thiệt hại muốn xóa!");
                return;
            }
            var obj = svc.services.GetAllThietHai().FirstOrDefault(th => th.IdThietHai == txtMaTH.Text);
            obj.DiemTruUyTin = 0;
            var removeTH = svc.services.UpdateThietHai(obj);
            if (removeTH)
            {
                MessageBox.Show("Xóa thành công!");
                ShowData();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }

        }
    }
}
