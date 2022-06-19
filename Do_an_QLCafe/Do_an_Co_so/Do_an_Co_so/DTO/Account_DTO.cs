using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_KeKao.DTO
{
    public class Account_DTO
    {
        public Account_DTO(int id, string taiKhoan, string passWord, int chuc_vu, int ma_nv)
        {
            this.Id = id;
            this.TaiKhoan = taiKhoan;
            this.PassWord = passWord;
            this.Chuc_vu = chuc_vu;
            this.Ma_nv = ma_nv;
        }
        public Account_DTO(DataRow row)
        {
            this.Id = (int)row["id"];
            this.TaiKhoan = row["sdt"].ToString();
            this.PassWord = row["mat_khau"].ToString();
            this.Chuc_vu = (int)row["Chuc_vu"]; 
            this.Ma_nv = (int)row["MA_NV"];
        }

        private int id;
        public int Id { get => id; set => id = value; }

        private string taiKhoan;
        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }

        private string passWord;
        public string PassWord { get => passWord; set => passWord = value; }

        private int chuc_vu;
        public int Chuc_vu { get => chuc_vu; set => chuc_vu = value; }

        private int ma_nv;
        public int Ma_nv { get => ma_nv; set => ma_nv = value; }

    }
}



