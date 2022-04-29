using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDiemSV.DTO
{
   public class MonHoc
    {
        public MonHoc(string maMon, string maSV, string tenMon,string hocKy)
        {
            this.Mamon = maMon; 
            this.Tenmon = tenMon;
            this.Hocky = hocKy;
            this.Masv = maSV;

        }
        public MonHoc(DataRow row)
        {
            this.Mamon = row["maMon"].ToString();
            this.Tenmon = row["tenMon"].ToString();
            this.Hocky = row["hocKy"].ToString();
            this.Masv = row["maSV"].ToString();

        }
        private string mamon;
        private string tenmon;
        private string hocky;
        private string masv;

        public string Mamon { get => mamon; set => mamon = value; }
        public string Tenmon { get => tenmon; set => tenmon = value; }
        public string Hocky { get => hocky; set => hocky = value; }
        public string Masv { get => masv; set => masv = value; }
    }
}
