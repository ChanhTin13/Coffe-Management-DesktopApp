using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Co_so.DTO
{
    public class MenuDTO
    {
        private int id;
        private string ten_mon;
        private int id_loai;
        private int gia;
        private int sl_ton;
        private string hinh;

        public MenuDTO(int id, string ten_mon, int id_loai, int gia, int sl_ton, string hinh)
        {
            this.id = id;
            this.ten_mon = ten_mon;
            this.id_loai = id_loai;
            this.gia = gia;
            this.sl_ton = sl_ton;
            this.hinh = hinh;
        }
        public MenuDTO(DataRow r)
        { 
            this.id = (int)r["id"]; 
            this.ten_mon = r["Tên món"].ToString(); 
            this.id_loai = (int)r["ma_loai"];
            this.gia = (int)r["Giá"]; 
            this.sl_ton = (int)r["Số lượng tồn"]; 
            this.hinh = r["Hình"].ToString() ;
        }

        public int Id { get => id; set => id = value; }
        public string Ten_mon { get => ten_mon; set => ten_mon = value; }
        public int Id_loai { get => id_loai; set => id_loai = value; }
        public int Gia { get => gia; set => gia = value; }
        public int Sl_ton { get => sl_ton; set => sl_ton = value; }
        public string Hinh { get => hinh; set => hinh = value; }
    }
}
