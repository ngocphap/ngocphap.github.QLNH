using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Doan_QLNH.Models
{
    class DangNhapMod
    {
        protected string user { get; set; }
        protected string pass { get; set; }
        // bien status dùng để kiểm tra trạng thái tài khoản
        protected bool status { get; set; }

        // khỏi tạo 2 doi tuong kiem tra dang nhập
        public DangNhapMod(string _user , string _pass)
        {
            this.user = _user;
            this.pass = _pass;
        }
        public DangNhapMod(string _user, string _pass, bool _status)
        {
            this.user = _user;
            this.pass = _pass;
            this.status = _status;
        }
        public DangNhapMod()
        { }
        public DangNhapMod(string _idDangNhap)
        {
            user = _idDangNhap;
        }
        //public DangNhapMod() { }
        public string KiemTraDangNhap()
        {
            string str;
            // truyền vào 2 biến IdDangNHap và MatKhau ,2 biến này phải trùng với CSDL
            string[] paras = new string[] { "@IdDangNhap", "@MatKhau" };
            object[] value = new object[] { user, pass };
            str = Models.connection.ExcuteScalar("spCheckDangNhap", CommandType.StoredProcedure, paras, value);
            return str;
        }
        public DataSet getDUlieu_KiemTraDangNhap()
        {
            DataSet str ;
            // truyền vào 2 biến IdDangNHap và MatKhau ,2 biến này phải trùng với CSDL
            string[] paras = new string[] { "@IdDangNhap", "@MatKhau" };
            object[] value = new object[] { user, pass };
            str = Models.connection.FillDataSet("spCheckDangNhap", CommandType.StoredProcedure, paras, value);
            return str;
        }
        public string getDUlieu_KtDeUpdate()
        {
            string str;
            // truyền vào 2 biến IdDangNHap và MatKhau ,2 biến này phải trùng với CSDL
            string[] paras = new string[] { "@IdDangNhap", "@MatKhau" };
            object[] value = new object[] { user, pass };
            str = Models.connection.ExcuteScalar("spCheckDangNhapMoi", CommandType.StoredProcedure, paras, value);
            return str;
        }
        ///khai baosthêm xóa sửa
        ///
        public int InsertTaiKhoan()
        {
            int i = 0;
            string[] paras = new string[] { "@IdDangNhap", "@MatKhau" , "@TrangThai" };
            object[] values = new object[] { user, pass, status };
            ///goi dung ten thủ tục  vua nay da đặt
            ///
            i = Models.connection.Excute_Sql("spInsertDangNhap", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateTaiKhoan()
        {
            int i = 0;
            string[] paras = new string[] { "@IdDangNhap", "@MatKhau" };
            object[] values = new object[] { user, pass};
            ///goi dung ten thủ tục  vua nay da đặt
            ///
            i = Models.connection.Excute_Sql("spUpdateDangNhap_MatKhau", CommandType.StoredProcedure, paras, values);
            return i;
        }

        public int DeleteTaiKhoan()
        {
            int i = 0;
            //int i ;
            string[] paras = new string[] { "@IdDangNhap" };
            object[] values = new object[] { user };
            ///goi dung ten thủ tục  vua nay da đặt
            ///
            i = Models.connection.Excute_Sql("spDeleteDangNhapByIdDangNhap", CommandType.StoredProcedure, paras, values);
            return i;
        }

        public static DataSet FillDataSetTaiKhoan()
        {
            //gọi thủ tục getNhannvien 
            return Models.connection.FillDataSet("spgetDangNhap", CommandType.StoredProcedure);
        }

    }
}
