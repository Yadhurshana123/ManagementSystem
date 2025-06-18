using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Views
{
    public partial class Manage_Courses : Form
    {
        CourseController controller = new CourseController();
        private int selectedCourseId = -1;

        public Manage_Courses()
        {
            InitializeComponent();
            LoadCourses();
        }

        public void LoadCourses()
        {
            var list = controller.GetAllCourses();
            dgview_course.DataSource = list;
        }

        private void ClearInputs()
        {
            tcourse.Text = "";
        }
        private void Manage_Courses_Load(object sender, EventArgs e)
        {

        }

        public void HideAllControlsExceptDataGridView()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (!(ctrl is DataGridView))
                {
                    ctrl.Visible = false;
                }
                else
                {
                    ctrl.Visible = true;
                    //ctrl.Dock = DockStyle.Fill; 
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tcourse.Text))
                {
                    MessageBox.Show("Please enter course name");
                    return;
                }
                var course = new Course
                {
                    CourseName = tcourse.Text,
                };

                controller.AddCourse(course);
                MessageBox.Show("Course added successfully!");
                LoadCourses();
                ClearInputs();
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
                if (selectedCourseId == -1)
                {
                    MessageBox.Show("Please select a course to edit.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(tcourse.Text))
                {
                    MessageBox.Show("Please enter course name.");
                    return;
                }
                var course = new Course
                {
                    CourseID = selectedCourseId,
                    CourseName = tcourse.Text,
                };
                controller.UpdateCourse(course);
                MessageBox.Show("Course edited successfully!");
                LoadCourses();
                ClearInputs();
                selectedCourseId = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (selectedCourseId == -1)
            {
                MessageBox.Show("Please select a course to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this course?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                controller.DeleteCourse(selectedCourseId);
                MessageBox.Show("Course Deleted Successfully");
                LoadCourses();
                ClearInputs();
            }
        }
  
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (int.TryParse(t_search.Text, out int id))
            {
                CourseController controller = new CourseController();
                Course result = controller.SearchCourse(id);

                if (result != null)
                {
                    dgview_course.DataSource = new List<Course> { result };
                }

                else
                {
                    MessageBox.Show("Course not found!");
                    ClearInputs();
                }
            }
        }

        private void dgview_course_SelectionChanged(object sender, EventArgs e)
        {
            if (dgview_course.SelectedRows.Count > 0)
            {
                var row = dgview_course.SelectedRows[0];
                Course course = row.DataBoundItem as Course;
                if (course != null)
                {
                    selectedCourseId = course.CourseID;
                    tcourse.Text = course.CourseName;
                }
                else
                {
                    ClearInputs();
                }
            }
        }
    }
}

