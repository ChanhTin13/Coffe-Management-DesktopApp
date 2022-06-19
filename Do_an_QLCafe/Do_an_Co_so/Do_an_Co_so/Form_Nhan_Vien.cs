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
    public partial class Form_Nhan_Vien : Form
    {
        private string dgDan = null;
        public Form_Nhan_Vien()
        {
            InitializeComponent();
            Load_NV();
        }

        private void dtgv_NV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Cus_txt_MaNv.Texts = dtgv_NV.SelectedCells[0].OwningRow.Cells["Mã nhân viên"].Value.ToString();
                Cus_txt_Ten_Nv.Texts = dtgv_NV.SelectedCells[0].OwningRow.Cells["Họ tên"].Value.ToString();

                Cus_Dtpk_Ngay_vao_lam.Value = (DateTime)dtgv_NV.SelectedCells[0].OwningRow.Cells["Ngày vào làm"].Value;
                custom_RBtn_Nam.Checked = bool.Parse(dtgv_NV.SelectedCells[0].OwningRow.Cells["Giới tính"].Value.ToString()) == true ? true : false;
                custom_RBtn_Nu.Checked = bool.Parse(dtgv_NV.SelectedCells[0].OwningRow.Cells["Giới tính"].Value.ToString()) == false ? true : false;

                Cus_txt_Sdt.Texts = dtgv_NV.SelectedCells[0].OwningRow.Cells["Số điện thoại"].Value.ToString();

                string ten_chuc_vu = dtgv_NV.SelectedCells[0].OwningRow.Cells["Chức vụ"].Value.ToString();
                DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("select * from Chuc_vu ");
                foreach (DataRow r in data.Rows)
                {
                    if (r["Ten_Chuc_vu"].Equals(ten_chuc_vu) == true)
                    {
                        custom_Cbx_chuc_vu.SelectedIndex = (int)r["id"] - 1;
                        break;
                    }
                }
                //custom_Cbx_chuc_vu.SelectedValue= (object)dtgv_NV.SelectedCells[0].OwningRow.Cells["Chức vụ"].Value;

                string hinh = dtgv_NV.SelectedCells[0].OwningRow.Cells["Hình"].Value.ToString();
                if (hinh == "")
                {
                    pictureBox_Hinh.BackgroundImage = null;
                }
                else if (hinh == null)
                {
                    pictureBox_Hinh.BackgroundImage = null;
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


        private void btnSuaHinh_Click(object sender, EventArgs e)
        {
            if (Cus_txt_MaNv.Texts == "")
            {
                MessageBox.Show("Hãy chọn người để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    (" update NHAN_VIEN set hinh = @hinh where id= @ma ", new object[] { dgDan, Cus_txt_MaNv.Texts });
                dgDan = null;
                MessageBox.Show("Sửa hình thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLuuHinh.Enabled = false;
                Load_NV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Load_NV()
        {

            DataTable dt = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("select * from Chuc_vu ");

            custom_Cbx_chuc_vu.DataSource = dt;
            custom_Cbx_chuc_vu.DisplayMember = "Ten_Chuc_vu";
            custom_Cbx_chuc_vu.ValueMember = "id";
            custom_Cbx_chuc_vu.SelectedIndex = 1;

            dtgv_NV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_NV.DataSource = QL_Nhan_Vien.Thuc_Thi.Load_NV(); 



            //reset
            dgDan = null;
            btnLuuHinh.Enabled = false;

            pictureBox_Hinh.BackgroundImage = null;
            Cus_txt_MaNv.Texts = "";
            Cus_txt_Ten_Nv.Texts = "";
            Cus_txt_Sdt.Texts = "";

        }
        private bool check()
        {
            if (Cus_txt_Ten_Nv.Texts == "" || Cus_txt_Sdt.Texts == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên và số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Cus_txt_MaNv.Texts = "";
                cus_btn_Sua.Enabled = false;
                cus_btn_them.Enabled = true;
                pictureBox_Hinh.BackgroundImage = null;

            }
            else
            {
                cus_btn_Sua.Enabled = !false;
                cus_btn_them.Enabled = !true;
                Cus_txt_MaNv.Enabled = !true;
            }
        }

        private void cus_btn_Lm_moi_Click(object sender, EventArgs e)
        {
            Load_NV();
        }

        private void cus_btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (check() == true)
                {
                    bool gt = custom_RBtn_Nam.Checked == true ? true : false;

                    QL_Nhan_Vien.Thuc_Thi.Them_Nhan_Vien(Cus_txt_Ten_Nv.Texts, (int) custom_Cbx_chuc_vu.SelectedValue, Cus_txt_Sdt.Texts, gt);
                    Load_NV();

                }

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
                if (Cus_txt_MaNv.Texts == "")
                {
                    MessageBox.Show("Bạn muốn Sửa ai ?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (check() == true)
                {
                    bool gt = custom_RBtn_Nam.Checked == true ? true : false;
                    int ma_nv = Convert.ToInt32(Cus_txt_MaNv.Texts);

                    QL_Nhan_Vien.Thuc_Thi.Sua_Nhan_Vien(ma_nv, Cus_txt_Ten_Nv.Texts, (int)custom_Cbx_chuc_vu.SelectedValue, Cus_txt_Sdt.Texts, gt);
                    Load_NV();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void cus_btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {

                if (Cus_txt_MaNv.Texts == "")
                {
                    MessageBox.Show("Bạn muốn Xóa ai ?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                QL_Nhan_Vien.Thuc_Thi.Xoa_Nhan_Vien(Convert.ToInt32(Cus_txt_MaNv.Texts));
                Load_NV();

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
                Xuat_Excel_DAO.Thuc_Thi.ToExcel(dtgv_NV, saveFileDialog1.FileName);
            }
        }
    }
}
