namespace C_Prl.qlySach
{
    partial class fQuanLyThietHai
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
            this.txtMaTH = new System.Windows.Forms.TextBox();
            this.txtTenThietHai = new System.Windows.Forms.TextBox();
            this.txtDiemUT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgShow = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenThietHai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemTru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgShow)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaTH);
            this.groupBox1.Controls.Add(this.txtTenThietHai);
            this.groupBox1.Controls.Add(this.txtDiemUT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(199, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 242);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Thiệt Hại";
            // 
            // txtMaTH
            // 
            this.txtMaTH.BackColor = System.Drawing.Color.LightCyan;
            this.txtMaTH.Location = new System.Drawing.Point(204, 48);
            this.txtMaTH.Name = "txtMaTH";
            this.txtMaTH.ReadOnly = true;
            this.txtMaTH.Size = new System.Drawing.Size(156, 27);
            this.txtMaTH.TabIndex = 0;
            // 
            // txtTenThietHai
            // 
            this.txtTenThietHai.Location = new System.Drawing.Point(204, 99);
            this.txtTenThietHai.Name = "txtTenThietHai";
            this.txtTenThietHai.Size = new System.Drawing.Size(156, 27);
            this.txtTenThietHai.TabIndex = 1;
            // 
            // txtDiemUT
            // 
            this.txtDiemUT.Location = new System.Drawing.Point(201, 155);
            this.txtDiemUT.Name = "txtDiemUT";
            this.txtDiemUT.Size = new System.Drawing.Size(156, 27);
            this.txtDiemUT.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Thiệt Hại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Thiệt Hại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Điểm Trừ Uy Tín";
            // 
            // dtgShow
            // 
            this.dtgShow.BackgroundColor = System.Drawing.Color.White;
            this.dtgShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaTh,
            this.tenThietHai,
            this.diemTru});
            this.dtgShow.GridColor = System.Drawing.Color.Black;
            this.dtgShow.Location = new System.Drawing.Point(30, 401);
            this.dtgShow.Name = "dtgShow";
            this.dtgShow.RowHeadersWidth = 51;
            this.dtgShow.RowTemplate.Height = 29;
            this.dtgShow.Size = new System.Drawing.Size(553, 188);
            this.dtgShow.TabIndex = 14;
            this.dtgShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgShow_CellContentClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // MaTh
            // 
            this.MaTh.HeaderText = "Mã Thiệt Hại";
            this.MaTh.MinimumWidth = 6;
            this.MaTh.Name = "MaTh";
            this.MaTh.Width = 125;
            // 
            // tenThietHai
            // 
            this.tenThietHai.HeaderText = "Tên Thiệt Hại";
            this.tenThietHai.MinimumWidth = 6;
            this.tenThietHai.Name = "tenThietHai";
            this.tenThietHai.Width = 200;
            // 
            // diemTru
            // 
            this.diemTru.HeaderText = "Mức Điểm Phạt";
            this.diemTru.MinimumWidth = 6;
            this.diemTru.Name = "diemTru";
            this.diemTru.Width = 125;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(46, 213);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(117, 58);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(47, 151);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(117, 58);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(45, 85);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(117, 58);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgShow);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(57, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(642, 625);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // fQuanLyThietHai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1116, 729);
            this.Controls.Add(this.groupBox2);
            this.Name = "fQuanLyThietHai";
            this.Text = "fQuanLyThietHai";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgShow)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtMaTH;
        private TextBox txtTenThietHai;
        private TextBox txtDiemUT;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dtgShow;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn MaTh;
        private DataGridViewTextBoxColumn tenThietHai;
        private DataGridViewTextBoxColumn diemTru;
        private GroupBox groupBox2;
    }
}