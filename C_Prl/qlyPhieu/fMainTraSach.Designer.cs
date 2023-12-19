namespace C_Prl.qlyPhieu
{
    partial class fMainTraSach
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
            this.pm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPMCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTrả = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnQuaHan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.txtMaPhieuTra = new System.Windows.Forms.TextBox();
            this.txtBarcodeMaSach = new System.Windows.Forms.TextBox();
            this.txtTinhTrangSach = new System.Windows.Forms.TextBox();
            this.txtMaPM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            ((System.ComponentModel.ISupportInitialize)(this.dtgShow)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgShow
            // 
            this.dtgShow.BackgroundColor = System.Drawing.Color.White;
            this.dtgShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.pm,
            this.MaSach,
            this.tenSach,
            this.MaPMCT,
            this.tenKhachHang,
            this.NgayMuon,
            this.NgayTrả,
            this.trangThai});
            this.dtgShow.Location = new System.Drawing.Point(32, 36);
            this.dtgShow.Name = "dtgShow";
            this.dtgShow.RowHeadersWidth = 51;
            this.dtgShow.RowTemplate.Height = 29;
            this.dtgShow.Size = new System.Drawing.Size(969, 229);
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
            // pm
            // 
            this.pm.HeaderText = "Mã Phiếu Mượn";
            this.pm.MinimumWidth = 6;
            this.pm.Name = "pm";
            this.pm.Width = 125;
            // 
            // MaSach
            // 
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.Width = 125;
            // 
            // tenSach
            // 
            this.tenSach.HeaderText = "Tên Sách";
            this.tenSach.MinimumWidth = 6;
            this.tenSach.Name = "tenSach";
            this.tenSach.Width = 200;
            // 
            // MaPMCT
            // 
            this.MaPMCT.HeaderText = "Mã PMCT";
            this.MaPMCT.MinimumWidth = 6;
            this.MaPMCT.Name = "MaPMCT";
            this.MaPMCT.Width = 125;
            // 
            // tenKhachHang
            // 
            this.tenKhachHang.HeaderText = "Người Mượn";
            this.tenKhachHang.MinimumWidth = 6;
            this.tenKhachHang.Name = "tenKhachHang";
            this.tenKhachHang.Width = 160;
            // 
            // NgayMuon
            // 
            this.NgayMuon.HeaderText = "Ngày Mượn";
            this.NgayMuon.MinimumWidth = 6;
            this.NgayMuon.Name = "NgayMuon";
            this.NgayMuon.Width = 125;
            // 
            // NgayTrả
            // 
            this.NgayTrả.HeaderText = "Ngày Trả";
            this.NgayTrả.MinimumWidth = 6;
            this.NgayTrả.Name = "NgayTrả";
            this.NgayTrả.Width = 125;
            // 
            // trangThai
            // 
            this.trangThai.HeaderText = "Trạng Thái";
            this.trangThai.MinimumWidth = 6;
            this.trangThai.Name = "trangThai";
            this.trangThai.Visible = false;
            this.trangThai.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnQuaHan);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnTraSach);
            this.groupBox2.Controls.Add(this.txtMaPhieuTra);
            this.groupBox2.Controls.Add(this.txtBarcodeMaSach);
            this.groupBox2.Controls.Add(this.txtTinhTrangSach);
            this.groupBox2.Controls.Add(this.txtMaPM);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1019, 317);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Phiếu Trả";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnQuaHan
            // 
            this.btnQuaHan.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnQuaHan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuaHan.ForeColor = System.Drawing.Color.White;
            this.btnQuaHan.Location = new System.Drawing.Point(693, 211);
            this.btnQuaHan.Name = "btnQuaHan";
            this.btnQuaHan.Size = new System.Drawing.Size(121, 64);
            this.btnQuaHan.TabIndex = 49;
            this.btnQuaHan.Text = "Quá Hạn";
            this.btnQuaHan.UseVisualStyleBackColor = false;
            this.btnQuaHan.Click += new System.EventHandler(this.btnQuaHan_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(455, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 64);
            this.button1.TabIndex = 47;
            this.button1.Text = "Phạt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(72, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Tên Sách:";
            // 
            // btnTraSach
            // 
            this.btnTraSach.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnTraSach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTraSach.ForeColor = System.Drawing.Color.White;
            this.btnTraSach.Location = new System.Drawing.Point(234, 211);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(121, 64);
            this.btnTraSach.TabIndex = 46;
            this.btnTraSach.Text = "Trả Sách";
            this.btnTraSach.UseVisualStyleBackColor = false;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // txtMaPhieuTra
            // 
            this.txtMaPhieuTra.BackColor = System.Drawing.Color.LightCyan;
            this.txtMaPhieuTra.Location = new System.Drawing.Point(234, 35);
            this.txtMaPhieuTra.Name = "txtMaPhieuTra";
            this.txtMaPhieuTra.ReadOnly = true;
            this.txtMaPhieuTra.Size = new System.Drawing.Size(204, 27);
            this.txtMaPhieuTra.TabIndex = 35;
            // 
            // txtBarcodeMaSach
            // 
            this.txtBarcodeMaSach.BackColor = System.Drawing.Color.LightCyan;
            this.txtBarcodeMaSach.Location = new System.Drawing.Point(654, 38);
            this.txtBarcodeMaSach.Name = "txtBarcodeMaSach";
            this.txtBarcodeMaSach.ReadOnly = true;
            this.txtBarcodeMaSach.Size = new System.Drawing.Size(202, 27);
            this.txtBarcodeMaSach.TabIndex = 36;
            // 
            // txtTinhTrangSach
            // 
            this.txtTinhTrangSach.Location = new System.Drawing.Point(235, 124);
            this.txtTinhTrangSach.Name = "txtTinhTrangSach";
            this.txtTinhTrangSach.Size = new System.Drawing.Size(202, 27);
            this.txtTinhTrangSach.TabIndex = 42;
            // 
            // txtMaPM
            // 
            this.txtMaPM.BackColor = System.Drawing.Color.LightCyan;
            this.txtMaPM.Location = new System.Drawing.Point(654, 118);
            this.txtMaPM.Name = "txtMaPM";
            this.txtMaPM.ReadOnly = true;
            this.txtMaPM.Size = new System.Drawing.Size(202, 27);
            this.txtMaPM.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(479, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Mã Phiếu Mượn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(67, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Tình Trạng Sách:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(479, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Mã Sách:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgShow);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 367);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1019, 283);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            // 
            // sqlCommandBuilder1
            // 
            this.sqlCommandBuilder1.DataAdapter = null;
            this.sqlCommandBuilder1.QuotePrefix = "[";
            this.sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // fMainTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1230, 676);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "fMainTraSach";
            this.Text = "fMainTraSach";
            ((System.ComponentModel.ISupportInitialize)(this.dtgShow)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dtgShow;
        private GroupBox groupBox2;
        private Button button1;
        private Label label1;
        private Button btnTraSach;
        private TextBox txtMaPhieuTra;
        private TextBox txtBarcodeMaSach;
        private TextBox txtTinhTrangSach;
        private TextBox txtMaPM;
        private Label label4;
        private Label label2;
        private Label label3;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn pm;
        private DataGridViewTextBoxColumn MaSach;
        private DataGridViewTextBoxColumn tenSach;
        private DataGridViewTextBoxColumn MaPMCT;
        private DataGridViewTextBoxColumn tenKhachHang;
        private DataGridViewTextBoxColumn trangThai;
        private GroupBox groupBox1;
        private Button btnQuaHan;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private DataGridViewTextBoxColumn NgayMuon;
        private DataGridViewTextBoxColumn NgayTra;
        private DataGridViewTextBoxColumn NgayTrả;
    }
}