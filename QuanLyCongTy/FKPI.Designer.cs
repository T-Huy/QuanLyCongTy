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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChuaHT = new Guna.UI2.WinForms.Guna2Button();
            this.btnDaHT = new Guna.UI2.WinForms.Guna2Button();
            this.flpListPC = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnChuaHT);
            this.panel1.Controls.Add(this.btnDaHT);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 63);
            this.panel1.TabIndex = 7;
            // 
            // btnChuaHT
            // 
            this.btnChuaHT.AutoRoundedCorners = true;
            this.btnChuaHT.BackColor = System.Drawing.Color.Transparent;
            this.btnChuaHT.BorderRadius = 27;
            this.btnChuaHT.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnChuaHT.Checked = true;
            this.btnChuaHT.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnChuaHT.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnChuaHT.CheckedState.Image = global::QuanLyCongTy.Properties.Resources.delete__2_;
            this.btnChuaHT.FillColor = System.Drawing.Color.White;
            this.btnChuaHT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuaHT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnChuaHT.Image = global::QuanLyCongTy.Properties.Resources.delete__1_;
            this.btnChuaHT.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnChuaHT.ImageSize = new System.Drawing.Size(25, 25);
            this.btnChuaHT.Location = new System.Drawing.Point(3, 3);
            this.btnChuaHT.Name = "btnChuaHT";
            this.btnChuaHT.Size = new System.Drawing.Size(62, 56);
            this.btnChuaHT.TabIndex = 41;
            this.btnChuaHT.UseTransparentBackground = true;
            this.btnChuaHT.CheckedChanged += new System.EventHandler(this.btnChuaHT_CheckedChanged);
            // 
            // btnDaHT
            // 
            this.btnDaHT.AutoRoundedCorners = true;
            this.btnDaHT.BackColor = System.Drawing.Color.Transparent;
            this.btnDaHT.BorderRadius = 27;
            this.btnDaHT.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDaHT.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnDaHT.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnDaHT.CheckedState.Image = global::QuanLyCongTy.Properties.Resources.checked__1_;
            this.btnDaHT.FillColor = System.Drawing.Color.White;
            this.btnDaHT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaHT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnDaHT.Image = global::QuanLyCongTy.Properties.Resources._checked;
            this.btnDaHT.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDaHT.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDaHT.Location = new System.Drawing.Point(71, 3);
            this.btnDaHT.Name = "btnDaHT";
            this.btnDaHT.Size = new System.Drawing.Size(62, 56);
            this.btnDaHT.TabIndex = 40;
            this.btnDaHT.UseTransparentBackground = true;
            this.btnDaHT.CheckedChanged += new System.EventHandler(this.btnDaHT_CheckedChanged);
            // 
            // flpListPC
            // 
            this.flpListPC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flpListPC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpListPC.Location = new System.Drawing.Point(0, 98);
            this.flpListPC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpListPC.Name = "flpListPC";
            this.flpListPC.Size = new System.Drawing.Size(1000, 602);
            this.flpListPC.TabIndex = 8;
            // 
            // FKPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpListPC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FKPI";
            this.Text = "FKPI2";
            this.Load += new System.EventHandler(this.FKPI_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnDaHT;
        private System.Windows.Forms.FlowLayoutPanel flpListPC;
        private Guna.UI2.WinForms.Guna2Button btnChuaHT;
    }
}