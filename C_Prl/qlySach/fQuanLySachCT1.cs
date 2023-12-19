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
    public partial class fQuanLySachCT1 : Form
    {
        List<SachChiTiet?> sachCTList;
        string IdSach;
        public fQuanLySachCT1(string id)
        {
            InitializeComponent();
            IdSach = id;
        }
        void ConfigData()
        {
            for (int i = 1; i <= sachCTList.Count; i++)
            {
                var sachCT = sachCTList[i - 1];
                dataGridView1.Rows.Add(
                i.ToString(),
                sachCT.BarCodeMaSach,
                sachCT.TinhTrangSach,
                sachCT.LanTaiBan,
                sachCT.NamTaiBan,
                sachCT.KichCo,
                sachCT.DiemUyTinMin,

                sachCT.TrangThai
                );
            }
        }

        void ShowData(string searchText, int Type)
        {
            sachCTList = svc.services.GetAllSachCT(IdSach);
            ConfigData();


        }

        private void fQuanLySachCT1_Load(object sender, EventArgs e)
        {
            ShowData("", 0);
        }
    }
}
