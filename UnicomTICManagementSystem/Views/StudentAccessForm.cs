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
using UnicomTICManagementSystem.Datas;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Services;

namespace UnicomTICManagementSystem.Views
{
    public partial class StudentAccessForm1 : Form
    {
        public static int LoggedInUserID;
        public StudentAccessForm1()
        {
            InitializeComponent();
        }

        public void LoadForm(Form formObj)
        {
            if (this.student_panel.Controls.Count > 0)
            {
                this.student_panel.Controls.RemoveAt(0);
            }

            formObj.TopLevel = false;
            formObj.Dock = DockStyle.Fill;
            this.student_panel.Controls.Add(formObj);
            formObj.Show();
        }

        private void btn_st_details_Click(object sender, EventArgs e)
        {
            int userId = SessionManager.LoggedInUserId;
            UserController userController = new UserController();
            User user = userController.GetUserByUserId(userId);

            StudentController studentController = new StudentController();
            Student student = studentController.GetStudentByUserId(userId);

            if (user != null)
            {
                DetailsForm detailForm = new DetailsForm(user, student, null, null);
                LoadForm(detailForm);
            }
            else
            {
                MessageBox.Show("User not found.");
            }
        }

        private void btn_st_timetable_Click(object sender, EventArgs e)
        {
            Manage_timetable form = new Manage_timetable();
            form.HideAllControlsExceptDataGridView();
            LoadForm(form);


        }

        private void btn_st_exams_Click(object sender, EventArgs e)
        {
            ManageExams manageExams = new ManageExams();
            manageExams.HideAllControlsExceptDataGridView();
            LoadForm(manageExams);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            

        }

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }

        private void btn_previous_Click_1(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    } 
}