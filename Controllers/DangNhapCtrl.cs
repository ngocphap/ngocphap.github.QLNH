using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doan_QLNH.Controllers
{
    class DangNhapCtrl
    {
        public static string KiemTraDangNhap(string _user ,string _pass)
        {
            try
            {
                Models.DangNhapMod login = new Models.DangNhapMod(_user, _pass);
                return login.KiemTraDangNhap();
            }
            catch
            {
                return "";
            }
        }
        public static DataSet getDUlieu_KiemTraDangNhap(string _user, string _pass)
        {
            try
            {
                Models.DangNhapMod login = new Models.DangNhapMod(_user, _pass);
                return login.getDUlieu_KiemTraDangNhap();
            }
            catch
            {
                return null;
            }
        }
        public static string getDulieu_ktDeUpdate(string _user, string _pass)
        {
            try
            {
                Models.DangNhapMod kt = new Models.DangNhapMod(_user, _pass);
                return kt.getDUlieu_KtDeUpdate();
            }
            catch
            {
                return null;
            }
        }
        public static int InsertTaiKhoan(string _user, string _pass, bool _status)
        {
            try
            {
                Models.DangNhapMod _ban = new Models.DangNhapMod(_user, _pass, _status);
                return _ban.InsertTaiKhoan();
            }
            catch
            {
                return 0;
            }
        }

        public static int UpdateTaiKhoan(string _user, string _pass)
        {
            try
            {
                Models.DangNhapMod _ban = new Models.DangNhapMod(_user, _pass);
                return _ban.UpdateTaiKhoan();
            }
            catch
            {
                return 0;
            }
        }
        public static int DeleteTaiKhoan(string _datasetNoiDungID)
        {
            try
            {
                Models.DangNhapMod _ban = new Models.DangNhapMod(_datasetNoiDungID);
                return _ban.DeleteTaiKhoan();
            }
            catch
            {
                return 0;
            }
        }
    }
}
