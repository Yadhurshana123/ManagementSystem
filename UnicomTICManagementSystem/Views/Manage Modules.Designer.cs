namespace UnicomTICManagementSystem.Views
{
    partial class Manage_Modules
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.t_search = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lmodules = new System.Windows.Forms.Label();
            this.tmodule = new System.Windows.Forms.TextBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dgview_modules = new System.Windows.Forms.DataGridView();
            this.lcourses = new System.Windows.Forms.Label();
            this.course_name = new System.Windows.Forms.ComboBox();
            this.lsearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_modules)).BeginInit();
            this.SuspendLayout();
            // 
            // t_search
            // 
            this.t_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_search.Location = new System.Drawing.Point(360, 129);
            this.t_search.Name = "t_search";
            this.t_search.Size = new System.Drawing.Size(251, 22);
            this.t_search.TabIndex = 88;
            this.t_search.TextChanged += new System.EventHandler(this.t_search_TextChanged);
            // 
            // btn_delete
            // 
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(524, 172);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(102, 35);
            this.btn_delete.TabIndex = 87;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lmodules
            // 
            this.lmodules.AutoSize = true;
            this.lmodules.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lmodules.Location = new System.Drawing.Point(228, 81);
            this.lmodules.Name = "lmodules";
            this.lmodules.Size = new System.Drawing.Size(65, 18);
            this.lmodules.TabIndex = 86;
            this.lmodules.Text = "Modules";
            // 
            // tmodule
            // 
            this.tmodule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmodule.Location = new System.Drawing.Point(360, 80);
            this.tmodule.Name = "tmodule";
            this.tmodule.Size = new System.Drawing.Size(251, 22);
            this.tmodule.TabIndex = 85;
            // 
            // btn_edit
            // 
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(373, 172);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(102, 35);
            this.btn_edit.TabIndex = 84;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(231, 172);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(102, 35);
            this.btn_add.TabIndex = 83;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dgview_modules
            // 
            this.dgview_modules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview_modules.Location = new System.Drawing.Point(183, 223);
            this.dgview_modules.Name = "dgview_modules";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dgview_modules.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgview_modules.Size = new System.Drawing.Size(502, 206);
            this.dgview_modules.TabIndex = 82;
            this.dgview_modules.SelectionChanged += new System.EventHandler(this.dgview_modules_SelectionChanged);
            // 
            // lcourses
            // 
            this.lcourses.AutoSize = true;
            this.lcourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcourses.Location = new System.Drawing.Point(228, 27);
            this.lcourses.Name = "lcourses";
            this.lcourses.Size = new System.Drawing.Size(65, 18);
            this.lcourses.TabIndex = 90;
            this.lcourses.Text = "Courses";
            // 
            // course_name
            // 
            this.course_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_name.FormattingEnabled = true;
            this.course_name.Location = new System.Drawing.Point(360, 24);
            this.course_name.Name = "course_name";
            this.course_name.Size = new System.Drawing.Size(251, 24);
            this.course_name.TabIndex = 91;
            // 
            // lsearch
            // 
            this.lsearch.AutoSize = true;
            this.lsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsearch.Location = new System.Drawing.Point(228, 131);
            this.lsearch.Name = "lsearch";
            this.lsearch.Size = new System.Drawing.Size(55, 18);
            this.lsearch.TabIndex = 92;
            this.lsearch.Text = "Search";
            // 
            // Manage_Modules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsearch);
            this.Controls.Add(this.course_name);
            this.Controls.Add(this.lcourses);
            this.Controls.Add(this.t_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.lmodules);
            this.Controls.Add(this.tmodule);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgview_modules);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manage_Modules";
            this.Text = "Manage_Modules";
            ((System.ComponentModel.ISupportInitialize)(this.dgview_modules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox t_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lmodules;
        private System.Windows.Forms.TextBox tmodule;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dgview_modules;
        private System.Windows.Forms.Label lcourses;
        private System.Windows.Forms.ComboBox course_name;
        private System.Windows.Forms.Label lsearch;
    }
}