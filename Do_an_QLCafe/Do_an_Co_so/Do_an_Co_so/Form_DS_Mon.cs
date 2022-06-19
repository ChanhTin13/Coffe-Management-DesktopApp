using Do_an_Co_so.Component;
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
    public partial class Form_DS_Mon : Form
    {
        private int ma_nv;
        public Form_DS_Mon(int id_b, string ten_b,int manv)
        {
            InitializeComponent();
            this.ma_nv = manv;
            _id_ban = id_b;
            _ten_ban = ten_b;
            if (_id_ban == -1)
            {
                btn_thanh_toan.Enabled = false;
                btn_luu_don.Enabled = false;
                label_ten_ban.Location = new Point(50, 3);
            }
            
            Load_ban_Id_phieu_goi_Bill();
        }
        private int _id_ban ;
        private string _ten_ban = "Bàn 3";
        private int _id_phieu_goi;
        private List<Goi_monDTO> list_goi_mon = new List<Goi_monDTO>();
        private void Load_ban_Id_phieu_goi_Bill()
        {
            try
            {
                Load_mon();
                label_ten_ban.Text = _ten_ban;
                DataTable dt = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("select * from phieu_goi_mon where thanh_toan = 0 and id_ban = @id ", new object[] { _id_ban });
                if (dt.Rows.Count > 0)
                {
                    _id_phieu_goi = (int)dt.Rows[0][0];
                    labelid_phieu.Text = "Phiếu: " + _id_phieu_goi.ToString();
                }
                else
                {
                    _id_phieu_goi = -1;
                    labelid_phieu.Text = "(Chưa có phiếu)";
                }
                list_goi_mon = new List<Goi_monDTO>();



                DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("load_bill_theo_id_phieu_goi @id ", new object[] { _id_phieu_goi });
                foreach (DataRow r in data.Rows)
                {
                    Goi_monDTO x = new Goi_monDTO(r);
                    list_goi_mon.Add(x);
                }

                flowLayoutPanel_goi_mon.Controls.Clear();
                foreach (Goi_monDTO x in list_goi_mon)
                {
                    add_goi_mon(x.Id_mon, x.Ten_mon, x.Sl, x.Gia, x.Hinh, x.Sl_ton, x.Noi_dung, x.Da_xong, x.Sl, true);
                }
                tinh_tong_tien();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        public void addItem(int id, string ten_mon, bool het_hang, int gia, string hinh, int sl)
        {
            var menu = new Mon_an()
            {
                Id = id,
                Ten_mon = ten_mon,
                Is_Het_Hang = het_hang,
                Gia = gia,
                Hinh = hinh,
                Sl = sl
            };
            flowLayoutPanel1.Controls.Add(menu);
            menu.OnSelect += (ss, ee) =>
            {
                if (het_hang != true)
                { 
                    foreach (Cus_goi_mon item in flowLayoutPanel_goi_mon.Controls)
                    {
                        if (item.Id == id)
                        { 
                            //if (item.Sl != 0)
                            //{
                            //    if (item.Sl < sl)
                            //    {
                            //        item.Sl = item.Sl + 1;
                            //        tinh_tong_tien();
                            //        return;
                            //    }
                            //}
                            return;
                        }
                    }
                    add_goi_mon(id, ten_mon, 1, gia, hinh, sl, "", false, 1, true);
                    tinh_tong_tien();
                } 
                //MessageBox.Show(sl.ToString());
            };
        }
        int tt;
        private void tinh_tong_tien()
        {
            tt = 0;
            foreach (Cus_goi_mon item in flowLayoutPanel_goi_mon.Controls)
            {
                //int xx = Convert.ToInt32(item.num_sl.Value) * item.Gia;
                int xx = Convert.ToInt32(item.Sl) * item.Gia;
                tt = tt + xx;
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            label_tong_tien.Text = tt.ToString("c", culture);
        }
        public void add_goi_mon(int id, string ten_mon, int sl, int gia, string hinh, int sl_max, string nd, bool da_xong, int min_values, bool con_hang)
        {
            var goi_mon = new Cus_goi_mon()
            {
                Id = id,
                Ten_mon = ten_mon,

                Gia = gia,
                Hinh = hinh,
                Sl_max = sl_max,
                Noi_dung = nd,
                Sl = sl,
                Da_xong = da_xong,
                min_values = min_values,
                Con_hang = con_hang
            };
            flowLayoutPanel_goi_mon.Controls.Add(goi_mon);
            goi_mon.OnSelect += (ss, ee) =>
            {
                tinh_tong_tien();
            };
        }
        private void Load_mon()
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();
                List<MenuDTO> ds_ban = DS_Mon_DAO.Thuc_Thi.Load_DS_Mon();
                foreach (MenuDTO x in ds_ban)
                {
                    bool con_hang = x.Sl_ton > 0 ? false : true;
                    addItem(x.Id, x.Ten_mon, con_hang, x.Gia, x.Hinh, x.Sl_ton);
                }
            }
            catch (Exception) { }

        }

        private void custom_Textbox1__TextChanged(object sender, EventArgs e)
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();
                List<MenuDTO> ds_ban = DS_Mon_DAO.Thuc_Thi.Tim_mon_theo_ten(custom_Textbox1.Texts);
                foreach (MenuDTO x in ds_ban)
                {
                    bool con_hang = x.Sl_ton > 0 ? false : true;
                    addItem(x.Id, x.Ten_mon, con_hang, x.Gia, x.Hinh, x.Sl_ton);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private struct luu_phieu
        { 
            public int id_monn;
            public int sll;
            public string noi_dung;
            public int sl_thay_doi;
            public luu_phieu(  int id_mon, int sl,string nd,int slm)
            { 
                this.id_monn = id_mon;
                this.sll = sl;
                this.noi_dung = nd;
                this.sl_thay_doi = slm;
            }
        }
        private void btn_luu_don_Click(object sender, EventArgs e)
        {
            try
            {
                List<Goi_monDTO> list = new List<Goi_monDTO>();
                foreach (Cus_goi_mon item in flowLayoutPanel_goi_mon.Controls)
                {
                    Goi_monDTO x = new Goi_monDTO(_id_phieu_goi, item.Id, item.Ten_mon, item.Sl, item.Gia, item.Noi_dung, 100, item.Hinh, item.Da_xong, item.Con_hang);
                    list.Add(x);
                }
                ///list_goi_mon = list;
                if (_id_phieu_goi != -1)
                {
                    if (list.Count == 0)
                    {
                        MessageBox.Show("Danh sách món trống,lưu cmm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        List<luu_phieu> cc = new List<luu_phieu>();
                        foreach (Goi_monDTO i in list)
                        {
                            int iii = 0;
                            foreach (var j in list_goi_mon)
                            {
                                if (i.Id_mon == j.Id_mon)
                                {
                                    cc.Add(new luu_phieu(i.Id_mon, i.Sl, i.Noi_dung ,i.Sl - j.Sl)); iii++; break;
                                }
                            }
                            if (iii == 0)
                            {
                                cc.Add(new luu_phieu(i.Id_mon, i.Sl, i.Noi_dung, 0));
                            }
                        }


                        foreach (var x in cc)
                        {
                            DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("luu_phieu_goi_mon @id_phieu , @id_mon , @so_luong , @noi_dung , @sl_td ",
                            new object[] { _id_phieu_goi, x.id_monn, x.sll, x.noi_dung, x.sl_thay_doi });
                        }

                        MessageBox.Show("Lưu đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_ban_Id_phieu_goi_Bill();
                    }

                }
                else
                {
                      if (list.Count == 0)
                    {
                        MessageBox.Show("Danh sách món trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("lap_phieu_goi_mon @id_nv , @id_ban ",
                            new object[] { ma_nv, _id_ban });
                        _id_phieu_goi = (int)DataProvider.Thuc_Thi.ExcuteScalar("select max(id) from phieu_goi_mon");
                        foreach (Goi_monDTO x in list)
                        {
                            DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("luu_phieu_goi_mon @id_phieu , @id_mon , @so_luong , @noi_dung , @sl_td ",
                                new object[] { _id_phieu_goi, x.Id_mon, x.Sl, x.Noi_dung , 0 });
                        }
                        MessageBox.Show("Tạo và lưu đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_ban_Id_phieu_goi_Bill();
                    }

                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }

        private void btn_thanh_toan_Click(object sender, EventArgs e)
        {
            try
            {


                if (_id_phieu_goi == -1)
                {
                    MessageBox.Show("Bàn này chưa có đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (list_goi_mon.Count == 0)
                {
                    MessageBox.Show("Bàn này chưa gọi món", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Form f = new F_Thanh_toan(_id_phieu_goi, _id_ban,tt);
                    f.ShowDialog();
                    f.Close();
                    Load_ban_Id_phieu_goi_Bill();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
    }
}
