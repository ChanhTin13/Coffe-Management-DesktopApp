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

namespace Do_an_Co_so.Custom_Component
{
    public partial class Cus_DonHang : UserControl
    {
        public Cus_DonHang()
        {
            InitializeComponent();
        }

        public Cus_DonHang(string ten_kv, string ten_ban, int tong_tien, int id_phieu_goi_mon, int id_ban, int id_phieu_dat_ban)
        {
            this.ten_kv = ten_kv;
            this.ten_ban = ten_ban;
            this.tong_tien = tong_tien;
            this.id_phieu_goi_mon = id_phieu_goi_mon;
            this.id_ban = id_ban;
            this.id_phieu_dat_ban = id_phieu_dat_ban;
        }

        private string ten_kv;
        private string ten_ban;
        private int tong_tien;
        private int id_phieu_goi_mon;
        private int id_ban;
        private int id_phieu_dat_ban;

        public string Ten_kv { get { return label_ten_kv.Text; } set { ten_kv = value; label_ten_kv.Text = value; } }
        public string Ten_ban { get { return label_ban.Text; } set { ten_ban = value; label_ban.Text = value; } }
        public int Tong_tien
        {
            get { return Int32.Parse(label_tong_tien.Text); }
            set
            {
                tong_tien = value;
                CultureInfo culture = new CultureInfo("vi-VN"); 
                label_tong_tien.Text = value.ToString("c", culture);
            }
        }
        public int Id_phieu_goi_mon { get => id_phieu_goi_mon; set => id_phieu_goi_mon = value; }
        public int Id_ban { get => id_ban; set => id_ban = value; }
        public int Id_phieu_dat_ban { get => id_phieu_dat_ban; set => id_phieu_dat_ban = value; }

        public event EventHandler Chuyen_ban = null;
        private void custom_btn1_Click(object sender, EventArgs e)
        {
            Chuyen_ban?.Invoke(this, e);
        }
        public event EventHandler Thanh_toan = null;
        private void btn_thanh_toan_Click(object sender, EventArgs e)
        {
            Thanh_toan?.Invoke(this, e);
        }
        public event EventHandler Gop_ban = null;
        private void btn_gop_ban_Click(object sender, EventArgs e)
        {
            Gop_ban?.Invoke(this, e);
        }

        private void btn_chuyen_ban_Click(object sender, EventArgs e)
        {
            try
            {
                Form f = new F_Chon_ban_de_chuyen(id_ban, id_phieu_dat_ban, id_phieu_goi_mon);
                f.ShowDialog();
                f.Close();
                custom_btn1_Click(sender, e);
            }
            catch (Exception) { }
        }
    }
}
