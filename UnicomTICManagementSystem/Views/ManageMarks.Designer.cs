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
            this.lscore = new System.Windows.Forms.Label();
            this.lresult = new System.Windows.Forms.Label();
            this.tscore = new System.Windows.Forms.TextBox();
            this.tresult = new System.Windows.Forms.TextBox();
            this.dgv_result = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).BeginInit();
            this.SuspendLayout();
            // 
            // lscore
            // 
            this.lscore.AutoSize = true;
            this.lscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lscore.Location = new System.Drawing.Point(81, 83);
            this.lscore.Name = "lscore";
            this.lscore.Size = new System.Drawing.Size(48, 18);
            this.lscore.TabIndex = 0;
            this.lscore.Text = "Score";
            // 
            // lresult
            // 
            this.lresult.AutoSize = true;
            this.lresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lresult.Location = new System.Drawing.Point(81, 144);
            this.lresult.Name = "lresult";
            this.lresult.Size = new System.Drawing.Size(50, 18);
            this.lresult.TabIndex = 1;
            this.lresult.Text = "Result";
            // 
            // tscore
            // 
            this.tscore.Location = new System.Drawing.Point(167, 84);
            this.tscore.Name = "tscore";
            this.tscore.Size = new System.Drawing.Size(170, 20);
            this.tscore.TabIndex = 2;
            // 
            // tresult
            // 
            this.tresult.Location = new System.Drawing.Point(167, 141);
            this.tresult.Name = "tresult";
            this.tresult.Size = new System.Drawing.Size(170, 20);
            this.tresult.TabIndex = 3;
            // 
            // dgv_result
            // 
            this.dgv_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_result.Location = new System.Drawing.Point(110, 266);
            this.dgv_result.Name = "dgv_result";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dgv_result.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_result.Size = new System.Drawing.Size(587, 150);
            this.dgv_result.TabIndex = 4;
            this.dgv_result.SelectionChanged += new System.EventHandler(this.dgv_result_SelectionChanged);
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(125, 216);
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
            this.btn_edit.Location = new System.Drawing.Point(341, 211);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(112, 35);
            this.btn_edit.TabIndex = 6;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(566, 211);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(114, 40);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // ManageMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_delete);
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
        private System.Windows.Forms.Button btn_delete;
    }
}