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
    public partial class fMainMuonSach : Form
    {
        List<SachChiTiet> sachCTList;
        public fMainMuonSach()
        {
            InitializeComponent();
            dataViewSach.CellClick += dataViewSach_CellContentClick;
            DataCmb();
            ShowData();
        }
        void ConfigData()
        {
            dataViewSach.Rows.Clear();
            for (int i = 1; i <= sachCTList.Count; i++)
            {
                var sachCT = sachCTList[i - 1];
                if (sachCT.TrangThai == 0 || sachCT.TrangThai == 4)//nếu trạng thái là 0: đã bị mượn và ẩn 4: đã xóa
                {
                    continue; // Bỏ qua dòng này và tiếp tục vòng lặp
                }
                if (true)
                {

                }
                dataViewSach.Rows.Add(
                i.ToString(),
                sachCT.BarCodeMaSach,
                sachCT.BarCodeSach,
                svc.services.GetTenSach(sachCT.BarCodeSach),
                sachCT.TinhTrangSach,
                svc.services.GetNhaXuatBanByID(sachCT.IdNxb),              
                sachCT.DiemUyTinMin,
                sachCT.TrangThai

                );
            }
        }

        void ShowData()
        {
            sachCTList = svc.services.GetAllSachCT2();
            ConfigData();
        }

        private void dataViewSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSach.Text = dataViewSach.CurrentRow.Cells[1].Value.ToString();
            txtBarcodeS.Text = dataViewSach.CurrentRow.Cells[2].Value.ToString();
        }
        public void DataCmb()
        {
            var lstNhanVien = svc.services.GetAllNhanVien();
            List<NhanVien> list = new List<NhanVien>();
            foreach (var item in lstNhanVien)
            {
                if (item.TrangThai != 4)
                {
                    list.Add(item);
                }
            }
            cmbNhanVien.DataSource = list;
            cmbNhanVien.DisplayMember = "hoTen";
            cmbNhanVien.ValueMember = "idNhanVien";
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSach.Text)||
                string.IsNullOrEmpty(txtMaPM.Text))
            {
                MessageBox.Show("Vui lòng không bỏ trống các trường");
                return;
            }
            var obj = svc.services.GetAllPhieuMuon(null).FirstOrDefault(pm => pm.IdPhieuMuon == txtMaPM.Text);
            if (obj.TrangThai == false)
            {
                MessageBox.Show("Phiếu mượn chưa được kích hoạt");
                return;
            }
            if (dtNgayMuon.Value > dtNgayTra.Value)
            {
                MessageBox.Show("Ngày trả phải lớn hơn ngày mượn!");
                return;
            }
            var objPM = svc.services.GetAllPhieuMuon(null).FirstOrDefault(p => p.IdPhieuMuon == txtMaPM.Text);
            if (objPM.TongSachMuon > 3)
            {
                MessageBox.Show("Mỗi phiếu mượn chỉ được mượn tối đa 3 quyển sách");
                return;
            }
            var sct = svc.services.GetAllSachCT2().FirstOrDefault(s => s.BarCodeMaSach == txtMaSach.Text);
            int diemUyTin = svc.services.GetDiemUyTin(obj.IdTheThuVien); //lấy điểm uy tín để check mượn sách
            MessageBox.Show(diemUyTin.ToString());
            PhieuMuonChiTiet pmct = new PhieuMuonChiTiet()
            {
                IdPhieuMuon = txtMaPM.Text,
                BarCodeMaSach = txtMaSach.Text,
                NgayMuonSach = dtNgayMuon.Value,
                NgayTraSach = dtNgayTra.Value,
                SoLanGiaHan = 0,
                IdNhanVien = cmbNhanVien.SelectedValue.ToString(),
                TrangThai = 0 // 0: trạng thái chưa trả sách
            };
            //MessageBox.Show(cmbNhanVien.SelectedValue.ToString());
            int minUyTin = Convert.ToInt32(dataViewSach.CurrentRow.Cells[6].Value.ToString());
            if (diemUyTin < minUyTin)
            {
                MessageBox.Show("Bạn không đủ điểm uy tín để mượn quyển sách này!");
                return;
            }
            var resultAdd = svc.services.AddPMCT(pmct);

            // Update the TongSachMuon in PhieuMuon
            if (resultAdd)
            {
                // Increment the TongSachMuon by 1
                obj.TongSachMuon += 1;

                // Update the PhieuMuon
                var resultUpPM = svc.services.UpdatePhieuMuon(obj);
                // chuyển trạng thái sách
                sct.TrangThai = 0;
                var resultUpSCT = svc.services.UpdateSCT(sct);
                if (resultUpSCT == false)
                {
                    MessageBox.Show("Lỗi cập nhập sách chi tiết");
                }
                if (resultUpPM)
                {
                    MessageBox.Show("Mượn thành công");
                }
                else
                {
                    // Handle the case where updating PhieuMuon fails
                    MessageBox.Show("Lỗi khi cập nhật thông tin mượn sách");
                }
            }
            else
            {
                // Handle the case where adding PhieuMuonChiTiet fails
                MessageBox.Show("Lỗi khi thêm chi tiết mượn sách");

            }
            ShowData();
        }

        private void btnInforTTV_Click(object sender, EventArgs e)
        {

            var ttv = svc.services.GetAllTheThuVien().FirstOrDefault(t => t.IdTheThuVien.ToUpper() == txtMaTTV.Text.ToUpper());
            if (ttv == null)
            {
                MessageBox.Show("Thẻ thư viện không tồn tại");
                return;
            }
            var pm = svc.services.GetAllPhieuMuon(null).FirstOrDefault(pm => pm.IdTheThuVien.ToUpper() == txtMaTTV.Text.ToUpper());
            if (pm == null)
            {
                MessageBox.Show("Thẻ thư viên chưa đăng ký phiếu mượn");
                return;
            }
            lbHoTen.Text = ttv.HoTen;
            lbMaPM.Text = pm.IdPhieuMuon;
            lbDiemUt.Text = ttv.DiemUyTin.ToString();
            lbSdt.Text = ttv.SoDienThoai;
            lbTongSach.Text = pm.TongSachMuon.ToString();
        }

        private void fMainMuonSach_Load(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void txtBarcodeS_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtNgayMuon_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaPM.Text = "";
            txtMaSach.Text = "";
            txtBarcodeS.Text = "";
            lbHoTen.Text = "";
            lbMaPM.Text = "";
            lbDiemUt.Text = "";
            lbSdt.Text = "";
            lbTongSach.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                sachCTList = svc.services.GetSachCTTimKiem(txtSearch.Text);

                ConfigData();
                return;
            }
            ShowData();
           
        }
    }
}
