using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UnicomTICManagementSystem.Views
{
    public partial class sign_up : Form
    {
        public sign_up()
        {
            InitializeComponent();
        }

        private void lpassword_Click(object sender, EventArgs e)
        {

        }

        private void SignUpStudents_Load(object sender, EventArgs e)
        {
            cbox_role.Items.Add("Student");
            cbox_role.Items.Add("Lecturer");
            cbox_role.Items.Add("Staff");
            cbox_role.Items.Add("Admin");
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string username = tusername.Text; 
            string password = tpassword.Text;
            string email = temail.Text;
            string role = cbox_role.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (password.Length < 8)
            {
                MessageBox.Show("Your password must be at least 8 characters long");
            }

            if (!Regex.IsMatch(password, @"[@#!$*&^]"))
            {
                MessageBox.Show("Your password must include at least one special character (@, #, !, $, *, &, ^).");
                return;
            }

            if (!temail.Text.Contains("@") && !temail.Text.Contains("."))
            {
                MessageBox.Show("Enter a valid email address.");
                return;
            }

            else
            {
                string hashedPassword = HashPassword(password);           
                User user = new User()
                {
                    Username = username,
                    Password = hashedPassword,  
                    Email = email,
                    Role = role 
                };
                UserController userControl = new UserController();
                userControl.AddUser(user);
                MessageBox.Show("Registration Successful!");
                ClearInputs();
            }    
        }

        public void ClearInputs() 
        {
            tusername.Clear();
            tpassword.Clear();
            temail.Clear();
            cbox_role.SelectedIndex = -1;
        }

        private string HashPassword(string password)
        {
            int hash = password.GetHashCode();
            return hash.ToString();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
