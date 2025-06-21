using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Datas;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Controllers
{
    class UserController 
    {
        public void AddPendingUser(User user) 
        {
            string query = @"INSERT INTO PendingUsers (Username, Password, Email, Role, CreatedAt)
                VALUES (@username, @password, @email, @role, @createdAt)";

            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@role", user.Role);
                cmd.Parameters.AddWithValue("@createdAt", DateTime.Now);
                cmd.ExecuteNonQuery();
            }
        }

        public List<User> GetAllPendingUsers()
        {
            List<User> usersList = new List<User>();
            using (var conn = DBConfig.GetConnection())
            {
                string query = "SELECT UserID, Username, Email, Role, CreatedAt FROM PendingUsers";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User()
                            {
                                UserID = Convert.ToInt32(reader["UserID"]),
                                Username = reader["Username"].ToString(),
                                Email = reader["Email"].ToString(),
                                Role = reader["Role"].ToString(),
                                CreatedAt = Convert.ToDateTime(reader["CreatedAt"]),
                            };
                            usersList.Add(user);
                        }
                    }
                }
            }
            return usersList;
        }
        public void AddUser(User user)
        {
            string addUserQuery = @"
                INSERT INTO Users (Username, Password, Email, Role, CreatedAt)
                VALUES (@username, @password, @email, @role, @createdAt)";

            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(addUserQuery, conn))
            {
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@role", user.Role);
                cmd.Parameters.AddWithValue("@createdAt", DateTime.Now);
                cmd.ExecuteNonQuery();
            }
        }

        public List<User> GetAllUsers()
        {
            List<User> usersList = new List<User>();
            using (var conn = DBConfig.GetConnection())
            {
                string query = "SELECT UserID, Username, Email, Role, CreatedAt FROM Users";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User()
                            {
                                UserID = Convert.ToInt32(reader["UserID"]),
                                Username = reader["Username"].ToString(),
                                Email = reader["Email"].ToString(),
                                Role = reader["Role"].ToString(),
                                CreatedAt = Convert.ToDateTime(reader["CreatedAt"]),
                            };
                            usersList.Add(user);
                        }
                    }
                }
            }
            return usersList;
        }

        public User UserValidation(string username, string password)
        {
            string query = "SELECT * FROM Users WHERE Username = @username AND Password = @password";

            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new User
                        {
                            UserID = Convert.ToInt32(reader["UserID"]),
                            Username = reader["Username"].ToString(),
                            Role = reader["Role"].ToString(),
                        };
                    }
                }
            }
            return null;
        }

        public User GetUserByUserId(int userId) 
        {
            string query = "SELECT * FROM Users WHERE UserID = @userId";
            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@userId", userId); 
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        User user = new User
                        {
                            UserID = Convert.ToInt32(reader["UserID"]),
                            Username = reader["Username"].ToString(),
                            Password = reader["Password"].ToString(),
                            Role = reader["Role"].ToString()
                        };
                        return user; 
                    }

                    else
                    {
                        return null; 
                    }
                }
            }
        }
    }
}


