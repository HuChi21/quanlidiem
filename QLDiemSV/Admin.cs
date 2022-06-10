using QLDiemSV.DAO;
using QLDiemSV.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDiemSV
{
    public partial class Admin : Form
    {
        //BindingSource svlist = new BindingSource();
        //BindingSource gvlist = new BindingSource();
        /*bindingsource loplist = new bindingsource();*/
        public Admin()
        {
            InitializeComponent();
            LoadKhoa();
            loadMonHoc();
            loadGiangVien();
            loadKetQua();
            loadLop();
            loadsinhvien();
            loadSVDF();
            loadSVDA();
            //AddSV();
            //LoadListGV();
            //AddGV();
            //LoadListSV();
            //LoadSVIntoCombobox(cbGioiTinhSV);
            //dssv.datasource = svlist;
            //dsGV.DataSource = gvlist;
            //dsLop.DataSource = loplist;
            //LoadListLop();
            LoadMonHocIntoCombobox(cbTenMon);
            //LoadHocKyIntoCombobox(cbHocKy);
            LoadTenlopIntoCombobox(cbTenLop);
            LoadTenlopIntoCombobox(cbTenLopD);
            LoadMonHocIntoCombobox(cbTenMonD);
            LoadKhoaIntoCombobox(cbTenKhoa);
            //LoadHocKyIntoCombobox(cbHKy);
           
        }
        //void LoadListLop()
        //{
        //    loplist.DataSource = LopDAO.Instance.GetListLop;
        //}
        //void LoadListGV() {
        //    gvlist.DataSource = GiangVienDAO.Instance.GetListGV();
        //}
        //void LoadListSV()
        //{
        //    svlist.DataSource = SinhVienDAO.Instance.GetListSV();
        //}
        void LoadKhoaIntoCombobox(ComboBox cb)
        {
            cb.DataSource = KhoaDAO.Instance.GetListKhoa();
            cb.DisplayMember = "Tenkhoa";
        }
        void LoadMonHocIntoCombobox(ComboBox cb)
        {
            cb.DataSource = MonHocDAO.Instance.GetListMonHoc();
            cb.DisplayMember = "Tenmon";
        }
        void LoadHocKyIntoCombobox(ComboBox cb)
        {
            cb.DataSource = MonHocDAO.Instance.GetListMonHoc();
            cb.DisplayMember = "Hocky";
        }
   
        void LoadTenlopIntoCombobox(ComboBox cb)
        {
            cb.DataSource = LopDAO.Instance.GetListLop();
            cb.DisplayMember = "Tenlop";
        }
        void loadLop()
        {
            string query = "select maLop as[Mã lớp],tenLop as[Tên lớp] from Lop ";

            dsLop.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        void loadKetQua()
        {
            string query = "select maSV as[Mã sinh viên],tenSV  as[Tên sinh viên],tenLop  as[Tên lớp],tenMon as[Tên môn học],diemTX  as[Điểm TX],diemThi  as[Điểm thi],diemTK  as[Điểm tổng kết],diem4 as[Điểm 4],diemChu as[Điểm chữ],hocKy  as[Học kỳ] from KetQua";

            dsDiem.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        void loadSVDF()
        {
            string query = "select maSV as[Mã sinh viên],tenSV  as[Tên sinh viên],tenLop  as[Tên lớp],tenMon as[Tên môn học],diemTX  as[Điểm TX],diemThi  as[Điểm thi],diemTK  as[Điểm tổng kết],diem4 as[Điểm 4],diemChu as[Điểm chữ],hocKy  as[Học kỳ] from KetQua where diemChu=N'F'";

            dsSVDF.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        void loadSVDA()
        {
            string query = "select maSV as[Mã sinh viên],tenSV  as[Tên sinh viên],tenLop  as[Tên lớp],tenMon as[Tên môn học],diemTX  as[Điểm TX],diemThi  as[Điểm thi],diemTK  as[Điểm tổng kết],diem4 as[Điểm 4],diemChu as[Điểm chữ],hocKy  as[Học kỳ] from KetQua where diemChu=N'A'";

            dsSVA.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        void loadGiangVien()
        {
            string query = "select maGV as[Mã giảng viên],tenGV as[Tên giảng viên],ngaySinh as[Ngày sinh],gioiTinh as[Giới tính ],email as[Email],sdt as[Số điện thoại] from GV ";

            dsGV.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        void loadsinhvien()
        {
            string query = "select masv as[mã sinh viên],tensv as[tên sinh viên],ngaysinh as[ngày sinh],gioitinh as[giới tính],diachi as[địa chỉ] from sv ";

            dsSV.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        void loadMonHoc()
        {
            string query = "select maMon as[Mã môn],tenMon as[Tên môn],hocKy as[Học kỳ] from MonHoc ";

            dsMonHoc.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        void LoadKhoa()
        {
            string query = "select maKhoa as[Mã khoa],tenKhoa as[Tên khoa] from Khoa ";

            dsKhoa.DataSource = DataProvider.Instance.ExecuteQuery(query);
            // string query = "exec USP_GetKhoabyMaKhoa @maKhoa ";

            //dsKhoa.DataSource = DataProvider.Instance.ExecuteQuery(query,new object[]{"k1"});
        }

        private void tbxThoatSV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Sinh Vien
        private void btnAddSV_Click(object sender, EventArgs e)
        {
            try
            {
                string masv = txbMSV.Text;
                string tensv = txbTenSV.Text;
                string ngaysinhsv = dtNSSV.Text;
                string gioitinhsv = cbGTSV.Text;
                string diachisv = txbDiaChiSV.Text;

                if (masv.Equals(""))
                {
                    MessageBox.Show("Mã sinh viên không được để trống");
                }
                else if (tensv.Equals(""))
                {
                    MessageBox.Show("Tên sinh viên không được để trống");
                }
                else if (ngaysinhsv.Equals(""))
                {
                    MessageBox.Show("Ngày sinh  không được để trống");
                }
                else if (gioitinhsv.Equals(""))
                {
                    MessageBox.Show("Giới tính không được để trống");
                }
                else if (diachisv.Equals(""))
                {
                    MessageBox.Show("Địa chỉ không được để trống");
                }
                else if (SinhVienDAO.Instance.InsertSV(masv, tensv, ngaysinhsv, gioitinhsv, diachisv))
                {
                    MessageBox.Show("Thêm sinh viên thành công");
                    loadsinhvien();

                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm sinh viên");
                }
            }
            catch
            {
                MessageBox.Show("Đã tồn tại mã sinh viên");
            }
        }

        private void btnEditSV_Click(object sender, EventArgs e)
        {
            string masv = txbMSV.Text;
            string tensv = txbTenSV.Text;
            string ngaysinhsv = dtNSSV.Text;
            string gioitinhsv = cbGTSV.Text;
            string diachisv = txbDiaChiSV.Text;
            if (tensv.Equals(""))
            {
                MessageBox.Show("Tên sinh viên không được để trống");
            }
            else if (ngaysinhsv.Equals(""))
            {
                MessageBox.Show("Ngày sinh  không được để trống");
            }
            else if (gioitinhsv.Equals(""))
            {
                MessageBox.Show("Giới tính không được để trống");
            }
            else if (diachisv.Equals(""))
            {
                MessageBox.Show("Địa chỉ không được để trống");
            }
            else if (SinhVienDAO.Instance.EditSV(masv, tensv, ngaysinhsv, gioitinhsv, diachisv))
            {
                MessageBox.Show("Sửa sinh viên thành công");
                loadsinhvien();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa sinh viên");
            }
        }

        private void tbnDeleteSV_Click(object sender, EventArgs e)
        {
            string masv = txbMSV.Text;

            if (SinhVienDAO.Instance.DeleteSV(masv))
            {
                MessageBox.Show("Xoa sinh viên thành công");
                loadsinhvien();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xoa sinh viên");
            }
        }

        private void btnInsertDV_Click(object sender, EventArgs e)
        {
            try
            {
                string magv = txbMGV.Text;
                string tengv = txbTenGV.Text;
                string ngaysinhgv = txbNSGV.Text;
                string gioitinhgv = cbGTGV.Text;
                string email = txbEmail.Text;
                string sdt = txbSDT.Text;
                if (magv.Equals(""))
                {
                    MessageBox.Show("Mã giảng viên không được để trống");
                }
                else if (tengv.Equals(""))
                {
                    MessageBox.Show("Tên giảng viên không được để trống");
                }
                else if (ngaysinhgv.Equals(""))
                {
                    MessageBox.Show("Ngày sinh  không được để trống");
                }
                else if (gioitinhgv.Equals(""))
                {
                    MessageBox.Show("Giới tính không được để trống");
                }
                else if (email.Equals(""))
                {
                    MessageBox.Show("Email không được để trống");
                }
                else if (sdt.Equals(""))
                {
                    MessageBox.Show("Số điện thoại không được để trống");
                }
                else if (GiangVienDAO.Instance.InsertGV(magv, tengv, ngaysinhgv, gioitinhgv, email, sdt))
                {
                    MessageBox.Show("Thêm giảng viên thành công");
                    loadGiangVien();

                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm giảng viên");
                }
            }
            catch
            {
                MessageBox.Show("Đã tồn tại mã giảng viên");
            }
        }

        private void btnInsertLop_Click(object sender, EventArgs e)
        {
            try
            {
                string malop = txbMaLop.Text;
                string tenlop = cbTenLop.Text;
                int i;
                i = dsLop.CurrentRow.Index;
                txbMaLop.Text = dsLop.Rows[i].Cells[0].Value.ToString();
                cbTenLop.Text = dsLop.Rows[i].Cells[1].Value.ToString();
                if (tenlop == cbTenLop.Text)
                {
                    MessageBox.Show("Đã tồn tại tên lớp");
                }else
                if (malop.Equals(""))
                {
                    MessageBox.Show("Mã lớp không được để trống");
                }
                else if (tenlop.Equals(""))
                {
                    MessageBox.Show("Tên lớp không được để trống");
                }
                else if (LopDAO.Instance.InsertLop(malop, tenlop))
                {
                    MessageBox.Show("Thêm lớp thành công");
                    loadLop();

                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm lớp");
                }
            }
            catch
            {
                MessageBox.Show("Đã tồn tại mã lớp");
            }
        }

        private void btnDeleteGV_Click(object sender, EventArgs e)
        {
            string magv = txbMGV.Text;

            if (GiangVienDAO.Instance.DeleteGV(magv))
            {
                MessageBox.Show("Xoa giảng viên thành công");
                loadGiangVien();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xoa giảng viên");
            }
        }

        private void btnDeleteLop_Click(object sender, EventArgs e)
        {
            string malop = txbMaLop.Text;

            if (LopDAO.Instance.DeleteLop(malop))
            {
                MessageBox.Show("Xoa lớp thành công");
                loadLop();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xoa lớp");
            }
        }

        private void btnEditLop_Click(object sender, EventArgs e)
        {
            string malop = txbMaLop.Text;
            string tenlop = cbTenLop.Text;

            if (tenlop.Equals(""))
            {
                MessageBox.Show("Tên lớp không được để trống");
            }
            else if (LopDAO.Instance.EditLop(malop, tenlop))
            {
                MessageBox.Show("Sửa lớp thành công");
                loadLop();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa lớp");
            }
        }

        private void btnEditGV_Click(object sender, EventArgs e)
        {
            string magv = txbMGV.Text;
            string tengv = txbTenGV.Text;
            string ngaysinhgv = txbNSGV.Text;
            string gioitinhgv = cbGTGV.Text;
            string email = txbEmail.Text;
            string sdt = txbSDT.Text;
             if (tengv.Equals(""))
            {
                MessageBox.Show("Tên giảng viên không được để trống");
            }
            else if (ngaysinhgv.Equals(""))
            {
                MessageBox.Show("Ngày sinh  không được để trống");
            }
            else if (gioitinhgv.Equals(""))
            {
                MessageBox.Show("Giới tính không được để trống");
            }
            else if (email.Equals(""))
            {
                MessageBox.Show("Email không được để trống");
            }
            else if (sdt.Equals(""))
            {
                MessageBox.Show("Số điện thoại không được để trống");
            }
            else if (GiangVienDAO.Instance.EditGV(magv, tengv, ngaysinhgv, gioitinhgv, email, sdt))
            {
                MessageBox.Show("Sửa giảng viên thành công");
                loadGiangVien();

            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa giảng viên");
            }
        }

        private void dsLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dsLop.CurrentRow.Index;
            txbMaLop.Text = dsLop.Rows[i].Cells[0].Value.ToString();
            cbTenLop.Text = dsLop.Rows[i].Cells[1].Value.ToString();
        }

        private void dsSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dsSV.CurrentRow.Index;
            txbMSV.Text = dsSV.Rows[i].Cells[0].Value.ToString();
            txbTenSV.Text = dsSV.Rows[i].Cells[1].Value.ToString();
            dtNSSV.Text = dsSV.Rows[i].Cells[2].Value.ToString();
            cbGTSV.Text = dsSV.Rows[i].Cells[3].Value.ToString();
            txbDiaChiSV.Text = dsSV.Rows[i].Cells[4].Value.ToString();
        }

        private void dsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dsGV.CurrentRow.Index;
            txbMGV.Text = dsGV.Rows[i].Cells[0].Value.ToString();
            txbTenGV.Text = dsGV.Rows[i].Cells[1].Value.ToString();
            txbNSGV.Text = dsGV.Rows[i].Cells[2].Value.ToString();
            cbGTGV.Text = dsGV.Rows[i].Cells[3].Value.ToString();
            txbEmail.Text = dsGV.Rows[i].Cells[4].Value.ToString();
            txbSDT.Text = dsGV.Rows[i].Cells[5].Value.ToString();
        }

        private void btnInsertKhoa_Click(object sender, EventArgs e)
        {
           
            try
            {
                string makhoa = txbMaKhoa.Text;
                string tenkhoa = cbTenKhoa.Text;
                int i;
                i = dsKhoa.CurrentRow.Index;
                cbTenKhoa.Text = dsKhoa.Rows[i].Cells[1].Value.ToString();
                if (tenkhoa == cbTenKhoa.Text)
                {
                    MessageBox.Show("Đã tồn tại tên khoa");
                }else

                if (makhoa.Equals(""))
                {
                    MessageBox.Show("Mã khoa không được để trống");
                }
                else if (tenkhoa.Equals(""))
                {
                    MessageBox.Show("Tên khoa không được để trống");
                }
                else if (KhoaDAO.Instance.InsertKhoa(makhoa, tenkhoa))
                {
                    MessageBox.Show("Thêm khoa thành công");
                    LoadKhoa();

                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm khoa");
                }
            }
            catch
            {
                MessageBox.Show("Đã tồn tại mã khoa");
            }
        }

        private void dsKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dsKhoa.CurrentRow.Index;
            txbMaKhoa.Text = dsKhoa.Rows[i].Cells[0].Value.ToString();
            cbTenKhoa.Text = dsKhoa.Rows[i].Cells[1].Value.ToString();
        }

        private void btnEditKhoa_Click(object sender, EventArgs e)
        {
            string makhoa = txbMaKhoa.Text;
            string tenkhoa = cbTenKhoa.Text;

            if (tenkhoa.Equals(""))
            {
                MessageBox.Show("Tên khoa không được để trống");
            }
            else if (KhoaDAO.Instance.EditKhoa(makhoa, tenkhoa))
            {
                MessageBox.Show("Sửa khoa thành công");
                LoadKhoa();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa khoa");
            }
        }

        private void btnDeleteKhoa_Click(object sender, EventArgs e)
        {
            string makhoa = txbMaKhoa.Text;

            if (KhoaDAO.Instance.DeleteKhoa(makhoa))
            {
                MessageBox.Show("Xoa khoa thành công");
                LoadKhoa();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xoa khoa");
            }
        }

        private void btnInsertMH_Click(object sender, EventArgs e)
        {
            try
            {

                string mamon = txbMaMon.Text;
                string tenmon = cbTenMon.Text;
                string hocky = cbHocKy.Text;
                int i;
                i = dsMonHoc.CurrentRow.Index; 
                cbTenMon.Text = dsMonHoc.Rows[i].Cells[1].Value.ToString();
                if (tenmon == cbTenMon.Text)
                {
                    MessageBox.Show("Đã tồn tại tên môn học");
                }else
                if (mamon.Equals(""))
                {
                    MessageBox.Show("Mã môn học không được để trống");
                }
                else if (tenmon.Equals(""))
                {
                    MessageBox.Show("Tên môn học không được để trống");
                }
                else if (hocky.Equals(""))
                {
                    MessageBox.Show("Học kỳ không được để trống");
                }
                else if (MonHocDAO.Instance.InsertMonHoc(mamon, tenmon, hocky))
                {
                    MessageBox.Show("Thêm môn học thành công");
                    loadMonHoc();

                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm môn học");
                }
            }
            catch
            {
                MessageBox.Show("Đã tồn tại mã môn học");
            }
        }

        private void btnEditMH_Click(object sender, EventArgs e)
        {
            string mamon = txbMaMon.Text;
            string tenmon = cbTenMon.Text;
            string hocky = cbHocKy.Text;

            if (tenmon.Equals(""))
            {
                MessageBox.Show("Tên môn học không được để trống");
            }else if (hocky.Equals(""))
            {
                MessageBox.Show("Học kỳ không được để trống");
            }
            else if (MonHocDAO.Instance.EditMonHoc(mamon, tenmon, hocky))
            {
                MessageBox.Show("Sửa môn học  thành công");
                loadMonHoc();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa môn học");
            }
        }
       

        private void btnDeleteMH_Click(object sender, EventArgs e)
        {
            string mamon = txbMaMon.Text;

            if (MonHocDAO.Instance.DeleteMonHoc(mamon))
            {
                MessageBox.Show("Xoa môn học thành công");
                loadMonHoc();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xoa môn học");
            }
        }

        private void dsMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dsMonHoc.CurrentRow.Index;
            txbMaMon.Text = dsMonHoc.Rows[i].Cells[0].Value.ToString();
            cbTenMon.Text = dsMonHoc.Rows[i].Cells[1].Value.ToString();
            cbHocKy.Text = dsMonHoc.Rows[i].Cells[2].Value.ToString();
           
        }

        private void btnInsertDiem_Click(object sender, EventArgs e)
        {
            try
            {
                string masv = txbMSVD.Text;
                string tensv = txbTenSVD.Text;
                string tenlop = cbTenLopD.Text;
                string tenmon = cbTenMonD.Text;
                float diemtx = float.Parse(txbTX.Text);
                float diemthi = float.Parse(txbDThi.Text);
                float diemtk = float.Parse(txbTKet.Text);
                float diemso4 = float.Parse(txbD4.Text);
                string diemchu = cbDChu.Text;
                string hocky = cbHKy.Text;

                if (masv.Equals(""))
                {
                    MessageBox.Show("Mã sinh viên  không được để trống");
                }
                else if (tensv.Equals(""))
                {
                    MessageBox.Show("Tên sinh viên  không được để trống");
                }
                else if (tenlop.Equals(""))
                {
                    MessageBox.Show("Tên lớp  không được để trống");
                }
                else if (tenmon.Equals(""))
                {
                    MessageBox.Show("Tên môn không được để trống");
                }
                else if (diemtx.Equals(""))
                {
                    MessageBox.Show("Điểm thường xuyên  không được để trống");
                }
                else if (diemthi.Equals(""))
                {
                    MessageBox.Show("Điểm thi không được để trống");
                }
                else if (diemtk.Equals(""))
                {
                    MessageBox.Show("Điểm tổng kết không được để trống");
                }
                else if (diemso4.Equals(""))
                {
                    MessageBox.Show("Điểm số 4 không được để trống");
                }
                else if (diemchu.Equals(""))
                {
                    MessageBox.Show("Điểm chữ không được để trống");
                }
                else if (hocky.Equals(""))
                {
                    MessageBox.Show("Học kỳ  không được để trống");
                }
                else if (KetQuaDAO.Instance.InsertKQ(masv, tensv, tenlop, tenmon, diemtx, diemthi, diemtk, diemso4, diemchu, hocky))
                {
                    MessageBox.Show("Thêm kết quả sinh viên thành công");
                    loadKetQua();

                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm kết quả sinh viên");
                }
            }
            catch
            {
                MessageBox.Show("Đã tồn tại mã sinh viên");
            }
        }
 

        //private void cbTenMon_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    ComboBox cb = sender as ComboBox;
        //    if (cb.SelectedValue != null)
        //    {
        //        RangBuoc tl = cb.SelectedItem as RangBuoc;
        //        cbTenLopMon.Text = tl.Tenlop.ToString();
        //    }
        //}

        private void dsDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dsDiem.CurrentRow.Index;
            txbMSVD.Text = dsDiem.Rows[i].Cells[0].Value.ToString();
            txbTenSVD.Text = dsDiem.Rows[i].Cells[1].Value.ToString();
            cbTenLopD.Text = dsDiem.Rows[i].Cells[2].Value.ToString();
            cbTenMonD.Text = dsDiem.Rows[i].Cells[3].Value.ToString();
            txbTX.Text = dsDiem.Rows[i].Cells[4].Value.ToString();
            txbDThi.Text = dsDiem.Rows[i].Cells[5].Value.ToString();
            txbTKet.Text = dsDiem.Rows[i].Cells[6].Value.ToString();
            txbD4.Text = dsDiem.Rows[i].Cells[7].Value.ToString();
            cbDChu.Text = dsDiem.Rows[i].Cells[8].Value.ToString();
            cbHKy.Text = dsDiem.Rows[i].Cells[9].Value.ToString();
        }

        private void btnEditDiem_Click(object sender, EventArgs e)
        {
            string masv = txbMSVD.Text;
            string tensv = txbTenSVD.Text;
            string tenlop = cbTenLopD.Text;
            string tenmon = cbTenMonD.Text;
            float diemtx = float.Parse(txbTX.Text);
            float diemthi = float.Parse(txbDThi.Text);
            float diemtk = float.Parse(txbTKet.Text);
            float diemso4 = float.Parse(txbD4.Text);
            string diemchu = cbDChu.Text;
            string hocky = cbHKy.Text;

            if (tensv.Equals(""))
            {
                MessageBox.Show("Tên sinh viên  không được để trống");
            }
            else if (tenlop.Equals(""))
            {
                MessageBox.Show("Tên lớp  không được để trống");
            }
            else if (tenmon.Equals(""))
            {
                MessageBox.Show("Tên môn không được để trống");
            }
            else if (hocky.Equals(""))
            {
                MessageBox.Show("Học kỳ  không được để trống");
            }
            else if (KetQuaDAO.Instance.EditKQ(masv, tensv, tenlop, tenmon, diemtx, diemthi, diemtk, diemso4, diemchu, hocky))
            {
                MessageBox.Show("Sửa kết quả sinh viên thành công");
                loadKetQua();

            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa kết quả sinh viên");
            }
        }

        private void btnDeleteDiem_Click(object sender, EventArgs e)
        {
            string masv = txbMSVD.Text;

            if (KetQuaDAO.Instance.DeleteKQ(masv))
            {
                MessageBox.Show("Xoa kết quả sinh viên thành công");
                loadKetQua();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xoa kết quả sinh viên");
            }
        }

       
        private void txbTX_TextChanged(object sender, EventArgs e)
        {
            float DIEMTX, DIEMTHI, DIEMTK;
            string a = "4", b1 = "3.5", b2 = "3", c1 = "2.5", c2 = "2", d1 = "1.5", d2 = "1", f = "0";
            if (float.TryParse(txbTX.Text, out DIEMTX) && float.TryParse(txbDThi.Text, out DIEMTHI))
            {
                //Tính điểm TK
                DIEMTK = (float)(0.3 * DIEMTX + 0.7 * DIEMTHI);
                this.txbTKet.Text = Convert.ToString(DIEMTK);
                DIEMTK = float.Parse(this.txbTKet.Text.ToString());
                if ((DIEMTK < 10) && (DIEMTK >= 8.5))
                {

                    this.txbD4.Text = Convert.ToString(a);
                    this.cbDChu.Text = "A".ToString();

                }
                else if ((DIEMTK < 8.5) && (DIEMTK >= 8.0))
                {
                    this.txbD4.Text = Convert.ToString(b1);
                    this.cbDChu.Text = "B+".ToString();
                }
                else if ((DIEMTK < 8.0) && (DIEMTK >= 7.0))
                {
                    this.txbD4.Text = Convert.ToString(b2);
                    this.cbDChu.Text = "B".ToString();
                }
                else if ((DIEMTK < 7.0) && (DIEMTK >= 6.5))
                {
                    this.txbD4.Text = Convert.ToString(c1);
                    this.cbDChu.Text = "C+".ToString();
                }
                else if ((DIEMTK < 6.5) && (DIEMTK >= 5.5))
                {
                    this.txbD4.Text = Convert.ToString(c2);
                    this.cbDChu.Text = "C".ToString();
                }
                else if ((DIEMTK < 5.5) && (DIEMTK >= 5.0))
                {
                    this.txbD4.Text = Convert.ToString(d1);
                    this.cbDChu.Text = "D+".ToString();
                }
                else if ((DIEMTK < 5.0) && (DIEMTK >= 4.0))
                {
                    this.txbD4.Text = Convert.ToString(d2);
                    this.cbDChu.Text = "D".ToString();
                }
                else
                {
                    this.txbD4.Text = Convert.ToString(f);
                    this.cbDChu.Text = "F".ToString();
                    MessageBox.Show("Không đạt");
                }
            }
            if(float.TryParse(txbTX.Text, out DIEMTX)==false)
            {
                MessageBox.Show("Giá trị nhập điểm TX phải là số và không được để trống");
            }
            
        }

        private void txbDThi_TextChanged(object sender, EventArgs e)
        {
            float DIEMTX, DIEMTHI, DIEMTK;
            string a = "4", b1 = "3.5", b2 = "3", c1 = "2.5", c2 = "2", d1 = "1.5", d2 = "1", f = "0";
            if (float.TryParse(txbTX.Text, out DIEMTX) && float.TryParse(txbDThi.Text, out DIEMTHI))
            {
                //Tính điểm TK
                DIEMTK = (float)(0.3 * DIEMTX + 0.7 * DIEMTHI);
                this.txbTKet.Text = Convert.ToString(DIEMTK);
                DIEMTK = float.Parse(this.txbTKet.Text.ToString());
                if ((DIEMTK < 10) && (DIEMTK >= 8.5))
                {

                    this.txbD4.Text = Convert.ToString(a);
                    this.cbDChu.Text = "A".ToString();

                }
                else if ((DIEMTK < 8.5) && (DIEMTK >= 8.0))
                {
                    this.txbD4.Text = Convert.ToString(b1);
                    this.cbDChu.Text = "B+".ToString();
                }
                else if ((DIEMTK < 8.0) && (DIEMTK >= 7.0))
                {
                    this.txbD4.Text = Convert.ToString(b2);
                    this.cbDChu.Text = "B".ToString();
                }
                else if ((DIEMTK < 7.0) && (DIEMTK >= 6.5))
                {
                    this.txbD4.Text = Convert.ToString(c1);
                    this.cbDChu.Text = "C+".ToString();
                }
                else if ((DIEMTK < 6.5) && (DIEMTK >= 5.5))
                {
                    this.txbD4.Text = Convert.ToString(c2);
                    this.cbDChu.Text = "C".ToString();
                }
                else if ((DIEMTK < 5.5) && (DIEMTK >= 5.0))
                {
                    this.txbD4.Text = Convert.ToString(d1);
                    this.cbDChu.Text = "D+".ToString();
                }
                else if ((DIEMTK < 5.0) && (DIEMTK >= 4.0))
                {
                    this.txbD4.Text = Convert.ToString(d2);
                    this.cbDChu.Text = "D".ToString();
                }
                else
                {
                    this.txbD4.Text = Convert.ToString(f);
                    this.cbDChu.Text = "F".ToString();
                    MessageBox.Show("Không đạt");
                }
            }
              if (float.TryParse(txbDThi.Text, out DIEMTHI) == false )
            {
                MessageBox.Show("Giá trị nhập điểm thi phải là số và không đươc để trống ");
            }
            
        }

        private void txbTimAdmin_TextChanged(object sender, EventArgs e)
        {
            string name = txbTimAdmin.Text.Trim();
            if (name == "")
            {
                loadKetQua();
            }
            else
            {

                string query = "select maSV as[Mã sinh viên],tenSV  as[Tên sinh viên],tenLop  as[Tên lớp],tenMon as[Tên môn học],diemTX  as[Điểm TX],diemThi  as[Điểm thi],diemTK  as[Điểm tổng kết],diem4 as[Điểm 4],diemChu as[Điểm chữ],hocKy  as[Học kỳ] from KetQua where tenSV like '%" + name + "%'";
                dsDiem.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int diemf = 0;
            int diema = 0;
            for(int i = 1; i < dsSVDF.Rows.Count; i++)
            {
                diemf++;
            }
            this.txbSVF.Text = Convert.ToString(diemf);
            for (int i = 1; i < dsSVA.Rows.Count; i++)
            {
                diema++;
            }
            this.txbSVA.Text = Convert.ToString(diema);
        }
    }
}
