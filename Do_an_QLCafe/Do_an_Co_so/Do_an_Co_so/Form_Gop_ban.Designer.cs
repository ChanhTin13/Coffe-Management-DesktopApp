
namespace Do_an_Co_so
{
    partial class Form_Gop_ban
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
            this.custom_btn1 = new Do_an_Co_so.Custom_Component.custom_btn();
            this.cbx_ban = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_kv = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.custom_btn1.Location = new System.Drawing.Point(128, 146);
            this.custom_btn1.Name = "custom_btn1";
            this.custom_btn1.Size = new System.Drawing.Size(178, 46);
            this.custom_btn1.TabIndex = 9;
            this.custom_btn1.Text = "Gộp bàn";
            this.custom_btn1.TextColor = System.Drawing.Color.White;
            this.custom_btn1.UseVisualStyleBackColor = false;
            this.custom_btn1.Click += new System.EventHandler(this.custom_btn1_Click);
            // 
            // cbx_ban
            // 
            this.cbx_ban.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_ban.FormattingEnabled = true;
            this.cbx_ban.Location = new System.Drawing.Point(166, 89);
            this.cbx_ban.Name = "cbx_ban";
            this.cbx_ban.Size = new System.Drawing.Size(200, 34);
            this.cbx_ban.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bàn";
            // 
            // cbx_kv
            // 
            this.cbx_kv.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_kv.FormattingEnabled = true;
            this.cbx_kv.Location = new System.Drawing.Point(166, 20);
            this.cbx_kv.Name = "cbx_kv";
            this.cbx_kv.Size = new System.Drawing.Size(200, 34);
            this.cbx_kv.TabIndex = 6;
            this.cbx_kv.SelectedIndexChanged += new System.EventHandler(this.cbx_kv_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Khu vực";
            // 
            // Form_Gop_ban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 211);
            this.Controls.Add(this.custom_btn1);
            this.Controls.Add(this.cbx_ban);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_kv);
            this.Controls.Add(this.label1);
            this.Name = "Form_Gop_ban";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gộp bàn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Custom_Component.custom_btn custom_btn1;
        private System.Windows.Forms.ComboBox cbx_ban;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_kv;
        private System.Windows.Forms.Label label1;
    }
}