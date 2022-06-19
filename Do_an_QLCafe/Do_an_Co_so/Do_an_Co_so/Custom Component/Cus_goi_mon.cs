using Do_an_Co_so.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_Co_so.Custom_Component
{
    public partial class Cus_goi_mon : UserControl
    {
        public Cus_goi_mon()
        {
            InitializeComponent();
        }
        private int sl_hien_tai;

        private int id;
        private string ten_mon;
        private int sl;
        private int gia;
        private string noi_dung;
        private string hinh;
        private int sl_max;
        private bool da_xong;
        public bool Da_xong
        {
            get => da_xong;
            set
            {
                da_xong = value;
                if (da_xong == true)
                {
                    pictureBox3.Visible = true;
                } 
            }
        }
        private bool con_hang;
        public bool Con_hang
        {
            get => con_hang;
            set
            {
                con_hang = value;
                 
            }
        }

        public int Id { get => id; set => id = value; }
        public string Ten_mon { get { return label_ten_mon.Text; } set { ten_mon = value; label_ten_mon.Text = value; } }
        public int Sl
        {
            get => sl; set
            {
                sl = value;
                sl_hien_tai = value;
                if (sl == 0)
                {
                    txt_noi_dung.Texts = "Hết hàng";
                    pictureBox3.Visible = true;
                    pictureBox3.BackgroundImage = Properties.Resources.x;
                }
                label_Sl.Text = sl.ToString();
            }
        }
        public int Gia { get => gia; set { gia = value; label_thanh_tien.Text = sl * value + "đ"; } }


        public string Noi_dung
        {
            get
            {
                return txt_noi_dung.Texts;
            }
            set
            {
                noi_dung = value;
                txt_noi_dung.Texts = value;
            }
        }
        public string Hinh { get => hinh; set { hinh = value; custom_Picturebox1.BackgroundImage = Image.FromFile(value); } }

        public int Sl_max { get => sl_max; set { sl_max = value; } }


        public event EventHandler OnSelect = null;
        private void click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }

        

        private void txt_noi_dung__TextChanged(object sender, EventArgs e)
        {
            noi_dung = txt_noi_dung.Texts;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (sl != 0)
            {
                if (sl < (sl_max + sl_hien_tai-1))
                {
                    sl++;
                    label_Sl.Text = sl.ToString();
                    label_thanh_tien.Text = sl * gia + "đ";
                    click(sender, e);
                }
            } 
        }
        public int min_values = 1;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (sl != 0)
            {
                if (sl > min_values)
                {
                    sl--;
                    label_Sl.Text = sl.ToString();
                    label_thanh_tien.Text = sl * gia + "đ";
                    click(sender, e);
                }
            }

        }

        private void label_Sl_TextChanged(object sender, EventArgs e)
        {
            label_thanh_tien.Text = sl * gia + "đ";
        }

        private void Cus_goi_mon_Load(object sender, EventArgs e)
        {
            label_thanh_tien.Text = sl * gia + "đ";
        }
    }
}
