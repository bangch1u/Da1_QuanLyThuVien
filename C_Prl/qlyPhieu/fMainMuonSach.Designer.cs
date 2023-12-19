namespace C_Prl.qlyPhieu
{
    partial class fMainMuonSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataViewSach = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemUyTin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtMaTTV = new System.Windows.Forms.TextBox();
            this.btnInforTTV = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbTongSach = new System.Windows.Forms.Label();
            this.lbSdt = new System.Windows.Forms.Label();
            this.lbDiemUt = new System.Windows.Forms.Label();
            this.lbMaPM = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cmbNhanVien = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dtNgayTra = new System.Windows.Forms.DateTimePicker();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dtNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtBarcodeS = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtMaPM = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.btnMuon = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewSach)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataViewSach
            // 
            this.dataViewSach.BackgroundColor = System.Drawing.Color.White;
            this.dataViewSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.MaSach,
            this.BarCode,
            this.tenSach,
            this.tinhTrang,
            this.NXB,
            this.DiemUyTin,
            this.trangThai});
            this.dataViewSach.GridColor = System.Drawing.Color.Black;
            this.dataViewSach.Location = new System.Drawing.Point(382, 297);
            this.dataViewSach.Name = "dataViewSach";
            this.dataViewSach.RowHeadersWidth = 51;
            this.dataViewSach.RowTemplate.Height = 29;
            this.dataViewSach.Size = new System.Drawing.Size(780, 312);
            this.dataViewSach.TabIndex = 40;
            this.dataViewSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewSach_CellContentClick);
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            this.stt.Width = 50;
            // 
            // MaSach
            // 
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.Width = 125;
            // 
            // BarCode
            // 
            this.BarCode.HeaderText = "Barcode Sach";
            this.BarCode.MinimumWidth = 6;
            this.BarCode.Name = "BarCode";
            this.BarCode.Width = 125;
            // 
            // tenSach
            // 
            this.tenSach.HeaderText = "Tên Sách";
            this.tenSach.MinimumWidth = 6;
            this.tenSach.Name = "tenSach";
            this.tenSach.Width = 200;
            // 
            // tinhTrang
            // 
            this.tinhTrang.HeaderText = "Tình Trạng";
            this.tinhTrang.MinimumWidth = 6;
            this.tinhTrang.Name = "tinhTrang";
            this.tinhTrang.Width = 125;
            // 
            // NXB
            // 
            this.NXB.HeaderText = "NXB";
            this.NXB.MinimumWidth = 6;
            this.NXB.Name = "NXB";
            this.NXB.Width = 150;
            // 
            // DiemUyTin
            // 
            this.DiemUyTin.HeaderText = "Điểm Uy Tín ";
            this.DiemUyTin.MinimumWidth = 6;
            this.DiemUyTin.Name = "DiemUyTin";
            this.DiemUyTin.Width = 50;
            // 
            // trangThai
            // 
            this.trangThai.HeaderText = "Trạng Thái";
            this.trangThai.MinimumWidth = 6;
            this.trangThai.Name = "trangThai";
            this.trangThai.Visible = false;
            this.trangThai.Width = 125;
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.groupBox9.Controls.Add(this.txtMaTTV);
            this.groupBox9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox9.ForeColor = System.Drawing.Color.White;
            this.groupBox9.Location = new System.Drawing.Point(16, 632);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(222, 68);
            this.groupBox9.TabIndex = 64;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Mã Thẻ Thư Viện";
            // 
            // txtMaTTV
            // 
            this.txtMaTTV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaTTV.Location = new System.Drawing.Point(13, 26);
            this.txtMaTTV.Name = "txtMaTTV";
            this.txtMaTTV.Size = new System.Drawing.Size(192, 27);
            this.txtMaTTV.TabIndex = 58;
            // 
            // btnInforTTV
            // 
            this.btnInforTTV.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnInforTTV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInforTTV.ForeColor = System.Drawing.Color.White;
            this.btnInforTTV.Location = new System.Drawing.Point(256, 643);
            this.btnInforTTV.Name = "btnInforTTV";
            this.btnInforTTV.Size = new System.Drawing.Size(120, 57);
            this.btnInforTTV.TabIndex = 63;
            this.btnInforTTV.Text = "Thông Tin Người Mượn";
            this.btnInforTTV.UseVisualStyleBackColor = false;
            this.btnInforTTV.Click += new System.EventHandler(this.btnInforTTV_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lbTongSach);
            this.groupBox1.Controls.Add(this.lbSdt);
            this.groupBox1.Controls.Add(this.lbDiemUt);
            this.groupBox1.Controls.Add(this.lbMaPM);
            this.groupBox1.Controls.Add(this.lbHoTen);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(16, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 357);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Thẻ Thư Viện";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(27, 296);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(124, 20);
            this.label18.TabIndex = 9;
            this.label18.Text = "Tổng Sách Mượn:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(27, 226);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 20);
            this.label17.TabIndex = 8;
            this.label17.Text = "Số Điện Thoại:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(27, 171);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 20);
            this.label16.TabIndex = 7;
            this.label16.Text = "Điểm Uy Tín:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(27, 113);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 20);
            this.label15.TabIndex = 6;
            this.label15.Text = "Mã Phiếu Mượn:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(27, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 20);
            this.label14.TabIndex = 5;
            this.label14.Text = "Họ tên:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // lbTongSach
            // 
            this.lbTongSach.AutoSize = true;
            this.lbTongSach.ForeColor = System.Drawing.Color.White;
            this.lbTongSach.Location = new System.Drawing.Point(192, 296);
            this.lbTongSach.Name = "lbTongSach";
            this.lbTongSach.Size = new System.Drawing.Size(0, 20);
            this.lbTongSach.TabIndex = 4;
            // 
            // lbSdt
            // 
            this.lbSdt.AutoSize = true;
            this.lbSdt.ForeColor = System.Drawing.Color.White;
            this.lbSdt.Location = new System.Drawing.Point(192, 226);
            this.lbSdt.Name = "lbSdt";
            this.lbSdt.Size = new System.Drawing.Size(0, 20);
            this.lbSdt.TabIndex = 3;
            // 
            // lbDiemUt
            // 
            this.lbDiemUt.AutoSize = true;
            this.lbDiemUt.ForeColor = System.Drawing.Color.White;
            this.lbDiemUt.Location = new System.Drawing.Point(192, 175);
            this.lbDiemUt.Name = "lbDiemUt";
            this.lbDiemUt.Size = new System.Drawing.Size(0, 20);
            this.lbDiemUt.TabIndex = 2;
            // 
            // lbMaPM
            // 
            this.lbMaPM.AutoSize = true;
            this.lbMaPM.ForeColor = System.Drawing.Color.White;
            this.lbMaPM.Location = new System.Drawing.Point(192, 116);
            this.lbMaPM.Name = "lbMaPM";
            this.lbMaPM.Size = new System.Drawing.Size(0, 20);
            this.lbMaPM.TabIndex = 1;
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.ForeColor = System.Drawing.Color.White;
            this.lbHoTen.Location = new System.Drawing.Point(192, 56);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(0, 20);
            this.lbHoTen.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnMuon);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(16, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1146, 219);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Phiếu Mượn CT";
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.groupBox8.Controls.Add(this.cmbNhanVien);
            this.groupBox8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox8.ForeColor = System.Drawing.Color.White;
            this.groupBox8.Location = new System.Drawing.Point(653, 39);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(250, 72);
            this.groupBox8.TabIndex = 60;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Nhân Viên";
            this.groupBox8.Enter += new System.EventHandler(this.groupBox8_Enter);
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.FormattingEnabled = true;
            this.cmbNhanVien.Location = new System.Drawing.Point(8, 26);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(235, 28);
            this.cmbNhanVien.TabIndex = 54;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.groupBox7.Controls.Add(this.dtNgayTra);
            this.groupBox7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox7.ForeColor = System.Drawing.Color.White;
            this.groupBox7.Location = new System.Drawing.Point(356, 114);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(250, 73);
            this.groupBox7.TabIndex = 59;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Ngày Trả";
            this.groupBox7.Enter += new System.EventHandler(this.groupBox7_Enter);
            // 
            // dtNgayTra
            // 
            this.dtNgayTra.Location = new System.Drawing.Point(8, 26);
            this.dtNgayTra.Name = "dtNgayTra";
            this.dtNgayTra.Size = new System.Drawing.Size(224, 27);
            this.dtNgayTra.TabIndex = 44;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.groupBox6.Controls.Add(this.dtNgayMuon);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(356, 39);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(250, 67);
            this.groupBox6.TabIndex = 58;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ngày Mượn";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // dtNgayMuon
            // 
            this.dtNgayMuon.Location = new System.Drawing.Point(9, 26);
            this.dtNgayMuon.Name = "dtNgayMuon";
            this.dtNgayMuon.Size = new System.Drawing.Size(215, 27);
            this.dtNgayMuon.TabIndex = 43;
            this.dtNgayMuon.ValueChanged += new System.EventHandler(this.dtNgayMuon_ValueChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.groupBox5.Controls.Add(this.txtBarcodeS);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(653, 117);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(250, 74);
            this.groupBox5.TabIndex = 57;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Mã Sách";
            // 
            // txtBarcodeS
            // 
            this.txtBarcodeS.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBarcodeS.Location = new System.Drawing.Point(6, 26);
            this.txtBarcodeS.Name = "txtBarcodeS";
            this.txtBarcodeS.ReadOnly = true;
            this.txtBarcodeS.Size = new System.Drawing.Size(234, 27);
            this.txtBarcodeS.TabIndex = 40;
            this.txtBarcodeS.TextChanged += new System.EventHandler(this.txtBarcodeS_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.groupBox4.Controls.Add(this.txtMaPM);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(47, 113);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(250, 74);
            this.groupBox4.TabIndex = 56;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mã Phiếu Mượn";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // txtMaPM
            // 
            this.txtMaPM.Location = new System.Drawing.Point(6, 26);
            this.txtMaPM.Name = "txtMaPM";
            this.txtMaPM.Size = new System.Drawing.Size(238, 27);
            this.txtMaPM.TabIndex = 41;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(1003, 129);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(91, 62);
            this.btnReset.TabIndex = 47;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.groupBox3.Controls.Add(this.txtMaSach);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(47, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 68);
            this.groupBox3.TabIndex = 55;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mã Sách";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txtMaSach
            // 
            this.txtMaSach.BackColor = System.Drawing.Color.LightGray;
            this.txtMaSach.Location = new System.Drawing.Point(6, 26);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.ReadOnly = true;
            this.txtMaSach.Size = new System.Drawing.Size(238, 27);
            this.txtMaSach.TabIndex = 42;
            // 
            // btnMuon
            // 
            this.btnMuon.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMuon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMuon.ForeColor = System.Drawing.Color.White;
            this.btnMuon.Location = new System.Drawing.Point(1003, 35);
            this.btnMuon.Name = "btnMuon";
            this.btnMuon.Size = new System.Drawing.Size(91, 80);
            this.btnMuon.TabIndex = 46;
            this.btnMuon.Text = "Mượn";
            this.btnMuon.UseVisualStyleBackColor = false;
            this.btnMuon.Click += new System.EventHandler(this.btnMuon_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(934, 264);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(227, 27);
            this.txtSearch.TabIndex = 66;
            this.txtSearch.Tag = "";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(763, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "Tìm kiếm theo tên sách:";
            // 
            // fMainMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1173, 708);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.btnInforTTV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataViewSach);
            this.Name = "fMainMuonSach";
            this.Text = "fMainMuonSach";
            this.Load += new System.EventHandler(this.fMainMuonSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewSach)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataViewSach;
        private GroupBox groupBox9;
        private TextBox txtMaTTV;
        private Button btnInforTTV;
        private GroupBox groupBox1;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label lbTongSach;
        private Label lbSdt;
        private Label lbDiemUt;
        private Label lbMaPM;
        private Label lbHoTen;
        private GroupBox groupBox2;
        private GroupBox groupBox8;
        private ComboBox cmbNhanVien;
        private GroupBox groupBox7;
        private DateTimePicker dtNgayTra;
        private GroupBox groupBox6;
        private DateTimePicker dtNgayMuon;
        private GroupBox groupBox5;
        private TextBox txtBarcodeS;
        private GroupBox groupBox4;
        private TextBox txtMaPM;
        private GroupBox groupBox3;
        private TextBox txtMaSach;
        private Button btnMuon;
        private Button btnReset;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn MaSach;
        private DataGridViewTextBoxColumn BarCode;
        private DataGridViewTextBoxColumn tenSach;
        private DataGridViewTextBoxColumn tinhTrang;
        private DataGridViewTextBoxColumn NXB;
        private DataGridViewTextBoxColumn DiemUyTin;
        private DataGridViewTextBoxColumn trangThai;
        private TextBox txtSearch;
        private Label label1;
    }
}