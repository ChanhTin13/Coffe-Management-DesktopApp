using Do_an_Co_so.DAO;
using QuanLyThuVien_KeKao.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_Co_so
{
    public partial class Form_Dang_Ky : Form
    {
        public Form_Dang_Ky()
        {
            InitializeComponent();
        }

         

        private void pictureBox_MK_Click(object sender, EventArgs e)
        {
            if (textEdit_Mat_Khau.Properties.UseSystemPasswordChar == true)
            {
                pictureBox_MK.BackgroundImage = Properties.Resources.eye_icon; //mở
                textEdit_Mat_Khau.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                pictureBox_MK.BackgroundImage = Properties.Resources.eye_closed;
                textEdit_Mat_Khau.Properties.UseSystemPasswordChar = true;

            }
        }

        private void pictureBox_NLMK_Click(object sender, EventArgs e)
        {
            if (textEdit_NLMK.Properties.UseSystemPasswordChar == true)
            {
                pictureBox_NLMK.BackgroundImage = Properties.Resources.eye_icon; //mở
                textEdit_NLMK.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                pictureBox_NLMK.BackgroundImage = Properties.Resources.eye_closed;
                textEdit_NLMK.Properties.UseSystemPasswordChar = true;

            }
        }

        public static bool IsValidPhone(string value)
        {
            string pattern = @"^-*[0-9,\.?\-?\(?\)?\ ]+$";
            return Regex.IsMatch(value, pattern);
        }
        private void button_Dang_Ky_Click(object sender, EventArgs e)
        {
            DataTable data;
            try
            {
                if (IsValidPhone(textEdit_TK.Text) == false)
                {
                    MessageBox.Show("Số điện thoại không được chứa ký tự chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                if (textEdit_MNV.Text=="")
                {
                    MessageBox.Show("Mã nhân viên không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                if (textEdit_Mat_Khau.Text != textEdit_NLMK.Text)
                {
                    MessageBox.Show("Mật khẩu nhập lại không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    return;
                }
                else
                {
                    data = QL_Dang_Ky_TK.Thuc_Thi.Dang_Ky(new object[] { textEdit_MNV.Text, textEdit_TK.Text, textEdit_Mat_Khau.Text });
                    if (data == null)
                    {
                        return;
                    }
                    else
                    {
                        this.Close();
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            } 
        }
    }
}
