namespace UnicomTICManagementSystem.Views
{
    partial class ManageAttendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.radio_btn_present = new System.Windows.Forms.RadioButton();
            this.radio_btn_absent = new System.Windows.Forms.RadioButton();
            this.com_timetable = new System.Windows.Forms.ComboBox();
            this.com_student = new System.Windows.Forms.ComboBox();
            this.student_name = new System.Windows.Forms.Label();
            this.radio_btn_late = new System.Windows.Forms.RadioButton();
            this.lbl_timetable = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.dgv_attendance = new System.Windows.Forms.DataGridView();
            this.btn_edit = new System.Windows.Forms.Button();
            this.dtp_login = new System.Windows.Forms.DateTimePicker();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_logout = new System.Windows.Forms.Label();
            this.dtp_logout = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_attendance)).BeginInit();
            this.SuspendLayout();
            // 
            // radio_btn_present
            // 
            this.radio_btn_present.AutoSize = true;
            this.radio_btn_present.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_btn_present.Location = new System.Drawing.Point(415, 202);
            this.radio_btn_present.Name = "radio_btn_present";
            this.radio_btn_present.Size = new System.Drawing.Size(71, 20);
            this.radio_btn_present.TabIndex = 0;
            this.radio_btn_present.TabStop = true;
            this.radio_btn_present.Text = "Present";
            this.radio_btn_present.UseVisualStyleBackColor = true;
            // 
            // radio_btn_absent
            // 
            this.radio_btn_absent.AutoSize = true;
            this.radio_btn_absent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_btn_absent.Location = new System.Drawing.Point(323, 202);
            this.radio_btn_absent.Name = "radio_btn_absent";
            this.radio_btn_absent.Size = new System.Drawing.Size(67, 20);
            this.radio_btn_absent.TabIndex = 1;
            this.radio_btn_absent.TabStop = true;
            this.radio_btn_absent.Text = "Absent";
            this.radio_btn_absent.UseVisualStyleBackColor = true;
            // 
            // com_timetable
            // 
            this.com_timetable.FormattingEnabled = true;
            this.com_timetable.Location = new System.Drawing.Point(323, 60);
            this.com_timetable.Name = "com_timetable";
            this.com_timetable.Size = new System.Drawing.Size(228, 21);
            this.com_timetable.TabIndex = 2;
            // 
            // com_student
            // 
            this.com_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_student.FormattingEnabled = true;
            this.com_student.Location = new System.Drawing.Point(323, 12);
            this.com_student.Name = "com_student";
            this.com_student.Size = new System.Drawing.Size(228, 24);
            this.com_student.TabIndex = 3;
            // 
            // student_name
            // 
            this.student_name.AutoSize = true;
            this.student_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_name.Location = new System.Drawing.Point(120, 18);
            this.student_name.Name = "student_name";
            this.student_name.Size = new System.Drawing.Size(99, 18);
            this.student_name.TabIndex = 4;
            this.student_name.Text = "Student name";
            // 
            // radio_btn_late
            // 
            this.radio_btn_late.AutoSize = true;
            this.radio_btn_late.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_btn_late.Location = new System.Drawing.Point(500, 202);
            this.radio_btn_late.Name = "radio_btn_late";
            this.radio_btn_late.Size = new System.Drawing.Size(51, 20);
            this.radio_btn_late.TabIndex = 5;
            this.radio_btn_late.TabStop = true;
            this.radio_btn_late.Text = "Late";
            this.radio_btn_late.UseVisualStyleBackColor = true;
            // 
            // lbl_timetable
            // 
            this.lbl_timetable.AutoSize = true;
            this.lbl_timetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timetable.Location = new System.Drawing.Point(119, 63);
            this.lbl_timetable.Name = "lbl_timetable";
            this.lbl_timetable.Size = new System.Drawing.Size(100, 18);
            this.lbl_timetable.TabIndex = 6;
            this.lbl_timetable.Text = "Timetable Info";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(120, 202);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(50, 18);
            this.status.TabIndex = 7;
            this.status.Text = "Status";
            // 
            // btn_submit
            // 
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Location = new System.Drawing.Point(586, 289);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(132, 42);
            this.btn_submit.TabIndex = 8;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // dgv_attendance
            // 
            this.dgv_attendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_attendance.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_attendance.Location = new System.Drawing.Point(123, 254);
            this.dgv_attendance.Name = "dgv_attendance";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dgv_attendance.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_attendance.Size = new System.Drawing.Size(428, 219);
            this.dgv_attendance.TabIndex = 9;
            this.dgv_attendance.SelectionChanged += new System.EventHandler(this.dgv_attendance_SelectionChanged);
            // 
            // btn_edit
            // 
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(586, 393);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(132, 42);
            this.btn_edit.TabIndex = 10;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // dtp_login
            // 
            this.dtp_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_login.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_login.Location = new System.Drawing.Point(323, 104);
            this.dtp_login.Name = "dtp_login";
            this.dtp_login.Size = new System.Drawing.Size(228, 22);
            this.dtp_login.TabIndex = 11;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.Location = new System.Drawing.Point(119, 108);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(44, 18);
            this.lbl_login.TabIndex = 12;
            this.lbl_login.Text = "LogIn";
            // 
            // lbl_logout
            // 
            this.lbl_logout.AutoSize = true;
            this.lbl_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logout.Location = new System.Drawing.Point(119, 152);
            this.lbl_logout.Name = "lbl_logout";
            this.lbl_logout.Size = new System.Drawing.Size(57, 18);
            this.lbl_logout.TabIndex = 13;
            this.lbl_logout.Text = "LogOut";
            // 
            // dtp_logout
            // 
            this.dtp_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_logout.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_logout.Location = new System.Drawing.Point(323, 149);
            this.dtp_logout.Name = "dtp_logout";
            this.dtp_logout.Size = new System.Drawing.Size(228, 22);
            this.dtp_logout.TabIndex = 14;
            // 
            // ManageAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(865, 562);
            this.Controls.Add(this.dtp_logout);
            this.Controls.Add(this.lbl_logout);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.dtp_login);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.dgv_attendance);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.status);
            this.Controls.Add(this.lbl_timetable);
            this.Controls.Add(this.radio_btn_late);
            this.Controls.Add(this.student_name);
            this.Controls.Add(this.com_student);
            this.Controls.Add(this.com_timetable);
            this.Controls.Add(this.radio_btn_absent);
            this.Controls.Add(this.radio_btn_present);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageAttendance";
            this.Text = "ManageAttendance";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_attendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radio_btn_present;
        private System.Windows.Forms.RadioButton radio_btn_absent;
        private System.Windows.Forms.ComboBox com_timetable;
        private System.Windows.Forms.ComboBox com_student;
        private System.Windows.Forms.Label student_name;
        private System.Windows.Forms.RadioButton radio_btn_late;
        private System.Windows.Forms.Label lbl_timetable;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.DataGridView dgv_attendance;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.DateTimePicker dtp_login;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_logout;
        private System.Windows.Forms.DateTimePicker dtp_logout;
    }
}