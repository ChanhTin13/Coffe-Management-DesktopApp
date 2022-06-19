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
    public partial class F_Chon_ban_de_chuyen : Form
    {
        private int id_ban;
        private int id_phieu_dat_ban;
        private int id_phieu_goi_mon;
        public F_Chon_ban_de_chuyen(int id_b, int id_pdb, int id_pgm)
        {
            id_ban = id_b;
            id_phieu_dat_ban = id_pdb;
            id_phieu_goi_mon = id_pgm;
            InitializeComponent();
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

        private void custom_btn1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbx_ban.SelectedIndex != -1)
                {
                    DialogResult dlr = MessageBox.Show("Bạn muốn chắc muốn chuyển bàn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlr == DialogResult.Yes)
                    {
                        DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("chuyen_ban @id_ban , @Id_phieu_dat_ban , @Id_phieu_goi_mon , @id_ban_cu ",
                            new object[] { (int)cbx_ban.SelectedValue, id_phieu_dat_ban, id_phieu_goi_mon , id_ban });

                        MessageBox.Show("Chuyển bàn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                " and ban.trang_thai = 0 " +
                " and ban.id != @id_ban ", new object[] { (int)cbx_kv.SelectedValue, id_ban });

                    cbx_ban.DataSource = dt;
                    cbx_ban.DisplayMember = "ten_ban";
                    cbx_ban.ValueMember = "id";
                    cbx_ban.SelectedIndex = 0;
                }

            }
            catch (Exception) { }
        }
    }
}
