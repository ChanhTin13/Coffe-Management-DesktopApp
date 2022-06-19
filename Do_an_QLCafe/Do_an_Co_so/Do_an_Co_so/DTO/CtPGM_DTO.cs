using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Co_so.DTO
{
    public class CtPGM_DTO
    {
        private int id_phieu_goi_mon;
        private int id_mon;
        private string ten_mon;
        private string noi_dung;
        private int sl;

        public CtPGM_DTO(int id_phieu_goi_mon, int id_mon, string ten_mon, string noi_dung, int sl)
        {
            this.id_phieu_goi_mon = id_phieu_goi_mon;
            this.id_mon = id_mon;
            this.ten_mon = ten_mon;
            this.noi_dung = noi_dung;
            this.sl = sl;
        }
        public CtPGM_DTO(DataRow r)
        { 
            this.id_phieu_goi_mon = (int)r["id_phieu"]; 
            this.id_mon = (int)r["id_mon"];
            this.ten_mon = r["ten_mon"].ToString();
            this.noi_dung = r["noi_dung"].ToString();
            this.sl = (int)r["so_luong"];
        }

        public int Id_phieu_goi_mon { get => id_phieu_goi_mon; set => id_phieu_goi_mon = value; }
        public int Id_mon { get => id_mon; set => id_mon = value; }
        public string Ten_mon { get => ten_mon; set => ten_mon = value; }
        public string Noi_dung { get => noi_dung; set => noi_dung = value; }
        public int Sl { get => sl; set => sl = value; }
    }
}
