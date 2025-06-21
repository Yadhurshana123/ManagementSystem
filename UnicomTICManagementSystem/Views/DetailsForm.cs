using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Datas;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Views;

namespace UnicomTICManagementSystem.Views
{

    public partial class DetailsForm : Form
    {
        private User _user;
        private Student _student;
        private Lecturer _lecturer;
        private Staff _staff;

        public DetailsForm(User user, Student student, Lecturer lecturer, Staff staff)
        {
            InitializeComponent();
            _user = user;
            _student = student;
            _lecturer = lecturer;
            _staff = staff;
            DisplayDetails();
            Updatedetails();
        }

        public void Updatedetails()
        {
            foreach (DataGridViewRow row in dg_details.Rows)
            {
                string field = row.Cells[0].Value?.ToString();

                bool isEditable = field == "Username" || field == "Password";

                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.ReadOnly = !isEditable;
                    cell.Style.BackColor = isEditable ? Color.White : Color.LightGray;
                }
            }
        }


        public void DisplayDetails() 
        {
            dg_details.Rows.Clear();
            dg_details.Rows.Add("UserID", _user.UserID);
            dg_details.Rows.Add("Username", _user.Username);
            dg_details.Rows.Add("Password", _user.Password);
            dg_details.Rows.Add("Role", _user.Role);


            if (_user.Role == "Student")
            {
                if (_student != null)
                {
                    dg_details.Rows.Add("Name", _student.Name);
                    dg_details.Rows.Add("DOB", _student.DOB);
                    dg_details.Rows.Add("Phone", _student.PhoneNumber);
                    dg_details.Rows.Add("Course", _student.CourseName);
                }
                else
                {
                    MessageBox.Show("Student details not found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (_user.Role == "Lecturer") 
            {
                if (_lecturer != null) 
                {
                    dg_details.Rows.Add("Name", _lecturer.Name);
                    dg_details.Rows.Add("Phone", _lecturer.PhoneNumber);
                    dg_details.Rows.Add("Address", _lecturer.Address);
                    dg_details.Rows.Add("Email", _lecturer.Email);
                }

                else
                {
                    MessageBox.Show("Lecture details not found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (_user.Role == "Staff")
            {
                if (_staff != null)
                {
                    dg_details.Rows.Add("Name", _staff.Name);
                    dg_details.Rows.Add("Phone", _staff.PhoneNumber);
                    dg_details.Rows.Add("Address", _staff.Address);
                    dg_details.Rows.Add("Email", _staff.Email);
                }

                else
                {
                    MessageBox.Show("Staff details not found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

       

        private void btn_update_password_Click(object sender, EventArgs e)
        {
            string updatedUsername = null;
            string updatedPassword = null;

            foreach (DataGridViewRow row in dg_details.Rows)
            {
                string field = row.Cells[0].Value?.ToString();
                string value = row.Cells[1].Value?.ToString();

                if (field == "Username")
                    updatedUsername = value;

                if (field == "Password")
                    updatedPassword = value;
            }

            if (!string.IsNullOrWhiteSpace(updatedUsername) && !string.IsNullOrWhiteSpace(updatedPassword))
            {
                string hashedPassword = HashPassword(updatedPassword);

                using (var conn = DBConfig.GetConnection())
                {
                    string query = "UPDATE Users SET Username = @username, Password = @password WHERE UserID = @userId";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", updatedUsername);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);
                        cmd.Parameters.AddWithValue("@userId", _user.UserID);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User details updated successfully!");
                            _user.Username = updatedUsername;
                            _user.Password = hashedPassword;
                        }
                        else
                        {
                            MessageBox.Show("Update failed. No rows affected.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Username or Password is empty.");
            }

        }

        private string HashPassword(string password)
        {
            int hash = password.GetHashCode();
            return hash.ToString();
        }
    }
}