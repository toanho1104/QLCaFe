using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyQuanCafeApp.Models
{
    public class MonRepository : BaseRepository
    {
        public int DeleteMon(int id)
        {
            Parameter[] parameters =
            {
                new Parameter{Name = "@Id", Value = id, DbType = DbType.Int32 }
            };
            return Save("DeleteMon", parameters);
        }
        public int UpdateMon(Mon obj)
        {
            Parameter[] parameters =
            {
                new Parameter{Name = "@Id", Value = obj.Id, DbType = DbType.Int32 },
                new Parameter{Name = "@TenMon", Value = obj.TenMon, DbType = DbType.String },
                new Parameter{Name = "@Giaban", Value = obj.GiaBan, DbType = DbType.Double },
                new Parameter{Name = "@IdThucDon", Value = obj.IdThucDon, DbType = DbType.Int32 }
            };
            return Save("UpdateMon", parameters);
        }
        public int AddMon(Mon obj)
        {
            Parameter[] parameters =
            {
                new Parameter{Name = "@TenMon", Value = obj.TenMon, DbType = DbType.String },
                new Parameter{Name = "@Giaban", Value = obj.GiaBan, DbType = DbType.Double },
                new Parameter{Name = "@IdThucDon", Value = obj.IdThucDon, DbType = DbType.Int32 }
            };
            return Save("AddMon", parameters);
        }
        
        public List<Mon> getMonByIdThucDon(int idthucdon)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Mon WHERE IdThucDon =" + idthucdon;
                    connection.Open();
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        List<Mon> list = new List<Mon>();
                        while (reader.Read())
                        {
                            list.Add(new Mon
                            {
                                Id = (int)reader["Id"],
                                TenMon = (string)reader["TenMon"],
                                GiaBan = (double)reader["GiaBan"],
                                IdThucDon = (int)reader["IdThucDon"]
                            });
                        }
                        return list;
                    }
                }
            }
        }
        public bool isTonTaiMon(int id)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT COUNT(*) FROM Mon WHERE Id =" + id;
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    if(count >= 1)
                    {
                        return true;
                    }
                    return false;
                }
            }
        }
        public List<Mon> GetMons()
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Mon";
                    connection.Open();
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        List<Mon> list = new List<Mon>();
                        while (reader.Read())
                        {
                            list.Add(new Mon
                            {
                                Id = (int)reader["Id"],
                                TenMon = (string)reader["TenMon"],
                                GiaBan = (double)reader["GiaBan"],
                                IdThucDon = (int)reader["IdThucDon"]
                            });
                        }
                        return list;
                    }
                }
            }
        }
        public Mon GetMonById(int id)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Mon WHERE Id = " + id;
                    connection.Open();
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Mon
                            {
                                Id = (int)reader["Id"],
                                TenMon = (string)reader["TenMon"],
                                GiaBan = (double)reader["GiaBan"],
                                IdThucDon = (int)reader["IdThucDon"]
                            };
                        }
                        return null;
                    }
                }
            }
        }
        public int XoaMonKhiOrder(int idhoadon, int idmon)
        {
            Parameter[] parameters =
            {
                new Parameter{Name = "@IdHoaDon", Value = idhoadon, DbType = DbType.Int32 },
                new Parameter{Name = "@IdMon", Value = idmon, DbType = DbType.Int32 }
            };
            
            return Save("XoaMonKhiOrder", parameters);
        }
        public Mon GetMonTheoTen(string tenmon)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "GetMonTheoTen";
                    command.CommandType = CommandType.StoredProcedure;
                    SetParameter(command, new Parameter {Name="@Tenmon",Value=tenmon,DbType=DbType.String });
                    connection.Open();
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Mon
                            {
                                Id = (int)reader["Id"],
                                TenMon = (string)reader["TenMon"],
                                GiaBan = (double)reader["GiaBan"],
                                IdThucDon = (int)reader["IdThucDon"]
                            };
                        }
                        return null;
                    }
                }
            }
        }
    }
}
