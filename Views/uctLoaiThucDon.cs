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
namespace Doan_QLNH.Views
{
    public partial class uctLoaiThucDon : UserControl
    {
        public uctLoaiThucDon()
        {
            InitializeComponent();
        }
        public static uctLoaiThucDon uctLTD = new uctLoaiThucDon();
        int flag = 0;

        // khai báo hàm hien3 thi DSNV de đổ dự liệu vào dataGridView
        public void HienThiDanhSachLoaiThucDon()
        {
            // trỏ tới data girview 
            dgvDSLoaiThucDon.DataSource = Models.LoaiThucDonMod.FillDataSetLoaiThucDon().Tables[0];
            dgvDSLoaiThucDon.BorderStyle = BorderStyle.Fixed3D;
            dgvDSLoaiThucDon.Dock = DockStyle.Fill;

            dgvDSLoaiThucDon.RowHeadersVisible = false;
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
            txtIDThucDon.DataBindings.Clear();
            txtIDThucDon.DataBindings.Add("Text", dgvDSLoaiThucDon.DataSource, "IdLoaiThucDon");
            //
            txtTenThucDon.DataBindings.Clear();
            txtTenThucDon.DataBindings.Add("Text", dgvDSLoaiThucDon.DataSource, "TenLoaiThucDon");
            //
            txtDienGiaiThucDon.DataBindings.Clear();
            txtDienGiaiThucDon.DataBindings.Add("Text", dgvDSLoaiThucDon.DataSource, "DienGiai");
            //
            cmbTrangThaiThucDon.DataBindings.Clear();
            cmbTrangThaiThucDon.DataBindings.Add("Text", dgvDSLoaiThucDon.DataSource, "TrangThai");
            //

        }
        void Ma_TudongTang()
        {
            int count = 0;
            count = dgvDSLoaiThucDon.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgvDSLoaiThucDon.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));
            if (chuoi2 + 1 < 10)

                dgvDSLoaiThucDon.Text = "LTĐ0" + (chuoi2 + 1).ToString();

            else if (chuoi2 + 1 < 1000)
            {

                dgvDSLoaiThucDon.Text = "LTĐ" + (chuoi2 + 1).ToString();
            }

        }
        // ham dis-end các button khi load len
        void dis_end(bool e)
        {
            txtIDThucDon.Enabled = e;
            // txtIDKhuVuc.Enabled = e;
            txtTenThucDon.Enabled = e;
            txtDienGiaiThucDon.Enabled = e;
            cmbTrangThaiThucDon.Enabled = e;

            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnXoa.Enabled = !e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
        }
        //hàm load gioi tinh cho nhan vien
        void loadcontrol()
        {
            cmbTrangThaiThucDon.Items.Clear();
            cmbTrangThaiThucDon.Items.Add("Còn");
            cmbTrangThaiThucDon.Items.Add("Đã hết");
            cmbTrangThaiThucDon.Show();


        }
        // ham xoa du lieu o textbox luc nhấn vào buton
        void clearData()
        {

            //Ma_TudongTang();
            txtIDThucDon.Text = Models.connection.ExcuteScalar(string.Format("select IdLoaiThucDon = dbo.FCgetIdLoaiThucDon()"));

            txtDienGiaiThucDon.Text = "";
            txtTenThucDon.Text = "";

            //cmbTrangThaiThucDon.Text = "";

            loadcontrol();
        }
        private void uctLoaiThucDon_Load(object sender, EventArgs e)
        {
            HienThiDanhSachLoaiThucDon();
            dis_end(false);
            bingding();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            string _idLoaiThucDon;
            _idLoaiThucDon = txtIDThucDon.Text;

            DialogResult dr = MessageBox.Show(" Bạn muốn xóa ?", " Xác Nhận .", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.LoaiThucDonCtrl.DeleteLoaiThucDon(_idLoaiThucDon);
                if (i > 0)
                {
                    MessageBox.Show(" Xóa thành công");
                    HienThiDanhSachLoaiThucDon();
                    uctLoaiThucDon_Load(sender, e);
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
            string _idLoaiThucDon = "";
            try
            {
                _idLoaiThucDon = txtIDThucDon.Text;
            }
            catch { }
            //
            string _tenLoaiThucdon = "";
            try
            {
                _tenLoaiThucdon = txtTenThucDon.Text;
            }
            catch { }
            //
            string _dienGiai = "";
            try
            {
                _dienGiai = txtDienGiaiThucDon.Text;
            }
            catch { }
            //

            //
            string _trangThai = "";
            try
            {
                _trangThai = cmbTrangThaiThucDon.Text;
            }
            catch { }
            //

            if (flag == 0)
            {
                // thêm mới
                if (_idLoaiThucDon == "" || _tenLoaiThucdon == "" || _trangThai == "")
                {
                    MessageBox.Show("Hãy nhập đầy đủ .");
                }
                else
                {
                    int i = 0;
                    i = Controllers.LoaiThucDonCtrl.InsertLoaiThucDon(_idLoaiThucDon, _tenLoaiThucdon, _dienGiai, _trangThai);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm thành công");
                        HienThiDanhSachLoaiThucDon();
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
                i = Controllers.LoaiThucDonCtrl.UpdateLoaiThucDon(_idLoaiThucDon, _tenLoaiThucdon, _dienGiai, _trangThai);
                if (i > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    HienThiDanhSachLoaiThucDon();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }

            }
            uctLoaiThucDon_Load(sender, e);
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            // load lại
            uctLoaiThucDon_Load(sender, e);
            dis_end(false);
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            //lúc click sửa mặt định dlag = 1;
            flag = 1;
            dis_end(true);// them xoa sua ẩn đi 
            loadcontrol();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            flag = 0;
            clearData();
            dis_end(true);
        }
    }
}
