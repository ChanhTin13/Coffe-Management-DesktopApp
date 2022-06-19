using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Co_so.DTO
{
    public class BanDTO
    {
        private int id;
        private string ten_ban;
        private int so_ghe;
        private bool trang_thai;
        private int khu_vuc;

        public BanDTO(int id, string ten_ban, int so_ghe, bool trang_thai, int khu_vuc)
        {
            this.id = id;
            this.ten_ban = ten_ban;
            this.so_ghe = so_ghe;
            this.trang_thai = trang_thai;
            this.khu_vuc = khu_vuc;
        }
        public BanDTO(DataRow r)
        {
            this.id = (int)r["id"];
            this.ten_ban = r["Tên bàn"].ToString();
            this.so_ghe = (int)r["Số ghế"];
            this.trang_thai = (bool)r["Trạng thái"];
            this.khu_vuc = (int)r["Khu vực"];
        }

        public int Id { get => id; set => id = value; }
        public string Ten_ban { get => ten_ban; set => ten_ban = value; }
        public int So_ghe { get => so_ghe; set => so_ghe = value; }
        public bool Trang_thai { get => trang_thai; set => trang_thai = value; }
        public int Khu_vuc { get => khu_vuc; set => khu_vuc = value; }
    }
}
