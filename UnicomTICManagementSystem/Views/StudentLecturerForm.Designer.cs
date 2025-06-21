namespace UnicomTICManagementSystem.Views
{
    partial class StudentLecturerForm
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
            this.lbl_student_name = new System.Windows.Forms.Label();
            this.lbl_lecturer_name = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btn_assign = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_student_name
            // 
            this.lbl_student_name.AutoSize = true;
            this.lbl_student_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_student_name.Location = new System.Drawing.Point(56, 58);
            this.lbl_student_name.Name = "lbl_student_name";
            this.lbl_student_name.Size = new System.Drawing.Size(110, 20);
            this.lbl_student_name.TabIndex = 0;
            this.lbl_student_name.Text = "Student name";
            // 
            // lbl_lecturer_name
            // 
            this.lbl_lecturer_name.AutoSize = true;
            this.lbl_lecturer_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lecturer_name.Location = new System.Drawing.Point(56, 107);
            this.lbl_lecturer_name.Name = "lbl_lecturer_name";
            this.lbl_lecturer_name.Size = new System.Drawing.Size(112, 20);
            this.lbl_lecturer_name.TabIndex = 1;
            this.lbl_lecturer_name.Text = "Lecturer name";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(233, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(233, 121);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(236, 94);
            this.checkedListBox1.TabIndex = 3;
            // 
            // btn_assign
            // 
            this.btn_assign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_assign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_assign.Location = new System.Drawing.Point(71, 348);
            this.btn_assign.Name = "btn_assign";
            this.btn_assign.Size = new System.Drawing.Size(142, 40);
            this.btn_assign.TabIndex = 4;
            this.btn_assign.Text = "Assign Lecturer";
            this.btn_assign.UseVisualStyleBackColor = true;
            // 
            // btn_remove
            // 
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.Location = new System.Drawing.Point(279, 348);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(139, 39);
            this.btn_remove.TabIndex = 5;
            this.btn_remove.Text = "Remove Lecturer";
            this.btn_remove.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(495, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 411);
            this.dataGridView1.TabIndex = 6;
            // 
            // StudentLecturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(773, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_assign);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_lecturer_name);
            this.Controls.Add(this.lbl_student_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentLecturerForm";
            this.Text = "StudentLecturerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_student_name;
        private System.Windows.Forms.Label lbl_lecturer_name;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btn_assign;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}