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

namespace Doan_QLNH.Views
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }
        public static string userName = "";
        public static string pass = "";
        Models.DangNhapMod uctDN = new Models.DangNhapMod();

        /*frmMain frmdn = new frmMain();
        string sqlconnect = @"Data Source=LAPTOP-2NM25M6Q\SQLEXPRESS;Initial Catalog=dbSoftQuanLyNhaHang;Integrated Security=True";
        SqlConnection comm;
        SqlCommand command;*/

        private void frmDangKy_Load(object sender, EventArgs e)
        {

        }

        private void btnOkDangKy_Click(object sender, EventArgs e)
        {
            string i = "";
            //string passmoi = "";
            string passNhaplai = "";

            userName = txtUser.Text;
            pass = txtPassWorld.Text;
            //passmoi = txtPassMoi.Text;
            passNhaplai = txtPassWordNhapLai.Text;

            //errorProvider1.Clear();
            if (userName == "" || pass == "" || passNhaplai == "")
            {
                MessageBox.Show("chưa nhập đầy đủ thông tin ");
            }

            else
            {
                 i = Controllers.DangNhapCtrl.getDulieu_ktDeUpdate(userName, pass);

                if (pass != passNhaplai)
                {
                    MessageBox.Show("Mật khẩu nhập lại chưa đúng");
                }
                else if (i == "1")
                {

                    MessageBox.Show(" Tên tài khoản này đã được sử dụng ");
                }
                else if(i !="1" && pass ==passNhaplai)
                {
                    int ok = Controllers.DangNhapCtrl.InsertTaiKhoan(userName, pass, false);
                    if (ok > 0)
                    {
                        MessageBox.Show(" Đăng ký thành công" + ok);
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show(" Đăng ký không thành công" + ok);
                        //frmDangKy_Load(sender, e);
                    }
                }
                    
                
                else
                {
                    MessageBox.Show("Không thành công");
                }
            }
            /*try
            {
                comm = new SqlConnection(sqlconnect);
                comm.Open();
                string sql = "";
                string user = "";
                string pass = "";
                string passNhaplai = "";
                user = txtUser.Text;
                pass = txtPassWorld.Text;
                passNhaplai = txtPassWordNhapLai.Text;

                if (user == "")
                {
                    MessageBox.Show("Bạn không để trống user  này!");
                    return;
                }
                else
                {
                    sql = "Select Count(*) From DangNHap Where IdDangNhap ='" + user + "'";
                    command = new SqlCommand(sql, comm);
                    int val = (int)command.ExecuteScalar();
                    if (val > 0)
                    {
                        MessageBox.Show("user da duoc su daung");
                        return;
                    }

                }
                if (pass.ToString() == passNhaplai.ToString()&& pass !=""&& passNhaplai !="")
                {
                    MessageBox.Show(" dang ky thanh cong ");
                }
                else
                {
                    MessageBox.Show(" pass không giống nhau ");
                }

                sql = "insert into DangNhap(IdDangNhap, MatKhau, TrangThai) values (" + "'" + user + "','" + pass + "','0')";
                command = new SqlCommand(sql, comm);
                command.ExecuteNonQuery();
                comm.Close();
                frmdn.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi :" + ex);
            }*/
        }
    
    }
}
