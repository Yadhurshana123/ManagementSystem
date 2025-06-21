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
            this.btn_staff_details = new System.Windows.Forms.Button();
            this.btn_staff_exams = new System.Windows.Forms.Button();
            this.btn_staff_course = new System.Windows.Forms.Button();
            this.btn_staff_timetable = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_staff_shedule
            // 
            this.btn_staff_shedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_staff_shedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_staff_shedule.Location = new System.Drawing.Point(12, 457);
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
            this.staff_panel.Location = new System.Drawing.Point(0, 43);
            this.staff_panel.Name = "staff_panel";
            this.staff_panel.Size = new System.Drawing.Size(623, 461);
            this.staff_panel.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.staff_panel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(188, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(659, 43);
            this.panel2.TabIndex = 4;
            // 
            // lbl_staff
            // 
            this.lbl_staff.AutoSize = true;
            this.lbl_staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_staff.Location = new System.Drawing.Point(57, 12);
            this.lbl_staff.Name = "lbl_staff";
            this.lbl_staff.Size = new System.Drawing.Size(76, 31);
            this.lbl_staff.TabIndex = 0;
            this.lbl_staff.Text = "Staff";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_staff_details);
            this.panel1.Controls.Add(this.lbl_staff);
            this.panel1.Controls.Add(this.btn_staff_exams);
            this.panel1.Controls.Add(this.btn_staff_shedule);
            this.panel1.Controls.Add(this.btn_staff_course);
            this.panel1.Controls.Add(this.btn_staff_timetable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 613);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_staff_details
            // 
            this.btn_staff_details.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_staff_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_staff_details.Location = new System.Drawing.Point(12, 83);
            this.btn_staff_details.Name = "btn_staff_details";
            this.btn_staff_details.Size = new System.Drawing.Size(165, 57);
            this.btn_staff_details.TabIndex = 5;
            this.btn_staff_details.Text = "Details";
            this.btn_staff_details.UseVisualStyleBackColor = true;
            this.btn_staff_details.Click += new System.EventHandler(this.btn_staff_details_Click);
            // 
            // btn_staff_exams
            // 
            this.btn_staff_exams.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_staff_exams.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_staff_exams.Location = new System.Drawing.Point(12, 266);
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
            this.btn_staff_course.Location = new System.Drawing.Point(12, 364);
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
            this.btn_staff_timetable.Location = new System.Drawing.Point(12, 169);
            this.btn_staff_timetable.Name = "btn_staff_timetable";
            this.btn_staff_timetable.Size = new System.Drawing.Size(165, 57);
            this.btn_staff_timetable.TabIndex = 1;
            this.btn_staff_timetable.Text = "View Timetable";
            this.btn_staff_timetable.UseVisualStyleBackColor = true;
            this.btn_staff_timetable.Click += new System.EventHandler(this.btn_staff_timetable_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainPanel.Controls.Add(this.panel3);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(188, 43);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(659, 570);
            this.mainPanel.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.btn_previous);
            this.panel3.Controls.Add(this.btn_exit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 489);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(659, 81);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btn_previous
            // 
            this.btn_previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_previous.Location = new System.Drawing.Point(416, 29);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(97, 30);
            this.btn_previous.TabIndex = 1;
            this.btn_previous.Text = "Previous";
            this.btn_previous.UseVisualStyleBackColor = true;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(550, 29);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(97, 30);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // StaffAccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 613);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffAccessForm";
            this.Text = "StaffAccessForm";
            this.Load += new System.EventHandler(this.StaffAccessForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.Label lbl_staff;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btn_staff_details;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btn_exit;
    }
}