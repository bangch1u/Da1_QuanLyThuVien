using A_Dal.DomainClass;
using B_Bus;
using C_Prl.qlyConNguoi;
using C_Prl.qlyPhieu;
using C_Prl.qlySach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Prl
{
    public partial class fMainView2 : Form
    {
        private Form currentFormChild;
        List<PhieuMuonChiTiet> lstPMCT;
        int? role;
        public fMainView2(int? r)
        {
            InitializeComponent();
            customizeDesing();
            role = r;
            CheckQuaHan();
            CheckPower();


        }
        private void CheckPower()
        {
            if (role == 1)
            {
                return;
            }

            btnNhanVien.Visible = false;
            panelNhanVien.Visible = false;

        }
        private void CheckQuaHan()
        {
            DateTime ngayHienTai = DateTime.Now;
            lstPMCT = svc.services.GetAllPMCT(null);
            foreach (var item in lstPMCT)
            {
                if (item.TrangThai == 4)
                {
                    continue;
                }
                if (ngayHienTai > item.NgayTraSach)
                {
                    item.TrangThai = 3; //0: chưa trả sách, 4: đã trả sách, 3: quá hạn
                    svc.services.UpdatePhieuMuonCT(item);
                }
            }
        }
        private void customizeDesing()
        {
            panelMuonTra.Visible = false;
            panelSach.Visible = false;
            panelKhachHang.Visible = false;
            panelNhanVien.Visible = false;
            panelThongTinSach.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelMuonTra.Visible == true)
            {
                panelMuonTra.Visible = false;
            }
            if (panelSach.Visible == true)
            {
                panelSach.Visible = false;
            }
            if (panelKhachHang.Visible == true)
            {
                panelKhachHang.Visible = false;
            }
            if (panelNhanVien.Visible == true)
            {
                panelNhanVien.Visible = false;
            }
            if (panelThongTinSach.Visible == true)
            {
                panelThongTinSach.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close(); // if form open is close
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;  // close form firt
            childForm.FormBorderStyle = FormBorderStyle.None; // of window controls
            childForm.Dock = DockStyle.Fill;
            panelOpenForm.Controls.Add(childForm);
            panelOpenForm.BringToFront();
            childForm.Show();
        }
        private void ChangeBackGroundButton(Button buttonAction)
        {
            btnMuonTra.BackColor = Color.FromArgb(51, 51, 76);
            btnSach.BackColor = Color.FromArgb(51, 51, 76);
            btnKhachHang.BackColor = Color.FromArgb(51, 51, 76);
            btnNhanVien.BackColor = Color.FromArgb(51, 51, 76);
            btnThongTinSach.BackColor = Color.FromArgb(51, 51, 76);


            buttonAction.BackColor = Color.MediumSeaGreen;
        }
        private void btnMuonTra_Click(object sender, EventArgs e)
        {
          
            showSubMenu(panelMuonTra);
            ChangeBackGroundButton(btnMuonTra);
            if (currentFormChild != null)
            {
                currentFormChild.Close(); // if form open is close
                //panelOpenForm
            }
            lbTenChucNang.Text = "Mượn-Trả";
           
        }

        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            //hideSubMenu();
            OpenChildForm(new fMainMuonSach());
            lbTenChucNang.Text = "Mượn Sách";
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            //hideSubMenu();
            OpenChildForm(new fMainTraSach());
            lbTenChucNang.Text = "Trả Sách";
        }

        private void bntGiaHan_Click(object sender, EventArgs e)
        {
            //hideSubMenu();
            OpenChildForm(new fMainGiaHan());
            lbTenChucNang.Text = "Gia Hạn";
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSach);
            ChangeBackGroundButton(btnSach);
            if (currentFormChild != null)
            {
                currentFormChild.Close(); // if form open is close
            }
            lbTenChucNang.Text = "Sách";
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            showSubMenu(panelKhachHang);
            ChangeBackGroundButton(btnKhachHang);
            lbTenChucNang.Text = "Khách Hàng";
            if (currentFormChild != null)
            {
                currentFormChild.Close(); // if form open is close
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            showSubMenu(panelNhanVien);
            ChangeBackGroundButton(btnNhanVien);
            lbTenChucNang.Text = "Nhân Viên";
            if (currentFormChild != null)
            {
                currentFormChild.Close(); // if form open is close
            }
        }

        private void btnThongTinSach_Click(object sender, EventArgs e)
        {
            showSubMenu(panelThongTinSach);
            ChangeBackGroundButton(btnThongTinSach);
            lbTenChucNang.Text = "Thông Tin Chung";
            if (currentFormChild != null)
            {
                currentFormChild.Close(); // if form open is close
            }
        }

        private void btnQlySach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fMainQuanLySach());
            lbTenChucNang.Text = "Quản lý sách";
        }

        private void btnQlySachCT_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fMainQuanLySachCT());
            lbTenChucNang.Text = "Quản lý sách chi tiết";
        }

        private void btnTheThuVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fQuanLyTheThuVien());
            lbTenChucNang.Text = "Quản lý thẻ thư viện";
        }

        private void btnPhieuMuon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fQuanLyPM());
            lbTenChucNang.Text = "Quản lý phiếu mượn";
        }

        private void btnNapDiem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fNapDiem());
            lbTenChucNang.Text = "Nạp điểm";

        }

        private void btnQlyNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fQuanLyNhanVien());
            lbTenChucNang.Text = "Quản lý nhân viên";
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fQuanLyTaiKhoan());
            lbTenChucNang.Text = "Quản lý tài khoản";
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fThemTacGia());
            lbTenChucNang.Text = "Quản lý tác giả";
        }

        private void btnTheLoai_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fThemTheLoai());
            lbTenChucNang.Text = "Quản lý thể loại";
        }

        private void btnThietHai_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fQuanLyThietHai());
            lbTenChucNang.Text = "Quản lý thiệt hại";
        }

        private void btnNhaXuatBan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fThemNhaXuatBan());
            lbTenChucNang.Text = "Quản lý nhà xuất bản";
        }

        private void btnTG_TL_Sach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fTacGia_TheLoai_Sach());
            lbTenChucNang.Text = "Tác giả - Thể Loại - Sách";
        }

        private void fMainView2_Load(object sender, EventArgs e)
        {

        }

        private void panelOpenForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLogo_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close(); // if form open is close
            }
            lbTenChucNang.Text = "Home";
            btnMuonTra.BackColor = Color.FromArgb(51, 51, 76);
            btnSach.BackColor = Color.FromArgb(51, 51, 76);
            btnKhachHang.BackColor = Color.FromArgb(51, 51, 76);
            btnNhanVien.BackColor = Color.FromArgb(51, 51, 76);
            btnThongTinSach.BackColor = Color.FromArgb(51, 51, 76);
            hideSubMenu();
           

        }
    }
}
