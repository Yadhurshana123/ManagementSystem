using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Datas;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Services;

namespace UnicomTICManagementSystem.Views
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            timerCheck.Start();
            //LoadPendingUsers();
        }

        public void LoadForm(Form formObj)
        {
            if (this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);
            }

            formObj.TopLevel = false;
            formObj.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(formObj);
            formObj.Show();
        }
        /*public void LoadPendingUsers()
        {
            UserController controller = new UserController();
            controller.GetAllPendingUsers();
        }*/

        private void timerCheck_Tick(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_manage_student_Click(object sender, EventArgs e)
        {
            Manage_student studentForm = new Manage_student();
            LoadForm(studentForm);
        }

        private void btn_manage_lecture_Click(object sender, EventArgs e)
        {
            Manage_lecturer lectureform = new Manage_lecturer();
            LoadForm(lectureform);
        }

        private void btn_manage_staff_Click(object sender, EventArgs e)
        {
            Manage_staff staffform = new Manage_staff();
            LoadForm(staffform);
        }

        private void btn_manage_timetable_Click(object sender, EventArgs e)
        {
            Manage_timetable timetableform = new Manage_timetable();
            LoadForm(timetableform);
        }

        private void btn_manage_course_Click(object sender, EventArgs e)
        {
            Manage_Courses courseform = new Manage_Courses();
            LoadForm(courseform);
        }

        private void btn_manage_exam_Click(object sender, EventArgs e)
        {
            ManageExams examsform = new ManageExams();
            LoadForm(examsform);
        }

        private void btn_manage_attendance_Click(object sender, EventArgs e)
        {
            ManageAttendance manageAttendance = new ManageAttendance();
            LoadForm(manageAttendance);
        }

        private void btn_marks_Click(object sender, EventArgs e)
        {
            ManageMarks marksform = new ManageMarks();
            marksform.HideAllControlsExceptDataGridView();
            LoadForm(marksform);
        }

        private void btn_manage_module_Click(object sender, EventArgs e)
        {
            Manage_Modules modulesform = new Manage_Modules();
            LoadForm(modulesform);
        }

        private void btn_manage_rooms_Click(object sender, EventArgs e)
        {
            ManageRooms roomsform = new ManageRooms();
            LoadForm(roomsform);
        }

        private void btn_admin_details_Click(object sender, EventArgs e)
        {
           
        }

        private void timerCheck_Tick_1(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM PendingUsers";
                using (var conn = DBConfig.GetConnection())
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["UserID"]);
                        string name = reader["Username"].ToString(); 
                        string email = reader["Email"].ToString();
                        string password = reader["Password"].ToString();
                        string role = reader["Role"].ToString();

                        reader.Close();

                        DialogResult result = MessageBox.Show(
                            $"Approve new user?\n\nName: {name}\nRole: {role}",
                            "Approval Needed",
                            MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            string movequery = "INSERT INTO Users (Username, Email, Password, Role) VALUES (@Username, @Email, @Password, @Role)";
                            using (var con = DBConfig.GetConnection())
                            using (var Cmd = new SQLiteCommand(movequery, con))
                            {
                                Cmd.Parameters.AddWithValue("@Username", name);
                                Cmd.Parameters.AddWithValue("@Email", email);
                                Cmd.Parameters.AddWithValue("@Password", password);
                                Cmd.Parameters.AddWithValue("@Role", role);
                                Cmd.ExecuteNonQuery();
                            }

                            string deletequery = "DELETE FROM PendingUsers WHERE UserID = @Id";
                            using (var con = DBConfig.GetConnection())
                            using (var Cmd = new SQLiteCommand(deletequery, con))
                            {
                                Cmd.Parameters.AddWithValue("@Id", id);
                                Cmd.ExecuteNonQuery();
                            }
                            MessageBox.Show("User registration successfully.");
                        }
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_details_Click(object sender, EventArgs e)
        {
            int userId = SessionManager.LoggedInUserId;
            UserController userController = new UserController();
            User user = userController.GetUserByUserId(userId);

            if (user != null)
            {
                DetailsForm detailForm = new DetailsForm(user, null, null, null);
                LoadForm(detailForm);
            }
            else
            {
                MessageBox.Show("User not found.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
