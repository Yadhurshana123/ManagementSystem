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
    } 
}
