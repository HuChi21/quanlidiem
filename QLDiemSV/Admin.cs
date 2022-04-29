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
            LoadHocKyIntoCombobox(cbHocKy);
            LoadTenlopIntoCombobox(cbTenLop);
           
           
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

        void LoadMonHocIntoCombobox(ComboBox cb)
        {
            cb.DataSource = RangBuocDAO.Instance.GetListRangBuoc();
            cb.DisplayMember = "Tenmon";
        }
        void LoadHocKyIntoCombobox(ComboBox cb)
        {
            cb.DataSource = MonHocDAO.Instance.GetListMonHoc();
            cb.DisplayMember = "Hocky";
        }
   
        void LoadTenlopIntoCombobox(ComboBox cb)
        {
            cb.DataSource = RangBuocDAO.Instance.GetListRangBuoc();
            cb.DisplayMember = "Tenlop";
        }

        //Hiển thị tên và mã khi kich vào
        //void AddSV()
        //{
        //    txbTenSV.DataBindings.Add(new Binding("Text", dsSV.DataSource, "tên sinh viên",true,DataSourceUpdateMode.Never));
        //    txbMSV.DataBindings.Add(new Binding("Text", dsSV.DataSource, "mã sinh viên",true, DataSourceUpdateMode.Never));
        //}
        //void AddGV()
        //{
        //    txbTenGV.DataBindings.Add(new Binding("Text", dsGV.DataSource, "Tên giảng viên"));
        //    txbMGV.DataBindings.Add(new Binding("Text", dsGV.DataSource, "Mã giảng viên"));
        //}

        void loadLop()
        {
            string query = "select maLop as[Mã lớp],tenLop as[Tên lớp] from Lop ";

            dsLop.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        void loadKetQua()
        {
            string query = "select a.maSV as[Mã sinh viên],tenSV  as[Tên sinh viên],tenLop  as[Tên lớp],tenMon as[Tên môn học],tenKhoa as[Khoa],tenGV  as[Giảng viên],diemTX1  as[Điểm TX1],diemTX2  as[Điểm TX2],diemThi  as[Điểm thi],k.hocKy  as[Học kỳ] from SV a, GV b, Lop c,Khoa d, KetQua f,MonHoc k where a.maSV = c.maSV and b.maLop = c.maLop and d.maLop = c.maLop and k.maSV = a.maSV and f.maMon = k.maMon and f.maSV = a.maSV  ";

            dsDiem.DataSource = DataProvider.Instance.ExecuteQuery(query);
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
            string masv = txbMSV.Text;
            string tensv = txbTenSV.Text;
            string ngaysinhsv = dtNSSV.Text;
            string gioitinhsv = cbGTSV.Text;
            string diachisv = txbDiaChiSV.Text;
            if (SinhVienDAO.Instance.InsertSV(masv, tensv, ngaysinhsv, gioitinhsv, diachisv))
            {
                MessageBox.Show("Thêm sinh viên thành công");
                loadsinhvien();
                
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm sinh viên");
            }
        }

        private void btnEditSV_Click(object sender, EventArgs e)
        {
            string masv = txbMSV.Text;
            string tensv = txbTenSV.Text;
            string ngaysinhsv = dtNSSV.Text;
            string gioitinhsv = cbGTSV.Text;
            string diachisv = txbDiaChiSV.Text;
            if (SinhVienDAO.Instance.EditSV(masv, tensv, ngaysinhsv, gioitinhsv, diachisv))
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
            string magv = txbMGV.Text;
            string tengv = txbTenGV.Text;
            string ngaysinhgv = txbNSGV.Text;
            string gioitinhgv = cbGTGV.Text;
            string email = txbEmail.Text;
            string sdt = txbSDT.Text;
            if (GiangVienDAO.Instance.InsertGV(magv,tengv, ngaysinhgv, gioitinhgv,email, sdt))
            {
                MessageBox.Show("Thêm giảng viên thành công");
                loadGiangVien();

            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm giảng viên");
            }
        }

        private void btnInsertLop_Click(object sender, EventArgs e)
        {
            string malop = txbMaLop.Text;
            string tenlop = cbTenLop.Text;
            
            if (LopDAO.Instance.InsertLop(malop,tenlop))
            {
                MessageBox.Show("Thêm lớp thành công");
                loadLop();

            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm lớp");
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
          
            if (LopDAO.Instance.EditLop(malop, tenlop))
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
            if (GiangVienDAO.Instance.EditGV(magv, tengv, ngaysinhgv, gioitinhgv, email, sdt))
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
            string makhoa = txbMaKhoa.Text;
            string tenkhoa = cbTenKhoa.Text;

            if (KhoaDAO.Instance.InsertKhoa(makhoa, tenkhoa))
            {
                MessageBox.Show("Thêm khoa thành công");
                LoadKhoa();

            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm khoa");
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

            if (KhoaDAO.Instance.EditKhoa(makhoa, tenkhoa))
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
            string mamon = txbMaMon.Text;
            string tenmon = cbTenMon.Text;
            string hocky = cbHocKy.Text;

            if (MonHocDAO.Instance.InsertMonHoc(mamon, tenmon,hocky))
            {
                MessageBox.Show("Thêm môn học thành công");
                loadMonHoc();

            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm môn học");
            }
        }

        private void btnEditMH_Click(object sender, EventArgs e)
        {
            string mamon = txbMaMon.Text;
            string tenmon = cbTenMon.Text;
            string hocky = cbHocKy.Text;

            if (MonHocDAO.Instance.EditMonHoc(mamon, tenmon, hocky))
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
          
        }

        

        private void cbTenLop_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if(cb.SelectedValue != null)
            {
                RangBuoc tl = cb.SelectedItem as RangBuoc;
                cbTenKhoaL.Text = tl.Tenkhoa.ToString();
            }
        }

        private void cbTenMon_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue != null)
            {
                RangBuoc tl = cb.SelectedItem as RangBuoc;
                cbTenLopMon.Text = tl.Tenlop.ToString();
            }
        }
    }
}
