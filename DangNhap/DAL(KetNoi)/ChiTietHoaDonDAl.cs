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
    public class ChiTietHoaDonDAO : BaseRepository
    {
        SqlDataAdapter da_ChiTietHoaDon;
        DataTable dt = new DataTable("ChiTietHoaDon");
        public ChiTietHoaDonDAO()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                da_ChiTietHoaDon = new SqlDataAdapter("Select * from ChiTietHoaDon", connection);
                da_ChiTietHoaDon.Fill(dt);
            }
        }

        public List<ChiTietHoaDon> LayDanhSachCTHD(int maHD)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "select * from ChiTietHoaDon where IdHoaDon = " + maHD + "";
                    connection.Open();
                    using (SqlDataReader sdr = command.ExecuteReader())
                    {
                        List<ChiTietHoaDon> dsCTHD = new List<ChiTietHoaDon>();
                        while (sdr.Read())
                        {
                            ChiTietHoaDon cthd = new ChiTietHoaDon(
                                int.Parse(sdr["IdHoaDon"].ToString()),
                                int.Parse(sdr["IdMon"].ToString()),
                                int.Parse(sdr["SoLuong"].ToString()));
                            dsCTHD.Add(cthd);
                        }
                        return dsCTHD;
                    }
                }
            }

        }

        public void ThemChiTietHoaDon(int idHoaDon, int idMon, int soLuong)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = string.Format("Insert into ChiTietHoaDon values('{0}','{1}','{2}','{3}')", idHoaDon, idMon, soLuong, null);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public bool KiemTraMonAnTonTai(int maHoaDon, int maMon)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    string result = string.Empty;
                    command.CommandText = string.Format("Select * from ChiTietHoaDon where IdHoaDon = {0} and IdMon = {1}", maHoaDon, maMon);
                    connection.Open();
                    if (command.ExecuteScalar() != null)
                        result = command.ExecuteScalar().ToString();
                    if (result != "")
                        return true;
                    else
                        return false;
                }
            }
        }

        public int LaySoLuong(int maHoaDon, int maMon)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = string.Format("select SoLuong from ChiTietHoaDon where IdHoaDon = {0} and IdMon = {1}", maHoaDon, maMon);
                    connection.Open();
                    var result = 0;
                    if (command.ExecuteScalar().ToString() != "")
                        result = (int)command.ExecuteScalar();
                    return result;
                }
            }
        }

        public void CapNhapSoLuong(int maHoaDon, int maMon, int soLuong)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    int soLuongTang = LaySoLuong(maHoaDon, maMon) + soLuong;
                    command.CommandText = string.Format("Update ChiTietHoaDon set SoLuong = {0} where IdHoaDon = {1} and IdMon = {2}", soLuongTang, maHoaDon, maMon);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        public bool isTonTaiMonTrongCTHD(int IdMon)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT COUNT(*) FROM ChiTietHoaDon WHERE IdMon =" + IdMon;
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    if (count >= 1)
                    {
                        return true;
                    }
                    return false;
                }
            }
        }
    }
}
