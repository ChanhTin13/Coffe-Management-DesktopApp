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
    public partial class Cus_Bep : UserControl
    {
        public Cus_Bep()
        {
            InitializeComponent();
        }

        private int id_phieu_goi_mon;
        private int id_mon;
        private string ten_mon;
        private string noi_dung;
        private string sl;
        private Size kich_thuoc;
        public Size Kich_thuoc { get => kich_thuoc; set { kich_thuoc = value; this.Size = kich_thuoc; } }
        private Point vi_tri;
        public Point Vi_tri { get => vi_tri; set { vi_tri = value; this.Location = vi_tri; } }
        public int Id_phieu_goi_mon { get => id_phieu_goi_mon; set => id_phieu_goi_mon = value; }
        public int Id_mon { get => id_mon; set => id_mon = value; }
        public string Ten_mon { get { return label_ten_mon.Text; } set { ten_mon = value; label_ten_mon.Text = value; } }
        public string Noi_dung { get { return label_noi_dung.Text; } set { noi_dung = value; label_noi_dung.Text = value; } }
        public string Sl { get { return label_sl.Text; } set { sl = value; label_sl.Text = value.ToString(); } }

        public event EventHandler OnSelect = null;

        private void btn_tra_mon_Click(object sender, EventArgs e)
        {
            DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("update chi_tiet_phieu_goi_mon set da_xong = 1 where id_phieu= @id_phieu and id_mon = @id_mon "
                , new object[] { id_phieu_goi_mon, id_mon });
            MessageBox.Show("Đã trả món", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Cus_Bep_Load(sender, e);
        }

        private void btn_het_hang_Click(object sender, EventArgs e)
        { 
            DialogResult dlr = MessageBox.Show("Bạn có chắc không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes) {
                DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("update chi_tiet_phieu_goi_mon set so_luong = 0, con_hang = 0 where id_phieu= @id_phieu and id_mon = @id_mon "
                , new object[] { id_phieu_goi_mon, id_mon });
                DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("update menu set so_luong_ton = 0 where id= @id_mon "
                , new object[] { id_mon });
                MessageBox.Show("Đã báo hết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cus_Bep_Load(sender, e);
            } 
            
        }

        private void Cus_Bep_Load(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }
    }
}
