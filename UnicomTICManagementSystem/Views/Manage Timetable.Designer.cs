namespace UnicomTICManagementSystem.Views
{
    partial class Manage_timetable
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
            this.btn_search = new System.Windows.Forms.Button();
            this.t_search = new System.Windows.Forms.TextBox();
            this.dgv_timetable = new System.Windows.Forms.DataGridView();
            this.start_time = new System.Windows.Forms.Label();
            this.end_time = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_module_name = new System.Windows.Forms.Label();
            this.lbl_room_name = new System.Windows.Forms.Label();
            this.lsearch = new System.Windows.Forms.Label();
            this.com_module = new System.Windows.Forms.ComboBox();
            this.com_room = new System.Windows.Forms.ComboBox();
            this.dtp_start_time = new System.Windows.Forms.DateTimePicker();
            this.dtp_end_time = new System.Windows.Forms.DateTimePicker();
            this.ldate = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_timetable)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.Info;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(591, 175);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(104, 40);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // t_search
            // 
            this.t_search.Location = new System.Drawing.Point(282, 198);
            this.t_search.Name = "t_search";
            this.t_search.Size = new System.Drawing.Size(272, 20);
            this.t_search.TabIndex = 1;
            // 
            // dgv_timetable
            // 
            this.dgv_timetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_timetable.Location = new System.Drawing.Point(88, 231);
            this.dgv_timetable.Name = "dgv_timetable";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dgv_timetable.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_timetable.Size = new System.Drawing.Size(466, 193);
            this.dgv_timetable.TabIndex = 2;
            this.dgv_timetable.SelectionChanged += new System.EventHandler(this.dgv_timetable_SelectionChanged);
            // 
            // start_time
            // 
            this.start_time.AutoSize = true;
            this.start_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_time.Location = new System.Drawing.Point(104, 123);
            this.start_time.Name = "start_time";
            this.start_time.Size = new System.Drawing.Size(68, 16);
            this.start_time.TabIndex = 7;
            this.start_time.Text = "Start Time";
            // 
            // end_time
            // 
            this.end_time.AutoSize = true;
            this.end_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_time.Location = new System.Drawing.Point(107, 163);
            this.end_time.Name = "end_time";
            this.end_time.Size = new System.Drawing.Size(65, 16);
            this.end_time.TabIndex = 8;
            this.end_time.Text = "End Time";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.Info;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(591, 246);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(104, 40);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.SystemColors.Info;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(591, 315);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(104, 40);
            this.btn_edit.TabIndex = 10;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.Info;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(591, 384);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(104, 40);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_module_name
            // 
            this.lbl_module_name.AutoSize = true;
            this.lbl_module_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_module_name.Location = new System.Drawing.Point(104, 18);
            this.lbl_module_name.Name = "lbl_module_name";
            this.lbl_module_name.Size = new System.Drawing.Size(92, 16);
            this.lbl_module_name.TabIndex = 12;
            this.lbl_module_name.Text = "Module Name";
            // 
            // lbl_room_name
            // 
            this.lbl_room_name.AutoSize = true;
            this.lbl_room_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_room_name.Location = new System.Drawing.Point(104, 56);
            this.lbl_room_name.Name = "lbl_room_name";
            this.lbl_room_name.Size = new System.Drawing.Size(84, 16);
            this.lbl_room_name.TabIndex = 14;
            this.lbl_room_name.Text = "Room Name";
            // 
            // lsearch
            // 
            this.lsearch.AutoSize = true;
            this.lsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsearch.Location = new System.Drawing.Point(107, 198);
            this.lsearch.Name = "lsearch";
            this.lsearch.Size = new System.Drawing.Size(50, 16);
            this.lsearch.TabIndex = 16;
            this.lsearch.Text = "Search";
            // 
            // com_module
            // 
            this.com_module.FormattingEnabled = true;
            this.com_module.Location = new System.Drawing.Point(282, 18);
            this.com_module.Name = "com_module";
            this.com_module.Size = new System.Drawing.Size(272, 21);
            this.com_module.TabIndex = 17;
            // 
            // com_room
            // 
            this.com_room.FormattingEnabled = true;
            this.com_room.Location = new System.Drawing.Point(282, 56);
            this.com_room.Name = "com_room";
            this.com_room.Size = new System.Drawing.Size(272, 21);
            this.com_room.TabIndex = 18;
            // 
            // dtp_start_time
            // 
            this.dtp_start_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_start_time.Location = new System.Drawing.Point(282, 123);
            this.dtp_start_time.Name = "dtp_start_time";
            this.dtp_start_time.Size = new System.Drawing.Size(272, 20);
            this.dtp_start_time.TabIndex = 19;
            this.dtp_start_time.Value = new System.DateTime(2025, 6, 17, 15, 37, 0, 0);
            // 
            // dtp_end_time
            // 
            this.dtp_end_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_end_time.Location = new System.Drawing.Point(282, 163);
            this.dtp_end_time.Name = "dtp_end_time";
            this.dtp_end_time.Size = new System.Drawing.Size(272, 20);
            this.dtp_end_time.TabIndex = 20;
            this.dtp_end_time.Value = new System.DateTime(2025, 6, 17, 15, 52, 2, 0);
            // 
            // ldate
            // 
            this.ldate.AutoSize = true;
            this.ldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldate.Location = new System.Drawing.Point(104, 92);
            this.ldate.Name = "ldate";
            this.ldate.Size = new System.Drawing.Size(36, 16);
            this.ldate.TabIndex = 21;
            this.ldate.Text = "Date";
            // 
            // dtp_date
            // 
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_date.Location = new System.Drawing.Point(282, 92);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(272, 20);
            this.dtp_date.TabIndex = 22;
            this.dtp_date.Value = new System.DateTime(2025, 6, 17, 15, 37, 0, 0);
            // 
            // Manage_timetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.ldate);
            this.Controls.Add(this.dtp_end_time);
            this.Controls.Add(this.dtp_start_time);
            this.Controls.Add(this.com_room);
            this.Controls.Add(this.com_module);
            this.Controls.Add(this.lsearch);
            this.Controls.Add(this.lbl_room_name);
            this.Controls.Add(this.lbl_module_name);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.end_time);
            this.Controls.Add(this.start_time);
            this.Controls.Add(this.dgv_timetable);
            this.Controls.Add(this.t_search);
            this.Controls.Add(this.btn_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manage_timetable";
            this.Text = "Manage Timetable";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_timetable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox t_search;
        private System.Windows.Forms.DataGridView dgv_timetable;
        private System.Windows.Forms.Label start_time;
        private System.Windows.Forms.Label end_time;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_module_name;
        private System.Windows.Forms.Label lbl_room_name;
        private System.Windows.Forms.Label lsearch;
        private System.Windows.Forms.ComboBox com_module;
        private System.Windows.Forms.ComboBox com_room;
        private System.Windows.Forms.DateTimePicker dtp_start_time;
        private System.Windows.Forms.DateTimePicker dtp_end_time;
        private System.Windows.Forms.Label ldate;
        private System.Windows.Forms.DateTimePicker dtp_date;
    }
}