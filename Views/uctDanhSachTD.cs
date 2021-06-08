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
    public partial class uctDanhSachTD : UserControl
    {
        public uctDanhSachTD()
        {
            InitializeComponent();
        }
        public void HienThiDanhSachTD()
        {
            dgvDSThucDon.DataSource = Models.ThucDonMod.FillDataSet_ThucDon().Tables[0];
            dgvDSThucDon.Dock = DockStyle.Fill;
            dgvDSThucDon.RowHeadersVisible = false;//xóa cốt đầu datagirview
            dgvDSThucDon.BorderStyle = BorderStyle.Fixed3D;
        }
        private void uctDanhSachTD_Load(object sender, EventArgs e)
        {
            //Controllers.ThucDonCtrl.
           // Models.ThucDonMod.FillDataSet_ThucDon();
            HienThiDanhSachTD();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bntFind_Click(object sender, EventArgs e)
        {

        }
    }
}
