using QLDiemSV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDiemSV.DAO
{
    public class KhoaDAO
    {
        private static KhoaDAO instance;

        public static KhoaDAO Instance
        {
            get { if (instance == null) instance = new KhoaDAO(); return KhoaDAO.instance; }
            private set { KhoaDAO.instance = value; }
        }
        private KhoaDAO() { }
        public List<Khoa> GetListKhoa()
        {
            List<Khoa> list = new List<Khoa>();
            string query = "select *from Khoa ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Khoa khoa = new Khoa(item);
                list.Add(khoa);
            }
            return list;
        }
        public bool InsertKhoa(string makhoa, string tenkhoa)
        {
            string query = string.Format("INSERT Khoa(maKhoa,tenKhoa)VAlUES (N'{0}', N'{1}')", makhoa, tenkhoa);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool EditKhoa(string makhoa, string tenkhoa)
        {
            string query = string.Format("UPDATE Khoa set tenKhoa=N'{0}'WHERE maKhoa=N'{1}'", tenkhoa, makhoa);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteKhoa(string makhoa)
        {
            //DataProvider.Instance.ExecuteQuery("DELETE SV where masv=N'{0}'"+masv);
            string query = string.Format("DELETE Khoa where maKhoa = N'{0}'", makhoa);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
