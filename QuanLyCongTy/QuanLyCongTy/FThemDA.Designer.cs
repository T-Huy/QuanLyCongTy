namespace QuanLyCongTy
{
    partial class FThemDA
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbLoaiPB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDA = new System.Windows.Forms.Label();
            this.gvPhongBanRanh = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.dtpDeadline = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpNgayBD = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbTenPB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_TenDA = new System.Windows.Forms.Label();
            this.lbl_MoTa = new System.Windows.Forms.Label();
            this.txtMoTa = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Shapes2 = new Guna.UI2.WinForms.Guna2Shapes();
            this.txtDiaDiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.txtTenDA = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_DeadLine = new System.Windows.Forms.Label();
            this.lbl_NgayBD = new System.Windows.Forms.Label();
            this.lbl_DiaDiem = new System.Windows.Forms.Label();
            this.lbl_TenPB = new System.Windows.Forms.Label();
            this.lblMaDA = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhongBanRanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.FillWeight = 81.81828F;
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 8;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            // 
            // TenPB
            // 
            this.TenPB.DataPropertyName = "TenPB";
            this.TenPB.FillWeight = 136.3637F;
            this.TenPB.HeaderText = "Tên phòng ban";
            this.TenPB.MinimumWidth = 8;
            this.TenPB.Name = "TenPB";
            this.TenPB.ReadOnly = true;
            // 
            // cmbLoaiPB
            // 
            this.cmbLoaiPB.BackColor = System.Drawing.Color.Transparent;
            this.cmbLoaiPB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(101)))), ((int)(((byte)(189)))));
            this.cmbLoaiPB.BorderRadius = 10;
            this.cmbLoaiPB.BorderThickness = 2;
            this.cmbLoaiPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbLoaiPB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLoaiPB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiPB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLoaiPB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLoaiPB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbLoaiPB.ForeColor = System.Drawing.Color.Black;
            this.cmbLoaiPB.ItemHeight = 30;
            this.cmbLoaiPB.Location = new System.Drawing.Point(245, 306);
            this.cmbLoaiPB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLoaiPB.Name = "cmbLoaiPB";
            this.cmbLoaiPB.Size = new System.Drawing.Size(335, 36);
            this.cmbLoaiPB.TabIndex = 133;
            this.cmbLoaiPB.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiPB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 132;
            this.label2.Text = "Loại phòng ban:";
            // 
            // Deadline
            // 
            this.Deadline.DataPropertyName = "DL";
            this.Deadline.FillWeight = 81.81828F;
            this.Deadline.HeaderText = "Thời hạn";
            this.Deadline.MinimumWidth = 8;
            this.Deadline.Name = "Deadline";
            this.Deadline.ReadOnly = true;
            // 
            // MaDA
            // 
            this.MaDA.AutoSize = true;
            this.MaDA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaDA.Location = new System.Drawing.Point(93, 60);
            this.MaDA.Name = "MaDA";
            this.MaDA.Size = new System.Drawing.Size(96, 24);
            this.MaDA.TabIndex = 129;
            this.MaDA.Text = "Mã dự án:";
            // 
            // gvPhongBanRanh
            // 
            this.gvPhongBanRanh.AllowUserToAddRows = false;
            this.gvPhongBanRanh.AllowUserToDeleteRows = false;
            this.gvPhongBanRanh.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvPhongBanRanh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(70)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(70)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvPhongBanRanh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvPhongBanRanh.ColumnHeadersHeight = 50;
            this.gvPhongBanRanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gvPhongBanRanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenPB,
            this.Deadline,
            this.TinhTrang});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvPhongBanRanh.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvPhongBanRanh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvPhongBanRanh.Location = new System.Drawing.Point(643, 60);
            this.gvPhongBanRanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gvPhongBanRanh.Name = "gvPhongBanRanh";
            this.gvPhongBanRanh.ReadOnly = true;
            this.gvPhongBanRanh.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvPhongBanRanh.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gvPhongBanRanh.RowHeadersVisible = false;
            this.gvPhongBanRanh.RowHeadersWidth = 62;
            this.gvPhongBanRanh.RowTemplate.Height = 28;
            this.gvPhongBanRanh.Size = new System.Drawing.Size(514, 446);
            this.gvPhongBanRanh.TabIndex = 128;
            this.gvPhongBanRanh.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gvPhongBanRanh.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPhongBanRanh.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gvPhongBanRanh.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvPhongBanRanh.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvPhongBanRanh.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gvPhongBanRanh.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvPhongBanRanh.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gvPhongBanRanh.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvPhongBanRanh.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPhongBanRanh.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gvPhongBanRanh.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gvPhongBanRanh.ThemeStyle.HeaderStyle.Height = 50;
            this.gvPhongBanRanh.ThemeStyle.ReadOnly = true;
            this.gvPhongBanRanh.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gvPhongBanRanh.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvPhongBanRanh.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPhongBanRanh.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvPhongBanRanh.ThemeStyle.RowsStyle.Height = 28;
            this.gvPhongBanRanh.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvPhongBanRanh.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(161)))));
            this.label1.Location = new System.Drawing.Point(42, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 29);
            this.label1.TabIndex = 126;
            this.label1.Text = "Tạo dự án";
            // 
            // btnHuy
            // 
            this.btnHuy.Animated = true;
            this.btnHuy.BorderRadius = 10;
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnHuy.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(455, 606);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(124, 43);
            this.btnHuy.TabIndex = 125;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.Animated = true;
            this.btnThem.BorderRadius = 10;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnThem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(325, 606);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 43);
            this.btnThem.TabIndex = 124;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.Animated = true;
            this.dtpDeadline.BackColor = System.Drawing.Color.Transparent;
            this.dtpDeadline.BorderRadius = 10;
            this.dtpDeadline.Checked = true;
            this.dtpDeadline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDeadline.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(101)))), ((int)(((byte)(189)))));
            this.dtpDeadline.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDeadline.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtpDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDeadline.IndicateFocus = true;
            this.dtpDeadline.Location = new System.Drawing.Point(245, 546);
            this.dtpDeadline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDeadline.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDeadline.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(334, 42);
            this.dtpDeadline.TabIndex = 123;
            this.dtpDeadline.UseTransparentBackground = true;
            this.dtpDeadline.Value = new System.DateTime(2023, 5, 11, 0, 25, 48, 267);
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.Animated = true;
            this.dtpNgayBD.BackColor = System.Drawing.Color.Transparent;
            this.dtpNgayBD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(101)))), ((int)(((byte)(189)))));
            this.dtpNgayBD.BorderRadius = 10;
            this.dtpNgayBD.BorderThickness = 3;
            this.dtpNgayBD.Checked = true;
            this.dtpNgayBD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpNgayBD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(101)))), ((int)(((byte)(189)))));
            this.dtpNgayBD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayBD.Location = new System.Drawing.Point(245, 485);
            this.dtpNgayBD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayBD.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayBD.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(334, 42);
            this.dtpNgayBD.TabIndex = 122;
            this.dtpNgayBD.Value = new System.DateTime(2023, 5, 11, 0, 25, 48, 267);
            // 
            // cmbTenPB
            // 
            this.cmbTenPB.BackColor = System.Drawing.Color.Transparent;
            this.cmbTenPB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(101)))), ((int)(((byte)(189)))));
            this.cmbTenPB.BorderRadius = 10;
            this.cmbTenPB.BorderThickness = 2;
            this.cmbTenPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTenPB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTenPB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenPB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTenPB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTenPB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTenPB.ForeColor = System.Drawing.Color.Black;
            this.cmbTenPB.ItemHeight = 30;
            this.cmbTenPB.Location = new System.Drawing.Point(245, 370);
            this.cmbTenPB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTenPB.Name = "cmbTenPB";
            this.cmbTenPB.Size = new System.Drawing.Size(335, 36);
            this.cmbTenPB.TabIndex = 121;
            // 
            // lbl_TenDA
            // 
            this.lbl_TenDA.AutoSize = true;
            this.lbl_TenDA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenDA.Location = new System.Drawing.Point(93, 110);
            this.lbl_TenDA.Name = "lbl_TenDA";
            this.lbl_TenDA.Size = new System.Drawing.Size(98, 24);
            this.lbl_TenDA.TabIndex = 109;
            this.lbl_TenDA.Text = "Tên dự án:";
            // 
            // lbl_MoTa
            // 
            this.lbl_MoTa.AutoSize = true;
            this.lbl_MoTa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MoTa.Location = new System.Drawing.Point(119, 161);
            this.lbl_MoTa.Name = "lbl_MoTa";
            this.lbl_MoTa.Size = new System.Drawing.Size(65, 24);
            this.lbl_MoTa.TabIndex = 110;
            this.lbl_MoTa.Text = "Mô tả:";
            // 
            // txtMoTa
            // 
            this.txtMoTa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(101)))), ((int)(((byte)(189)))));
            this.txtMoTa.BorderRadius = 15;
            this.txtMoTa.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtMoTa.BorderThickness = 2;
            this.txtMoTa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoTa.DefaultText = "";
            this.txtMoTa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMoTa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMoTa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMoTa.ForeColor = System.Drawing.Color.Black;
            this.txtMoTa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoTa.Location = new System.Drawing.Point(98, 173);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.PasswordChar = '\0';
            this.txtMoTa.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtMoTa.PlaceholderText = "";
            this.txtMoTa.SelectedText = "";
            this.txtMoTa.Size = new System.Drawing.Size(482, 110);
            this.txtMoTa.TabIndex = 120;
            // 
            // guna2Shapes2
            // 
            this.guna2Shapes2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Shapes2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2Shapes2.BorderThickness = 0;
            this.guna2Shapes2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(101)))), ((int)(((byte)(189)))));
            this.guna2Shapes2.LineEndCap = System.Drawing.Drawing2D.LineCap.NoAnchor;
            this.guna2Shapes2.LineStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.guna2Shapes2.LineThickness = 2;
            this.guna2Shapes2.Location = new System.Drawing.Point(237, 452);
            this.guna2Shapes2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Shapes2.Name = "guna2Shapes2";
            this.guna2Shapes2.PolygonSkip = 1;
            this.guna2Shapes2.Rotate = 0F;
            this.guna2Shapes2.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes2.Size = new System.Drawing.Size(340, 12);
            this.guna2Shapes2.TabIndex = 119;
            this.guna2Shapes2.Text = "guna2Shapes2";
            this.guna2Shapes2.UseTransparentBackground = true;
            this.guna2Shapes2.Zoom = 90;
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Animated = true;
            this.txtDiaDiem.BorderColor = System.Drawing.Color.White;
            this.txtDiaDiem.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtDiaDiem.BorderThickness = 0;
            this.txtDiaDiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaDiem.DefaultText = "";
            this.txtDiaDiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaDiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaDiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaDiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaDiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaDiem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDiaDiem.ForeColor = System.Drawing.Color.Black;
            this.txtDiaDiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaDiem.Location = new System.Drawing.Point(240, 422);
            this.txtDiaDiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.PasswordChar = '\0';
            this.txtDiaDiem.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtDiaDiem.PlaceholderText = "";
            this.txtDiaDiem.SelectedText = "";
            this.txtDiaDiem.Size = new System.Drawing.Size(340, 40);
            this.txtDiaDiem.TabIndex = 118;
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Shapes1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2Shapes1.BorderThickness = 0;
            this.guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(101)))), ((int)(((byte)(189)))));
            this.guna2Shapes1.LineEndCap = System.Drawing.Drawing2D.LineCap.NoAnchor;
            this.guna2Shapes1.LineStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.guna2Shapes1.LineThickness = 2;
            this.guna2Shapes1.Location = new System.Drawing.Point(188, 130);
            this.guna2Shapes1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes1.Size = new System.Drawing.Size(388, 11);
            this.guna2Shapes1.TabIndex = 117;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.UseTransparentBackground = true;
            this.guna2Shapes1.Zoom = 90;
            // 
            // txtTenDA
            // 
            this.txtTenDA.Animated = true;
            this.txtTenDA.BorderColor = System.Drawing.Color.White;
            this.txtTenDA.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtTenDA.BorderThickness = 0;
            this.txtTenDA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDA.DefaultText = "";
            this.txtTenDA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenDA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenDA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDA.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTenDA.ForeColor = System.Drawing.Color.Black;
            this.txtTenDA.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDA.Location = new System.Drawing.Point(191, 102);
            this.txtTenDA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenDA.Name = "txtTenDA";
            this.txtTenDA.PasswordChar = '\0';
            this.txtTenDA.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTenDA.PlaceholderText = "";
            this.txtTenDA.SelectedText = "";
            this.txtTenDA.Size = new System.Drawing.Size(388, 40);
            this.txtTenDA.TabIndex = 116;
            // 
            // lbl_DeadLine
            // 
            this.lbl_DeadLine.AutoSize = true;
            this.lbl_DeadLine.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_DeadLine.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DeadLine.Location = new System.Drawing.Point(93, 554);
            this.lbl_DeadLine.Name = "lbl_DeadLine";
            this.lbl_DeadLine.Size = new System.Drawing.Size(90, 24);
            this.lbl_DeadLine.TabIndex = 114;
            this.lbl_DeadLine.Text = "Thời hạn:";
            // 
            // lbl_NgayBD
            // 
            this.lbl_NgayBD.AutoSize = true;
            this.lbl_NgayBD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_NgayBD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayBD.Location = new System.Drawing.Point(91, 494);
            this.lbl_NgayBD.Name = "lbl_NgayBD";
            this.lbl_NgayBD.Size = new System.Drawing.Size(126, 24);
            this.lbl_NgayBD.TabIndex = 113;
            this.lbl_NgayBD.Text = "Ngày bắt đầu:";
            // 
            // lbl_DiaDiem
            // 
            this.lbl_DiaDiem.AutoSize = true;
            this.lbl_DiaDiem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaDiem.Location = new System.Drawing.Point(93, 434);
            this.lbl_DiaDiem.Name = "lbl_DiaDiem";
            this.lbl_DiaDiem.Size = new System.Drawing.Size(89, 24);
            this.lbl_DiaDiem.TabIndex = 112;
            this.lbl_DiaDiem.Text = "Địa điểm:";
            // 
            // lbl_TenPB
            // 
            this.lbl_TenPB.AutoSize = true;
            this.lbl_TenPB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenPB.Location = new System.Drawing.Point(91, 375);
            this.lbl_TenPB.Name = "lbl_TenPB";
            this.lbl_TenPB.Size = new System.Drawing.Size(144, 24);
            this.lbl_TenPB.TabIndex = 111;
            this.lbl_TenPB.Text = "Tên phòng ban: ";
            // 
            // lblMaDA
            // 
            this.lblMaDA.AutoSize = true;
            this.lblMaDA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMaDA.Location = new System.Drawing.Point(212, 60);
            this.lblMaDA.Name = "lblMaDA";
            this.lblMaDA.Size = new System.Drawing.Size(61, 24);
            this.lblMaDA.TabIndex = 134;
            this.lblMaDA.Text = "label3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyCongTy.Properties.Resources.add_button__1_;
            this.pictureBox1.Location = new System.Drawing.Point(156, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 21);
            this.pictureBox1.TabIndex = 127;
            this.pictureBox1.TabStop = false;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.CustomIconSize = 20F;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(101)))), ((int)(((byte)(189)))));
            this.guna2ControlBox1.Location = new System.Drawing.Point(1158, -1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(62, 32);
            this.guna2ControlBox1.TabIndex = 135;
            // 
            // FThemDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1220, 690);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.lblMaDA);
            this.Controls.Add(this.cmbLoaiPB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaDA);
            this.Controls.Add(this.gvPhongBanRanh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtpDeadline);
            this.Controls.Add(this.dtpNgayBD);
            this.Controls.Add(this.cmbTenPB);
            this.Controls.Add(this.lbl_TenDA);
            this.Controls.Add(this.lbl_MoTa);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.guna2Shapes2);
            this.Controls.Add(this.txtDiaDiem);
            this.Controls.Add(this.guna2Shapes1);
            this.Controls.Add(this.txtTenDA);
            this.Controls.Add(this.lbl_DeadLine);
            this.Controls.Add(this.lbl_NgayBD);
            this.Controls.Add(this.lbl_DiaDiem);
            this.Controls.Add(this.lbl_TenPB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FThemDA";
            this.Text = "FThemDA";
            this.Load += new System.EventHandler(this.FThemDA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvPhongBanRanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPB;
        private Guna.UI2.WinForms.Guna2ComboBox cmbLoaiPB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deadline;
        private System.Windows.Forms.Label MaDA;
        private Guna.UI2.WinForms.Guna2DataGridView gvPhongBanRanh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDeadline;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayBD;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTenPB;
        private System.Windows.Forms.Label lbl_TenDA;
        private System.Windows.Forms.Label lbl_MoTa;
        private Guna.UI2.WinForms.Guna2TextBox txtMoTa;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes2;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaDiem;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Guna.UI2.WinForms.Guna2TextBox txtTenDA;
        private System.Windows.Forms.Label lbl_DeadLine;
        private System.Windows.Forms.Label lbl_NgayBD;
        private System.Windows.Forms.Label lbl_DiaDiem;
        private System.Windows.Forms.Label lbl_TenPB;
        private System.Windows.Forms.Label lblMaDA;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}