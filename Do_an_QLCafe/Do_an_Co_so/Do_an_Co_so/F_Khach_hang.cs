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
    public partial class F_Khach_hang : Form
    {
        public F_Khach_hang()
        {
            InitializeComponent();
            Load_DS();
        }
        private void ToExcel(DataGridView dataGridView1, string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //đặt tên cho sheet
                worksheet.Name = "Danh sách khách hàng";

                // export header trong DataGridView
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(fileName);
                //đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ToExcel(dtgv_kh, saveFileDialog1.FileName);
            }
        }
        private void Load_DS()
        {
            dtgv_kh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_kh.DataSource = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("select id , ten_kh as N'Tên khách hàng', sdt as N'Số điện thoại', cmnd as N'CMND', diem_tich_luy as N'Điểm tích lũy'  from khach_hang");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Load_DS();
            txt_ma_kh.Texts = "";
            txt_ten_kh.Texts = "";
            txt_sdt.Texts = "";
            txt_cmnd.Texts = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ma_kh.Texts = dtgv_kh.SelectedCells[0].OwningRow.Cells["id"].Value.ToString();
            txt_ten_kh.Texts = dtgv_kh.SelectedCells[0].OwningRow.Cells["Tên khách hàng"].Value.ToString();
            txt_sdt.Texts = dtgv_kh.SelectedCells[0].OwningRow.Cells["Số điện thoại"].Value.ToString();
            txt_cmnd.Texts = dtgv_kh.SelectedCells[0].OwningRow.Cells["CMND"].Value.ToString();
        }

        private void cus_btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ten_kh.Texts == "" || txt_sdt.Texts == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int check_sdt = (int)DataProvider.Thuc_Thi.ExcuteScalar("select count(*) from khach_hang where sdt like @sdt ", new object[] { txt_sdt.Texts });
                    int check_cmnd = (int)DataProvider.Thuc_Thi.ExcuteScalar("select count(*) from khach_hang where cmnd like @sdt ", new object[] { txt_cmnd.Texts });
                    if (check_sdt > 0)
                    {
                        MessageBox.Show("Số điện thoại đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (check_cmnd > 0)
                    {
                        MessageBox.Show("Cẩn thận lừa đảo, CMND đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dtgv_kh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dtgv_kh.DataSource = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("insert into khach_hang values( @ten_kh , @sdt , @cmnd ,0)",
                            new object[] { txt_ten_kh.Texts, txt_sdt.Texts, txt_cmnd.Texts });
                        MessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_DS();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }


        }

        private void cus_btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ma_kh.Texts == "")
                {
                    MessageBox.Show("Hãy chọn khách hàng để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txt_ten_kh.Texts == "" || txt_sdt.Texts == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult dlr = MessageBox.Show("Bạn có chắc muốn sửa khách hàng " + txt_ma_kh.Texts + " ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlr == DialogResult.Yes)
                    {
                        dtgv_kh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dtgv_kh.DataSource = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("update khach_hang set ten_kh= @ten_kh ,sdt= @sdt ,cmnd= @cmnd where id = @id ",
                            new object[] { txt_ten_kh.Texts, txt_sdt.Texts, txt_cmnd.Texts, txt_ma_kh.Texts });
                        MessageBox.Show("Sửa khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_DS();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
    }
}
