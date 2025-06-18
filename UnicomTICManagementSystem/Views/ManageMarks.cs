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
        public void LoadMarks() 
        {
            var list = markController.GetAllMarks();
            dgv_result.DataSource = list;
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
                    //StudentID = int.Parse(txtStudentID.Text),
                    //ExamID = int.Parse(txtExamID.Text),
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
                    //txtStudentID.Text = mark.StudentID.ToString();
                    //txtExamID.Text = mark.ExamID.ToString();
                    tscore.Text = mark.Score.ToString();
                    tresult.Text = mark.Results;
                }
            }
        }
    }
    
}
