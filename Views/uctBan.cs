using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doan_QLNH.Views
{
    public partial class uctBan : UserControl
    {
        public uctBan()
        {
            InitializeComponent();
        }
        int flag = 0;// gán cờ để xác định thêm hoặc sửa
        public static uctBan uctB = new uctBan();
        // khai báo hàm hien3 thi DSNV de đổ dự liệu vào dataGridView
        public void HienThiDanhSachBan()
        {
            // trỏ tới data girview 
            dgvDSBan.DataSource = Models.BanMod.FillDataSetBan().Tables[0];
            dgvDSBan.BorderStyle = BorderStyle.Fixed3D;
            dgvDSBan.Dock = DockStyle.Fill;

            dgvDSBan.RowHeadersVisible = false;
        }

        // hàm nhúng crl
        /*void nhung(Control ctr)
        {
            pnlDSNhanVien.Controls.Clear();
            pnlDSNhanVien.BorderStyle = BorderStyle.Fixed3D;
            ctr.Dock = DockStyle.Fill;
            pnlDSNhanVien.Controls.Add(ctr);
            pnlDSNhanVien.Show();
        }*/
        // hàm trỏ tới dữ liệu datagitview
        void bingding()
        {
            //
            txtIDBan.DataBindings.Clear();
            txtIDBan.DataBindings.Add("Text", dgvDSBan.DataSource, "IdBan");
            //
            cmbTenKhuVuc.DataBindings.Clear();
            cmbTenKhuVuc.DataBindings.Add("Text", dgvDSBan.DataSource, "TenKhuVuc");
            //
            txtTenBanMoi.DataBindings.Clear();
            txtTenBanMoi.DataBindings.Add("Text", dgvDSBan.DataSource, "TenBan");
            //
            txtDienGiai.DataBindings.Clear();
            txtDienGiai.DataBindings.Add("Text", dgvDSBan.DataSource, "DienGiai");
            
            //
            cmbTrangThaiBan.DataBindings.Clear();
            cmbTrangThaiBan.DataBindings.Add("Text", dgvDSBan.DataSource, "TrangThai");
        }
        void Ma_TudongTang()
        {
            int count = 0;
            count = dgvDSBan.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgvDSBan.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
            if (chuoi2 + 1 < 10)

                txtIDBan.Text = "MB0" + (chuoi2 + 1).ToString();

            else if (chuoi2 + 1 < 1000)
            {

                txtIDBan.Text = "MB" + (chuoi2 + 1).ToString();
            }

        }
        // ham dis-end các button khi load len
        void dis_end(bool e)
        {
            txtIDBan.Enabled = e;
            cmbTenKhuVuc.Enabled = e;
            txtTenBanMoi.Enabled = e;
            txtDienGiai.Enabled = e;
            cmbTrangThaiBan.Enabled = e;
            

            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnXoa.Enabled = !e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
        }
        //hàm load gioi tinh cho nhan vien
        void loadcontrol()
        {
            // trang thai ban : trống , không còn trong
            cmbTrangThaiBan.Items.Clear();
            cmbTrangThaiBan.Items.Add("Trống, chưa có khách");
            cmbTrangThaiBan.Items.Add("Có khách");
            cmbTrangThaiBan.Show();

            // gọi lại data của khuvucmod cho cmbKhuvuc
            
            cmbTenKhuVuc.DataSource = Models.KhuVucMod.getTenKhuVuc().Tables[0];
            // ta dùng biến TenKhuVuc để hiển thị ( lấy giá trị Tenkhuvuc)
            cmbTenKhuVuc.DisplayMember = "TenKhuVuc";
        }
        
        void clearData()
        {

            //Ma_TudongTang();
            txtIDBan.Text = Models.connection.ExcuteScalar(string.Format("select IdBan = dbo.FCgetIdBan()"));
            loadcontrol();
           
            txtTenBanMoi.Text = "";
            txtDienGiai.Text = "";
        }
        private void uctBan_Load(object sender, EventArgs e)
        {
            HienThiDanhSachBan();
            dis_end(false);
            bingding();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            clearData();
            dis_end(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //lúc click sửa mặt định dlag = 1;
            flag = 1;
            dis_end(true);// them xoa sua ẩn đi 
            loadcontrol();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // load lại
            uctBan_Load(sender, e);
            dis_end(false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // khai báo các biến
            string _idBan = "";
            try
            {
                _idBan = txtIDBan.Text;
            }
            catch { }
            //
            string _tenBan = "";
            try
            {
                _tenBan = txtTenBanMoi.Text;
            }
            catch { }
            //
            string _dienGiai = "";
            try
            {
                _dienGiai = txtDienGiai.Text;
            }
            catch { }
            //

            //
            string _trangThai = "";
            try
            {
                _trangThai = cmbTrangThaiBan.Text;
            }
            catch { }
            //
            string _tenKhuVuc = "";
            try
            {
                _tenKhuVuc = cmbTenKhuVuc.Text;
            }
            catch { }
            //
            if (flag == 0)
            {
                // thêm mới
                if (_tenBan == "" || _tenKhuVuc == "" || _trangThai == "")
                {
                    MessageBox.Show("Hãy nhập đầy đủ .");
                }
                else
                {
                    int i = 0;
                    i = Controllers.BanCtrl.InsertBan(_idBan, _tenKhuVuc, _tenBan, _dienGiai,_trangThai);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm thành công");
                        HienThiDanhSachBan();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }

            }
            else
            {
                // sửa
                int i = 0;
                i = Controllers.BanCtrl.UpdateBan(_idBan,_tenKhuVuc, _tenBan, _dienGiai, _trangThai);
                if (i > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    HienThiDanhSachBan();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }

            }
            uctBan_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _idBan;
            _idBan = txtIDBan.Text;

            DialogResult dr = MessageBox.Show(" Bạn muốn xóa ?", " Xác Nhận .", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.BanCtrl.DeleteBan(_idBan);
                if (i > 0)
                {
                    MessageBox.Show(" Xóa thành công");
                    HienThiDanhSachBan();
                    uctBan_Load(sender, e);
                }
                else
                    MessageBox.Show(" Xóa thất bại");
            }
            else
                return;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTenKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
