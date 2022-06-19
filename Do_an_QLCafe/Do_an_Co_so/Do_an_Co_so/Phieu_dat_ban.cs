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
    public partial class Phieu_dat_ban : Form
    {
        private int ma_nv;
        public Phieu_dat_ban(int manv)
        {
            InitializeComponent();
            ma_nv = manv;
            cbx_ngay();
            load_kv();
        }
        private void cbx_ngay()
        {
            List<string> list = new List<string>();
            DateTime dt = DateTime.Today;
            for (int i = 0; i < 7; i++)
            {
                dt = DateTime.Today.AddDays(i);

                list.Add(dt.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture));
            }
            cbx_ngay_hen_nhan.DataSource = list;
            cbx_ngay_hen_nhan.SelectedIndex = 0;
        }
        private void custom_Textbox1__TextChanged(object sender, EventArgs e)
        {
            try
            { 
                DataTable dt = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("select * from khach_hang where sdt like N'%'+ @sdt +N'%' ", new object[] { txt_sdt.Texts });
                txt_makh.Texts = dt.Rows[0]["id"].ToString();
                txt_ten_kh.Texts = dt.Rows[0]["ten_kh"].ToString();
            }
            catch (Exception) { }

        }

        private void custom_btn1_Click(object sender, EventArgs e)
        {
            try
            {
                double dayss = Convert.ToInt64(cbx_ngay_hen_nhan.SelectedIndex);
                DateTime xx = DateTime.Today.AddDays(dayss); 
                DateTime d1 = new DateTime(xx.Year, xx.Month, xx.Day, (int)num_gio.Value, (int)num_phut.Value, 0);
                 
                if (txt_makh.Texts == "")
                {
                    MessageBox.Show("Mã khách hàng không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cbx_ban.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (DateTime.Compare(DateTime.Now, d1) >=0)
                {
                    MessageBox.Show("Thời gian không hợp lệ: "+ DateTime.Now+" > "+ d1, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string ngay_gio = cbx_ngay_hen_nhan.Text + " " + num_gio.Value + ":" + num_phut.Value + ":00 ";
                    int check_time = (int)DataProvider.Thuc_Thi.ExcuteScalar("kt_dat_ban @thoi_gian , @id_ban ",
                        new object[] { ngay_gio, (int)cbx_ban.SelectedValue });
                    if (check_time > 0)
                    {
                        MessageBox.Show("Trùng thời gian đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(" Dat_ban @ma_nv , @ma_kh , @ngay_hen_nhan , @id_ban   ",
                            new object[] { ma_nv, txt_makh.Texts, ngay_gio, (int)cbx_ban.SelectedValue });

                        MessageBox.Show("Tạo phiếu đặt bàn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        void load_kv()
        {
            DataTable dt = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("select * from khu_vuc ");

            cbx_kv.DataSource = dt;
            cbx_kv.DisplayMember = "ten_khu_vuc";
            cbx_kv.ValueMember = "id";
            cbx_kv.SelectedIndex = -1;
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (cbx_kv.SelectedIndex != -1)
                {
                    DataTable dt = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("select ban.id,ban.ten_ban " +
                " from khu_vuc,ban where ban.khu_vuc=khu_vuc.id and ban.khu_vuc = @id ", new object[] { (int)cbx_kv.SelectedValue });

                    cbx_ban.DataSource = dt;
                    cbx_ban.DisplayMember = "ten_ban";
                    cbx_ban.ValueMember = "id";
                    cbx_ban.SelectedIndex = 0;
                }

            }
            catch (Exception) { }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txt_sdt.Texts = "";
            txt_makh.Texts = "";
            txt_ten_kh.Texts = "";
            cbx_ngay_hen_nhan.SelectedIndex = 0;
            cbx_kv.SelectedIndex = -1;
            cbx_ban.SelectedIndex = -1;
        }
    }
}
