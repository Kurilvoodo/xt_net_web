using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Task10.Entities;
using Task10.Dao.Interfaces;
using System;

namespace Task11_DAL
{
    class AwardDao: IAwardDao
    {
        private static Dictionary<int, Award> _awards = new Dictionary<int, Award>();

        private string _connectionString = @"Data Source=DESKTOP-QALPV5U\SQLEXPRESS;Initial Catalog=XtEpamTask11Demo;Integrated Security=True";

        public void Add(Award award)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "dbo.AddAward";

                var titleParameter = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@Title",
                    Value = award.Title,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(titleParameter);

                var idParameter = new SqlParameter()
                {
                    DbType = DbType.Int64,
                    ParameterName = "@Id",
                    Value = award.Id,
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(idParameter);

               

                connection.Open();

                command.ExecuteNonQuery();
            }

        }

        public void Remove(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "dbo.RemoveAward";

                var idParameter = new SqlParameter()
                {
                    DbType = DbType.Int64,
                    ParameterName = "@Id",
                    Value = id,
                    Direction = ParameterDirection.Input
                };

                command.Parameters.Add(idParameter);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public Award GetById(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "dbo.GetAwardById";

                var idParameter = new SqlParameter()
                {
                    DbType = DbType.Int64,
                    ParameterName = "@Id",
                    Value = id,
                    Direction = ParameterDirection.Input
                };

                command.Parameters.Add(idParameter);

                connection.Open();
                var reader = command.ExecuteReader();

                Award award = new Award();

                while (reader.Read())
                {
                    award = new Award()
                    {
                        Id = (int)reader["Id"],
                        Title = reader["Title"] as string,
                        
                    };
                }

                return award;
            }

        }

        public IEnumerable<Award> GetAll()
        {
            List<Award> awards = new List<Award>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "dbo.GetAllAward";

                connection.Open();

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    awards.Add(new Award
                    {
                        Id = (int)reader["Id"],
                        Title = reader["Title"] as string,
                        
                    });
                }
            }
            return awards;
        }
    }
}
