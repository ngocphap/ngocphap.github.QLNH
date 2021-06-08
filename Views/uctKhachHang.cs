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
    public partial class uctKhachHang : UserControl
    {
        public uctKhachHang()
        {
            InitializeComponent();
        }

        int flag = 0;
        public static uctKhachHang uctKH = new uctKhachHang();

        // khai báo hàm hien3 thi DSkh de đổ dự liệu vào dataGridView
        public void HienThiDanhSachKhachHang()
        {
            // trỏ tới data nhan vien
            dgvDSKhachHang.DataSource = Models.KhachHangMod.FillDataSetKhachHang().Tables[0];
            dgvDSKhachHang.BorderStyle = BorderStyle.Fixed3D;
            dgvDSKhachHang.Dock = DockStyle.Fill;

            dgvDSKhachHang.RowHeadersVisible = false;
        }

        // hàm nhúng crl
        
        // hàm trỏ tới dữ liệu datagitview
        void bingding()
        {
            //
            txtIdKhachHang.DataBindings.Clear();
            txtIdKhachHang.DataBindings.Add("Text", dgvDSKhachHang.DataSource, "IdKhachHang");
            //
            txtTenKhachHang.DataBindings.Clear();
            txtTenKhachHang.DataBindings.Add("Text", dgvDSKhachHang.DataSource, "TenKhachHang");
            //
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgvDSKhachHang.DataSource, "DienThoai");
            //
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dgvDSKhachHang.DataSource, "Email");
            //
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvDSKhachHang.DataSource, "DiaChi");
            //
            cmbGioiTinh.DataBindings.Clear();
            cmbGioiTinh.DataBindings.Add("Text", dgvDSKhachHang.DataSource, "GioiTinh");
            //
           
        }
        
        // ham dis-end các button khi load len
        void dis_end(bool e)
        {
            txtIdKhachHang.Enabled = e;
            txtTenKhachHang.Enabled = e;
            txtSDT.Enabled = e;
            txtEmail.Enabled = e;
            txtDiaChi.Enabled = e;
            cmbGioiTinh.Enabled = e;
            
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnXoa.Enabled = !e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
        }
        //hàm load gioi tinh cho nhan vien
        void loadcontrol()
        {
            cmbGioiTinh.Items.Clear();
            cmbGioiTinh.Items.Add("Nam");
            cmbGioiTinh.Items.Add("Nữ");
            cmbGioiTinh.Items.Add("Khác");
        }
        // ham xoa du lieu o textbox luc nhấn vào buton
        void clearData()
        {
            //Ma_TudongTang();

            txtIdKhachHang.Text = Models.connection.ExcuteScalar(string.Format("select IdNhanVien = dbo.fcgetIdKhachHang()"));
            txtTenKhachHang.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
           
            loadcontrol();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            // load lại
            uctKhachHang_Load(sender, e);
            dis_end(false);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            //lúc click sửa mặt định dlag = 1;
            flag = 1;
            dis_end(true);// them xoa sua ẩn đi 
            loadcontrol();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            clearData();
            dis_end(true);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // khai báo các biến
            string _idKhachHang = "";
            try
            {
                _idKhachHang = txtIdKhachHang.Text;
            }
            catch { }
            //
            string _TenKhachHang = "";
            try
            {
                _TenKhachHang = txtTenKhachHang.Text;
            }
            catch { }
            //

            //
            string _gioitinhKhachHang = "";
            try
            {
                _gioitinhKhachHang = cmbGioiTinh.Text;
            }
            catch { }
            //
            string _emailKhachHang = "";
            try
            {
                _emailKhachHang = txtEmail.Text;
            }
            catch { }
            //
            string _diachiKhachHang = "";
            try
            {
                _diachiKhachHang = txtDiaChi.Text;
            }
            catch { }
            //
            string _dienthoai = "";
            try
            {
                _dienthoai = txtSDT.Text;
            }

            catch { }
            if (flag == 0)
            {
                // thêm mới
                if (_idKhachHang == "" || _TenKhachHang == "" || _dienthoai == ""||_diachiKhachHang=="")
                {
                    MessageBox.Show("Hãy nhập đầy đủ .");
                }
                else
                {
                    int i = 0;
                    i = Controllers.KhachHangCtrl.InsertKhachHang(_idKhachHang, _TenKhachHang, _gioitinhKhachHang, _dienthoai, _emailKhachHang, _diachiKhachHang);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm thành công");
                        HienThiDanhSachKhachHang();
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
                i = Controllers.KhachHangCtrl.UpdateKhachHang(_idKhachHang, _TenKhachHang, _gioitinhKhachHang, _dienthoai, _emailKhachHang, _diachiKhachHang);
                if (i > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    HienThiDanhSachKhachHang();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }

            }
            uctKhachHang_Load(sender, e);
        }
        



        private void uctKhachHang_Load(object sender, EventArgs e)
        {
            HienThiDanhSachKhachHang();
            //  Ma_TudongTang();
            dis_end(false);
            bingding();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _idKhachHang;
            _idKhachHang = txtIdKhachHang.Text;

            DialogResult dr = MessageBox.Show(" Bạn muốn xóa ?", " Xác Nhận .", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.KhachHangCtrl.DeleteKhachHang(_idKhachHang);
                if (i > 0)
                {
                    MessageBox.Show(" Xóa thành công");
                    HienThiDanhSachKhachHang();
                    uctKhachHang_Load(sender, e);
                }
                else
                    MessageBox.Show(" Xóa thất bại");
            }
            else
                return;


        }

    
    }
}
