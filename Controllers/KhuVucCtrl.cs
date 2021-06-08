using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Doan_QLNH.Controllers
{
    class KhuVucCtrl
    {
        public static DataSet FillDataSet_getKhuVucByIdKhuVuc(string _datasetNoiDungID)
        {
            try
            {
                Models.KhuVucMod nvien = new Models.KhuVucMod(_datasetNoiDungID);
                return nvien.FillDataSet_getKhuVucByIdKhuVuc();
            }
            catch
            {
                return null;
            }
        }

        // method add
        public static int InsertKhuVuc(string _IdKhuVuc, string _TenKhuVuc, string _DienGiai, string _TrangThai)
        {
            try
            {
                Models.KhuVucMod _nhanVien = new Models.KhuVucMod(_IdKhuVuc, _TenKhuVuc, _DienGiai, _TrangThai);
                return _nhanVien.InsertKhuVuc();
            }
            catch
            {
                return 0;
            }
        }
        // method update
        public static int UpdateKhuVuc(string _IdKhuVuc, string _TenKhuVuc, string _DienGiai, string _TrangThai)
        {
            try
            {
                Models.KhuVucMod _nhanVien = new Models.KhuVucMod(_IdKhuVuc, _TenKhuVuc, _DienGiai, _TrangThai);
                return _nhanVien.UpdateKhuVuc();
            }
            catch
            {
                return 0;
            }
        }
        // mwthod delete
        public static int DeleteKhuVuc(string _datasetNoiDungID)
        {
            try
            {
                Models.KhuVucMod _nhanVien = new Models.KhuVucMod(_datasetNoiDungID);
                return _nhanVien.DeleteKhuVuc();
            }
            catch
            {
                return 0;
            }
        }
        // metho tim theo id
       
    }
}
