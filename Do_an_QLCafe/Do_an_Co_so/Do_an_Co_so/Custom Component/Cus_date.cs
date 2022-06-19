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
    public partial class Cus_date : UserControl
    {
        public Cus_date()
        {
            InitializeComponent();
        }
        private string ngay;
        public string Ngay
        {
            get { return custom_btn1.Text; }
            set
            {
                ngay = value;
                custom_btn1.Text = value;
            }
        }
        private Point vi_tri;
        public Point Vi_tri { get => vi_tri; set { vi_tri = value; this.Location = vi_tri; } }
        public event EventHandler OnSelect = null;
        private void custom_btn1_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }
    }
}
