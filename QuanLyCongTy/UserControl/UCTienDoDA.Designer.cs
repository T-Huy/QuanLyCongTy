namespace QuanLyCongTy
{
    partial class UCTienDoDA
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
            this.lblNgayConLai = new System.Windows.Forms.Label();
            this.lblTenPhong = new System.Windows.Forms.Label();
            this.lblTenDA = new System.Windows.Forms.Label();
            this.prgTienDo = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.lblTienDo = new System.Windows.Forms.Label();
            this.ptbBG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBG)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNgayConLai
            // 
            this.lblNgayConLai.AutoSize = true;
            this.lblNgayConLai.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayConLai.ForeColor = System.Drawing.Color.Gray;
            this.lblNgayConLai.Location = new System.Drawing.Point(32, 126);
            this.lblNgayConLai.Name = "lblNgayConLai";
            this.lblNgayConLai.Size = new System.Drawing.Size(94, 21);
            this.lblNgayConLai.TabIndex = 29;
            this.lblNgayConLai.Text = "Ngày còn lại";
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPhong.ForeColor = System.Drawing.Color.Black;
            this.lblTenPhong.Location = new System.Drawing.Point(31, 58);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(97, 24);
            this.lblTenPhong.TabIndex = 28;
            this.lblTenPhong.Text = "Tên phòng";
            // 
            // lblTenDA
            // 
            this.lblTenDA.AutoSize = true;
            this.lblTenDA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.lblTenDA.Location = new System.Drawing.Point(31, 27);
            this.lblTenDA.Name = "lblTenDA";
            this.lblTenDA.Size = new System.Drawing.Size(94, 24);
            this.lblTenDA.TabIndex = 27;
            this.lblTenDA.Text = "Tên dự án";
            // 
            // prgTienDo
            // 
            this.prgTienDo.Location = new System.Drawing.Point(36, 97);
            this.prgTienDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prgTienDo.Name = "prgTienDo";
            this.prgTienDo.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.prgTienDo.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.prgTienDo.Size = new System.Drawing.Size(420, 10);
            this.prgTienDo.TabIndex = 32;
            this.prgTienDo.Text = "guna2ProgressBar1";
            this.prgTienDo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // lblTienDo
            // 
            this.lblTienDo.AutoSize = true;
            this.lblTienDo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTienDo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTienDo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienDo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.lblTienDo.Location = new System.Drawing.Point(387, 66);
            this.lblTienDo.Name = "lblTienDo";
            this.lblTienDo.Size = new System.Drawing.Size(61, 24);
            this.lblTienDo.TabIndex = 33;
            this.lblTienDo.Text = "label1";
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
            this.ptbBG.TabIndex = 26;
            this.ptbBG.TabStop = false;
            this.ptbBG.Click += new System.EventHandler(this.ptbBG_Click);
            // 
            // UCTienDoDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.lblTienDo);
            this.Controls.Add(this.prgTienDo);
            this.Controls.Add(this.lblNgayConLai);
            this.Controls.Add(this.lblTenPhong);
            this.Controls.Add(this.lblTenDA);
            this.Controls.Add(this.ptbBG);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCTienDoDA";
            this.Size = new System.Drawing.Size(495, 165);
            this.Load += new System.EventHandler(this.UCTienDoDA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNgayConLai;
        private System.Windows.Forms.Label lblTenPhong;
        private System.Windows.Forms.Label lblTenDA;
        private System.Windows.Forms.PictureBox ptbBG;
        private Guna.UI2.WinForms.Guna2ProgressBar prgTienDo;
        private System.Windows.Forms.Label lblTienDo;
    }
}
