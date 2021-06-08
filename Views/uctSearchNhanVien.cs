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
    public partial class uctSearchNhanVien : UserControl
    {
        public uctSearchNhanVien() 
        {
            InitializeComponent();
        }
        void loadcontrol()
        {
            cmbFind.Items.Clear();
            cmbFind.Items.Add("id Mã Nhân viên");
            cmbFind.Items.Add("Tên Nhân viên");
        }

        private void utcSearchNhanVien_Load(object sender, EventArgs e)
        {
            cmbFind.Items.Add("id Mã Nhân viên");
            loadcontrol();
        }

        private void bntFind_Click(object sender, EventArgs e)
        {

            if (txtFind.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập nội dung tìm kiếm", " Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
            {
                string chuoicmb = cmbFind.Text.ToString();
                string chuoi = "id Mã Nhân Viên".ToString();
                if (string.Compare(chuoicmb, chuoi,true) == 0)
                {

                    string _idNhanVien = txtFind.Text.ToString();
                    DataTable dt = new DataTable();
                    dt = Controllers.NhanVienCtrl.FillDataSet_SearchNhanVienByIdNhanVien(_idNhanVien).Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        dgvDSNhanVien.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Id" + txtFind.Text + "không có trong dữ liệu", " Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    string _tenNhanVien = txtFind.Text;
                    DataTable dt = new DataTable();
                    dt = Controllers.NhanVienCtrl.FillDataSet_SearchNhanVienByTenNhanVien(_tenNhanVien).Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        dgvDSNhanVien.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Tên" + txtFind + "không có trong dữ liệu", " Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }

        }

        private void bntFind_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            string chuoicmb = cmbFind.Text.ToString();
            string chuoi = "id Mã Nhân Viên".ToString();
            if (string.Compare(chuoicmb,chuoi,true)==0)
            {
                string _idNhanVien = txtFind.Text.ToString();
                DataTable dt = new DataTable();
                dt = Controllers.NhanVienCtrl.FillDataSet_SearchNhanVienByIdNhanVien(_idNhanVien).Tables[0];
                dgvDSNhanVien.DataSource = dt;
            }
            else
            {
                //string _ten = txt.Text.ToString();
                string _ten = txtFind.Text.ToString();
                DataTable dt = new DataTable();
                dt = Controllers.NhanVienCtrl.FillDataSet_SearchNhanVienByTenNhanVien(_ten).Tables[0];
                dgvDSNhanVien.DataSource = dt;
            }
        }

        private void cmbFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbFind.Items.Add("id Mã Nhân viên");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
