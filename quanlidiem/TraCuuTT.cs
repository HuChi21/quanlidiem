using QLDiemSV.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDiemSV
{
    public partial class TraCuuTT : Form
    {
        public TraCuuTT()
        {
            InitializeComponent();
            loadTT();
        }

        void loadTT()
        {
            string query = "select a.maSV as[Mã sinh viên],tenSV  as[Tên sinh viên],tenLop  as[Tên lớp],tenMon as[Tên môn học],tenKhoa as[Khoa],tenGV  as[Giảng viên],diemTX1  as[Điểm TX1],diemTX2  as[Điểm TX2],diemThi  as[Điểm thi],k.hocKy  as[Học kỳ] from SV a, GV b, Lop c,Khoa d, KetQua f,MonHoc k where a.maSV = c.maSV and b.maLop = c.maLop and d.maLop = c.maLop and k.maSV = a.maSV and f.maMon = k.maMon and f.maSV = a.maSV ";

            dsTraCuu.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap f = new DangNhap();
            f.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItemSV_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
