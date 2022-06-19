using Do_an_Co_so.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_KeKao.DAO
{
    public class QL_Danh_Sach_Den
    {
        private static QL_Danh_Sach_Den thuc_Thi;

        public static QL_Danh_Sach_Den Thuc_Thi
        {
            get
            {
                if (thuc_Thi == null)
                {
                    thuc_Thi = new QL_Danh_Sach_Den();
                }
                return thuc_Thi;
            }
        }
        

        public DataTable ShowData()
        {
            string query = "SHOW_DANH_SACH_DEN";
            return DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query);
        }
        public DataTable Loai_Khoi_Danh_Sach_Den(string parameter )
        {
            string query = " LOAI_KHOI_DANH_SACH_DEN  @X  ";
            return DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query, new object[] { parameter });
        }
        public DataTable Xoa_Het_DS_Den()
        {
            string query = " XOA_DS_DEN ";
            return DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query);
        }
    }
}
