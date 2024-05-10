namespace QuanLyCongTy
{
    partial class UCXemDADaHT
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
            this.flpNgoiSao = new System.Windows.Forms.FlowLayoutPanel();
            this.ucTienDo1 = new QuanLyCongTy.UCTienDo();
            this.SuspendLayout();
            // 
            // lbl_TenPhong
            // 
            this.lbl_TenPhong.AutoSize = true;
            this.lbl_TenPhong.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenPhong.Location = new System.Drawing.Point(38, 51);
            this.lbl_TenPhong.Name = "lbl_TenPhong";
            this.lbl_TenPhong.Size = new System.Drawing.Size(97, 24);
            this.lbl_TenPhong.TabIndex = 24;
            this.lbl_TenPhong.Text = "Tên phòng";
            // 
            // lbl_tenDA
            // 
            this.lbl_tenDA.AutoSize = true;
            this.lbl_tenDA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenDA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_tenDA.Location = new System.Drawing.Point(38, 20);
            this.lbl_tenDA.Name = "lbl_tenDA";
            this.lbl_tenDA.Size = new System.Drawing.Size(94, 24);
            this.lbl_tenDA.TabIndex = 23;
            this.lbl_tenDA.Text = "Tên dự án";
            // 
            // flpNgoiSao
            // 
            this.flpNgoiSao.Location = new System.Drawing.Point(42, 106);
            this.flpNgoiSao.Margin = new System.Windows.Forms.Padding(0);
            this.flpNgoiSao.Name = "flpNgoiSao";
            this.flpNgoiSao.Size = new System.Drawing.Size(366, 32);
            this.flpNgoiSao.TabIndex = 25;
            // 
            // ucTienDo1
            // 
            this.ucTienDo1.Location = new System.Drawing.Point(42, 51);
            this.ucTienDo1.Name = "ucTienDo1";
            this.ucTienDo1.Size = new System.Drawing.Size(410, 55);
            this.ucTienDo1.TabIndex = 26;
            // 
            // UCXemDADaHT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_TenPhong);
            this.Controls.Add(this.lbl_tenDA);
            this.Controls.Add(this.flpNgoiSao);
            this.Controls.Add(this.ucTienDo1);
            this.Name = "UCXemDADaHT";
            this.Size = new System.Drawing.Size(490, 158);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TenPhong;
        private System.Windows.Forms.Label lbl_tenDA;
        private System.Windows.Forms.FlowLayoutPanel flpNgoiSao;
        private UCTienDo ucTienDo1;
    }
}
