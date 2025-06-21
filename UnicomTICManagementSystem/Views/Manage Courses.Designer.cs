namespace UnicomTICManagementSystem.Views
{
    partial class Manage_Courses
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
            this.lcourse = new System.Windows.Forms.Label();
            this.tcourse = new System.Windows.Forms.TextBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dgview_course = new System.Windows.Forms.DataGridView();
            this.btn_delete = new System.Windows.Forms.Button();
            this.t_search = new System.Windows.Forms.TextBox();
            this.lsearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_course)).BeginInit();
            this.SuspendLayout();
            // 
            // lcourse
            // 
            this.lcourse.AutoSize = true;
            this.lcourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcourse.Location = new System.Drawing.Point(170, 41);
            this.lcourse.Name = "lcourse";
            this.lcourse.Size = new System.Drawing.Size(57, 18);
            this.lcourse.TabIndex = 76;
            this.lcourse.Text = "Course";
            // 
            // tcourse
            // 
            this.tcourse.Location = new System.Drawing.Point(301, 39);
            this.tcourse.Name = "tcourse";
            this.tcourse.Size = new System.Drawing.Size(251, 20);
            this.tcourse.TabIndex = 75;
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(595, 223);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(102, 35);
            this.btn_edit.TabIndex = 65;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(595, 158);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(102, 35);
            this.btn_add.TabIndex = 63;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dgview_course
            // 
            this.dgview_course.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgview_course.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgview_course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview_course.Location = new System.Drawing.Point(173, 158);
            this.dgview_course.Name = "dgview_course";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dgview_course.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgview_course.Size = new System.Drawing.Size(387, 197);
            this.dgview_course.TabIndex = 62;
            this.dgview_course.SelectionChanged += new System.EventHandler(this.dgview_course_SelectionChanged);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(595, 294);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(102, 35);
            this.btn_delete.TabIndex = 79;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // t_search
            // 
            this.t_search.Location = new System.Drawing.Point(301, 97);
            this.t_search.Name = "t_search";
            this.t_search.Size = new System.Drawing.Size(251, 20);
            this.t_search.TabIndex = 80;
            this.t_search.TextChanged += new System.EventHandler(this.t_search_TextChanged);
            // 
            // lsearch
            // 
            this.lsearch.AutoSize = true;
            this.lsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsearch.Location = new System.Drawing.Point(170, 102);
            this.lsearch.Name = "lsearch";
            this.lsearch.Size = new System.Drawing.Size(55, 18);
            this.lsearch.TabIndex = 82;
            this.lsearch.Text = "Search";
            // 
            // Manage_Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsearch);
            this.Controls.Add(this.t_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.lcourse);
            this.Controls.Add(this.tcourse);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgview_course);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manage_Courses";
            this.Text = "Manage_Courses";
            this.Load += new System.EventHandler(this.Manage_Courses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgview_course)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lcourse;
        private System.Windows.Forms.TextBox tcourse;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dgview_course;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox t_search;
        private System.Windows.Forms.Label lsearch;
    }
}