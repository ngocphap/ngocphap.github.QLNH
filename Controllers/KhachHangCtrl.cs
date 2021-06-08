using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doan_QLNH.Controllers
{
    class KhachHangCtrl
    {
        public static DataSet FillDataSet_getKhachHangByIdKhachHang(string _datasetNoiDungID)
        {
            try
            {
                Models.KhachHangMod khachhang = new Models.KhachHangMod(_datasetNoiDungID);
                return khachhang.FillDataSet_getKhachHangByIdKhachHang();
            }
            catch
            {
                return null;
            }
        }

        // method add
        public static int InsertKhachHang(string _IdKhachHang, string _TenKhachHang, string _GioiTinh, string _DienThoai, string _Email, string _DiaChi)
        {
            try
            {
                Models.KhachHangMod khachhang = new Models.KhachHangMod(_IdKhachHang, _TenKhachHang, _GioiTinh, _DienThoai, _Email, _DiaChi);
                return khachhang.InsertKhachHang();
            }
            catch
            {
                return 0;
            }
        }
        // method update
        public static int UpdateKhachHang(string _IdKhachHang, string _TenKhachHang, string _GioiTinh, string _DienThoai, string _Email, string _DiaChi)
        {
            try
            {
                Models.KhachHangMod khachhang = new Models.KhachHangMod(_IdKhachHang, _TenKhachHang, _GioiTinh, _DienThoai, _Email, _DiaChi);
                return khachhang.UpdateKhachHang();
            }
            catch
            {
                return 0;
            }
        }
        // mwthod delete
        public static int DeleteKhachHang(string _datasetNoiDungID)
        {
            try
            {
                Models.KhachHangMod khachhang = new Models.KhachHangMod(_datasetNoiDungID);
                return khachhang.DeleteKhachHang();
            }
            catch
            {
                return 0;
            }
        }
    }
}
