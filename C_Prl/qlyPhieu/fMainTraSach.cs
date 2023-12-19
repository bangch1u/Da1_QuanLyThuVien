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
    public partial class fMainTraSach : Form
    {
        List<PhieuMuonChiTiet> listPMCT;
        public fMainTraSach()
        {
            InitializeComponent();
            dtgShow.CellClick += dtgShow_CellContentClick;
            ShowData();
        }
        private void ConfigData()
        {
            dtgShow.Rows.Clear();
            for (int i = 1; i <= listPMCT.Count; i++)
            {

                var pmct = listPMCT[i - 1];
                if (pmct.TrangThai == 4)
                {
                    continue;
                }
              
                dtgShow.Rows.Add(
                i.ToString(),
                pmct.IdPhieuMuon,
                pmct.BarCodeMaSach,
                svc.services.GetTenSachBySct(pmct.BarCodeMaSach),
                pmct.IdPhieuMuonChiTiet,
                svc.services.TenTheThuVien(pmct.IdPhieuMuon),
                pmct.NgayMuonSach?.ToString("MM/dd/yyyy"),
                pmct.NgayTraSach?.ToString("MM/dd/yyyy"),
                pmct.SoLanGiaHan


                );

            }
        }
        void ShowData()
        {
            listPMCT = svc.services.GetAllPMCT(null);
            ConfigData();
        }
        static string GenerateMaPT()
        {
            Random random = new Random();
            int randomNumber = random.Next(1000, 9999); // Số ngẫu nhiên từ 1000 đến 9999

            string maPT = "PT" + randomNumber.ToString();
            return maPT;
        }
        //private bool checkTrong()
        //{

        //}
        private void btnTraSach_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBarcodeMaSach.Text) ||
                string.IsNullOrEmpty(txtMaPM.Text))
            {
                MessageBox.Show("Chưa chọn phiếu mượn chi tiết muốn trả sách");
                return;
            }
            DateTime dateTimeNow = DateTime.Now;
            var pm = svc.services.GetAllPhieuMuon(null).FirstOrDefault(pm => pm.IdPhieuMuon == txtMaPM.Text); // lấy phiếu mượn
            var idTheTV = pm.IdTheThuVien; // id thẻ thư viện
            var idPMCT = dtgShow.CurrentRow.Cells[4].Value.ToString();
            var pmct = svc.services.GetAllPMCT2().FirstOrDefault(pm => pm.IdPhieuMuonChiTiet == Convert.ToInt32(idPMCT)); // lấy phiếu mượn ct
            var sct = svc.services.GetAllSachCT2().FirstOrDefault(s => s.BarCodeMaSach == txtBarcodeMaSach.Text); // lấy sách chi tiết
            var ttv = svc.services.GetAllTheThuVien().FirstOrDefault(ttv => ttv.IdTheThuVien == idTheTV);
            PhieuTraSach pts = new PhieuTraSach()
            {
                IdPhieuTra = GenerateMaPT(),
                ThoiGianTraSach = DateTime.Now,
                TinhTrangSach = txtTinhTrangSach.Text,
                BarCodeMaSach = txtBarcodeMaSach.Text,
                IdPhieuMuon = txtMaPM.Text,
                TrangThai = false, //trạng thái false : chưa xác định phạt tiền hay không
            };
            if (dateTimeNow > pmct.NgayTraSach)
            {
                MessageBox.Show("Trả sách muộn - trừ 50 điểm uy tín");
                //update thẻ thư viện
                ttv.DiemUyTin -= 50;
                svc.services.UpdateTheThuVien(ttv);
            }


            //update phiếu mượn           
            pm.TongSachMuon -= 1;
            var upPM = svc.services.UpdatePhieuMuon(pm);
            //update phiếu mượn chi tiết        
            pmct.TrangThai = 4; // 4: trạng thái đã trả sách

            var upPMCT = svc.services.UpdatePhieuMuonCT(pmct);
           
            //update Sách chi Tiết
            if (sct.TrangThai != 4)
            {
                sct.TrangThai = 1; //0: đã mượn, 1: chưa mượn
                var upSCT = svc.services.UpdateSCT(sct);
            }

            //tra sách
            var resultTraSach = svc.services.AddPhieuTraSach(pts);
            if (upPMCT == true)
            {
                MessageBox.Show("Trả sách thành công");
            }
            //MessageBox.Show(pmct.TrangThai.ToString());
            ShowData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fMainPhatDiem form = new fMainPhatDiem();
            form.Show();
        }

        private void btnQuaHan_Click(object sender, EventArgs e)
        {
            fQuaHanKhongTra form = new fQuaHanKhongTra();
            form.Show();
        }

        private void dtgShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPM.Text = dtgShow.CurrentRow.Cells[1].Value.ToString();
            txtMaPhieuTra.Text = dtgShow.CurrentRow.Cells[3].Value.ToString();
            txtBarcodeMaSach.Text = dtgShow.CurrentRow.Cells[2].Value.ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
