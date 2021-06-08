using System;
using System.Data;
namespace Doan_QLNH.Models
{
    class NhanVienMod
    {
        // khai báo các bến và hàm thuộc tính
        protected string ID_NV { get; set; }
        protected string HoLot_NV { get; set; }
        protected string Ten_NV { get; set; }
        protected DateTime NgaySinh_NV { get; set; }
        protected string GioiTinh_NV { get; set; }
        protected string DienThoaiN_V { get; set; }
        protected string Email_NV { get; set; }

        protected string DiaChi_NV { get; set; }

        // ham khỏi tạo contructor
        public NhanVienMod (string _IdNhanVien)
        {
           ID_NV = _IdNhanVien;

           //_IdNhanVien = ID_NV;
            
            
        }
        
        public NhanVienMod() { }
        public NhanVienMod(string _idNhanVien, string _holotNhanVien, string _tenNhanVien,DateTime _ngaysinhNhanVien,string _gioitinhNhanVien, string _dienthoaiNhanVien,string _emalNhanVien,string _diachiNhanVien)
        {
            ID_NV = _idNhanVien;
            HoLot_NV = _holotNhanVien;
            Ten_NV = _tenNhanVien;
            NgaySinh_NV = _ngaysinhNhanVien;
            GioiTinh_NV = _gioitinhNhanVien;
            DienThoaiN_V = _dienthoaiNhanVien;
            Email_NV = _emalNhanVien;
            DiaChi_NV = _diachiNhanVien;

            /*_idNhanVien = ID_NV;
            _holotNhanVien = HoLot_NV;
            _tenNhanVien = Ten_NV;
            _ngaysinhNhanVien = NgaySinh_NV;
            _gioitinhNhanVien = GioiTinh_NV;
            _dienthoaiNhanVien = DienThoaiN_V;
            _emalNhanVien = Email_NV;
            _diachiNhanVien = DiaChi_NV;*/


        }
        ///khai baosthêm xóa sửa
        ///
        public int InsertNhanVien()
        {
            int i=0;
            //int i ;
            string[] paras = new string[] { "@IdNhanVien", "@HoLot", "@Ten", "@Ngaysinh", "@GioiTinh", "@DienThoai", "@Email", "@DiaChi" };
            object[] values = new object[] { ID_NV, HoLot_NV, Ten_NV, NgaySinh_NV, GioiTinh_NV, DienThoaiN_V, Email_NV, DiaChi_NV };
            ///goi dung ten thủ tục  vua nay da đặt
            ///
            i = Models.connection.Excute_Sql("spInsertNhanVien", CommandType.StoredProcedure, paras, values);
            return i;
        }
        // ham update
        public int UpdateNhanVien()
        {
            int i=0;
           // int i;
            string []paras = new string[] { "@IdNhanVien", "@HoLot", "@Ten", "@Ngaysinh", "@GioiTinh", "@DienThoai", "@Email", "@DiaChi" };
            object []values = new object[] { ID_NV, HoLot_NV, Ten_NV, NgaySinh_NV, GioiTinh_NV, DienThoaiN_V, Email_NV, DiaChi_NV };
            ///goi dung ten thủ tục  vua nay da đặt
            ///
            i = Models.connection.Excute_Sql("spUpdateNhanVien", CommandType.StoredProcedure, paras, values);
            return i;
        }
        //ham delete

        public int DeleteNhanVien()
        {
            int i=0;
           // int i;
            string[] paras = new string[] { "@IdNhanVien"};
            object[] values = new object[] { ID_NV };
            ///goi dung ten thủ tục  vua nay da đặt
            ///
            i = Models.connection.Excute_Sql("spDeleteNhanVien", CommandType.StoredProcedure, paras, values);
            return i;
        }
        // khoi tạo hàm dataset de load "Nhan vien"
        public static DataSet FillDataSetNhanVien()
        {
            //gọi thủ tục getNhannvien 
            return Models.connection.FillDataSet("spgetNhanVien", CommandType.StoredProcedure);
        }
        // get nhan vien by idNhanvien
        public DataSet FillDataSet_getNhanVienByIdNhanVien()
        {
            DataSet ds = new DataSet();
            string []paras = { "@IdNhanVien" } ;
            object []values = { ID_NV };
            ds = Models.connection.FillDataSet("spgetNhanVienByIdNhanVien", CommandType.StoredProcedure, paras, values);
            return ds;
        }
        
        // ham tim kiem nahn vien theo id
        public  DataSet FillDataSet_SearchNhanVienByIdNhanVien()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[] { "@IdNhanVien" };
            object[] values = new object[] { ID_NV };
            ds = Models.connection.FillDataSet("spSearchNhanVienByIdNhanVien", CommandType.StoredProcedure, paras, values);
            return ds;
        }
        // ha, tim kiem theo ten
        public  DataSet FillDataSet_SearchNhanVienByTenNhanVien()
        {
            DataSet ds = new DataSet();
            string[] paras = { "@Ten" };
            object[] values = { ID_NV };
            ds = Models.connection.FillDataSet("spSearchNVByTenNV", CommandType.StoredProcedure, paras, values);
            return ds;
        }
    }
}
