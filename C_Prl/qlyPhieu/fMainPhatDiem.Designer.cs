namespace C_Prl.qlyPhieu
{
    partial class fMainPhatDiem
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbThietHai = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnF5 = new System.Windows.Forms.Button();
            this.btnKhongPhat = new System.Windows.Forms.Button();
            this.dtgPhieuTra = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrangSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSCt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPhatDiem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhieuTra)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnF5);
            this.groupBox1.Controls.Add(this.btnKhongPhat);
            this.groupBox1.Controls.Add(this.dtgPhieuTra);
            this.groupBox1.Controls.Add(this.btnPhatDiem);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(22, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 459);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbThietHai);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(338, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 125);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            // 
            // cmbThietHai
            // 
            this.cmbThietHai.FormattingEnabled = true;
            this.cmbThietHai.Location = new System.Drawing.Point(93, 47);
            this.cmbThietHai.Name = "cmbThietHai";
            this.cmbThietHai.Size = new System.Drawing.Size(151, 28);
            this.cmbThietHai.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Thiệt Hại:";
            // 
            // btnF5
            // 
            this.btnF5.Location = new System.Drawing.Point(657, 181);
            this.btnF5.Name = "btnF5";
            this.btnF5.Size = new System.Drawing.Size(94, 29);
            this.btnF5.TabIndex = 35;
            this.btnF5.Text = "F5";
            this.btnF5.UseVisualStyleBackColor = true;
            this.btnF5.Click += new System.EventHandler(this.btnF5_Click);
            // 
            // btnKhongPhat
            // 
            this.btnKhongPhat.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnKhongPhat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKhongPhat.ForeColor = System.Drawing.Color.White;
            this.btnKhongPhat.Location = new System.Drawing.Point(49, 121);
            this.btnKhongPhat.Name = "btnKhongPhat";
            this.btnKhongPhat.Size = new System.Drawing.Size(150, 68);
            this.btnKhongPhat.TabIndex = 34;
            this.btnKhongPhat.Text = "Không Phạt";
            this.btnKhongPhat.UseVisualStyleBackColor = false;
            this.btnKhongPhat.Click += new System.EventHandler(this.btnKhongPhat_Click);
            // 
            // dtgPhieuTra
            // 
            this.dtgPhieuTra.BackgroundColor = System.Drawing.Color.White;
            this.dtgPhieuTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPhieuTra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.mapt,
            this.NgayTra,
            this.TinhTrangSach,
            this.maSCt,
            this.maPM});
            this.dtgPhieuTra.Location = new System.Drawing.Point(36, 216);
            this.dtgPhieuTra.Name = "dtgPhieuTra";
            this.dtgPhieuTra.RowHeadersWidth = 51;
            this.dtgPhieuTra.RowTemplate.Height = 29;
            this.dtgPhieuTra.Size = new System.Drawing.Size(719, 206);
            this.dtgPhieuTra.TabIndex = 33;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // mapt
            // 
            this.mapt.HeaderText = "Mã Phiếu Trả";
            this.mapt.MinimumWidth = 6;
            this.mapt.Name = "mapt";
            this.mapt.Width = 125;
            // 
            // NgayTra
            // 
            this.NgayTra.HeaderText = "Ngày Trả";
            this.NgayTra.MinimumWidth = 6;
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.Width = 125;
            // 
            // TinhTrangSach
            // 
            this.TinhTrangSach.HeaderText = "Tình Trạng Sách";
            this.TinhTrangSach.MinimumWidth = 6;
            this.TinhTrangSach.Name = "TinhTrangSach";
            this.TinhTrangSach.Width = 125;
            // 
            // maSCt
            // 
            this.maSCt.HeaderText = "Mã Sách";
            this.maSCt.MinimumWidth = 6;
            this.maSCt.Name = "maSCt";
            this.maSCt.Width = 125;
            // 
            // maPM
            // 
            this.maPM.HeaderText = "Mã Phiếu Mượn";
            this.maPM.MinimumWidth = 6;
            this.maPM.Name = "maPM";
            this.maPM.Width = 125;
            // 
            // btnPhatDiem
            // 
            this.btnPhatDiem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnPhatDiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPhatDiem.ForeColor = System.Drawing.Color.White;
            this.btnPhatDiem.Location = new System.Drawing.Point(49, 55);
            this.btnPhatDiem.Name = "btnPhatDiem";
            this.btnPhatDiem.Size = new System.Drawing.Size(150, 67);
            this.btnPhatDiem.TabIndex = 32;
            this.btnPhatDiem.Text = "Phạt điểm";
            this.btnPhatDiem.UseVisualStyleBackColor = false;
            this.btnPhatDiem.Click += new System.EventHandler(this.btnPhatDiem_Click);
            // 
            // fMainPhatDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(807, 477);
            this.Controls.Add(this.groupBox1);
            this.Name = "fMainPhatDiem";
            this.Text = "fMainPhatDiem";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhieuTra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnF5;
        private Button btnKhongPhat;
        private DataGridView dtgPhieuTra;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn mapt;
        private DataGridViewTextBoxColumn NgayTra;
        private DataGridViewTextBoxColumn TinhTrangSach;
        private DataGridViewTextBoxColumn maSCt;
        private DataGridViewTextBoxColumn maPM;
        private Button btnPhatDiem;
        private ComboBox cmbThietHai;
        private Label label5;
        private GroupBox groupBox2;
    }
}