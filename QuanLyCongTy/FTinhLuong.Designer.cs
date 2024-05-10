namespace QuanLyCongTy
{
    partial class FTinhLuong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpNgayTinhLuong = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbTenPB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_TenPB = new System.Windows.Forms.Label();
            this.gvTinhLuong = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnXuat = new Guna.UI2.WinForms.Guna2Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gvTinhLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNgayTinhLuong
            // 
            this.dtpNgayTinhLuong.Animated = true;
            this.dtpNgayTinhLuong.BackColor = System.Drawing.Color.Transparent;
            this.dtpNgayTinhLuong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(101)))), ((int)(((byte)(189)))));
            this.dtpNgayTinhLuong.BorderRadius = 10;
            this.dtpNgayTinhLuong.BorderThickness = 3;
            this.dtpNgayTinhLuong.Checked = true;
            this.dtpNgayTinhLuong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpNgayTinhLuong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(101)))), ((int)(((byte)(189)))));
            this.dtpNgayTinhLuong.Font = new System.Drawing.Font("Calibri", 12F);
            this.dtpNgayTinhLuong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtpNgayTinhLuong.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayTinhLuong.Location = new System.Drawing.Point(36, 11);
            this.dtpNgayTinhLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayTinhLuong.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayTinhLuong.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayTinhLuong.Name = "dtpNgayTinhLuong";
            this.dtpNgayTinhLuong.Size = new System.Drawing.Size(289, 42);
            this.dtpNgayTinhLuong.TabIndex = 132;
            this.dtpNgayTinhLuong.Value = new System.DateTime(2024, 5, 11, 0, 25, 0, 0);
            this.dtpNgayTinhLuong.ValueChanged += new System.EventHandler(this.dtpNgayTinhLuong_ValueChanged_1);
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
            this.cmbTenPB.Location = new System.Drawing.Point(677, 17);
            this.cmbTenPB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTenPB.Name = "cmbTenPB";
            this.cmbTenPB.Size = new System.Drawing.Size(311, 36);
            this.cmbTenPB.TabIndex = 131;
            this.cmbTenPB.SelectedIndexChanged += new System.EventHandler(this.cmbTenPB_SelectedIndexChanged_1);
            // 
            // lbl_TenPB
            // 
            this.lbl_TenPB.AutoSize = true;
            this.lbl_TenPB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenPB.Location = new System.Drawing.Point(527, 29);
            this.lbl_TenPB.Name = "lbl_TenPB";
            this.lbl_TenPB.Size = new System.Drawing.Size(144, 24);
            this.lbl_TenPB.TabIndex = 130;
            this.lbl_TenPB.Text = "Tên phòng ban: ";
            // 
            // gvTinhLuong
            // 
            this.gvTinhLuong.AllowUserToAddRows = false;
            this.gvTinhLuong.AllowUserToDeleteRows = false;
            this.gvTinhLuong.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvTinhLuong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(70)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(70)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvTinhLuong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvTinhLuong.ColumnHeadersHeight = 50;
            this.gvTinhLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvTinhLuong.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvTinhLuong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvTinhLuong.Location = new System.Drawing.Point(36, 79);
            this.gvTinhLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gvTinhLuong.Name = "gvTinhLuong";
            this.gvTinhLuong.ReadOnly = true;
            this.gvTinhLuong.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvTinhLuong.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gvTinhLuong.RowHeadersVisible = false;
            this.gvTinhLuong.RowHeadersWidth = 62;
            this.gvTinhLuong.RowTemplate.Height = 28;
            this.gvTinhLuong.Size = new System.Drawing.Size(963, 561);
            this.gvTinhLuong.TabIndex = 134;
            this.gvTinhLuong.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gvTinhLuong.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTinhLuong.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gvTinhLuong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvTinhLuong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvTinhLuong.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gvTinhLuong.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvTinhLuong.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gvTinhLuong.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvTinhLuong.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTinhLuong.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gvTinhLuong.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gvTinhLuong.ThemeStyle.HeaderStyle.Height = 50;
            this.gvTinhLuong.ThemeStyle.ReadOnly = true;
            this.gvTinhLuong.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gvTinhLuong.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvTinhLuong.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTinhLuong.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvTinhLuong.ThemeStyle.RowsStyle.Height = 28;
            this.gvTinhLuong.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvTinhLuong.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnXuat
            // 
            this.btnXuat.Animated = true;
            this.btnXuat.BorderRadius = 10;
            this.btnXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXuat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnXuat.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnXuat.ForeColor = System.Drawing.Color.White;
            this.btnXuat.Location = new System.Drawing.Point(857, 646);
            this.btnXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(142, 43);
            this.btnXuat.TabIndex = 135;
            this.btnXuat.Text = "Xuất Excel";
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // FTinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.gvTinhLuong);
            this.Controls.Add(this.lbl_TenPB);
            this.Controls.Add(this.cmbTenPB);
            this.Controls.Add(this.dtpNgayTinhLuong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FTinhLuong";
            this.Text = "FTinhLuong";
            ((System.ComponentModel.ISupportInitialize)(this.gvTinhLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayTinhLuong;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTenPB;
        private System.Windows.Forms.Label lbl_TenPB;
        private Guna.UI2.WinForms.Guna2DataGridView gvTinhLuong;
        private Guna.UI2.WinForms.Guna2Button btnXuat;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
    }
}