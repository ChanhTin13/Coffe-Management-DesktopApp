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
    public partial class Cus_KhuVuc_2 : UserControl
    {
        public Cus_KhuVuc_2()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
        }
        private int id;
        public int Id
        {
            get => id;
            set => id = value;
        }
        public string Ten_khu_vuc
        {
            get { return button1.Text; }
            set => button1.Text = value;
        }
    }
}
