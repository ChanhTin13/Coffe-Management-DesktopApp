using Do_an_Co_so.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Co_so.DAO
{
    public class QL_Ban
    {
        private static QL_Ban thuc_Thi;

        public static QL_Ban Thuc_Thi
        {
            get
            {
                if (thuc_Thi == null)
                {
                    thuc_Thi = new QL_Ban();
                }
                return thuc_Thi;
            }
        }
        private QL_Ban() { }

        public static int TableWidth = 80; 

        public List<KhuVucDTO> Load_Khu_vuc()
        {
            List<KhuVucDTO> ds_KhuVuc = new List<KhuVucDTO>();

            DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("select id, ten_khu_vuc as N'Tên khu vực' from khu_vuc" );
            foreach (DataRow r in data.Rows)
            {
                KhuVucDTO x = new KhuVucDTO(r);
                ds_KhuVuc.Add(x);
            }

            return ds_KhuVuc;
        }

        public List<BanDTO> Load_Ban_Theo_Ten_Khu_Vuc(string ten_khu_vuc)
        {
            List<BanDTO> ds_ban = new List<BanDTO>();

            DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("select ban.id, ten_ban as N'Tên bàn', so_ghe as N'Số ghế', trang_thai as N'Trạng thái', khu_vuc as N'Khu vực'  from ban,khu_vuc where ban.khu_vuc=khu_vuc.id and ten_khu_vuc= @id_kv ", new object[] { ten_khu_vuc });
            foreach(DataRow r in data.Rows)
            {
                BanDTO x = new BanDTO(r);
                ds_ban.Add(x);
            } 
            return ds_ban;
        }
        public List<BanDTO> Load_Ban_Theo_id_Khu_Vuc(int id_khu_vuc)
        {
            List<BanDTO> ds_ban = new List<BanDTO>();

            DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("select ban.id, ten_ban as N'Tên bàn', so_ghe as N'Số ghế', trang_thai as N'Trạng thái', khu_vuc as N'Khu vực'  from ban,khu_vuc where ban.khu_vuc=khu_vuc.id and khu_vuc = @id_kv ", new object[] { id_khu_vuc });
            foreach (DataRow r in data.Rows)
            {
                BanDTO x = new BanDTO(r);
                ds_ban.Add(x);
            }
            return ds_ban;
        }

    }
}
