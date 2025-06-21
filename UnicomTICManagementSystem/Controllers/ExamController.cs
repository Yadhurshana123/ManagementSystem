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
    internal class ExamController
    {
        public void AddExam(Exam exam)
        {
            string query = @"INSERT INTO Exams (ExamName, ModuleID, RoomID, Date, StartTime, EndTime)
                         VALUES (@name, @moduleid, @roomid, @date, @start, @end)"
            ;

            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", exam.ExamName[0].ToString().ToUpper() + exam.ExamName.Substring(1));
                cmd.Parameters.AddWithValue("@moduleid", exam.ModuleID);
                cmd.Parameters.AddWithValue("@roomid", exam.RoomID);
                cmd.Parameters.AddWithValue("@date", exam.Date.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@start", exam.StartTime.ToString(@"hh\:mm\:ss"));
                cmd.Parameters.AddWithValue("@end", exam.EndTime.ToString(@"hh\:mm\:ss"));  

                cmd.ExecuteNonQuery();
            }
        }

        public List<Exam> GetAllExams()
        {
            List<Exam> exams = new List<Exam>();
            string query = @"
                    SELECT e.ExamID, e.ExamName, e.ModuleID, m.ModuleName, 
                           e.RoomID, e.Date, r.RoomName, e.StartTime, e.EndTime
                    FROM Exams e
                    JOIN Modules m ON e.ModuleID = m.ModuleID
                    JOIN Rooms r ON e.RoomID = r.RoomID"
            ;

            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(query, conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    exams.Add(new Exam
                    {
                        ExamID = reader.GetInt32(0),
                        ExamName = reader.GetString(1),
                        ModuleID = reader.GetInt32(2),
                        ModuleName = reader.GetString(3),
                        RoomID = reader.GetInt32(4),
                        Date = reader.GetDateTime(5),
                        RoomName = reader.GetString(6),                      
                        StartTime = TimeSpan.Parse(reader.GetString(7)),
                        EndTime = TimeSpan.Parse(reader.GetString(8))
                    });
                }

            }

            return exams;
        }

        public void UpdateExam(Exam exam)
        {
            string query = @"UPDATE Exams 
                         SET ExamName = @name, ModuleID = @moduleid, RoomID = @roomid, Date = @date,
                             StartTime = @start, EndTime = @end 
                         WHERE ExamID = @id"
            ;

            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", exam.ExamID);
                cmd.Parameters.AddWithValue("@name", exam.ExamName[0].ToString().ToUpper() + exam.ExamName.Substring(1));
                cmd.Parameters.AddWithValue("@moduleid", exam.ModuleID);
                cmd.Parameters.AddWithValue("@roomid", exam.RoomID);
                cmd.Parameters.AddWithValue("@date", exam.Date.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@start", exam.StartTime.ToString(@"hh\:mm\:ss"));
                cmd.Parameters.AddWithValue("@end", exam.EndTime.ToString(@"hh\:mm\:ss"));

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteExam(int id)
        {
            string query = "DELETE FROM Exams WHERE ExamID = @id";

            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}