using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Doan_QLNH.Models
{
    class GoiMonMod
    {
        // khai báo các bến và hàm thuộc tính
        protected string IdBan { get; set; }
       // protected string IdThucDon { get; set; }
        protected string TenThucDon { get; set; }
        protected decimal DonGiaTon { get; set; }
        protected int SoLuong { get; set; }
        protected DateTime ThoiGian { get; set; }
        protected decimal ThanhTien { get; set; }
        

        // ham khỏi tạo contructor
        public GoiMonMod(string _IdBan)
        {
            this.IdBan = _IdBan;
        }

        public GoiMonMod() { }
        public GoiMonMod(string _IdBan,  string _TenThucDon, decimal _DonGiaTon, int _SoLuong, DateTime _ThoiGian, decimal _ThanhTien)
        {
            this.IdBan = _IdBan;
            
            this.TenThucDon = _TenThucDon;
            
            this.DonGiaTon = _DonGiaTon;
            this.SoLuong = _SoLuong;
            this.ThoiGian = _ThoiGian;
            this.ThanhTien = _ThanhTien;
        }
        // them xoa sua
        public int InsertGoiMon()
        {
            int i = 0;
            string[] paras = new string[] { "@IdBan", "@TenThucDon", "@DonGiaTon", "@SoLuong", "@ThoiGian","@ThanhTien" };
            object[] values = new object[] { IdBan,  TenThucDon, DonGiaTon, SoLuong, ThoiGian, ThanhTien };
            ///goi dung ten thủ tục  vua nay da đặt
            ///
            i = Models.connection.Excute_Sql("spInsertGoiMon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        // ham update
        public int UpdateGoiMon()
        {
            int i = 0;
            string[] paras = new string[] { "@IdBan", "@TenThucDon", "@DonGiaTon", "@SoLuong", "@ThoiGian", "@ThanhTien" };
            object[] values = new object[] { IdBan, TenThucDon, DonGiaTon, SoLuong, ThoiGian, ThanhTien };
            ///goi dung ten thủ tục  vua nay da đặt
            ///
            i = Models.connection.Excute_Sql("spUpdateGoiMon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        //ham delete

        public int DeleteGoiMon()
        {
            int i = 0;
            // int i;
            string[] paras = new string[] { "@IdBan" };
            object[] values = new object[] { IdBan };
            ///goi dung ten thủ tục  vua nay da đặt
            ///
            i = Models.connection.Excute_Sql("spDeleteGoiMon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        // khoi tạo hàm dataset de load "GoiMOn"
        public static DataSet FillDataSet_GoiMon()
        {
            //gọi thủ tục getThucDon
            return Models.connection.FillDataSet("spgetGoiMon", CommandType.StoredProcedure);
        }
        public static DataSet FillDataSet_DanhSachBan_GoiMon()
        {
            //gọi thủ tục getThucDon
            return Models.connection.FillDataSet("spgetDanhSachBan_GoiMon", CommandType.StoredProcedure);
        }
        public static DataSet FillDataSet_DanhSachBan_ChuaGoiMon()
        {
            //gọi thủ tục getThucDon
            return Models.connection.FillDataSet("spgetDanhSachBan_ChuaGoiMon", CommandType.StoredProcedure);
        }
       // .....get cac the loai
        public DataSet FillDataSet_getGoiMonByIdBan()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[] { "@IdBan" };
            object[] values = new object[] { IdBan };
            ds = Models.connection.FillDataSet("spgetGoiMonByIdBan", CommandType.StoredProcedure, paras, values);
            return ds;
        }
        /*public DataSet FillDataSet_SumThanhTien()
        {
            return Models.connection.FillDataSet("spgetSumThanhTien",CommandType.StoredProcedure)
        }*/

        // dùng hàm này để lấy du lien ten thuc don
        public static DataSet FillDataSet_getTenThucDon()
        {
            //gọi thủ tục getThucDon
            return Models.connection.FillDataSet("spgetTenThucDon", CommandType.StoredProcedure);
        }

        // dung hàm này để lấy du lieu idban
        public static DataSet FillDataSet_getIdBan()
        {
            //gọi thủ tục getThucDon
            return Models.connection.FillDataSet("spgetBan", CommandType.StoredProcedure);
        }

        //
       /* public static DataSet FillDataSet_getMonDaGoi()
        {
            //gọi thủ tục getThucDon
            return Models.connection.FillDataSet("spXemGoiMon", CommandType.StoredProcedure);
        }*/
        // get goimon by idban


        public static DataSet FillDataSet_getDonGiaThucDon()
        {
            DataSet ds = new DataSet();
            try
            {
                ds = Models.connection.FillDataSet("spgetThucDon", CommandType.StoredProcedure);
            }
            catch { }
            return ds;
        }

        public int LayTongTien_BanGoiMon()
        {
            int i = 0;
            string[] paras = new string[] { "@IdBan" };
            object[] values = new object[] { IdBan };
            i = Models.connection.Excute_Sql("spgetTien_BanGoiMon", CommandType.StoredProcedure, paras, values);
            return i;
        }

    }
}
