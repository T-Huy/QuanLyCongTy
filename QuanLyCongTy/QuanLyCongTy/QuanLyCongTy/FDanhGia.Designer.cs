namespace QuanLyCongTy
{
    partial class FDanhGia
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.rtxt_NhanXet = new System.Windows.Forms.RichTextBox();
            this.gv_PhanCong = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CongViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeadLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanXet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChamCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.txt_ChamCong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaDA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gv_PhanCong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhận xét:";
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Location = new System.Drawing.Point(48, 47);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(144, 22);
            this.txt_MaNV.TabIndex = 3;
            // 
            // rtxt_NhanXet
            // 
            this.rtxt_NhanXet.Location = new System.Drawing.Point(48, 217);
            this.rtxt_NhanXet.Name = "rtxt_NhanXet";
            this.rtxt_NhanXet.Size = new System.Drawing.Size(264, 106);
            this.rtxt_NhanXet.TabIndex = 6;
            this.rtxt_NhanXet.Text = "";
            // 
            // gv_PhanCong
            // 
            this.gv_PhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_PhanCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.MaDA,
            this.CongViec,
            this.DeadLine,
            this.NhanXet,
            this.ChamCong});
            this.gv_PhanCong.Location = new System.Drawing.Point(348, 24);
            this.gv_PhanCong.Name = "gv_PhanCong";
            this.gv_PhanCong.RowHeadersVisible = false;
            this.gv_PhanCong.RowHeadersWidth = 62;
            this.gv_PhanCong.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_PhanCong.RowTemplate.Height = 28;
            this.gv_PhanCong.Size = new System.Drawing.Size(574, 543);
            this.gv_PhanCong.TabIndex = 7;
            this.gv_PhanCong.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gv_PhanCong_MouseClick);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.MinimumWidth = 8;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            this.MaNV.Width = 150;
            // 
            // MaDA
            // 
            this.MaDA.DataPropertyName = "MaDA";
            this.MaDA.HeaderText = "Mã dự án";
            this.MaDA.MinimumWidth = 8;
            this.MaDA.Name = "MaDA";
            this.MaDA.ReadOnly = true;
            this.MaDA.Width = 150;
            // 
            // CongViec
            // 
            this.CongViec.DataPropertyName = "CongViec";
            this.CongViec.HeaderText = "Công việc";
            this.CongViec.MinimumWidth = 8;
            this.CongViec.Name = "CongViec";
            this.CongViec.ReadOnly = true;
            this.CongViec.Width = 150;
            // 
            // DeadLine
            // 
            this.DeadLine.DataPropertyName = "DeadLine";
            this.DeadLine.HeaderText = "Thời hạn";
            this.DeadLine.MinimumWidth = 8;
            this.DeadLine.Name = "DeadLine";
            this.DeadLine.ReadOnly = true;
            this.DeadLine.Width = 150;
            // 
            // NhanXet
            // 
            this.NhanXet.DataPropertyName = "NhanXet";
            this.NhanXet.HeaderText = "Nhận xét";
            this.NhanXet.MinimumWidth = 8;
            this.NhanXet.Name = "NhanXet";
            this.NhanXet.ReadOnly = true;
            this.NhanXet.Width = 150;
            // 
            // ChamCong
            // 
            this.ChamCong.DataPropertyName = "ChamCong";
            this.ChamCong.HeaderText = "Chấm công";
            this.ChamCong.MinimumWidth = 8;
            this.ChamCong.Name = "ChamCong";
            this.ChamCong.ReadOnly = true;
            this.ChamCong.Width = 150;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(48, 472);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(190, 24);
            this.btn_Sua.TabIndex = 10;
            this.btn_Sua.Text = "Thêm đánh giá";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // txt_ChamCong
            // 
            this.txt_ChamCong.Location = new System.Drawing.Point(48, 399);
            this.txt_ChamCong.Name = "txt_ChamCong";
            this.txt_ChamCong.Size = new System.Drawing.Size(191, 22);
            this.txt_ChamCong.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Chấm công:";
            // 
            // txt_MaDA
            // 
            this.txt_MaDA.Location = new System.Drawing.Point(48, 126);
            this.txt_MaDA.Name = "txt_MaDA";
            this.txt_MaDA.Size = new System.Drawing.Size(144, 22);
            this.txt_MaDA.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mã dự án:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FDanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.txt_MaDA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_ChamCong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.gv_PhanCong);
            this.Controls.Add(this.rtxt_NhanXet);
            this.Controls.Add(this.txt_MaNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FDanhGia";
            this.Text = "DanhGia";
            this.Load += new System.EventHandler(this.DanhGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_PhanCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.RichTextBox rtxt_NhanXet;
        private System.Windows.Forms.DataGridView gv_PhanCong;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.TextBox txt_ChamCong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaDA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CongViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeadLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanXet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChamCong;
    }
}