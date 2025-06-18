namespace UnicomTICManagementSystem.Views
{
    partial class sign_in
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.log_username = new System.Windows.Forms.Label();
            this.log_password = new System.Windows.Forms.Label();
            this.log_tname = new System.Windows.Forms.TextBox();
            this.log_tpassword = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // log_username
            // 
            this.log_username.AutoSize = true;
            this.log_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_username.Location = new System.Drawing.Point(117, 64);
            this.log_username.Name = "log_username";
            this.log_username.Size = new System.Drawing.Size(77, 18);
            this.log_username.TabIndex = 0;
            this.log_username.Text = "Username";
            // 
            // log_password
            // 
            this.log_password.AutoSize = true;
            this.log_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_password.Location = new System.Drawing.Point(119, 122);
            this.log_password.Name = "log_password";
            this.log_password.Size = new System.Drawing.Size(75, 18);
            this.log_password.TabIndex = 1;
            this.log_password.Text = "Password";
            // 
            // log_tname
            // 
            this.log_tname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_tname.Location = new System.Drawing.Point(232, 65);
            this.log_tname.Name = "log_tname";
            this.log_tname.Size = new System.Drawing.Size(243, 22);
            this.log_tname.TabIndex = 2;
            // 
            // log_tpassword
            // 
            this.log_tpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_tpassword.Location = new System.Drawing.Point(232, 123);
            this.log_tpassword.Name = "log_tpassword";
            this.log_tpassword.Size = new System.Drawing.Size(243, 22);
            this.log_tpassword.TabIndex = 3;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(161, 200);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(113, 50);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(364, 200);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(111, 50);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // sign_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.log_tpassword);
            this.Controls.Add(this.log_tname);
            this.Controls.Add(this.log_password);
            this.Controls.Add(this.log_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sign_in";
            this.Text = "SignInForm";
            this.Load += new System.EventHandler(this.sign_in_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label log_username;
        private System.Windows.Forms.Label log_password;
        private System.Windows.Forms.TextBox log_tname;
        private System.Windows.Forms.TextBox log_tpassword;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_cancel;
    }
}