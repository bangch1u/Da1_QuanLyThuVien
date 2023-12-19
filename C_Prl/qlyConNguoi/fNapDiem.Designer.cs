namespace C_Prl.qlyConNguoi
{
    partial class fNapDiem
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNap = new System.Windows.Forms.Button();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.cmbMucDiem = new System.Windows.Forms.ComboBox();
            this.txtIDTTV = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTheThuVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mức Điểm Nạp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Số Tiền Nạp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã Thẻ Thư Viện";
            // 
            // btnNap
            // 
            this.btnNap.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnNap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNap.ForeColor = System.Drawing.Color.White;
            this.btnNap.Location = new System.Drawing.Point(147, 250);
            this.btnNap.Name = "btnNap";
            this.btnNap.Size = new System.Drawing.Size(133, 67);
            this.btnNap.TabIndex = 15;
            this.btnNap.Text = "Nạp";
            this.btnNap.UseVisualStyleBackColor = false;
            this.btnNap.Click += new System.EventHandler(this.btnNap_Click);
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(147, 132);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(199, 27);
            this.txtSoTien.TabIndex = 13;
            // 
            // cmbMucDiem
            // 
            this.cmbMucDiem.FormattingEnabled = true;
            this.cmbMucDiem.Location = new System.Drawing.Point(147, 87);
            this.cmbMucDiem.Name = "cmbMucDiem";
            this.cmbMucDiem.Size = new System.Drawing.Size(199, 28);
            this.cmbMucDiem.TabIndex = 12;
            this.cmbMucDiem.SelectedIndexChanged += new System.EventHandler(this.cmbMucDiem_SelectedIndexChanged);
            // 
            // txtIDTTV
            // 
            this.txtIDTTV.Location = new System.Drawing.Point(147, 50);
            this.txtIDTTV.Name = "txtIDTTV";
            this.txtIDTTV.Size = new System.Drawing.Size(199, 27);
            this.txtIDTTV.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.IdTheThuVien,
            this.hoTen,
            this.diemUT});
            this.dataGridView1.Location = new System.Drawing.Point(26, 401);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(474, 192);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            this.stt.Width = 50;
            // 
            // IdTheThuVien
            // 
            this.IdTheThuVien.HeaderText = "Mã Thẻ Thư Viện";
            this.IdTheThuVien.MinimumWidth = 6;
            this.IdTheThuVien.Name = "IdTheThuVien";
            this.IdTheThuVien.Width = 125;
            // 
            // hoTen
            // 
            this.hoTen.HeaderText = "Họ Tên";
            this.hoTen.MinimumWidth = 6;
            this.hoTen.Name = "hoTen";
            this.hoTen.Width = 125;
            // 
            // diemUT
            // 
            this.diemUT.HeaderText = "Điểm Uy Tín";
            this.diemUT.MinimumWidth = 6;
            this.diemUT.Name = "diemUT";
            this.diemUT.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIDTTV);
            this.groupBox1.Controls.Add(this.btnNap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbMucDiem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSoTien);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 351);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nạp thẻ";
            // 
            // fNapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1122, 729);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "fNapDiem";
            this.Text = "fNapDiem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnNap;
        private TextBox txtSoTien;
        private ComboBox cmbMucDiem;
        private TextBox txtIDTTV;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn IdTheThuVien;
        private DataGridViewTextBoxColumn hoTen;
        private DataGridViewTextBoxColumn diemUT;
        private GroupBox groupBox1;
    }
}