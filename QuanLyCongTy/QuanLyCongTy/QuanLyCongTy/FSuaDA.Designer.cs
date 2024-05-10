namespace QuanLyCongTy
{
    partial class FSuaDA
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
            this.lbl_MaDA = new System.Windows.Forms.Label();
            this.lbl_TenDA = new System.Windows.Forms.Label();
            this.txt_MaDA = new System.Windows.Forms.TextBox();
            this.lbl_MoTa = new System.Windows.Forms.Label();
            this.rtxt_MoTa = new System.Windows.Forms.RichTextBox();
            this.txt_TenDA = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.dtp_DeadLine = new System.Windows.Forms.DateTimePicker();
            this.dtp_NgayBD = new System.Windows.Forms.DateTimePicker();
            this.cmb_TenPB = new System.Windows.Forms.ComboBox();
            this.lbl_DeadLine = new System.Windows.Forms.Label();
            this.lbl_NgayBD = new System.Windows.Forms.Label();
            this.lbl_DiaDiem = new System.Windows.Forms.Label();
            this.lbl_TenPB = new System.Windows.Forms.Label();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_MaDA
            // 
            this.lbl_MaDA.AutoSize = true;
            this.lbl_MaDA.Location = new System.Drawing.Point(39, 35);
            this.lbl_MaDA.Name = "lbl_MaDA";
            this.lbl_MaDA.Size = new System.Drawing.Size(79, 20);
            this.lbl_MaDA.TabIndex = 0;
            this.lbl_MaDA.Text = "Mã dự án:";
            // 
            // lbl_TenDA
            // 
            this.lbl_TenDA.AutoSize = true;
            this.lbl_TenDA.Location = new System.Drawing.Point(39, 89);
            this.lbl_TenDA.Name = "lbl_TenDA";
            this.lbl_TenDA.Size = new System.Drawing.Size(84, 20);
            this.lbl_TenDA.TabIndex = 1;
            this.lbl_TenDA.Text = "Tên dự án:";
            // 
            // txt_MaDA
            // 
            this.txt_MaDA.Location = new System.Drawing.Point(184, 29);
            this.txt_MaDA.Name = "txt_MaDA";
            this.txt_MaDA.Size = new System.Drawing.Size(296, 26);
            this.txt_MaDA.TabIndex = 7;
            // 
            // lbl_MoTa
            // 
            this.lbl_MoTa.AutoSize = true;
            this.lbl_MoTa.Location = new System.Drawing.Point(40, 144);
            this.lbl_MoTa.Name = "lbl_MoTa";
            this.lbl_MoTa.Size = new System.Drawing.Size(53, 20);
            this.lbl_MoTa.TabIndex = 13;
            this.lbl_MoTa.Text = "Mô tả:";
            // 
            // rtxt_MoTa
            // 
            this.rtxt_MoTa.Location = new System.Drawing.Point(43, 167);
            this.rtxt_MoTa.Name = "rtxt_MoTa";
            this.rtxt_MoTa.Size = new System.Drawing.Size(437, 128);
            this.rtxt_MoTa.TabIndex = 14;
            this.rtxt_MoTa.Text = "";
            // 
            // txt_TenDA
            // 
            this.txt_TenDA.Location = new System.Drawing.Point(184, 83);
            this.txt_TenDA.Name = "txt_TenDA";
            this.txt_TenDA.Size = new System.Drawing.Size(296, 26);
            this.txt_TenDA.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(519, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(705, 595);
            this.dataGridView1.TabIndex = 16;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(245, 582);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(114, 42);
            this.btn_Sua.TabIndex = 17;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(367, 582);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(114, 42);
            this.btn_Huy.TabIndex = 18;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // dtp_DeadLine
            // 
            this.dtp_DeadLine.Location = new System.Drawing.Point(185, 489);
            this.dtp_DeadLine.Name = "dtp_DeadLine";
            this.dtp_DeadLine.Size = new System.Drawing.Size(296, 26);
            this.dtp_DeadLine.TabIndex = 28;
            // 
            // dtp_NgayBD
            // 
            this.dtp_NgayBD.Location = new System.Drawing.Point(185, 436);
            this.dtp_NgayBD.Name = "dtp_NgayBD";
            this.dtp_NgayBD.Size = new System.Drawing.Size(296, 26);
            this.dtp_NgayBD.TabIndex = 27;
            // 
            // cmb_TenPB
            // 
            this.cmb_TenPB.FormattingEnabled = true;
            this.cmb_TenPB.Location = new System.Drawing.Point(185, 329);
            this.cmb_TenPB.Name = "cmb_TenPB";
            this.cmb_TenPB.Size = new System.Drawing.Size(296, 28);
            this.cmb_TenPB.TabIndex = 25;
            this.cmb_TenPB.SelectedIndexChanged += new System.EventHandler(this.cmb_TenPB_SelectedIndexChanged);
            // 
            // lbl_DeadLine
            // 
            this.lbl_DeadLine.AutoSize = true;
            this.lbl_DeadLine.Location = new System.Drawing.Point(40, 495);
            this.lbl_DeadLine.Name = "lbl_DeadLine";
            this.lbl_DeadLine.Size = new System.Drawing.Size(74, 20);
            this.lbl_DeadLine.TabIndex = 23;
            this.lbl_DeadLine.Text = "Thời hạn:";
            // 
            // lbl_NgayBD
            // 
            this.lbl_NgayBD.AutoSize = true;
            this.lbl_NgayBD.Location = new System.Drawing.Point(39, 441);
            this.lbl_NgayBD.Name = "lbl_NgayBD";
            this.lbl_NgayBD.Size = new System.Drawing.Size(107, 20);
            this.lbl_NgayBD.TabIndex = 22;
            this.lbl_NgayBD.Text = "Ngày bắt đầu:";
            // 
            // lbl_DiaDiem
            // 
            this.lbl_DiaDiem.AutoSize = true;
            this.lbl_DiaDiem.Location = new System.Drawing.Point(39, 390);
            this.lbl_DiaDiem.Name = "lbl_DiaDiem";
            this.lbl_DiaDiem.Size = new System.Drawing.Size(75, 20);
            this.lbl_DiaDiem.TabIndex = 21;
            this.lbl_DiaDiem.Text = "Địa điểm:";
            // 
            // lbl_TenPB
            // 
            this.lbl_TenPB.AutoSize = true;
            this.lbl_TenPB.Location = new System.Drawing.Point(40, 337);
            this.lbl_TenPB.Name = "lbl_TenPB";
            this.lbl_TenPB.Size = new System.Drawing.Size(124, 20);
            this.lbl_TenPB.TabIndex = 20;
            this.lbl_TenPB.Text = "Tên phòng ban: ";
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Location = new System.Drawing.Point(185, 384);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(295, 26);
            this.txtDiaDiem.TabIndex = 29;
            // 
            // FSuaDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 659);
            this.Controls.Add(this.txtDiaDiem);
            this.Controls.Add(this.dtp_DeadLine);
            this.Controls.Add(this.dtp_NgayBD);
            this.Controls.Add(this.cmb_TenPB);
            this.Controls.Add(this.lbl_DeadLine);
            this.Controls.Add(this.lbl_NgayBD);
            this.Controls.Add(this.lbl_DiaDiem);
            this.Controls.Add(this.lbl_TenPB);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_TenDA);
            this.Controls.Add(this.rtxt_MoTa);
            this.Controls.Add(this.lbl_MoTa);
            this.Controls.Add(this.txt_MaDA);
            this.Controls.Add(this.lbl_TenDA);
            this.Controls.Add(this.lbl_MaDA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FSuaDA";
            this.Text = "FSuaDA";
            this.Load += new System.EventHandler(this.FSuaDA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MaDA;
        private System.Windows.Forms.Label lbl_TenDA;
        private System.Windows.Forms.TextBox txt_MaDA;
        private System.Windows.Forms.Label lbl_MoTa;
        private System.Windows.Forms.RichTextBox rtxt_MoTa;
        private System.Windows.Forms.TextBox txt_TenDA;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.DateTimePicker dtp_DeadLine;
        private System.Windows.Forms.DateTimePicker dtp_NgayBD;
        private System.Windows.Forms.ComboBox cmb_TenPB;
        private System.Windows.Forms.Label lbl_DeadLine;
        private System.Windows.Forms.Label lbl_NgayBD;
        private System.Windows.Forms.Label lbl_DiaDiem;
        private System.Windows.Forms.Label lbl_TenPB;
        private System.Windows.Forms.TextBox txtDiaDiem;
    }
}