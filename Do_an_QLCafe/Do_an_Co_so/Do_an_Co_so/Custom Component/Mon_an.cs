using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_Co_so.Component
{
    public partial class Mon_an : UserControl
    {



        public Mon_an()
        {
            InitializeComponent();
        }
        private int id;
        public int Id { get => id; set => id = value; }

        private string ten_mon;
        public string Ten_mon { get { return label_Ten_mon.Text; } set { ten_mon = value; label_Ten_mon.Text = value; } }


        private bool is_Het_Hang;
        public bool Is_Het_Hang
        {
            get => is_Het_Hang;
            set
            {
                is_Het_Hang = value;
                if (is_Het_Hang == true)
                {
                    label_het_hang.Text = "Hết hàng";
                    label_het_hang.Visible = true;
                }
                else
                {
                    label_het_hang.Visible = false;
                }
            }
        }

        private int gia;
        public int Gia { get { return Int32.Parse(label_Gia.Text); } set { gia = value; label_Gia.Text = gia.ToString(); } }

        private int sl;
        public int Sl
        {
            get => sl; set
            {
                sl = value;
                if (sl <=0)
                {
                    label_het_hang.Text = "Hết hàng";
                    label_het_hang.Visible = true;
                }
            }
        }

        private string hinh;
        public string Hinh
        {
            get => hinh;
            set
            {
                hinh = value;

                custom_Picturebox1.BackgroundImage = Image.FromFile(value);
                //this.Invalidate();


            }
        }



        public event EventHandler OnSelect = null;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }
    }
}
