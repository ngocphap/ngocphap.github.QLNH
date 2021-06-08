using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;
using DevExpress.XtraEditors;
using Doan_QLNH.Views;
using System.Data.SqlClient;

namespace Doan_QLNH
{
    
    public partial class frmMain : Form
    {
        
        public static string user;
        public static string idLogin;
        public frmMain()
        {
            InitializeComponent();
            
        }
        public void DisEnd_menuDangnhap(bool e ,string _idLogin)
        {
            
        }





        internal static List<byte> typePages = new List<byte>();
        public void ThemTabPages(UserControl uct, byte typeControl , string tenTab)
        {
            // kiem tra tồn tại trang này chưa
            for( int i=0;i < tabHienThi.TabPages.Count;i++)
            {
                if(tabHienThi.TabPages[i].Contains(uct) == true)
                {
                    tabHienThi.SelectedTab = tabHienThi.TabPages[i];
                    return;
                }
            }
            TabPage tab = new TabPage();
            typePages.Add(typeControl);
            tab.Name = uct.Name;
            tab.Size = tabHienThi.Size;
            tab.Text = tenTab;
            tabHienThi.TabPages.Add(tab);
            tabHienThi.SelectedTab = tab;
            uct.Dock = DockStyle.Fill;
            tab.Controls.Add(uct);
            uct.Focus();
        }

        // Đóng tab hiển thị
        public void DongTabHienTai()
        {
            tabHienThi.TabPages.Remove(tabHienThi.SelectedTab);
        }
        //dong tat ca tab
        public void DongAllTab()
        {
            while(tabHienThi.TabPages.Count > 0)
            {
                DongTabHienTai();
            }
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn thoát", " Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
                return;
        }

        private void đóngTabHiệnTạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongTabHienTai();
        }

        private void đóngTấtCảTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongAllTab();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.uctNhanVien.uctNV, 4, "Quản lý nhân viên");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           
            DisEndMenuLogin(true);
            
        }
        public void Hienthi()
        {
            frmMain frm = new frmMain();
            frm.ShowDialog();
            DisEndMenuLogin(false);
        }
        private void hệThốngKhuVựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.uctKhuVuc.uctKV, 4, "Hệ thống khu vực");
        }

        private void bànKhuVựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.uctBan.uctB, 4, "Bàn Khu vực");
        }

        private void loạiThựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.uctLoaiThucDon.uctLTD, 4, "Loại thực đơn");
        }

        private void thựcĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.uctThucDon.uctTD, 4, "Thực đơn");
        }

        private void gọiMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.uctGoiMon.uctGM, 4, "Gọi Món");
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void tabHienThi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
       



        public void DisEndMenuLogin(bool e)
        {
            tsMenuDangNhap.Enabled = e;
            tsMenuGoiMon.Enabled = !e;
            tsMenuHeThong.Enabled = !e;
            tsMenuKhuVuc.Enabled = !e;
            tsMenuQuanLy.Enabled = !e;
            tsMenuThucDon.Enabled = !e;
            tsMenuThuChi.Enabled = !e;
            

        }
        private void đăngNhậpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //this.Hide();
            
            frmDangNhap doimatkhau = new frmDangNhap();
            doimatkhau.ShowDialog();
           // this.Close();
            frmMain_Load(sender, e);
            DisEndMenuLogin(false);
        
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DisEndMenuLogin(true);
                DongAllTab();
                đăngNhậpToolStripMenuItem_Click_1(sender, e);
               
            }
        }

        private void kiểmCaGiaoTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.uctKhachHang.uctKH, 4, "Quản lý khách hàng");
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau doimatkhau = new frmDoiMatKhau();
            doimatkhau.ShowDialog();
            frmMain_Load(sender, e);
            DisEndMenuLogin(false);
        }

        private void đổiMậtKhẩuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmDoiMatKhau doimatkhau = new frmDoiMatKhau();
            doimatkhau.ShowDialog();
            frmMain_Load(sender, e);
            DisEndMenuLogin(false);
        }
    }
}
