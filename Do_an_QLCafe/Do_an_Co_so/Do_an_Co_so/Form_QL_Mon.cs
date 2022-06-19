using Do_an_Co_so.DAO;
using QuanLyThuVien_KeKao.DAO;
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
    public partial class Form_QL_Mon : Form
    {
        private string dgDan = null;
        public Form_QL_Mon()
        {
            InitializeComponent();
            Load_Loai_Mon();
            Load_Menu();
        }
        private void load_cmb_loai()
        {
            DataTable dt = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("select * from loai ");

            custom_Cbx_loai.DataSource = dt;
            custom_Cbx_loai.DisplayMember = "ten_loai";
            custom_Cbx_loai.ValueMember = "id";
            custom_Cbx_loai.SelectedIndex = 1;
        }
        private void Load_Loai_Mon()
        {
            dataGridView_loai_menu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_loai_menu.DataSource = QL_Mon.Thuc_Thi.Load_Loai();

        }
        private void Load_Menu()
        {
            load_cmb_loai();

            dgDan = null;
            btnLuuHinh.Enabled = false;

            pictureBox_Hinh.BackgroundImage = null;
            Cus_txt_MaMon.Texts = "";
            Cus_txt_Ten_Mon.Texts = "";
            Cus_txt_Gia.Texts = "";
            numericUpDown_SL.Value = 1;

            dtgv_menu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_menu.DataSource = QL_Mon.Thuc_Thi.Load_Mon();
        }
        private void dataGridView_loai_menu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_tenLoai.Texts = dataGridView_loai_menu.SelectedCells[0].OwningRow.Cells["Tên loại"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgv_menu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (checkBox1.Checked == true)
                {
                    Cus_txt_MaMon.Texts = "";
                }
                else
                {
                    Cus_txt_MaMon.Texts = dtgv_menu.SelectedCells[0].OwningRow.Cells["id"].Value.ToString();
                }

                Cus_txt_Ten_Mon.Texts = dtgv_menu.SelectedCells[0].OwningRow.Cells["Tên món"].Value.ToString();

                numericUpDown_SL.Value = (int)dtgv_menu.SelectedCells[0].OwningRow.Cells["Số lượng tồn"].Value;

                Cus_txt_Gia.Texts = dtgv_menu.SelectedCells[0].OwningRow.Cells["Giá"].Value.ToString();

                string ten_loai = dtgv_menu.SelectedCells[0].OwningRow.Cells["Loại"].Value.ToString();
                DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("select * from Loai ");
                foreach (DataRow r in data.Rows)
                {
                    if (r["ten_loai"].Equals(ten_loai) == true)
                    {
                        custom_Cbx_loai.SelectedIndex = (int)r["id"] - 1;
                        break;
                    }
                }
                //custom_Cbx_chuc_vu.SelectedValue= (object)dtgv_menu.SelectedCells[0].OwningRow.Cells["Chức vụ"].Value;

                string hinh = dtgv_menu.SelectedCells[0].OwningRow.Cells["Hình"].Value.ToString();
                if (hinh == "")
                {
                    pictureBox_Hinh.BackgroundImage = Image.FromFile(@"D:\z_Do an co so QL Cafe\Do_an_QLCafe\Do_an_Co_so\Do_an_Co_so\HinhAnh\null.png"); ;
                }
                else if (hinh == null)
                {
                    pictureBox_Hinh.BackgroundImage = Image.FromFile(@"D:\z_Do an co so QL Cafe\Do_an_QLCafe\Do_an_Co_so\Do_an_Co_so\HinhAnh\null.png");
                }
                else
                {
                    pictureBox_Hinh.BackgroundImage = null;
                    pictureBox_Hinh.BackgroundImage = Image.FromFile(hinh);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cus_btn_Lm_moi_Click(object sender, EventArgs e)
        {
            Load_Loai_Mon();
            Load_Menu();
        }

        private void cus_btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cus_txt_MaMon.Texts == "")
                {
                    MessageBox.Show("Hãy chọn món để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                QL_Mon.Thuc_Thi.Xoa_Mon(Convert.ToInt32(Cus_txt_MaMon.Texts));
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Load_Menu();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Cus_txt_MaMon.Texts = "";
                cus_btn_Sua.Enabled = false;
                cus_btn_them.Enabled = true;
                pictureBox_Hinh.BackgroundImage = null;

            }
            else
            {
                cus_btn_Sua.Enabled = !false;
                cus_btn_them.Enabled = !true;
                Cus_txt_MaMon.Enabled = !true;
            }
        }
        private void btn_Luu_loai_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_tenLoai.Texts == "")
                {
                    MessageBox.Show("Vui lòng nhập tên loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {

                    QL_Mon.Thuc_Thi.Luu_loai(txt_tenLoai.Texts);
                    load_cmb_loai();
                    Load_Loai_Mon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_Xoa_Loai_Click(object sender, EventArgs e)
        {

            try
            {
                QL_Mon.Thuc_Thi.Xoa_loai(txt_tenLoai.Texts);
                Load_Loai_Mon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_sua_loai_Click(object sender, EventArgs e)
        {

        }
        private bool check()
        {
            int x = (int)DataProvider.Thuc_Thi.ExcuteScalar("select count(*) from menu where ten_mon like @ten_mon", new object[] { Cus_txt_Ten_Mon.Texts });

            if (Cus_txt_Ten_Mon.Texts == "")
            {
                MessageBox.Show("Vui lòng nhập tên món", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (x > 0)
            {
                MessageBox.Show("Tên món bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void cus_btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (check() == true)
                {
                    QL_Mon.Thuc_Thi.Them_Mon(Cus_txt_Ten_Mon.Texts, (int)custom_Cbx_loai.SelectedValue, (int)numericUpDown_SL.Value, Int32.Parse(Cus_txt_Gia.Texts));
                    Load_Menu();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSuaHinh_Click(object sender, EventArgs e)
        {
            if (Cus_txt_MaMon.Texts == "")
            {
                MessageBox.Show("Hãy chọn món để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                OpenFileDialog a = new OpenFileDialog();
                a.Filter = "Image Files (*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg";
                a.InitialDirectory = @"Desktop";
                a.Title = "Open";
                if (a.ShowDialog() == DialogResult.OK)
                {
                    dgDan = a.FileName;
                    pictureBox_Hinh.BackgroundImage = Image.FromFile(dgDan);
                }
                btnLuuHinh.Enabled = true;
            }
        }

        private void btnLuuHinh_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van
                    (" update menu set hinh = @hinh where id= @ma ", new object[] { dgDan, Int32.Parse(Cus_txt_MaMon.Texts) });
                dgDan = null;
                MessageBox.Show("Sửa hình thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLuuHinh.Enabled = false;
                Load_Menu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cus_btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cus_txt_Ten_Mon.Texts == "")
                {
                    MessageBox.Show("Vui lòng nhập tên món", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    QL_Mon.Thuc_Thi.Sua_Mon(Convert.ToInt32(Cus_txt_MaMon.Texts), Cus_txt_Ten_Mon.Texts, (int)custom_Cbx_loai.SelectedValue, (int)numericUpDown_SL.Value, Int32.Parse(Cus_txt_Gia.Texts));
                    Load_Menu();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox_Excel_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Xuat_Excel_DAO.Thuc_Thi.ToExcel(dtgv_menu, saveFileDialog1.FileName);
            }
        }
    }
}
