using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafeApp.Models.DTO
{
    public class Bill
    {
        public DateTime? TimeCheckIn { get; set; }
        public DateTime? TimeCheckOut { get; set; }
        public int ID { get; set; }
        public int IdBan { get; set; }
        public int TrangThai { get; set; }
        public string NguoiLap { get; set; }

        public Bill(int ID, DateTime? TimeCheckIn, DateTime? TimeCheckOut, int TrangThai, int IdBan, string NguoiLap)
        {
            this.ID = ID;
            this.TimeCheckIn = TimeCheckIn;
            this.TimeCheckOut = TimeCheckOut;
            this.TrangThai = TrangThai;
            this.IdBan = IdBan;
            this.NguoiLap = NguoiLap;
        }
    }
}
