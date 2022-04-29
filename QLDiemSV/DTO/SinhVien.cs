using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDiemSV.DAO
{
    public class SinhVien
    {
        public SinhVien(string maSV, string tenSV,string ngaySinh,string gioiTinh,string diaChi) {
            this.Idsv = maSV;
            this.Namesv = tenSV;
            this.Diachisv = diaChi;
            this.Ngaysinhsv = ngaySinh;
            this.Gioitinhsv = gioiTinh;
        }
        public SinhVien(DataRow row)
        {
            this.Idsv = row["maSV"].ToString();
            this.Namesv = row["tenSV"].ToString();
            this.Diachisv = row["diaChi"].ToString();
            this.Ngaysinhsv = row["ngaySinh"].ToString();
            this.Gioitinhsv = row["gioiTinh"].ToString();

        }
        private string namesv;
        private string idsv;
        private string ngaysinhsv;
        private string gioitinhsv;
        private string diachisv;

        public string Namesv { get => namesv; set => namesv = value; }
        public string Idsv { get => idsv; set => idsv = value; }
        public string Ngaysinhsv { get => ngaysinhsv; set => ngaysinhsv = value; }
        public string Gioitinhsv { get => gioitinhsv; set => gioitinhsv = value; }
        public string Diachisv { get => diachisv; set => diachisv = value; }
    }
}
