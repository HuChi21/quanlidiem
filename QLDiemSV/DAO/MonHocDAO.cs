using QLDiemSV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDiemSV.DAO
{
    public class MonHocDAO
    {
        private static MonHocDAO instance;

        public static MonHocDAO Instance
        {
            get { if (instance == null) instance = new MonHocDAO(); return MonHocDAO.instance; }
            private set { MonHocDAO.instance = value; }
        }
        private MonHocDAO() { }
        public List<MonHoc> GetListMonHoc()
        {
            List<MonHoc> list = new List<MonHoc>();
            string query = "select *from MonHoc ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                MonHoc monhoc = new MonHoc(item);
                list.Add(monhoc);
            }
            return list;
        }
        public bool InsertMonHoc(string mamon, string tenmon,string hocky)
        {
            string query = string.Format("INSERT MonHoc(maMon,tenMon,hocKY)VAlUES (N'{0}', N'{1}',N'{2}')", mamon, tenmon,hocky);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool EditMonHoc(string mamon, string tenmon,string hocky)
        {
            string query = string.Format("UPDATE MonHoc set tenMon=N'{0}',hocKy=N'{1}' WHERE maMon=N'{2}'", tenmon, hocky,mamon);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteMonHoc(string mamon)
        {
            //DataProvider.Instance.ExecuteQuery("DELETE SV where masv=N'{0}'"+masv);
            string query = string.Format("DELETE MonHoc where maMon = N'{0}'", mamon);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
