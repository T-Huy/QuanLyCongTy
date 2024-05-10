namespace QuanLyCongTy
{
    partial class FQuanLy
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
            this.ucbtnDanhGiaDA = new QuanLyCongTy.ucMenuBtn();
            this.ucbtnTaoDA = new QuanLyCongTy.ucMenuBtn();
            this.ucbtnCheckinout = new QuanLyCongTy.ucMenuBtn();
            this.ucbtnXinNghi = new QuanLyCongTy.ucMenuBtn();
            this.ucTheme = new QuanLyCongTy.UC();
            this.SuspendLayout();
            // 
            // ucbtnDanhGiaDA
            // 
            this.ucbtnDanhGiaDA.Location = new System.Drawing.Point(0, 252);
            this.ucbtnDanhGiaDA.Name = "ucbtnDanhGiaDA";
            this.ucbtnDanhGiaDA.Size = new System.Drawing.Size(250, 70);
            this.ucbtnDanhGiaDA.TabIndex = 3;
            this.ucbtnDanhGiaDA.Text = "Đánh giá";
            // 
            // ucbtnTaoDA
            // 
            this.ucbtnTaoDA.Location = new System.Drawing.Point(0, 176);
            this.ucbtnTaoDA.Name = "ucbtnTaoDA";
            this.ucbtnTaoDA.Size = new System.Drawing.Size(250, 70);
            this.ucbtnTaoDA.TabIndex = 2;
            this.ucbtnTaoDA.Text = "Tạo Dự Án";
            // 
            // ucbtnCheckinout
            // 
            this.ucbtnCheckinout.Location = new System.Drawing.Point(0, 100);
            this.ucbtnCheckinout.Name = "ucbtnCheckinout";
            this.ucbtnCheckinout.Size = new System.Drawing.Size(250, 70);
            this.ucbtnCheckinout.TabIndex = 1;
            this.ucbtnCheckinout.Text = "Checkin/out";
            // 
            // ucTheme
            // 
            this.ucTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTheme.Location = new System.Drawing.Point(0, 0);
            this.ucTheme.Name = "ucTheme";
            this.ucTheme.Size = new System.Drawing.Size(1250, 800);
            this.ucTheme.TabIndex = 0;
            // 
            // ucbtnXinNghi
            // 
            this.ucbtnXinNghi.Location = new System.Drawing.Point(0, 328);
            this.ucbtnXinNghi.Name = "ucbtnXinNghi";
            this.ucbtnXinNghi.Size = new System.Drawing.Size(250, 70);
            this.ucbtnXinNghi.TabIndex = 4;
            this.ucbtnXinNghi.Text = "Xin nghỉ";
            // 
            // FQuanLy2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 800);
            this.Controls.Add(this.ucbtnXinNghi);
            this.Controls.Add(this.ucbtnDanhGiaDA);
            this.Controls.Add(this.ucbtnTaoDA);
            this.Controls.Add(this.ucbtnCheckinout);
            this.Controls.Add(this.ucTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FQuanLy2";
            this.Text = "FQuanLy2";
            this.ResumeLayout(false);

        }

        #endregion

        private UC ucTheme;
        private ucMenuBtn ucbtnCheckinout;
        private ucMenuBtn ucbtnTaoDA;
        private ucMenuBtn ucbtnDanhGiaDA;
        private ucMenuBtn ucbtnXinNghi;
    }
}