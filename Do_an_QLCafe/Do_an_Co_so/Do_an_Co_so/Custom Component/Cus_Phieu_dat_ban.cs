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

namespace Do_an_Co_so.Custom_Component
{
    public partial class Cus_Phieu_dat_ban : UserControl
    {
        public Cus_Phieu_dat_ban()
        {
            InitializeComponent();
        }
        private string ten_kv;
        private string sdt;
        private string ten_ban;
        private string ngay_nhan;
        private int id_phieu;
        private int id_ban;
        public string Ten_kv { get { return label_ten_kv.Text; } set { ten_kv = value; label_ten_kv.Text = value; } }
        public string Sdt { get { return label_sdt.Text; } set { sdt = value; label_sdt.Text = value; } }
        public string Ten_ban { get { return label_ban.Text; } set { ten_ban = value; label_ban.Text = value; } }
        public string Ngay_nhan { get { return label_time.Text; } set { ngay_nhan = value; label_time.Text = value; } }

        public int Id_phieu { get => id_phieu; set => id_phieu = value; }
        public int Id_ban { get => id_ban; set => id_ban = value; }

        public event EventHandler OnSelect = null;
        private void custom_btn1_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dlr = MessageBox.Show("Bạn muốn chắc muốn hủy phiếu đặt bàn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("update phieu_dat_ban set huy = 1 where id = @id ", new object[] { id_phieu });
                custom_btn1_Click(sender, e);
            }
            }
            catch (Exception ) { }
        }

        private void btn_nhan_ban_Click(object sender, EventArgs e)
        {
            try
            {
                //int id_banxx = (int)DataProvider.Thuc_Thi.ExcuteScalar("select a.id_ban from thong_tin_dat_ban as a,ban as b where a.id_ban=b.id and id_phieu= @id ", new object[] { id_phieu });
                int check_co_ng = (int)DataProvider.Thuc_Thi.ExcuteScalar("select count(*) from ban where trang_thai = 1 and id = @id ", new object[] { id_ban });
                if (check_co_ng > 0)
                {
                    MessageBox.Show("Bàn đã có người, hãy đuổi khách đi và bạn sẽ bị trừ lương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("nhan_ban @id ", new object[] { id_phieu });
                    custom_btn1_Click(sender, e);
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
    }
}
