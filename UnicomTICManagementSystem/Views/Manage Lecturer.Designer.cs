namespace UnicomTICManagementSystem.Views
{
    partial class Manage_lecturer
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
            this.dgview_lectures = new System.Windows.Forms.DataGridView();
            this.tnumber = new System.Windows.Forms.TextBox();
            this.lphonenumber = new System.Windows.Forms.Label();
            this.laddress = new System.Windows.Forms.Label();
            this.taddress = new System.Windows.Forms.TextBox();
            this.tname = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.lemail = new System.Windows.Forms.Label();
            this.temail = new System.Windows.Forms.TextBox();
            this.tsearch = new System.Windows.Forms.TextBox();
            this.l_search = new System.Windows.Forms.Label();
            this.lusername = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_lectures)).BeginInit();
            this.SuspendLayout();
            // 
            // dgview_lectures
            // 
            this.dgview_lectures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview_lectures.Location = new System.Drawing.Point(89, 255);
            this.dgview_lectures.Name = "dgview_lectures";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dgview_lectures.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgview_lectures.Size = new System.Drawing.Size(502, 206);
            this.dgview_lectures.TabIndex = 27;
            this.dgview_lectures.SelectionChanged += new System.EventHandler(this.dgview_lectures_SelectionChanged);
            // 
            // tnumber
            // 
            this.tnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnumber.Location = new System.Drawing.Point(309, 140);
            this.tnumber.Name = "tnumber";
            this.tnumber.Size = new System.Drawing.Size(251, 22);
            this.tnumber.TabIndex = 39;
            // 
            // lphonenumber
            // 
            this.lphonenumber.AutoSize = true;
            this.lphonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lphonenumber.Location = new System.Drawing.Point(146, 142);
            this.lphonenumber.Name = "lphonenumber";
            this.lphonenumber.Size = new System.Drawing.Size(108, 18);
            this.lphonenumber.TabIndex = 38;
            this.lphonenumber.Text = "Phone Number";
            // 
            // laddress
            // 
            this.laddress.AutoSize = true;
            this.laddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laddress.Location = new System.Drawing.Point(146, 100);
            this.laddress.Name = "laddress";
            this.laddress.Size = new System.Drawing.Size(62, 18);
            this.laddress.TabIndex = 37;
            this.laddress.Text = "Address";
            // 
            // taddress
            // 
            this.taddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taddress.Location = new System.Drawing.Point(309, 98);
            this.taddress.Name = "taddress";
            this.taddress.Size = new System.Drawing.Size(251, 22);
            this.taddress.TabIndex = 36;
            // 
            // tname
            // 
            this.tname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tname.Location = new System.Drawing.Point(309, 62);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(251, 22);
            this.tname.TabIndex = 35;
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.Location = new System.Drawing.Point(146, 64);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(48, 18);
            this.lname.TabIndex = 34;
            this.lname.Text = "Name";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(608, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 38);
            this.button2.TabIndex = 33;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_click);
            // 
            // btn_edit
            // 
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(608, 356);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(102, 35);
            this.btn_edit.TabIndex = 32;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(608, 416);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(102, 35);
            this.btn_delete.TabIndex = 31;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(608, 298);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(102, 35);
            this.btn_add.TabIndex = 30;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lemail
            // 
            this.lemail.AutoSize = true;
            this.lemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lemail.Location = new System.Drawing.Point(146, 180);
            this.lemail.Name = "lemail";
            this.lemail.Size = new System.Drawing.Size(45, 18);
            this.lemail.TabIndex = 43;
            this.lemail.Text = "Email";
            // 
            // temail
            // 
            this.temail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temail.Location = new System.Drawing.Point(309, 178);
            this.temail.Name = "temail";
            this.temail.Size = new System.Drawing.Size(251, 22);
            this.temail.TabIndex = 44;
            // 
            // tsearch
            // 
            this.tsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsearch.Location = new System.Drawing.Point(309, 215);
            this.tsearch.Name = "tsearch";
            this.tsearch.Size = new System.Drawing.Size(251, 22);
            this.tsearch.TabIndex = 45;
            // 
            // l_search
            // 
            this.l_search.AutoSize = true;
            this.l_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_search.Location = new System.Drawing.Point(146, 217);
            this.l_search.Name = "l_search";
            this.l_search.Size = new System.Drawing.Size(55, 18);
            this.l_search.TabIndex = 46;
            this.l_search.Text = "Search";
            // 
            // lusername
            // 
            this.lusername.AutoSize = true;
            this.lusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lusername.Location = new System.Drawing.Point(146, 25);
            this.lusername.Name = "lusername";
            this.lusername.Size = new System.Drawing.Size(77, 18);
            this.lusername.TabIndex = 47;
            this.lusername.Text = "Username";
            // 
            // user_name
            // 
            this.user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name.FormattingEnabled = true;
            this.user_name.Location = new System.Drawing.Point(309, 22);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(251, 24);
            this.user_name.TabIndex = 48;
            // 
            // Manage_lecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.lusername);
            this.Controls.Add(this.l_search);
            this.Controls.Add(this.tsearch);
            this.Controls.Add(this.temail);
            this.Controls.Add(this.lemail);
            this.Controls.Add(this.tnumber);
            this.Controls.Add(this.lphonenumber);
            this.Controls.Add(this.laddress);
            this.Controls.Add(this.taddress);
            this.Controls.Add(this.tname);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgview_lectures);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manage_lecturer";
            this.Text = "Manage Lecturer";
            ((System.ComponentModel.ISupportInitialize)(this.dgview_lectures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgview_lectures;
        private System.Windows.Forms.TextBox tnumber;
        private System.Windows.Forms.Label lphonenumber;
        private System.Windows.Forms.Label laddress;
        private System.Windows.Forms.TextBox taddress;
        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lemail;
        private System.Windows.Forms.TextBox temail;
        private System.Windows.Forms.TextBox tsearch;
        private System.Windows.Forms.Label l_search;
        private System.Windows.Forms.Label lusername;
        private System.Windows.Forms.ComboBox user_name;
    }
}