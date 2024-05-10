namespace QuanLyCongTy
{
    partial class UCSailorStar
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
            this.lbl_TenPhong = new System.Windows.Forms.Label();
            this.lbl_tenDA = new System.Windows.Forms.Label();
            this.prgTienDo = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.lblTienDo = new System.Windows.Forms.Label();
            this.RatingStar = new Guna.UI2.WinForms.Guna2RatingStar();
            this.ptbBG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBG)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TenPhong
            // 
            this.lbl_TenPhong.AutoSize = true;
            this.lbl_TenPhong.BackColor = System.Drawing.Color.White;
            this.lbl_TenPhong.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenPhong.Location = new System.Drawing.Point(32, 55);
            this.lbl_TenPhong.Name = "lbl_TenPhong";
            this.lbl_TenPhong.Size = new System.Drawing.Size(97, 24);
            this.lbl_TenPhong.TabIndex = 19;
            this.lbl_TenPhong.Text = "Tên phòng";
            // 
            // lbl_tenDA
            // 
            this.lbl_tenDA.BackColor = System.Drawing.Color.White;
            this.lbl_tenDA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenDA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.lbl_tenDA.Location = new System.Drawing.Point(33, 18);
            this.lbl_tenDA.Name = "lbl_tenDA";
            this.lbl_tenDA.Size = new System.Drawing.Size(423, 30);
            this.lbl_tenDA.TabIndex = 18;
            this.lbl_tenDA.Text = "Tên dự án";
            // 
            // prgTienDo
            // 
            this.prgTienDo.Location = new System.Drawing.Point(36, 98);
            this.prgTienDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prgTienDo.Name = "prgTienDo";
            this.prgTienDo.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.prgTienDo.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.prgTienDo.Size = new System.Drawing.Size(420, 8);
            this.prgTienDo.TabIndex = 33;
            this.prgTienDo.Text = "guna2ProgressBar1";
            this.prgTienDo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // lblTienDo
            // 
            this.lblTienDo.AutoSize = true;
            this.lblTienDo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTienDo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTienDo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienDo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.lblTienDo.Location = new System.Drawing.Point(390, 62);
            this.lblTienDo.Name = "lblTienDo";
            this.lblTienDo.Size = new System.Drawing.Size(61, 24);
            this.lblTienDo.TabIndex = 34;
            this.lblTienDo.Text = "label1";
            // 
            // RatingStar
            // 
            this.RatingStar.BorderColor = System.Drawing.Color.Transparent;
            this.RatingStar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RatingStar.Location = new System.Drawing.Point(36, 119);
            this.RatingStar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RatingStar.Name = "RatingStar";
            this.RatingStar.RatingColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(11)))));
            this.RatingStar.ReadOnly = true;
            this.RatingStar.Size = new System.Drawing.Size(183, 32);
            this.RatingStar.TabIndex = 150;
            // 
            // ptbBG
            // 
            this.ptbBG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbBG.Image = global::QuanLyCongTy.Properties.Resources.Vien2;
            this.ptbBG.Location = new System.Drawing.Point(0, 0);
            this.ptbBG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbBG.Name = "ptbBG";
            this.ptbBG.Size = new System.Drawing.Size(495, 165);
            this.ptbBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBG.TabIndex = 27;
            this.ptbBG.TabStop = false;
            this.ptbBG.Click += new System.EventHandler(this.ptbBG_Click);
            // 
            // UCSailorStar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.RatingStar);
            this.Controls.Add(this.lblTienDo);
            this.Controls.Add(this.prgTienDo);
            this.Controls.Add(this.lbl_TenPhong);
            this.Controls.Add(this.lbl_tenDA);
            this.Controls.Add(this.ptbBG);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCSailorStar";
            this.Size = new System.Drawing.Size(495, 165);
            this.Load += new System.EventHandler(this.UCSailorStar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_TenPhong;
        private System.Windows.Forms.Label lbl_tenDA;
        private System.Windows.Forms.PictureBox ptbBG;
        private Guna.UI2.WinForms.Guna2ProgressBar prgTienDo;
        private System.Windows.Forms.Label lblTienDo;
        private Guna.UI2.WinForms.Guna2RatingStar RatingStar;
    }
}
