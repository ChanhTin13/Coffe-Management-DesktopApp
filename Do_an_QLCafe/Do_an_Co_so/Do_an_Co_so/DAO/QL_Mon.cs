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
    public class QL_Mon
    {
        private static QL_Mon thuc_Thi;

        public static QL_Mon Thuc_Thi
        {
            get
            {
                if (thuc_Thi == null)
                {
                    thuc_Thi = new QL_Mon();
                }
                return thuc_Thi;
            }
        }

        public DataTable Load_Mon()
        {
            string query = "load_menu";
            return DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query);
        }
        bool check_Ten_Mon(string ten_mon)
        { 
            int x = (int)DataProvider.Thuc_Thi.ExcuteScalar("select count(*) from menu where ten_mon like @ten_mon" , new object[] { ten_mon });
            return x > 0;
        } 

        public void Them_Mon(string ten_mon, int ma_loai, int so_luong_ton, int gia)
        {

            if (check_Ten_Mon(ten_mon) == true)
            {
                MessageBox.Show("Tên  bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ;
            }
            
            string  query = "them_mon  @ten_mon , @ma_loai , @so_luong_ton , @gia ";
            DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query, new object[] {  ten_mon, ma_loai, so_luong_ton, gia });
            MessageBox.Show("Thêm món mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Sua_Mon(int id  , string ten_mon , int ma_loai , int so_luong_ton , int gia)
        { 
            string query = "sua_mon  @id  , @ten_mon , @ma_loai , @so_luong_ton , @gia ";
            DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query, new object[] { id, ten_mon,ma_loai, so_luong_ton, gia }); 
        }

        public void Xoa_Mon(int id_mon)
        { 
            int x = (int)DataProvider.Thuc_Thi.ExcuteScalar("co_the_xoa_menu @id_mon ",new object[] { id_mon });

            if (x > 0)
            {
                MessageBox.Show("Còn đơn hàng chưa thanh toán", "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return ;
            }
            else
            {
                string query = "delete menu where id = @id";
                DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query, new object[] { id_mon }); 
            }
        }


        public DataTable Load_Loai()
        { 
            return DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("select id , ten_loai as N'Tên loại' from loai");
        }

        public void Luu_loai(string ten_loai)
        {
            int check_ten_loai = (int)DataProvider.Thuc_Thi.ExcuteScalar("select count(*) from loai where ten_loai like @ten_loai ", new object[] { ten_loai });
            if(check_ten_loai > 0)
            {
                MessageBox.Show("Tên loại bị trùng, xóa loại cũ hoặc sửa lại tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = " insert into loai values ( @ten_loai ) ";
                DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query, new object[] { ten_loai });
                MessageBox.Show("Thêm loại mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Sua_loai(int id,string ten_loai)
        { 
            //int check_ten_loai = (int)DataProvider.Thuc_Thi.ExcuteScalar("select count(*) from loai where ten_loai like @ten_loai ", new object[] { ten_loai });
            //if (check_ten_loai < 1)
            //{
            //    MessageBox.Show("Không tìm thấy loại cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
                string query = " update loai set ten_loai = @ten_loai where id @id like  ";
                DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query, new object[] { ten_loai,id });
                MessageBox.Show("Sửa loại thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }
        public void Xoa_loai(string ten_loai)
        {
            int check_có_the_xoa = (int)DataProvider.Thuc_Thi.ExcuteScalar("co_the_xoa_loai @ten_loai ", new object[] { ten_loai });
            int check_ten_loai = (int)DataProvider.Thuc_Thi.ExcuteScalar("select count(*) from loai where ten_loai like @ten_loai ", new object[] { ten_loai });
             
            if (check_có_the_xoa > 0)
            {
                MessageBox.Show("Còn sản phẩm ràng buộc", "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (check_ten_loai < 1)
            {
                MessageBox.Show("Không tìm thấy", "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = " delete loai where ten_loai like  @ten_loai  ";
                DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query, new object[] { ten_loai });
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
