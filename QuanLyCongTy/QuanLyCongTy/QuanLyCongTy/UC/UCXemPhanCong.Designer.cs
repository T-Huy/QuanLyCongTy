namespace QuanLyCongTy
{
    partial class UCXemPhanCong
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
            this.lblTenCV = new System.Windows.Forms.Label();
            this.lblGTBatDauLam = new System.Windows.Forms.Label();
            this.lblTGConLai = new System.Windows.Forms.Label();
            this.pbThem = new System.Windows.Forms.PictureBox();
            this.pbXoa = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ucTienDo1 = new QuanLyCongTy.UCTienDo();
            ((System.ComponentModel.ISupportInitialize)(this.pbThem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenCV
            // 
            this.lblTenCV.AutoSize = true;
            this.lblTenCV.BackColor = System.Drawing.Color.White;
            this.lblTenCV.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenCV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTenCV.Location = new System.Drawing.Point(12, 15);
            this.lblTenCV.Name = "lblTenCV";
            this.lblTenCV.Size = new System.Drawing.Size(124, 35);
            this.lblTenCV.TabIndex = 0;
            this.lblTenCV.Text = "Công việc";
            // 
            // lblGTBatDauLam
            // 
            this.lblGTBatDauLam.AutoSize = true;
            this.lblGTBatDauLam.BackColor = System.Drawing.Color.White;
            this.lblGTBatDauLam.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGTBatDauLam.Location = new System.Drawing.Point(30, 50);
            this.lblGTBatDauLam.Name = "lblGTBatDauLam";
            this.lblGTBatDauLam.Size = new System.Drawing.Size(136, 21);
            this.lblGTBatDauLam.TabIndex = 1;
            this.lblGTBatDauLam.Text = "Thời Gian Bắt Đầu";
            // 
            // lblTGConLai
            // 
            this.lblTGConLai.AutoSize = true;
            this.lblTGConLai.BackColor = System.Drawing.Color.White;
            this.lblTGConLai.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTGConLai.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTGConLai.Location = new System.Drawing.Point(30, 144);
            this.lblTGConLai.Name = "lblTGConLai";
            this.lblTGConLai.Size = new System.Drawing.Size(117, 24);
            this.lblTGConLai.TabIndex = 3;
            this.lblTGConLai.Text = "Ngày Còn Lại";
            // 
            // pbThem
            // 
            this.pbThem.BackColor = System.Drawing.Color.White;
            this.pbThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbThem.Image = global::QuanLyCongTy.Properties.Resources.Add;
            this.pbThem.Location = new System.Drawing.Point(422, 20);
            this.pbThem.Name = "pbThem";
            this.pbThem.Size = new System.Drawing.Size(40, 40);
            this.pbThem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbThem.TabIndex = 9;
            this.pbThem.TabStop = false;
            this.pbThem.Click += new System.EventHandler(this.pbThem_Click);
            this.pbThem.MouseEnter += new System.EventHandler(this.pbThem_MouseEnter);
            this.pbThem.MouseLeave += new System.EventHandler(this.pbThem_MouseLeave);
            // 
            // pbXoa
            // 
            this.pbXoa.BackColor = System.Drawing.Color.White;
            this.pbXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbXoa.Image = global::QuanLyCongTy.Properties.Resources.delete;
            this.pbXoa.Location = new System.Drawing.Point(422, 124);
            this.pbXoa.Name = "pbXoa";
            this.pbXoa.Size = new System.Drawing.Size(40, 40);
            this.pbXoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbXoa.TabIndex = 10;
            this.pbXoa.TabStop = false;
            this.pbXoa.MouseEnter += new System.EventHandler(this.pbXoa_MouseEnter);
            this.pbXoa.MouseLeave += new System.EventHandler(this.pbXoa_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::QuanLyCongTy.Properties.Resources.BackUCXemPC;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.UCXemPhanCong_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(18, 74);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 36);
            this.textBox1.TabIndex = 12;
            // 
            // ucTienDo1
            // 
            this.ucTienDo1.BackColor = System.Drawing.Color.White;
            this.ucTienDo1.Location = new System.Drawing.Point(3, 86);
            this.ucTienDo1.Name = "ucTienDo1";
            this.ucTienDo1.Size = new System.Drawing.Size(413, 55);
            this.ucTienDo1.TabIndex = 6;
            // 
            // UCXemPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pbXoa);
            this.Controls.Add(this.pbThem);
            this.Controls.Add(this.lblTGConLai);
            this.Controls.Add(this.lblGTBatDauLam);
            this.Controls.Add(this.lblTenCV);
            this.Controls.Add(this.ucTienDo1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "UCXemPhanCong";
            this.Size = new System.Drawing.Size(480, 180);
            this.Load += new System.EventHandler(this.UCXemPhanCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbThem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenCV;
        private System.Windows.Forms.Label lblGTBatDauLam;
        private System.Windows.Forms.Label lblTGConLai;
        private UCTienDo ucTienDo1;
        private System.Windows.Forms.PictureBox pbThem;
        private System.Windows.Forms.PictureBox pbXoa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
