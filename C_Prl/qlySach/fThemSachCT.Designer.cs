namespace C_Prl.qlySach
{
    partial class fThemSachCT
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
            this.btnThem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNXB = new System.Windows.Forms.ComboBox();
            this.txtDiemUyTinMin = new System.Windows.Forms.TextBox();
            this.txtNamTaiBan = new System.Windows.Forms.TextBox();
            this.txtKichCo = new System.Windows.Forms.TextBox();
            this.txtLanTaiBan = new System.Windows.Forms.TextBox();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.txtBarcodeMaSach = new System.Windows.Forms.TextBox();
            this.txtBarcodeSach = new System.Windows.Forms.TextBox();
            this.dtgShow = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgShow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(267, 424);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 54);
            this.btnThem.TabIndex = 35;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(25, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Nhà Xuất Bản";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(25, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Điểm Uy Tín";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Năm Tái Bản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Kích Cỡ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Lần Tái Bản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Tình Trạng ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Mã Sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Barcode ";
            // 
            // cmbNXB
            // 
            this.cmbNXB.FormattingEnabled = true;
            this.cmbNXB.Location = new System.Drawing.Point(142, 369);
            this.cmbNXB.Name = "cmbNXB";
            this.cmbNXB.Size = new System.Drawing.Size(151, 28);
            this.cmbNXB.TabIndex = 26;
            // 
            // txtDiemUyTinMin
            // 
            this.txtDiemUyTinMin.Location = new System.Drawing.Point(140, 330);
            this.txtDiemUyTinMin.Name = "txtDiemUyTinMin";
            this.txtDiemUyTinMin.Size = new System.Drawing.Size(153, 27);
            this.txtDiemUyTinMin.TabIndex = 25;
            // 
            // txtNamTaiBan
            // 
            this.txtNamTaiBan.Location = new System.Drawing.Point(142, 293);
            this.txtNamTaiBan.Name = "txtNamTaiBan";
            this.txtNamTaiBan.Size = new System.Drawing.Size(153, 27);
            this.txtNamTaiBan.TabIndex = 24;
            // 
            // txtKichCo
            // 
            this.txtKichCo.Location = new System.Drawing.Point(142, 245);
            this.txtKichCo.Name = "txtKichCo";
            this.txtKichCo.Size = new System.Drawing.Size(153, 27);
            this.txtKichCo.TabIndex = 23;
            // 
            // txtLanTaiBan
            // 
            this.txtLanTaiBan.Location = new System.Drawing.Point(143, 199);
            this.txtLanTaiBan.Name = "txtLanTaiBan";
            this.txtLanTaiBan.Size = new System.Drawing.Size(153, 27);
            this.txtLanTaiBan.TabIndex = 22;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(143, 149);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(153, 27);
            this.txtTinhTrang.TabIndex = 21;
            // 
            // txtBarcodeMaSach
            // 
            this.txtBarcodeMaSach.BackColor = System.Drawing.Color.LightCyan;
            this.txtBarcodeMaSach.Location = new System.Drawing.Point(142, 106);
            this.txtBarcodeMaSach.Name = "txtBarcodeMaSach";
            this.txtBarcodeMaSach.ReadOnly = true;
            this.txtBarcodeMaSach.Size = new System.Drawing.Size(153, 27);
            this.txtBarcodeMaSach.TabIndex = 20;
            // 
            // txtBarcodeSach
            // 
            this.txtBarcodeSach.BackColor = System.Drawing.Color.LightCyan;
            this.txtBarcodeSach.Location = new System.Drawing.Point(143, 55);
            this.txtBarcodeSach.Name = "txtBarcodeSach";
            this.txtBarcodeSach.ReadOnly = true;
            this.txtBarcodeSach.Size = new System.Drawing.Size(153, 27);
            this.txtBarcodeSach.TabIndex = 19;
            // 
            // dtgShow
            // 
            this.dtgShow.BackgroundColor = System.Drawing.Color.White;
            this.dtgShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenSach,
            this.soLuong,
            this.barcode});
            this.dtgShow.Location = new System.Drawing.Point(343, 55);
            this.dtgShow.Name = "dtgShow";
            this.dtgShow.RowHeadersWidth = 51;
            this.dtgShow.RowTemplate.Height = 29;
            this.dtgShow.Size = new System.Drawing.Size(331, 334);
            this.dtgShow.TabIndex = 18;
            this.dtgShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgShow_CellContentClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // TenSach
            // 
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.MinimumWidth = 6;
            this.TenSach.Name = "TenSach";
            this.TenSach.Width = 125;
            // 
            // soLuong
            // 
            this.soLuong.HeaderText = "Số Lượng";
            this.soLuong.MinimumWidth = 6;
            this.soLuong.Name = "soLuong";
            this.soLuong.Width = 125;
            // 
            // barcode
            // 
            this.barcode.HeaderText = "Barcode";
            this.barcode.MinimumWidth = 6;
            this.barcode.Name = "barcode";
            this.barcode.Visible = false;
            this.barcode.Width = 125;
            // 
            // fThemSachCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(686, 490);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbNXB);
            this.Controls.Add(this.txtDiemUyTinMin);
            this.Controls.Add(this.txtNamTaiBan);
            this.Controls.Add(this.txtKichCo);
            this.Controls.Add(this.txtLanTaiBan);
            this.Controls.Add(this.txtTinhTrang);
            this.Controls.Add(this.txtBarcodeMaSach);
            this.Controls.Add(this.txtBarcodeSach);
            this.Controls.Add(this.dtgShow);
            this.Name = "fThemSachCT";
            this.Text = "fThemSachCT";
            ((System.ComponentModel.ISupportInitialize)(this.dtgShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnThem;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbNXB;
        private TextBox txtDiemUyTinMin;
        private TextBox txtNamTaiBan;
        private TextBox txtKichCo;
        private TextBox txtLanTaiBan;
        private TextBox txtTinhTrang;
        private TextBox txtBarcodeMaSach;
        private TextBox txtBarcodeSach;
        private DataGridView dtgShow;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn TenSach;
        private DataGridViewTextBoxColumn soLuong;
        private DataGridViewTextBoxColumn barcode;
    }
}