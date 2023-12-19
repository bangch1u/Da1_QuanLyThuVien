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
    public partial class fMainQuanLySach : Form
    {
        List<Sach?> sachList;
        public fMainQuanLySach()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            ShowData();
        }
        void ConfigData()
        {
            dataGridView1.Rows.Clear();
            for (int i = 1; i <= sachList.Count; i++)
            {
                var sach = sachList[i - 1];
                var tg = svc.services.GetTacGiaByID(sach.BarCodeSach);
                if (sach.TenSach == "Sách đã bị xóa!")
                {
                    continue;
                }
                dataGridView1.Rows.Add(
                i.ToString(),
                sach.BarCodeSach,
                sach.TenSach,
                sach.GiaTien,
                sach.NamXuatBan?.ToString("dd/MM/yyyy"),
                svc.services.GetTacGiaByID(sach.BarCodeSach),
                svc.services.GetTheLoaiByID(sach.BarCodeSach),
                svc.services.getCountById(sach.BarCodeSach)
                );
            }
        }

        void ShowData()
        {
            sachList = svc.services.GetAllSach();
            ConfigData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var idsach = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            var obj = svc.services.GetAllSach().FirstOrDefault(s => s.BarCodeSach == idsach);
            var obj2 = svc.services.GetAllSachCT2().FirstOrDefault(s => s.BarCodeSach == idsach);
            if (obj2 != null)
            {
                obj2.TrangThai = 4;
                var del2 = svc.services.UpdateSCT(obj2);
            }
            obj.TenSach = "Sách đã bị xóa!";
           
            var del = svc.services.UpdateSach(obj);
            
            if (del)
            {
                MessageBox.Show("Xóa Thành Công");
            }
            ShowData();
        }

        private void btnF5_Click(object sender, EventArgs e)
        {
            tbBarcode.Text = "";
            tbGiaTien.Text = "";
            tbName.Text = "";
            txtSearch.Text = "";
            ShowData();
        }
        private bool checkTrong()
        {
            if (string.IsNullOrEmpty(tbBarcode.Text)||
                string.IsNullOrEmpty(tbName.Text)||
                string.IsNullOrEmpty(tbGiaTien.Text))
            {
                return false;
            }
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkTrong() != true)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các trường");
                return;
            }
            var obj = svc.services.GetAllSach().FirstOrDefault(s => s.BarCodeSach == tbBarcode.Text);
            if (obj != null)
            {
                MessageBox.Show("Barcode đã tồn tại!");
                return;
            }
            Regex regex = new Regex(@"^-?\d+$");
            if (!regex.IsMatch(tbGiaTien.Text))
            {
                MessageBox.Show("Vui lòng nhập số nguyên ở giá tiền");
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
            ShowData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkTrong() != true)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các trường");
                return;
            }
            var obj = svc.services.GetAllSach().FirstOrDefault(s => s.BarCodeSach == tbBarcode.Text);
            if (obj == null)
            {
                MessageBox.Show("Barcode không tồn tại!");
                return;
            }
            Regex regex = new Regex(@"^-?\d+$");
            if (!regex.IsMatch(tbGiaTien.Text))
            {
                MessageBox.Show("Vui lòng nhập số nguyên ở giá tiền");
                return;
            }
            var objSach = svc.services.GetAllSach().FirstOrDefault(s => s.BarCodeSach == tbBarcode.Text);
            objSach.TenSach = tbName.Text;
            objSach.GiaTien = Convert.ToInt32(tbGiaTien.Text);
            objSach.NamXuatBan = dateTimePicker1.Value;
            var updateSach = svc.services.UpdateSach(objSach);
            if (updateSach)
            {
                MessageBox.Show("Cập nhập thành công");
            }
            else
            {
                MessageBox.Show("Cập nhập thất bại");
            }
            ShowData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbBarcode.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbGiaTien.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value);
        }
    }
}
