using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Services;

namespace UnicomTICManagementSystem.Views
{
    public partial class sign_in : Form
    {
        UserController controller = new UserController();
        //public static int LoggedInUserID;
        public sign_in()
        {
            InitializeComponent();
            log_tpassword.PasswordChar = '*';
        }

        public void ClearInputs()
        {
            log_tname.Clear();
            log_tpassword.Clear();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = log_tname.Text;
            string password = log_tpassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }
            string hashedPassword = HashPassword(password);
     
            User user = controller.UserValidation(username, hashedPassword);
            if (user != null)
            {
                MessageBox.Show("Login Successful!");
                SessionManager.LoggedInUserid = user.UserID;
                //LoggedInUserID = user.UserID;
                this.Hide();
                switch (user.Role)
                {
                    case "Admin":
                        new AdminForm().Show();
                        break;

                    case "Student":
                        new StudentAccessForm1().Show();
                        break;

                    case "Lecturer":
                        new LectureAccessForm().Show();
                        break;

                    case "Staff":
                        new StaffAccessForm().Show();
                        break;

                    default:
                        MessageBox.Show("Role not recognized.");
                        return;
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
                ClearInputs();
            }
        }

        private string HashPassword(string password)
        {
            int hash = password.GetHashCode();
            return hash.ToString();
        }

        
        private void sign_in_Load(object sender, EventArgs e)
        {

        }
    }
}
