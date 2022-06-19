using Do_an_Co_so.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Co_so.DAO
{
    public class DS_Mon_DAO
    {
        private static DS_Mon_DAO thuc_Thi; 
        public static DS_Mon_DAO Thuc_Thi
        {
            get
            {
                if (thuc_Thi == null)
                {
                    thuc_Thi = new DS_Mon_DAO();
                }
                return thuc_Thi;
            }
        }

        public List<MenuDTO> Load_DS_Mon()
        {
            List<MenuDTO> xx = new List<MenuDTO>(10000);
            DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("select a.id, ten_mon as N'Tên món',a.ma_loai, gia as N'Giá',so_luong_ton as N'Số lượng tồn', hinh as N'Hình' " +
                " from menu as a, loai as b where a.ma_loai=b.id");
            foreach (DataRow r in data.Rows)
            {
                MenuDTO x = new MenuDTO(r);
                xx.Add(x);
            }
            return xx; 
        }
        public List<MenuDTO> Tim_mon_theo_ten(string ten_mon)
        {
            List<MenuDTO> xx = new List<MenuDTO>(10000);
            DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("select a.id, ten_mon as N'Tên món',a.ma_loai, gia as N'Giá',so_luong_ton as N'Số lượng tồn', hinh as N'Hình' " +
                " from menu as a, loai as b where a.ma_loai=b.id and a.ten_mon like N'%'+  @ten_mon +N'%' ", new object[] { ten_mon});
            foreach (DataRow r in data.Rows)
            {
                MenuDTO x = new MenuDTO(r);
                xx.Add(x);
            }
            return xx;
        }

    }
}
