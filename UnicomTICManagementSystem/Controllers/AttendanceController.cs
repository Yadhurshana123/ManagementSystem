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
            string query = @"INSERT INTO Attendances_new (TimetableID, StudentID, LogIn, LogOut, Status )
                         VALUES (@ttid, @sid, @intime, @outtime, @status)";
            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ttid", attendance.TimetableID);
                cmd.Parameters.AddWithValue("@sid", attendance.StudentID);
                cmd.Parameters.AddWithValue("@intime", attendance.LogIn.HasValue ? attendance.LogIn.Value.ToString("HH:mm:ss") : (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@outtime", attendance.LogOut.HasValue ? attendance.LogOut.Value.ToString("HH:mm:ss") : (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@status", attendance.Status);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateAttendance(Attendance attendance)
        {
            string query = @"
                UPDATE Attendances_new 
                SET TimetableID = @ttid,
                    StudentID = @sid,
                    LogIn = @intime, 
                    LogOut = @outtime, 
                    Status = @status 
                WHERE AttendanceID = @id";


            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", attendance.AttendanceID);
                cmd.Parameters.AddWithValue("@ttid", attendance.TimetableID);
                cmd.Parameters.AddWithValue("@sid", attendance.StudentID);
                cmd.Parameters.AddWithValue("@intime", attendance.LogIn.HasValue ? attendance.LogIn.Value.ToString("HH:mm:ss") : (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@outtime", attendance.LogOut.HasValue ? attendance.LogOut.Value.ToString("HH:mm:ss") : (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@status", attendance.Status);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Attendance> GetAttendance()
        {
            var list = new List<Attendance>();
            string query = @"SELECT a.AttendanceID, a.TimetableID, a.StudentID, a.Status, a.LogIn, a.LogOut
                 FROM Attendances_new a
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
                            LogIn = reader.IsDBNull(4) ? (DateTime?)null : DateTime.Parse(reader.GetString(4)),
                            LogOut = reader.IsDBNull(5) ? (DateTime?)null : DateTime.Parse(reader.GetString(5)),

                        };
                        list.Add(attendance);
                    }
                }
            }
            return list;
        }
    }      
}

