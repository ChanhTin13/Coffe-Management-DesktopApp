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
    public class QL_Nhan_Vien
    {
        private static QL_Nhan_Vien thuc_Thi;

        public static QL_Nhan_Vien Thuc_Thi
        {
            get
            {
                if (thuc_Thi == null)
                {
                    thuc_Thi = new QL_Nhan_Vien();
                }
                return thuc_Thi;
            }
        }

        //public bool Check_Nhan_Vien(string ma_NV)
        //{
        //    int x;
        //    x = (int)DataProvider.Thuc_Thi.ExcuteScalar("select count(*) from NHAN_VIEN where id like @ma_NV ", new object[] { ma_NV });
        //    return x > 0;
        //}

        public DataTable Load_NV()
        {
            string query = "SHOW_NHAN_VIEN";
            return DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query);
        }

        public void Them_Nhan_Vien(string Ho_ten, int Chuc_vu, string sdt, bool Gioi_tinh)
        {
            string query = " THEM_NHAN_VIEN @Ho_ten , @Chuc_vu , @sdt , @Gioi_tinh ";
            DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query, new object[] { Ho_ten, Chuc_vu, sdt, Gioi_tinh });
            MessageBox.Show("Thêm thành công", "Insert Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Sửa
        public void Sua_Nhan_Vien(int id, string Ho_ten, int Chuc_vu, string sdt, bool gioi_tinh)
        {
            string query = " SUA_NHAN_VIEN  @id , @Ho_ten , @Chuc_vu , @sdt , @gioi_tinh ";
            DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query, new object[] { id, Ho_ten, Chuc_vu, sdt, gioi_tinh });
            MessageBox.Show("Sửa thành công", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Xóa
        public void Xoa_Nhan_Vien(int id)
        {
            string query = " delete Nhan_vien where id= @Ma_nv ";
            DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query, new object[] { id });

            MessageBox.Show("Xóa thành công", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
