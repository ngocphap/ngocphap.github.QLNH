using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Doan_QLNH.Controllers
{
    class BanCtrl
    {
        public static DataSet FillDataSet_getBanByIdBan(string _datasetNoiDungID)
        {
            try
            {
                Models.BanMod _ban = new Models.BanMod(_datasetNoiDungID);
                return _ban.FillDataSet_getBannByIdBan();
            }
            catch
            {
                return null;
            }
        }

        // method add
        public static int InsertBan(string _IdBan, string _TenKhuVuc, string _TenBan, string _DienGiai, string _TrangThai)
        {
            try
            {
                Models.BanMod _ban = new Models.BanMod(_IdBan, _TenKhuVuc, _TenBan, _DienGiai, _TrangThai);
                return _ban.InsertBan();
            }
            catch
            {
                return 0;
            }
        }
        // method update
        public static int UpdateBan(string _IdBan, string _TenKhuVuc, string _TenBan, string _DienGiai, string _TrangThai)
        {
            try
            {
                Models.BanMod _ban = new Models.BanMod(_IdBan, _TenKhuVuc,_TenBan, _DienGiai, _TrangThai);
                return _ban.UpdateBan();
            }
            catch
            {
                return 0;
            }
        }
        // mwthod delete
        public static int DeleteBan(string _datasetNoiDungID)
        {
            try
            {
                Models.BanMod _ban = new Models.BanMod(_datasetNoiDungID);
                return _ban.DeleteBan();
            }
            catch
            {
                return 0;
            }
        }
        // metho tim theo id
    }
}
