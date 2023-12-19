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
    public partial class fQuaHanKhongTra : Form
    {
        List<PhieuMuonChiTiet> listPMCT;
        public fQuaHanKhongTra()
        {
            InitializeComponent();
            dtgPhieuMuonCT.CellClick += dtgPhieuMuonCT_CellContentClick;
            ShowData();
        }
        private void ConfigData()
        {
            dtgPhieuMuonCT.Rows.Clear();
            for (int i = 1; i <= listPMCT.Count; i++)
            {

                var pmct = listPMCT[i - 1];
                var pm = svc.services.GetAllPhieuMuon(null).FirstOrDefault(p => p.IdPhieuMuon == pmct.IdPhieuMuon);
                var ttv = svc.services.GetAllTheThuVien().FirstOrDefault(t => t.IdTheThuVien == pm.IdTheThuVien);
                if (pmct.TrangThai != 3) //3: trạng thái quá hạn trả sách, 0: chưa trả, 4: đã trả
                {
                    continue;
                }
                dtgPhieuMuonCT.Rows.Add(
                i.ToString(),
                pmct.IdPhieuMuonChiTiet,
                pmct.BarCodeMaSach,
                ttv.SoDienThoai,
                ttv.HoTen,
               // svc.services.GetTenSachBySct(pmct.BarCodeMaSach),
                //pmct.IdPhieuMuonChiTiet,
                pmct.NgayMuonSach?.ToString("MM/dd/yyyy"),
                pmct.NgayTraSach?.ToString("MM/dd/yyyy"),
                pmct.SoLanGiaHan,
                pmct.TrangThai,
                pmct.IdPhieuMuon


                );

            }
        }
        void ShowData()
        {
            listPMCT = svc.services.GetAllPMCT(null);
            ConfigData();
        }

        private void dtgPhieuMuonCT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPMCT.Text = dtgPhieuMuonCT.CurrentRow.Cells[1].Value.ToString();
            txtMaSach.Text = dtgPhieuMuonCT.CurrentRow.Cells[2].Value.ToString();
            txtSDT.Text = dtgPhieuMuonCT.CurrentRow.Cells[3].Value.ToString();
            txtNguoiMuon.Text = dtgPhieuMuonCT.CurrentRow.Cells[4].Value.ToString();
            txtNgayMuon.Text = dtgPhieuMuonCT.CurrentRow.Cells[5].Value.ToString();
            txtNgayTra.Text = dtgPhieuMuonCT.CurrentRow.Cells[6].Value.ToString();
            txtSoLanGiaHan.Text = dtgPhieuMuonCT.CurrentRow.Cells[7].Value.ToString();
            txtTrangThai.Text = dtgPhieuMuonCT.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnKhoaPM_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPMCT.Text))
            {
                MessageBox.Show("Chưa chọn phiếu mượn chi tiết");
                return;
            }
            var obj = svc.services.GetAllPhieuMuon(null).FirstOrDefault(pm => pm.IdPhieuMuon == dtgPhieuMuonCT.CurrentRow.Cells[9].Value.ToString());
            obj.TrangThai = false;
            var up = svc.services.UpdatePhieuMuon(obj);
            if (up)
            {
                MessageBox.Show("Khóa phiếu mượn thành công");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
            ShowData();
        }
    }
}
