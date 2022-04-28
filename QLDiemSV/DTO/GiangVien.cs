using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDiemSV.DTO
{
   public class GiangVien
    {
        public GiangVien(string maGV,string tenGV,string maLop,string ngaySinh,string gioiTinh, string email, string sdt)
        {
            this.IdGV = maGV;
            this.NameGV = tenGV;
            this.IdlopGV = maLop;
            this.NgaysinhGV = ngaySinh;
            this.GioitinhGV = gioiTinh;
            this.EmailGV = email;
            this.SdtGV = sdt;
        }
        public GiangVien(DataRow row)
        {
            this.IdGV = row["maGV"].ToString();
             this.NameGV = row["tenGV"].ToString();
            this.IdlopGV = row["maLop"].ToString();
            this.NgaysinhGV = row["ngaySinh"].ToString();
            this.GioitinhGV = row["gioiTinh"].ToString();
            this.EmailGV = row["email"].ToString();
            this.SdtGV = row["sdt"].ToString();

        }
        private string idGV;
        private string nameGV;
        private string idlopGV;
        private string ngaysinhGV;
        private string gioitinhGV;
        private string emailGV;
        private string sdtGV;

        public string IdGV { get => idGV; set => idGV = value; }
        public string NameGV { get => nameGV; set => nameGV = value; }
        public string IdlopGV { get => idlopGV; set => idlopGV = value; }
        public string NgaysinhGV { get => ngaysinhGV; set => ngaysinhGV = value; }
        public string GioitinhGV { get => gioitinhGV; set => gioitinhGV = value; }
        public string EmailGV { get => emailGV; set => emailGV = value; }
        public string SdtGV { get => sdtGV; set => sdtGV = value; }
    }
}
