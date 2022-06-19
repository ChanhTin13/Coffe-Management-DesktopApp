using QuanLyThuVien_KeKao.DAO;
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
    public partial class Form_Doi_Mk : Form
    {
        private Account_DTO tai_khoan;
        public Form_Doi_Mk(Account_DTO tk)
        {
            InitializeComponent();
            this.tai_khoan = tk;
        }

        private void pictureBox_mkc_Click(object sender, EventArgs e)
        {
            if (textEdit_mkc.Properties.UseSystemPasswordChar == true)
            {
                pictureBox_mkc.BackgroundImage = Properties.Resources.eye_icon; //mở
                textEdit_mkc.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                pictureBox_mkc.BackgroundImage = Properties.Resources.eye_closed;
                textEdit_mkc.Properties.UseSystemPasswordChar = true;

            }
        }

        private void pictureBox_MKm_Click(object sender, EventArgs e)
        {
            if (textEdit_Mat_Khau_Moi.Properties.UseSystemPasswordChar == true)
            {
                pictureBox_MKm.BackgroundImage = Properties.Resources.eye_icon; //mở
                textEdit_Mat_Khau_Moi.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                pictureBox_MKm.BackgroundImage = Properties.Resources.eye_closed;
                textEdit_Mat_Khau_Moi.Properties.UseSystemPasswordChar = true;

            }
        }

        private void pictureBox_NLMKm_Click(object sender, EventArgs e)
        {
            if (textEdit_NLMKm.Properties.UseSystemPasswordChar == true)
            {
                pictureBox_NLMKm.BackgroundImage = Properties.Resources.eye_icon; //mở
                textEdit_NLMKm.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                pictureBox_NLMKm.BackgroundImage = Properties.Resources.eye_closed;
                textEdit_NLMKm.Properties.UseSystemPasswordChar = true;

            }
        }

        private void btn_Doi_mk_Click(object sender, EventArgs e)
        {
            QL_Doi_Mat_Khau.Thuc_Thi.Doi_Mat_Khau(tai_khoan.Ma_nv, textEdit_mkc.Text, textEdit_Mat_Khau_Moi.Text, textEdit_NLMKm.Text);
        }
    }
}
