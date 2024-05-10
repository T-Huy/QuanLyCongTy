namespace QuanLyCongTy
{
    partial class FThongTinDA
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbThem = new System.Windows.Forms.PictureBox();
            this.txtTenDa = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.lblMoTaTitle = new System.Windows.Forms.Label();
            this.lblThoiHan = new System.Windows.Forms.Label();
            this.lblThoiHanTitle = new System.Windows.Forms.Label();
            this.lblNgayBD = new System.Windows.Forms.Label();
            this.lblNgayBDTitle = new System.Windows.Forms.Label();
            this.lblDiaDiem = new System.Windows.Forms.Label();
            this.lblDiaDiemTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbThem)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 200);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1000, 500);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbThem);
            this.panel1.Controls.Add(this.txtTenDa);
            this.panel1.Controls.Add(this.txtMoTa);
            this.panel1.Controls.Add(this.lblMoTaTitle);
            this.panel1.Controls.Add(this.lblThoiHan);
            this.panel1.Controls.Add(this.lblThoiHanTitle);
            this.panel1.Controls.Add(this.lblNgayBD);
            this.panel1.Controls.Add(this.lblNgayBDTitle);
            this.panel1.Controls.Add(this.lblDiaDiem);
            this.panel1.Controls.Add(this.lblDiaDiemTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel1.Size = new System.Drawing.Size(1000, 200);
            this.panel1.TabIndex = 1;
            // 
            // pbThem
            // 
            this.pbThem.BackColor = System.Drawing.SystemColors.Control;
            this.pbThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbThem.Image = global::QuanLyCongTy.Properties.Resources.Add;
            this.pbThem.Location = new System.Drawing.Point(925, 127);
            this.pbThem.Name = "pbThem";
            this.pbThem.Size = new System.Drawing.Size(50, 50);
            this.pbThem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbThem.TabIndex = 11;
            this.pbThem.TabStop = false;
            this.pbThem.Click += new System.EventHandler(this.pbThem_Click);
            this.pbThem.MouseEnter += new System.EventHandler(this.pbThem_MouseEnter);
            this.pbThem.MouseLeave += new System.EventHandler(this.pbThem_MouseLeave);
            // 
            // txtTenDa
            // 
            this.txtTenDa.BackColor = System.Drawing.SystemColors.Control;
            this.txtTenDa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenDa.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTenDa.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDa.ForeColor = System.Drawing.Color.Blue;
            this.txtTenDa.Location = new System.Drawing.Point(0, 10);
            this.txtTenDa.Name = "txtTenDa";
            this.txtTenDa.ReadOnly = true;
            this.txtTenDa.Size = new System.Drawing.Size(1000, 33);
            this.txtTenDa.TabIndex = 10;
            this.txtTenDa.Text = "Tên";
            this.txtTenDa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMoTa
            // 
            this.txtMoTa.BackColor = System.Drawing.SystemColors.Control;
            this.txtMoTa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMoTa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Location = new System.Drawing.Point(531, 85);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.ReadOnly = true;
            this.txtMoTa.Size = new System.Drawing.Size(388, 109);
            this.txtMoTa.TabIndex = 9;
            this.txtMoTa.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtMoTa_MouseMove);
            // 
            // lblMoTaTitle
            // 
            this.lblMoTaTitle.AutoSize = true;
            this.lblMoTaTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoTaTitle.Location = new System.Drawing.Point(527, 59);
            this.lblMoTaTitle.Name = "lblMoTaTitle";
            this.lblMoTaTitle.Size = new System.Drawing.Size(61, 24);
            this.lblMoTaTitle.TabIndex = 8;
            this.lblMoTaTitle.Text = "Mô Tả";
            // 
            // lblThoiHan
            // 
            this.lblThoiHan.AutoSize = true;
            this.lblThoiHan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiHan.Location = new System.Drawing.Point(167, 141);
            this.lblThoiHan.Name = "lblThoiHan";
            this.lblThoiHan.Size = new System.Drawing.Size(32, 24);
            this.lblThoiHan.TabIndex = 7;
            this.lblThoiHan.Text = "TH";
            // 
            // lblThoiHanTitle
            // 
            this.lblThoiHanTitle.AutoSize = true;
            this.lblThoiHanTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiHanTitle.Location = new System.Drawing.Point(76, 141);
            this.lblThoiHanTitle.Name = "lblThoiHanTitle";
            this.lblThoiHanTitle.Size = new System.Drawing.Size(85, 24);
            this.lblThoiHanTitle.TabIndex = 6;
            this.lblThoiHanTitle.Text = "Thời hạn";
            // 
            // lblNgayBD
            // 
            this.lblNgayBD.AutoSize = true;
            this.lblNgayBD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayBD.Location = new System.Drawing.Point(203, 99);
            this.lblNgayBD.Name = "lblNgayBD";
            this.lblNgayBD.Size = new System.Drawing.Size(33, 24);
            this.lblNgayBD.TabIndex = 5;
            this.lblNgayBD.Text = "BD";
            // 
            // lblNgayBDTitle
            // 
            this.lblNgayBDTitle.AutoSize = true;
            this.lblNgayBDTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayBDTitle.Location = new System.Drawing.Point(76, 99);
            this.lblNgayBDTitle.Name = "lblNgayBDTitle";
            this.lblNgayBDTitle.Size = new System.Drawing.Size(121, 24);
            this.lblNgayBDTitle.TabIndex = 4;
            this.lblNgayBDTitle.Text = "Ngày bắt đầu";
            // 
            // lblDiaDiem
            // 
            this.lblDiaDiem.AutoSize = true;
            this.lblDiaDiem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaDiem.Location = new System.Drawing.Point(164, 59);
            this.lblDiaDiem.Name = "lblDiaDiem";
            this.lblDiaDiem.Size = new System.Drawing.Size(34, 24);
            this.lblDiaDiem.TabIndex = 3;
            this.lblDiaDiem.Text = "ĐĐ";
            // 
            // lblDiaDiemTitle
            // 
            this.lblDiaDiemTitle.AutoSize = true;
            this.lblDiaDiemTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaDiemTitle.Location = new System.Drawing.Point(77, 59);
            this.lblDiaDiemTitle.Name = "lblDiaDiemTitle";
            this.lblDiaDiemTitle.Size = new System.Drawing.Size(84, 24);
            this.lblDiaDiemTitle.TabIndex = 2;
            this.lblDiaDiemTitle.Text = "Địa điểm";
            // 
            // FThongTinDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FThongTinDA";
            this.Text = "FThongTinDA";
            this.Load += new System.EventHandler(this.FThongTinDA_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbThem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTenDa;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label lblMoTaTitle;
        private System.Windows.Forms.Label lblThoiHan;
        private System.Windows.Forms.Label lblThoiHanTitle;
        private System.Windows.Forms.Label lblNgayBD;
        private System.Windows.Forms.Label lblNgayBDTitle;
        private System.Windows.Forms.Label lblDiaDiem;
        private System.Windows.Forms.Label lblDiaDiemTitle;
        private System.Windows.Forms.PictureBox pbThem;
    }
}