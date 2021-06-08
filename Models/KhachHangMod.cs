using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doan_QLNH.Models
{
    class KhachHangMod
    {
        // khai báo các bến và hàm thuộc tính
        protected string ID_KH { get; set; }
        protected string Ten_KH { get; set; }
        protected string GioiTinh_KH { get; set; }
        protected string DienThoai_KH{ get; set; }
        protected string Email_KH { get; set; }

        protected string DiaChi_KH { get; set; }

        // ham khỏi tạo contructor
        public KhachHangMod(string _IdKhachHang)
        {
            ID_KH = _IdKhachHang;  
        }

        public KhachHangMod() { }
        public KhachHangMod(string _IdKhachHang, string _TenKhachHang, string _GioiTinh, string _DienThoai, string _Email, string _DiaChi)
        {
            this.ID_KH = _IdKhachHang;
            this.Ten_KH = _TenKhachHang;
            this.GioiTinh_KH = _GioiTinh;
            this.DienThoai_KH = _DienThoai;
            this.Email_KH = _Email;
            this.DiaChi_KH = _DiaChi;
         
        }
        ///khai baosthêm xóa sửa
        ///
        public int InsertKhachHang()
        {
            int i = 0;
            //int i ;
            string[] paras = new string[] { "@IdKhachHang", "@TenKhachHang", "@DienThoai", "@Email", "@DiaChi", "@GioiTinh" };
            object[] values = new object[] { ID_KH, Ten_KH, DienThoai_KH, Email_KH, DiaChi_KH, GioiTinh_KH};
            ///goi dung ten thủ tục  vua nay da đặt
            ///
            i = Models.connection.Excute_Sql("spInsertKhachHang", CommandType.StoredProcedure, paras, values);
            return i;
        }
        // ham update
        public int UpdateKhachHang()
        {
            int i = 0;
            //int i ;
            string[] paras = new string[] { "@IdKhachHang", "@TenKhachHang", "@DienThoai", "@Email", "@DiaChi", "@GioiTinh" };
            object[] values = new object[] { ID_KH, Ten_KH, DienThoai_KH, Email_KH, DiaChi_KH, GioiTinh_KH };
            ///goi dung ten thủ tục  vua nay da đặt
            ///
            i = Models.connection.Excute_Sql("spUpdateKhachHang", CommandType.StoredProcedure, paras, values);
            return i;
        }
        //ham delete

        public int DeleteKhachHang()
        {
            int i = 0;
            // int i;
            string[] paras = new string[] { "@IdKhachHang" };
            object[] values = new object[] { ID_KH };
            ///goi dung ten thủ tục  vua nay da đặt
            ///
            i = Models.connection.Excute_Sql("spDeleteKhachHang", CommandType.StoredProcedure, paras, values);
            return i;
        }
        // khoi tạo hàm dataset de load "Nhan vien"
        public static DataSet FillDataSetKhachHang()
        {
           
            return Models.connection.FillDataSet("spgetKhachHang", CommandType.StoredProcedure);
        }
      
        public DataSet FillDataSet_getKhachHangByIdKhachHang()
        {
            DataSet ds = new DataSet();
            string[] paras = { "@IdKhachHang" };
            object[] values = { ID_KH };
            ds = Models.connection.FillDataSet("spgetKhachHangByIdKhachHang", CommandType.StoredProcedure, paras, values);
            return ds;
        }
    }
}
