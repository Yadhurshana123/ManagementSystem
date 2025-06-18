using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Datas;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Controllers
{
    internal class StudentLecturerController
    {
        public void AssignLecturerToStudent(int studentId, int lecturerId)
        {
            string query = @"
                INSERT INTO StudentLecturers (StudentID, LecturerID)
                VALUES (@studentId, @lecturerId)";

            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@studentId", studentId);
                cmd.Parameters.AddWithValue("@lecturerId", lecturerId);
                cmd.ExecuteNonQuery();
            }
        }
        public List<Lecturer> GetLecturersForStudent(int studentId)
        {
            var lecturers = new List<Lecturer>();
            string query = @"
                    SELECT l.LectureID, l.UserID, l.Name, l.Address, l.Email, l.PhoneNumber
                    FROM StudentLecturers sl
                    JOIN Lecturers l ON sl.LecturerID = l.LectureID
                    WHERE sl.StudentID = @studentId";

            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@studentId", studentId);
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
                            PhoneNumber = reader.GetString(5)
                        });
                    }
                }
            }
            return lecturers;
        }

        public void RemoveLecturerFromStudent(int studentId, int lecturerId)
        {
            string query = @"
                DELETE FROM StudentLecturers
                WHERE StudentID = @studentId AND LecturerID = @lecturerId";

            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@studentId", studentId);
                cmd.Parameters.AddWithValue("@lecturerId", lecturerId);
                cmd.ExecuteNonQuery();
            }
        }

        //private readonly StudentLectureService _service;

        //public StudentLecturerController()
        //{
        //    _service = new StudentLectureService();
        //}

        //public void AssignLecturerToStudent(int studentId, int lectureId)
        //    => _service.AssignLecturerToStudent(studentId, lectureId);

        //public void RemoveLecturerFromStudent(int studentId, int lectureId)
        //    => _service.RemoveLecturerFromStudent(studentId, lectureId);

        //public List<Lecturer> GetTeachersForStudent(int studentId)
        //    => _service.GetTeachersForStudent(studentId);
    }
}
