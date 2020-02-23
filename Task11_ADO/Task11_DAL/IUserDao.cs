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
    public class UserDao : IUserDao
    {
        private string _connectionString = @"Data Source=DESKTOP-QALPV5U\SQLEXPRESS;Initial Catalog=XtEpamTask11Demo;Integrated Security=True";

        public void Add(User user)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "dbo.AddUserAwarded";

                var nameParameter = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@Name",
                    Value = user.Name,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(nameParameter);

                var idParameter = new SqlParameter()
                {
                    DbType = DbType.Int64,
                    ParameterName = "@Id",
                    Value = user.Id,
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(idParameter);

                var birthdayParameter = new SqlParameter()
                {
                    DbType = DbType.DateTime,
                    ParameterName = "@Birthday",
                    Value = user.DateOfBirth,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(birthdayParameter);

                

                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void  Remove(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "dbo.RemoveUserAwarded";

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

        public User GetById(int id)
        {
            User user = new User();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "dbo.GetUserById";

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

                while (reader.Read())
                {
                    user = new User()
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"] as string,
                        DateOfBirth = (DateTime)reader["Birthday"],
                        
                    };
                }
            }
            return user;
        }

        public IEnumerable<User> GetAll()
        {
            List<User> users = new List<User>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "dbo.GetAllAwardedUsers";

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    users.Add(new User()
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"] as string,
                        DateOfBirth = (DateTime)reader["Birthday"]
                        
                    });
                }
            }
            return users;
        }

        public void Reward(int userId, Award award)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "dbo.RewardUser";

                var userIdParameter = new SqlParameter()
                {
                    DbType = DbType.Int64,
                    ParameterName = "@UserId",
                    Value = userId,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(userIdParameter);

                var awardIdParameter = new SqlParameter()
                {
                    DbType = DbType.Int64,
                    ParameterName = "@AwardId",
                    Value = award.Id,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(awardIdParameter);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Award> GetAllAwardUser(int idUser)
        {
            List<Award> awards = new List<Award>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "dbo.GetAllAwardsUser";

                var userIdParameter = new SqlParameter()
                {
                    DbType = DbType.Int64,
                    ParameterName = "@IdUser",
                    Value = idUser,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(userIdParameter);

                connection.Open();

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    awards.Add(new Award()
                    {
                        Id = (int)reader["Id"],
                        Title = reader["Title"] as string
                        
                    });
                }
            }
            return awards;
        }

        public void RemoveAward(int idUser, int idAward)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "dbo.RemoveRewardFromUser";

                var userIdParameter = new SqlParameter()
                {
                    DbType = DbType.Int64,
                    ParameterName = "@IdUser",
                    Value = idUser,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(userIdParameter);

                var awardIdParameter = new SqlParameter()
                {
                    DbType = DbType.Int64,
                    ParameterName = "@IdAward",
                    Value = idAward,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(awardIdParameter);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }
    }
}
