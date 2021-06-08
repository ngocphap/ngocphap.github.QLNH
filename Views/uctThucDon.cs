using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doan_QLNH.Views
{
    public partial class uctThucDon : UserControl
    {
        public uctThucDon()
        {
            InitializeComponent();
        }
        int flag = 0;
        public static uctThucDon uctTD = new uctThucDon();

        // khai báo hàm hien3 thi DSNV de đổ dự liệu vào dataGridView
        public void HienThiDanhSachThucDOn()
        {
            // trỏ tới data nhan vien
            dgvDSThucDon.DataSource = Models.ThucDonMod.FillDataSet_ThucDon().Tables[0];
            dgvDSThucDon.BorderStyle = BorderStyle.Fixed3D;
            dgvDSThucDon.Dock = DockStyle.Fill;

            dgvDSThucDon.RowHeadersVisible = false;
        }

        
        void bingding()
        {

            //picThucDon.Image
            //picThucDon.DataBindings.Clear();
           // picThucDon.DataBindings.Add("Image", dgvDSThucDon.DataSource, "HinhAnh");
            //
            txtIDThucDon.DataBindings.Clear();
            txtIDThucDon.DataBindings.Add("Text", dgvDSThucDon.DataSource, "IdThucDon");
            //
            cmbLoaiThucDon.DataBindings.Clear();
            cmbLoaiThucDon.DataBindings.Add("Text", dgvDSThucDon.DataSource, "TenLoaiThucDon");
            //
            txtTenThucDonMoi.DataBindings.Clear();
            txtTenThucDonMoi.DataBindings.Add("Text", dgvDSThucDon.DataSource, "TenThucDon");
            //
            txtDonViTinh.DataBindings.Clear();
            txtDonViTinh.DataBindings.Add("Text", dgvDSThucDon.DataSource, "DonViTinh");
            //
            txtSoLuongTon.DataBindings.Clear();
            txtSoLuongTon.DataBindings.Add("Text", dgvDSThucDon.DataSource, "SoLuongTon");
            //
            txtDonGiaTon.DataBindings.Clear();
            txtDonGiaTon.DataBindings.Add("Text", dgvDSThucDon.DataSource, "DonGiaTon");
            //
            //txtTonToiThieu.DataBindings.Clear();
           // txtTonToiThieu.DataBindings.Add("Text", dgvDSThucDon.DataSource, "TonToiThieu");
            ///
            cmbTrangThai.DataBindings.Clear();
            cmbTrangThai.DataBindings.Add("Text", dgvDSThucDon.DataSource, "TrangThai");
        }
        void Ma_TudongTang()
        {
            int count = 0;
            count = dgvDSThucDon.Rows.Count;
            string chuoi = "MTĐ";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgvDSThucDon.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));
            if (chuoi2 + 1 < 10)

                txtIDThucDon.Text = "MTĐ0" + (chuoi2 + 1).ToString();

            else if (chuoi2 + 1 < 1000)
            {

                txtIDThucDon.Text = "MTĐ" + (chuoi2 + 1).ToString();
            }
        }
        // ham dis-end các button khi load len
        void dis_end(bool e)
        {
            picThucDon.Enabled = e;
            txtIDThucDon.Enabled = e;
            txtTenThucDonMoi.Enabled = e;
            //txtTonToiThieu.Enabled = e;
            txtSoLuongTon.Enabled = e;
            txtDonViTinh.Enabled = e;
            txtDonGiaTon.Enabled = e;
            cmbTrangThai.Enabled = e;
            cmbLoaiThucDon.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnXoa.Enabled = !e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
        }
        //hàm load gioi tinh cho nhan vien
        void loadcontrol()
        {
            cmbTrangThai.Items.Clear();
            cmbTrangThai.Items.Add("Còn");
            cmbTrangThai.Items.Add("Hết");
            cmbTrangThai.Items.Add("Khác");
            //
            // gọi lại data của Loaithuc cho cmbtenloaithucdon

            cmbLoaiThucDon.DataSource = Models.LoaiThucDonMod.FillDataSetLoaiThucDon().Tables[0];
            // ta dùng biến TenKhuVuc để hiển thị ( lấy giá trị Tenkhuvuc)
            cmbLoaiThucDon.DisplayMember = "TenLoaiThucDon";

        }
        // ham xoa du lieu o textbox luc nhấn vào buton
        void clearData()
        {
            //Ma_TudongTang();

            txtIDThucDon.Text = Models.connection.ExcuteScalar(string.Format("select IdLoaiThucDon = dbo.fcgetIdThucDon()"));
            txtDonGiaTon.Text = "";
            txtDonViTinh.Text = "";
            txtSoLuongTon.Text = "";
            txtTenThucDonMoi.Text = "";
            picThucDon.Image = null;
            //txtTonToiThieu.Text = "";
            loadcontrol();
        }
      
        private void uctThucDon_Load(object sender, EventArgs e)
        {
            HienThiDanhSachThucDOn();
            //  Ma_TudongTang();
            dis_end(false);
            bingding();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            flag = 0;
            //MoOpeFile();
            clearData();
            dis_end(true);
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            string _idThucDon;
            _idThucDon = txtIDThucDon.Text;

            DialogResult dr = MessageBox.Show(" Bạn muốn xóa ?", " Xác Nhận .", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.ThucDonCtrl.DeleteThucDon(_idThucDon);
                if (i > 0)
                {
                    MessageBox.Show(" Xóa thành công");
                    HienThiDanhSachThucDOn();
                    uctThucDon_Load(sender, e);
                }
                else
                    MessageBox.Show(" Xóa thất bại");
            }
            else
                return;
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            //lúc click sửa mặt định dlag = 1;
            flag = 1;
            dis_end(true);// them xoa sua ẩn đi 
            loadcontrol();
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            // load lại
            uctThucDon_Load(sender, e);
            dis_end(false);
        }
        public void MoOpeFile()
        {
            openfileDialod_Image.ShowDialog();
            string file = openfileDialod_Image.FileName;
            
            if (string.IsNullOrEmpty(file))
                return;
            Image myImage = Image.FromFile(file);
            picThucDon.Image = myImage;
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            // khai báo các biến
            string _idThucDOn = "";
            try
            {
                _idThucDOn = txtIDThucDon.Text;
            }
            catch { }
            //
            string _tenloaithucdon = "";
            try
            {
                _tenloaithucdon = cmbLoaiThucDon.Text;
            }
            catch { }
            //
            string _tenThucDon = "";
            try
            {
                _tenThucDon = txtTenThucDonMoi.Text;
            }
            catch { }
            //
            string _DonViTinh = "";
            try
            {
                _DonViTinh = txtDonViTinh.Text;
            }
            catch { }
            //
            decimal _dongiaton = 0;
            try
            {
                _dongiaton = Convert.ToInt32(txtDonGiaTon.Text);
            }
            catch { }
            //
            byte[] _Hinhanh = null;
            try

            {
                _Hinhanh = ImageToByteArray(picThucDon.Image);
            }
            catch { }
            //
            int _soluongton = 0;
            try
            {
                _soluongton = Convert.ToInt32( txtSoLuongTon.Text);
            }
            catch { }
            //
            string _trangthai = "";
            try
            {
                _trangthai = cmbTrangThai.Text;
            }

            catch { }
            if (flag == 0)
            {
                // thêm mới
                if (_tenThucDon == "" || _tenloaithucdon == "" || _DonViTinh == "")
                {
                    MessageBox.Show("Hãy nhập đầy đủ .");
                }
                else
                {
                    int i = 0;
                    i = Controllers.ThucDonCtrl.InsertThucDon(_idThucDOn, _tenloaithucdon, _tenThucDon, _DonViTinh, _soluongton, _dongiaton, _trangthai,_Hinhanh);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm thành công");
                        HienThiDanhSachThucDOn();
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
                i = Controllers.ThucDonCtrl.UpdateThucDon(_idThucDOn, _tenloaithucdon, _tenThucDon, _DonViTinh, _soluongton, _dongiaton, _trangthai,_Hinhanh);
                if (i > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    HienThiDanhSachThucDOn();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }

            }
            uctThucDon_Load(sender, e);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
           
            openfileDialod_Image.CheckFileExists = true;
            openfileDialod_Image.CheckPathExists = true;
            openfileDialod_Image.DefaultExt = "jpg";
            openfileDialod_Image.DereferenceLinks = true;
            openfileDialod_Image.FileName = ".jpg";
            openfileDialod_Image.Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.jpg)|*.jpg|All files|*.*";
            openfileDialod_Image.Multiselect = false;
            openfileDialod_Image.RestoreDirectory = true;
            openfileDialod_Image.Title = "Select a file to open";
            openfileDialod_Image.ValidateNames = true;
            if (openfileDialod_Image.ShowDialog() == DialogResult.OK)
            {
                picThucDon.Image = Image.FromFile(openfileDialod_Image.FileName);
                
            }
            
        }
        // chuyen image sang byte[]
        byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        public void ThemAnh()
        {
            
        }
    }
}
