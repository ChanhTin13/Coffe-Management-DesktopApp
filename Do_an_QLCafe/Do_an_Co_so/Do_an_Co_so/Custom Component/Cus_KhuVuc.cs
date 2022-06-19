using Do_an_Co_so.DTO;
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
    public partial class Cus_KhuVuc : UserControl
    {
        
        public Cus_KhuVuc()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
        }
        
        //private string ten_khu_vuc; 
        public string Ten_khu_vuc
        {
            get { return custom_btn1.Text; }
            set { custom_btn1.Text = value; }
        }
        private Point vi_tri;
        public Point Vi_tri { get => vi_tri; set { vi_tri = value; this.Location = vi_tri; } }


        private int id;
        public int Id
        {
            get { return id; }
            set
            {
                id = value;

            }
        }
        private KhuVucDTO tag_kv;
        public KhuVucDTO Tag_kv { get => tag_kv; set => tag_kv = value; }
        

        public event EventHandler OnSelect = null;
        private void custom_btn1_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }
 
    }
}
