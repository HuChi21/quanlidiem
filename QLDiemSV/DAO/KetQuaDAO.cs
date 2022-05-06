using QLDiemSV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDiemSV.DAO
{
   public class KetQuaDAO
    {
        private static KetQuaDAO instance;

        public static KetQuaDAO Instance
        {
            get { if (instance == null) instance = new KetQuaDAO(); return KetQuaDAO.instance; }
            private set { KetQuaDAO.instance = value; }
        }
        private KetQuaDAO() { }
        public List<KetQua> GetListKetQua()
        {
            List<KetQua> list = new List<KetQua>();
            string query = "select *from KetQua ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                KetQua ketqua = new KetQua(item);
                list.Add(ketqua);
            }
            return list;
        }
        public List<KetQua> GetListKetQuabyTenSV(string tensv)
        {
            List<KetQua> list = new List<KetQua>();
            string query = string.Format("select *from KetQua where tenSV like N'%{0}%'",tensv);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                KetQua ketqua = new KetQua(item);
                list.Add(ketqua);
            }
            return list;
        }
        public List<KetQua> GetListKetQuabyMaSV(string masv)
        {
            List<KetQua> list = new List<KetQua>();
            string query = string.Format("select *from KetQua where maSV like N'%{0}%'", masv);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                KetQua ketqua = new KetQua(item);
                list.Add(ketqua);
            }
            return list;
        }
        public bool InsertKQ(string masv,string tensv,string tenlop,string tenmon,float diemtx,float diemthi,float diemtk,float diemso4,string diemchu,string hocky)
        {
            string query = string.Format("INSERT KetQua(maSV,tenSV,tenLop,tenMon,diemTX,diemThi,diemTK,diem4,diemChu,hocKy)VAlUES (N'{0}', N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}')", masv,tensv,tenlop,tenmon,diemtx,diemthi,diemtk,diemso4,diemchu,hocky);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool EditKQ(string masv, string tensv, string tenlop, string tenmon, float diemtx, float diemthi, float diemtk, float diemso4, string diemchu, string hocky)
        {
            string query = string.Format("UPDATE KetQua set tenSV=N'{0}',tenLop=N'{1}',tenMon=N'{2}',diemTX=N'{3}',diemThi=N'{4}',diemTK=N'{5}',diem4=N'{6}',diemChu=N'{7}',hocKy=N'{8}'WHERE maSV=N'{9}'", tensv, tenlop, tenmon, diemtx, diemthi, diemtk, diemso4, diemchu, hocky, masv);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteKQ(string masv)
        {
            //DataProvider.Instance.ExecuteQuery("DELETE SV where masv=N'{0}'"+masv);
            string query = string.Format("DELETE KetQua where maSV = N'{0}'", masv);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
