using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDiemSV.DTO
{
   public class RangBuoc
    {
        public RangBuoc(int id, string tenSV, string tenKhoa,string tenLop,string tenMon)
        {
            this.Id = id;
            this.Tensv = tensv;
            this.Tenkhoa = tenKhoa;
            this.Tenlop = tenLop;
            this.Tenmon = tenMon;

        }
        public RangBuoc(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Tensv = row["tenSV"].ToString();
            this.Tenkhoa = row["tenKhoa"].ToString();
            this.Tenlop = row["tenLop"].ToString();
            this.Tenmon = row["tenMon"].ToString();


        }
        private int id;
        private string tensv;
        private string tenkhoa;
        private string tenlop;
        private string tenmon;

        public int Id { get => id; set => id = value; }
        public string Tensv { get => tensv; set => tensv = value; }
        public string Tenkhoa { get => tenkhoa; set => tenkhoa = value; }
        public string Tenlop { get => tenlop; set => tenlop = value; }
        public string Tenmon { get => tenmon; set => tenmon = value; }
    }
}
