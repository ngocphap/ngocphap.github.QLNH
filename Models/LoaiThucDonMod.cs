using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Doan_QLNH.Models
{
    class LoaiThucDonMod
    {
        // khai báo các bến và hàm thuộc tính
        protected string IdLoaiThucDon { get; set; }
        protected string TenLoaiThucDon { get; set; }
        protected string DienGiai { get; set; }
        protected string TrangTHai { get; set; }
       


        // ham khỏi tạo contructor
        public LoaiThucDonMod(string _IdLoaiThucDon)
        {
            this.IdLoaiThucDon = _IdLoaiThucDon;

        }

        public LoaiThucDonMod() { }
        public LoaiThucDonMod(string _IdLoaiThucDon, string _TenLoaiThucDon, string _DienGiai, string _TrangTHai)
        {
            this.IdLoaiThucDon = _IdLoaiThucDon;
            this.TenLoaiThucDon = _TenLoaiThucDon;
            this.DienGiai = _DienGiai;
            this.TrangTHai = _TrangTHai;
            
        }
        ///khai baosthêm xóa sửa
        ///
        public int InsertLoaiThucDon()
        {
            int i = 0;
            //int i ;
            string[] paras = new string[] { "@IdLoaiThucDon", "@TenLoaiThucDon", "@DienGiai", "@TrangThai" };
            object[] values = new object[] { IdLoaiThucDon, TenLoaiThucDon, DienGiai, TrangTHai};
            ///goi dung ten thủ tục  vua nay da đặt
            ///
            i = Models.connection.Excute_Sql("spInsertLoaiThucDon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        // ham update
        public int UpdateLoaiThucDon()
        {
            int i = 0;
            //int i ;
            string[] paras = new string[] { "@IdLoaiThucDon", "@TenLoaiThucDon", "@DienGiai", "@TrangThai" };
            object[] values = new object[] { IdLoaiThucDon, TenLoaiThucDon, DienGiai, TrangTHai };
            ///goi dung ten thủ tục  vua nay da đặt
            ///
            i = Models.connection.Excute_Sql("spUpdateLoaiThucDon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        //ham delete

        public int DeleteLoaiThucDon()
        {
            int i = 0;
            //int i ;
            string[] paras = new string[] { "@IdLoaiThucDon" };
            object[] values = new object[] { IdLoaiThucDon };
            ///goi dung ten thủ tục  vua nay da đặt
            ///
            i = Models.connection.Excute_Sql("spDeleteLoaiThucDon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        // khoi tạo hàm dataset de load "Nhan vien"
        public static DataSet FillDataSetLoaiThucDon()
        {
            //gọi thủ tục getNhannvien 
            return Models.connection.FillDataSet("spgetLoaiThucDon", CommandType.StoredProcedure);
        }
        // get nhan vien by idNhanvien
        public DataSet FillDataSet_getLoaiThucDonnByIdLoaiTHucDon()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[] { "@IdLoaiThucDon" };
            object[] values = new object[] { IdLoaiThucDon };
            ds = Models.connection.FillDataSet("spgetLoaiThucDonByIdLoaiThucDon", CommandType.StoredProcedure, paras, values);
            return ds;
        }

        // ham tim kiem nahn vien theo id
    }
}
