using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Views
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();          
        }

        public void LoadForm(Form formObj)
        {
            if (this.mainpanel1.Controls.Count > 0)
            {
                this.mainpanel1.Controls.RemoveAt(0);
            }

            formObj.TopLevel = false;
            formObj.Dock = DockStyle.Fill;
            this.mainpanel1.Controls.Add(formObj);
            formObj.Show();
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
    }
}
