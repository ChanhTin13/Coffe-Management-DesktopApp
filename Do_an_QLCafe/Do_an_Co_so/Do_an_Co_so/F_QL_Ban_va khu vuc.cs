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

namespace Do_an_Co_so
{
    public partial class F_QL_Ban_va_khu_vuc : Form
    {
        public F_QL_Ban_va_khu_vuc()
        {
            InitializeComponent();
            Load_cbx();
            load_dtgv_kv();
        }
        private void Load_cbx()
        {
            DataTable dt = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("select * from khu_vuc");

            cmb_KV.DataSource = dt;
            cmb_KV.DisplayMember = "ten_khu_vuc";
            cmb_KV.ValueMember = "id";
            cmb_KV.SelectedIndex = -1;
        }
        void load_dtgv_kv()
        {
            try
            {
                dtgv_kv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtgv_kv.DataSource = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(" select id, ten_khu_vuc as N'Tên khu vực' from khu_vuc ");
            }
            catch (Exception) { }
        }
        private void cmb_KV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_KV.SelectedIndex != -1)
                {
                    dtgv_ban.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dtgv_ban.DataSource = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("select ban.id, ten_ban as N'Tên bàn', so_ghe as N'Số ghế', trang_thai as N'Trạng thái' " +
                        " from ban,khu_vuc where ban.khu_vuc=khu_vuc.id and khu_vuc.id= @xxx ", new object[] { (int)cmb_KV.SelectedValue });
                }
                
            }
            catch (Exception) { }
        }

        private void dtgv_ban_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ma_ban.Texts = dtgv_ban.SelectedCells[0].OwningRow.Cells["id"].Value.ToString();
            txt_ten_ban.Texts = dtgv_ban.SelectedCells[0].OwningRow.Cells["Tên bàn"].Value.ToString();
            txt_so_ghe.Texts = dtgv_ban.SelectedCells[0].OwningRow.Cells["Số ghế"].Value.ToString();
        }

        private void cus_btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                dtgv_ban.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtgv_ban.DataSource = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("insert into ban values( @ten_ban , @so_ghe ,0, @kv )",
                    new object[] { txt_ten_ban.Texts, Int32.Parse(txt_so_ghe.Texts), (int)cmb_KV.SelectedValue });
                cmb_KV_SelectedIndexChanged(sender, e);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void cus_btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ma_ban.Texts == "" || txt_ma_ban.Texts == null)
                {
                    MessageBox.Show("Vui lòng chọn bàn để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dtgv_ban.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dtgv_ban.DataSource = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("update ban set ten_ban = @ten_ban , so_ghe = @so_ghe where id = @id ",
                        new object[] { txt_ten_ban.Texts, Int32.Parse(txt_so_ghe.Texts), Int32.Parse(txt_ma_ban.Texts) });
                    cmb_KV_SelectedIndexChanged(sender, e);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void cus_btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ma_ban.Texts == "" || txt_ma_ban.Texts == null)
                {
                    MessageBox.Show("Vui lòng chọn bàn để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dtgv_ban.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dtgv_ban.DataSource = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("delete ban where id = @id ",
                        new object[] { Int32.Parse(txt_ma_ban.Texts) });
                    MessageBox.Show("Xóa bàn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmb_KV_SelectedIndexChanged(sender, e);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dlr = MessageBox.Show("Bạn muốn thêm tự động " + numericUpDown1.Value + " bàn vào khu: " + cmb_KV.Text + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    dtgv_ban.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dtgv_ban.DataSource = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("them_ban_tu_dong @sl , @id_kv ",
                        new object[] { numericUpDown1.Value, (int)cmb_KV.SelectedValue });
                    MessageBox.Show("Đã tự động thêm thành công " + numericUpDown1.Value + " bàn vào khu: " + cmb_KV.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmb_KV_SelectedIndexChanged(sender, e);
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void dtgv_kv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ma_kv.Texts = dtgv_kv.SelectedCells[0].OwningRow.Cells["id"].Value.ToString();
            txt_ten_kv.Texts = dtgv_kv.SelectedCells[0].OwningRow.Cells["Tên khu vực"].Value.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Load_cbx();
            load_dtgv_kv();
        }

        private void btn_them_kv_Click(object sender, EventArgs e)
        {
            try
            {
                int x = (int)DataProvider.Thuc_Thi.ExcuteScalar("select COUNT(*) from khu_vuc where ten_khu_vuc like @ten_kv ", new object[] { txt_ten_kv.Texts });
                if (x > 0)
                {
                    MessageBox.Show("Tên khu vực bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dtgv_kv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dtgv_kv.DataSource = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("insert into khu_vuc values ( @ten_kv ) ",
                        new object[] { txt_ten_kv.Texts });
                    MessageBox.Show("Thêm khu vực thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pictureBox2_Click(sender, e);
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void btn_xoa_kv_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ma_kv.Texts == null || txt_ma_kv.Texts == " ")
                {
                    MessageBox.Show("Hãy nhập mã khu vực", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int x = (int)DataProvider.Thuc_Thi.ExcuteScalar("select count(*) from ban where khu_vuc = @id ", new object[] { txt_ma_kv.Texts });
                    if (x > 0)
                    {
                        MessageBox.Show("Còn ràng buộc dữ diệu với bàn", "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dtgv_kv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dtgv_kv.DataSource = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("delete khu_vuc where id = @id ",
                            new object[] { txt_ma_kv.Texts });
                        MessageBox.Show("Xóa khu vực thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pictureBox2_Click(sender, e);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
    }
}
