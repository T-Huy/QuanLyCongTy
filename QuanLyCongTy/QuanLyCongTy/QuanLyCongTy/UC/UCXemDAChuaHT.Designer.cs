namespace QuanLyCongTy
{
    partial class UCXemDAChuaHT
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
            this.lbl_NgayCL = new System.Windows.Forms.Label();
            this.lbl_TenPhong = new System.Windows.Forms.Label();
            this.lbl_tenDA = new System.Windows.Forms.Label();
            this.ucTienDo = new QuanLyCongTy.UCTienDo();
            this.SuspendLayout();
            // 
            // lbl_NgayCL
            // 
            this.lbl_NgayCL.AutoSize = true;
            this.lbl_NgayCL.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayCL.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_NgayCL.Location = new System.Drawing.Point(16, 132);
            this.lbl_NgayCL.Name = "lbl_NgayCL";
            this.lbl_NgayCL.Size = new System.Drawing.Size(94, 21);
            this.lbl_NgayCL.TabIndex = 23;
            this.lbl_NgayCL.Text = "Ngày còn lại";
            // 
            // lbl_TenPhong
            // 
            this.lbl_TenPhong.AutoSize = true;
            this.lbl_TenPhong.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenPhong.Location = new System.Drawing.Point(23, 53);
            this.lbl_TenPhong.Name = "lbl_TenPhong";
            this.lbl_TenPhong.Size = new System.Drawing.Size(97, 24);
            this.lbl_TenPhong.TabIndex = 22;
            this.lbl_TenPhong.Text = "Tên phòng";
            // 
            // lbl_tenDA
            // 
            this.lbl_tenDA.AutoSize = true;
            this.lbl_tenDA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenDA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_tenDA.Location = new System.Drawing.Point(16, 19);
            this.lbl_tenDA.Name = "lbl_tenDA";
            this.lbl_tenDA.Size = new System.Drawing.Size(94, 24);
            this.lbl_tenDA.TabIndex = 21;
            this.lbl_tenDA.Text = "Tên dự án";
            // 
            // ucTienDo
            // 
            this.ucTienDo.Location = new System.Drawing.Point(20, 65);
            this.ucTienDo.Name = "ucTienDo";
            this.ucTienDo.Size = new System.Drawing.Size(410, 55);
            this.ucTienDo.TabIndex = 26;
            // 
            // UCXemDAChuaHT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_NgayCL);
            this.Controls.Add(this.lbl_TenPhong);
            this.Controls.Add(this.lbl_tenDA);
            this.Controls.Add(this.ucTienDo);
            this.Name = "UCXemDAChuaHT";
            this.Size = new System.Drawing.Size(490, 160);
            this.Click += new System.EventHandler(this.UCXemDAChuaHT_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_NgayCL;
        private System.Windows.Forms.Label lbl_TenPhong;
        private System.Windows.Forms.Label lbl_tenDA;
        private UCTienDo ucTienDo;
    }
}
