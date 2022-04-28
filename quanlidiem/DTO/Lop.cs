using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDiemSV.DTO
{
   public class Lop
    {
        public Lop(string maLop, string tenLop, string maSV)
        {
            this.Malop = maLop;
            this.Tenlop = tenLop;
            this.Masv = maSV;
            
        }
        public Lop(DataRow row)
        {
            this.Malop = row["maLop"].ToString();
            this.Tenlop = row["tenLop"].ToString();
            this.Masv = row["maSV"].ToString();
           

        }
        private string malop;
        private string tenlop;
        private string masv;

        public string Malop { get => malop; set => malop = value; }
        public string Tenlop { get => tenlop; set => tenlop = value; }
        public string Masv { get => masv; set => masv = value; }
    }
}
