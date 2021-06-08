using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Doan_QLNH.Controllers
{
    class GoiMonCtrl
    {
        public static DataSet FillDataSet_getGoiMonByIdBan(string _isBan)
        {
            try
            {
                Models.GoiMonMod gmon = new Models.GoiMonMod(_isBan);
                return gmon.FillDataSet_getGoiMonByIdBan();
            }
            catch
            {
                return null;
            }
        }
        
        // method add
        public static int InsertGoiMon(string _IdBan, string _TenThucDon, decimal _DonGiaTon, int _SoLuong, DateTime _ThoiGian, decimal _ThanhTien)
        {
            try
            {
                Models.GoiMonMod _goimon = new Models.GoiMonMod(_IdBan, _TenThucDon, _DonGiaTon, _SoLuong, _ThoiGian, _ThanhTien);
                return _goimon.InsertGoiMon();
            }
            catch
            {
                return 0;
            }
        }
        // method update
        public static int UpdateGoiMon(string _IdBan, string _TenThucDon, decimal _DonGiaTon, int _SoLuong, DateTime _ThoiGian, decimal _ThanhTien)
        {
            try
            {
                Models.GoiMonMod _goimon = new Models.GoiMonMod(_IdBan, _TenThucDon, _DonGiaTon, _SoLuong, _ThoiGian, _ThanhTien);
                return _goimon.UpdateGoiMon();
            }
            catch
            {
                return 0;
            }
        }
        // mwthod delete
        public static int DeleteGoiMon(string _idBan)
        {
            try
            {
                Models.GoiMonMod _goimon = new Models.GoiMonMod(_idBan);
                return _goimon.DeleteGoiMon();
            }
            catch
            {
                return 0;
            }
        }
    }
}
