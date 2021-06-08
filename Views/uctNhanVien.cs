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
    public partial class uctNhanVien : UserControl
    {
        public uctNhanVien()
        {
            InitializeComponent();
        }
        // khai báo biến để phân biệt lúc thêm và sửa
        int flag = 0;
        public static uctNhanVien uctNV = new uctNhanVien();

        // khai báo hàm hien3 thi DSNV de đổ dự liệu vào dataGridView
        public void HienThiDanhSachNhanVien()
        {
            // trỏ tới data nhan vien
            dgvDSNhanVien.DataSource = Models.NhanVienMod.FillDataSetNhanVien().Tables[0];
            dgvDSNhanVien.BorderStyle = BorderStyle.Fixed3D;
            dgvDSNhanVien.Dock = DockStyle.Fill;
           
            dgvDSNhanVien.RowHeadersVisible = false;
        }

        // hàm nhúng crl
        void nhung(Control ctr)
        {
            pnlDSNhanVien.Controls.Clear();
            pnlDSNhanVien.BorderStyle = BorderStyle.Fixed3D;
            ctr.Dock = DockStyle.Fill;
            pnlDSNhanVien.Controls.Add(ctr);
           pnlDSNhanVien.Show();
        }
        // hàm trỏ tới dữ liệu datagitview
        void bingding()
        {
            //
            txtIDNhanVien.DataBindings.Clear();
            txtIDNhanVien.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "IdNhanVien");
            //
            txtHolotNhanVien.DataBindings.Clear();
            txtHolotNhanVien.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "HoLot");
            //
            txtTenNhanVien.DataBindings.Clear();
            txtTenNhanVien.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "Ten");
            //
            dtpNgaysinhNhanVien.DataBindings.Clear();
            dtpNgaysinhNhanVien.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "Ngaysinh");
            //
            cmbGioiTinhNhanVien.DataBindings.Clear();
            cmbGioiTinhNhanVien.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "GioiTinh");
            //
            txtSDTNhanVien.DataBindings.Clear();
            txtSDTNhanVien.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "DienThoai");
            //
            txtEmailNhanVien.DataBindings.Clear();
            txtEmailNhanVien.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "Email");
            //
            txtDiaChiNhanVien.DataBindings.Clear();
            txtDiaChiNhanVien.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "DiaChi");
        }
        void Ma_TudongTang()
        {
            int count = 0;
            count = dgvDSNhanVien.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgvDSNhanVien.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));
            if (chuoi2 + 1 < 10)

                txtIDNhanVien.Text = "MNV0" + (chuoi2 + 1).ToString();

            else if (chuoi2 + 1 < 1000)
            {

                txtIDNhanVien.Text = "MNV" + (chuoi2 + 1).ToString();
            }
        }
        // ham dis-end các button khi load len
        void dis_end(bool e)
        {
            txtHolotNhanVien.Enabled = e;
            txtTenNhanVien.Enabled = e;
            dtpNgaysinhNhanVien.Enabled = e;
            cmbGioiTinhNhanVien.Enabled = e;
            txtDiaChiNhanVien.Enabled = e;
            txtSDTNhanVien.Enabled = e;
            txtEmailNhanVien.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnXoa.Enabled = !e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
        }
        //hàm load gioi tinh cho nhan vien
         void loadcontrol()
        {
            cmbGioiTinhNhanVien.Items.Clear();
            cmbGioiTinhNhanVien.Items.Add("Nam");
            cmbGioiTinhNhanVien.Items.Add("Nữ");
            cmbGioiTinhNhanVien.Items.Add("Khác");
        }
        // ham xoa du lieu o textbox luc nhấn vào buton
        void clearData()
        {
           //Ma_TudongTang();

           txtIDNhanVien.Text = Models.connection.ExcuteScalar(string.Format("select IdNhanVien = dbo.FCgetIdNhanVien()"));
            txtHolotNhanVien.Text = "";
            txtTenNhanVien.Text = "";
            txtSDTNhanVien.Text = "";
            txtEmailNhanVien.Text = "";
            txtDiaChiNhanVien.Text = "";
            loadcontrol();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            // load lại
            uctNhanVien_Load(sender, e);
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
            string _idNhanVien = "";
            try
            { 
                _idNhanVien = txtIDNhanVien.Text; 
            }
            catch { }
            //
            string _holotNhanVien = "";
            try
            { 
                _holotNhanVien = txtHolotNhanVien.Text;
            }
            catch { }
            //
            string _tenNhanVien = "";
            try 
            { 
                _tenNhanVien = txtTenNhanVien.Text;
            }
            catch { }
            //
            DateTime _ngaysinhNhanVien = dtpNgaysinhNhanVien.Value;
            try 
            {

            } 
            catch { }
            //
            string _gioitinhNhanVien = "";
            try
            {
                _gioitinhNhanVien = cmbGioiTinhNhanVien.Text;
            }
            catch { }
            //
            string _emalNhanVien = "";
            try
            {
                _emalNhanVien = txtEmailNhanVien.Text;
            }
            catch { }
            //
            string _diachiNhanVien = "";
            try 
            {
                _diachiNhanVien = txtDiaChiNhanVien.Text;
            }
            catch { }
            //
            string _dienthoaiNhanVien = "";
            try 
            {
                _dienthoaiNhanVien = txtSDTNhanVien.Text; }

            catch { }
            if(flag ==0)
            {
                // thêm mới
                if(_idNhanVien ==""|| _tenNhanVien ==""|| _holotNhanVien =="")
                {
                    MessageBox.Show("Hãy nhập đầy đủ .");
                }
                else
                {
                    int i = 0;
                    i = Controllers.NhanVienCtrl.InsertNhanVien(_idNhanVien, _holotNhanVien, _tenNhanVien, _ngaysinhNhanVien, _gioitinhNhanVien, _dienthoaiNhanVien, _emalNhanVien, _diachiNhanVien);
                    if(i>0)
                    {
                        MessageBox.Show("Thêm thành công");
                        HienThiDanhSachNhanVien();
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
                i = Controllers.NhanVienCtrl.UpdateNhanVien(_idNhanVien, _holotNhanVien, _tenNhanVien, _ngaysinhNhanVien, _gioitinhNhanVien, _dienthoaiNhanVien, _emalNhanVien, _diachiNhanVien);
                if (i > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    HienThiDanhSachNhanVien();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }

            }
            uctNhanVien_Load(sender, e);
        }
        private void grQLNhanVien_Enter(object sender, EventArgs e)

        { 
        }

       
        
        private void uctNhanVien_Load(object sender, EventArgs e)
        {
            HienThiDanhSachNhanVien();
          //  Ma_TudongTang();
            dis_end(false);
            bingding();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _idNhanvien;
            _idNhanvien = txtIDNhanVien.Text;
           
            DialogResult dr = MessageBox.Show(" Bạn muốn xóa ?", " Xác Nhận .", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.NhanVienCtrl.DeleteNhanVien(_idNhanvien);
                if (i > 0)
                {
                    MessageBox.Show(" Xóa thành công");
                    HienThiDanhSachNhanVien();
                    uctNhanVien_Load(sender, e);
                }
                else
                    MessageBox.Show(" Xóa thất bại");
            }
            else
                return;


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            uctSearchNhanVien utcS = new uctSearchNhanVien();
            nhung(utcS);
        }

        private void pnlDSNhanVien_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnhide_Click(object sender, EventArgs e)
        {
            pnlDSNhanVien.Controls.Clear();
            pnlDSNhanVien.BorderStyle = BorderStyle.None;
        }
    }
}
