using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Co_so.DTO
{
    public class Goi_monDTO
    {
        private int id_phieu_goi_mon;
        private int id_mon;
        private string ten_mon;
        private int sl;
        private int gia;
        private string noi_dung;
        private int sl_ton;
        private string hinh;
        private bool da_xong;
        private bool con_hang;
        public Goi_monDTO(int id_phieu_goi_mon, int id_mon, string ten_mon, int sl, int gia, string noi_dung, int sl_ton, string hinh, bool da_xong, bool con_hang)
        {
            this.id_phieu_goi_mon = id_phieu_goi_mon;
            this.id_mon = id_mon;
            this.ten_mon = ten_mon;
            this.sl = sl;
            this.gia = gia;
            this.noi_dung = noi_dung;
            this.sl_ton = sl_ton;
            this.hinh = hinh;
            this.Da_xong = da_xong;
            this.Con_hang = con_hang;
        }
        public Goi_monDTO(DataRow r)
        { 
            this.id_phieu_goi_mon = (int)r["id_phieu"];
            this.id_mon = (int)r["id_mon"];
            this.ten_mon = r["ten_mon"].ToString(); 
            this.sl = (int)r["so_luong"];
            this.gia = (int)r["gia"];
            this.noi_dung = r["noi_dung"].ToString(); 
            this.Sl_ton = (int)r["so_luong_ton"];
            this.hinh = r["hinh"].ToString();
            this.Da_xong = (bool)r["da_xong"];
            this.Con_hang = (bool)r["con_hang"];
        }

        public int Id_phieu_goi_mon { get => id_phieu_goi_mon; set => id_phieu_goi_mon = value; }
        public int Id_mon { get => id_mon; set => id_mon = value; }
        public string Ten_mon { get => ten_mon; set => ten_mon = value; }
        public int Sl { get => sl; set => sl = value; }
        public int Gia { get => gia; set => gia = value; }
        public string Noi_dung { get => noi_dung; set => noi_dung = value; }
        public int Sl_ton { get => sl_ton; set => sl_ton = value; }
        public string Hinh { get => hinh; set => hinh = value; }
        public bool Da_xong { get => da_xong; set => da_xong = value; }
        public bool Con_hang { get => con_hang; set => con_hang = value; }
    }
}
