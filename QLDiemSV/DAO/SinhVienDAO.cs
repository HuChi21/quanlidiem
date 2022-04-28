using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDiemSV.DAO
{
    public class SinhVienDAO
    {
        private static SinhVienDAO instance;

        public static SinhVienDAO Instance
        { get { if (instance == null) instance = new SinhVienDAO(); return SinhVienDAO.instance; }
           private set  {SinhVienDAO.instance = value; }
        }
        private SinhVienDAO() { }
        public List<SinhVien> GetListSV()
        {
            List<SinhVien> list = new List<SinhVien>();
            string query = "select *from SV ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                SinhVien sinhvien = new SinhVien(item);
                list.Add(sinhvien);
            }
            return list;
        }
        public bool InsertSV(string masv,string tensv, string ngaysinhsv,string gioitinhsv,string diachisv)
        {
            string query = string.Format("INSERT SV(maSV,tenSV, ngaySinh, gioiTinh, diaChi)VAlUES (N'{0}', N'{1}', N'{2}', N'{3}',N'{4}')",masv,tensv,ngaysinhsv,gioitinhsv,diachisv);
          int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool EditSV(string masv, string tensv, string ngaysinhsv, string gioitinhsv, string diachisv)
        {
            string query = string.Format("UPDATE SV set tenSV=N'{0}', ngaySinh=N'{1}', gioiTinh='{2}', diaChi=N'{3}' WHERE maSV=N'{4}'" ,tensv, ngaysinhsv, gioitinhsv, diachisv,masv);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteSV(string masv)
        {
            //DataProvider.Instance.ExecuteQuery("DELETE SV where masv=N'{0}'"+masv);
            string query = string.Format("DELETE SV where maSV = N'{0}'",masv);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
