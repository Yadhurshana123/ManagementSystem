using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Datas;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Controllers
{
    internal class StaffController 
    {
        public void AddStaff(Staff staff)
        {
            string addStaffQuery = "INSERT INTO Staffs (UserID, Name, Email, PhoneNumber, Address) VALUES (@userid, @name, @email, @number, @address)";

            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(addStaffQuery, conn))
            {
                cmd.Parameters.AddWithValue("@userid", staff.UserID);
                cmd.Parameters.AddWithValue("@name", staff.Name[0].ToString().ToUpper() + staff.Name.Substring(1));
                cmd.Parameters.AddWithValue("@email", staff.Email);
                cmd.Parameters.AddWithValue("@number", staff.PhoneNumber);
                cmd.Parameters.AddWithValue("@address", staff.Address[0].ToString().ToUpper() + staff.Address.Substring(1));
                cmd.ExecuteNonQuery();
            }
        }

        public List<Staff> GetAllStaffs()
        {
            List<Staff> staffList = new List<Staff>();
            string getQuery = @"
                SELECT s.StaffID, s.UserID, s.Name, s.Address, s.Email, s.PhoneNumber
                FROM Staffs s
                LEFT JOIN Users u ON s.UserID = u.UserID "
            ;

            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(getQuery, conn)) 
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        staffList.Add(new Staff
                        {
                            StaffID = reader.GetInt32(0),
                            UserID = reader.GetInt32(1),
                            Name = reader.GetString(2),
                            Address = reader.GetString(3),
                            Email = reader.GetString(4),
                            PhoneNumber = reader.GetString(5),
                        });
                    }
                }
            }
            return staffList;
        }

        public void UpdateStaff(Staff staff)
        {
            string updateQuery = "UPDATE Staffs SET Name = @name, UserID = @userid, Email = @email, PhoneNumber = @number, Address = @address WHERE StaffID = @id";

            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(updateQuery, conn))
            {
                cmd.Parameters.AddWithValue("@id", staff.StaffID);
                cmd.Parameters.AddWithValue("@userid", staff.UserID);
                cmd.Parameters.AddWithValue("@name", staff.Name[0].ToString().ToUpper() + staff.Name.Substring(1));
                cmd.Parameters.AddWithValue("@email", staff.Email);
                cmd.Parameters.AddWithValue("@number", staff.PhoneNumber);
                cmd.Parameters.AddWithValue("@address", staff.Address[0].ToString().ToUpper() + staff.Address.Substring(1));
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteStaff(int id)
        {
            string deleteQuery = "DELETE FROM Staffs WHERE StaffID = @id";

            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(deleteQuery, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public Staff SearchStaff(int id)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "SELECT * FROM Staffs WHERE StudentID = @id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Staff
                            {
                                StaffID = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                PhoneNumber = reader.GetString(2),
                                Email = reader.GetString(3),
                                Address = reader.GetString(4),
                                UserID = reader.GetInt32(5),
                            };
                        }
                        else
                        {
                            MessageBox.Show("Staff Not Found");
                        }
                    }
                }
            }
            return null;
        }

        public Staff GetStaffInfo(int id)
        {
            string query = @"
                SELECT s.StaffID, s.Name, s.PhoneNumber, s.Email, s.Address,
                       u.Username, u.Email, u.Role
                FROM Staffs s
                JOIN Users u ON s.UserID = u.UserID
                WHERE s.UserID = @id"
            ;

            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Staff
                        {
                            StaffID = Convert.ToInt32(reader["StaffID"]),
                            Name = reader["Name"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            Email = reader["Email"].ToString(),
                            Address = reader["Address"].ToString(),
                        };
                    }
                }
            }
            return null;
        }
    }
} 

