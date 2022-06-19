using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Co_so.DTO
{
    public class Pdb_DTO
    {
        private int id_phieu;
        private int id_ban;
        private string ten_kv;
        private string sdt;
        private string ten_ban;
        private DateTime ngay_nhan;

        public Pdb_DTO(int id_phieu, int id_ban, string ten_kv, string sdt, string ten_ban, DateTime ngay_nhan)
        {
            this.id_phieu = id_phieu;
            this.id_ban = id_ban;
            this.ten_kv = ten_kv;
            this.sdt = sdt;
            this.ten_ban = ten_ban;
            this.ngay_nhan = ngay_nhan;
        }

        public Pdb_DTO(DataRow r)
        {
            this.id_phieu = (int)r["id_phieu"]; ;
            this.id_ban = (int)r["id_ban"]; ;
            this.ten_kv = r["ten_khu_vuc"].ToString(); ;
            this.sdt = r["sdt"].ToString(); ;
            this.ten_ban = r["ten_ban"].ToString(); ;
            this.ngay_nhan = (DateTime)r["ngay_hen_nhan"] ;

        }
        public int Id_phieu { get => id_phieu; set => id_phieu = value; }
        public int Id_ban { get => id_ban; set => id_ban = value; }
        public string Ten_kv { get => ten_kv; set => ten_kv = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Ten_ban { get => ten_ban; set => ten_ban = value; }
        public DateTime Ngay_nhan { get => ngay_nhan; set => ngay_nhan = value; }
    }
}
