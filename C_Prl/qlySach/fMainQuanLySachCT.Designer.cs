namespace C_Prl.qlySach
{
    partial class fMainQuanLySachCT
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
            this.dtgShow = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lanTaiBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namTaiBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemUyTinMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kichCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cmbNXB = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtLanTaiBan = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtDiemUyTinMin = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtNamTaiBan = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtKichCo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBarcodeMaSach = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgShow)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgShow
            // 
            this.dtgShow.BackgroundColor = System.Drawing.Color.White;
            this.dtgShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.maSach,
            this.tenSach,
            this.tinhTrangSach,
            this.lanTaiBan,
            this.namTaiBan,
            this.diemUyTinMin,
            this.nxb,
            this.kichCo,
            this.trangThai});
            this.dtgShow.Location = new System.Drawing.Point(13, 360);
            this.dtgShow.Name = "dtgShow";
            this.dtgShow.RowHeadersWidth = 51;
            this.dtgShow.RowTemplate.Height = 29;
            this.dtgShow.Size = new System.Drawing.Size(1097, 297);
            this.dtgShow.TabIndex = 35;
            this.dtgShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgShow_CellContentClick);
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            this.stt.Width = 50;
            // 
            // maSach
            // 
            this.maSach.HeaderText = "Mã Sách";
            this.maSach.MinimumWidth = 6;
            this.maSach.Name = "maSach";
            this.maSach.Width = 125;
            // 
            // tenSach
            // 
            this.tenSach.HeaderText = "Tên Sách";
            this.tenSach.MinimumWidth = 6;
            this.tenSach.Name = "tenSach";
            this.tenSach.Width = 200;
            // 
            // tinhTrangSach
            // 
            this.tinhTrangSach.HeaderText = "Tình Trạng";
            this.tinhTrangSach.MinimumWidth = 6;
            this.tinhTrangSach.Name = "tinhTrangSach";
            this.tinhTrangSach.Width = 125;
            // 
            // lanTaiBan
            // 
            this.lanTaiBan.HeaderText = "Lần Tái Bản";
            this.lanTaiBan.MinimumWidth = 6;
            this.lanTaiBan.Name = "lanTaiBan";
            this.lanTaiBan.Width = 50;
            // 
            // namTaiBan
            // 
            this.namTaiBan.HeaderText = "Năm Tái Bản";
            this.namTaiBan.MinimumWidth = 6;
            this.namTaiBan.Name = "namTaiBan";
            this.namTaiBan.Width = 125;
            // 
            // diemUyTinMin
            // 
            this.diemUyTinMin.HeaderText = "Điểm UT";
            this.diemUyTinMin.MinimumWidth = 6;
            this.diemUyTinMin.Name = "diemUyTinMin";
            this.diemUyTinMin.Width = 70;
            // 
            // nxb
            // 
            this.nxb.HeaderText = "NXB";
            this.nxb.MinimumWidth = 6;
            this.nxb.Name = "nxb";
            this.nxb.Width = 125;
            // 
            // kichCo
            // 
            this.kichCo.HeaderText = "Kích Cỡ";
            this.kichCo.MinimumWidth = 6;
            this.kichCo.Name = "kichCo";
            this.kichCo.Width = 125;
            // 
            // trangThai
            // 
            this.trangThai.HeaderText = "Trạng Thái";
            this.trangThai.MinimumWidth = 6;
            this.trangThai.Name = "trangThai";
            this.trangThai.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1091, 212);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sách ct";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.cmbNXB);
            this.groupBox8.ForeColor = System.Drawing.Color.White;
            this.groupBox8.Location = new System.Drawing.Point(683, 44);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(174, 69);
            this.groupBox8.TabIndex = 41;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Nhà Xuất Bản";
            // 
            // cmbNXB
            // 
            this.cmbNXB.FormattingEnabled = true;
            this.cmbNXB.Location = new System.Drawing.Point(6, 26);
            this.cmbNXB.Name = "cmbNXB";
            this.cmbNXB.Size = new System.Drawing.Size(151, 28);
            this.cmbNXB.TabIndex = 24;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtLanTaiBan);
            this.groupBox7.ForeColor = System.Drawing.Color.White;
            this.groupBox7.Location = new System.Drawing.Point(465, 44);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(186, 69);
            this.groupBox7.TabIndex = 40;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Lần Tái Bản";
            // 
            // txtLanTaiBan
            // 
            this.txtLanTaiBan.Location = new System.Drawing.Point(6, 32);
            this.txtLanTaiBan.Name = "txtLanTaiBan";
            this.txtLanTaiBan.Size = new System.Drawing.Size(153, 27);
            this.txtLanTaiBan.TabIndex = 20;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtTinhTrang);
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(249, 121);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(186, 71);
            this.groupBox6.TabIndex = 39;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tình Trạng";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(6, 26);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(153, 27);
            this.txtTinhTrang.TabIndex = 19;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtDiemUyTinMin);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(249, 44);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(186, 69);
            this.groupBox5.TabIndex = 38;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Điểm Uy Tín";
            // 
            // txtDiemUyTinMin
            // 
            this.txtDiemUyTinMin.Location = new System.Drawing.Point(6, 26);
            this.txtDiemUyTinMin.Name = "txtDiemUyTinMin";
            this.txtDiemUyTinMin.Size = new System.Drawing.Size(153, 27);
            this.txtDiemUyTinMin.TabIndex = 23;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtNamTaiBan);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(465, 119);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(181, 73);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Năm Tái Bản";
            // 
            // txtNamTaiBan
            // 
            this.txtNamTaiBan.Location = new System.Drawing.Point(9, 32);
            this.txtNamTaiBan.Name = "txtNamTaiBan";
            this.txtNamTaiBan.Size = new System.Drawing.Size(153, 27);
            this.txtNamTaiBan.TabIndex = 22;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtKichCo);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(48, 121);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(178, 71);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kích Cỡ";
            // 
            // txtKichCo
            // 
            this.txtKichCo.Location = new System.Drawing.Point(6, 26);
            this.txtKichCo.Name = "txtKichCo";
            this.txtKichCo.Size = new System.Drawing.Size(153, 27);
            this.txtKichCo.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBarcodeMaSach);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(45, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 69);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mã Sách";
            // 
            // txtBarcodeMaSach
            // 
            this.txtBarcodeMaSach.Location = new System.Drawing.Point(6, 23);
            this.txtBarcodeMaSach.Name = "txtBarcodeMaSach";
            this.txtBarcodeMaSach.ReadOnly = true;
            this.txtBarcodeMaSach.Size = new System.Drawing.Size(153, 27);
            this.txtBarcodeMaSach.TabIndex = 33;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(680, 264);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(141, 66);
            this.btnXoa.TabIndex = 40;
            this.btnXoa.Text = "Xóa Sách";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(449, 264);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(141, 66);
            this.btnSua.TabIndex = 39;
            this.btnSua.Text = "Sửa Sách";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(230, 264);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(133, 66);
            this.btnThem.TabIndex = 41;
            this.btnThem.Text = "Thêm Sách";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // fMainQuanLySachCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1116, 729);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgShow);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "fMainQuanLySachCT";
            this.Text = "fMainQuanLySachCT";
            ((System.ComponentModel.ISupportInitialize)(this.dtgShow)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dtgShow;
        private GroupBox groupBox1;
        private GroupBox groupBox8;
        private ComboBox cmbNXB;
        private GroupBox groupBox7;
        private TextBox txtLanTaiBan;
        private GroupBox groupBox6;
        private TextBox txtTinhTrang;
        private GroupBox groupBox5;
        private TextBox txtDiemUyTinMin;
        private GroupBox groupBox4;
        private TextBox txtNamTaiBan;
        private GroupBox groupBox3;
        private TextBox txtKichCo;
        private GroupBox groupBox2;
        private TextBox txtBarcodeMaSach;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn maSach;
        private DataGridViewTextBoxColumn tenSach;
        private DataGridViewTextBoxColumn tinhTrangSach;
        private DataGridViewTextBoxColumn lanTaiBan;
        private DataGridViewTextBoxColumn namTaiBan;
        private DataGridViewTextBoxColumn diemUyTinMin;
        private DataGridViewTextBoxColumn nxb;
        private DataGridViewTextBoxColumn kichCo;
        private DataGridViewTextBoxColumn trangThai;
    }
}