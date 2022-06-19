using Do_an_Co_so.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Co_so.DAO
{
    public class DataProvider
    {
        private static DataProvider thuc_Thi;
        public string tk;
        public static DataProvider Thuc_Thi
        {
            get
            {
                if (thuc_Thi == null)
                {
                    thuc_Thi = new DataProvider();
                }
                return thuc_Thi;
            }
        }

        string Data_Source = @"Data Source=LAPTOP-HAD0QVLJ\SQL_2019;Initial Catalog=Do_an_Co_so;Integrated Security=True";
        public void Set_Data_Source(string chuoi_DataSource)
        { 
            Data_Source = chuoi_DataSource;
        } 
         
        public DataTable Thuc_hien_cau_truy_van(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(Data_Source))
            {
                connection.Open();

                SqlCommand cm = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listParameter = query.Split(' ');
                    int i = 0;
                    foreach (string item in listParameter)
                    {
                        if (item.Contains('@'))
                        {
                            cm.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cm);
                adapter.Fill(data);

                return data;
            }
        }

        public object ExcuteScalar(string query, object[] parameter = null)
        {
            object x = null;
            using (SqlConnection connection = new SqlConnection(Data_Source))
            {
                connection.Open();

                SqlCommand cm = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listParameter = query.Split(' ');
                    int i = 0;
                    foreach (string item in listParameter)
                    {
                        if (item.Contains('@'))
                        {
                            cm.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                x = cm.ExecuteScalar();
            }

            return x;
        }
        

    }
}
