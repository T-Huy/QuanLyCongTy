namespace QuanLyCongTy
{
    partial class FPhanCong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblThoiHan = new System.Windows.Forms.Label();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.lblCongViec = new System.Windows.Forms.Label();
            this.btnTaoPC = new System.Windows.Forms.Button();
            this.gv_CongViec = new System.Windows.Forms.DataGridView();
            this.HoTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.cboCongViec = new System.Windows.Forms.ComboBox();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.dtpDBLam = new System.Windows.Forms.DateTimePicker();
            this.btnHuy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CongViec)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblThoiHan
            // 
            this.lblThoiHan.AutoSize = true;
            this.lblThoiHan.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiHan.Location = new System.Drawing.Point(6, 77);
            this.lblThoiHan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThoiHan.Name = "lblThoiHan";
            this.lblThoiHan.Size = new System.Drawing.Size(80, 21);
            this.lblThoiHan.TabIndex = 13;
            this.lblThoiHan.Text = "Thời hạn: ";
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDeadline.Location = new System.Drawing.Point(0, 102);
            this.dtpDeadline.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(314, 28);
            this.dtpDeadline.TabIndex = 12;
            // 
            // lblCongViec
            // 
            this.lblCongViec.AutoSize = true;
            this.lblCongViec.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCongViec.Location = new System.Drawing.Point(14, 125);
            this.lblCongViec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCongViec.Name = "lblCongViec";
            this.lblCongViec.Size = new System.Drawing.Size(81, 21);
            this.lblCongViec.TabIndex = 11;
            this.lblCongViec.Text = "Công việc:";
            // 
            // btnTaoPC
            // 
            this.btnTaoPC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTaoPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoPC.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoPC.Location = new System.Drawing.Point(813, 484);
            this.btnTaoPC.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaoPC.Name = "btnTaoPC";
            this.btnTaoPC.Size = new System.Drawing.Size(150, 40);
            this.btnTaoPC.TabIndex = 19;
            this.btnTaoPC.Text = "Thêm";
            this.btnTaoPC.UseVisualStyleBackColor = true;
            this.btnTaoPC.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // gv_CongViec
            // 
            this.gv_CongViec.BackgroundColor = System.Drawing.Color.White;
            this.gv_CongViec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_CongViec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_CongViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_CongViec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HoTenNV,
            this.TinhTrang,
            this.DL});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_CongViec.DefaultCellStyle = dataGridViewCellStyle2;
            this.gv_CongViec.Location = new System.Drawing.Point(414, 18);
            this.gv_CongViec.Margin = new System.Windows.Forms.Padding(10, 10, 4, 4);
            this.gv_CongViec.Name = "gv_CongViec";
            this.gv_CongViec.RowHeadersVisible = false;
            this.gv_CongViec.RowHeadersWidth = 62;
            this.gv_CongViec.RowTemplate.Height = 28;
            this.gv_CongViec.Size = new System.Drawing.Size(536, 458);
            this.gv_CongViec.TabIndex = 22;
            // 
            // HoTenNV
            // 
            this.HoTenNV.DataPropertyName = "HoTenNV";
            this.HoTenNV.HeaderText = "Tên Nhân Viên";
            this.HoTenNV.MinimumWidth = 6;
            this.HoTenNV.Name = "HoTenNV";
            this.HoTenNV.Width = 150;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Width = 125;
            // 
            // DL
            // 
            this.DL.DataPropertyName = "DL";
            this.DL.HeaderText = "Hạn gần nhất";
            this.DL.MinimumWidth = 6;
            this.DL.Name = "DL";
            this.DL.Width = 125;
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(14, 80);
            this.cboNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(271, 32);
            this.cboNhanVien.TabIndex = 23;
            // 
            // cboCongViec
            // 
            this.cboCongViec.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCongViec.FormattingEnabled = true;
            this.cboCongViec.Location = new System.Drawing.Point(14, 150);
            this.cboCongViec.Margin = new System.Windows.Forms.Padding(4);
            this.cboCongViec.Name = "cboCongViec";
            this.cboCongViec.Size = new System.Drawing.Size(330, 32);
            this.cboCongViec.TabIndex = 24;
            this.cboCongViec.SelectedIndexChanged += new System.EventHandler(this.cboCongViec_SelectedIndexChanged);
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVien.Location = new System.Drawing.Point(15, 55);
            this.lblNhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(85, 21);
            this.lblNhanVien.TabIndex = 9;
            this.lblNhanVien.Text = "Nhân viên:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(14, 204);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(330, 151);
            this.textBox1.TabIndex = 25;
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.AutoSize = true;
            this.lblNgayBatDau.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayBatDau.Location = new System.Drawing.Point(4, 7);
            this.lblNgayBatDau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(102, 21);
            this.lblNgayBatDau.TabIndex = 27;
            this.lblNgayBatDau.Text = "Ngày bắt đầu";
            // 
            // dtpDBLam
            // 
            this.dtpDBLam.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDBLam.Location = new System.Drawing.Point(0, 32);
            this.dtpDBLam.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDBLam.Name = "dtpDBLam";
            this.dtpDBLam.Size = new System.Drawing.Size(314, 28);
            this.dtpDBLam.TabIndex = 26;
            // 
            // btnHuy
            // 
            this.btnHuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(626, 484);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(150, 40);
            this.btnHuy.TabIndex = 28;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNgayBatDau);
            this.panel1.Controls.Add(this.dtpDBLam);
            this.panel1.Controls.Add(this.lblThoiHan);
            this.panel1.Controls.Add(this.dtpDeadline);
            this.panel1.Location = new System.Drawing.Point(14, 361);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 143);
            this.panel1.TabIndex = 29;
            // 
            // FPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 540);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cboCongViec);
            this.Controls.Add(this.cboNhanVien);
            this.Controls.Add(this.gv_CongViec);
            this.Controls.Add(this.btnTaoPC);
            this.Controls.Add(this.lblCongViec);
            this.Controls.Add(this.lblNhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FPhanCong";
            this.Text = "PhanCong";
            this.Load += new System.EventHandler(this.PhanCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_CongViec)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblThoiHan;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
        private System.Windows.Forms.Label lblCongViec;
        private System.Windows.Forms.Button btnTaoPC;
        private System.Windows.Forms.DataGridView gv_CongViec;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.ComboBox cboCongViec;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpDBLam;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DL;
    }
}