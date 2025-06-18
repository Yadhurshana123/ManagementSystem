using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Datas;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Controllers
{
    class TimetableController
    {
        public void AddTimetable(Timetable timetable)
        {
            string query = @"INSERT INTO Timetables (ModuleID, Date, StartTime, EndTime, RoomID)
                             VALUES (@moduleid, @date, @start, @end, @roomid)";

            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@moduleid", timetable.ModuleID);
                cmd.Parameters.AddWithValue("@date", timetable.Date);
                cmd.Parameters.AddWithValue("@start", timetable.StartTime);
                cmd.Parameters.AddWithValue("@end", timetable.EndTime);
                cmd.Parameters.AddWithValue("@roomid", timetable.RoomID);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Timetable> GetAllTimetables()
        {
            var list = new List<Timetable>();
            using (var conn = DBConfig.GetConnection()) 
            {
                string query = @"SELECT a.AttendanceID, a.TimetableID, a.StudentID, a.Status, a.Timestamp, s.Name
                     FROM Attendances a
                     LEFT JOIN Students s ON a.StudentID = s.StudentID
                     LEFT JOIN Timetables t ON a.TimetableID = t.TimetableID";

                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())

                while (reader.Read())
                {
                    var timetable = new Timetable
                    {
                        TimetableID = reader.GetInt32(0),
                        ModuleID = reader.GetInt32(1),
                        Date = reader.GetString(2),
                        StartTime = TimeSpan.Parse(reader.GetString(3)),
                        EndTime = TimeSpan.Parse(reader.GetString(4)),
                        RoomID = reader.GetInt32(5),
                    };
                    list.Add(timetable);
                }
            }

            return list;
        }


        public void UpdateTimetable(Timetable timetable)
        {
            string query = @"UPDATE Timetables 
                     SET ModuleID = @moduleid, Date = @date, StartTime = @start, EndTime = @end, RoomID = @roomid 
                     WHERE TimetableID = @id";

            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", timetable.TimetableID);
                cmd.Parameters.AddWithValue("@moduleid", timetable.ModuleID);
                cmd.Parameters.AddWithValue("@date", timetable.Date);
                cmd.Parameters.AddWithValue("@start", timetable.StartTime);
                cmd.Parameters.AddWithValue("@end", timetable.EndTime);
                cmd.Parameters.AddWithValue("@roomid", timetable.RoomID);

                cmd.ExecuteNonQuery();
            }
        }


        public void DeleteTimetable(int id)
        {
            string query = "DELETE FROM Timetables WHERE TimetableID = @id";

            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public Timetable SearchTimetable(int id)
        {
            string query = "SELECT * FROM Timetables WHERE TimetableID = @id";

            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Timetable
                        {
                            TimetableID = Convert.ToInt32(reader["TimetableID"]),
                            ModuleID = Convert.ToInt32(reader["ModuleID"]),
                            Date = Convert.ToString(reader["Date"]),
                            StartTime = (TimeSpan)reader["StartTime"],
                            EndTime = (TimeSpan)reader["EndTime"],
                            RoomID = Convert.ToInt32(reader["RoomID"]),
                        };
                    }
                }
            }
            return null;
        }
    }
}