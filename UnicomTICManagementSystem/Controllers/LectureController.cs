using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using UnicomTICManagementSystem.Datas;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Controllers
{
    internal class LectureController 
    {
        //private readonly LectureService _lectureService;

        //public LectureController()
        //{
        //    _lectureService = new LectureService();
        //}

        //public List<Lecturer> GetAllLectures() => _lectureService.GetAll();

        //public void AddLecture(Lecturer lecturer) => _lectureService.Add(lecturer);

        //public void UpdateLecture(Lecturer lecturer) => _lectureService.Update(lecturer);

        //public void DeleteLecture(int teacherId) => _lectureService.Delete(teacherId);

        public void AddLecture(Lecturer lecturer)
        {
            string addLectureQuery = @"
                INSERT INTO Lecturers (UserID, Name, Email, PhoneNumber, Address) 
                VALUES (@userid, @name, @email, @number, @address)";

            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(addLectureQuery, conn))
            {
                cmd.Parameters.AddWithValue("@userid", lecturer.UserID);
                cmd.Parameters.AddWithValue("@name", lecturer.Name[0].ToString().ToUpper() + lecturer.Name.Substring(1));
                cmd.Parameters.AddWithValue("@email", lecturer.Email);
                cmd.Parameters.AddWithValue("@number", lecturer.PhoneNumber);
                cmd.Parameters.AddWithValue("@address", lecturer.Address[0].ToString().ToUpper() + lecturer.Address.Substring(1));

                cmd.ExecuteNonQuery();
            }
        }

        public List<Lecturer> GetAllLectures()
        {
            List<Lecturer> lecturers = new List<Lecturer>();
            string getQuery = @"
                SELECT l.LectureID, l.UserID, l.Name, l.Address, l.Email, l.PhoneNumber
                FROM Lecturers l";

            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(getQuery, conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    lecturers.Add(new Lecturer
                    {
                        LectureID = reader.GetInt32(0),
                        UserID = reader.GetInt32(1),
                        Name = reader.GetString(2),
                        Address = reader.GetString(3),
                        Email = reader.GetString(4),
                        PhoneNumber = reader.GetString(5),
                    });
                }
            }

            return lecturers;
        }

        public void UpdateLecture(Lecturer lecturer)
        {
            string updateQuery = @"
                UPDATE Lecturers  
                SET Name = @name, UserID = @userid, Email = @email, 
                    PhoneNumber = @number, Address = @address 
                WHERE LectureID = @id";

            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(updateQuery, conn))
            {
                cmd.Parameters.AddWithValue("@id", lecturer.LectureID);
                cmd.Parameters.AddWithValue("@userid", lecturer.UserID);
                cmd.Parameters.AddWithValue("@name", lecturer.Name[0].ToString().ToUpper() + lecturer.Name.Substring(1));
                cmd.Parameters.AddWithValue("@email", lecturer.Email);
                cmd.Parameters.AddWithValue("@number", lecturer.PhoneNumber);
                cmd.Parameters.AddWithValue("@address", lecturer.Address[0].ToString().ToUpper() + lecturer.Address.Substring(1));

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteLecture(int id)
        {
            string deleteQuery = "DELETE FROM Lecturers WHERE LectureID = @id";

            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(deleteQuery, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
 
        public Lecturer SearchLecturer(int id)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "SELECT * FROM Lecturers WHERE LectureID = @id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Lecturer
                            {
                                LectureID = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                PhoneNumber = reader.GetString(2),
                                Email = reader.GetString(3),
                                Address = reader.GetString(4),
                                UserID = reader.GetInt32(5),
                            };
                        }

                        else
                        {
                            MessageBox.Show("Lecturer Not Found");
                        }
                    }
                }
            }
            return null;
        }
                

//        public Lecturer GetLecturerInfo(int id)
//        {
//            string query = @"
//                SELECT l.LectureID, l.Name, l.PhoneNumber, l.Email, l.Address,
//                       u.Username, u.Role
//                FROM Lecturers l
//                JOIN Users u ON l.UserID = u.UserID
//                WHERE l.UserID = @id";

//            using (var conn = DBConfig.GetConnection())
//            using (var cmd = new SQLiteCommand(query, conn))
//            {
//                cmd.Parameters.AddWithValue("@id", id);

//                using (var reader = cmd.ExecuteReader())
//                {
//                    if (reader.Read())
//                    {
//                        return new Lecturer
//                        {
//                            LectureID = Convert.ToInt32(reader["LectureID"]),
//                            Name = reader["Name"].ToString(),
//                            PhoneNumber = reader["PhoneNumber"].ToString(),
//                            Email = reader["Email"].ToString(),
//                            Address = reader["Address"].ToString(),
//                        };
//                    }
//                }
//            }
//            return null;
//        }
    }
}
