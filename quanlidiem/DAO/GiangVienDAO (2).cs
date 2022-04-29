using QLDiemSV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDiemSV.DAO
{
   public class GiangVienDAO
    {
        private static GiangVienDAO instance;

        public static GiangVienDAO Instance
        {
            get { if (instance == null) instance = new GiangVienDAO(); return GiangVienDAO.instance; }
            private set { GiangVienDAO.instance = value; }
        }
        private GiangVienDAO() { }
        public List<GiangVien> GetListGV()
        {
            List<GiangVien> list = new List<GiangVien>();
            string query = "select *from GV";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                GiangVien giangvien = new GiangVien(item);
                list.Add(giangvien);
            }
            return list;
        }
        public bool InsertGV(string magv, string tengv, string ngaysinhgv, string gioitinhgv,string email, string sdt)
        {
            string query = string.Format("INSERT GV(maGV,tenGV, ngaySinh, gioiTinh, email, sdt)VAlUES (N'{0}', N'{1}', N'{2}', N'{3}',N'{4}',N'{5}')", magv, tengv,ngaysinhgv, gioitinhgv, email,sdt);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool EditGV(string magv,string tengv, string ngaysinhgv, string gioitinhgv, string email, string sdt)
        {
            string query = string.Format("UPDATE GV set tenGV=N'{0}', ngaySinh=N'{1}', gioiTinh='{2}', email=N'{3}',sdt=N'{4}' WHERE maGV=N'{5}'", tengv, ngaysinhgv, gioitinhgv, email, sdt,magv);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteGV(string magv)
        {
            string query = string.Format("DELETE GV where  maGV= N'{0}'", magv);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
