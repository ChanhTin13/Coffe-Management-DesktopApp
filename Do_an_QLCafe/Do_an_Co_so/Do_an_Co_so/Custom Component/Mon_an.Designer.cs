
namespace Do_an_Co_so.Component
{
    partial class Mon_an
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mon_an));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_het_hang = new System.Windows.Forms.Label();
            this.custom_Picturebox1 = new Do_an_Co_so.Custom_Controls.Custom_Picturebox();
            this.label_Gia = new System.Windows.Forms.Label();
            this.label_Ten_mon = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custom_Picturebox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label_het_hang);
            this.panel1.Controls.Add(this.custom_Picturebox1);
            this.panel1.Controls.Add(this.label_Gia);
            this.panel1.Controls.Add(this.label_Ten_mon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 166);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // label_het_hang
            // 
            this.label_het_hang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_het_hang.AutoSize = true;
            this.label_het_hang.BackColor = System.Drawing.Color.Transparent;
            this.label_het_hang.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_het_hang.ForeColor = System.Drawing.Color.Red;
            this.label_het_hang.Location = new System.Drawing.Point(204, 135);
            this.label_het_hang.Name = "label_het_hang";
            this.label_het_hang.Size = new System.Drawing.Size(119, 30);
            this.label_het_hang.TabIndex = 13;
            this.label_het_hang.Text = "Hết hàng";
            this.label_het_hang.Visible = false;
            // 
            // custom_Picturebox1
            // 
            this.custom_Picturebox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.custom_Picturebox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("custom_Picturebox1.BackgroundImage")));
            this.custom_Picturebox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.custom_Picturebox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.custom_Picturebox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.custom_Picturebox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.custom_Picturebox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.custom_Picturebox1.BorderSize = 2;
            this.custom_Picturebox1.GradientAngle = 50F;
            this.custom_Picturebox1.Location = new System.Drawing.Point(190, 9);
            this.custom_Picturebox1.Name = "custom_Picturebox1";
            this.custom_Picturebox1.Size = new System.Drawing.Size(138, 138);
            this.custom_Picturebox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.custom_Picturebox1.TabIndex = 12;
            this.custom_Picturebox1.TabStop = false;
            this.custom_Picturebox1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // label_Gia
            // 
            this.label_Gia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Gia.AutoSize = true;
            this.label_Gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Gia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.label_Gia.Location = new System.Drawing.Point(22, 126);
            this.label_Gia.Name = "label_Gia";
            this.label_Gia.Size = new System.Drawing.Size(55, 39);
            this.label_Gia.TabIndex = 11;
            this.label_Gia.Text = "15";
            this.label_Gia.Click += new System.EventHandler(this.panel1_Click);
            // 
            // label_Ten_mon
            // 
            this.label_Ten_mon.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Ten_mon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(73)))));
            this.label_Ten_mon.Location = new System.Drawing.Point(3, 1);
            this.label_Ten_mon.Name = "label_Ten_mon";
            this.label_Ten_mon.Size = new System.Drawing.Size(181, 125);
            this.label_Ten_mon.TabIndex = 10;
            this.label_Ten_mon.Text = "Đen đá";
            this.label_Ten_mon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_Ten_mon.Click += new System.EventHandler(this.panel1_Click);
            // 
            // Mon_an
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.panel1);
            this.Name = "Mon_an";
            this.Size = new System.Drawing.Size(348, 166);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custom_Picturebox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_het_hang;
        private Custom_Controls.Custom_Picturebox custom_Picturebox1;
        private System.Windows.Forms.Label label_Gia;
        private System.Windows.Forms.Label label_Ten_mon;
    }
}
