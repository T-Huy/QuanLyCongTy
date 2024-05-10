namespace QuanLyCongTy
{
    partial class FKPI
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
            this.gv_DuAn = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_TienDo = new System.Windows.Forms.ComboBox();
            this.cbo_DuAn = new System.Windows.Forms.ComboBox();
            this.gv_PhanCong = new System.Windows.Forms.DataGridView();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DuAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_PhanCong)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_DuAn
            // 
            this.gv_DuAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_DuAn.Location = new System.Drawing.Point(0, -2);
            this.gv_DuAn.Name = "gv_DuAn";
            this.gv_DuAn.Size = new System.Drawing.Size(368, 211);
            this.gv_DuAn.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Các Dư Án Tham Gia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tiến Độ: ";
            // 
            // cbo_TienDo
            // 
            this.cbo_TienDo.FormattingEnabled = true;
            this.cbo_TienDo.Items.AddRange(new object[] {
            "5%",
            "10%",
            "15%",
            "20%",
            "25%",
            "30%",
            "35%",
            "40%",
            "45%",
            "50%",
            "55%",
            "60%",
            "65%",
            "70%",
            "75%",
            "80%",
            "85%",
            "90%",
            "95%",
            "100%"});
            this.cbo_TienDo.Location = new System.Drawing.Point(580, 196);
            this.cbo_TienDo.Name = "cbo_TienDo";
            this.cbo_TienDo.Size = new System.Drawing.Size(121, 21);
            this.cbo_TienDo.TabIndex = 12;
            // 
            // cbo_DuAn
            // 
            this.cbo_DuAn.FormattingEnabled = true;
            this.cbo_DuAn.Location = new System.Drawing.Point(580, 142);
            this.cbo_DuAn.Name = "cbo_DuAn";
            this.cbo_DuAn.Size = new System.Drawing.Size(121, 21);
            this.cbo_DuAn.TabIndex = 17;
            // 
            // gv_PhanCong
            // 
            this.gv_PhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_PhanCong.Location = new System.Drawing.Point(0, 240);
            this.gv_PhanCong.Name = "gv_PhanCong";
            this.gv_PhanCong.Size = new System.Drawing.Size(368, 211);
            this.gv_PhanCong.TabIndex = 22;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(443, 286);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 23;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(548, 286);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 24;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.Location = new System.Drawing.Point(654, 286);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(75, 23);
            this.btn_XacNhan.TabIndex = 25;
            this.btn_XacNhan.Text = "Xác Nhận";
            this.btn_XacNhan.UseVisualStyleBackColor = true;
            // 
            // FKPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_XacNhan);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.gv_PhanCong);
            this.Controls.Add(this.cbo_DuAn);
            this.Controls.Add(this.cbo_TienDo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gv_DuAn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FKPI";
            this.Text = "FKPI";
            this.Load += new System.EventHandler(this.FKPI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_DuAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_PhanCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_DuAn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_TienDo;
        private System.Windows.Forms.ComboBox cbo_DuAn;
        private System.Windows.Forms.DataGridView gv_PhanCong;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_XacNhan;
    }
}