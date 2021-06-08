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
    public partial class frmBillHoaDon : Form
    {
        public frmBillHoaDon()
        {
            InitializeComponent();
        }

        public static uctMonDaGoi uctGM = new uctMonDaGoi();
        string sqlconnect = @"Data Source=LAPTOP-2NM25M6Q\SQLEXPRESS;Initial Catalog=dbSoftQuanLyNhaHang;Integrated Security=True";
        SqlConnection comm;
        SqlCommand command;

        public DataTable getBanDaGoi()
        {
            DataTable dt = new DataTable();
            dt = Models.GoiMonMod.FillDataSet_DanhSachBan_GoiMon().Tables[0];
            dgvDSHoaDonTheoBan.DataSource = dt;
            return dt;
        }

        public void HienThiDanhSachGM()
        {
            dgvDSHoaDonTheoBan.DataSource = Models.GoiMonMod.FillDataSet_GoiMon().Tables[0];
            dgvDSHoaDonTheoBan.Dock = DockStyle.Fill;
            dgvDSHoaDonTheoBan.RowHeadersVisible = false;//xóa cốt đầu datagirview
            dgvDSHoaDonTheoBan.BorderStyle = BorderStyle.Fixed3D;
        }
        void bingding()
        {
            cmbIdBan.DataBindings.Clear();
            cmbIdBan.DataBindings.Add("Text", dgvDSHoaDonTheoBan.DataSource, "IdBan");
            //
            //txtIdHoaDon.DataBindings.Clear();
           // txtIdHoaDon.DataBindings.Add("Text", dgvDSHoaDonTheoBan.DataSource, "IdHoaDon");
           // ////
            //txtTienKhachTra.DataBindings.Clear();
            //txtTienKhachTra.DataBindings.Add("Text", dgvDSHoaDonTheoBan.DataSource, "TenKhachTra");
            //
           // txtTienThuaTraLai.DataBindings.Clear();
           // txtTienThuaTraLai.DataBindings.Add("Text", dgvDSHoaDonTheoBan.DataSource, "TienThuaTraLai");
            //
            //txtTongTien.DataBindings.Clear();
           // txtTongTien.DataBindings.Add("Text", dgvDSHoaDonTheoBan.DataSource, "SoTien");
            //
          // dtpNgayLap.DataBindings.Clear();
           //dtpNgayLap.DataBindings.Add("Text", dgvDSHoaDonTheoBan.DataSource, "NgayLap");

        }
        void loadcontrolBan()
        {
            cmbIdBan.DataSource = Models.GoiMonMod.FillDataSet_getIdBan().Tables[0];// get lấy bang ra
            cmbIdBan.DisplayMember = "IdBan";// DisplayMember chọn định danh để hiển thị
            cmbIdBan.ValueMember = "IdBan";//ValueMember chọn giá trị để sử dụng
                                           // cmbIdBan.Show();
        }
        
        void cleardata()
        {
            loadcontrolBan();
            txtIdHoaDon.Text = Models.connection.ExcuteScalar(string.Format("select IdHoaDon = dbo.fcgetIdHoaDon()")) ;
           // txtTienKhachDua.Text = "";
            txtTongTien.Text = TongTien();
            
        }
        public string TongTien()
        {
            comm = new SqlConnection(sqlconnect);
            comm.Open();
            string sql = "";
            uctMonDaGoi uct = new uctMonDaGoi();

            string _IdBan = cmbIdBan.Text.ToString();
            DataTable dt = new DataTable();
            dt = Controllers.GoiMonCtrl.FillDataSet_getGoiMonByIdBan(_IdBan).Tables[0];
            dgvDSHoaDonTheoBan.DataSource = dt;
           

            sql = "select sum(gm.DonGiaTon*gm.SoLuong) from GoiMon gm where gm.IdBan  = '" + _IdBan + "'";
            command = new SqlCommand(sql, comm);
            string val = command.ExecuteScalar().ToString();
            
            
            return val;
        }

        public void TienThoiChoKhach()
        {
            double _TienTraKhach = 0;

            double _TienKhachDua = 0;
            double _Tongtien = 0;

            _TienKhachDua = double.Parse(txtTienKhachDua.Text);
            //_TienTraKhach = double.Parse(txtTienThuaTraLai.Text);
            _Tongtien = double.Parse(txtTongTien.Text);

            _TienTraKhach = _TienKhachDua - _Tongtien;

            txtTienThuaTraLai.Text = _TienTraKhach.ToString();
            txtTongTien.Text = string.Format("{0:0,0 }", decimal.Parse(txtTongTien.Text));
            txtTongTien.SelectionStart = txtTongTien.Text.Length;

        }
        void dis_end(bool e)
        {
            
            txtTienKhachDua.Enabled = e;
            btnThem.Enabled = !e;
            btnInHoaDon.Enabled = e;
           
        }


        private void lbltenTongTien_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            HienThiDanhSachGM();
            dis_end(false);
            bingding();
        }

        private void cmbIdBan_TextChanged(object sender, EventArgs e)
        {
            //string chuoicmb = cmbIdBan.Text.ToString();
            //string chuoi = "id Mã Nhân Viên".ToString();
            
                string _idNhanVien = cmbIdBan.Text.ToString();
                DataTable dt = new DataTable();
                dt = Controllers.GoiMonCtrl.FillDataSet_getGoiMonByIdBan(_idNhanVien).Tables[0];
                dgvDSHoaDonTheoBan.DataSource = dt;

           

            
            txtTongTien.Text = TongTien();
            //  TienThoiChoKhach();
            // txtTienThuaTraLai.Text = TienThoiChoKhach();

        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cleardata();
            dis_end(true);
        }

        private void txtTongTien_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtTienKhachTra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTienKhachTra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTienKhachDua_TextChanged_1(object sender, EventArgs e)
        {
            
           /// txtTienKhachDua.Text = string.Format("{0:0,0 }", decimal.Parse(txtTienKhachDua.Text));
          //  txtTienKhachDua.SelectionStart = txtTienKhachDua.Text.Length;

            string a = txtTienKhachDua.Text;
            txtTienKhachTra_autohien.Text = a;
            
            TienThoiChoKhach();
            
            // txtTienThuaTraLai.Text = a - TongTien();
            // txtTienKhachDua.Text = txtTienKhachTra_autohien.Text;
        }

        private void txtTienKhachTra_autohien_TextChanged(object sender, EventArgs e)
        {
            txtTienKhachTra_autohien.Text = string.Format("{0:0,0 }", decimal.Parse(txtTienKhachTra_autohien.Text));
            txtTienKhachTra_autohien.SelectionStart = txtTienKhachTra_autohien.Text.Length;
        }

        private void txtTienThuaTraLai_TextChanged(object sender, EventArgs e)
        {
            txtTienThuaTraLai.Text = string.Format("{0:0,0 }", decimal.Parse(txtTienThuaTraLai.Text));
            txtTienThuaTraLai.SelectionStart = txtTienThuaTraLai.Text.Length;

        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void frmBillHoaDon_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }
    }
}
