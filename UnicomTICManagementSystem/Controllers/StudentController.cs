using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UnicomTICManagementSystem.Datas;
using UnicomTICManagementSystem.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UnicomTICManagementSystem.Controllers
{
    class StudentController 
    {
        //private readonly StudentService _studentService;

        public StudentController()
        {
            //_studentService = new StudentService();
        }

        //public List<Student> GetAllStudents() => _studentService.GetAll();

        //public void AddStudent(Student student) => _studentService.Add(student);

        //public void UpdateStudent(Student student) => _studentService.Update(student);

        //public void DeleteStudent(int studentId) => _studentService.Delete(studentId);


        public void AddStudent(Student student)
        {            
            string addStudentQuery = "INSERT INTO Students (Name, Address, DOB, PhoneNumber, UserID, CourseID) " +
                                    "VALUES (@name, @address, @dob, @number, @userid, @courseid)";
            using (var conn = DBConfig.GetConnection())
            {
                var cmd = new SQLiteCommand(addStudentQuery, conn);
                cmd.Parameters.AddWithValue("@name", student.Name[0].ToString().ToUpper() + student.Name.Substring(1));
                cmd.Parameters.AddWithValue("@address", student.Address[0].ToString().ToUpper() + student.Address.Substring(1));
                cmd.Parameters.AddWithValue("@dob", student.DOB);
                cmd.Parameters.AddWithValue("@number", student.PhoneNumber);
                cmd.Parameters.AddWithValue("@userid", student.UserID);
                cmd.Parameters.AddWithValue("@courseid", student.CourseID);
                cmd.ExecuteNonQuery();
            }
        }



        public List<Student> GetAllStudents()
        {
            var students = new List<Student>();

            string query = @"
                SELECT st.StudentID, st.UserID, st.Name, st.Address, st.DOB, st.PhoneNumber, 
                       st.CourseID, c.CourseName
                FROM Students st
                LEFT JOIN Users u ON st.UserID = u.UserID
                LEFT JOIN Courses c ON st.CourseID = c.CourseID";

            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(query, conn))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var student = new Student
                        {
                            StudentID = reader.GetInt32(0),
                            UserID = reader.GetInt32(1),
                            Name = reader.GetString(2),
                            Address = reader.GetString(3),
                            DOB = reader.GetString(4),
                            PhoneNumber = reader.GetString(5),
                            CourseID = reader.GetInt32(6),
                            CourseName = reader.IsDBNull(7) ? null : reader.GetString(7),
                        };
                        students.Add(student);
                    }
                }
            }

            return students;
        }


        public void UpdateStudent(Student student)
        {
            string updateQuery = @"
                UPDATE Students 
                SET Name = @name, 
                    UserID = @userid,
                    Address = @address, 
                    DOB = @dob, 
                    PhoneNumber = @number, 
                    CourseID = @courseid 
                WHERE StudentID = @id";

            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(updateQuery, conn))
            {
                cmd.Parameters.AddWithValue("@id", student.StudentID);
                cmd.Parameters.AddWithValue("@userid", student.UserID);
                cmd.Parameters.AddWithValue("@name", student.Name[0].ToString().ToUpper() + student.Name.Substring(1));
                cmd.Parameters.AddWithValue("@address", student.Address[0].ToString().ToUpper() + student.Address.Substring(1));
                cmd.Parameters.AddWithValue("@dob", student.DOB);
                cmd.Parameters.AddWithValue("@number", student.PhoneNumber);
                cmd.Parameters.AddWithValue("@courseid", student.CourseID);

                cmd.ExecuteNonQuery();
            }
        }


        public void DeleteStudent(int id)
        {
            string deleteQuery = "DELETE FROM Students WHERE StudentID = @id";

            using (var conn = DBConfig.GetConnection())
            using (var cmd = new SQLiteCommand(deleteQuery, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }


        public Student SearchStudent(int id)
        {
            using (var conn = DBConfig.GetConnection())
            {
                string query = "SELECT * FROM Students WHERE StudentID = @id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Student
                            {
                                StudentID = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Address = reader.GetString(2),
                                DOB = reader.GetString(3),
                                PhoneNumber = reader.GetString(4),
                                UserID = reader.GetInt32(5),
                                CourseID = reader.IsDBNull(6) ? 0 : reader.GetInt32(6)
                            };
                        }
                        else
                        {
                            MessageBox.Show("Student Not Found");
                        }
                    }
                }
            }
            return null;
        }


        //public Student GetStudentInfo(int id)
        //{
        //    string query = @"
        //        SELECT st.StudentID, st.Name, st.Address, st.DOB, st.PhoneNumber, 
        //               st.CourseID, u.Username, u.Role 
        //        FROM Students st
        //        JOIN Courses c ON st.CourseID = c.CourseID
        //        JOIN Users u ON st.UserID = u.UserID 
        //        WHERE st.UserID = @id"; 
        //    using (var conn = DBConfig.GetConnection())
        //    using (var cmd = new SQLiteCommand(query, conn))
        //    {
        //        cmd.Parameters.AddWithValue("@id", id);

        //        using (var reader = cmd.ExecuteReader())
        //        {
        //            if (reader.Read())
        //            {
        //                return new Student
        //                {
        //                    StudentID = Convert.ToInt32(reader["StudentID"]),
        //                    Name = reader["Name"].ToString(),
        //                    Address = reader["Address"].ToString(),
        //                    DOB = reader["DOB"].ToString(),
        //                    PhoneNumber = reader["PhoneNumber"].ToString(),
        //                    CourseID = Convert.ToInt32(reader["CourseID"]),
        //                };
        //            }
        //        }
        //    }
        //    return null;
        //}
    }
}