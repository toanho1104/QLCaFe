using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafeApp.Models.DTO
{
    public class HoaDonChiTiet
    {
        public string TenMon { get; set; }
        public int SoLuong { get; set; }
        public float GiaBan { get; set; }

        public HoaDonChiTiet(string _tenMon, int _soLuong,float _giaban)
        {
            TenMon = _tenMon;
            SoLuong = _soLuong;
            GiaBan = _giaban;
        }

        public HoaDonChiTiet(DataRow row)
        {
            TenMon = row["TenMon"].ToString();
            SoLuong = int.Parse(row["SoLuong"].ToString());
            GiaBan = float.Parse(row["Giaban"].ToString());
        }
    }
}
