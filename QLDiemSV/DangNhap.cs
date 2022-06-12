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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txtPassWord.Text;
            
            if (Login(userName,passWord))
            {

                //liên kết tới form quản lý điểm
                QuanLyDiem f = new QuanLyDiem();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            
            if (LoginSV(userName, passWord))
            {

                //liên kết tới form quản lý điểm
                TraCuuTT f = new TraCuuTT();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng vui lòng nhập lại!!!");
            }
        }
        bool Login(string userName,string passWord) {
            return AccountDAO.Instance.Login(userName,passWord);
        }
        bool LoginSV(string userName, string passWord)
        {
            return AccountDAO.Instance.LoginSV(userName, passWord);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Hiển thị thông báo khi thoát
            if(MessageBox.Show("Bạn có chắc chắn thoát chương trình ?","Thông báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
