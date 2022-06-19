using Do_an_Co_so.Component;
using Do_an_Co_so.Custom_Component;
using QuanLyThuVien_KeKao.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_Co_so
{
    public partial class Admin : Form
    {
        private Account_DTO acc;
        public Admin(Account_DTO tk)
        {
            InitializeComponent();
            acc = tk;
            phan_quyen();
        }
        private void phan_quyen()
        {
            if (acc.Chuc_vu == 2)
            {
                un_see_all_btn();
                button_So_Do_Ban.Visible = true;
                button_DS_Mon.Visible = true;
                btn_Dat_ban.Visible = true;
                btn_don_hang.Visible = true; 
            }
            else if (acc.Chuc_vu == 3)
            {
                un_see_all_btn();
                btn_Bep.Visible = true;
            }
            else if(acc.Chuc_vu == 1)
            {

            }
            else
            {
                un_see_all_btn();
            }
        }
        private void un_see_all_btn()
        {
            btn_bao_cao.Visible = false;
            btn_nhan_vien.Visible = false;
            btn_mat_hang.Visible = false;
            button_So_Do_Ban.Visible = false;
            btn_Bep.Visible = false;
            button_DS_Mon.Visible = false;
            btn_khach_hang.Visible = false;
            btn_QL_Ban_KV.Visible = false;
            btn_Dat_ban.Visible = false;
            btn_don_hang.Visible = false;
        }

        private void btn_nhan_vien_Click(object sender, EventArgs e)
        {
            reset_btn_back_color();
            btn_nhan_vien.BackColor = Color.FromArgb(0, 115, 178);
            openChildForm(new Form_Nhan_Vien());
        }

        private void btn_mat_hang_Click(object sender, EventArgs e)
        {
            reset_btn_back_color();
            btn_mat_hang.BackColor = Color.FromArgb(0, 115, 178);
            openChildForm(new Form_QL_Mon());

        }

        private void reset_btn_back_color()
        {
            foreach (Control btn in panel_slide.Controls)
            {
                btn.BackColor = Color.FromArgb(24, 37, 55);
            }
        }



        //open child form
        private Form activeForm = null;
        private void openChildForm(Form f)
        {
            panel_child_form.Controls.Clear();
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = f;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            panel_child_form.Controls.Add(f);
            panel_child_form.Tag = f;
            f.BringToFront();
            f.Show();

        }


        private void btn_doi_mk_Click(object sender, EventArgs e)
        {
            reset_btn_back_color();
            btn_doi_mk.BackColor = Color.FromArgb(0, 115, 178);
            openChildForm(new Form_Doi_Mk(acc));
        }

        private void button_So_Do_Ban_Click(object sender, EventArgs e)
        {
            reset_btn_back_color();
            button_So_Do_Ban.BackColor = Color.FromArgb(0, 115, 178);
            openChildForm(new Form_So_do_ban(acc.Ma_nv));
        }

        private void btn_tong_quan_Click(object sender, EventArgs e)
        {
            panel_child_form.Controls.Clear();
            reset_btn_back_color();
            btn_tong_quan.BackColor = Color.FromArgb(0, 115, 178);
        }

        private void btn_Bep_Click(object sender, EventArgs e)
        {
            reset_btn_back_color();
            btn_Bep.BackColor = Color.FromArgb(0, 115, 178);
            openChildForm(new Form_Bep());
        }

        private void button_DS_Mon_Click(object sender, EventArgs e)
        {
            reset_btn_back_color();
            button_DS_Mon.BackColor = Color.FromArgb(0, 115, 178);
            openChildForm(new Form_DS_Mon(-1,"Danh sách món ăn",0));
        }

        private void btn_khach_hang_Click(object sender, EventArgs e)
        {
            reset_btn_back_color();
            btn_khach_hang.BackColor = Color.FromArgb(0, 115, 178);
            openChildForm(new F_Khach_hang());
        }

        private void btn_QL_Ban_KV_Click(object sender, EventArgs e)
        {
            reset_btn_back_color();
            btn_QL_Ban_KV.BackColor = Color.FromArgb(0, 115, 178);
            openChildForm(new F_QL_Ban_va_khu_vuc());
        }

        private void btn_Dat_ban_Click(object sender, EventArgs e)
        {
            reset_btn_back_color();
            btn_Dat_ban.BackColor = Color.FromArgb(0, 115, 178);
            openChildForm(new F_Dat_ban(acc.Ma_nv));
        }

        private void btn_don_hang_Click(object sender, EventArgs e)
        {
            reset_btn_back_color();
            btn_don_hang.BackColor = Color.FromArgb(0, 115, 178);
 

            openChildForm(new F_Don_hang());
        }

        private void btn_dang_xuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_bao_cao_Click(object sender, EventArgs e)
        {
            reset_btn_back_color();
            btn_bao_cao.BackColor = Color.FromArgb(0, 115, 178);
            openChildForm(new F_Bao_cao());
        }
    }
}
