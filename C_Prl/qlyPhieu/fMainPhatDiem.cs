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
    public partial class fMainPhatDiem : Form
    {
        List<PhieuTraSach> listPT;
        public fMainPhatDiem()
        {
            InitializeComponent();
            ShowData2();
            DataCmb();
        }
        public void DataCmb()
        {
            var lstThietHai = svc.services.GetAllThietHai();
            List<ThietHai> lstTH = new List<ThietHai>();
            foreach (var item in lstThietHai)
            {
                if (item.DiemTruUyTin != 0)
                {
                    lstTH.Add(item);
                }
            }
            cmbThietHai.DataSource = lstTH;
            cmbThietHai.DisplayMember = "tenThietHai";
            cmbThietHai.ValueMember = "idThietHai";
        }
        private void ConfigData2()
        {
            dtgPhieuTra.Rows.Clear();
            for (int i = 1; i <= listPT.Count; i++)
            {

                var pt = listPT[i - 1];
                if (pt.TrangThai == true)
                {
                    continue;
                }
                dtgPhieuTra.Rows.Add(
                i.ToString(),
                pt.IdPhieuTra,
                pt.ThoiGianTraSach,
                pt.TinhTrangSach,
                pt.BarCodeMaSach,
                pt.IdPhieuMuon

                );

            }
        }
        void ShowData2()
        {
            listPT = svc.services.GetAllPhieuTra();
            ConfigData2();
        }

        private void btnPhatDiem_Click(object sender, EventArgs e)
        {
            ThietHaiChiTiet thct = new ThietHaiChiTiet()
            {
                IdPhieuTra = dtgPhieuTra.CurrentRow.Cells[1].Value.ToString(),
                IdThietHai = cmbThietHai.SelectedValue.ToString()
            };
            // MessageBox.Show(cmbThietHai.SelectedValue.ToString());
            var addTH = svc.services.AddThietHaiCT(thct);
            if (addTH)
            {
                MessageBox.Show("Trừ điểm thành công");
            }
            else
            {
                MessageBox.Show("Trừ điểm thất bại");
                return;
            }
            var pm = svc.services.GetAllPhieuMuon(null).FirstOrDefault(pm => pm.IdPhieuMuon == dtgPhieuTra.CurrentRow.Cells[5].Value.ToString()); // lấy phiếu mượn
            var idTheTV = pm.IdTheThuVien; // id thẻ thư viện
            var ttv = svc.services.GetAllTheThuVien().FirstOrDefault(ttv => ttv.IdTheThuVien == idTheTV);
            var th = svc.services.GetAllThietHai().FirstOrDefault(th => th.IdThietHai == cmbThietHai.SelectedValue);
            ttv.DiemUyTin -= th.DiemTruUyTin;
            svc.services.UpdateTheThuVien(ttv);
            var pt = svc.services.GetAllPhieuTra().FirstOrDefault(pt => pt.IdPhieuTra == dtgPhieuTra.CurrentRow.Cells[1].Value.ToString());
            pt.TrangThai = true; // ẩn phiếu trả sách khỏi dtgPhieuTra
            svc.services.UpdatePhieuTraSach(pt);
            MessageBox.Show($"Thẻ thư viện{idTheTV} đã bị trừ {th.DiemTruUyTin}");
            ShowData2();
        }

        private void btnKhongPhat_Click(object sender, EventArgs e)
        {
            var pt = svc.services.GetAllPhieuTra().FirstOrDefault(pt => pt.IdPhieuTra == dtgPhieuTra.CurrentRow.Cells[1].Value.ToString());
            pt.TrangThai = true;// true: trạng thái đã phán xét :)))
            svc.services.UpdatePhieuTraSach(pt);
            ShowData2();
        }

        private void btnF5_Click(object sender, EventArgs e)
        {
            ShowData2();
        }
    }
}
