
namespace Do_an_Co_so
{
    partial class F_thanh_toan_momo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_tt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.custom_btn2 = new Do_an_Co_so.Custom_Component.custom_btn();
            this.custom_btn1 = new Do_an_Co_so.Custom_Component.custom_btn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng tiền:";
            // 
            // label_tt
            // 
            this.label_tt.AutoSize = true;
            this.label_tt.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tt.Location = new System.Drawing.Point(265, 401);
            this.label_tt.Name = "label_tt";
            this.label_tt.Size = new System.Drawing.Size(162, 43);
            this.label_tt.TabIndex = 3;
            this.label_tt.Text = "350000 đ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Do_an_Co_so.Properties.Resources.momo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(75, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(385, 385);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // custom_btn2
            // 
            this.custom_btn2.BackColor = System.Drawing.SystemColors.Control;
            this.custom_btn2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.custom_btn2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.custom_btn2.BorderRadius = 20;
            this.custom_btn2.BorderSize = 0;
            this.custom_btn2.FlatAppearance.BorderSize = 0;
            this.custom_btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custom_btn2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custom_btn2.ForeColor = System.Drawing.Color.Red;
            this.custom_btn2.Location = new System.Drawing.Point(178, 565);
            this.custom_btn2.Name = "custom_btn2";
            this.custom_btn2.Size = new System.Drawing.Size(176, 53);
            this.custom_btn2.TabIndex = 7;
            this.custom_btn2.Text = "Hủy";
            this.custom_btn2.TextColor = System.Drawing.Color.Red;
            this.custom_btn2.UseVisualStyleBackColor = false;
            this.custom_btn2.Visible = false;
            this.custom_btn2.Click += new System.EventHandler(this.custom_btn2_Click);
            // 
            // custom_btn1
            // 
            this.custom_btn1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.custom_btn1.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.custom_btn1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.custom_btn1.BorderRadius = 30;
            this.custom_btn1.BorderSize = 0;
            this.custom_btn1.FlatAppearance.BorderSize = 0;
            this.custom_btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custom_btn1.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custom_btn1.ForeColor = System.Drawing.Color.White;
            this.custom_btn1.Location = new System.Drawing.Point(114, 457);
            this.custom_btn1.Name = "custom_btn1";
            this.custom_btn1.Size = new System.Drawing.Size(302, 83);
            this.custom_btn1.TabIndex = 0;
            this.custom_btn1.Text = "Lấy mã";
            this.custom_btn1.TextColor = System.Drawing.Color.White;
            this.custom_btn1.UseVisualStyleBackColor = false;
            this.custom_btn1.Click += new System.EventHandler(this.custom_btn1_Click);
            // 
            // F_thanh_toan_momo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(538, 630);
            this.Controls.Add(this.custom_btn2);
            this.Controls.Add(this.label_tt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.custom_btn1);
            this.Name = "F_thanh_toan_momo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán Momo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Custom_Component.custom_btn custom_btn1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_tt;
        private Custom_Component.custom_btn custom_btn2;
    }
}