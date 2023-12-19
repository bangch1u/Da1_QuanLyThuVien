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
    public partial class fMainQuanLySachCT : Form
    {
        List<SachChiTiet> sachCTList;
        public fMainQuanLySachCT()
        {
            InitializeComponent();
            ShowData();
            dtgShow.CellClick += dtgShow_CellContentClick;
        }
        void ConfigData()
        {
            dtgShow.Rows.Clear();
            for (int i = 1; i <= sachCTList.Count; i++)
            {

                var sachCT = sachCTList[i - 1];
                var tt = sachCT.TrangThai;

                string trangThai;
                if (tt == 0)
                {
                    trangThai = "đã mượn";
                }
                else
                {
                    trangThai = "chưa mượn";
                }
                if (tt == 4)
                {
                    continue;
                }

                dtgShow.Rows.Add(
                i.ToString(),
                sachCT.BarCodeMaSach,
                svc.services.GetTenSach(sachCT.BarCodeSach),
                sachCT.TinhTrangSach,
                sachCT.LanTaiBan,

                sachCT.NamTaiBan,
                sachCT.DiemUyTinMin,
                svc.services.GetNhaXuatBanByID(sachCT.IdNxb),
                sachCT.KichCo,
                trangThai
                );
            }
        }
        public void DataCmb()
        {
            var lstNXB = svc.services.GetAllNXB();
            List<NhaXuatBan> lstNXB2 = new List<NhaXuatBan>();
            foreach (var item in lstNXB)
            {
                if (item.TenNxb != "Đã xóa!")
                {
                    lstNXB2.Add(item);
                }
            }
            cmbNXB.DataSource = lstNXB2;
            cmbNXB.DisplayMember = "tenNXB";
            cmbNXB.ValueMember = "idNXB";
        }
        void ShowData()
        {
            sachCTList = svc.services.GetAllSachCT2();

            ConfigData();
            DataCmb();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var obj = svc.services.GetAllSachCT2().FirstOrDefault(s => s.BarCodeMaSach == dtgShow.CurrentRow.Cells[1].Value.ToString());
            obj.TinhTrangSach = txtTinhTrang.Text;
            obj.LanTaiBan = Convert.ToInt32(txtLanTaiBan.Text);
            obj.NamTaiBan = Convert.ToInt32(txtNamTaiBan.Text);
            obj.KichCo = txtKichCo.Text;
            obj.DiemUyTinMin = Convert.ToInt32(txtDiemUyTinMin.Text);
            obj.IdNxb = cmbNXB.SelectedValue.ToString();
            var upSct = svc.services.UpdateSCT(obj);
            if (upSct)
            {
                MessageBox.Show("Sửa thành công");

            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
            ShowData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var obj = svc.services.GetAllSachCT2().FirstOrDefault(s => s.BarCodeMaSach == dtgShow.CurrentRow.Cells[1].Value.ToString());
            obj.TrangThai = 4;
            var a = svc.services.UpdateSCT(obj);
            //update số lượng sách 
            var sach = svc.services.GetAllSach().FirstOrDefault(ss => ss.BarCodeSach == obj.BarCodeSach);
            sach.SoLuong -= 1;
            var upSach = svc.services.UpdateSach(sach);
            if (a && upSach)
            {
                MessageBox.Show("Xóa thành công");
            }
            ShowData();
        }

        private void dtgShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBarcodeMaSach.Text = dtgShow.CurrentRow.Cells[1].Value.ToString();
            txtTinhTrang.Text = dtgShow.CurrentRow.Cells[3].Value.ToString();
            txtLanTaiBan.Text = dtgShow.CurrentRow.Cells[4].Value.ToString();
            txtNamTaiBan.Text = dtgShow.CurrentRow.Cells[5].Value.ToString();
            txtDiemUyTinMin.Text = dtgShow.CurrentRow.Cells[6].Value.ToString();
            
            txtKichCo.Text = dtgShow.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fThemSachCT form = new fThemSachCT();
            form.Show();
        }
    }
}
