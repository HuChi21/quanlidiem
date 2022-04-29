using QLDiemSV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDiemSV.DAO
{
    public class LopDAO
    {
        private static LopDAO instance;

        public static LopDAO Instance
        {
            get { if (instance == null) instance = new LopDAO(); return LopDAO.instance; }
            private set { LopDAO.instance = value; }
        }
        private LopDAO() { }
        public List<Lop> GetListLop()
        {
            List<Lop> list = new List<Lop>();
            string query = "select *from Lop ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Lop lop = new Lop(item);
                list.Add(lop);
            }
            return list;
        }
        public bool InsertLop(string malop, string tenlop)
        {
            string query = string.Format("INSERT Lop(maLop,tenLop)VAlUES (N'{0}', N'{1}')", malop,tenlop);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool EditLop(string malop, string tenlop)
        {
            string query = string.Format("UPDATE Lop set tenLOP=N'{0}'WHERE maLop=N'{1}'", tenlop, malop);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteLop(string malop)
        {
            //DataProvider.Instance.ExecuteQuery("DELETE SV where masv=N'{0}'"+masv);
            string query = string.Format("DELETE Lop where maLop = N'{0}'", malop);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
