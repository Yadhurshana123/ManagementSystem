using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (this.staff_panel.Controls.Count > 0)
            {
                this.staff_panel.Controls.RemoveAt(0);
            }

            formObj.TopLevel = false;
            formObj.Dock = DockStyle.Fill;
            this.staff_panel.Controls.Add(formObj);
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
    }
}
