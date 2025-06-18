namespace UnicomTICManagementSystem.Views
{
    partial class StudentAccessForm1
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
            this.btn_st_result = new System.Windows.Forms.Button();
            this.btn_st_timetable = new System.Windows.Forms.Button();
            this.btn_st_details = new System.Windows.Forms.Button();
            this.btn_st_exams = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_student = new System.Windows.Forms.Label();
            this.student_panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_st_result);
            this.panel1.Controls.Add(this.btn_st_timetable);
            this.panel1.Controls.Add(this.btn_st_details);
            this.panel1.Controls.Add(this.btn_st_exams);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // btn_st_result
            // 
            this.btn_st_result.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_st_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_st_result.Location = new System.Drawing.Point(12, 318);
            this.btn_st_result.Name = "btn_st_result";
            this.btn_st_result.Size = new System.Drawing.Size(171, 48);
            this.btn_st_result.TabIndex = 5;
            this.btn_st_result.Text = "View Results";
            this.btn_st_result.UseVisualStyleBackColor = true;
            // 
            // btn_st_timetable
            // 
            this.btn_st_timetable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_st_timetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_st_timetable.Location = new System.Drawing.Point(12, 152);
            this.btn_st_timetable.Name = "btn_st_timetable";
            this.btn_st_timetable.Size = new System.Drawing.Size(171, 48);
            this.btn_st_timetable.TabIndex = 4;
            this.btn_st_timetable.Text = "View Timetable";
            this.btn_st_timetable.UseVisualStyleBackColor = true;
            this.btn_st_timetable.Click += new System.EventHandler(this.btn_st_timetable_Click);
            // 
            // btn_st_details
            // 
            this.btn_st_details.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_st_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_st_details.Location = new System.Drawing.Point(12, 68);
            this.btn_st_details.Name = "btn_st_details";
            this.btn_st_details.Size = new System.Drawing.Size(171, 48);
            this.btn_st_details.TabIndex = 3;
            this.btn_st_details.Text = "Details";
            this.btn_st_details.UseVisualStyleBackColor = true;
            this.btn_st_details.Click += new System.EventHandler(this.btn_st_details_Click);
            // 
            // btn_st_exams
            // 
            this.btn_st_exams.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_st_exams.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_st_exams.Location = new System.Drawing.Point(12, 235);
            this.btn_st_exams.Name = "btn_st_exams";
            this.btn_st_exams.Size = new System.Drawing.Size(171, 48);
            this.btn_st_exams.TabIndex = 2;
            this.btn_st_exams.Text = "Viwe Exams";
            this.btn_st_exams.UseVisualStyleBackColor = true;
            this.btn_st_exams.Click += new System.EventHandler(this.btn_st_exams_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.lbl_student);
            this.panel2.Location = new System.Drawing.Point(206, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(589, 50);
            this.panel2.TabIndex = 1;
            // 
            // lbl_student
            // 
            this.lbl_student.AutoSize = true;
            this.lbl_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_student.Location = new System.Drawing.Point(203, 6);
            this.lbl_student.Name = "lbl_student";
            this.lbl_student.Size = new System.Drawing.Size(115, 31);
            this.lbl_student.TabIndex = 0;
            this.lbl_student.Text = "Student";
            // 
            // student_panel
            // 
            this.student_panel.BackColor = System.Drawing.SystemColors.Window;
            this.student_panel.Location = new System.Drawing.Point(206, 59);
            this.student_panel.Name = "student_panel";
            this.student_panel.Size = new System.Drawing.Size(589, 379);
            this.student_panel.TabIndex = 2;
            // 
            // StudentAccessForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.student_panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentAccessForm1";
            this.Text = "StudentAccessForm1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel student_panel;
        private System.Windows.Forms.Button btn_st_result;
        private System.Windows.Forms.Button btn_st_timetable;
        private System.Windows.Forms.Button btn_st_details;
        private System.Windows.Forms.Button btn_st_exams;
        private System.Windows.Forms.Label lbl_student;
    }
}