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
    public partial class Manage_staff : Form
    {
        private int selectedStaffId = -1;
        StaffController controller = new StaffController();

        public Manage_staff()
        {
            InitializeComponent();
            LoadStaffs();
            LoadUserCombobox();

        }
        public void LoadUserCombobox()
        {
            UserController userController = new UserController();
            List<User> users = userController.GetAllUsers();

            username.DataSource = users;
            username.DisplayMember = "Username";
            username.ValueMember = "UserID";
        }
            public void LoadStaffs()
        {
            var list = controller.GetAllStaffs();
            dgview_staffs.DataSource = list;
        }

        private void ClearForm()
        {
            tname.Clear();
            taddress.Clear();
            tnumber.Clear();
            temail.Clear();
            tsearch.Clear();
            selectedStaffId = -1;
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

                if (string.IsNullOrWhiteSpace(username.SelectedItem?.ToString()))
                {
                    MessageBox.Show("Please select a Username.");
                    return;
                }

                var staff = new Staff
                {
                    Name = tname.Text,
                    Address = taddress.Text,
                    Email = temail.Text,
                    PhoneNumber = tnumber.Text,
                    UserID = (int)username.SelectedValue,
                };

                controller.AddStaff(staff);
                MessageBox.Show("Staff added successfully!");
                LoadStaffs();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding staff: " + ex.Message);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedStaffId == -1)
                {
                    MessageBox.Show("Please select a staff to update.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(tname.Text) || string.IsNullOrWhiteSpace(taddress.Text) || string.IsNullOrWhiteSpace(tnumber.Text) || string.IsNullOrWhiteSpace(temail.Text))
                {
                    MessageBox.Show("Please enter all requirnments.");
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

                var staff = new Staff
                {
                    StaffID = selectedStaffId,
                    Name = tname.Text,
                    Address = taddress.Text,
                    Email = temail.Text,
                    PhoneNumber = tnumber.Text,
                    UserID = (int)username.SelectedValue,
                };

                controller.UpdateStaff(staff);
                MessageBox.Show("Staff edited successfully!");
                LoadStaffs();
                ClearForm();
                selectedStaffId = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error edited staffs: " + ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (selectedStaffId == -1)
            {
                MessageBox.Show("Please select a staff to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this staff?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                controller.DeleteStaff(selectedStaffId);
                MessageBox.Show("staff Deleted Successfully");
                LoadStaffs();
                ClearForm();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            
            //    try
            //    {
            //        string input = tsearch.Text.Trim();
            //        if (string.IsNullOrEmpty(input))
            //        {
            //            LoadStaffs();
            //            return;
            //        }

            //        if (!int.TryParse(input, out int staffId))
            //        {
            //            MessageBox.Show("Please enter a valid numeric StaffID ID.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            return;
            //        }

            //        Staff staff = new Staff();
            //        controller.SearchStaff(staffId, staff);

            //        if (staff.StaffID != 0)
            //        {
            //            tname.Text = staff.Name;
            //            taddress.Text = staff.Address;
            //            temail.Text = staff.Email;
            //            tnumber.Text = staff.PhoneNumber;
            //            username.SelectedValue = staff.UserID;
            //            dgview_staffs.DataSource = new List<Staff> { staff };
            //        }
            //        else
            //        {
            //            MessageBox.Show("Staff not found.");
            //            dgview_staffs.DataSource = null;
            //            ClearForm();
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
        }

        private void dgview_staffs_SelectionChanged(object sender, EventArgs e)
        {
            if (dgview_staffs.SelectedRows.Count > 0)
            {
                var row = dgview_staffs.SelectedRows[0];
                Staff staff = row.DataBoundItem as Staff;
                if (staff != null)
                {
                    selectedStaffId = staff.StaffID;
                    tname.Text = staff.Name;
                    taddress.Text = staff.Address;
                    temail.Text = staff.Email;
                    tnumber.Text = staff.PhoneNumber;
                    username.SelectedValue = staff.UserID;
                }
                else
                {
                    ClearForm();
                }
            }
        }

        private void lname_Click(object sender, EventArgs e)
        {

        }

        private void tsearch_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tsearch.Text, out int id))
            {
                StaffController controller = new StaffController();
                Staff result = controller.SearchStaff(id);

                if (result != null)
                {
                    dgview_staffs.DataSource = new List<Staff> { result };
                }

                else
                {
                    MessageBox.Show("Staff not found!");
                    ClearForm();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Staff ID");
            }
        }
    }
}


