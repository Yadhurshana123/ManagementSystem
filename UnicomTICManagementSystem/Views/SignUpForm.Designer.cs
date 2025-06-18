namespace UnicomTICManagementSystem.Views
{
    partial class sign_up
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
            this.lusername = new System.Windows.Forms.Label();
            this.lpassword = new System.Windows.Forms.Label();
            this.tusername = new System.Windows.Forms.TextBox();
            this.tpassword = new System.Windows.Forms.TextBox();
            this.lrole = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.cbox_role = new System.Windows.Forms.ComboBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lemail = new System.Windows.Forms.Label();
            this.temail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lusername
            // 
            this.lusername.AutoSize = true;
            this.lusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lusername.Location = new System.Drawing.Point(129, 69);
            this.lusername.Name = "lusername";
            this.lusername.Size = new System.Drawing.Size(80, 18);
            this.lusername.TabIndex = 0;
            this.lusername.Text = "UserName";
            // 
            // lpassword
            // 
            this.lpassword.AutoSize = true;
            this.lpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpassword.Location = new System.Drawing.Point(129, 121);
            this.lpassword.Name = "lpassword";
            this.lpassword.Size = new System.Drawing.Size(75, 18);
            this.lpassword.TabIndex = 1;
            this.lpassword.Text = "Password";
            this.lpassword.Click += new System.EventHandler(this.lpassword_Click);
            // 
            // tusername
            // 
            this.tusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tusername.Location = new System.Drawing.Point(255, 70);
            this.tusername.Name = "tusername";
            this.tusername.Size = new System.Drawing.Size(246, 22);
            this.tusername.TabIndex = 2;
            // 
            // tpassword
            // 
            this.tpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpassword.Location = new System.Drawing.Point(255, 122);
            this.tpassword.Name = "tpassword";
            this.tpassword.Size = new System.Drawing.Size(246, 22);
            this.tpassword.TabIndex = 3;
            // 
            // lrole
            // 
            this.lrole.AutoSize = true;
            this.lrole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lrole.Location = new System.Drawing.Point(129, 230);
            this.lrole.Name = "lrole";
            this.lrole.Size = new System.Drawing.Size(39, 18);
            this.lrole.TabIndex = 4;
            this.lrole.Text = "Role";
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.Location = new System.Drawing.Point(159, 280);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(134, 51);
            this.btn_register.TabIndex = 6;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // cbox_role
            // 
            this.cbox_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_role.FormattingEnabled = true;
            this.cbox_role.Location = new System.Drawing.Point(255, 222);
            this.cbox_role.Name = "cbox_role";
            this.cbox_role.Size = new System.Drawing.Size(246, 24);
            this.cbox_role.TabIndex = 7;
            this.cbox_role.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(388, 280);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(136, 51);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lemail
            // 
            this.lemail.AutoSize = true;
            this.lemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lemail.Location = new System.Drawing.Point(129, 171);
            this.lemail.Name = "lemail";
            this.lemail.Size = new System.Drawing.Size(45, 18);
            this.lemail.TabIndex = 9;
            this.lemail.Text = "Email";
            // 
            // temail
            // 
            this.temail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temail.Location = new System.Drawing.Point(255, 172);
            this.temail.Name = "temail";
            this.temail.Size = new System.Drawing.Size(246, 22);
            this.temail.TabIndex = 10;
            // 
            // sign_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.temail);
            this.Controls.Add(this.lemail);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.cbox_role);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.lrole);
            this.Controls.Add(this.tpassword);
            this.Controls.Add(this.tusername);
            this.Controls.Add(this.lpassword);
            this.Controls.Add(this.lusername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sign_up";
            this.Text = "SignUpForm";
            this.Load += new System.EventHandler(this.SignUpStudents_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lusername;
        private System.Windows.Forms.Label lpassword;
        private System.Windows.Forms.TextBox tusername;
        private System.Windows.Forms.TextBox tpassword;
        private System.Windows.Forms.Label lrole;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.ComboBox cbox_role;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lemail;
        private System.Windows.Forms.TextBox temail;
    }
}