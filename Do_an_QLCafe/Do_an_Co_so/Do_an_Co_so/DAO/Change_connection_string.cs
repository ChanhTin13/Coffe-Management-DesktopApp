using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Co_so.DAO
{
    public class Change_connection_string
    {
        private static Change_connection_string thuc_Thi;

        public static Change_connection_string Thuc_Thi
        {
            get
            {
                if (thuc_Thi == null)
                {
                    thuc_Thi = new Change_connection_string();
                }
                return thuc_Thi;
            }
        }
        public List<string> Lay_database_name()
        {
            DataTable datax = new DataTable();

            string connectionString = @"Data Source=.;" + "Integrated Security=true";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", con);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(datax);

            }
            List<string> dd = new List<string>();
             
            foreach (DataRow itemm in datax.Rows)
            { 
                    dd.Add(itemm[0].ToString()); 
            }
            return dd;
        }

        

        public List<string> Show_ServerName()
        {
            string ServerName = Environment.MachineName;
            string str;

            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;

            List<string> x = new List<string>();
            x.Add(ServerName);
            int skip = 1;

            using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
            {
                RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instanceKey != null)
                {
                    foreach (var instanceName in instanceKey.GetValueNames())
                    {
                        if (skip == 1)
                        {
                            skip = skip + 1;
                            continue;
                        }
                        else
                        {
                            str = ServerName + @"\" + instanceName;
                            x.Add(str);
                        }
                    }
                }
            }
            return x;
        }

    }

}
