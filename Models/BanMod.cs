using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Doan_QLNH.Models
{
    class BanMod
    {
        // khai báo các bến và hàm thuộc tính
        protected string IdBan { get; set; }
        protected string TenKhuVuc { get; set; }
        protected string TenBan { get; set; }
        protected string DienGiai { get; set; }
        protected string TrangThai { get; set; }
        

        // ham khỏi tạo contructor
        public BanMod(string _IdBan)
        {
            this.IdBan = _IdBan;

        }

        public BanMod() { }
        public BanMod(string _IdBan, string _TenKhuVuc, string _TenBan, string _DienGiai, string _TrangThai)
        {
            this.IdBan = _IdBan;
            this.TenKhuVuc = _TenKhuVuc;
            this.TenBan = _TenBan;
            
            this.DienGiai = _DienGiai;
            this.TrangThai = _TrangThai;


        }
        ///khai baosthêm xóa sửa
        ///
        public int InsertBan()
        {
            int i = 0;
            string[] paras = new string[] { "@IdBan", "@TenKhuVuc", "@TenBan", "@DienGiai", "@TrangThai" };
            object[] values = new object[] { IdBan, TenKhuVuc, TenBan, DienGiai, TrangThai};
            ///goi dung ten thủ tục  vua nay da đặt
            ///
            i = Models.connection.Excute_Sql("spInsertBan", CommandType.StoredProcedure, paras, values);
            return i;
        }
        // ham update
        public int UpdateBan()
        {
            int i = 0;
            string[] paras = new string[] { "@IdBan", "@TenKhuVuc", "@TenBan", "@DienGiai", "@TrangThai" };
            object[] values = new object[] { IdBan, TenKhuVuc, TenBan, DienGiai, TrangThai };
            ///goi dung ten thủ tục  vua nay da đặt
            ///
            i = Models.connection.Excute_Sql("spUpdateBan", CommandType.StoredProcedure, paras, values);
            return i;
        }
        //ham delete

        public int DeleteBan()
        {
            int i = 0;
            //int i ;
            string[] paras = new string[] { "@IdBan" };
            object[] values = new object[] { IdBan };
            ///goi dung ten thủ tục  vua nay da đặt
            ///
            i = Models.connection.Excute_Sql("spDeleteBan", CommandType.StoredProcedure, paras, values);
            return i;
        }
        // khoi tạo hàm dataset de load "Nhan vien"
        public static DataSet FillDataSetBan()
        {
            //gọi thủ tục getNhannvien 
            return Models.connection.FillDataSet("spgetBan", CommandType.StoredProcedure);
        }
      /*  public static DataSet FillDataSet_DanhSachBan_GoiMon()
        {
            return Models.connection.FillDataSet("spViewDanhSachBan_GoiMon", CommandType.StoredProcedure);
        }*/
        public DataSet FillDataSet_getBannByIdBan()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[] { "@IdBan" };
            object[] values = new object[] { IdBan };
            ds = Models.connection.FillDataSet("spgetBanByIdBan", CommandType.StoredProcedure, paras, values);
            return ds;
        }

        // ham tim kiem nahn vien theo id
        
    }
}
