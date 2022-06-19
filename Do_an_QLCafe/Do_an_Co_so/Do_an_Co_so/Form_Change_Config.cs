using Do_an_Co_so.DAO;
using Microsoft.Win32;
using QuanLyThuVien_KeKao.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_Co_so
{
    public partial class Form_Change_Config : Form
    {
        private string chuoi_DataSource;
        public Form_Change_Config()
        {
            InitializeComponent();

            cboServerName.DataSource = Change_connection_string.Thuc_Thi.Show_ServerName();
            cboServerName.SelectedIndex = -1;

            List<string> Authentication = new List<string>();
            Authentication.Add("Windows Authentication");
            Authentication.Add("SQL Server Authentication");
            Authentication.Add("Active Directory Password Authentication");
            Authentication.Add("Active Directory Integrated Authentication");
            cboAuthentication.DataSource = Authentication;
            cboAuthentication.SelectedIndex = 0;
        }

        ////change Initial Catalog
        private void cboServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboServerName.SelectedIndex != -1)
            {
                string x = "Data Source=" + cboServerName.SelectedValue.ToString() + "; Integrated Security=true";
                  
                DataTable data = new DataTable();  
                using (SqlConnection connection = new SqlConnection(x))
                {
                    connection.Open(); 
                    SqlCommand cm = new SqlCommand("SELECT name from sys.databases", connection); 
                    SqlDataAdapter adapter = new SqlDataAdapter(cm);
                    adapter.Fill(data); 
                } 

                List<string> list_database_name = new List<string>(); 
                foreach (DataRow itemm in data.Rows)
                {
                    list_database_name.Add(itemm[0].ToString());
                }
                cboDatabase_Name.DataSource = list_database_name;

            }
            else
            {
                cboDatabase_Name.DataSource = null;
            }
        }


        private void cboAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAuthentication.SelectedIndex != 0)
            {
                txtUserName.Enabled = true;
                txtPassWord.Enabled = true;
            }
            else
            {
                txtUserName.Enabled = false;
                txtPassWord.Enabled = false;
            }
        }

        private void btn_test_connection_Click(object sender, EventArgs e)
        {
            if (cboServerName.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn server name", "Quản lý cà phê Women", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
                try
                {
                    string x = "Data Source=" + cboServerName.SelectedValue.ToString() + ";Initial Catalog=" + cboDatabase_Name.SelectedValue.ToString() + ";Integrated Security=True";
                    SqlHelper helper = new SqlHelper(x);
                    if (helper.IsConnection)
                        MessageBox.Show("Test connection succeeded.", "Quản lý cà phê Women", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //string connectionString = string.Format("Data Source={0};Initial Catalog={1};", cboServer.Text, txtDatabase.Text);
        private void btnConnect_Click(object sender, EventArgs e)
        {  

            //Form_Dang_Nhap f = new Form_Dang_Nhap();
            //this.Hide();
            //f.Show();
            //this.Show();
            if (cboServerName.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn server name", "Quản lý cà phê Women", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string x = cboServerName.SelectedValue.ToString();
                string y = cboDatabase_Name.SelectedValue.ToString();

                chuoi_DataSource = "Data Source=" + x + ";Initial Catalog=" + y + ";Integrated Security=True";
                try
                {
                    SqlHelper helper = new SqlHelper(chuoi_DataSource);
                    if (helper.IsConnection)
                    {
                        DataProvider.Thuc_Thi.Set_Data_Source(chuoi_DataSource);
                        MessageBox.Show("Đổi connection thành công", "Quản lý cà phê Women", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
