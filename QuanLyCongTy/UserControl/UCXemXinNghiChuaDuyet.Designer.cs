namespace QuanLyCongTy
{
    partial class UCXemXinNghiChuaDuyet
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_MaNV = new System.Windows.Forms.Label();
            this.lb_NgayNghi = new System.Windows.Forms.Label();
            this.lb_SoNgayNghi = new System.Windows.Forms.Label();
            this.lb_Lydo = new System.Windows.Forms.Label();
            this.ptB_ChuaDuyet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptB_ChuaDuyet)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_MaNV
            // 
            this.lb_MaNV.AutoSize = true;
            this.lb_MaNV.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.lb_MaNV.Location = new System.Drawing.Point(16, 9);
            this.lb_MaNV.Name = "lb_MaNV";
            this.lb_MaNV.Size = new System.Drawing.Size(62, 24);
            this.lb_MaNV.TabIndex = 28;
            this.lb_MaNV.Text = "MaNV";
            // 
            // lb_NgayNghi
            // 
            this.lb_NgayNghi.AutoSize = true;
            this.lb_NgayNghi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NgayNghi.ForeColor = System.Drawing.Color.Black;
            this.lb_NgayNghi.Location = new System.Drawing.Point(16, 38);
            this.lb_NgayNghi.Name = "lb_NgayNghi";
            this.lb_NgayNghi.Size = new System.Drawing.Size(94, 24);
            this.lb_NgayNghi.TabIndex = 30;
            this.lb_NgayNghi.Text = "Ngày Nghỉ";
            // 
            // lb_SoNgayNghi
            // 
            this.lb_SoNgayNghi.AutoSize = true;
            this.lb_SoNgayNghi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoNgayNghi.ForeColor = System.Drawing.Color.Black;
            this.lb_SoNgayNghi.Location = new System.Drawing.Point(183, 38);
            this.lb_SoNgayNghi.Name = "lb_SoNgayNghi";
            this.lb_SoNgayNghi.Size = new System.Drawing.Size(119, 24);
            this.lb_SoNgayNghi.TabIndex = 31;
            this.lb_SoNgayNghi.Text = "Số Ngày Nghỉ";
            // 
            // lb_Lydo
            // 
            this.lb_Lydo.AutoSize = true;
            this.lb_Lydo.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Lydo.ForeColor = System.Drawing.Color.Black;
            this.lb_Lydo.Location = new System.Drawing.Point(16, 71);
            this.lb_Lydo.Name = "lb_Lydo";
            this.lb_Lydo.Size = new System.Drawing.Size(55, 24);
            this.lb_Lydo.TabIndex = 32;
            this.lb_Lydo.Text = "Lý Do";
            // 
            // ptB_ChuaDuyet
            // 
            this.ptB_ChuaDuyet.ErrorImage = null;
            this.ptB_ChuaDuyet.Image = global::QuanLyCongTy.Properties.Resources.Vien2;
            this.ptB_ChuaDuyet.InitialImage = null;
            this.ptB_ChuaDuyet.Location = new System.Drawing.Point(0, 0);
            this.ptB_ChuaDuyet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ptB_ChuaDuyet.Name = "ptB_ChuaDuyet";
            this.ptB_ChuaDuyet.Size = new System.Drawing.Size(767, 108);
            this.ptB_ChuaDuyet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptB_ChuaDuyet.TabIndex = 0;
            this.ptB_ChuaDuyet.TabStop = false;
            // 
            // UCXemXinNghiChuaDuyet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.lb_Lydo);
            this.Controls.Add(this.lb_SoNgayNghi);
            this.Controls.Add(this.lb_NgayNghi);
            this.Controls.Add(this.lb_MaNV);
            this.Controls.Add(this.ptB_ChuaDuyet);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCXemXinNghiChuaDuyet";
            this.Size = new System.Drawing.Size(767, 108);
            this.Load += new System.EventHandler(this.UCXemXinNghiChuaDuyet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptB_ChuaDuyet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptB_ChuaDuyet;
        private System.Windows.Forms.Label lb_MaNV;
        private System.Windows.Forms.Label lb_NgayNghi;
        private System.Windows.Forms.Label lb_SoNgayNghi;
        private System.Windows.Forms.Label lb_Lydo;
    }
}
