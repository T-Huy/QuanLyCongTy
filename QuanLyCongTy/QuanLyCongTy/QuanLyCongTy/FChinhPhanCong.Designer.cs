namespace QuanLyCongTy
{
    partial class FChinhPhanCong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblThoiHan = new System.Windows.Forms.Label();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.gv_CongViec = new System.Windows.Forms.DataGridView();
            this.HoTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSuaPC = new System.Windows.Forms.Button();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.dtpDBLam = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
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
            // cboNhanVien
            // 
            this.cboNhanVien.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(39, 86);
            this.cboNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(271, 32);
            this.cboNhanVien.TabIndex = 34;
            // 
            // gv_CongViec
            // 
            this.gv_CongViec.BackgroundColor = System.Drawing.Color.White;
            this.gv_CongViec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_CongViec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gv_CongViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_CongViec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HoTenNV,
            this.TinhTrang,
            this.DL});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_CongViec.DefaultCellStyle = dataGridViewCellStyle4;
            this.gv_CongViec.Location = new System.Drawing.Point(439, 24);
            this.gv_CongViec.Margin = new System.Windows.Forms.Padding(10, 10, 4, 4);
            this.gv_CongViec.Name = "gv_CongViec";
            this.gv_CongViec.RowHeadersVisible = false;
            this.gv_CongViec.RowHeadersWidth = 62;
            this.gv_CongViec.RowTemplate.Height = 28;
            this.gv_CongViec.Size = new System.Drawing.Size(536, 458);
            this.gv_CongViec.TabIndex = 33;
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
            // btnSuaPC
            // 
            this.btnSuaPC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSuaPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaPC.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaPC.Location = new System.Drawing.Point(838, 490);
            this.btnSuaPC.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaPC.Name = "btnSuaPC";
            this.btnSuaPC.Size = new System.Drawing.Size(150, 40);
            this.btnSuaPC.TabIndex = 32;
            this.btnSuaPC.Text = "Sửa";
            this.btnSuaPC.UseVisualStyleBackColor = true;
            this.btnSuaPC.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVien.Location = new System.Drawing.Point(40, 61);
            this.lblNhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(85, 21);
            this.lblNhanVien.TabIndex = 30;
            this.lblNhanVien.Text = "Nhân viên:";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNgayBatDau);
            this.panel1.Controls.Add(this.dtpDBLam);
            this.panel1.Controls.Add(this.lblThoiHan);
            this.panel1.Controls.Add(this.dtpDeadline);
            this.panel1.Location = new System.Drawing.Point(39, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 143);
            this.panel1.TabIndex = 38;
            // 
            // btnHuy
            // 
            this.btnHuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(651, 490);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(150, 40);
            this.btnHuy.TabIndex = 37;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // FChinhPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 540);
            this.Controls.Add(this.cboNhanVien);
            this.Controls.Add(this.gv_CongViec);
            this.Controls.Add(this.btnSuaPC);
            this.Controls.Add(this.lblNhanVien);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnHuy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FChinhPhanCong";
            this.Text = "FChinhPhanCong";
            this.Load += new System.EventHandler(this.ChinhPhanCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_CongViec)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThoiHan;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.DataGridView gv_CongViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DL;
        private System.Windows.Forms.Button btnSuaPC;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lblNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpDBLam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHuy;
    }
}