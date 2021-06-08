using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Doan_QLNH.Views
{
    public partial class frmDoiMatKhau : Form
    {
        public static string userName = "";
        public static string pass = "";
        Models.DangNhapMod uctDN = new Models.DangNhapMod();

        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnOkDangKy_Click(object sender, EventArgs e)
        {
            string i = "";
            string passmoi = "";
            string nhaplaipass = "";

            userName = txtUser.Text;
            pass = txtPassCu.Text;
            passmoi = txtPassMoi.Text;
            nhaplaipass = txtNhapLaiPass.Text;

            //errorProvider1.Clear();
            if (userName == "" || pass == "" || passmoi == "" || nhaplaipass == "")
            {
                MessageBox.Show("chưa nhập đầy đủ thông tin ");
            }
            
            else 
            {
                i = Controllers.DangNhapCtrl.getDulieu_ktDeUpdate(userName, pass);

                 if (passmoi != nhaplaipass)
                {
                    MessageBox.Show("Mật khẩu nhập lại chưa đúng");
                }
                else if (i == "1" && passmoi == nhaplaipass)
                {


                    int ok = Controllers.DangNhapCtrl.UpdateTaiKhoan(userName, passmoi);
                    if (ok > 0)
                    {
                        MessageBox.Show(" ĐỔi thành công" + ok);
                        this.Close();
                        /*DialogResult da = MessageBox.Show(" Bạn muốn đăng nhập tài khoản ", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (da==DialogResult.Yes)
                        {
                            
                            frmMain.ShowDialog();
                            this.Close();
                        }
                            else
                        {
                            frmDangNhap frnDN = new frmDangNhap();
                            frnDN.ShowDialog();
                            this.Close();
                        }*/
                        
                    }
                    else
                    {
                        MessageBox.Show(" ĐỔi không thành công" + ok);
                    }
                }
                else
                {
                        MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng kiểm tra lại");
                }
            }

        }
    

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
