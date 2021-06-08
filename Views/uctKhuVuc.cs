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
    public partial class uctKhuVuc : UserControl
    {
        public uctKhuVuc()
        {
            InitializeComponent();
        }
        int flag = 0;
        public static uctKhuVuc uctKV = new uctKhuVuc();

        // khai báo hàm hien3 thi DSNV de đổ dự liệu vào dataGridView
        public void HienThiDanhSachKhuVuc()
        {
            // trỏ tới data girview 
            dgvDSKhuVuc.DataSource = Models.KhuVucMod.FillDataSetKhuVuc().Tables[0];
            dgvDSKhuVuc.BorderStyle = BorderStyle.Fixed3D;
            dgvDSKhuVuc.Dock = DockStyle.Fill;

            dgvDSKhuVuc.RowHeadersVisible = false;
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
            txtIDKhuVuc.DataBindings.Clear();
            txtIDKhuVuc.DataBindings.Add("Text", dgvDSKhuVuc.DataSource, "IdKhuVuc");
            //
            txtTenKhuVuc.DataBindings.Clear();
            txtTenKhuVuc.DataBindings.Add("Text", dgvDSKhuVuc.DataSource, "TenKhuVuc");
            //
            txtDienGiai.DataBindings.Clear();
            txtDienGiai.DataBindings.Add("Text", dgvDSKhuVuc.DataSource, "DienGiai");
            //
            cmbTrangThaiKhuVuc.DataBindings.Clear();
            cmbTrangThaiKhuVuc.DataBindings.Add("Text", dgvDSKhuVuc.DataSource, "TrangThai");
            //
            
        }
        void Ma_TudongTang()
        {
            int count = 0;
            count = dgvDSKhuVuc.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgvDSKhuVuc.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));
            if (chuoi2 +1<10)
            
                txtIDKhuVuc.Text = "MKV0" + (chuoi2 + 1).ToString();
            
            else if(chuoi2 +1<1000)
            {
                
                txtIDKhuVuc.Text = "MKV" + (chuoi2 + 1).ToString();
            }

        }
        // ham dis-end các button khi load len
        void dis_end(bool e)
        {
            txtTenKhuVuc.Enabled = e;
           // txtIDKhuVuc.Enabled = e;
            txtTenKhuVuc.Enabled = e;
            cmbTrangThaiKhuVuc.Enabled = e;
            
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnXoa.Enabled = !e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
        }
        //hàm load gioi tinh cho nhan vien
        void loadcontrol()
        {
            cmbTrangThaiKhuVuc.Items.Clear();
            cmbTrangThaiKhuVuc.Items.Add("Hoạt động");
            cmbTrangThaiKhuVuc.Items.Add("Ngừng hoạt động");
            cmbTrangThaiKhuVuc.Show();
        }
        // ham xoa du lieu o textbox luc nhấn vào buton
        void clearData()
        {
           
          //Ma_TudongTang();
           txtIDKhuVuc.Text = Models.connection.ExcuteScalar(string.Format("select IdKhuVuc = dbo.FCgetIdKhuVuc()"));
           
            txtDienGiai.Text = "";
            txtTenKhuVuc.Text = "";

            cmbTrangThaiKhuVuc.Text = "";
            
            loadcontrol();
        }
        private void uctKhuVuc_Load(object sender, EventArgs e)
        {
            HienThiDanhSachKhuVuc();
            dis_end(false);
            bingding();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _idKhuVuc;
            _idKhuVuc = txtIDKhuVuc.Text;

            DialogResult dr = MessageBox.Show(" Bạn muốn xóa ?", " Xác Nhận .", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.KhuVucCtrl.DeleteKhuVuc(_idKhuVuc);
                if (i > 0)
                {
                    MessageBox.Show(" Xóa thành công");
                    HienThiDanhSachKhuVuc();
                    uctKhuVuc_Load(sender, e);
                }
                else
                    MessageBox.Show(" Xóa thất bại");
            }
            else
                return;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // khai báo các biến
            string _idKhuVuc = "";
            try
            {
                _idKhuVuc = txtIDKhuVuc.Text;
            }
            catch { }
            //
            string _tenKhuVuc = "";
            try
            {
                _tenKhuVuc = txtTenKhuVuc.Text;
            }
            catch { }
            //
            string _dienGiai = "";
            try
            {
                _dienGiai = cmbTrangThaiKhuVuc.Text;
            }
            catch { }
            //
           
            //
            string _trangThai = "";
            try
            {
                _trangThai = txtDienGiai.Text;
            }
            catch { }
            //
            
            if (flag == 0)
            {
                // thêm mới
                if (_idKhuVuc == "" || _tenKhuVuc == "" || _trangThai == "")
                {
                    MessageBox.Show("Hãy nhập đầy đủ .");
                }
                else
                {
                    int i = 0;
                    i = Controllers.KhuVucCtrl.InsertKhuVuc(_idKhuVuc, _tenKhuVuc, _trangThai, _dienGiai);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm thành công");
                        HienThiDanhSachKhuVuc();
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
                i = Controllers.KhuVucCtrl.UpdateKhuVuc(_idKhuVuc, _tenKhuVuc, _trangThai, _dienGiai);
                if (i > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    HienThiDanhSachKhuVuc();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }

            }
            uctKhuVuc_Load(sender, e);
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

        private void txtDienGiai_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbTrangThaiKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
           // loadcontrol();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // load lại
            uctKhuVuc_Load(sender, e);
            dis_end(false);
        }
    }
}
