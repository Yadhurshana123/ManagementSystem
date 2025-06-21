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
    public partial class Manage_lecturer : Form
    {
        private int selectedLectureId = -1;
        LectureController controller = new LectureController();

        public Manage_lecturer()
        {
            InitializeComponent();
            LoadLectures();
            LoadUserCombobox();
        }

        public void LoadUserCombobox()
        {
            UserController userController = new UserController();
            List<User> users = userController.GetAllUsers();

            user_name.DataSource = users;
            user_name.DisplayMember = "Username";
            user_name.ValueMember = "UserID";
        }
        public void LoadLectures()
        {
            var list = controller.GetAllLectures();
            dgview_lectures.DataSource = list;
        }

        private void ClearForm()
        {
            tname.Clear();
            taddress.Clear();
            tnumber.Clear();
            temail.Clear();
            tsearch.Clear();
            selectedLectureId = -1;
            user_name.SelectedIndex = -1;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tname.Text) ||
                   string.IsNullOrWhiteSpace(taddress.Text) ||
                   string.IsNullOrWhiteSpace(tnumber.Text) ||
                   string.IsNullOrWhiteSpace(temail.Text))
                {
                    MessageBox.Show("Please enter all required fields.");
                    return;
                }

                if (!temail.Text.Contains("@") || !temail.Text.Contains("."))
                {
                    MessageBox.Show("Enter a valid email address.");
                    return;
                }

                if (tnumber.Text.Length < 10)
                {
                    MessageBox.Show("Enter a valid phone number.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(user_name.SelectedItem?.ToString()))
                {
                    MessageBox.Show("Please select a Username.");
                    return;
                }

                var lecture = new Lecturer
                {
                    Name = tname.Text,
                    Address = taddress.Text,
                    Email = temail.Text,
                    PhoneNumber = tnumber.Text,
                    UserID = (int)user_name.SelectedValue,
                };

                controller.AddLecture(lecture);
                MessageBox.Show("Lecture added successfully!");
                LoadLectures();
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
                if (selectedLectureId == -1)
                {
                    MessageBox.Show("Please select a lecture to edit.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(tname.Text) || string.IsNullOrWhiteSpace(taddress.Text) || string.IsNullOrWhiteSpace(tnumber.Text) || string.IsNullOrWhiteSpace(temail.Text))
                {
                    MessageBox.Show("Please enter all reqirnments.");
                    return;
                }

                if (!temail.Text.Contains("@") || !temail.Text.Contains("."))
                {
                    MessageBox.Show("Enter a valid email address.");
                    return;
                }

                if (tnumber.Text.Length < 10)
                {
                    MessageBox.Show("Enter a valid phone number.");
                    return;
                }

                var lecture = new Lecturer
                {
                    LectureID = selectedLectureId,
                    Name = tname.Text,
                    Address = taddress.Text,
                    Email = temail.Text,
                    PhoneNumber = tnumber.Text,
                    UserID = (int)user_name.SelectedValue,
                };

                controller.UpdateLecture(lecture);
                MessageBox.Show("Lecture edited successfully!");
                LoadLectures();
                ClearForm();
                selectedLectureId = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error editing lecrures: " + ex.Message);
            }
        }

        private void dgview_lectures_SelectionChanged(object sender, EventArgs e)
        {
            if (dgview_lectures.SelectedRows.Count > 0)
            {
                var row = dgview_lectures.SelectedRows[0];
                Lecturer lecturer = row.DataBoundItem as Lecturer;
                if (lecturer != null)
                {
                    selectedLectureId = lecturer.LectureID;
                    tname.Text = lecturer.Name;
                    taddress.Text = lecturer.Address;
                    temail.Text = lecturer.Email;
                    tnumber.Text = lecturer.PhoneNumber;
                    user_name.SelectedValue = lecturer.UserID;
                }
                else
                {
                    ClearForm();
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (selectedLectureId == -1)
            {
                MessageBox.Show("Please select a lecture to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this lecture?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                controller.DeleteLecture(selectedLectureId);
                MessageBox.Show("Lecture Deleted Successfully");
                LoadLectures();
                ClearForm();
            }
        }

        //==== Search lecturer =====
        private void button2_click(object sender, EventArgs e)
        {

        }

        private void tsearch_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tsearch.Text, out int id))
            {
                LectureController controller = new LectureController();
                Lecturer result = controller.SearchLecturer(id);

                if (result != null)
                {
                    dgview_lectures.DataSource = new List<Lecturer> { result };
                }

                else
                {
                    MessageBox.Show("Lecturer not found!");
                    ClearForm();
                    LoadLectures();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Student ID");
                LoadLectures();
            }
        }

        private void dgview_lectures_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
