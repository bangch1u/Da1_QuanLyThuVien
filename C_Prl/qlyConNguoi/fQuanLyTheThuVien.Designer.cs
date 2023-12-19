namespace C_Prl.qlyConNguoi
{
    partial class fQuanLyTheThuVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdThe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSuaThe = new System.Windows.Forms.Button();
            this.btnThemThe = new System.Windows.Forms.Button();
            this.btnNap = new System.Windows.Forms.Button();
            this.dtgShow = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTheTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnF5 = new System.Windows.Forms.Button();
            this.btnXoaThe = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgShow)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIdThe);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSdt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(398, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 232);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Thẻ";
            // 
            // txtIdThe
            // 
            this.txtIdThe.BackColor = System.Drawing.Color.PowderBlue;
            this.txtIdThe.Location = new System.Drawing.Point(162, 54);
            this.txtIdThe.Name = "txtIdThe";
            this.txtIdThe.ReadOnly = true;
            this.txtIdThe.Size = new System.Drawing.Size(188, 27);
            this.txtIdThe.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Số Điện Thoại";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(162, 99);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(188, 27);
            this.txtHoTen.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Họ Tên";
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(162, 157);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(188, 27);
            this.txtSdt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã Thẻ Thư Viện";
            // 
            // btnSuaThe
            // 
            this.btnSuaThe.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSuaThe.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSuaThe.ForeColor = System.Drawing.Color.White;
            this.btnSuaThe.Location = new System.Drawing.Point(69, 174);
            this.btnSuaThe.Name = "btnSuaThe";
            this.btnSuaThe.Size = new System.Drawing.Size(183, 48);
            this.btnSuaThe.TabIndex = 15;
            this.btnSuaThe.Text = "Sửa Thẻ";
            this.btnSuaThe.UseVisualStyleBackColor = false;
            this.btnSuaThe.Click += new System.EventHandler(this.btnSuaThe_Click);
            // 
            // btnThemThe
            // 
            this.btnThemThe.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThemThe.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThemThe.ForeColor = System.Drawing.Color.White;
            this.btnThemThe.Location = new System.Drawing.Point(69, 104);
            this.btnThemThe.Name = "btnThemThe";
            this.btnThemThe.Size = new System.Drawing.Size(183, 48);
            this.btnThemThe.TabIndex = 14;
            this.btnThemThe.Text = "Thêm Thẻ";
            this.btnThemThe.UseVisualStyleBackColor = false;
            this.btnThemThe.Click += new System.EventHandler(this.btnThemThe_Click);
            // 
            // btnNap
            // 
            this.btnNap.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnNap.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNap.ForeColor = System.Drawing.Color.White;
            this.btnNap.Location = new System.Drawing.Point(69, 31);
            this.btnNap.Name = "btnNap";
            this.btnNap.Size = new System.Drawing.Size(183, 48);
            this.btnNap.TabIndex = 13;
            this.btnNap.Text = "Nạp Điểm";
            this.btnNap.UseVisualStyleBackColor = false;
            this.btnNap.Click += new System.EventHandler(this.btnNap_Click);
            // 
            // dtgShow
            // 
            this.dtgShow.BackgroundColor = System.Drawing.Color.White;
            this.dtgShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.idTheTV,
            this.hoTen,
            this.sodienthoai,
            this.diemUT,
            this.TrangThai});
            this.dtgShow.GridColor = System.Drawing.Color.Black;
            this.dtgShow.Location = new System.Drawing.Point(69, 334);
            this.dtgShow.Name = "dtgShow";
            this.dtgShow.RowHeadersWidth = 51;
            this.dtgShow.RowTemplate.Height = 29;
            this.dtgShow.Size = new System.Drawing.Size(733, 271);
            this.dtgShow.TabIndex = 12;
            this.dtgShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgShow_CellContentClick);
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            this.stt.Width = 50;
            // 
            // idTheTV
            // 
            this.idTheTV.HeaderText = "Mã Thẻ Thư Viện";
            this.idTheTV.MinimumWidth = 6;
            this.idTheTV.Name = "idTheTV";
            this.idTheTV.Width = 125;
            // 
            // hoTen
            // 
            this.hoTen.HeaderText = "Họ Tên";
            this.hoTen.MinimumWidth = 6;
            this.hoTen.Name = "hoTen";
            this.hoTen.Width = 125;
            // 
            // sodienthoai
            // 
            this.sodienthoai.HeaderText = "Số Điện Thoại";
            this.sodienthoai.MinimumWidth = 6;
            this.sodienthoai.Name = "sodienthoai";
            this.sodienthoai.Width = 125;
            // 
            // diemUT
            // 
            this.diemUT.HeaderText = "Điểm Uy Tín";
            this.diemUT.MinimumWidth = 6;
            this.diemUT.Name = "diemUT";
            this.diemUT.Width = 125;
            // 
            // TrangThai
            // 
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Width = 125;
            // 
            // btnF5
            // 
            this.btnF5.Location = new System.Drawing.Point(708, 611);
            this.btnF5.Name = "btnF5";
            this.btnF5.Size = new System.Drawing.Size(94, 29);
            this.btnF5.TabIndex = 17;
            this.btnF5.Text = "F5";
            this.btnF5.UseVisualStyleBackColor = true;
            this.btnF5.Click += new System.EventHandler(this.btnF5_Click);
            // 
            // btnXoaThe
            // 
            this.btnXoaThe.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnXoaThe.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoaThe.ForeColor = System.Drawing.Color.White;
            this.btnXoaThe.Location = new System.Drawing.Point(69, 247);
            this.btnXoaThe.Name = "btnXoaThe";
            this.btnXoaThe.Size = new System.Drawing.Size(183, 48);
            this.btnXoaThe.TabIndex = 18;
            this.btnXoaThe.Text = "Xóa Thẻ";
            this.btnXoaThe.UseVisualStyleBackColor = false;
            this.btnXoaThe.Click += new System.EventHandler(this.btnXoaThe_Click);
            // 
            // fQuanLyTheThuVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1122, 729);
            this.Controls.Add(this.btnXoaThe);
            this.Controls.Add(this.btnF5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSuaThe);
            this.Controls.Add(this.btnThemThe);
            this.Controls.Add(this.btnNap);
            this.Controls.Add(this.dtgShow);
            this.Name = "fQuanLyTheThuVien";
            this.Text = "fQuanLyTheThuVien";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtIdThe;
        private Label label3;
        private TextBox txtHoTen;
        private Label label2;
        private TextBox txtSdt;
        private Label label1;
        private Button btnSuaThe;
        private Button btnThemThe;
        private Button btnNap;
        private DataGridView dtgShow;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn idTheTV;
        private DataGridViewTextBoxColumn hoTen;
        private DataGridViewTextBoxColumn sodienthoai;
        private DataGridViewTextBoxColumn diemUT;
        private DataGridViewTextBoxColumn TrangThai;
        private Button btnF5;
        private Button btnXoaThe;
    }
}