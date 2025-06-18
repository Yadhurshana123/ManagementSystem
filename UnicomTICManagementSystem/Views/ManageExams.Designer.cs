namespace UnicomTICManagementSystem.Views
{
    partial class ManageExams
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
            this.l_st_time = new System.Windows.Forms.Label();
            this.lDate = new System.Windows.Forms.Label();
            this.room_name = new System.Windows.Forms.Label();
            this.texam_name = new System.Windows.Forms.TextBox();
            this.lexam_name = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dgview_exam = new System.Windows.Forms.DataGridView();
            this.com_room_name = new System.Windows.Forms.ComboBox();
            this.l_end_time = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.dtp_end_time = new System.Windows.Forms.DateTimePicker();
            this.dtp_st_time = new System.Windows.Forms.DateTimePicker();
            this.l_module_name = new System.Windows.Forms.Label();
            this.com_module_name = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_exam)).BeginInit();
            this.SuspendLayout();
            // 
            // l_st_time
            // 
            this.l_st_time.AutoSize = true;
            this.l_st_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_st_time.Location = new System.Drawing.Point(159, 183);
            this.l_st_time.Name = "l_st_time";
            this.l_st_time.Size = new System.Drawing.Size(71, 18);
            this.l_st_time.TabIndex = 74;
            this.l_st_time.Text = "Start time";
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDate.Location = new System.Drawing.Point(159, 137);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(78, 18);
            this.lDate.TabIndex = 72;
            this.lDate.Text = "Exam date";
            // 
            // room_name
            // 
            this.room_name.AutoSize = true;
            this.room_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_name.Location = new System.Drawing.Point(159, 93);
            this.room_name.Name = "room_name";
            this.room_name.Size = new System.Drawing.Size(91, 18);
            this.room_name.TabIndex = 71;
            this.room_name.Text = "Room name";
            // 
            // texam_name
            // 
            this.texam_name.Location = new System.Drawing.Point(313, 52);
            this.texam_name.Name = "texam_name";
            this.texam_name.Size = new System.Drawing.Size(251, 20);
            this.texam_name.TabIndex = 69;
            // 
            // lexam_name
            // 
            this.lexam_name.AutoSize = true;
            this.lexam_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lexam_name.Location = new System.Drawing.Point(159, 54);
            this.lexam_name.Name = "lexam_name";
            this.lexam_name.Size = new System.Drawing.Size(87, 18);
            this.lexam_name.TabIndex = 68;
            this.lexam_name.Text = "Exam name";
            // 
            // btn_edit
            // 
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(612, 334);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(102, 35);
            this.btn_edit.TabIndex = 66;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(612, 410);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(102, 35);
            this.btn_delete.TabIndex = 65;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(612, 258);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(102, 35);
            this.btn_add.TabIndex = 64;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dgview_exam
            // 
            this.dgview_exam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview_exam.Location = new System.Drawing.Point(87, 258);
            this.dgview_exam.Name = "dgview_exam";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dgview_exam.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgview_exam.Size = new System.Drawing.Size(502, 206);
            this.dgview_exam.TabIndex = 63;
            this.dgview_exam.SelectionChanged += new System.EventHandler(this.dgview_exam_SelectionChanged);
            // 
            // com_room_name
            // 
            this.com_room_name.FormattingEnabled = true;
            this.com_room_name.Location = new System.Drawing.Point(313, 90);
            this.com_room_name.Name = "com_room_name";
            this.com_room_name.Size = new System.Drawing.Size(251, 21);
            this.com_room_name.TabIndex = 76;
            // 
            // l_end_time
            // 
            this.l_end_time.AutoSize = true;
            this.l_end_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_end_time.Location = new System.Drawing.Point(159, 226);
            this.l_end_time.Name = "l_end_time";
            this.l_end_time.Size = new System.Drawing.Size(66, 18);
            this.l_end_time.TabIndex = 77;
            this.l_end_time.Text = "End time";
            // 
            // dtp_date
            // 
            this.dtp_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(313, 133);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(251, 22);
            this.dtp_date.TabIndex = 78;
            // 
            // dtp_end_time
            // 
            this.dtp_end_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_end_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_end_time.Location = new System.Drawing.Point(313, 222);
            this.dtp_end_time.Name = "dtp_end_time";
            this.dtp_end_time.Size = new System.Drawing.Size(251, 22);
            this.dtp_end_time.TabIndex = 79;
            // 
            // dtp_st_time
            // 
            this.dtp_st_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_st_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_st_time.Location = new System.Drawing.Point(313, 179);
            this.dtp_st_time.Name = "dtp_st_time";
            this.dtp_st_time.Size = new System.Drawing.Size(251, 22);
            this.dtp_st_time.TabIndex = 80;
            // 
            // l_module_name
            // 
            this.l_module_name.AutoSize = true;
            this.l_module_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_module_name.Location = new System.Drawing.Point(159, 15);
            this.l_module_name.Name = "l_module_name";
            this.l_module_name.Size = new System.Drawing.Size(98, 18);
            this.l_module_name.TabIndex = 81;
            this.l_module_name.Text = "Module name";
            // 
            // com_module_name
            // 
            this.com_module_name.FormattingEnabled = true;
            this.com_module_name.Location = new System.Drawing.Point(313, 12);
            this.com_module_name.Name = "com_module_name";
            this.com_module_name.Size = new System.Drawing.Size(251, 21);
            this.com_module_name.TabIndex = 82;
            // 
            // ManageExams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(825, 482);
            this.Controls.Add(this.com_module_name);
            this.Controls.Add(this.l_module_name);
            this.Controls.Add(this.dtp_st_time);
            this.Controls.Add(this.dtp_end_time);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.l_end_time);
            this.Controls.Add(this.com_room_name);
            this.Controls.Add(this.l_st_time);
            this.Controls.Add(this.lDate);
            this.Controls.Add(this.room_name);
            this.Controls.Add(this.texam_name);
            this.Controls.Add(this.lexam_name);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgview_exam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageExams";
            this.Text = "ManageExams";
            ((System.ComponentModel.ISupportInitialize)(this.dgview_exam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label l_st_time;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.Label room_name;
        private System.Windows.Forms.TextBox texam_name;
        private System.Windows.Forms.Label lexam_name;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dgview_exam;
        private System.Windows.Forms.ComboBox com_room_name;
        private System.Windows.Forms.Label l_end_time;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.DateTimePicker dtp_end_time;
        private System.Windows.Forms.DateTimePicker dtp_st_time;
        private System.Windows.Forms.Label l_module_name;
        private System.Windows.Forms.ComboBox com_module_name;
    }
}