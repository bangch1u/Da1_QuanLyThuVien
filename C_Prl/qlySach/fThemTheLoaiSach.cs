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
    public partial class fThemTheLoaiSach : Form
    {
        List<Sach?> sachList;
        public fThemTheLoaiSach()
        {
            InitializeComponent();
            DataCmb();
            ShowData();
        }
        public void DataCmb()
        {
            var lstTheLoai = svc.services.GetAllTheLoai();
            cmbTheLoai.DataSource = lstTheLoai;
            cmbTheLoai.DisplayMember = "tenTheLoai";

            // Set ValueMember to show the ViTriKeSach
            cmbTheLoai.ValueMember = "idTheLoai";

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
                sach.TenSach,
                svc.services.GetTheLoaiByID(sach.BarCodeSach),
                sach.BarCodeSach
                );
            }
        }
        void ShowData()
        {
            sachList = svc.services.GetAllSach();
            ConfigData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            MessageBox.Show(cmbTheLoai.SelectedValue.ToString());
            string barCode = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            ChiTietTheLoai cttl = new ChiTietTheLoai()
            {
                IdTheLoai = cmbTheLoai.SelectedValue.ToString(),
                BarCodeSach = barCode
            };

            var result = svc.services.AddTheLoaiChiTiet(cttl);

            if (result)
            {
                MessageBox.Show("Thêm chi tiết thể loại thành công.");
            }
            else
            {
                MessageBox.Show("Thêm chi tiết thể loại thất bại.");
            }
            ShowData();
        }
    }
}
