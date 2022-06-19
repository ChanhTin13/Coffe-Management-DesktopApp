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
    public partial class F_Bao_cao : Form
    {
        public F_Bao_cao()
        {
            InitializeComponent();
            Load_chart1();
            Load_chart2();
            dtgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv1.DataSource= DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("select id,ma_phieu as N'Mã phiếu gọi món', ngay_thanh_toan as N'Ngày thanh toán',tong_tien as N'Tổng tiền' from hoa_don order by ngay_thanh_toan desc");
        }
        private struct top_mon_ban_chay
        {
            public string ten_mon;
            public int sl;
            public top_mon_ban_chay(DataRow r)
            {
                ten_mon =  r["ten_mon"].ToString();
                sl = (int)r["SL"];
            } 
        }
        private struct kh
        {
            public string tkh;
            public int dtl;
            public kh(DataRow r)
            {
                tkh = r["ten_kh"].ToString();
                dtl = (int)r["diem_tich_luy"];
            }
        }
        void Load_chart1()
        {
            string q = " top_10_mon_ban_chay ";
            DataTable dt = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(q);
            foreach (DataRow item in dt.Rows)
            {
                top_mon_ban_chay x = new top_mon_ban_chay(item);
                chart1.Series["Top 10 món bán chạy"].Points.AddXY(x.ten_mon, x.sl);
            }
        }
        void Load_chart2()
        {
            int i = 0;
            string q = "select ten_kh,diem_tich_luy from khach_hang order by diem_tich_luy desc";
            DataTable dt = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(q);
            foreach (DataRow item in dt.Rows)
            {
                kh x = new kh(item);
                chart2.Series["Top 10 khách hàng có ĐTL cao nhất"].Points.AddXY(x.tkh, x.dtl);
                chart2.Series["Top 10 khách hàng có ĐTL cao nhất"].Points[i].Label=  x.dtl.ToString();
                i++;
            }
        }
    }
}
