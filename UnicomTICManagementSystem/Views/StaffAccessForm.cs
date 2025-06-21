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
using UnicomTICManagementSystem.Services;

namespace UnicomTICManagementSystem.Views
{
    public partial class StaffAccessForm : Form
    {
        public StaffAccessForm()
        {
            InitializeComponent();
        }

        private void btn_lec_details_Click(object sender, EventArgs e)
        {
            
        }

        public void LoadForm(Form formObj)
        {
            if (this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }

            formObj.TopLevel = false;
            formObj.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(formObj);
            formObj.Show();
        }
        private void btn_staff_timetable_Click(object sender, EventArgs e)
        {
            Manage_timetable manage_timetable = new Manage_timetable();
            manage_timetable.HideAllControlsExceptDataGridView();
            LoadForm(manage_timetable);
        }

        private void btn_staff_shedule_Click(object sender, EventArgs e)
        {
            ManageMarks manageMarks = new ManageMarks();
            LoadForm(manageMarks);
        }

        private void btn_staff_exams_Click(object sender, EventArgs e)
        {
            ManageExams manageExams = new ManageExams();
            manageExams.HideAllControlsExceptDataGridView();
            LoadForm(manageExams);
        }

        private void btn_staff_course_Click(object sender, EventArgs e)
        {
            Manage_Courses manageCourses = new Manage_Courses();
            manageCourses.HideAllControlsExceptDataGridView();
            LoadForm(manageCourses);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StaffAccessForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_staff_details_Click(object sender, EventArgs e)
        {
            int userId = SessionManager.LoggedInUserId;
            UserController userController = new UserController();
            User user = userController.GetUserByUserId(userId);

            StaffController staffcontroller = new StaffController();
            Staff staff = staffcontroller.GetStaffByUserID(userId);

            if (user != null)
            {
                DetailsForm detailForm = new DetailsForm(user, null, null, staff);
                LoadForm(detailForm);
            }
            else
            {
                MessageBox.Show("User not found.");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginform = new LoginForm();
            loginform.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
