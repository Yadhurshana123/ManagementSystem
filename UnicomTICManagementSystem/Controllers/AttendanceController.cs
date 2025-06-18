using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Datas;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Controllers
{
    internal class AttendanceController
    {
        public void MarkAttendance(Attendance attendance)
        {
            string query = @"INSERT INTO Attendances (TimetableID, StudentID, Timestamp, Status )
                         VALUES (@ttid, @sid, @time, @status)";
            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ttid", attendance.TimetableID);
                cmd.Parameters.AddWithValue("@sid", attendance.StudentID);
                cmd.Parameters.AddWithValue("@time", attendance.Timestamp.ToString());
                cmd.Parameters.AddWithValue("@status", attendance.Status);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateAttendance(Attendance attendance)
        {
            string query = @"
                UPDATE Attendances 
                SET TimetableID = @ttid,
                    StudentID = @sid,
                    Timestamp = @time, 
                    Status = @status 
                WHERE AttendanceID = @id";


            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", attendance.AttendanceID);
                cmd.Parameters.AddWithValue("@ttid", attendance.TimetableID);
                cmd.Parameters.AddWithValue("@sid", attendance.StudentID);
                cmd.Parameters.AddWithValue("@time", attendance.Timestamp.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("@status", attendance.Status);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Attendance> GetAttendance()
        {
            var list = new List<Attendance>();
            string query = @"SELECT a.AttendanceID, a.TimetableID, a.StudentID, a.Status, a.Timestamp, s.Name
                 FROM Attendances a
                 LEFT JOIN Students s ON a.StudentID = s.StudentID
                 LEFT JOIN Timetables t ON a.TimetableID = t.TimetableID";


            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(query, conn))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var attendance = new Attendance()
                        {
                            AttendanceID = reader.GetInt32(0),
                            TimetableID = reader.GetInt32(1),
                            StudentID = reader.GetInt32(2),
                            Status = reader.GetString(3),
                            Timestamp = DateTime.Parse(reader.GetString(4))
                        };
                        list.Add(attendance);
                    }
                }
            }
            return list;
        }
    }      
}

