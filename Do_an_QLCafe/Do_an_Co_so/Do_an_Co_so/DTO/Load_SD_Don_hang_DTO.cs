using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Co_so.DTO
{
    public class Load_SD_Don_hang_DTO
    {
        private string ten_kv;
        private string ten_ban;
        private int tong_tien;
        private int id_phieu_goi_mon;
        private int id_ban;
        private int id_phieu_dat_ban;

        public Load_SD_Don_hang_DTO(string ten_kv, string ten_ban, int tong_tien, int id_phieu_goi_mon, int id_ban, int id_phieu_dat_ban)
        {
            this.ten_kv = ten_kv;
            this.ten_ban = ten_ban;
            this.tong_tien = tong_tien;
            this.id_phieu_goi_mon = id_phieu_goi_mon;
            this.id_ban = id_ban;
            this.id_phieu_dat_ban = id_phieu_dat_ban;
        }
        public Load_SD_Don_hang_DTO(DataRow r)
        { 
            this.ten_kv = r["ten_khu_vuc"].ToString();  
            this.ten_ban = r["ten_ban"].ToString();  
            this.tong_tien = (int)r["tt"]; ;
            this.id_phieu_goi_mon = (int)r["id_phieu_goi_mon"]; ;
            this.id_ban = (int)r["id_ban"]; ;
            this.id_phieu_dat_ban = (int)r["id_phieu_dat_ban"]; ;
        }

        public string Ten_kv { get => ten_kv; set => ten_kv = value; }
        public string Ten_ban { get => ten_ban; set => ten_ban = value; }
        public int Tong_tien { get => tong_tien; set => tong_tien = value; }
        public int Id_phieu_goi_mon { get => id_phieu_goi_mon; set => id_phieu_goi_mon = value; }
        public int Id_ban { get => id_ban; set => id_ban = value; }
        public int Id_phieu_dat_ban { get => id_phieu_dat_ban; set => id_phieu_dat_ban = value; }
    }
}
