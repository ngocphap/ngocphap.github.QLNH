using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Doan_QLNH.Models
{
    class KhuVucMod
    {
        // khai báo các bến và hàm thuộc tính
        protected string IdKhuVuc { get; set; }
        protected string TenKhuVuc { get; set; }
        protected string DienGiai { get; set; }
        protected string TrangThai { get; set; }
       

        // ham khỏi tạo contructor
        public KhuVucMod(string _IdKhuVucn)
        {
            this.IdKhuVuc = _IdKhuVucn;

            //_IdNhanVien = ID_NV;


        }

        public KhuVucMod() { }
        public KhuVucMod(string _IdKhuVuc, string _TenKhuVuc, string _DienGiai, string _TrangThai)
        {
            this.IdKhuVuc = _IdKhuVuc;
            this.TenKhuVuc = _TenKhuVuc;
            this.DienGiai = _DienGiai;
            this.TrangThai = _TrangThai;
            }
        ///khai baosthêm xóa sửa
        ///
        public int InsertKhuVuc()
        {
            int i = 0;
            
            string[] paras = new string[] { "@IdKhuVuc", "@TenKhuVuc", "@DienGiai", "@TrangThai" };
            object[] values = new object[] { IdKhuVuc, TenKhuVuc, DienGiai, TrangThai };
            ///goi dung ten thủ tục  vua nay da đặt
            ///
            i = Models.connection.Excute_Sql("spInsertKhuVuc", CommandType.StoredProcedure, paras, values);
            return i;
        }
        // ham update
        public int UpdateKhuVuc()
        {
            int i = 0;

            string[] paras = new string[] { "@IdKhuVuc", "@TenKhuVuc", "@DienGiai", "@TrangThai" };
            object[] values = new object[] { IdKhuVuc, TenKhuVuc, DienGiai, TrangThai };
            ///
            i = Models.connection.Excute_Sql("spUpdateKhuVuc", CommandType.StoredProcedure, paras, values);
            return i;
        }
        //ham delete

        public int DeleteKhuVuc()
        {
            int i = 0;
            // int i;
            string[] paras = new string[] { "@IdKhuVuc"};
            object[] values = new object[] { IdKhuVuc };
            ///goi dung ten thủ tục  vua nay da đặt
            ///
            i = Models.connection.Excute_Sql("spDeleteKhuVuc", CommandType.StoredProcedure, paras, values);
            return i;
        }
        // khoi tạo hàm dataset de load "Nhan vien"
        public static DataSet FillDataSetKhuVuc()
        {
            //gọi thủ tục getNhannvien 
            return Models.connection.FillDataSet("spgetKhuVuc", CommandType.StoredProcedure);
        }
        // get nhan vien by idNhanvien
        public DataSet FillDataSet_getKhuVucByIdKhuVuc()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[] { "@IdKhuVuc" };
            object[] values = new object[] { IdKhuVuc };
            ds = Models.connection.FillDataSet("spgetKhuVucByIdKhuVuc", CommandType.StoredProcedure, paras, values);
            return ds;
        }

        public static DataSet getTenKhuVuc()
        {
            //gọi thủ tục get return tên khu vực;
            return Models.connection.FillDataSet("spgetTenKhuVuc", CommandType.StoredProcedure);
        }
        // ham tim kiem nahn vien theo id

    }
}
