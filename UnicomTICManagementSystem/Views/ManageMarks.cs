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
    public partial class ManageMarks : Form
    {
        private int selectedMarkId = -1;
        MarkController markController = new MarkController();

        public ManageMarks()
        {
            InitializeComponent();
            LoadStudentCombo();
            LoadModulesCombo();
            LoadMarks();
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
                }
            }
        }
        public void LoadMarks() 
        {
            var list = markController.GetAllMarks();
            dgv_result.DataSource = list;
        }

        public void LoadStudentCombo() 
        {
            StudentController studentController = new StudentController();
            List<Student> students = studentController.GetAllStudents();
            com_students.DataSource = students;
            com_students.DisplayMember = "Name";
            com_students.ValueMember = "StudentID";
        }

        public void LoadModulesCombo() 
        {
            ExamController examController = new ExamController();   
            var exams = examController.GetAllExams();
            com_exam.DataSource = exams;
            com_exam.DisplayMember = "ExamName";
            com_exam.ValueMember = "ExamID";
        }

        public void ClearInputs() 
        {
            tscore.Clear();
            tresult.Clear();
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tscore.Text) ||
                    string.IsNullOrWhiteSpace(tresult.Text))
                {
                    MessageBox.Show("Fill all fields.");
                    return;
                }

                var mark = new Mark
                {
                    Score = int.Parse(tscore.Text),
                    ExamID = (int)com_exam.SelectedValue,
                    StudentID = (int)com_students.SelectedValue,
                    Results = tresult.Text
                };

                markController.AddMark(mark);
                MessageBox.Show("Mark added successfully!");
                LoadMarks();
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
                if (selectedMarkId == -1)
                {
                    MessageBox.Show("Please select a mark to edit.");
                    return;
                }

                var mark = new Mark
                {
                    MarkID = selectedMarkId,
                    ExamID = (int)com_exam.SelectedValue,
                    StudentID = (int)com_students.SelectedValue,
                    Score = int.Parse(tscore.Text),
                    Results = tresult.Text
                };

                markController.UpdateMark(mark);
                MessageBox.Show("Mark updated successfully!");
                LoadMarks();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_result_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_result.SelectedRows.Count > 0)
            {
                var row = dgv_result.SelectedRows[0];
                Mark mark = row.DataBoundItem as Mark;

                if (mark != null)
                {
                    selectedMarkId = mark.MarkID;
                    com_students.SelectedValue = mark.StudentID;
                    com_exam.SelectedValue = mark.ExamID;
                    tscore.Text = mark.Score.ToString();
                    tresult.Text = mark.Results;
                }
            }
        }

        private void lbl_module_Click(object sender, EventArgs e)
        {

        }
    }
    
}
