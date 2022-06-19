
namespace Do_an_Co_so.Custom_Component
{
    partial class Cus_Ban
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_ten_ban = new System.Windows.Forms.Label();
            this.label_trang_thai = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.custom_btn1 = new Do_an_Co_so.Custom_Component.custom_btn();
            this.SuspendLayout();
            // 
            // label_ten_ban
            // 
            this.label_ten_ban.BackColor = System.Drawing.Color.White;
            this.label_ten_ban.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ten_ban.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(87)))));
            this.label_ten_ban.Location = new System.Drawing.Point(10, 22);
            this.label_ten_ban.Name = "label_ten_ban";
            this.label_ten_ban.Size = new System.Drawing.Size(130, 48);
            this.label_ten_ban.TabIndex = 1;
            this.label_ten_ban.Text = "Bàn 1";
            this.label_ten_ban.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_ten_ban.Click += new System.EventHandler(this.custom_btn1_Click);
            // 
            // label_trang_thai
            // 
            this.label_trang_thai.BackColor = System.Drawing.Color.White;
            this.label_trang_thai.Enabled = false;
            this.label_trang_thai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_trang_thai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_trang_thai.ForeColor = System.Drawing.Color.Black;
            this.label_trang_thai.Location = new System.Drawing.Point(15, 97);
            this.label_trang_thai.Name = "label_trang_thai";
            this.label_trang_thai.Size = new System.Drawing.Size(125, 30);
            this.label_trang_thai.TabIndex = 2;
            this.label_trang_thai.Text = "Trống";
            this.label_trang_thai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.ForeColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(15, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 2);
            this.panel1.TabIndex = 3;
            // 
            // custom_btn1
            // 
            this.custom_btn1.BackColor = System.Drawing.Color.White;
            this.custom_btn1.BackgroundColor = System.Drawing.Color.White;
            this.custom_btn1.BorderColor = System.Drawing.SystemColors.Highlight;
            this.custom_btn1.BorderRadius = 15;
            this.custom_btn1.BorderSize = 0;
            this.custom_btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.custom_btn1.FlatAppearance.BorderSize = 0;
            this.custom_btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custom_btn1.ForeColor = System.Drawing.Color.White;
            this.custom_btn1.Location = new System.Drawing.Point(0, 0);
            this.custom_btn1.Name = "custom_btn1";
            this.custom_btn1.Size = new System.Drawing.Size(150, 150);
            this.custom_btn1.TabIndex = 0;
            this.custom_btn1.TextColor = System.Drawing.Color.White;
            this.custom_btn1.UseVisualStyleBackColor = false;
            this.custom_btn1.Click += new System.EventHandler(this.custom_btn1_Click);
            // 
            // Cus_Ban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_trang_thai);
            this.Controls.Add(this.label_ten_ban);
            this.Controls.Add(this.custom_btn1);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "Cus_Ban";
            this.ResumeLayout(false);

        }

        #endregion

        private custom_btn custom_btn1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label_ten_ban;
        public System.Windows.Forms.Label label_trang_thai;
    }
}
