namespace QLCTy
{
    partial class Add
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
            System.Windows.Forms.DateTimePicker dateTimePicker2;
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Lydo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Khac = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Songay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picBox_Image = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ngày Bắt Đầu: ";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            dateTimePicker2.CalendarTitleBackColor = System.Drawing.Color.OrangeRed;
            dateTimePicker2.CausesValidation = false;
            dateTimePicker2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            dateTimePicker2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateTimePicker2.ImeMode = System.Windows.Forms.ImeMode.Off;
            dateTimePicker2.Location = new System.Drawing.Point(130, 23);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new System.Drawing.Size(278, 26);
            dateTimePicker2.TabIndex = 9;
            dateTimePicker2.TabStop = false;
            dateTimePicker2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lý Do: ";
            // 
            // cb_Lydo
            // 
            this.cb_Lydo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Lydo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Lydo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Lydo.FormattingEnabled = true;
            this.cb_Lydo.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cb_Lydo.Items.AddRange(new object[] {
            "Lý do sức khỏe",
            "Có lịch đi khám sức khỏe",
            "Gia đình có việc đột xuất",
            "Chăm người thân bị bệnh",
            "Chuyển nhà, chuyển trọ",
            "Khác"});
            this.cb_Lydo.Location = new System.Drawing.Point(130, 110);
            this.cb_Lydo.Name = "cb_Lydo";
            this.cb_Lydo.Size = new System.Drawing.Size(278, 27);
            this.cb_Lydo.TabIndex = 11;
            this.cb_Lydo.SelectedValueChanged += new System.EventHandler(this.cb_Lydo_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Khác:";
            // 
            // txt_Khac
            // 
            this.txt_Khac.Location = new System.Drawing.Point(130, 166);
            this.txt_Khac.Multiline = true;
            this.txt_Khac.Name = "txt_Khac";
            this.txt_Khac.Size = new System.Drawing.Size(278, 99);
            this.txt_Khac.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Số Ngày Nghỉ: ";
            // 
            // txt_Songay
            // 
            this.txt_Songay.Location = new System.Drawing.Point(130, 69);
            this.txt_Songay.Name = "txt_Songay";
            this.txt_Songay.Size = new System.Drawing.Size(278, 20);
            this.txt_Songay.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ảnh Minh Chứng:";
            // 
            // picBox_Image
            // 
            this.picBox_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox_Image.Location = new System.Drawing.Point(130, 312);
            this.picBox_Image.Name = "picBox_Image";
            this.picBox_Image.Size = new System.Drawing.Size(278, 160);
            this.picBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Image.TabIndex = 17;
            this.picBox_Image.TabStop = false;
            this.picBox_Image.Click += new System.EventHandler(this.picBox_Image_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(309, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Xác Nhận";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picBox_Image);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Songay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Khac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Lydo);
            this.Controls.Add(this.label3);
            this.Controls.Add(dateTimePicker2);
            this.Controls.Add(this.label5);
            this.Name = "Add";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Lydo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Khac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Songay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBox_Image;
        private System.Windows.Forms.Button button1;
    }
}