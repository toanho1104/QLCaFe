using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafeApp.Models
{
    public class ThucDonRepository : BaseRepository
    {
        public int AddThucDon(ThucDon obj)
        {
            Parameter parameter = new Parameter { Name = "@Name", Value = obj.Name, DbType = DbType.String };
            return Save("AddThucDon", parameter);
        }
        public int DeleteThucDon(int Id)
        {
            Parameter parameter = new Parameter { Name = "@Id", Value = Id, DbType = DbType.Int32 };
            return Save("DeleteThucDon", parameter);
        }
        public int UpdateThucDon(ThucDon obj)
        {
            Parameter[] parameters =
            {
                new Parameter{Name = "@Id", Value = obj.Id, DbType = DbType.Int32 },
                new Parameter{Name = "@Name", Value = obj.Name, DbType = DbType.String }
            };
            return Save("UpdateThucDon", parameters);
        }
        public bool isTonTaiThucDonTrong_Mon(int Id)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT COUNT(*) FROM Mon WHERE IdThucDon = " + Id;
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
        public List<ThucDon> GetThucDons()
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM ThucDon";
                    connection.Open();
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        List<ThucDon> list = new List<ThucDon>();
                        while (reader.Read())
                        {
                            list.Add(new ThucDon
                            {
                                Id = (int)reader["Id"],
                                Name = (string)reader["Name"]
                            });
                        }
                        return list;
                    }
                }
            }
        }
        public ThucDon GetThucDonById(int id)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM ThucDon WHERE Id = " + id;
                    connection.Open();
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        ThucDon obj = new ThucDon();
                        if (reader.Read())
                        {
                            obj.Id = (int)reader["Id"];
                            obj.Name = (string)reader["Name"];
                        }
                        return obj;
                    }
                }
            }
        }
    }
}
