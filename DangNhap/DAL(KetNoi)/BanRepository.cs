using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafeApp.Models
{
    public class BanRepository : BaseRepository
    {
        public int AddBan(Ban obj)
        {
            Parameter parameter = new Parameter { Name = "@Name", Value = obj.Name, DbType = DbType.String };
            return Save("AddBan", parameter);
        }
        public int DeleteBan(int Id)
        {
            Parameter parameter = new Parameter { Name = "@Id", Value = Id, DbType = DbType.Int32 };
            return Save("DeleteBan", parameter);
        }
        public int UpdateBan(Ban obj)
        {
            Parameter[] parameters =
            {
                new Parameter{Name = "@Id", Value = obj.Id, DbType = DbType.Int32 },
                new Parameter{Name = "@Name", Value = obj.Name, DbType = DbType.String }
            };
            return Save("UpdateBan", parameters);
        }
        public bool isTonTaiBanTrong_HoaDon(int Id)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT COUNT(*) FROM HoaDon WHERE IdBan = " + Id;
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
        public List<Ban> GetBans()
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Ban";
                    connection.Open();
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        List<Ban> list = new List<Ban>();
                        while (reader.Read())
                        {
                            list.Add(new Ban
                            {
                                Id = (int)reader["Id"],
                                Name = (string)reader["Name"],
                                TrangThai = (string)reader["TrangThai"]
                            });
                        }
                        return list;
                    }
                }
            }
        }
        public int CapNhatTrangThaiBan(int id,string tt)
        {
            Parameter[] parameters =
            {
                new Parameter{Name = "@Id", Value = id, DbType = DbType.Int32 },
                new Parameter{Name= "@TrangThai", Value = tt, DbType = DbType.String}
            };
            return Save("CapNhatTrangThaiBan", parameters);
        }


    }
}
