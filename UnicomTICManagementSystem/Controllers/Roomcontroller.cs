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
    internal class Roomcontroller
    {
        public void AddRoom(Room room)
        {
            string query = "INSERT INTO Rooms (RoomName, RoomType) VALUES (@name, @type)";
            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", room.RoomName[0].ToString().ToUpper() + room.RoomName.Substring(1));
                cmd.Parameters.AddWithValue("@type", room.RoomType);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Room> GetAllRooms()
        {
            var rooms = new List<Room>();

            string query = "SELECT RoomID, RoomName, RoomType FROM Rooms";
            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(query, conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    rooms.Add(new Room
                    {
                        RoomID = reader.GetInt32(0),
                        RoomName = reader.GetString(1),
                        RoomType = reader.GetString(2),
                    });
                }
            }

            return rooms;
        }

        public void UpdateRoom(Room room)
        {
            string query = "UPDATE Rooms SET RoomName = @name, RoomType = @type WHERE RoomID = @id";
            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", room.RoomID);
                cmd.Parameters.AddWithValue("@name", room.RoomName[0].ToString().ToUpper() + room.RoomName.Substring(1));
                cmd.Parameters.AddWithValue("@type", room.RoomType);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteRoom(int id)
        {
            string query = "DELETE FROM Rooms WHERE RoomID = @id";
            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}


