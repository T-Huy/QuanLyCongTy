namespace QuanLyCongTy
{
    partial class FXemDuAn
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
            this.flp_ListDA = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDaHT = new System.Windows.Forms.Button();
            this.btnChuaHT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flp_ListDA
            // 
            this.flp_ListDA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flp_ListDA.Location = new System.Drawing.Point(0, 50);
            this.flp_ListDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flp_ListDA.Name = "flp_ListDA";
            this.flp_ListDA.Size = new System.Drawing.Size(1000, 650);
            this.flp_ListDA.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDaHT);
            this.panel1.Controls.Add(this.btnChuaHT);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 44);
            this.panel1.TabIndex = 3;
            // 
            // btnDaHT
            // 
            this.btnDaHT.Location = new System.Drawing.Point(233, -1);
            this.btnDaHT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDaHT.Name = "btnDaHT";
            this.btnDaHT.Size = new System.Drawing.Size(235, 44);
            this.btnDaHT.TabIndex = 1;
            this.btnDaHT.Text = "Đã hoàn thành";
            this.btnDaHT.UseVisualStyleBackColor = true;
            this.btnDaHT.Click += new System.EventHandler(this.btnDaHT_Click);
            // 
            // btnChuaHT
            // 
            this.btnChuaHT.Location = new System.Drawing.Point(-1, -1);
            this.btnChuaHT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChuaHT.Name = "btnChuaHT";
            this.btnChuaHT.Size = new System.Drawing.Size(235, 44);
            this.btnChuaHT.TabIndex = 0;
            this.btnChuaHT.Text = "Chưa hoàn thành";
            this.btnChuaHT.UseVisualStyleBackColor = true;
            this.btnChuaHT.Click += new System.EventHandler(this.btnChuaHT_Click);
            // 
            // FXemDuAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.flp_ListDA);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FXemDuAn";
            this.Text = "FXemDuAn";
            this.Load += new System.EventHandler(this.FXemDuAn_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_ListDA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDaHT;
        private System.Windows.Forms.Button btnChuaHT;
    }
}