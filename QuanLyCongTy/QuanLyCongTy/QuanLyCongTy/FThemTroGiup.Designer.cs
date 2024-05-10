namespace QuanLyCongTy
{
    partial class FThemTroGiup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gv_CongViec = new System.Windows.Forms.DataGridView();
            this.HoTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemTroGiup = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CongViec)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_CongViec
            // 
            this.gv_CongViec.BackgroundColor = System.Drawing.Color.White;
            this.gv_CongViec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_CongViec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_CongViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_CongViec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HoTenNV,
            this.TinhTrang,
            this.DL});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_CongViec.DefaultCellStyle = dataGridViewCellStyle2;
            this.gv_CongViec.Location = new System.Drawing.Point(19, 19);
            this.gv_CongViec.Margin = new System.Windows.Forms.Padding(10, 10, 4, 4);
            this.gv_CongViec.Name = "gv_CongViec";
            this.gv_CongViec.ReadOnly = true;
            this.gv_CongViec.RowHeadersVisible = false;
            this.gv_CongViec.RowHeadersWidth = 62;
            this.gv_CongViec.RowTemplate.Height = 28;
            this.gv_CongViec.Size = new System.Drawing.Size(536, 444);
            this.gv_CongViec.TabIndex = 41;
            this.gv_CongViec.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_CongViec_CellContentClick);
            // 
            // HoTenNV
            // 
            this.HoTenNV.DataPropertyName = "HoTenNV";
            this.HoTenNV.HeaderText = "Tên Nhân Viên";
            this.HoTenNV.MinimumWidth = 6;
            this.HoTenNV.Name = "HoTenNV";
            this.HoTenNV.ReadOnly = true;
            this.HoTenNV.Width = 150;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            this.TinhTrang.Width = 125;
            // 
            // DL
            // 
            this.DL.DataPropertyName = "DL";
            this.DL.HeaderText = "Hạn gần nhất";
            this.DL.MinimumWidth = 6;
            this.DL.Name = "DL";
            this.DL.ReadOnly = true;
            this.DL.Width = 125;
            // 
            // btnThemTroGiup
            // 
            this.btnThemTroGiup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThemTroGiup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTroGiup.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTroGiup.Location = new System.Drawing.Point(815, 420);
            this.btnThemTroGiup.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemTroGiup.Name = "btnThemTroGiup";
            this.btnThemTroGiup.Size = new System.Drawing.Size(150, 40);
            this.btnThemTroGiup.TabIndex = 40;
            this.btnThemTroGiup.Text = "Thêm";
            this.btnThemTroGiup.UseVisualStyleBackColor = true;
            this.btnThemTroGiup.Click += new System.EventHandler(this.btnThemTroGiup_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(627, 420);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(150, 40);
            this.btnHuy.TabIndex = 43;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(603, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(320, 340);
            this.listBox1.TabIndex = 44;
            // 
            // FThemTroGiup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 476);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.gv_CongViec);
            this.Controls.Add(this.btnThemTroGiup);
            this.Controls.Add(this.btnHuy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FThemTroGiup";
            this.Text = "ThemTroGiup";
            this.Load += new System.EventHandler(this.FThemTroGiup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_CongViec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_CongViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DL;
        private System.Windows.Forms.Button btnThemTroGiup;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.ListBox listBox1;
    }
}