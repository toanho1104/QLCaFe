using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafeApp.Models.DTO
{
    public class ChiTietHoaDon
    {
        public int IdHoaDon { get; set; }
        public int IdMon { get; set; }
        public int SoLuong { get; set; }

        public ChiTietHoaDon(int _IdHoaDon, int _IdMon, int _soLuong)
        {
            IdHoaDon = _IdHoaDon;
            IdMon = _IdMon;
            SoLuong = _soLuong;
        }
    }
}
