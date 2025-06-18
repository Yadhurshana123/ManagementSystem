using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Datas;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Controllers
{
    internal class MarkController 
    {
        public void AddMark(Mark mark)
        {
            string addMarkQuery = "INSERT INTO Marks (StudentID, ExamID, Score, Results) VALUES (@studentId, @examId, @score, @results)";

            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(addMarkQuery, conn))
            {
                cmd.Parameters.AddWithValue("@studentId", mark.StudentID);
                cmd.Parameters.AddWithValue("@examId", mark.ExamID);
                cmd.Parameters.AddWithValue("@score", mark.Score);
                cmd.Parameters.AddWithValue("@results", mark.Results);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Mark> GetAllMarks()
        {
            List<Mark> marks = new List<Mark>();
            string query = "SELECT MarkID, StudentID, ExamID, Score, Results FROM Marks";

            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(query, conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    marks.Add(new Mark
                    {
                        MarkID = reader.GetInt32(0),
                        StudentID = reader.GetInt32(1),
                        ExamID = reader.GetInt32(2),
                        Score = reader.GetInt32(3),
                        Results = reader.GetString(4)
                    });
                }
            }
            return marks;
        }

        public void UpdateMark(Mark mark)
        {
            string query = "UPDATE Marks SET StudentID = @studentId, ExamID = @examId, Score = @score, Results = @results WHERE MarkID = @markId";

            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@markId", mark.MarkID);
                cmd.Parameters.AddWithValue("@studentId", mark.StudentID);
                cmd.Parameters.AddWithValue("@examId", mark.ExamID);
                cmd.Parameters.AddWithValue("@score", mark.Score);
                cmd.Parameters.AddWithValue("@results", mark.Results);

                cmd.ExecuteNonQuery();
            }
        }
    }
}

