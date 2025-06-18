using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Views
{
    public partial class Manage_student : Form
    {
        private int selectedStudentId = -1;
        StudentController controller = new StudentController();
        CourseController courseController = new CourseController();

        public Manage_student()
        {
           
            InitializeComponent();
            LoadStudents();
            LoadUserCombobox();
            LoadCourseCombobox();
        }

        public void LoadUserCombobox()
        {
            UserController userController = new UserController();
            List<User> users = userController.GetAllUsers(); 

            user_name.DataSource = users;
            user_name.DisplayMember = "Username";  
            user_name.ValueMember = "UserID";      
        }

        public void LoadCourseCombobox() 
        {
            List<Course> courses = courseController.GetAllCourses();
            com_course.DataSource = courses;
            com_course.DisplayMember = "CourseName";
            com_course.ValueMember = "CourseID";
        }
        public void LoadStudents()
        {
            var list = controller.GetAllStudents();
            dgview_students.DataSource = list;        
        }

        private void ClearForm()
        {
            tname.Clear();
            taddress.Clear();
            tnumber.Clear();
            tsearch.Clear();
            user_name.SelectedIndex = -1;
            com_course.SelectedIndex = -1;
            dtp_dob.Value = DateTime.Today; 
            selectedStudentId = -1;
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tname.Text) || string.IsNullOrWhiteSpace(taddress.Text) || string.IsNullOrWhiteSpace(dtp_dob.Text) || string.IsNullOrWhiteSpace(tnumber.Text))
                {
                    MessageBox.Show("Please enter all requirements");
                    return;
                }

                if (string.IsNullOrWhiteSpace(com_course.SelectedItem?.ToString()))
                {
                    MessageBox.Show("Please select a course.");
                    return;
                }
                
                if (string.IsNullOrWhiteSpace(user_name.SelectedItem?.ToString()))
                {
                    MessageBox.Show("Please select a Username.");
                    return;
                }

                if (tnumber.Text.Length < 10)
                {
                    MessageBox.Show("Enter a valid phone number.");
                    return;
                }

                int selectedCourseId = com_course.SelectedIndex + 1;
                var student = new Student
                {
                    Name = tname.Text,
                    Address = taddress.Text,
                    DOB = dtp_dob.Value.ToString("yyyy-MM-dd"),
                    PhoneNumber = tnumber.Text,
                    UserID = (int)user_name.SelectedValue,
                    CourseID = (int)com_course.SelectedValue
                };

                controller.AddStudent(student);
                MessageBox.Show("Student added successfully!");
                LoadStudents();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
           

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedStudentId == -1)
                {
                    MessageBox.Show("Please select a student to edit.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(tname.Text) || 
                    string.IsNullOrWhiteSpace(taddress.Text) ||
                    string.IsNullOrWhiteSpace(dtp_dob.Text) ||
                    string.IsNullOrWhiteSpace(tnumber.Text))
                {
                    MessageBox.Show("Please enter all requirments fields.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(com_course.SelectedItem?.ToString()))
                {
                    MessageBox.Show("Please select a course.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(user_name.SelectedItem?.ToString()))
                {
                    MessageBox.Show("Please select a Username.");
                    return;
                }

                var student = new Student
                {
                    StudentID = selectedStudentId,
                    Name = tname.Text,
                    Address = taddress.Text,
                    DOB = dtp_dob.Value.ToString("yyyy-MM-dd"),
                    PhoneNumber = tnumber.Text,
                    UserID = (int)user_name.SelectedValue,
                    CourseID = (int)com_course.SelectedValue
                };

                controller.UpdateStudent(student);
                MessageBox.Show("Student updated successfully!");
                LoadStudents();
                ClearForm();
                selectedStudentId = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedStudentId == -1)
                {
                    MessageBox.Show("Please select a student to delete.");
                    return;
                }

                var confirmResult = MessageBox.Show("Are you sure to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    controller.DeleteStudent(selectedStudentId);
                    MessageBox.Show("Student Deleted Successfully");
                    LoadStudents();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //==========Search student========
        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tsearch.Text, out int id))
            {
                StudentController controller = new StudentController();
                Student result = controller.SearchStudent(id);

                if (result != null)
                {
                    dgview_students.DataSource = new List<Student> { result };
                }

                else
                {
                    MessageBox.Show("Student not found!");
                    ClearForm();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Student ID");
            }
            //try
            //{
            //    string input = tsearch.Text.Trim();
            //    if (string.IsNullOrEmpty(input))
            //    {
            //        LoadStudents();
            //        return;
            //    }

            //    if (!int.TryParse(input, out int studentId))
            //    {
            //        MessageBox.Show("Please enter a valid numeric Student ID.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }

            //    Student student = new Student();
            //    controller.SearchStudent(studentId);

            //    if (student.StudentID != 0)
            //    {
            //        tname.Text = student.Name;
            //        taddress.Text = student.Address;
            //        dtp_dob.Value = DateTime.Parse(student.DOB);
            //        tnumber.Text = student.PhoneNumber;
            //        com_course.SelectedValue = student.CourseID;
            //        user_name.SelectedValue = student.UserID;
            //        dgview_students.DataSource = new List<Student> { student };
            //    }
            //    else
            //    {
            //        MessageBox.Show("Student not found.");
            //        dgview_students.DataSource = null;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void dgview_students_SelectionChanged(object sender, EventArgs e)
        {
            try 
            {
                if (dgview_students.SelectedRows.Count > 0)
                {
                    var row = dgview_students.SelectedRows[0];
                    Student student = row.DataBoundItem as Student;
                    if (student != null)
                    {
                        selectedStudentId = student.StudentID;
                        tname.Text = student.Name;
                        taddress.Text = student.Address;
                        dtp_dob.Value = DateTime.Parse(student.DOB);
                        tnumber.Text = student.PhoneNumber;
                        user_name.SelectedValue = student.UserID;
                        com_course.SelectedValue = student.CourseID;
                    }
                    else
                    {
                        ClearForm();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Manage_student_Load(object sender, EventArgs e)
        {
          
        }
    }
}


