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
    public class QL_Doi_Mat_Khau
    {
        private static QL_Doi_Mat_Khau thuc_Thi;

        public static QL_Doi_Mat_Khau Thuc_Thi
        {
            get
            {
                if (thuc_Thi == null)
                {
                    thuc_Thi = new QL_Doi_Mat_Khau();
                }
                return thuc_Thi;
            }
        }

        private bool kt_mk_cu(int MA_NV, string mkc)
        {
            string query = "select count(*) from tai_khoan where MA_NV like @sdt and mat_khau like @mk ";
            
            int x=  (int)DataProvider.Thuc_Thi.ExcuteScalar(query, new object[] { MA_NV, mkc });
            if( x==1)
            {
                return true;
            }
            else
            { 
                MessageBox.Show("Mật khẩu cũ không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                return false;
            }
        }
        private bool kt_mknl(string mkm, string nlmkm)
        { 
            if(mkm != nlmkm)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public void Doi_Mat_Khau(int ma_nv, string mkc, string mkm,string nlmkm)
        {
            string mat_khau_cu = Md5_DAO.Thuc_Thi.GetHash(mkc);
            if (kt_mk_cu(ma_nv, mat_khau_cu) == true)
            {
                if (kt_mknl(mkm, nlmkm) == true)
                {
                    string mat_khau_moi = Md5_DAO.Thuc_Thi.GetHash(nlmkm);
                    string query = "update tai_khoan set mat_khau = @mat_khau where MA_NV= @ma_nv ";
                    DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query, new object[] {mat_khau_moi , ma_nv });
                    MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } 
            
        }
    }
}
