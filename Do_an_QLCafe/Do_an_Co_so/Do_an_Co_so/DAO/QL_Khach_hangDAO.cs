using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Co_so.DAO
{
    public class QL_Khach_hangDAO
    {
        private static QL_Khach_hangDAO thuc_Thi; 
        public static QL_Khach_hangDAO Thuc_Thi
        {
            get
            {
                if (thuc_Thi == null)
                {
                    thuc_Thi = new QL_Khach_hangDAO();
                }
                return thuc_Thi;
            }
        }
    }
}
