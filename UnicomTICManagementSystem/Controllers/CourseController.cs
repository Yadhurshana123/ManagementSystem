using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UnicomTICManagementSystem.Datas;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Controllers
{
    class CourseController 
    {
        public void AddCourse(Course course)
        {
            string addcourseQuery = "INSERT INTO Courses (CourseName) VALUES (@name)";
            using (var conn = DBConfig.GetConnection()) 
            {
                var cmd = new SQLiteCommand(addcourseQuery, conn);
                cmd.Parameters.AddWithValue("@name", course.CourseName);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Course> GetAllCourses()
        {
            var courses = new List<Course>();
            string query = "SELECT CourseID, CourseName FROM Courses";

            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(query, conn))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        courses.Add(new Course
                        {
                            CourseID = reader.GetInt32(0),
                            CourseName = reader.GetString(1)
                        });
                    }
                }
            }
            return courses;
        }


        public void UpdateCourse(Course course)
        {
            string updateQuery = "UPDATE Courses SET CourseName = @name WHERE CourseID = @id";

            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(updateQuery, conn))
            {
                cmd.Parameters.AddWithValue("@id", course.CourseID);
                cmd.Parameters.AddWithValue("@name", course.CourseName[0].ToString().ToUpper() + course.CourseName.Substring(1));
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteCourse(int id)
        {
            string deleteQuery = "DELETE FROM Courses WHERE CourseID = @id";

            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(deleteQuery, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public Course SearchCourse(int id)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "SELECT * FROM Courses WHERE CourseID = @id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Course
                            {
                                CourseID = Convert.ToInt32(reader["CourseID"]),
                                CourseName = reader["CourseName"].ToString()
                            };
                        }
                        else
                        {
                            MessageBox.Show("Course Not Found");
                        }
                    }
                }
            }
            return null;
        }
    }
}