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
    public partial class fThemTacGia : Form
    {
        List<TacGium> lstTacGia;
        public fThemTacGia()
        {
            InitializeComponent();
            ShowData();
            dtgShow.CellClick += dtgShow_CellContentClick;
        }
        void ConfigData()
        {
            dtgShow.Rows.Clear();
            for (int i = 1; i <= lstTacGia.Count; i++)
            {
                var tacGia = lstTacGia[i - 1];
                if (tacGia.HoTen == "Tác giả đã bị xóa!")
                {
                    continue;
                }
                dtgShow.Rows.Add(
                i.ToString(),
                tacGia.IdTacGia,
                tacGia.HoTen,
                tacGia.NgaySinh

                );
            }
        }

        void ShowData()
        {
            lstTacGia = svc.services.GetAllTacGia();
            ConfigData();
        }
        private bool checkTrong()
        {
            if (string.IsNullOrEmpty(txtTenTG.Text))
            {
                return false;
            }
            return true;
        }
        static string GenerateMaTG()
        {
            Random random = new Random();
            int randomNumber = random.Next(1000, 9999); // Số ngẫu nhiên từ 1000 đến 9999

            string maTG = "TG" + randomNumber.ToString();
            return maTG;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkTrong() != true)
            {
                MessageBox.Show("Vui lòng không để trống các trường!");
                return;
            }
            TacGium tacGia = new TacGium()
            {
                IdTacGia = GenerateMaTG(),
                HoTen = txtTenTG.Text,
                NgaySinh = dtpNgaySinh.Value
            };
            var result = svc.services.AddTacGia(tacGia);
            if (result)
            {
                MessageBox.Show("Thêm thành công");
            }
            ShowData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTG.Text))
            {
                MessageBox.Show("Vui lòng chọn tác giả muốn sửa");
                return;
            }
            if (checkTrong() != true)
            {
                MessageBox.Show("Vui lòng không để trống các trường!");
                return;
            }
           
            var obj = svc.services.GetAllTacGia().FirstOrDefault(tg => tg.IdTacGia == txtMaTG.Text);
            obj.HoTen = txtTenTG.Text;
            obj.NgaySinh = dtpNgaySinh.Value;
            var result = svc.services.UpdateTacGia(obj);
            if (result)
            {
                MessageBox.Show("Sửa thành côg");
            }
            ShowData();
        }

        private void dtgShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaTG.Text = dtgShow.CurrentRow.Cells[1].Value.ToString();
            txtTenTG.Text = dtgShow.CurrentRow.Cells[2].Value.ToString();
            dtpNgaySinh.Value = Convert.ToDateTime(dtgShow.CurrentRow.Cells[3].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTG.Text))
            {
                MessageBox.Show("Vui lòng chọn tác giả muốn xóa");
                return;
            }
            var tacGia = svc.services.GetAllTacGia().FirstOrDefault(tg => tg.IdTacGia == txtMaTG.Text);
            tacGia.HoTen = "Tác giả đã bị xóa!";
            var upTacGia = svc.services.UpdateTacGia(tacGia);
            //update tacGiaSach : Mô tả = "Đã xóa!"
            var tacGiaSach = svc.services.GetAllTacGiaSach().FirstOrDefault(t => t.IdTacGia == txtMaTG.Text);
            var removeTGS = svc.services.RemoveTacGiaSach(tacGiaSach);
        }
    }
}
