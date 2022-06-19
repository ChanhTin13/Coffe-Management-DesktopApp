using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Co_so.DTO
{
    public class KhuVucDTO
    {
        private int id;
        private string ten_khu_vuc;
        public KhuVucDTO(DataRow r)
        {
            this.id = (int)r["id"];
            this.ten_khu_vuc = r["Tên khu vực"].ToString(); 
        } 

        public KhuVucDTO(int id, string ten_khu_vuc)
        {
            this.id = id;
            this.ten_khu_vuc = ten_khu_vuc;
        }

        public int Id { get => id; set => id = value; }
        public string Ten_khu_vuc { get => ten_khu_vuc; set => ten_khu_vuc = value; }
    }
}
