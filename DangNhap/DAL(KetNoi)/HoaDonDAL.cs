using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafeApp.Models.DAO
{
    public class HoaDonDAO : BaseRepository
    {
        public int XoaHoaDonKhiXoaAllMon(int id)
        {
            Parameter parameter=new Parameter{Name = "@Id", Value = id, DbType = DbType.Int32 };
            return Save("XoaHoaDonKhiXoaAllMon", parameter);
        }
        public DataTable ThongKeDoanhThu(DateTime fromdate, DateTime todate)
        {
            DataTable result = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ThongKeDoanhThu", conn);cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FromDate",fromdate); cmd.Parameters.AddWithValue("@ToDate",todate);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(result);
            }
            return result;
        }
        public int LayMaHoaDonTheoMaBan(int maBan)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "select * from HoaDon where IdBan =" + maBan + " and TrangThai = 0";
                    connection.Open();
                    using (IDataReader sdr = command.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            if (sdr["Id"].ToString() != "")
                                return int.Parse(sdr["Id"].ToString());
                        }
                        return -1;
                    }
                }
            }
        }

        public void ThemHD(int maBan)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = string.Format("Insert into HoaDon(TimeCheckOut, TrangThai, IdBan, NguoiLap) values({1},{2},{3},{4})",
                        DateTime.Today.ToString("yyyy-dd-MM HH:mm:ss"), "NULL", 0, maBan, "NULL");
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public int LayMaHDLonNhat()
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "Select Max(Id) from HoaDon";
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }
        public int CapNhatHoaDon(int id, DateTime time, int trangthai, string nguoilap, double tongtien, double giamgia)
        {
            Parameter[] parameters =
            {
                new Parameter{Name = "@Id", Value = id, DbType = DbType.Int32 },
                new Parameter{Name= "@Time", Value = time, DbType = DbType.DateTime},
                new Parameter{Name= "@TrangThai", Value = trangthai, DbType = DbType.Int32},
                new Parameter{Name= "@NguoiLap", Value = nguoilap, DbType = DbType.String},
                new Parameter{Name= "@TongTien", Value = tongtien, DbType = DbType.Double},
                new Parameter{Name= "@GiamGia", Value = giamgia, DbType = DbType.Double}
            };
            return Save("CapNhatHoaDon", parameters);
        }
    }
}
