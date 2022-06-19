using Do_an_Co_so.DAO;
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
    public partial class Form_Gop_ban : Form
    {
        private int id_ban_cu;
        private int id_phieu_dat_ban_cu;
        private int id_phieu_goi_mon_cu;

        public Form_Gop_ban(int id_bc, int id_pdbc, int id_pgmc )
        {
            InitializeComponent();
            id_ban_cu = id_bc;
            id_phieu_dat_ban_cu = id_pdbc;
            id_phieu_goi_mon_cu = id_pgmc;

            Load_cbx();
        } 
        private void Load_cbx()
        {
            DataTable dt = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("select * from khu_vuc ");

            cbx_kv.DataSource = dt;
            cbx_kv.DisplayMember = "ten_khu_vuc";
            cbx_kv.ValueMember = "id";
            cbx_kv.SelectedIndex = -1;
        } 
        private void cbx_kv_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbx_kv.SelectedIndex != -1)
                {
                    DataTable dt = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("select ban.id,ban.ten_ban " +
                " from khu_vuc,ban " +
                " where ban.khu_vuc=khu_vuc.id " +
                " and ban.khu_vuc = @id " +
                " and ban.trang_thai = 1 " +
                " and ban.id != @id_ban ", new object[] { (int)cbx_kv.SelectedValue, id_ban_cu });

                    cbx_ban.DataSource = dt;
                    cbx_ban.DisplayMember = "ten_ban";
                    cbx_ban.ValueMember = "id";
                    cbx_ban.SelectedIndex = -1;
                }

            }
            catch (Exception) { }
        }

        private void custom_btn1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbx_ban.SelectedIndex != -1)
                { 
                    DialogResult dlr = MessageBox.Show("Bạn muốn chắc muốn gộp bàn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlr == DialogResult.Yes)
                    {
                        int id_phieu_goi_mon_moi = (int)DataProvider.Thuc_Thi.ExcuteScalar("select a.id " +
                        "from phieu_goi_mon as a,ban as b where a.id_ban=b.id and a.thanh_toan=0 and b.id= @id ", new object[] { (int)cbx_ban.SelectedValue });

                       // MessageBox.Show(id_phieu_goi_mon_moi.ToString(),id_phieu_goi_mon_moi.GetType().ToString()+"|"+ id_phieu_goi_mon_cu.GetType().ToString()+ "|" + id_ban_cu.GetType().ToString()+ "|" + id_phieu_dat_ban_cu.GetType().ToString());
                        DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(" gop_ban @id_phieu_goi_mon_moi , @id_phieu_goi_mon_cu  , @id_ban_cu , @id_phieu_dat_ban_cu  ",  
                            new object[] { id_phieu_goi_mon_moi, id_phieu_goi_mon_cu, id_ban_cu, id_phieu_dat_ban_cu });
                        

                        MessageBox.Show("Gộp bàn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            Load_cbx();
        }
    }
} 