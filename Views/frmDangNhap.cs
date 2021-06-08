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
using Doan_QLNH.Views;
namespace Doan_QLNH.Views
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        /*string sqlconnect= @"Data Source=LAPTOP-2NM25M6Q\SQLEXPRESS;Initial Catalog=dbSoftQuanLyNhaHang;Integrated Security=True";
        SqlConnection comm;
        SqlCommand command;*/

        public static string userName = "";
        public static string pass = "";
        Models.DangNhapMod uctDN = new Models.DangNhapMod();

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            TopMost = true;
            txtPassWord.Properties.PasswordChar = '*';
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {

            this.Hide();
           
            frmDangKy dangky = new frmDangKy();
            dangky.ShowDialog();
            frmDangNhap_Load(sender, e);
        }

        private void btnOkDangNhap_Click(object sender, EventArgs e)
        {
            string i = "";
           
            userName = txtUser.Text;
            pass = txtPassWord.Text;
           
            if (userName == "" || pass == "")
            {
                MessageBox.Show("chưa nhập đầy đủ thông tin ");
            }

            else
            {
                i = Controllers.DangNhapCtrl.getDulieu_ktDeUpdate(userName, pass);
                if (i == "1")
                {

                    MessageBox.Show(" Đăng Nhập thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(" Sai tên hoặc sai mật khẩu ");
                }

            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            frmMain frm = new frmMain();
            frm.ShowDialog();
           // this.Close();
        }
    }

}
