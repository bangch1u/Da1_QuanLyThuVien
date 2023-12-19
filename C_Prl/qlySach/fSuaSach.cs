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
    public partial class fSuaSach : Form
    {
        List<Sach> sachList;
        public fSuaSach()
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
                svc.services.GetTheLoaiByID(sach.BarCodeSach)
                // svc.services.getCountById(sach.BarCodeSach)
                );
            }
        }

        void ShowData()
        {
            sachList = svc.services.GetAllSach();
            ConfigData();
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
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

        private void btnTheLoai_Click(object sender, EventArgs e)
        {

        }
    }
}
