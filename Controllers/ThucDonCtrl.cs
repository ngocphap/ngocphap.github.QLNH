using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Doan_QLNH.Controllers
{
    class ThucDonCtrl
    {
        public static DataSet FillDataSet_getThucDonByIdThucDon(string _idThucDon)
        {
            try
            {
                Models.ThucDonMod tdon = new Models.ThucDonMod(_idThucDon);
                return tdon.FillDataSet_getThucDonByIdThucDon();
            }
            catch
            {
                return null;
            }
        }

        // method add
        public static int InsertThucDon(string _IdThucDon, string _TenLoaiThucDon, string _TenThucDon, string _DonViTinh, int _SoLuongTon, decimal _DonGiaTon, string _TrangThai, byte[] _HinhAnh)
        {
            try
            {
                Models.ThucDonMod _nhanVien = new Models.ThucDonMod(_IdThucDon, _TenLoaiThucDon, _TenThucDon, _DonViTinh, _SoLuongTon, _DonGiaTon, _TrangThai,_HinhAnh);
                return _nhanVien.InsertThucDon();
            }
            catch
            {
                return 0;
            }
        }
        // method update
        public static int UpdateThucDon(string _IdThucDon, string _TenLoaiThucDon, string _TenThucDon, string _DonViTinh, int _SoLuongTon, decimal _DonGiaTon, string _TrangThai, byte[] _HinhAnh)
        {
            try
            {
                Models.ThucDonMod _thucdon = new Models.ThucDonMod(_IdThucDon, _TenLoaiThucDon, _TenThucDon, _DonViTinh, _SoLuongTon, _DonGiaTon, _TrangThai,_HinhAnh);
                return _thucdon.UpdateThucDon();
            }
            catch
            {
                return 0;
            }
        }
        // mwthod delete
        public static int DeleteThucDon(string _IdThucDon)
        {
            try
            {
                Models.ThucDonMod _thucdon = new Models.ThucDonMod(_IdThucDon);
                return _thucdon.DeleteThucDon();
            }
            catch
            {
                return 0;
            }
        }
       
    }
}
