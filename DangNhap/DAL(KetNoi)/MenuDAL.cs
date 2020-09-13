using QuanLyQuanCafeApp.Models.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafeApp.Models.DAO
{
    public class MenuDAO : BaseRepository
    {
        public List<HoaDonChiTiet> LayMenuTuBan(int maBan)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "select f.TenMon, cthd.SoLuong, f.GiaBan from Mon as f, HoaDon as hd, ChiTietHoaDon as cthd where hd.Id = cthd.IdHoaDon and cthd.IdMon = f.Id and hd.IdBan = " + maBan+" and hd.TrangThai = 0";
                connection.Open();
                List<HoaDonChiTiet> dsMenu = new List<HoaDonChiTiet>();
                SqlDataAdapter da = new SqlDataAdapter(sql, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    HoaDonChiTiet menu = new HoaDonChiTiet(row);
                    dsMenu.Add(menu);
                }

                return dsMenu;
            }

        }
    }
}
