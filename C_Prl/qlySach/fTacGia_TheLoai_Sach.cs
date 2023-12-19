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
    public partial class fTacGia_TheLoai_Sach : Form
    {
        List<Sach?> sachList;
        public fTacGia_TheLoai_Sach()
        {
            InitializeComponent();
            ShowData();
            DataCmb();
            ShowData2();
            DataCmb2();
            checkTxtBarcode();
            dtgTGS.CellClick += dtgTGS_CellContentClick;
            dtgTLS.CellClick += dtgTLS_CellContentClick;


        }
        void ConfigData()
        {
            dtgTGS.Rows.Clear();

            for (int i = 1; i <= sachList.Count; i++)
            {
                var sach = sachList[i - 1];
                if (sach.TenSach == "Sách đã bị xóa!")
                {
                    continue;
                }
                dtgTGS.Rows.Add(
                i.ToString(),
                sach.TenSach,
                svc.services.GetTacGiaByID(sach.BarCodeSach),
                 sach.BarCodeSach
                );
            }
        }
        void ShowData()
        {
            sachList = svc.services.GetAllSach();
            ConfigData();

        }
        public void DataCmb()
        {
            var lstTacGia = svc.services.GetAllTacGia();
            var tenTacGiaList = lstTacGia.Select(tacGia => tacGia.HoTen).ToList();
            List<TacGium> lstTG = new List<TacGium>();
            foreach (var item in lstTacGia)
            {
                if (item.HoTen != "Tác giả đã bị xóa!")
                {
                    lstTG.Add(item);
                }
            }
            // Đặt danh sách tên tác giả làm DataSource cho ComboBox
            cmbTacGia.DataSource = lstTG;
            cmbTacGia.DisplayMember = "hoTen";

            // Set ValueMember to show the ViTriKeSach
            cmbTacGia.ValueMember = "idTacGia";
        }

        private void btnThemTGS_Click(object sender, EventArgs e)
        {
            var tgs = svc.services.GetAllTacGiaSach().FirstOrDefault(t => t.BarCodeSach == txtBarcode.Text && t.IdTacGia == cmbTacGia.SelectedValue.ToString());
            var tg = svc.services.GetAllTacGia().FirstOrDefault(tg => tg.IdTacGia == cmbTacGia.SelectedValue.ToString());
            var sach = svc.services.GetAllSach().FirstOrDefault(s => s.BarCodeSach == txtBarcode.Text);
            if (tgs != null)
            {
                MessageBox.Show($"Tác giả {tg.HoTen} này đã được gán vào sách {sach.TenSach} !");
                return;
            }
            TacGiaSach obj = new TacGiaSach()
            {
                BarCodeSach = dtgTGS.CurrentRow.Cells[3].Value.ToString(),
                IdTacGia = cmbTacGia.SelectedValue.ToString()
            };
            var result = svc.services.AddTacGiaSach(obj);
            if (result)
            {
                MessageBox.Show("Thêm thành công");
                ShowData();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
        public void DataCmb2()
        {
            var lstTheLoai = svc.services.GetAllTheLoai();
            cmbTheLoai.DataSource = lstTheLoai;
            cmbTheLoai.DisplayMember = "tenTheLoai";

            // Set ValueMember to show the ViTriKeSach
            cmbTheLoai.ValueMember = "idTheLoai";

        }
        void ConfigData2()
        {
            dtgTLS.Rows.Clear();
            for (int i = 1; i <= sachList.Count; i++)
            {
                var sach = sachList[i - 1];
                if (sach.TenSach == "Sách đã bị xóa!")
                {
                    continue;
                }
                dtgTLS.Rows.Add(
                i.ToString(),
                sach.TenSach,
                svc.services.GetTheLoaiByID(sach.BarCodeSach),
                sach.BarCodeSach
                );
            }
        }
        void ShowData2()
        {
            sachList = svc.services.GetAllSach();
            ConfigData2();
        }

        private void btnThemTLS_Click(object sender, EventArgs e)
        {
            var tls = svc.services.GetAllChiTietTheLoai().FirstOrDefault(t => t.BarCodeSach == txtBarcode2.Text && t.IdTheLoai == cmbTheLoai.SelectedValue.ToString());
            var tl = svc.services.GetAllTheLoai().FirstOrDefault(tg => tg.IdTheLoai == cmbTheLoai.SelectedValue.ToString());
            var sach = svc.services.GetAllSach().FirstOrDefault(s => s.BarCodeSach == txtBarcode2.Text);
            if (tls != null)
            {
                MessageBox.Show($"Thể loại {tl.TenTheLoai} này đã được gán vào sách {sach.TenSach} !");
                return;
            }
            MessageBox.Show(dtgTLS.CurrentRow.Cells[3].Value.ToString());
            MessageBox.Show(cmbTheLoai.SelectedValue.ToString());
            string barCode = dtgTLS.CurrentRow.Cells[3].Value.ToString();

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
            ShowData2();
        }
         private void DataCmbTacGiaSach()
        {
            List<TacGiaSach> lstTacGiaSach = svc.services.GetAllTacGiaSach();
            List<TacGiaSach> lstTacGiaSach2 = new List<TacGiaSach>();
            foreach (var item in lstTacGiaSach)
            {
                if (item.BarCodeSach == txtBarcode.Text)
                {
                    lstTacGiaSach2.Add(item);
                }
            }
            var lstTG = svc.services.GetAllTacGia();
            var lstTG2 = new List<TacGium>();
            foreach (var item in lstTacGiaSach2)
            {
                foreach (var item2 in lstTG)
                {
                    if (item.IdTacGia == item2.IdTacGia)
                    {
                        lstTG2.Add(item2);
                    }
                }
            }
            cmbTacGiaSach.DataSource = lstTG2;

            cmbTacGiaSach.DisplayMember = "hoTen";
            cmbTacGiaSach.ValueMember = "idTacGia";

        }
        private void DatacmbTheLoaiSach()
        {
            List<ChiTietTheLoai> lstCTTheLoaiSach = svc.services.GetAllChiTietTheLoai();
            var lstCTTheLoaiSach2 = new List<ChiTietTheLoai>();
            foreach (var item in lstCTTheLoaiSach)
            {
                if (item.BarCodeSach == txtBarcode2.Text)
                {
                    lstCTTheLoaiSach2.Add(item);
                }
            }
            var lstTL = svc.services.GetAllTheLoai();
            var lstTL2 = new List<TheLoai>();
            foreach (var item in lstCTTheLoaiSach2)
            {
                foreach (var item2 in lstTL)
                {
                    if (item.IdTheLoai == item2.IdTheLoai)
                    {
                        lstTL2.Add(item2);
                    }
                }
            }
            cmbTheLoaiSach.DataSource = lstTL2;
            cmbTheLoaiSach.DisplayMember = "tenTheLoai";
            cmbTheLoaiSach.ValueMember = "idTheLoai";

        }
        private void checkTxtBarcode()
        {
            if (txtBarcode.Text != "")
            {
                DataCmbTacGiaSach();
            }
        }
        private void checkTGS()
        {
            if (txtBarcode2.Text != "")
            {
                DatacmbTheLoaiSach();
            }
        }
        private void btnXoaTacGiaSach_Click(object sender, EventArgs e)
        {
            var idTG = cmbTacGiaSach.SelectedValue.ToString();
            //MessageBox.Show(cmbTacGiaSach.SelectedValue.ToString());
            var tacGiaSach = svc.services.GetAllTacGiaSach().FirstOrDefault(tgs => tgs.IdTacGia == idTG && tgs.BarCodeSach == txtBarcode.Text);
            var removeTGs = svc.services.RemoveTacGiaSach(tacGiaSach);
            if (removeTGs)
            {
                MessageBox.Show("Xóa thành công!");
                ShowData();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

   

        private void fTacGia_TheLoai_Sach_Load(object sender, EventArgs e)
        {
        }

   
        private void btnXoaTheLoaiSach_Click(object sender, EventArgs e)
        {
            var idTL = cmbTheLoaiSach.SelectedValue.ToString();
            //MessageBox.Show(cmbTacGiaSach.SelectedValue.ToString());
            var theLoaiSach = svc.services.GetAllChiTietTheLoai().FirstOrDefault(tgs => tgs.IdTheLoai == idTL && tgs.BarCodeSach == txtBarcode2.Text);
            var removeTLS = svc.services.RemoveCTTL(theLoaiSach);
            if (removeTLS)
            {
                MessageBox.Show("Xóa thành công!");
                ShowData2();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void dtgTLS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenSach2.Text = dtgTLS.CurrentRow.Cells[1].Value.ToString();
            txtBarcode2.Text = dtgTLS.CurrentRow.Cells[3].Value.ToString();
            checkTGS();
        }

        private void dtgTGS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenSach.Text = dtgTGS.CurrentRow.Cells[1].Value.ToString();
            txtBarcode.Text = dtgTGS.CurrentRow.Cells[3].Value.ToString();
            checkTxtBarcode();
        }
    }
}
