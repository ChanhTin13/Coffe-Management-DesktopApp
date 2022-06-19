using Do_an_Co_so.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Co_so.DAO
{
    public class CtPGM_DAO
    {
        private static CtPGM_DAO thuc_Thi;

        public static CtPGM_DAO Thuc_Thi
        {
            get
            {
                if (thuc_Thi == null)
                {
                    thuc_Thi = new CtPGM_DAO();
                }
                return thuc_Thi;
            }
        }
        private CtPGM_DAO() { }

        public List<CtPGM_DTO> Load_CTPGM()
        {
            string query = " load_all_ctpgm";
            List<CtPGM_DTO> ds_bill = new List<CtPGM_DTO>();

            DataTable data = DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van(query);
            foreach (DataRow r in data.Rows)
            {
                CtPGM_DTO x = new CtPGM_DTO(r);
                ds_bill.Add(x);
            }

            return ds_bill;
        }

    }
}
