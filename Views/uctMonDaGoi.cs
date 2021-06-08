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
    public partial class uctMonDaGoi : UserControl
    {
        public uctMonDaGoi()
        {
            InitializeComponent();
        }

        //string sqlconnect = @"Data Source=LAPTOP-2NM25M6Q\SQLEXPRESS;Initial Catalog=dbSoftQuanLyNhaHang;Integrated Security=True";
       // SqlConnection comm;
       // SqlCommand command;
        int flag = 0;
        
        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void HienThiDanhSachGM()
        {
            dgvGoiMon.DataSource = Models.GoiMonMod.FillDataSet_GoiMon().Tables[0];
            dgvGoiMon.Dock = DockStyle.Fill;
            dgvGoiMon.RowHeadersVisible = false;//xóa cốt đầu datagirview
            dgvGoiMon.BorderStyle = BorderStyle.Fixed3D;
        }
        void bingding()
        {
            cmbIdBan.DataBindings.Clear();
            cmbIdBan.DataBindings.Add("Text", dgvGoiMon.DataSource, "IdBan");
            //
            cmbTenThucDon.DataBindings.Clear();
            cmbTenThucDon.DataBindings.Add("Text", dgvGoiMon.DataSource, "TenThucDon");
            //
            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", dgvGoiMon.DataSource, "DonGiaTon");
            //
            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", dgvGoiMon.DataSource, "SoLuong");
            //
            dtpThoiGian.DataBindings.Clear();
            dtpThoiGian.DataBindings.Add("Text", dgvGoiMon.DataSource, "ThoiGian");
            //
           
            
        }
        void loadcontrolBan()
        {
            cmbIdBan.DataSource = Models.GoiMonMod.FillDataSet_getIdBan().Tables[0];// get lấy bang ra
            cmbIdBan.DisplayMember = "IdBan";// DisplayMember chọn định danh để hiển thị
            cmbIdBan.ValueMember = "IdBan";//ValueMember chọn giá trị để sử dụng
                                           // cmbIdBan.Show();
        }
        void loadcontroThucdon()
        {
            cmbTenThucDon.DataSource = Models.GoiMonMod.FillDataSet_getDonGiaThucDon().Tables[0];// get lấy bang ra
           cmbTenThucDon.DisplayMember = "TenThucDon";
            //cmbTenThucDon.DisplayMember = "DonGiaTon";
            cmbTenThucDon.ValueMember = "DonGiaTon";
            //cmbTenThucDon.Show();
        }
        void cleardata()
        {
            loadcontrolBan();
            loadcontroThucdon();
            txtDonGia.Text = cmbTenThucDon.SelectedValue.ToString();//? chọn cái value từ combobox thực đơn
            //có nghĩa là ứng với mỗi thực đơn có 1 đơn giá - cái này chúng ta đã định giá trước trong bang thuc don
            txtSoLuong.Text = "";
        }
        void dis_end(bool e)
        {
            cmbIdBan.Enabled = e;
            cmbTenThucDon.Enabled = e;
            txtDonGia.Enabled = e;
            txtSoLuong.Enabled = e;
            dtpThoiGian.Enabled = e;

            btnHuy.Enabled = e;
            btnLuu.Enabled = e;
            btnSua.Enabled = !e;
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
        }
        // Thêm 
        

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            cleardata();
            dis_end(true);
        }
        

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _idban = "";
            try
            {
                _idban = cmbIdBan.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("Bạn chắc muốn xóa", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.GoiMonCtrl.DeleteGoiMon(_idban);
                if (i > 0)
                {
                    MessageBox.Show("xóa thành công");
                    HienThiDanhSachGM();
                    uctMonDaGoi_Load(sender, e);
                }
                else
                    MessageBox.Show("Xóa thất bại");
            }
            else
                return;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_end(true);
            loadcontroThucdon();
            loadcontrolBan();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string _idBan = "";
            try
            {
                _idBan = cmbIdBan.Text;
            }
            catch { }
            //
            string _tenThucDon = "";
            try
            {
                _tenThucDon = cmbTenThucDon.Text;
            }
            catch { }
            //
            decimal _donGia = 0;
            try
            {
                _donGia= Convert.ToInt32(txtDonGia.Text);
            }
            catch { }
            //
            int _soluong = 0;
            try
            {
                _soluong = Convert.ToInt32(txtSoLuong.Text);
            }
            catch { }
            //
            DateTime _Thoigian = DateTime.Now;
            try
            {
                
            }
            catch { }
            //
            decimal _ThanhTIen = 0;
            try
            {
                _ThanhTIen = Convert.ToInt32(txtDonGia.Text);
            }
            catch { }
            
            ////
            ///
            if(flag==0)
            {
                if (_soluong == 0 || _donGia==0)
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = 0;
                    i = Controllers.GoiMonCtrl.InsertGoiMon(_idBan, _tenThucDon, _donGia, _soluong, _Thoigian, _ThanhTIen);
                    if (i > 0)
                    {
                        MessageBox.Show("Gọi món thành công");
                        HienThiDanhSachGM();
                    }
                    else
                        MessageBox.Show("Gọi món Không thành công");
                }
            }
            else
            {
                int i = 0;
                i = Controllers.GoiMonCtrl.UpdateGoiMon(_idBan, _tenThucDon, _donGia, _soluong, _Thoigian, _ThanhTIen);
                if (i > 0)
                {
                    MessageBox.Show("Thay đổi món thành công");
                    HienThiDanhSachGM();
                    uctMonDaGoi_Load(sender, e);
                }
                else
                    MessageBox.Show("Sửa Không thành công");
            }
            uctMonDaGoi_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            uctMonDaGoi_Load(sender, e);
            dis_end(false);
        }

        private void cmbTenThucDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtDonGia.Text = cmbTenThucDon.SelectedValue.ToString();
            }
            catch
            {
                MessageBox.Show(" lỗi rồi");
            }
            // gán cho txtDongia.text cho gia tri vulue cua gia tien cua dung ten thuc don đó
            
        }

        private void dgvDLMonGoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvGoiMon.CurrentRow.Index;
            cmbIdBan.Text = dgvGoiMon[0, row].Value.ToString();
            cmbTenThucDon.Text = dgvGoiMon[1, row].Value.ToString();
            txtSoLuong.Text = dgvGoiMon[2, row].Value.ToString();
            txtDonGia.Text = dgvGoiMon[3, row].Value.ToString();
            dtpThoiGian.Text = dgvGoiMon[4, row].Value.ToString();
        }
        // hàm này ngăn không cho người dùng nhập vào ký tự
        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar)&& !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void uctMonDaGoi_Load(object sender, EventArgs e)
        {
            HienThiDanhSachGM();
            bingding();
            dis_end(false);
        }

        
        private void dgvGoiMon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //
    }
}
