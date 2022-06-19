using Do_an_Co_so.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien_KeKao.DAO
{
    public class QL_Dang_Ky_TK
    {
        private static QL_Dang_Ky_TK thuc_Thi;

        public static QL_Dang_Ky_TK Thuc_Thi
        {
            get
            {
                if (thuc_Thi == null)
                {
                    thuc_Thi = new QL_Dang_Ky_TK();
                }
                return thuc_Thi;
            }
        }
        private int Check_Ma_NV(object ma_NV)
        {
            string q = "select count(*) from Nhan_vien where id like " + ma_NV; // kt Ma NV co ton tai khong
            return (int)DataProvider.Thuc_Thi.ExcuteScalar(q);
        }
        private int is_Have_Account(object ma_NV)
        {
            string q = "select count(*) from tai_khoan where MA_NV like " + ma_NV; // kt NV co tai khoan chua
            return (int)DataProvider.Thuc_Thi.ExcuteScalar(q);
        }
        //private int lay_chuc_vu(object ma_NV)
        //{
        //    string q = "select Chuc_vu from Nhan_vien where id like " + ma_NV; // lấy chức vụ 
        //    return (int)DataProvider.Thuc_Thi.ExcuteScalar(q);
        //}


        public DataTable Dang_Ky(object[] parameter = null)
        { 
            int co_tk = (int)DataProvider.Thuc_Thi.ExcuteScalar("select count(*) from Nhan_vien");
            string mk = Md5_DAO.Thuc_Thi.GetHash(parameter[2].ToString());
            if (co_tk == 0)
            {
                string them_tk_boss = " tao_tk_admin @sdt , @mk "; // thêm account admin
                MessageBox.Show("Tạo tài khoản admin thành công, hãy bắt đầu quản lý quán cà phê của riêng bạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(them_tk_boss, new object[] { parameter[1], mk });

            }
            else if (Check_Ma_NV(parameter[0]) == 0)
            {
                MessageBox.Show("Mã Nhân viên không tồn tại", "Không thể xử lý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            else if (is_Have_Account(parameter[0]) == 1)
            {
                MessageBox.Show("Nhân viên này đã có tài khoản", "Không thể xử lý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            else
            {
                //int type_acc = lay_chuc_vu(parameter[0]); 

                string q = "tao_tk_nhan_vien @MA_NV , @sdt , @mat_khau "; // thêm account
                MessageBox.Show("Đăng ký tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataTable dt= DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(q, new object[] { parameter[0], parameter[1], mk  });
                return dt;
            }
        }

    }
}
