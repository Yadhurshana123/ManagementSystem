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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UnicomTICManagementSystem.Views
{
    public partial class ManageAttendance : Form
    {
        private int selectedAttendanceId = -1;
        public ManageAttendance()
        {
            InitializeComponent();
            LoadAttendanceData();
            LoadTimetableComboBox();
            LoadStudentComboBox();
        }

        private void LoadAttendanceData()
        {
            var controller = new AttendanceController();
            List<Attendance> attendanceList = controller.GetAttendance();
            dgv_attendance.DataSource = attendanceList;
        }

        public void LoadTimetableComboBox()
        {
            TimetableController timetableController = new TimetableController();
            List<Timetable> timetables = timetableController.GetAllTimetables();

            com_timetable.DataSource = timetables;
            com_timetable.DisplayMember = "Date";
            com_timetable.ValueMember = "TimetableID";
        }

        public void LoadStudentComboBox() 
        {
            StudentController studentController = new StudentController();
            List<Student> students = studentController.GetAllStudents();

            com_student.DataSource = students;
            com_student.DisplayMember = "Name";
            com_student.ValueMember = "StudentID";
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (com_timetable.SelectedValue == null || com_student.SelectedValue == null)
                {
                    MessageBox.Show("Please select both Timetable and Student.");
                    return;
                }

                if (!radio_btn_present.Checked && !radio_btn_absent.Checked)
                {
                    MessageBox.Show("Please select a status.");
                    return;
                }


                var attendance = new Attendance
                {
                    StudentID = Convert.ToInt32(com_student.SelectedValue),
                    TimetableID = Convert.ToInt32(com_timetable.SelectedValue),
                    Status = radio_btn_present.Checked ? "Present" :
                                 radio_btn_absent.Checked ? "Absent" : "",
                    Timestamp = dtp_timestamp.Value,
                };

                var controller = new AttendanceController();
                controller.MarkAttendance(attendance);

                MessageBox.Show("Attendance marked successfully!");

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
                AttendanceController controller = new AttendanceController();
                Attendance attendance = new Attendance()
                {
                    AttendanceID = selectedAttendanceId,
                    TimetableID = Convert.ToInt32(com_timetable.SelectedValue),
                    StudentID = Convert.ToInt32(com_student.SelectedValue),
                    Status = radio_btn_present.Checked ? "Present" :
                                 radio_btn_absent.Checked ? "Absent" : "",
                    Timestamp = dtp_timestamp.Value


                };
                controller.UpdateAttendance(attendance);
                MessageBox.Show("Attendance updated successfully!");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
