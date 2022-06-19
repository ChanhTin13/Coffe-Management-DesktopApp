using Do_an_Co_so.Custom_Component;
using Do_an_Co_so.DAO;
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

namespace Do_an_Co_so
{
    public partial class Form_Bep : Form
    {
        public Form_Bep()
        {
            InitializeComponent();
            Load_Don();
        } 
        public void add_don(int id_phieu_goi_mon, int id, string ten_mon, string noi_dung, string sl, Point vitri)
        {
            var kt = new Size(panel_header.Width,header_bep.Height);

            var don = new Cus_Bep()
            {
                Id_phieu_goi_mon = id_phieu_goi_mon,
                Id_mon = id,
                Ten_mon=ten_mon,
                Noi_dung=noi_dung,
                Sl=sl,
                Vi_tri=vitri,
                Kich_thuoc= kt
            };
            don.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);
            panel_child.Controls.Add(don);
            don.OnSelect += (ss, ee) =>
            {
                Load_Don();
            };
        } 

        private void Load_Don()
        {
            try
            {
                panel_child.Controls.Clear();
                List<CtPGM_DTO> ds_kv = CtPGM_DAO.Thuc_Thi.Load_CTPGM();
                 
                int vt_X = 3;
                int vt_Y = 3;

                foreach (CtPGM_DTO x in ds_kv)
                {
                    Point vitri = new Point(vt_X, vt_Y);
                    vt_Y = vt_Y   + panel_header.Size.Height;

                    add_don(x.Id_phieu_goi_mon, x.Id_mon, x.Ten_mon, x.Noi_dung, x.Sl.ToString(), vitri);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Load_Don();
        }
    }
}
