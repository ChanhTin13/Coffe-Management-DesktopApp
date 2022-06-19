
namespace Do_an_Co_so.Custom_Component
{
    partial class Cus_date
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
            this.custom_btn1 = new Do_an_Co_so.Custom_Component.custom_btn();
            this.SuspendLayout();
            // 
            // custom_btn1
            // 
            this.custom_btn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.custom_btn1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.custom_btn1.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.custom_btn1.BorderColor = System.Drawing.Color.MintCream;
            this.custom_btn1.BorderRadius = 20;
            this.custom_btn1.BorderSize = 1;
            this.custom_btn1.CausesValidation = false;
            this.custom_btn1.FlatAppearance.BorderSize = 0;
            this.custom_btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custom_btn1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custom_btn1.ForeColor = System.Drawing.Color.White;
            this.custom_btn1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.custom_btn1.Location = new System.Drawing.Point(0, 0);
            this.custom_btn1.Name = "custom_btn1";
            this.custom_btn1.Size = new System.Drawing.Size(296, 68);
            this.custom_btn1.TabIndex = 1;
            this.custom_btn1.Text = "15-06-2022";
            this.custom_btn1.TextColor = System.Drawing.Color.White;
            this.custom_btn1.UseVisualStyleBackColor = false;
            this.custom_btn1.Click += new System.EventHandler(this.custom_btn1_Click);
            // 
            // Cus_date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.custom_btn1);
            this.Name = "Cus_date";
            this.Size = new System.Drawing.Size(296, 68);
            this.ResumeLayout(false);

        }

        #endregion

        public custom_btn custom_btn1;
    }
}
