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
    public partial class fNapDiem : Form
    {
        List<TheThuVien> lstTTV;
        public fNapDiem()
        {
            InitializeComponent();
            ShowData();
            DataCmb();
            dataGridView1.CellClick += dataGridView1_CellContentClick;
        }
        void ConfigData()
        {
            dataGridView1.Rows.Clear();
            for (int i = 1; i <= lstTTV.Count; i++)
            {
                var ttv = lstTTV[i - 1];
                if (ttv.TrangThai == 4)
                {
                    continue;
                }
                dataGridView1.Rows.Add(
                i.ToString(),
                ttv.IdTheThuVien,
                ttv.HoTen,
                ttv.DiemUyTin,
                ttv.TrangThai

                );
            }
        }
        void ShowData()
        {
            lstTTV = svc.services.GetAllTheThuVien();

            ConfigData();
        }
        public void DataCmb()
        {
            var lstDiemCong = svc.services.GetMucDiemCongs();
            cmbMucDiem.DataSource = lstDiemCong;
            cmbMucDiem.DisplayMember = "soDiemCong";
            cmbMucDiem.ValueMember = "soDiemCong";
            cmbMucDiem.ValueMember = "mucTien";
            cmbMucDiem.SelectedIndexChanged += cmbMucDiem_SelectedIndexChanged;
            txtSoTien.Text = " ";
        }

        private void btnNap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDTTV.Text))
            {
                MessageBox.Show("Vui lòng chọn thẻ thư viện muốn nạp điểm!");
                return;
            }
            if (cmbMucDiem.SelectedItem == null)
            {
                MessageBox.Show("Chưa chọn mức điểm muốn nạp !");
                return ;
            }
            DateTime ngayHienTai = DateTime.Now;
            var ttv = svc.services.GetAllTheThuVien().FirstOrDefault(t => t.IdTheThuVien == txtIDTTV.Text);
            LichSuNap ls = new LichSuNap()
            {
                SoTienNap = Convert.ToInt32(cmbMucDiem.SelectedValue),
                DiemCongUyTin = Convert.ToInt32(cmbMucDiem.Text),
                NgayNap = ngayHienTai,
                IdTheThuVien = txtIDTTV.Text,

            };
            if (ttv.DiemUyTin == null)
            {
                ttv.DiemUyTin = 0;
                svc.services.UpdateTheThuVien(ttv);
            }
            ttv.DiemUyTin += Convert.ToInt32(cmbMucDiem.Text);
            MessageBox.Show(ttv.DiemUyTin.ToString());
            var upTTV = svc.services.UpdateTheThuVien(ttv);
            var result = svc.services.AddLichSuNap(ls);
            if (upTTV && result)
            {
                MessageBox.Show("Nạp thành công");
            }
            else
            {
                MessageBox.Show("Nạp thất bại");
            }
            ShowData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDTTV.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void cmbMucDiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMucDiem.SelectedItem != null)
            {
                // Lấy giá trị của ValueMember
                object selectedValue = cmbMucDiem.SelectedValue;

                // Hiển thị giá trị của ValueMember ở TextBox khác (ví dụ: txtMucTien)
                txtSoTien.Text = selectedValue.ToString();
            }
        }
    }
}
