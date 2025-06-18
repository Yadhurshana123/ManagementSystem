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
    public partial class LectureAccessForm : Form
    {
        public LectureAccessForm()
        {
            InitializeComponent();
        }

        public void LoadForm(Form formObj)
        {
            if (this.lecturer_panel.Controls.Count > 0)
            {
                this.lecturer_panel.Controls.RemoveAt(0);
            }

            formObj.TopLevel = false;
            formObj.Dock = DockStyle.Fill;
            this.lecturer_panel.Controls.Add(formObj);
            formObj.Show();
        }
        private void btn_lec_details_Click(object sender, EventArgs e)
        {

        }

        private void btn_lec_timetable_Click(object sender, EventArgs e)
        {
            Manage_timetable managetimetable = new Manage_timetable();
            managetimetable.HideAllControlsExceptDataGridView();
            LoadForm(managetimetable);
        }

        private void btn_lec_shedule_Click(object sender, EventArgs e)
        {
            ManageMarks manageMarks = new ManageMarks();
            LoadForm(manageMarks);
        }

        private void btn_lec_exams_Click(object sender, EventArgs e)
        {
            ManageExams manageExams = new ManageExams();
            manageExams.HideAllControlsExceptDataGridView();
            LoadForm(manageExams);
        }

        private void btn_lec_course_Click(object sender, EventArgs e)
        {
            Manage_Courses manageCourses = new Manage_Courses();
            manageCourses.HideAllControlsExceptDataGridView();
            LoadForm(manageCourses);
        }
    }
}
