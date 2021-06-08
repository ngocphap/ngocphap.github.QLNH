using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Doan_QLNH.Controllers
{
    class NhanVienCtrl
    {

        public static DataSet FillDataSet_getNhanVienByIdNhanVien(string _datasetNoiDungID)
        {
            try
            {
                Models.NhanVienMod nvien = new Models.NhanVienMod(_datasetNoiDungID);
                return nvien.FillDataSet_getNhanVienByIdNhanVien();
            }
            catch
            {
                return null;
            }
        }

        // method add
        public static int InsertNhanVien(string _idNhanVien, string _holotNhanVien, string _tenNhanVien, DateTime _ngaysinhNhanVien, string _gioitinhNhanVien, string _dienthoaiNhanVien, string _emalNhanVien, string _diachiNhanVien)
        {
            try
            {
                Models.NhanVienMod _nhanVien = new Models.NhanVienMod(_idNhanVien, _holotNhanVien, _tenNhanVien, _ngaysinhNhanVien, _gioitinhNhanVien, _dienthoaiNhanVien, _emalNhanVien, _diachiNhanVien);
                return _nhanVien.InsertNhanVien();
            }
            catch
            {
                return 0;
            }
        }
        // method update
        public static int UpdateNhanVien(string _idNhanVien, string _holotNhanVien, string _tenNhanVien, DateTime _ngaysinhNhanVien, string _gioitinhNhanVien, string _dienthoaiNhanVien, string _emalNhanVien, string _diachiNhanVien)
        {
            try
            {
                Models.NhanVienMod _nhanVien = new Models.NhanVienMod(_idNhanVien, _holotNhanVien, _tenNhanVien, _ngaysinhNhanVien, _gioitinhNhanVien, _dienthoaiNhanVien, _emalNhanVien, _diachiNhanVien);
                return _nhanVien.UpdateNhanVien();
            }
            catch
            {
                return 0;
            }
        }
        // mwthod delete
        public static int DeleteNhanVien(string _datasetNoiDungID)
        {
            try
            {
                Models.NhanVienMod _nhanVien = new Models.NhanVienMod(_datasetNoiDungID);
                return _nhanVien.DeleteNhanVien();
            }
            catch
            {
                return 0;
            }
        }
        // metho tim theo id
        public static DataSet FillDataSet_SearchNhanVienByIdNhanVien(string _datasetNoiDungID)
        {
            try
            {
                Models.NhanVienMod nvien = new Models.NhanVienMod(_datasetNoiDungID);
                return nvien.FillDataSet_SearchNhanVienByIdNhanVien();
            }
            catch
            {
                return null;
            }
        }
        // metho tim theo ten
        public static DataSet FillDataSet_SearchNhanVienByTenNhanVien(string _datasetNoiDungID)
        {
            try
            {
                Models.NhanVienMod nvien = new Models.NhanVienMod(_datasetNoiDungID);
                return nvien.FillDataSet_SearchNhanVienByTenNhanVien();
            }
            catch
            {
                return null;
            }
        }
    }
}
