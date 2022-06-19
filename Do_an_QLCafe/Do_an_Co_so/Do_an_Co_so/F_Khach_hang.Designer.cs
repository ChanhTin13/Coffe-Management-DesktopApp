
namespace Do_an_Co_so
{
    partial class F_Khach_hang
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
            this.dtgv_kh = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Excel = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cus_btn_Sua = new Do_an_Co_so.Custom_Component.custom_btn();
            this.cus_btn_them = new Do_an_Co_so.Custom_Component.custom_btn();
            this.txt_cmnd = new Do_an_Co_so.Custom_Controls.Custom_Textbox();
            this.txt_sdt = new Do_an_Co_so.Custom_Controls.Custom_Textbox();
            this.txt_ten_kh = new Do_an_Co_so.Custom_Controls.Custom_Textbox();
            this.txt_ma_kh = new Do_an_Co_so.Custom_Controls.Custom_Textbox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_kh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Excel)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_kh
            // 
            this.dtgv_kh.AllowUserToAddRows = false;
            this.dtgv_kh.AllowUserToDeleteRows = false;
            this.dtgv_kh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_kh.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dtgv_kh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_kh.Location = new System.Drawing.Point(13, 218);
            this.dtgv_kh.Name = "dtgv_kh";
            this.dtgv_kh.ReadOnly = true;
            this.dtgv_kh.RowHeadersWidth = 51;
            this.dtgv_kh.RowTemplate.Height = 24;
            this.dtgv_kh.Size = new System.Drawing.Size(1052, 319);
            this.dtgv_kh.TabIndex = 0;
            this.dtgv_kh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::Do_an_Co_so.Properties.Resources.refresh;
            this.pictureBox2.Location = new System.Drawing.Point(103, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox_Excel
            // 
            this.pictureBox_Excel.BackColor = System.Drawing.Color.White;
            this.pictureBox_Excel.Image = global::Do_an_Co_so.Properties.Resources.excel;
            this.pictureBox_Excel.Location = new System.Drawing.Point(13, 8);
            this.pictureBox_Excel.Name = "pictureBox_Excel";
            this.pictureBox_Excel.Size = new System.Drawing.Size(73, 57);
            this.pictureBox_Excel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Excel.TabIndex = 2;
            this.pictureBox_Excel.TabStop = false;
            this.pictureBox_Excel.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.label2.Location = new System.Drawing.Point(237, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Kh:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.label3.Location = new System.Drawing.Point(237, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã Kh:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.label4.Location = new System.Drawing.Point(567, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "CMND:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.label5.Location = new System.Drawing.Point(567, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sđt:";
            // 
            // cus_btn_Sua
            // 
            this.cus_btn_Sua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cus_btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(209)))), ((int)(((byte)(134)))));
            this.cus_btn_Sua.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(209)))), ((int)(((byte)(134)))));
            this.cus_btn_Sua.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cus_btn_Sua.BorderRadius = 20;
            this.cus_btn_Sua.BorderSize = 0;
            this.cus_btn_Sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cus_btn_Sua.FlatAppearance.BorderSize = 0;
            this.cus_btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cus_btn_Sua.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cus_btn_Sua.ForeColor = System.Drawing.Color.White;
            this.cus_btn_Sua.Location = new System.Drawing.Point(663, 162);
            this.cus_btn_Sua.Name = "cus_btn_Sua";
            this.cus_btn_Sua.Size = new System.Drawing.Size(94, 50);
            this.cus_btn_Sua.TabIndex = 79;
            this.cus_btn_Sua.Text = "Sửa";
            this.cus_btn_Sua.TextColor = System.Drawing.Color.White;
            this.cus_btn_Sua.UseVisualStyleBackColor = false;
            this.cus_btn_Sua.Click += new System.EventHandler(this.cus_btn_Sua_Click);
            // 
            // cus_btn_them
            // 
            this.cus_btn_them.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cus_btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(209)))), ((int)(((byte)(134)))));
            this.cus_btn_them.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(209)))), ((int)(((byte)(134)))));
            this.cus_btn_them.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cus_btn_them.BorderRadius = 20;
            this.cus_btn_them.BorderSize = 0;
            this.cus_btn_them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cus_btn_them.FlatAppearance.BorderSize = 0;
            this.cus_btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cus_btn_them.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cus_btn_them.ForeColor = System.Drawing.Color.White;
            this.cus_btn_them.Location = new System.Drawing.Point(333, 162);
            this.cus_btn_them.Name = "cus_btn_them";
            this.cus_btn_them.Size = new System.Drawing.Size(94, 50);
            this.cus_btn_them.TabIndex = 78;
            this.cus_btn_them.Text = "Thêm";
            this.cus_btn_them.TextColor = System.Drawing.Color.White;
            this.cus_btn_them.UseVisualStyleBackColor = false;
            this.cus_btn_them.Click += new System.EventHandler(this.cus_btn_them_Click);
            // 
            // txt_cmnd
            // 
            this.txt_cmnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_cmnd.BackColor = System.Drawing.SystemColors.Window;
            this.txt_cmnd.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_cmnd.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_cmnd.BorderSize = 2;
            this.txt_cmnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cmnd.ForeColor = System.Drawing.Color.DimGray;
            this.txt_cmnd.Location = new System.Drawing.Point(663, 110);
            this.txt_cmnd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cmnd.Multiline = false;
            this.txt_cmnd.Name = "txt_cmnd";
            this.txt_cmnd.Padding = new System.Windows.Forms.Padding(7);
            this.txt_cmnd.PasswordChar = false;
            this.txt_cmnd.Size = new System.Drawing.Size(196, 35);
            this.txt_cmnd.TabIndex = 14;
            this.txt_cmnd.Texts = "";
            this.txt_cmnd.UnderlinedStyle = true;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_sdt.BackColor = System.Drawing.SystemColors.Window;
            this.txt_sdt.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_sdt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_sdt.BorderSize = 2;
            this.txt_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.ForeColor = System.Drawing.Color.DimGray;
            this.txt_sdt.Location = new System.Drawing.Point(663, 62);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sdt.Multiline = false;
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Padding = new System.Windows.Forms.Padding(7);
            this.txt_sdt.PasswordChar = false;
            this.txt_sdt.Size = new System.Drawing.Size(196, 35);
            this.txt_sdt.TabIndex = 13;
            this.txt_sdt.Texts = "";
            this.txt_sdt.UnderlinedStyle = true;
            // 
            // txt_ten_kh
            // 
            this.txt_ten_kh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_ten_kh.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ten_kh.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_ten_kh.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_ten_kh.BorderSize = 2;
            this.txt_ten_kh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ten_kh.ForeColor = System.Drawing.Color.DimGray;
            this.txt_ten_kh.Location = new System.Drawing.Point(333, 110);
            this.txt_ten_kh.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ten_kh.Multiline = false;
            this.txt_ten_kh.Name = "txt_ten_kh";
            this.txt_ten_kh.Padding = new System.Windows.Forms.Padding(7);
            this.txt_ten_kh.PasswordChar = false;
            this.txt_ten_kh.Size = new System.Drawing.Size(196, 35);
            this.txt_ten_kh.TabIndex = 10;
            this.txt_ten_kh.Texts = "";
            this.txt_ten_kh.UnderlinedStyle = true;
            // 
            // txt_ma_kh
            // 
            this.txt_ma_kh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_ma_kh.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ma_kh.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_ma_kh.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_ma_kh.BorderSize = 2;
            this.txt_ma_kh.Enabled = false;
            this.txt_ma_kh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ma_kh.ForeColor = System.Drawing.Color.DimGray;
            this.txt_ma_kh.Location = new System.Drawing.Point(333, 62);
            this.txt_ma_kh.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ma_kh.Multiline = false;
            this.txt_ma_kh.Name = "txt_ma_kh";
            this.txt_ma_kh.Padding = new System.Windows.Forms.Padding(7);
            this.txt_ma_kh.PasswordChar = false;
            this.txt_ma_kh.Size = new System.Drawing.Size(196, 35);
            this.txt_ma_kh.TabIndex = 9;
            this.txt_ma_kh.Texts = "";
            this.txt_ma_kh.UnderlinedStyle = true;
            // 
            // F_Khach_hang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 538);
            this.Controls.Add(this.cus_btn_Sua);
            this.Controls.Add(this.cus_btn_them);
            this.Controls.Add(this.txt_cmnd);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_ten_kh);
            this.Controls.Add(this.txt_ma_kh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox_Excel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgv_kh);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "F_Khach_hang";
            this.Text = "Quản lý khách hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_kh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Excel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_kh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_Excel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Custom_Controls.Custom_Textbox txt_ten_kh;
        private Custom_Controls.Custom_Textbox txt_ma_kh;
        private Custom_Controls.Custom_Textbox txt_cmnd;
        private Custom_Controls.Custom_Textbox txt_sdt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Custom_Component.custom_btn cus_btn_Sua;
        private Custom_Component.custom_btn cus_btn_them;
    }
}