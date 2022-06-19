
namespace Do_an_Co_so
{
    partial class F_Chon_ban_de_chuyen
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
            this.label2 = new System.Windows.Forms.Label();
            this.custom_btn1 = new Do_an_Co_so.Custom_Component.custom_btn();
            this.cbx_kv = new System.Windows.Forms.ComboBox();
            this.cbx_ban = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khu vực";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bàn";
            // 
            // custom_btn1
            // 
            this.custom_btn1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.custom_btn1.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.custom_btn1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.custom_btn1.BorderRadius = 20;
            this.custom_btn1.BorderSize = 0;
            this.custom_btn1.FlatAppearance.BorderSize = 0;
            this.custom_btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custom_btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custom_btn1.ForeColor = System.Drawing.Color.White;
            this.custom_btn1.Location = new System.Drawing.Point(119, 153);
            this.custom_btn1.Name = "custom_btn1";
            this.custom_btn1.Size = new System.Drawing.Size(178, 46);
            this.custom_btn1.TabIndex = 4;
            this.custom_btn1.Text = "Chuyển bàn";
            this.custom_btn1.TextColor = System.Drawing.Color.White;
            this.custom_btn1.UseVisualStyleBackColor = false;
            this.custom_btn1.Click += new System.EventHandler(this.custom_btn1_Click);
            // 
            // cbx_kv
            // 
            this.cbx_kv.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_kv.FormattingEnabled = true;
            this.cbx_kv.Location = new System.Drawing.Point(157, 27);
            this.cbx_kv.Name = "cbx_kv";
            this.cbx_kv.Size = new System.Drawing.Size(200, 34);
            this.cbx_kv.TabIndex = 1;
            this.cbx_kv.SelectedIndexChanged += new System.EventHandler(this.cbx_kv_SelectedIndexChanged);
            // 
            // cbx_ban
            // 
            this.cbx_ban.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_ban.FormattingEnabled = true;
            this.cbx_ban.Location = new System.Drawing.Point(157, 96);
            this.cbx_ban.Name = "cbx_ban";
            this.cbx_ban.Size = new System.Drawing.Size(200, 34);
            this.cbx_ban.TabIndex = 3;
            // 
            // F_Chon_ban_de_chuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 211);
            this.Controls.Add(this.custom_btn1);
            this.Controls.Add(this.cbx_ban);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_kv);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "F_Chon_ban_de_chuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyển bàn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Custom_Component.custom_btn custom_btn1;
        private System.Windows.Forms.ComboBox cbx_kv;
        private System.Windows.Forms.ComboBox cbx_ban;
    }
}