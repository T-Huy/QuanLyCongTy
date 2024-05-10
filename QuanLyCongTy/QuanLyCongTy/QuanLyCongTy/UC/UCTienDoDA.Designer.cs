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
            this.lbl_NgayCL = new System.Windows.Forms.Label();
            this.lbl_TenPhong = new System.Windows.Forms.Label();
            this.lbl_tenDA = new System.Windows.Forms.Label();
            this.ptbDelete = new System.Windows.Forms.PictureBox();
            this.ptbSetting = new System.Windows.Forms.PictureBox();
            this.ucTienDo = new QuanLyCongTy.UCTienDo();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_NgayCL
            // 
            this.lbl_NgayCL.AutoSize = true;
            this.lbl_NgayCL.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayCL.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_NgayCL.Location = new System.Drawing.Point(19, 129);
            this.lbl_NgayCL.Name = "lbl_NgayCL";
            this.lbl_NgayCL.Size = new System.Drawing.Size(94, 21);
            this.lbl_NgayCL.TabIndex = 15;
            this.lbl_NgayCL.Text = "Ngày còn lại";
            // 
            // lbl_TenPhong
            // 
            this.lbl_TenPhong.AutoSize = true;
            this.lbl_TenPhong.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenPhong.Location = new System.Drawing.Point(26, 50);
            this.lbl_TenPhong.Name = "lbl_TenPhong";
            this.lbl_TenPhong.Size = new System.Drawing.Size(97, 24);
            this.lbl_TenPhong.TabIndex = 13;
            this.lbl_TenPhong.Text = "Tên phòng";
            // 
            // lbl_tenDA
            // 
            this.lbl_tenDA.AutoSize = true;
            this.lbl_tenDA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenDA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_tenDA.Location = new System.Drawing.Point(19, 16);
            this.lbl_tenDA.Name = "lbl_tenDA";
            this.lbl_tenDA.Size = new System.Drawing.Size(94, 24);
            this.lbl_tenDA.TabIndex = 12;
            this.lbl_tenDA.Text = "Tên dự án";
            // 
            // ptbDelete
            // 
            this.ptbDelete.Image = global::QuanLyCongTy.Properties.Resources.trash;
            this.ptbDelete.Location = new System.Drawing.Point(430, 5);
            this.ptbDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbDelete.Name = "ptbDelete";
            this.ptbDelete.Size = new System.Drawing.Size(47, 35);
            this.ptbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbDelete.TabIndex = 19;
            this.ptbDelete.TabStop = false;
            this.ptbDelete.Click += new System.EventHandler(this.ptbDelete_Click);
            // 
            // ptbSetting
            // 
            this.ptbSetting.Image = global::QuanLyCongTy.Properties.Resources.edit;
            this.ptbSetting.Location = new System.Drawing.Point(377, 5);
            this.ptbSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbSetting.Name = "ptbSetting";
            this.ptbSetting.Size = new System.Drawing.Size(47, 35);
            this.ptbSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbSetting.TabIndex = 18;
            this.ptbSetting.TabStop = false;
            this.ptbSetting.Click += new System.EventHandler(this.ptbSetting_Click);
            // 
            // ucTienDo
            // 
            this.ucTienDo.Location = new System.Drawing.Point(23, 62);
            this.ucTienDo.Name = "ucTienDo";
            this.ucTienDo.Size = new System.Drawing.Size(410, 55);
            this.ucTienDo.TabIndex = 20;
            // 
            // UCTienDoDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ptbDelete);
            this.Controls.Add(this.ptbSetting);
            this.Controls.Add(this.lbl_NgayCL);
            this.Controls.Add(this.lbl_TenPhong);
            this.Controls.Add(this.lbl_tenDA);
            this.Controls.Add(this.ucTienDo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCTienDoDA";
            this.Size = new System.Drawing.Size(490, 160);
            this.Load += new System.EventHandler(this.UCTienDoDA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSetting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_NgayCL;
        private System.Windows.Forms.Label lbl_TenPhong;
        private System.Windows.Forms.Label lbl_tenDA;
        private System.Windows.Forms.PictureBox ptbSetting;
        private System.Windows.Forms.PictureBox ptbDelete;
        private UCTienDo ucTienDo;
    }
}
