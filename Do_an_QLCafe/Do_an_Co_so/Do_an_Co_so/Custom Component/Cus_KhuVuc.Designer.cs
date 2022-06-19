
namespace Do_an_Co_so.Custom_Component
{
    partial class Cus_KhuVuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cus_KhuVuc));
            this.custom_btn1 = new Do_an_Co_so.Custom_Component.custom_btn();
            this.label_id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // custom_btn1
            // 
            this.custom_btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.custom_btn1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.custom_btn1.BorderColor = System.Drawing.Color.Cyan;
            this.custom_btn1.BorderRadius = 20;
            this.custom_btn1.BorderSize = 0;
            this.custom_btn1.CausesValidation = false;
            this.custom_btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.custom_btn1.FlatAppearance.BorderSize = 0;
            this.custom_btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custom_btn1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custom_btn1.ForeColor = System.Drawing.Color.Black;
            this.custom_btn1.Image = ((System.Drawing.Image)(resources.GetObject("custom_btn1.Image")));
            this.custom_btn1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.custom_btn1.Location = new System.Drawing.Point(0, 0);
            this.custom_btn1.Name = "custom_btn1";
            this.custom_btn1.Size = new System.Drawing.Size(296, 68);
            this.custom_btn1.TabIndex = 0;
            this.custom_btn1.Text = "Khu vực 1";
            this.custom_btn1.TextColor = System.Drawing.Color.Black;
            this.custom_btn1.UseVisualStyleBackColor = false;
            this.custom_btn1.Click += new System.EventHandler(this.custom_btn1_Click);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Enabled = false;
            this.label_id.Location = new System.Drawing.Point(240, 25);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(16, 17);
            this.label_id.TabIndex = 1;
            this.label_id.Text = "1";
            this.label_id.Visible = false;
            // 
            // Cus_KhuVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.custom_btn1);
            this.Name = "Cus_KhuVuc";
            this.Size = new System.Drawing.Size(296, 68);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public custom_btn custom_btn1;
        public System.Windows.Forms.Label label_id;
    }
}
