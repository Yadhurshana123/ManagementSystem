namespace UnicomTICManagementSystem.Views
{
    partial class Manage_staff
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
            this.tsearch = new System.Windows.Forms.TextBox();
            this.temail = new System.Windows.Forms.TextBox();
            this.lemail = new System.Windows.Forms.Label();
            this.tnumber = new System.Windows.Forms.TextBox();
            this.lphonenumber = new System.Windows.Forms.Label();
            this.laddress = new System.Windows.Forms.Label();
            this.taddress = new System.Windows.Forms.TextBox();
            this.tname = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dgview_staffs = new System.Windows.Forms.DataGridView();
            this.user_name = new System.Windows.Forms.Label();
            this.lsearch = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_staffs)).BeginInit();
            this.SuspendLayout();
            // 
            // tsearch
            // 
            this.tsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsearch.Location = new System.Drawing.Point(310, 239);
            this.tsearch.Name = "tsearch";
            this.tsearch.Size = new System.Drawing.Size(251, 22);
            this.tsearch.TabIndex = 59;
            this.tsearch.TextChanged += new System.EventHandler(this.tsearch_TextChanged);
            // 
            // temail
            // 
            this.temail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temail.Location = new System.Drawing.Point(310, 191);
            this.temail.Name = "temail";
            this.temail.Size = new System.Drawing.Size(251, 22);
            this.temail.TabIndex = 58;
            // 
            // lemail
            // 
            this.lemail.AutoSize = true;
            this.lemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lemail.Location = new System.Drawing.Point(156, 193);
            this.lemail.Name = "lemail";
            this.lemail.Size = new System.Drawing.Size(45, 18);
            this.lemail.TabIndex = 57;
            this.lemail.Text = "Email";
            // 
            // tnumber
            // 
            this.tnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnumber.Location = new System.Drawing.Point(310, 150);
            this.tnumber.Name = "tnumber";
            this.tnumber.Size = new System.Drawing.Size(251, 22);
            this.tnumber.TabIndex = 56;
            // 
            // lphonenumber
            // 
            this.lphonenumber.AutoSize = true;
            this.lphonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lphonenumber.Location = new System.Drawing.Point(156, 149);
            this.lphonenumber.Name = "lphonenumber";
            this.lphonenumber.Size = new System.Drawing.Size(108, 18);
            this.lphonenumber.TabIndex = 55;
            this.lphonenumber.Text = "Phone Number";
            // 
            // laddress
            // 
            this.laddress.AutoSize = true;
            this.laddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laddress.Location = new System.Drawing.Point(156, 104);
            this.laddress.Name = "laddress";
            this.laddress.Size = new System.Drawing.Size(62, 18);
            this.laddress.TabIndex = 54;
            this.laddress.Text = "Address";
            // 
            // taddress
            // 
            this.taddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taddress.Location = new System.Drawing.Point(310, 102);
            this.taddress.Name = "taddress";
            this.taddress.Size = new System.Drawing.Size(251, 22);
            this.taddress.TabIndex = 53;
            // 
            // tname
            // 
            this.tname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tname.Location = new System.Drawing.Point(310, 57);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(251, 22);
            this.tname.TabIndex = 52;
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.Location = new System.Drawing.Point(156, 59);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(48, 18);
            this.lname.TabIndex = 51;
            this.lname.Text = "Name";
            this.lname.Click += new System.EventHandler(this.lname_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(618, 371);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(102, 35);
            this.btn_edit.TabIndex = 49;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(618, 455);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(102, 35);
            this.btn_delete.TabIndex = 48;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(618, 284);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(102, 35);
            this.btn_add.TabIndex = 47;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dgview_staffs
            // 
            this.dgview_staffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview_staffs.Location = new System.Drawing.Point(84, 284);
            this.dgview_staffs.Name = "dgview_staffs";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dgview_staffs.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgview_staffs.Size = new System.Drawing.Size(502, 206);
            this.dgview_staffs.TabIndex = 46;
            this.dgview_staffs.SelectionChanged += new System.EventHandler(this.dgview_staffs_SelectionChanged);
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name.Location = new System.Drawing.Point(156, 15);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(77, 18);
            this.user_name.TabIndex = 60;
            this.user_name.Text = "Username";
            // 
            // lsearch
            // 
            this.lsearch.AutoSize = true;
            this.lsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsearch.Location = new System.Drawing.Point(156, 241);
            this.lsearch.Name = "lsearch";
            this.lsearch.Size = new System.Drawing.Size(55, 18);
            this.lsearch.TabIndex = 61;
            this.lsearch.Text = "Search";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.FormattingEnabled = true;
            this.username.Location = new System.Drawing.Point(310, 12);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(251, 24);
            this.username.TabIndex = 62;
            // 
            // Manage_staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(837, 578);
            this.Controls.Add(this.username);
            this.Controls.Add(this.lsearch);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.tsearch);
            this.Controls.Add(this.temail);
            this.Controls.Add(this.lemail);
            this.Controls.Add(this.tnumber);
            this.Controls.Add(this.lphonenumber);
            this.Controls.Add(this.laddress);
            this.Controls.Add(this.taddress);
            this.Controls.Add(this.tname);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgview_staffs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manage_staff";
            this.Text = "Manage Staff";
            ((System.ComponentModel.ISupportInitialize)(this.dgview_staffs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tsearch;
        private System.Windows.Forms.TextBox temail;
        private System.Windows.Forms.Label lemail;
        private System.Windows.Forms.TextBox tnumber;
        private System.Windows.Forms.Label lphonenumber;
        private System.Windows.Forms.Label laddress;
        private System.Windows.Forms.TextBox taddress;
        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dgview_staffs;
        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.Label lsearch;
        private System.Windows.Forms.ComboBox username;
    }
}