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
    public partial class fThemTheLoai : Form
    {
        List<TheLoai> lstTheLoai;
        public fThemTheLoai()
        {
            InitializeComponent();
            ShowData();
        }
        void ConfigData()
        {
            dataGridView1.Rows.Clear();
            for (int i = 1; i <= lstTheLoai.Count; i++)
            {
                var tl = lstTheLoai[i - 1];
                dataGridView1.Rows.Add(
                i.ToString(),
                tl.IdTheLoai,
                tl.TenTheLoai
                );
            }
        }

        void ShowData()
        {
            lstTheLoai = svc.services.GetAllTheLoai();
            ConfigData();
        }
        static string GenerateMaTL()
        {
            Random random = new Random();
            int randomNumber = random.Next(1000, 9999); // Số ngẫu nhiên từ 1000 đến 9999

            string maTL = "TL" + randomNumber.ToString();
            return maTL;
        }
        private bool checkTrong()
        {
            if (string.IsNullOrEmpty(txtTenTL.Text))
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
            TheLoai theLoai = new TheLoai()
            {
                IdTheLoai = GenerateMaTL(),
                TenTheLoai = txtTenTL.Text
            };
            var result = svc.services.AddTheLoai(theLoai);
            if (result)
            {
                MessageBox.Show("Thêm Thành Công");
            }
            else
            {
                MessageBox.Show("Thêm Thất bại");
            }
            ShowData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTL.Text))
            {
                MessageBox.Show("Chưa chọn thể loại muốn sửa!");
                return;
            }
            if (checkTrong() != true)
            {
                MessageBox.Show("Vui lòng không bỏ trống các trường!");
                return;
            }
          
            var obj = svc.services.GetAllTheLoai().FirstOrDefault(tl => tl.IdTheLoai == txtMaTL.Text);
            obj.TenTheLoai = txtTenTL.Text;
            var upTheLoai = svc.services.UpdateTheLoai(obj);
            if (upTheLoai)
            {
                MessageBox.Show("Sủa Thành Công");
            }
            else
            {
                MessageBox.Show("Sủa Thất bại");
            }
            ShowData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaTL.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtTenTL.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTL.Text))
            {
                MessageBox.Show("Chưa chọn thể loại muốn xóa!");
                return;
            }
            var theLoai = svc.services.GetAllTheLoai().FirstOrDefault(tl => tl.IdTheLoai == txtMaTL.Text);
            theLoai.TenTheLoai = "Thể loại đã bị xóa!";
            var upTheLoai = svc.services.UpdateTheLoai(theLoai);
            //update tacGiaSach : Mô tả = "Đã xóa!"
            var theLoaiSach = svc.services.GetAllChiTietTheLoai().FirstOrDefault(t => t.IdTheLoai == txtMaTL.Text);
            var removeTLS = svc.services.RemoveCTTL(theLoaiSach);
        }
    }
}
