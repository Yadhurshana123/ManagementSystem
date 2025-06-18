namespace UnicomTICManagementSystem.Views
{
    partial class StaffAccessForm
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
            this.btn_staff_shedule = new System.Windows.Forms.Button();
            this.staff_panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_staff = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_staff_exams = new System.Windows.Forms.Button();
            this.btn_staff_course = new System.Windows.Forms.Button();
            this.btn_staff_timetable = new System.Windows.Forms.Button();
            this.btn_staff_details = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_staff_shedule
            // 
            this.btn_staff_shedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_staff_shedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_staff_shedule.Location = new System.Drawing.Point(18, 365);
            this.btn_staff_shedule.Name = "btn_staff_shedule";
            this.btn_staff_shedule.Size = new System.Drawing.Size(165, 57);
            this.btn_staff_shedule.TabIndex = 4;
            this.btn_staff_shedule.Text = "Mark Shedule";
            this.btn_staff_shedule.UseVisualStyleBackColor = true;
            this.btn_staff_shedule.Click += new System.EventHandler(this.btn_staff_shedule_Click);
            // 
            // staff_panel
            // 
            this.staff_panel.BackColor = System.Drawing.SystemColors.Window;
            this.staff_panel.Location = new System.Drawing.Point(199, 48);
            this.staff_panel.Name = "staff_panel";
            this.staff_panel.Size = new System.Drawing.Size(601, 399);
            this.staff_panel.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.lbl_staff);
            this.panel2.Location = new System.Drawing.Point(199, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 54);
            this.panel2.TabIndex = 4;
            // 
            // lbl_staff
            // 
            this.lbl_staff.AutoSize = true;
            this.lbl_staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_staff.Location = new System.Drawing.Point(216, 9);
            this.lbl_staff.Name = "lbl_staff";
            this.lbl_staff.Size = new System.Drawing.Size(76, 31);
            this.lbl_staff.TabIndex = 0;
            this.lbl_staff.Text = "Staff";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_staff_exams);
            this.panel1.Controls.Add(this.btn_staff_shedule);
            this.panel1.Controls.Add(this.btn_staff_course);
            this.panel1.Controls.Add(this.btn_staff_timetable);
            this.panel1.Controls.Add(this.btn_staff_details);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 3;
            // 
            // btn_staff_exams
            // 
            this.btn_staff_exams.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_staff_exams.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_staff_exams.Location = new System.Drawing.Point(18, 217);
            this.btn_staff_exams.Name = "btn_staff_exams";
            this.btn_staff_exams.Size = new System.Drawing.Size(165, 57);
            this.btn_staff_exams.TabIndex = 2;
            this.btn_staff_exams.Text = "View Exams";
            this.btn_staff_exams.UseVisualStyleBackColor = true;
            this.btn_staff_exams.Click += new System.EventHandler(this.btn_staff_exams_Click);
            // 
            // btn_staff_course
            // 
            this.btn_staff_course.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_staff_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_staff_course.Location = new System.Drawing.Point(18, 290);
            this.btn_staff_course.Name = "btn_staff_course";
            this.btn_staff_course.Size = new System.Drawing.Size(165, 57);
            this.btn_staff_course.TabIndex = 3;
            this.btn_staff_course.Text = "View Courses";
            this.btn_staff_course.UseVisualStyleBackColor = true;
            this.btn_staff_course.Click += new System.EventHandler(this.btn_staff_course_Click);
            // 
            // btn_staff_timetable
            // 
            this.btn_staff_timetable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_staff_timetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_staff_timetable.Location = new System.Drawing.Point(18, 143);
            this.btn_staff_timetable.Name = "btn_staff_timetable";
            this.btn_staff_timetable.Size = new System.Drawing.Size(165, 57);
            this.btn_staff_timetable.TabIndex = 1;
            this.btn_staff_timetable.Text = "View Timetable";
            this.btn_staff_timetable.UseVisualStyleBackColor = true;
            this.btn_staff_timetable.Click += new System.EventHandler(this.btn_staff_timetable_Click);
            // 
            // btn_staff_details
            // 
            this.btn_staff_details.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_staff_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_staff_details.Location = new System.Drawing.Point(18, 66);
            this.btn_staff_details.Name = "btn_staff_details";
            this.btn_staff_details.Size = new System.Drawing.Size(165, 57);
            this.btn_staff_details.TabIndex = 0;
            this.btn_staff_details.Text = "Details";
            this.btn_staff_details.UseVisualStyleBackColor = true;
            this.btn_staff_details.Click += new System.EventHandler(this.btn_lec_details_Click);
            // 
            // StaffAccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.staff_panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffAccessForm";
            this.Text = "StaffAccessForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_staff_shedule;
        private System.Windows.Forms.Panel staff_panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_staff_exams;
        private System.Windows.Forms.Button btn_staff_course;
        private System.Windows.Forms.Button btn_staff_timetable;
        private System.Windows.Forms.Button btn_staff_details;
        private System.Windows.Forms.Label lbl_staff;
    }
}