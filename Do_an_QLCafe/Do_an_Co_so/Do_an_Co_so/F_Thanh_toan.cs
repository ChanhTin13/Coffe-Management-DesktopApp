using Do_an_Co_so.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_Co_so
{
    public partial class F_Thanh_toan : Form
    {
        public F_Thanh_toan(int id_pg, int id_bannn, int ttt)
        {
            InitializeComponent();
            _id_phieu_goi = id_pg;
            _id_ban = id_bannn;
            tt = ttt;

            CultureInfo culture = new CultureInfo("vi-VN");
            label_tt.Text = tt.ToString("c", culture);
        }
        private int _id_phieu_goi;
        private int _id_ban;
        private int tt;

        private void custom_btn1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void custom_btn2_Click(object sender, EventArgs e)
        {
            DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("thanh_toan @id_phieu_goi_mon , @id_ban ", new object[] { _id_phieu_goi, _id_ban });
            MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void txt_sdt__TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("select * from khach_hang where sdt like N'%'+ @sdt +N'%' ", new object[] { txt_sdt.Texts });
                txt_makh.Texts = dt.Rows[0]["id"].ToString();
                txt_ten_kh.Texts = dt.Rows[0]["ten_kh"].ToString();
            }
            catch (Exception) { }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form f = new F_thanh_toan_momo(_id_phieu_goi, _id_ban,tt);
            f.ShowDialog();
            f.Close();
        }
    }
}
