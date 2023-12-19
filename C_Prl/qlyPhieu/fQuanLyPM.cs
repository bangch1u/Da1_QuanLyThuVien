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

namespace C_Prl.qlyPhieu
{
    public partial class fQuanLyPM : Form
    {
        List<PhieuMuon> pmList;
        public fQuanLyPM()
        {
            InitializeComponent();
            ShowData();
        }
        private void ConfigData()
        {
            dataGridView1.Rows.Clear();
            for (int i = 1; i <= pmList.Count; i++)
            {
                var pm = pmList[i - 1];
                var tt = pm.TrangThai;
                string trangThai;
                if (tt == true)
                {
                    trangThai = "Hoạt động";
                }
                else
                {
                    trangThai = "Ngừng HĐ";
                }
                dataGridView1.Rows.Add(
                i.ToString(),
                pm.IdPhieuMuon,
                svc.services.GetTheThuVienByID(pm.IdTheThuVien),
                pm.TongSachMuon,
                pm.NgayTaoPhieu?.ToString("MM/dd/yyyy"),
                trangThai
                //svc.services.GetTe(sach.BarCodeSach),
                //svc.services.GetTheLoaiByID(sach.BarCodeSach),
                );

            }

        }
        void ShowData()
        {
            pmList = svc.services.GetAllPhieuMuon(null);
            ConfigData();
        }

        private void btnKichHoat_Click(object sender, EventArgs e)
        {
            var obj = svc.services.GetAllPhieuMuon(null).FirstOrDefault(pm => pm.IdPhieuMuon == dataGridView1.CurrentRow.Cells[1].Value.ToString());
            obj.TrangThai = true;
            var up = svc.services.UpdatePhieuMuon(obj);
            if (up)
            {
                MessageBox.Show("Kích hoạt thành công");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
            ShowData();
            //MessageBox.Show(dataGridView1.CurrentRow.Cells[1].Value.ToString());
        }

        private void btnHuyPhieu_Click(object sender, EventArgs e)
        {
            var obj = svc.services.GetAllPhieuMuon(null).FirstOrDefault(pm => pm.IdPhieuMuon == dataGridView1.CurrentRow.Cells[1].Value.ToString());
            obj.TrangThai = false;
            var up = svc.services.UpdatePhieuMuon(obj);
            if (up)
            {
                MessageBox.Show("Hủy kích hoạt thành công");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
            ShowData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            pmList = svc.services.GetAllPhieuMuon(search);
            ConfigData();
        }

        private void btnPMCT_Click(object sender, EventArgs e)
        {
            fQuanLyPMCT fQuanLyPMCT = new fQuanLyPMCT();
            fQuanLyPMCT.Show();
        }

        private void btnThemPM_Click(object sender, EventArgs e)
        {
            fThemPM fThemPM = new fThemPM();
            fThemPM.Show();
            ShowData();
        }
    } 
}
