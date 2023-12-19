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
    public partial class fQuanLyPMCT : Form
    {
        List<PhieuMuonChiTiet> listPMCT;
        public fQuanLyPMCT()
        {
            InitializeComponent();
            ShowData();
        }
        private void ConfigData()
        {
            dataGridView1.Rows.Clear();
            for (int i = 1; i <= listPMCT.Count; i++)
            {
                var pm = listPMCT[i - 1];
                if (pm.TrangThai == 4)
                {
                    continue;
                }
                dataGridView1.Rows.Add(
                i.ToString(),
                pm.IdPhieuMuonChiTiet,
                pm.IdPhieuMuon,
                pm.IdNhanVien,
                svc.services.GetTenSachBySct(pm.BarCodeMaSach),
                pm.BarCodeMaSach,
                pm.NgayMuonSach?.ToString("MM/dd/yyyy"),
                pm.NgayTraSach?.ToString("MM/dd/yyyy"),
                pm.SoLanGiaHan,
                pm.TrangThai

                );

            }
        }
        void ShowData()
        {
            listPMCT = svc.services.GetAllPMCT(null);
            ConfigData();
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            DateTime ngayHienTai = DateTime.Now;
            //MessageBox.Show(ngayHienTai.Day.ToString());
            var idPMCT = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            var obj = svc.services.GetAllPMCT(null).FirstOrDefault(pm => pm.IdPhieuMuonChiTiet == idPMCT);
            //MessageBox.Show(idPMCT.ToString());

            if (obj.NgayTraSach < ngayHienTai)
            {
                MessageBox.Show("Đã quá ngày gia hạn");
                return;
            }
            obj.NgayTraSach = dtpGiaHan.Value;
            obj.SoLanGiaHan += 1;

            if (obj.SoLanGiaHan > 3)
            {
                MessageBox.Show("Bạn đã gia hạn quá 3 lần!");
                return;
            }
            var result = svc.services.UpdatePhieuMuonCT(obj);
            if (result)
            {
                MessageBox.Show("Gia Hạn Thành Công");
            }
            ShowData();
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            //fTraSach fTraSach = new fTraSach();
            //fTraSach.Show();
        }
    }
}
