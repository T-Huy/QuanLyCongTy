namespace QuanLyCongTy
{
    partial class FTruongPhong
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
            this.ucbtnXinNghi = new QuanLyCongTy.ucMenuBtn();
            this.ucbtnTaoPC = new QuanLyCongTy.ucMenuBtn();
            this.ucbtnCheckinout = new QuanLyCongTy.ucMenuBtn();
            this.ucTheme = new QuanLyCongTy.UC();
            this.SuspendLayout();
            // 
            // ucbtnXinNghi
            // 
            this.ucbtnXinNghi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ucbtnXinNghi.Location = new System.Drawing.Point(0, 240);
            this.ucbtnXinNghi.Name = "ucbtnXinNghi";
            this.ucbtnXinNghi.Size = new System.Drawing.Size(248, 70);
            this.ucbtnXinNghi.TabIndex = 4;
            this.ucbtnXinNghi.Text = "Xin Nghỉ";
            // 
            // ucbtnTaoPC
            // 
            this.ucbtnTaoPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ucbtnTaoPC.Location = new System.Drawing.Point(0, 170);
            this.ucbtnTaoPC.Name = "ucbtnTaoPC";
            this.ucbtnTaoPC.Size = new System.Drawing.Size(248, 70);
            this.ucbtnTaoPC.TabIndex = 2;
            this.ucbtnTaoPC.Text = "Dự Án";
            // 
            // ucbtnCheckinout
            // 
            this.ucbtnCheckinout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ucbtnCheckinout.Location = new System.Drawing.Point(0, 100);
            this.ucbtnCheckinout.Name = "ucbtnCheckinout";
            this.ucbtnCheckinout.Size = new System.Drawing.Size(248, 70);
            this.ucbtnCheckinout.TabIndex = 1;
            this.ucbtnCheckinout.Text = "Check in/out";
            // 
            // ucTheme
            // 
            this.ucTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTheme.Location = new System.Drawing.Point(0, 0);
            this.ucTheme.Name = "ucTheme";
            this.ucTheme.Size = new System.Drawing.Size(1250, 800);
            this.ucTheme.TabIndex = 5;
            // 
            // FTruongPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 800);
            this.Controls.Add(this.ucbtnXinNghi);
            this.Controls.Add(this.ucbtnTaoPC);
            this.Controls.Add(this.ucbtnCheckinout);
            this.Controls.Add(this.ucTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FTruongPhong";
            this.Text = "FTruongPhong2";
            this.ResumeLayout(false);

        }

        #endregion
        private ucMenuBtn ucbtnCheckinout;
        private ucMenuBtn ucbtnTaoPC;
        private ucMenuBtn ucbtnXinNghi;
        private UC ucTheme;
    }
}