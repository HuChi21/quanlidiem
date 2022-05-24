using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDiemSV.DTO
{
    public class KetQua
    {
        public KetQua(string maSV,string tenSV,string tenLop, string tenMon,float diemTX,float diemThi,float diemTK,float diem4,string diemChu,string hocKy)
        {
            this.Masv = maSV;
            this.Tensv = tensv;
            this.Tenlop = tenLop;
            this.Tenmon = tenMon;
            this.Diemtx = diemTX;
            this.Diemthi = diemThi;
            this.Diemtk = diemTK;
            this.Diemso4 = diem4;
            this.Diemchu = diemChu;
            this.Hocky = hocKy;

        }
        public KetQua(DataRow row)
        {
            this.Masv = row["maSV"].ToString();
            this.Tensv = row["tenSV"].ToString();
            this.Tenlop = row["tenLop"].ToString();
            this.Tenmon = row["tenMon"].ToString();
            this.Diemtx = (float)Convert.ToDouble(row["diemTX"].ToString());
            this.Diemthi = (float)Convert.ToDouble(row["diemThi"].ToString());
            this.Diemtk = (float)Convert.ToDouble(row["diemTK"].ToString());
            this.Diemso4 = (float)Convert.ToDouble(row["diem4"].ToString());
            this.Diemchu = row["diemChu"].ToString();
            this.Hocky = row["hocKy"].ToString();


        }
        private string masv;
        private string tensv;
        private string tenlop;
        private string tenmon;
        private float diemtx;
        private float diemthi;
        private float diemtk;
        private float diemso4;
        private string diemchu;
        private string hocky;

        public string Masv { get => masv; set => masv = value; }
        public string Tensv { get => tensv; set => tensv = value; }
        public string Tenlop { get => tenlop; set => tenlop = value; }
        public string Tenmon { get => tenmon; set => tenmon = value; }
        public float Diemtx { get => diemtx; set => diemtx = value; }
        public float Diemthi { get => diemthi; set => diemthi = value; }
        public float Diemtk { get => diemtk; set => diemtk = value; }
        public float Diemso4 { get => diemso4; set => diemso4 = value; }
        public string Diemchu { get => diemchu; set => diemchu = value; }
        public string Hocky { get => hocky; set => hocky = value; }
    }
}
