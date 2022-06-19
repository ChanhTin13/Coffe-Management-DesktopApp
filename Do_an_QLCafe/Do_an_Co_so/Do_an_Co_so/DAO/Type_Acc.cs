using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Co_so.DAO
{
    public class Type_Acc
    {
        private static Type_Acc thuc_Thi; 
        public static Type_Acc Thuc_Thi
        {
            get
            {
                if (thuc_Thi == null)
                {
                    thuc_Thi = new Type_Acc();
                }
                return thuc_Thi;
            }
        }
        private int x;
        public int Get_Type()
        {
            return x;
        }
        public void Set_Type(int type)
        {
            x = type;
        }
    }
}
