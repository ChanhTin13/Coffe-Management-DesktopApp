
using QuanLyThuVien_KeKao.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Co_so.DAO
{
    public class QL_Dang_Nhap
    {
        private static QL_Dang_Nhap thuc_Thi;

        public static QL_Dang_Nhap Thuc_Thi
        {
            get
            {
                if (thuc_Thi == null)
                {
                    thuc_Thi = new QL_Dang_Nhap();
                }
                return thuc_Thi;
            }
        }

        private QL_Dang_Nhap() { }

        public Account_DTO Lay_Tai_Khoan_Qua_Sdt(string sdt,string mk)
        {
            string query = " select * from tai_khoan as a, Nhan_vien as b where a.MA_NV=b.id and a.sdt like @sdt and a.mat_khau like @mk ";
            DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query, new object[] { sdt , mk });

            foreach (DataRow item in data.Rows)
            {
                return new Account_DTO(item);
            }
            return null;
        } 

        public bool DangNhap(object[] parameter = null)
        {
            string query = "select * from tai_khoan where sdt like @sdt and mat_khau like @mat_khau"; // Kiểm tra tài khoản

            DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query, parameter);

            return data.Rows.Count == 1; 
        }
        //public int Get_type_ACC(object[] parameter = null)
        //{
        //    string query = "select TYPE_ACC from tai_khoan where sdt like @sdt and mat_khau like @mat_khau ";
        //    int type_acc;
        //    type_acc = (int)DataProvider.Thuc_Thi.ExcuteScalar(query, parameter);
        //    //Get_Type_Acc.Thuc_Thi.Get_Type(a);
        //    return type_acc;
        //}

         
    }
}



