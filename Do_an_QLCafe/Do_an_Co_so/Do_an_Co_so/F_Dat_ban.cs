using Do_an_Co_so.Custom_Component;
using Do_an_Co_so.DAO;
using Do_an_Co_so.DTO;
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
    public partial class F_Dat_ban : Form
    {
        private int ma_nv;
        public F_Dat_ban(int ma_nvv)
        {
            InitializeComponent();
            this.ma_nv = ma_nvv;
            Load_date();
            Load_phieu(selected_date);
        }
        DateTime selected_date = DateTime.Today;
        public void add_ngay(string ngay, Point vt, double i)
        {
            var x = new Cus_date()
            {
                Ngay = ngay,
                Vi_tri = vt

            };
            panel_Khu_vuc.Controls.Add(x);
            x.OnSelect += (ss, ee) =>
            {
                DateTime xx = DateTime.Today.AddDays(i);
                DateTime d1 = new DateTime(xx.Year, xx.Month, xx.Day, 0, 0, 0);
                selected_date = d1;
                Load_phieu(selected_date);
                
            };
        }


        private Cus_date sss = new Cus_date();
        private void Load_date()
        {
            try
            {
                int vt_X = 71;
                int vt_Y = 20 + 68 + 20;
                DateTime dt = DateTime.Today;
                for (int i = 0; i < 7; i++)
                {
                    dt = DateTime.Today.AddDays(i);
                    Point vitri = new Point(vt_X, vt_Y);
                    vt_Y = vt_Y + 20 + sss.Size.Height;
                    double aaa = Convert.ToInt64(i);
                    add_ngay(dt.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture), vitri, aaa);
                } 
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
        public void add_don_dat_ban(int id_phieu, int id_ban, string ten_kv, string sdt, string ten_ban, string ngay_nhan)
        {
            var x = new Cus_Phieu_dat_ban()
            {
                Id_phieu = id_phieu,
                Id_ban = id_ban,
                Ten_kv = ten_kv,
                Sdt = sdt,
                Ten_ban = ten_ban,
                Ngay_nhan = ngay_nhan
                 
            };
            flowLayoutPanel1.Controls.Add(x);
            x.OnSelect += (ss, ee) =>
            {
                Load_phieu(selected_date);
            };
        }
        void Load_phieu(DateTime day)
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();
                List<Pdb_DTO> ds_phieu_dat_ban = new List<Pdb_DTO>();

                DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("load_phieu_dat_ban @ngay ", new object[] { day });
                foreach (DataRow r in data.Rows)
                {
                    Pdb_DTO x = new Pdb_DTO(r);
                    ds_phieu_dat_ban.Add(x);
                }
                foreach (Pdb_DTO x in ds_phieu_dat_ban)
                {
                    add_don_dat_ban(x.Id_phieu, x.Id_ban, x.Ten_kv, x.Sdt, x.Ten_ban, x.Ngay_nhan.ToShortTimeString());
                }
                 
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void custom_btn1_Click(object sender, EventArgs e)
        {
            Form f = new Phieu_dat_ban(ma_nv);
            f.ShowDialog();
            
            f.Close();
            Load_phieu(selected_date);

        }
    }
}
