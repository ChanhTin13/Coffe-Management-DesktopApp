
namespace Do_an_Co_so.Custom_Component
{
    partial class Cus_DonHang
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_ten_kv = new System.Windows.Forms.Label();
            this.btn_chuyen_ban = new System.Windows.Forms.Button();
            this.btn_gop_ban = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_thanh_toan = new System.Windows.Forms.Button();
            this.label_tong_tien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_ban = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label_ten_kv);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 38);
            this.panel2.TabIndex = 6;
            // 
            // label_ten_kv
            // 
            this.label_ten_kv.AutoSize = true;
            this.label_ten_kv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ten_kv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_ten_kv.Location = new System.Drawing.Point(3, 1);
            this.label_ten_kv.Name = "label_ten_kv";
            this.label_ten_kv.Size = new System.Drawing.Size(134, 31);
            this.label_ten_kv.TabIndex = 1;
            this.label_ten_kv.Text = "Khu vực 1";
            // 
            // btn_chuyen_ban
            // 
            this.btn_chuyen_ban.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_chuyen_ban.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_chuyen_ban.FlatAppearance.BorderSize = 0;
            this.btn_chuyen_ban.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chuyen_ban.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_chuyen_ban.Location = new System.Drawing.Point(133, 162);
            this.btn_chuyen_ban.Name = "btn_chuyen_ban";
            this.btn_chuyen_ban.Size = new System.Drawing.Size(140, 43);
            this.btn_chuyen_ban.TabIndex = 5;
            this.btn_chuyen_ban.Text = "Chuyển bàn";
            this.btn_chuyen_ban.UseVisualStyleBackColor = false;
            this.btn_chuyen_ban.Click += new System.EventHandler(this.btn_chuyen_ban_Click);
            // 
            // btn_gop_ban
            // 
            this.btn_gop_ban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_gop_ban.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gop_ban.FlatAppearance.BorderSize = 0;
            this.btn_gop_ban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gop_ban.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gop_ban.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_gop_ban.Location = new System.Drawing.Point(0, 162);
            this.btn_gop_ban.Name = "btn_gop_ban";
            this.btn_gop_ban.Size = new System.Drawing.Size(127, 40);
            this.btn_gop_ban.TabIndex = 4;
            this.btn_gop_ban.Text = "Gộp bàn";
            this.btn_gop_ban.UseVisualStyleBackColor = false;
            this.btn_gop_ban.Click += new System.EventHandler(this.btn_gop_ban_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btn_thanh_toan);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label_tong_tien);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label_ban);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 164);
            this.panel1.TabIndex = 3;
            // 
            // btn_thanh_toan
            // 
            this.btn_thanh_toan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_thanh_toan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_thanh_toan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thanh_toan.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_thanh_toan.Location = new System.Drawing.Point(0, 124);
            this.btn_thanh_toan.Name = "btn_thanh_toan";
            this.btn_thanh_toan.Size = new System.Drawing.Size(273, 40);
            this.btn_thanh_toan.TabIndex = 7;
            this.btn_thanh_toan.Text = "Thanh toán";
            this.btn_thanh_toan.UseVisualStyleBackColor = false;
            this.btn_thanh_toan.Click += new System.EventHandler(this.btn_thanh_toan_Click);
            // 
            // label_tong_tien
            // 
            this.label_tong_tien.AutoSize = true;
            this.label_tong_tien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tong_tien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_tong_tien.Location = new System.Drawing.Point(112, 94);
            this.label_tong_tien.Name = "label_tong_tien";
            this.label_tong_tien.Size = new System.Drawing.Size(84, 27);
            this.label_tong_tien.TabIndex = 5;
            this.label_tong_tien.Text = "50000đ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(3, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng tiền";
            // 
            // label_ban
            // 
            this.label_ban.AutoSize = true;
            this.label_ban.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ban.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_ban.Location = new System.Drawing.Point(87, 51);
            this.label_ban.Name = "label_ban";
            this.label_ban.Size = new System.Drawing.Size(95, 33);
            this.label_ban.TabIndex = 2;
            this.label_ban.Text = "Bàn 3";
            // 
            // Cus_DonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.btn_chuyen_ban);
            this.Controls.Add(this.btn_gop_ban);
            this.Controls.Add(this.panel1);
            this.Name = "Cus_DonHang";
            this.Size = new System.Drawing.Size(273, 205);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_ten_kv;
        private System.Windows.Forms.Button btn_chuyen_ban;
        private System.Windows.Forms.Button btn_gop_ban;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_thanh_toan;
        private System.Windows.Forms.Label label_tong_tien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_ban;
    }
}
