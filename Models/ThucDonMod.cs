using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Doan_QLNH.Models
{
    class ThucDonMod
    {
        // khai báo các bến và hàm thuộc tính
        protected string IdThucDon { get; set; }
        protected string TenLoaiThucDon { get; set; }
        protected string TenThucDon { get; set; }
        protected string DonViTinh { get; set; }
        protected int SoLuongTon { get; set; }
        protected decimal DonGiaTon { get; set; }
       // protected int TonToiThieu { get; set; }
        protected string TrangThai { get; set; }
        protected byte[] HinhAnh { get; set; }

        // ham khỏi tạo contructor
        public ThucDonMod(string _IdThucDon)
        {
            this.IdThucDon = _IdThucDon;
        }

        public ThucDonMod() { }
        public ThucDonMod(string _IdThucDon, string _TenLoaiThucDon, string _TenThucDon, string _DonViTinh, int _SoLuongTon, decimal _DonGiaTon, string _TrangThai,byte[] _Hinhanh)
        {
            IdThucDon = _IdThucDon;
            TenLoaiThucDon = _TenLoaiThucDon;
            TenThucDon = _TenThucDon;
            DonViTinh = _DonViTinh;
            SoLuongTon = _SoLuongTon;
            DonGiaTon = _DonGiaTon;
            //TonToiThieu = _TonToiThieu;
            TrangThai = _TrangThai;
            HinhAnh = _Hinhanh;
        }
        // them xoa sua
        public int InsertThucDon()
        {
            int i = 0;
            //int i ;
            string[] paras = new string[] { "@IdThucDon", "@TenLoaiThucDon", "@TenThucDon", "@DonViTinh", "@SoLuongTon", "@DonGiaTon", "@TrangThai","@HinhAnh" };
            object[] values = new object[] { IdThucDon, TenLoaiThucDon, TenThucDon, DonViTinh, SoLuongTon, DonGiaTon, TrangThai ,HinhAnh};
            ///goi dung ten thủ tục  vua nay da đặt
            ///
            i = Models.connection.Excute_Sql("spInsertThucDon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        // ham update
        public int UpdateThucDon()
        {
            int i = 0;
            // int i;
            string[] paras = new string[] { "@IdThucDon", "@TenLoaiThucDon", "@TenThucDon", "@DonViTinh", "@SoLuongTon", "@DonGiaTon", "@TrangThai" , "@HinhAnh" };
            object[] values = new object[] { IdThucDon, TenLoaiThucDon, TenThucDon, DonViTinh, SoLuongTon, DonGiaTon, TrangThai ,HinhAnh};
            ///goi dung ten thủ tục  vua nay da đặt
            ///
            i = Models.connection.Excute_Sql("spUpdateThucDon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        //ham delete

        public int DeleteThucDon()
        {
            int i = 0;
            // int i;
            string[] paras = new string[] { "@IdThucDon" };
            object[] values = new object[] { IdThucDon };
            ///goi dung ten thủ tục  vua nay da đặt
            ///
            i = Models.connection.Excute_Sql("spDeleteThucDon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        // khoi tạo hàm dataset de load "Thuc Don"
        public static DataSet FillDataSet_ThucDon()
        {
            //gọi thủ tục getThucDon
            return Models.connection.FillDataSet("spgetThucDon", CommandType.StoredProcedure);
        }
        // get Thucdon by idThucdon
        public DataSet FillDataSet_getThucDonByIdThucDon()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[] { "@IdThucDon" };
            object[] values = new object[] { IdThucDon };
            ds = Models.connection.FillDataSet("spgetThucDonByIdThucDon", CommandType.StoredProcedure, paras, values);
            return ds;
        }

        // ham tim kiem nahn vien theo ten
        public DataSet FillDataSet_SearchThucDonByTenThucDon()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[] { "@TenThucDon" };
            object[] values = new object[] { IdThucDon };
            ds = Models.connection.FillDataSet("spSearchThucDonByTenThucDon", CommandType.StoredProcedure, paras, values);
            return ds;
        }
        // ha, tim kiem theo ten
        
    }
}
