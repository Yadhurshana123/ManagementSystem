using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicomTICManagementSystem.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_sign_in_Click(object sender, EventArgs e)
        {
            sign_in signIn = new sign_in();
            LoadForm(signIn);

        }
        public void LoadForm(Form formObj)
        {
            if (this.mainpanal.Controls.Count > 0)
            {
                this.mainpanal.Controls.RemoveAt(0);
            }

            formObj.TopLevel = false;
            formObj.Dock = DockStyle.Fill;
            this.mainpanal.Controls.Add(formObj);
            formObj.Show();
        }

        private void btn_sihn_up_Click(object sender, EventArgs e)
        {
            sign_up signUp = new sign_up();
            LoadForm(signUp);
            
        }
    }
}
