
namespace Do_an_Co_so
{
    partial class Form_Bep
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
            this.panel_header = new System.Windows.Forms.Panel();
            this.header_bep = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_noi_dung = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_child = new System.Windows.Forms.Panel();
            this.panel_header.SuspendLayout();
            this.header_bep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.Controls.Add(this.header_bep);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(964, 72);
            this.panel_header.TabIndex = 0;
            // 
            // header_bep
            // 
            this.header_bep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header_bep.BackColor = System.Drawing.Color.White;
            this.header_bep.Controls.Add(this.pictureBox2);
            this.header_bep.Controls.Add(this.label3);
            this.header_bep.Controls.Add(this.label_noi_dung);
            this.header_bep.Controls.Add(this.label2);
            this.header_bep.Controls.Add(this.label1);
            this.header_bep.Location = new System.Drawing.Point(3, 3);
            this.header_bep.Name = "header_bep";
            this.header_bep.Size = new System.Drawing.Size(958, 66);
            this.header_bep.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::Do_an_Co_so.Properties.Resources.refresh;
            this.pictureBox2.Location = new System.Drawing.Point(882, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(653, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 57);
            this.label3.TabIndex = 8;
            this.label3.Text = "Thao tác";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_noi_dung
            // 
            this.label_noi_dung.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_noi_dung.BackColor = System.Drawing.Color.SeaShell;
            this.label_noi_dung.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_noi_dung.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_noi_dung.Location = new System.Drawing.Point(358, 6);
            this.label_noi_dung.Name = "label_noi_dung";
            this.label_noi_dung.Size = new System.Drawing.Size(208, 57);
            this.label_noi_dung.TabIndex = 6;
            this.label_noi_dung.Text = "Nội dung";
            this.label_noi_dung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(289, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "SL";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(47, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 63);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên món";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_child
            // 
            this.panel_child.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_child.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel_child.Location = new System.Drawing.Point(0, 69);
            this.panel_child.Name = "panel_child";
            this.panel_child.Size = new System.Drawing.Size(964, 381);
            this.panel_child.TabIndex = 1;
            // 
            // Form_Bep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 450);
            this.Controls.Add(this.panel_child);
            this.Controls.Add(this.panel_header);
            this.Name = "Form_Bep";
            this.Text = "Bếp";
            this.panel_header.ResumeLayout(false);
            this.header_bep.ResumeLayout(false);
            this.header_bep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Panel header_bep;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label_noi_dung;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_child;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}