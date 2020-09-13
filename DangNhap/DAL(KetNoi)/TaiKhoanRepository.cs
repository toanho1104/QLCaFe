using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyQuanCafeApp.Models
{
    public class TaiKhoanRepository : BaseRepository
    {
        public int ResetPassWord(string username)
        {
            Parameter parameter = new Parameter { Name = "@UserName", Value = username, DbType = DbType.String };
            return Save("ResetPassWord", parameter);
        }
        public int AddTaiKhoan(TaiKhoan obj)
        {
            Parameter[] parameters =
            {
                new Parameter{Name = "@UserName", Value = obj.UserName, DbType = DbType.String },
                new Parameter{Name = "@Fullname", Value = obj.FullName, DbType = DbType.String },
                new Parameter{Name = "@Matkhau", Value = obj.UserName, DbType = DbType.String },
                new Parameter{Name = "@HoatDong", Value = obj.Hoatdong, DbType = DbType.Int32 },
                new Parameter{Name = "@Phanquyen", Value = obj.Phanquyen, DbType = DbType.Int32 }
            };
            return Save("AddTaiKhoan", parameters);
        }
        public int UpdateTaiKhoan(TaiKhoan obj)
        {
            Parameter[] parameters =
            {
                new Parameter{Name = "@UserName", Value = obj.UserName, DbType = DbType.String },
                new Parameter{Name = "@Fullname", Value = obj.FullName, DbType = DbType.String },
                new Parameter{Name = "@HoatDong", Value = obj.Hoatdong, DbType = DbType.Int32 },
                new Parameter{Name = "@Phanquyen", Value = obj.Phanquyen, DbType = DbType.Int32 }
            };
            return Save("UpdateTaiKhoan", parameters);
        }
        public bool isTrungUserName(string username)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT COUNT(*) FROM TaiKhoan WHERE UserName = '" + username +"'";
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
        public TaiKhoan Login(string username, string password, out int ret)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "Login";
                    command.CommandType = CommandType.StoredProcedure;
                    Parameter[] parameters = {
                        new Parameter{Name = "@username", Value = username, DbType = DbType.String },
                        new Parameter{Name = "@password", Value = password, DbType = DbType.String },
                        new Parameter{Name = "@Ret", DbType = DbType.Int32, Direction = ParameterDirection.ReturnValue }
                    };
                    SetParameter(command, parameters);
                    connection.Open();
                    TaiKhoan obj = null;
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            obj = new TaiKhoan
                            {
                                UserName = (string)reader["UserName"],
                                FullName = (string)reader["FullName"],
                                Hoatdong = (int)reader["HoatDong"],
                                Phanquyen = (int)reader["PhanQuyen"]
                            };
                        }
                    }
                    IDataParameter parameter = (IDataParameter)command.Parameters["@Ret"];
                    ret = (int)parameter.Value;
                    return obj;
                }
            }
        }
        public TaiKhoan GetAccountByUserName(string username)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "GetAccountByUserName";
                    command.CommandType = CommandType.StoredProcedure;
                    SetParameter(command, new Parameter { Name = "@username", Value = username, DbType = DbType.String });
                    connection.Open();
                    TaiKhoan obj = null;
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            obj = new TaiKhoan
                            {
                                UserName = (string)reader["UserName"],
                                FullName = (string)reader["FullName"],
                                Hoatdong = (int)reader["HoatDong"],
                                Phanquyen = (int)reader["PhanQuyen"]
                            };
                        }
                    }
                    return obj;
                }
            }
        }
        public bool UpdateThongTinCaNhan(string username, string fullname, string password, string newpassword)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "UpdateThongTinCaNhan";
                    command.CommandType = CommandType.StoredProcedure;
                    Parameter[] parameters = {
                        new Parameter{Name = "@Username", Value = username, DbType = DbType.String },
                        new Parameter{Name = "@Fullname", Value = fullname, DbType = DbType.String },
                        new Parameter{Name = "@password", Value = password, DbType = DbType.String },
                        new Parameter{Name = "@newpassword", Value = newpassword, DbType = DbType.String }
                    };
                    SetParameter(command, parameters);
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
        public List<TaiKhoan> GetTaiKhoans()
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT UserName,FullName AS HoTen, HoatDong,PhanQuyen FROM TaiKhoan";
                    connection.Open();
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        List<TaiKhoan> list = new List<TaiKhoan>();
                        while (reader.Read())
                        {
                            list.Add(new TaiKhoan
                            {
                                UserName = (string)reader["UserName"],
                                FullName = (string)reader["HoTen"],
                                Hoatdong = (int)reader["HoatDong"],
                                Phanquyen = (int)reader["PhanQuyen"]
                            });
                        }
                        return list;
                    }
                }
            }
        }
    }
}
