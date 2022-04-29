using QLDiemSV.DAO;
using QLDiemSV.DTO;
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
            string query = "select maSV as[Mã sinh viên],tenSV  as[Tên sinh viên],tenLop  as[Tên lớp],tenMon as[Tên môn học],diemTX  as[Điểm TX],diemThi  as[Điểm thi],diemTK  as[Điểm tổng kết],diem4 as[Điểm 4],diemChu as[Điểm chữ],hocKy  as[Học kỳ] from KetQua";

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
        List<KetQua> GetListKetQuabyTenSV(string tensv)
        {
            List<KetQua> listSV = KetQuaDAO.Instance.GetListKetQuabyTenSV(tensv);
                return listSV;
        }

       

        private void txbTim_TextChanged(object sender, EventArgs e)
        {
            string name = txbTim.Text.Trim();
            if (name == "")
            {
                loadTT();
            }
            else
            {

                string query = "select*from KetQua where tenSV like '%" + name + "%'";
                dsTraCuu.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
        }
    }
}
