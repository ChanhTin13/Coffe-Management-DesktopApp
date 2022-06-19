using Do_an_Co_so.DAO;
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
    public partial class Form_Dang_Nhap : Form
    {
        public Form_Dang_Nhap()
        {
            InitializeComponent();
            
        } 

        private void textEdit_TK_Enter(object sender, EventArgs e)
        {
            if (textEdit_TK.Text == "Số điện thoại")
            {
                textEdit_TK.Text = "";
                textEdit_TK.ForeColor = SystemColors.WindowText;
            }
        }

        private void textEdit_TK_Leave(object sender, EventArgs e)
        {
            if (textEdit_TK.Text == "")
            {
                textEdit_TK.Text = "Số điện thoại";
                textEdit_TK.ForeColor = SystemColors.ButtonShadow;
            }
        }

        private void textEdit_Mat_Khau_Enter(object sender, EventArgs e)
        {
            if (textEdit_Mat_Khau.Text == "Mật khẩu")
            {
                textEdit_Mat_Khau.Text = "";
                pictureBox_eye.BackgroundImage = Properties.Resources.eye_closed;
                textEdit_Mat_Khau.Properties.UseSystemPasswordChar = true;

                textEdit_Mat_Khau.ForeColor = SystemColors.WindowText;
            }
        }

        private void textEdit_Mat_Khau_Leave(object sender, EventArgs e)
        {

            if (textEdit_Mat_Khau.Text == "")
            {
                textEdit_Mat_Khau.Text = "Mật khẩu";
                pictureBox_eye.BackgroundImage = Properties.Resources.eye_icon;
                textEdit_Mat_Khau.Properties.UseSystemPasswordChar = false;
                textEdit_Mat_Khau.ForeColor = SystemColors.ButtonShadow;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hyperlinkLabelControl2_Click(object sender, EventArgs e)
        {
            Form_Change_Config f = new Form_Change_Config();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void hyperlinkLabelControl_quenMk_Click(object sender, EventArgs e)
        {

        }

        private void button_Dang_Nhap_Click(object sender, EventArgs e)
        {
            try { 
            string u = textEdit_TK.Text;
            string p = textEdit_Mat_Khau.Text;
            string mk = Md5_DAO.Thuc_Thi.GetHash(p);
            if (QL_Dang_Nhap.Thuc_Thi.DangNhap(new object[] { u,mk }))
            {
                Account_DTO tk = QL_Dang_Nhap.Thuc_Thi.Lay_Tai_Khoan_Qua_Sdt(u, mk);

                Admin f = new Admin(tk);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai số điện thoại hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            }
            catch (Exception ) { MessageBox.Show("Lỗi kết nối CSDL", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void pictureBox_eye_Click(object sender, EventArgs e)
        {
            if (textEdit_Mat_Khau.Properties.UseSystemPasswordChar == true)
            {
                pictureBox_eye.BackgroundImage = Properties.Resources.eye_icon; //mở
                textEdit_Mat_Khau.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                pictureBox_eye.BackgroundImage = Properties.Resources.eye_closed;
                textEdit_Mat_Khau.Properties.UseSystemPasswordChar = true;

            }
        }

        private void hyperlinkLabelControl_Dang_ky_Click(object sender, EventArgs e)
        {
            Form_Dang_Ky f = new Form_Dang_Ky();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
