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
    public partial class ManageExams : Form
    {
        ExamController examController = new ExamController();
        ModuleController moduleController = new ModuleController(); 
        Roomcontroller roomController = new Roomcontroller();
        private int selectedExamId = -1;
        public ManageExams()
        {
            InitializeComponent();
            LoadExams();
            LoadModules();
            LoadRooms();
        }

        public void LoadModules()
        {
            var modules = moduleController.GetAllModules(); 
            com_module_name.DataSource = modules;
            com_module_name.DisplayMember = "ModuleName";
            com_module_name.ValueMember = "ModuleID";
        }

        public void LoadRooms()
        {
            var rooms = roomController.GetAllRooms();
            com_room_name.DataSource = rooms;
            com_room_name.DisplayMember = "RoomName";
            com_room_name.ValueMember = "RoomID";
        }

        public void LoadExams()
        {
            dgview_exam.DataSource = examController.GetAllExams();
        }

        public void ClearForm()
        {
            texam_name.Clear();
            com_module_name.SelectedIndex = -1;
            com_room_name.SelectedIndex = -1;
            dtp_date.Value = DateTime.Today;
            dtp_st_time.Value = DateTime.Now;
            dtp_end_time.Value = DateTime.Now;
            selectedExamId = -1;
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
                if (string.IsNullOrWhiteSpace(texam_name.Text))
                {
                    MessageBox.Show("Please enter all requirements");
                    return;
                }

                if (dtp_end_time.Value <= dtp_st_time.Value)
                {
                    MessageBox.Show("End time must be after start time.");
                    return;
                }
                var exam = new Exam
                {
                    ExamName = texam_name.Text.Trim(),
                    ModuleID = (int)com_module_name.SelectedValue,
                    RoomID = (int)com_room_name.SelectedValue,
                    Date = dtp_date.Value.Date, 
                    StartTime = dtp_st_time.Value.TimeOfDay,
                    EndTime = dtp_end_time.Value.TimeOfDay
                };

                examController.AddExam(exam);
                LoadExams();
                MessageBox.Show("Exam added successfully!");      
                ClearForm();
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
                if (selectedExamId == -1)
                {
                    MessageBox.Show("Please select an exam to edit.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(texam_name.Text))
                {
                    MessageBox.Show("Please enter all requirements");
                    return;
                }

                if (dtp_end_time.Value <= dtp_st_time.Value)
                {
                    MessageBox.Show("End time must be after start time.");
                    return;
                }

                var exam = new Exam
                {
                    ExamID = selectedExamId,
                    ExamName = texam_name.Text.Trim(),
                    ModuleID = (int)com_module_name.SelectedValue,
                    RoomID = (int)com_room_name.SelectedValue,
                    Date = dtp_date.Value.Date, 
                    StartTime = dtp_st_time.Value.TimeOfDay,
                    EndTime = dtp_end_time.Value.TimeOfDay
                };

                examController.UpdateExam(exam);
                MessageBox.Show("Exam edited successfully!");
                LoadExams();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (selectedExamId == -1)
            {
                MessageBox.Show("Please select an exam to delete.");
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this exam?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                examController.DeleteExam(selectedExamId);
                MessageBox.Show("Exam deleted successfully!");
                LoadExams();
                ClearForm();
            }
        }

        private void dgview_exam_SelectionChanged(object sender, EventArgs e)
        {
            if (dgview_exam.SelectedRows.Count > 0)
            {
                var exam = dgview_exam.SelectedRows[0].DataBoundItem as Exam;
                if (exam != null)
                {
                    selectedExamId = exam.ExamID;
                    texam_name.Text = exam.ExamName;
                    com_module_name.SelectedValue = exam.ModuleID;
                    com_room_name.SelectedValue = exam.RoomID;
                    dtp_date.Value = exam.Date; 
                    dtp_st_time.Value = DateTime.Today.Add(exam.StartTime);
                    dtp_end_time.Value = DateTime.Today.Add(exam.EndTime);
                }
            }
        }
    }
}
