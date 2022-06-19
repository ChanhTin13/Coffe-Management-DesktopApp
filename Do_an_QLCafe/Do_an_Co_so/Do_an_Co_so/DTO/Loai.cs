using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Co_so.DTO
{
    public class Loai
    {
        private int id;
        private string ten_loai;

        public Loai(int id, string ten_loai)
        {
            this.id = id;
            this.ten_loai = ten_loai;
        }
        public Loai(DataRow row)
        {
            this.id = (int)row["Mã loại"];
            this.ten_loai = row["Tên loại"].ToString();
        }

        public int Id { get => id; set => id = value; }
        public string Ten_loai { get => ten_loai; set => ten_loai = value; }
    }
}
