using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDiemSV.DTO
{
    public class Khoa
    {
        public Khoa(string maKhoa, string tenKhoa, string maLop)
        {
            this.Makhoa = maKhoa;
            this.Tenkhoa = tenKhoa;
            this.Malop = maLop;

        }
        public Khoa(DataRow row)
        {
            this.Makhoa = row["maKhoa"].ToString();
            this.Tenkhoa = row["tenKhoa"].ToString();
            this.Malop = row["maLop"].ToString();


        }
        private string makhoa;
        private string tenkhoa;
        private string malop;

        public string Makhoa { get => makhoa; set => makhoa = value; }
        public string Tenkhoa { get => tenkhoa; set => tenkhoa = value; }
        public string Malop { get => malop; set => malop = value; }
    }
}
