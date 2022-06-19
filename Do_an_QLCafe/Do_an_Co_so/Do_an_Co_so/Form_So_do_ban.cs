using Do_an_Co_so.Custom_Component;
using Do_an_Co_so.DAO;
using Do_an_Co_so.DTO;
using Do_an_Co_so.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Do_an_Co_so
{
    public partial class Form_So_do_ban : Form
    {
        private int ma_nv;
        public Form_So_do_ban(int id_nv)
        {
            InitializeComponent();
            this.ma_nv = id_nv;
            Load_khu_vuc();
            Load_ban(1);

        }
        private Form activeForm = null;
        private void openChildForm(Form f)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = f;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            panel_child_form.Controls.Add(f);
            panel_child_form.Tag = f;
            f.BringToFront();
            f.Show();

        }
        public void add_ban(int id,string ten_ban, bool ban_trong)
        {
            var ban = new Cus_Ban()
            {
                Id = id,
                Ten_ban = ten_ban,
                Is_Ban_trong = ban_trong,
                //Time = x,
            };
            flowLayoutPanel1.Controls.Add(ban);
            ban.OnSelect += (ss, ee) =>
            {
                openChildForm(new Form_DS_Mon(id,ten_ban, ma_nv)  );
            };
        }
        private void Load_ban(int id_kv)
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();
                List<BanDTO> ds_ban = QL_Ban.Thuc_Thi.Load_Ban_Theo_id_Khu_Vuc(id_kv);
                foreach (BanDTO x in ds_ban)
                {  
                    add_ban(x.Id,x.Ten_ban,x.Trang_thai);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
         
        public void add_kv(int id_kv, string ten_kv, Point vitri)
        {
            var kv = new Cus_KhuVuc()
            {
                Ten_khu_vuc = ten_kv,
                Id = id_kv,
                Vi_tri = vitri
            };
            panel_Khu_vuc.Controls.Add(kv);
            kv.OnSelect += (ss, ee) =>
            {
                Load_ban(id_kv);
            };
        }


        private Cus_KhuVuc kv = new Cus_KhuVuc();
        private void Load_khu_vuc()
        {
            try
            {
                List<KhuVucDTO> ds_kv = QL_Ban.Thuc_Thi.Load_Khu_vuc();

                int vt_X = 71;
                int vt_Y = 20;

                foreach (KhuVucDTO x in ds_kv)
                { 
                    Point vitri = new Point(vt_X, vt_Y);
                    vt_Y = vt_Y + 20 + kv.Size.Height; 

                    add_kv(x.Id, x.Ten_khu_vuc, vitri); 
                } 
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        } 
    }
}
