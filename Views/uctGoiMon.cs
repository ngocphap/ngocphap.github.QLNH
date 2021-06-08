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
    public partial class uctGoiMon : UserControl
    {
        public uctGoiMon()
        {
            InitializeComponent();
        }
        public static uctGoiMon uctGM = new uctGoiMon();
        string sqlconnect = @"Data Source=LAPTOP-2NM25M6Q\SQLEXPRESS;Initial Catalog=dbSoftQuanLyNhaHang;Integrated Security=True";
        SqlConnection comm;
        SqlCommand command;
        /*public DataTable getBan()
        {
            DataTable dt = new DataTable();
            dt = Models.BanMod.FillDataSet_DanhSachBan_GoiMon().Tables[0];
            return dt;
        }*/
        //them bàn mới

        // get ban da goi
        public DataTable getBanDaGoi()
        {
            DataTable dt = new DataTable();
            dt = Models.GoiMonMod.FillDataSet_DanhSachBan_GoiMon().Tables[0];
            dgvGoiMon.DataSource = dt;
            return dt;
        }
        // get ban chua goi
        public DataTable getBanChuaGoi()
        {
            DataTable dt = new DataTable();
            dt = Models.GoiMonMod.FillDataSet_DanhSachBan_ChuaGoiMon().Tables[0];
            dgvGoiMon.DataSource = dt;
            return dt;
        }
        // show listview
        public void ShowListView()
        {
            lvDanhSachBan.Items.Clear();
            DataTable dt = new DataTable();
            dt = getBanDaGoi();
            for(int i=0;i<dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(dt.Rows[i]["Tên Bàn"].ToString());
                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(item, dt.Rows[i][0].ToString());
                ListViewItem Status = new ListViewItem(dt.Rows[i]["Id Bàn"].ToString());
                item.ImageIndex = 2;
                item.SubItems.Add(subItem);
                lvDanhSachBan.Items.Add(item);
            }
            DataTable dt2 = new DataTable();
            dt2 = getBanChuaGoi();
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(dt2.Rows[i]["Tên Bàn"].ToString());
                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(item, dt2.Rows[i][0].ToString());
                ListViewItem Status = new ListViewItem(dt2.Rows[i]["Id Bàn"].ToString());
                item.ImageIndex = 1;
                item.SubItems.Add(subItem);
                lvDanhSachBan.Items.Add(item);
            }
        }
        // Bàn có người- cai datatable de luu dữ liệu - hàm này dùng để đổ dữ liệu và hiện cái listItem vào listView( listview subItem trong list view)
        public void  BanCoNguoi()
        {
            DataTable dt = new DataTable();
            dt = getBanDaGoi();
            dgvGoiMon.DataSource = dt;
            lvDanhSachBan.Items.Clear();
            for(int i= 0; i< dt.Rows.Count;i++)
            {
                ListViewItem item = new ListViewItem(dt.Rows[i]["Tên Bàn"].ToString());// "Tên bàn" dùng để hiển thị tương tự display
                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(item,dt.Rows[i][0].ToString());
                ListViewItem Status = new ListViewItem(dt.Rows[i]["Id Bàn"].ToString());// "id Bàn" dùng để lấy giá trị tương tự value
                item.ImageIndex = 2;// gán imageIndex =2 lấy pic thứ tự 2 trong listImage
                item.SubItems.Add(subItem);
                lvDanhSachBan.Items.Add(item);
            }
        }
        // bàn chưa có người
        public void BanChuaCoNguoi()
        {
            DataTable dt = new DataTable();

            dt = getBanChuaGoi();
            dgvGoiMon.DataSource = dt;
            lvDanhSachBan.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(dt.Rows[i]["Tên Bàn"].ToString());// "Tên bàn" dùng để hiển thị tương tự display
                //ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(item, dt.Rows[i][0].ToString());
                ListViewItem Status = new ListViewItem(dt.Rows[i]["Id Bàn"].ToString());// "id Bàn" dùng để lấy giá trị tương tự value
                item.SubItems.Add(dt.Rows[i]["Id Bàn"].ToString());
                lvDanhSachBan.Items.Add(item);
                item.ImageIndex = 1;
                
            }
        }
        public void ThemBanMoi()
        {
            uctBan uctban = new uctBan();
            uctban.Show();
        }

        private void uctGoiMon_Load(object sender, EventArgs e)
        {
            //uctThucDon uctDSTD = new uctThucDon();
            uctDanhSachTD uctDSTD = new uctDanhSachTD();
            nhung(uctDSTD);
            //nhungFrom();
            ShowListView();
            dgvGoiMon.Dock = DockStyle.Fill;
            dgvGoiMon.RowHeadersVisible = false;//xóa cốt đầu datagirview
            dgvGoiMon.BorderStyle = BorderStyle.Fixed3D;
            lblThanhToan.Text = "";
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void hiểnThịBànChưaCóNgườiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BanChuaCoNguoi();
        }

        private void hIểnThịBànCóNgườiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BanCoNguoi();
        }

        private void cậpNhậtDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uctGoiMon_Load(sender, e);
        }

        private void lvDSBan_Click(object sender, EventArgs e)
        {
            
        }
        

        

        // ham nhúng vào panel
        

       

        private void thêmBànMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemBanMoi();
        }

        private void lvDanhSachBan_Click(object sender, EventArgs e)
        {
            comm = new SqlConnection(sqlconnect);
            comm.Open();
            string sql = "";
            uctMonDaGoi uct = new uctMonDaGoi();
            
            string _IdBan = lvDanhSachBan.SelectedItems[0].SubItems[1].Text;
            dgvGoiMon.DataSource = Controllers.GoiMonCtrl.FillDataSet_getGoiMonByIdBan(_IdBan).ToString();
          // dgvGoiMon.DataSource = Models.GoiMonMod(_IdBan).ToString();
            //dgvDS.DataSource = Controllers.HoaDonCtrl.FillDataSet_getHoaDonByIdBan(_IdBan).ToString();
            // may cai1 item chính là tên bàn và subItem chính là cái idban
            string _tenBan = lvDanhSachBan.SelectedItems[0].SubItems[0].Text;
            lblTenBanTrongListView.Text = _tenBan.ToString();
            lblTenBanTrongListView.Hide();

            sql = "select sum(gm.DonGiaTon*gm.SoLuong) from GoiMon gm where gm.IdBan  = '" + _IdBan + "'";
            command = new SqlCommand(sql, comm);
            string val = command.ExecuteScalar().ToString();
            MessageBox.Show(" cho xem gia tri" + val);
            //tinhtien();
            //TongTienCuaBan();
        }

        public void TongTienCuaBan()

        {

            comm = new SqlConnection(sqlconnect);
            comm.Open();
            string sql = "";
            uctMonDaGoi uct = new uctMonDaGoi();

            string _IdBan = lvDanhSachBan.SelectedItems[0].SubItems[1].Text;
            dgvGoiMon.DataSource = Controllers.GoiMonCtrl.FillDataSet_getGoiMonByIdBan(_IdBan).ToString();
            // dgvGoiMon.DataSource = Models.GoiMonMod(_IdBan).ToString();
            //dgvDS.DataSource = Controllers.HoaDonCtrl.FillDataSet_getHoaDonByIdBan(_IdBan).ToString();
            // may cai1 item chính là tên bàn và subItem chính là cái idban
            string _tenBan = lvDanhSachBan.SelectedItems[0].SubItems[0].Text;
            lblTenBanTrongListView.Text = _tenBan.ToString();
            lblTenBanTrongListView.Hide();

            sql = "select sum(gm.DonGiaTon*gm.SoLuong) from GoiMon gm where gm.IdBan  = '" + _IdBan + "'";
            command = new SqlCommand(sql, comm);
            string val = command.ExecuteScalar().ToString();
           
            //MessageBox.Show(" cho xem gia tri" + val);
            lblThanhToan.Text = val.ToString() + "VND";
            lblThanhToan.ForeColor = SystemColors.HotTrack;
        }
        /*public void tinhtien()
        {
            //lvDanhSachBan_Click(sender, e);
            try
            {
                
                int tien = dgvGoiMon.Rows.Count;
                decimal thanhtien = 0;
                for (int i = 0; i <= tien; i++)
                {
                    try
                    {
                        thanhtien += decimal.Parse(dgvGoiMon.Rows[i].Cells["Thành Tiền"].Value.ToString());
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("lôi:" + ex);
                    }

                }
                lblThanhToan.Text = thanhtien.ToString("#,###") + "VND";
                lblThanhToan.ForeColor = SystemColors.HotTrack;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("lôi:" + ex);
            }
        }*/
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            //Views.uctMonDaGoi uctmdg = new Views.uctMonDaGoi();
            
            try
            {
                DialogResult ok = new DialogResult();
                ok = MessageBox.Show("Bạn có muốn tính tiền" + lblTenBanTrongListView.Text + "Không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ok == DialogResult.Yes)
                {
                    TongTienCuaBan();
                    DialogResult da= MessageBox.Show(" TỔNG TIỀN THANH TOÁN CỦA" + "[" + lblTenBanTrongListView.Text + "]" + "LÀ" + lblThanhToan.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if(da==DialogResult.Yes)
                    {
                        uctMonDaGoi uctMDG = new uctMonDaGoi();
                        nhung(uctMDG);

                        // tính tien xong xoa cai bàn đã tính đi
                        string _IdBan = lvDanhSachBan.SelectedItems[0].SubItems[1].Text;
                        dgvGoiMon.DataSource = Controllers.GoiMonCtrl.DeleteGoiMon(_IdBan);
                        uctGoiMon_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa tính tiền");
                    }
                   
                }
                else
                { 
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Bạn chưa chọn bàn thanh toán", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            uctGoiMon_Load(sender, e);

        }
        public void nhung(Control ctr)
        {
            pnlGoiMon.Controls.Clear();
            pnlGoiMon.BorderStyle = BorderStyle.Fixed3D;
            ctr.Dock = DockStyle.Fill;
            pnlGoiMon.Controls.Add(ctr);
            pnlGoiMon.Show();
        }
        public void nhungFrom(Form frm)
        {
            pnlGoiMon.Controls.Clear();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Visible = true;
            frm.Dock = DockStyle.Fill;
            pnlGoiMon.Controls.Add(frm);
            pnlGoiMon.Show();
        }
        // luc goi mon dẽ load uct GoiMon
        private void btnGoiMon_Click(object sender, EventArgs e)
        {
            uctMonDaGoi uctGMCT = new uctMonDaGoi();
            uctGoiMon_Load(sender, e);
            nhung(uctGMCT);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //uctThucDon uctDSTD = new uctThucDon();
           uctDanhSachTD uctDSTD = new uctDanhSachTD();
            nhung(uctDSTD);
            uctGoiMon_Load(sender, e);
        }

        private void dgvGoiMon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void lvDanhSachBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            uctMonDaGoi uctmdg = new uctMonDaGoi();
            nhung(uctmdg);
            //tinhtien();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            frmBillHoaDon frmhoadon = new frmBillHoaDon();
            frmhoadon.ShowDialog();
        }
        // bat su 
    }
}
