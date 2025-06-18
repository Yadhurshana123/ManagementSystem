namespace UnicomTICManagementSystem.Views
{
    partial class LectureAccessForm
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
            this.btn_lec_exams = new System.Windows.Forms.Button();
            this.btn_lec_shedule = new System.Windows.Forms.Button();
            this.btn_lec_course = new System.Windows.Forms.Button();
            this.btn_lec_timetable = new System.Windows.Forms.Button();
            this.btn_lec_details = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_lecturer = new System.Windows.Forms.Label();
            this.lecturer_panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_lec_exams);
            this.panel1.Controls.Add(this.btn_lec_shedule);
            this.panel1.Controls.Add(this.btn_lec_course);
            this.panel1.Controls.Add(this.btn_lec_timetable);
            this.panel1.Controls.Add(this.btn_lec_details);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // btn_lec_exams
            // 
            this.btn_lec_exams.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_lec_exams.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lec_exams.Location = new System.Drawing.Point(18, 217);
            this.btn_lec_exams.Name = "btn_lec_exams";
            this.btn_lec_exams.Size = new System.Drawing.Size(165, 57);
            this.btn_lec_exams.TabIndex = 2;
            this.btn_lec_exams.Text = "View Exams";
            this.btn_lec_exams.UseVisualStyleBackColor = true;
            this.btn_lec_exams.Click += new System.EventHandler(this.btn_lec_exams_Click);
            // 
            // btn_lec_shedule
            // 
            this.btn_lec_shedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_lec_shedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lec_shedule.Location = new System.Drawing.Point(18, 365);
            this.btn_lec_shedule.Name = "btn_lec_shedule";
            this.btn_lec_shedule.Size = new System.Drawing.Size(165, 57);
            this.btn_lec_shedule.TabIndex = 4;
            this.btn_lec_shedule.Text = "Mark Shedule";
            this.btn_lec_shedule.UseVisualStyleBackColor = true;
            this.btn_lec_shedule.Click += new System.EventHandler(this.btn_lec_shedule_Click);
            // 
            // btn_lec_course
            // 
            this.btn_lec_course.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_lec_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lec_course.Location = new System.Drawing.Point(18, 290);
            this.btn_lec_course.Name = "btn_lec_course";
            this.btn_lec_course.Size = new System.Drawing.Size(165, 57);
            this.btn_lec_course.TabIndex = 3;
            this.btn_lec_course.Text = "View Courses";
            this.btn_lec_course.UseVisualStyleBackColor = true;
            this.btn_lec_course.Click += new System.EventHandler(this.btn_lec_course_Click);
            // 
            // btn_lec_timetable
            // 
            this.btn_lec_timetable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_lec_timetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lec_timetable.Location = new System.Drawing.Point(18, 143);
            this.btn_lec_timetable.Name = "btn_lec_timetable";
            this.btn_lec_timetable.Size = new System.Drawing.Size(165, 57);
            this.btn_lec_timetable.TabIndex = 1;
            this.btn_lec_timetable.Text = "View Timetable";
            this.btn_lec_timetable.UseVisualStyleBackColor = true;
            this.btn_lec_timetable.Click += new System.EventHandler(this.btn_lec_timetable_Click);
            // 
            // btn_lec_details
            // 
            this.btn_lec_details.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_lec_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lec_details.Location = new System.Drawing.Point(18, 66);
            this.btn_lec_details.Name = "btn_lec_details";
            this.btn_lec_details.Size = new System.Drawing.Size(165, 57);
            this.btn_lec_details.TabIndex = 0;
            this.btn_lec_details.Text = "Details";
            this.btn_lec_details.UseVisualStyleBackColor = true;
            this.btn_lec_details.Click += new System.EventHandler(this.btn_lec_details_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.lbl_lecturer);
            this.panel2.Location = new System.Drawing.Point(199, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 54);
            this.panel2.TabIndex = 1;
            // 
            // lbl_lecturer
            // 
            this.lbl_lecturer.AutoSize = true;
            this.lbl_lecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lecturer.Location = new System.Drawing.Point(211, 9);
            this.lbl_lecturer.Name = "lbl_lecturer";
            this.lbl_lecturer.Size = new System.Drawing.Size(122, 31);
            this.lbl_lecturer.TabIndex = 0;
            this.lbl_lecturer.Text = "Lecturer";
            // 
            // lecturer_panel
            // 
            this.lecturer_panel.BackColor = System.Drawing.SystemColors.Window;
            this.lecturer_panel.Location = new System.Drawing.Point(199, 48);
            this.lecturer_panel.Name = "lecturer_panel";
            this.lecturer_panel.Size = new System.Drawing.Size(601, 399);
            this.lecturer_panel.TabIndex = 2;
            // 
            // LectureAccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lecturer_panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LectureAccessForm";
            this.Text = "LectureAccessForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel lecturer_panel;
        private System.Windows.Forms.Button btn_lec_exams;
        private System.Windows.Forms.Button btn_lec_shedule;
        private System.Windows.Forms.Button btn_lec_course;
        private System.Windows.Forms.Button btn_lec_timetable;
        private System.Windows.Forms.Button btn_lec_details;
        private System.Windows.Forms.Label lbl_lecturer;
    }
}