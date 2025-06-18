namespace UnicomTICManagementSystem.Views
{
    partial class AdminForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_manage_rooms = new System.Windows.Forms.Button();
            this.btn_manage_module = new System.Windows.Forms.Button();
            this.btn_admin_details = new System.Windows.Forms.Button();
            this.btn_marks = new System.Windows.Forms.Button();
            this.btn_manage_attendance = new System.Windows.Forms.Button();
            this.btn_manage_exam = new System.Windows.Forms.Button();
            this.btn_manage_course = new System.Windows.Forms.Button();
            this.btn_manage_timetable = new System.Windows.Forms.Button();
            this.btn_manage_staff = new System.Windows.Forms.Button();
            this.btn_manage_lecture = new System.Windows.Forms.Button();
            this.btn_manage_student = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_admin = new System.Windows.Forms.Label();
            this.mainpanel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_manage_timetable);
            this.panel1.Controls.Add(this.btn_manage_lecture);
            this.panel1.Controls.Add(this.btn_manage_student);
            this.panel1.Controls.Add(this.btn_manage_rooms);
            this.panel1.Controls.Add(this.btn_manage_module);
            this.panel1.Controls.Add(this.btn_admin_details);
            this.panel1.Controls.Add(this.btn_marks);
            this.panel1.Controls.Add(this.btn_manage_attendance);
            this.panel1.Controls.Add(this.btn_manage_exam);
            this.panel1.Controls.Add(this.btn_manage_course);
            this.panel1.Controls.Add(this.btn_manage_staff);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 560);
            this.panel1.TabIndex = 0;
            // 
            // btn_manage_rooms
            // 
            this.btn_manage_rooms.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_manage_rooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manage_rooms.Location = new System.Drawing.Point(12, 132);
            this.btn_manage_rooms.Name = "btn_manage_rooms";
            this.btn_manage_rooms.Size = new System.Drawing.Size(181, 35);
            this.btn_manage_rooms.TabIndex = 10;
            this.btn_manage_rooms.Text = "Manage Rooms";
            this.btn_manage_rooms.UseVisualStyleBackColor = true;
            this.btn_manage_rooms.Click += new System.EventHandler(this.btn_manage_rooms_Click);
            // 
            // btn_manage_module
            // 
            this.btn_manage_module.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_manage_module.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manage_module.Location = new System.Drawing.Point(12, 173);
            this.btn_manage_module.Name = "btn_manage_module";
            this.btn_manage_module.Size = new System.Drawing.Size(181, 35);
            this.btn_manage_module.TabIndex = 9;
            this.btn_manage_module.Text = "Manage Modules";
            this.btn_manage_module.UseVisualStyleBackColor = true;
            this.btn_manage_module.Click += new System.EventHandler(this.btn_manage_module_Click);
            // 
            // btn_admin_details
            // 
            this.btn_admin_details.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_admin_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin_details.Location = new System.Drawing.Point(12, 49);
            this.btn_admin_details.Name = "btn_admin_details";
            this.btn_admin_details.Size = new System.Drawing.Size(181, 35);
            this.btn_admin_details.TabIndex = 8;
            this.btn_admin_details.Text = "Details";
            this.btn_admin_details.UseVisualStyleBackColor = true;
            // 
            // btn_marks
            // 
            this.btn_marks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_marks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_marks.Location = new System.Drawing.Point(13, 461);
            this.btn_marks.Name = "btn_marks";
            this.btn_marks.Size = new System.Drawing.Size(181, 35);
            this.btn_marks.TabIndex = 7;
            this.btn_marks.Text = "View Marks";
            this.btn_marks.UseVisualStyleBackColor = true;
            this.btn_marks.Click += new System.EventHandler(this.btn_marks_Click);
            // 
            // btn_manage_attendance
            // 
            this.btn_manage_attendance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_manage_attendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manage_attendance.Location = new System.Drawing.Point(12, 420);
            this.btn_manage_attendance.Name = "btn_manage_attendance";
            this.btn_manage_attendance.Size = new System.Drawing.Size(181, 35);
            this.btn_manage_attendance.TabIndex = 6;
            this.btn_manage_attendance.Text = "Manage Attendance";
            this.btn_manage_attendance.UseVisualStyleBackColor = true;
            this.btn_manage_attendance.Click += new System.EventHandler(this.btn_manage_attendance_Click);
            // 
            // btn_manage_exam
            // 
            this.btn_manage_exam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_manage_exam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manage_exam.Location = new System.Drawing.Point(12, 379);
            this.btn_manage_exam.Name = "btn_manage_exam";
            this.btn_manage_exam.Size = new System.Drawing.Size(181, 35);
            this.btn_manage_exam.TabIndex = 5;
            this.btn_manage_exam.Text = "Manage Exams";
            this.btn_manage_exam.UseVisualStyleBackColor = true;
            this.btn_manage_exam.Click += new System.EventHandler(this.btn_manage_exam_Click);
            // 
            // btn_manage_course
            // 
            this.btn_manage_course.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_manage_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manage_course.Location = new System.Drawing.Point(12, 90);
            this.btn_manage_course.Name = "btn_manage_course";
            this.btn_manage_course.Size = new System.Drawing.Size(181, 36);
            this.btn_manage_course.TabIndex = 4;
            this.btn_manage_course.Text = "Manage Course";
            this.btn_manage_course.UseVisualStyleBackColor = true;
            this.btn_manage_course.Click += new System.EventHandler(this.btn_manage_course_Click);
            // 
            // btn_manage_timetable
            // 
            this.btn_manage_timetable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_manage_timetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manage_timetable.Location = new System.Drawing.Point(13, 338);
            this.btn_manage_timetable.Name = "btn_manage_timetable";
            this.btn_manage_timetable.Size = new System.Drawing.Size(181, 35);
            this.btn_manage_timetable.TabIndex = 3;
            this.btn_manage_timetable.Text = "Manage Timetable";
            this.btn_manage_timetable.UseVisualStyleBackColor = true;
            this.btn_manage_timetable.Click += new System.EventHandler(this.btn_manage_timetable_Click);
            // 
            // btn_manage_staff
            // 
            this.btn_manage_staff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_manage_staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manage_staff.Location = new System.Drawing.Point(13, 296);
            this.btn_manage_staff.Name = "btn_manage_staff";
            this.btn_manage_staff.Size = new System.Drawing.Size(181, 36);
            this.btn_manage_staff.TabIndex = 2;
            this.btn_manage_staff.Text = "Manage Staffs";
            this.btn_manage_staff.UseVisualStyleBackColor = true;
            this.btn_manage_staff.Click += new System.EventHandler(this.btn_manage_staff_Click);
            // 
            // btn_manage_lecture
            // 
            this.btn_manage_lecture.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_manage_lecture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manage_lecture.Location = new System.Drawing.Point(12, 255);
            this.btn_manage_lecture.Name = "btn_manage_lecture";
            this.btn_manage_lecture.Size = new System.Drawing.Size(181, 35);
            this.btn_manage_lecture.TabIndex = 1;
            this.btn_manage_lecture.Text = "Manage Lectures";
            this.btn_manage_lecture.UseVisualStyleBackColor = true;
            this.btn_manage_lecture.Click += new System.EventHandler(this.btn_manage_lecture_Click);
            // 
            // btn_manage_student
            // 
            this.btn_manage_student.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_manage_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manage_student.Location = new System.Drawing.Point(12, 214);
            this.btn_manage_student.Name = "btn_manage_student";
            this.btn_manage_student.Size = new System.Drawing.Size(181, 35);
            this.btn_manage_student.TabIndex = 0;
            this.btn_manage_student.Text = "Manage Students";
            this.btn_manage_student.UseVisualStyleBackColor = true;
            this.btn_manage_student.Click += new System.EventHandler(this.btn_manage_student_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.lbl_admin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 54);
            this.panel2.TabIndex = 1;
            // 
            // lbl_admin
            // 
            this.lbl_admin.AutoSize = true;
            this.lbl_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_admin.Location = new System.Drawing.Point(355, 13);
            this.lbl_admin.Name = "lbl_admin";
            this.lbl_admin.Size = new System.Drawing.Size(95, 31);
            this.lbl_admin.TabIndex = 0;
            this.lbl_admin.Text = "Admin";
            // 
            // mainpanel1
            // 
            this.mainpanel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.mainpanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel1.Location = new System.Drawing.Point(200, 54);
            this.mainpanel1.Name = "mainpanel1";
            this.mainpanel1.Size = new System.Drawing.Size(797, 506);
            this.mainpanel1.TabIndex = 2;
            this.mainpanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 560);
            this.Controls.Add(this.mainpanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel mainpanel1;
        private System.Windows.Forms.Button btn_manage_timetable;
        private System.Windows.Forms.Button btn_manage_staff;
        private System.Windows.Forms.Button btn_manage_lecture;
        private System.Windows.Forms.Button btn_manage_student;
        private System.Windows.Forms.Button btn_manage_course;
        private System.Windows.Forms.Button btn_manage_exam;
        private System.Windows.Forms.Button btn_manage_attendance;
        private System.Windows.Forms.Button btn_admin_details;
        private System.Windows.Forms.Button btn_marks;
        private System.Windows.Forms.Label lbl_admin;
        private System.Windows.Forms.Button btn_manage_module;
        private System.Windows.Forms.Button btn_manage_rooms;
    }
}