using Do_an_Co_so.Custom_Component;
using Do_an_Co_so.DAO;
using Do_an_Co_so.DTO;
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
    public partial class F_Don_hang : Form
    {
        public F_Don_hang()
        {
            InitializeComponent();
            Load_don_hang();
        }
        public event EventHandler nhan_thanh_toan = null;
        private void nhan_thanh_toan_Click(object sender, EventArgs e)
        {
            nhan_thanh_toan?.Invoke(this, e);
        }
        public void add_don_hang(string ten_kv, string ten_ban, int tong_tien, int id_phieu_goi_mon, int id_ban, int id_phieu_dat_ban)
        {
            var don_hang = new Cus_DonHang()
            {
                Ten_kv = ten_kv,
                Ten_ban = ten_ban,
                Tong_tien = tong_tien,
                Id_phieu_goi_mon = id_phieu_goi_mon,
                Id_ban = id_ban,
                Id_phieu_dat_ban = id_phieu_dat_ban
            };
            flowLayoutPanel1.Controls.Add(don_hang);
            don_hang.Gop_ban += (ss, ee) =>
            { 
                Form f = new Form_Gop_ban(id_ban, id_phieu_dat_ban, id_phieu_goi_mon);
                f.ShowDialog();
                f.Close();
                Load_don_hang();
            };
            don_hang.Chuyen_ban += (ss, ee) =>
            {
                Load_don_hang();
            }; 
        }
        private void Load_don_hang()
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();
                List<Load_SD_Don_hang_DTO> ds_don = new List<Load_SD_Don_hang_DTO>();
                DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("Load_don_hang");
                foreach (DataRow r in data.Rows)
                {
                    Load_SD_Don_hang_DTO x = new Load_SD_Don_hang_DTO(r);
                    ds_don.Add(x);
                } 
                foreach (Load_SD_Don_hang_DTO x in ds_don)
                {
                    add_don_hang(x.Ten_kv, x.Ten_ban, x.Tong_tien, x.Id_phieu_goi_mon, x.Id_ban, x.Id_phieu_dat_ban);
                } 
            }
            catch (Exception) { }
        }
    }
}
