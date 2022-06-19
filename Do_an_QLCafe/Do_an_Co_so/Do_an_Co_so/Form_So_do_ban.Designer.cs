
namespace Do_an_Co_so
{
    partial class Form_So_do_ban
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
            this.panel_child_form = new System.Windows.Forms.Panel();
            this.panel_Khu_vuc = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_child_form.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_child_form
            // 
            this.panel_child_form.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_child_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(68)))), ((int)(((byte)(100)))));
            this.panel_child_form.Controls.Add(this.panel_Khu_vuc);
            this.panel_child_form.Controls.Add(this.flowLayoutPanel1);
            this.panel_child_form.Location = new System.Drawing.Point(-3, -2);
            this.panel_child_form.Name = "panel_child_form";
            this.panel_child_form.Size = new System.Drawing.Size(999, 634);
            this.panel_child_form.TabIndex = 9;
            // 
            // panel_Khu_vuc
            // 
            this.panel_Khu_vuc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Khu_vuc.AutoScroll = true;
            this.panel_Khu_vuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
            this.panel_Khu_vuc.CausesValidation = false;
            this.panel_Khu_vuc.ForeColor = System.Drawing.Color.Black;
            this.panel_Khu_vuc.Location = new System.Drawing.Point(538, 3);
            this.panel_Khu_vuc.Name = "panel_Khu_vuc";
            this.panel_Khu_vuc.Size = new System.Drawing.Size(458, 631);
            this.panel_Khu_vuc.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(68)))), ((int)(((byte)(100)))));
            this.flowLayoutPanel1.CausesValidation = false;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 3);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(1415, 1050);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(540, 631);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // Form_So_do_ban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 629);
            this.Controls.Add(this.panel_child_form);
            this.Name = "Form_So_do_ban";
            this.Text = "Sơ đồ bàn";
            this.panel_child_form.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_child_form;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel_Khu_vuc;
        //private Component.Mon_an mon_an1;
    }
}

