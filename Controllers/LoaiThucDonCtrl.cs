using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Doan_QLNH.Controllers
{
    class LoaiThucDonCtrl
    {
        public static DataSet FillDataSet_getBanByIdBan(string _datasetNoiDungID)
        {
            try
            {
                Models.LoaiThucDonMod nvien = new Models.LoaiThucDonMod(_datasetNoiDungID);
                return nvien.FillDataSet_getLoaiThucDonnByIdLoaiTHucDon();
            }
            catch
            {
                return null;
            }
        }

        // method add
        public static int InsertLoaiThucDon(string _IdLoaiThucDon, string _TenLoaiThucDon, string _DienGiai, string _TrangTHai)
        {
            try
            {
                Models.LoaiThucDonMod _nhanVien = new Models.LoaiThucDonMod(_IdLoaiThucDon, _TenLoaiThucDon, _DienGiai, _TrangTHai);
                return _nhanVien.InsertLoaiThucDon();
            }
            catch
            {
                return 0;
            }
        }
        // method update
        public static int UpdateLoaiThucDon(string _IdLoaiThucDon, string _TenLoaiThucDon, string _DienGiai, string _TrangTHai)
        {
            try
            {
                Models.LoaiThucDonMod _nhanVien = new Models.LoaiThucDonMod(_IdLoaiThucDon, _TenLoaiThucDon, _DienGiai, _TrangTHai);
                return _nhanVien.UpdateLoaiThucDon();
            }
            catch
            {
                return 0;
            }
        }
        // mwthod delete
        public static int DeleteLoaiThucDon(string _datasetNoiDungID)
        {
            try
            {
                Models.LoaiThucDonMod _nhanVien = new Models.LoaiThucDonMod(_datasetNoiDungID);
                return _nhanVien.DeleteLoaiThucDon();
            }
            catch
            {
                return 0;
            }
        }
        // metho tim theo id
    }
}
