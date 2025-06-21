namespace UnicomTICManagementSystem.Views
{
    partial class ManageMarks
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
            this.lscore = new System.Windows.Forms.Label();
            this.lresult = new System.Windows.Forms.Label();
            this.tscore = new System.Windows.Forms.TextBox();
            this.tresult = new System.Windows.Forms.TextBox();
            this.dgv_result = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.com_students = new System.Windows.Forms.ComboBox();
            this.lbl_student = new System.Windows.Forms.Label();
            this.lbl_mark = new System.Windows.Forms.Label();
            this.com_exam = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).BeginInit();
            this.SuspendLayout();
            // 
            // lscore
            // 
            this.lscore.AutoSize = true;
            this.lscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lscore.Location = new System.Drawing.Point(200, 102);
            this.lscore.Name = "lscore";
            this.lscore.Size = new System.Drawing.Size(48, 18);
            this.lscore.TabIndex = 0;
            this.lscore.Text = "Score";
            // 
            // lresult
            // 
            this.lresult.AutoSize = true;
            this.lresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lresult.Location = new System.Drawing.Point(199, 143);
            this.lresult.Name = "lresult";
            this.lresult.Size = new System.Drawing.Size(50, 18);
            this.lresult.TabIndex = 1;
            this.lresult.Text = "Result";
            // 
            // tscore
            // 
            this.tscore.Location = new System.Drawing.Point(325, 100);
            this.tscore.Name = "tscore";
            this.tscore.Size = new System.Drawing.Size(223, 20);
            this.tscore.TabIndex = 2;
            // 
            // tresult
            // 
            this.tresult.Location = new System.Drawing.Point(325, 141);
            this.tresult.Name = "tresult";
            this.tresult.Size = new System.Drawing.Size(223, 20);
            this.tresult.TabIndex = 3;
            // 
            // dgv_result
            // 
            this.dgv_result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_result.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_result.Location = new System.Drawing.Point(136, 235);
            this.dgv_result.Name = "dgv_result";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dgv_result.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_result.Size = new System.Drawing.Size(459, 198);
            this.dgv_result.TabIndex = 4;
            this.dgv_result.SelectionChanged += new System.EventHandler(this.dgv_result_SelectionChanged);
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(202, 194);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(122, 35);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(436, 189);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(112, 35);
            this.btn_edit.TabIndex = 6;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // com_students
            // 
            this.com_students.FormattingEnabled = true;
            this.com_students.Location = new System.Drawing.Point(325, 13);
            this.com_students.Name = "com_students";
            this.com_students.Size = new System.Drawing.Size(223, 21);
            this.com_students.TabIndex = 8;
            // 
            // lbl_student
            // 
            this.lbl_student.AutoSize = true;
            this.lbl_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_student.Location = new System.Drawing.Point(199, 9);
            this.lbl_student.Name = "lbl_student";
            this.lbl_student.Size = new System.Drawing.Size(58, 18);
            this.lbl_student.TabIndex = 9;
            this.lbl_student.Text = "Student";
            // 
            // lbl_mark
            // 
            this.lbl_mark.AutoSize = true;
            this.lbl_mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mark.Location = new System.Drawing.Point(200, 57);
            this.lbl_mark.Name = "lbl_mark";
            this.lbl_mark.Size = new System.Drawing.Size(46, 18);
            this.lbl_mark.TabIndex = 10;
            this.lbl_mark.Text = "Exam";
            this.lbl_mark.Click += new System.EventHandler(this.lbl_module_Click);
            // 
            // com_exam
            // 
            this.com_exam.FormattingEnabled = true;
            this.com_exam.Location = new System.Drawing.Point(325, 57);
            this.com_exam.Name = "com_exam";
            this.com_exam.Size = new System.Drawing.Size(223, 21);
            this.com_exam.TabIndex = 11;
            // 
            // ManageMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 493);
            this.Controls.Add(this.com_exam);
            this.Controls.Add(this.lbl_mark);
            this.Controls.Add(this.lbl_student);
            this.Controls.Add(this.com_students);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgv_result);
            this.Controls.Add(this.tresult);
            this.Controls.Add(this.tscore);
            this.Controls.Add(this.lresult);
            this.Controls.Add(this.lscore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageMarks";
            this.Text = "ManageMarks";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lscore;
        private System.Windows.Forms.Label lresult;
        private System.Windows.Forms.TextBox tscore;
        private System.Windows.Forms.TextBox tresult;
        private System.Windows.Forms.DataGridView dgv_result;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.ComboBox com_students;
        private System.Windows.Forms.Label lbl_student;
        private System.Windows.Forms.Label lbl_mark;
        private System.Windows.Forms.ComboBox com_exam;
    }
}