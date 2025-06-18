namespace UnicomTICManagementSystem.Views
{
    partial class Manage_student
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tsearch = new System.Windows.Forms.TextBox();
            this.ldob = new System.Windows.Forms.Label();
            this.tnumber = new System.Windows.Forms.TextBox();
            this.lphonenumber = new System.Windows.Forms.Label();
            this.laddress = new System.Windows.Forms.Label();
            this.taddress = new System.Windows.Forms.TextBox();
            this.tname = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dgview_students = new System.Windows.Forms.DataGridView();
            this.lcourse = new System.Windows.Forms.Label();
            this.com_course = new System.Windows.Forms.ComboBox();
            this.user_name = new System.Windows.Forms.ComboBox();
            this.username = new System.Windows.Forms.Label();
            this.dtp_dob = new System.Windows.Forms.DateTimePicker();
            this.lsearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_students)).BeginInit();
            this.SuspendLayout();
            // 
            // tsearch
            // 
            this.tsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsearch.Location = new System.Drawing.Point(311, 271);
            this.tsearch.Name = "tsearch";
            this.tsearch.Size = new System.Drawing.Size(251, 22);
            this.tsearch.TabIndex = 59;
            // 
            // ldob
            // 
            this.ldob.AutoSize = true;
            this.ldob.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldob.Location = new System.Drawing.Point(169, 188);
            this.ldob.Name = "ldob";
            this.ldob.Size = new System.Drawing.Size(93, 18);
            this.ldob.TabIndex = 57;
            this.ldob.Text = "Data Of Birth";
            // 
            // tnumber
            // 
            this.tnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnumber.Location = new System.Drawing.Point(311, 145);
            this.tnumber.Name = "tnumber";
            this.tnumber.Size = new System.Drawing.Size(251, 22);
            this.tnumber.TabIndex = 56;
            // 
            // lphonenumber
            // 
            this.lphonenumber.AutoSize = true;
            this.lphonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lphonenumber.Location = new System.Drawing.Point(168, 149);
            this.lphonenumber.Name = "lphonenumber";
            this.lphonenumber.Size = new System.Drawing.Size(108, 18);
            this.lphonenumber.TabIndex = 55;
            this.lphonenumber.Text = "Phone Number";
            // 
            // laddress
            // 
            this.laddress.AutoSize = true;
            this.laddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laddress.Location = new System.Drawing.Point(169, 112);
            this.laddress.Name = "laddress";
            this.laddress.Size = new System.Drawing.Size(62, 18);
            this.laddress.TabIndex = 54;
            this.laddress.Text = "Address";
            // 
            // taddress
            // 
            this.taddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taddress.Location = new System.Drawing.Point(311, 108);
            this.taddress.Name = "taddress";
            this.taddress.Size = new System.Drawing.Size(251, 22);
            this.taddress.TabIndex = 53;
            // 
            // tname
            // 
            this.tname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tname.Location = new System.Drawing.Point(311, 73);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(251, 22);
            this.tname.TabIndex = 52;
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.Location = new System.Drawing.Point(168, 77);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(48, 18);
            this.lname.TabIndex = 51;
            this.lname.Text = "Name";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(610, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 34);
            this.button2.TabIndex = 50;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(610, 373);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(102, 35);
            this.btn_edit.TabIndex = 49;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(610, 430);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(102, 35);
            this.btn_delete.TabIndex = 48;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(610, 317);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(102, 35);
            this.btn_add.TabIndex = 47;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dgview_students
            // 
            this.dgview_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview_students.Location = new System.Drawing.Point(91, 305);
            this.dgview_students.Name = "dgview_students";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dgview_students.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgview_students.Size = new System.Drawing.Size(502, 206);
            this.dgview_students.TabIndex = 46;
            this.dgview_students.SelectionChanged += new System.EventHandler(this.dgview_students_SelectionChanged);
            // 
            // lcourse
            // 
            this.lcourse.AutoSize = true;
            this.lcourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcourse.Location = new System.Drawing.Point(168, 236);
            this.lcourse.Name = "lcourse";
            this.lcourse.Size = new System.Drawing.Size(57, 18);
            this.lcourse.TabIndex = 60;
            this.lcourse.Text = "Course";
            // 
            // com_course
            // 
            this.com_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_course.FormattingEnabled = true;
            this.com_course.Location = new System.Drawing.Point(311, 230);
            this.com_course.Name = "com_course";
            this.com_course.Size = new System.Drawing.Size(251, 24);
            this.com_course.TabIndex = 61;
            this.com_course.Text = " ";
            // 
            // user_name
            // 
            this.user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name.FormattingEnabled = true;
            this.user_name.Location = new System.Drawing.Point(311, 32);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(251, 24);
            this.user_name.TabIndex = 63;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(169, 38);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(77, 18);
            this.username.TabIndex = 64;
            this.username.Text = "Username";
            // 
            // dtp_dob
            // 
            this.dtp_dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dob.Location = new System.Drawing.Point(311, 184);
            this.dtp_dob.Name = "dtp_dob";
            this.dtp_dob.Size = new System.Drawing.Size(251, 22);
            this.dtp_dob.TabIndex = 65;
            // 
            // lsearch
            // 
            this.lsearch.AutoSize = true;
            this.lsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsearch.Location = new System.Drawing.Point(168, 275);
            this.lsearch.Name = "lsearch";
            this.lsearch.Size = new System.Drawing.Size(55, 18);
            this.lsearch.TabIndex = 66;
            this.lsearch.Text = "Search";
            // 
            // Manage_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(809, 536);
            this.Controls.Add(this.lsearch);
            this.Controls.Add(this.dtp_dob);
            this.Controls.Add(this.username);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.com_course);
            this.Controls.Add(this.lcourse);
            this.Controls.Add(this.tsearch);
            this.Controls.Add(this.ldob);
            this.Controls.Add(this.tnumber);
            this.Controls.Add(this.lphonenumber);
            this.Controls.Add(this.laddress);
            this.Controls.Add(this.taddress);
            this.Controls.Add(this.tname);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgview_students);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manage_student";
            this.Text = "Manage Student";
            this.Load += new System.EventHandler(this.Manage_student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgview_students)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tsearch;
        private System.Windows.Forms.Label ldob;
        private System.Windows.Forms.TextBox tnumber;
        private System.Windows.Forms.Label lphonenumber;
        private System.Windows.Forms.Label laddress;
        private System.Windows.Forms.TextBox taddress;
        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dgview_students;
        private System.Windows.Forms.Label lcourse;
        private System.Windows.Forms.ComboBox com_course;
        private System.Windows.Forms.ComboBox user_name;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.DateTimePicker dtp_dob;
        private System.Windows.Forms.Label lsearch;
    }
}