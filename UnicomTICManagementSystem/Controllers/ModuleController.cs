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
    internal class ModuleController
    {
        public void AddModule(Module module)
        {
            string query = "INSERT INTO Modules (ModuleName, CourseID) VALUES (@name, @courseId)";

            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", module.ModuleName[0].ToString().ToUpper() + module.ModuleName.Substring(1));
                cmd.Parameters.AddWithValue("@courseId", module.CourseID);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Module> GetAllModules()
        {



            var modules = new List<Module>();
            string query = @"
                SELECT m.ModuleID, m.ModuleName, m.CourseID, c.CourseName
                FROM Modules m
                LEFT JOIN Courses c ON m.CourseID = c.CourseID";

            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(query, conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    modules.Add(new Module
                    {
                        ModuleID = reader.GetInt32(0),
                        ModuleName = reader.GetString(1),
                        CourseID = reader.GetInt32(2)
                    });
                }
            }
            return modules;
        }

        public void UpdateModule(Module module)
        {
            string updateQuery = "UPDATE Modules SET ModuleName = @name, CourseID = @courseId WHERE ModuleID = @id";

            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(updateQuery, conn))
            {
                cmd.Parameters.AddWithValue("@id", module.ModuleID);
                cmd.Parameters.AddWithValue("@name", module.ModuleName[0].ToString().ToUpper() + module.ModuleName.Substring(1));
                cmd.Parameters.AddWithValue("@courseId", module.CourseID);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteModule(int id)
        {
            string deleteQuery = "DELETE FROM Modules WHERE ModuleID = @id";

            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(deleteQuery, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public Module SearchModule(int id)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = @"
                SELECT m.ModuleID, m.ModuleName, m.CourseID, c.CourseName
                FROM Modules m
                LEFT JOIN Courses c ON m.CourseID = c.CourseID
                WHERE m.ModuleID = @id";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Module
                            {
                                ModuleID = reader.GetInt32(0),
                                ModuleName = reader.GetString(1),
                                CourseID = reader.GetInt32(2)
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}