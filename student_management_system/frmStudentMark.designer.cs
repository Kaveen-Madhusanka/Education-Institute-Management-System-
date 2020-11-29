namespace StudentManagementSystem
{
    partial class frmStudentMark
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
            this.lblStudentId = new System.Windows.Forms.Label();
            this.lblSubjectd = new System.Windows.Forms.Label();
            this.lblMarks = new System.Windows.Forms.Label();
            this.dgvStudentMark = new System.Windows.Forms.DataGridView();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMarks = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentMark)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(49, 73);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(62, 13);
            this.lblStudentId.TabIndex = 0;
            this.lblStudentId.Text = "Student Id :";
            // 
            // lblSubjectd
            // 
            this.lblSubjectd.AutoSize = true;
            this.lblSubjectd.Location = new System.Drawing.Point(49, 101);
            this.lblSubjectd.Name = "lblSubjectd";
            this.lblSubjectd.Size = new System.Drawing.Size(49, 13);
            this.lblSubjectd.TabIndex = 1;
            this.lblSubjectd.Text = "Subject :";
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Location = new System.Drawing.Point(49, 130);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(42, 13);
            this.lblMarks.TabIndex = 2;
            this.lblMarks.Text = "Marks :";
            // 
            // dgvStudentMark
            // 
            this.dgvStudentMark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentMark.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentId,
            this.SubjectName,
            this.Marks});
            this.dgvStudentMark.Location = new System.Drawing.Point(262, 73);
            this.dgvStudentMark.Name = "dgvStudentMark";
            this.dgvStudentMark.Size = new System.Drawing.Size(422, 234);
            this.dgvStudentMark.TabIndex = 9;
            this.dgvStudentMark.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentMark_CellClick);
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.HeaderText = "Student Id";
            this.StudentId.Name = "StudentId";
            this.StudentId.Width = 130;
            // 
            // SubjectName
            // 
            this.SubjectName.DataPropertyName = "SubjectName";
            this.SubjectName.HeaderText = "Subject Name";
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.Width = 130;
            // 
            // Marks
            // 
            this.Marks.DataPropertyName = "Marks";
            this.Marks.HeaderText = "Marks";
            this.Marks.Name = "Marks";
            this.Marks.Width = 130;
            // 
            // txtMarks
            // 
            this.txtMarks.Location = new System.Drawing.Point(136, 127);
            this.txtMarks.MaxLength = 3;
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(100, 20);
            this.txtMarks.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(214, 360);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(133, 360);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(52, 360);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(528, 47);
            this.txtSearch.MaxLength = 8;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(156, 20);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(480, 50);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(47, 13);
            this.lblSearch.TabIndex = 13;
            this.lblSearch.Text = "Search :";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(528, 360);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(609, 360);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(136, 100);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(100, 21);
            this.cmbSubject.TabIndex = 1;
            this.cmbSubject.SelectedIndexChanged += new System.EventHandler(this.cmbSubject_SelectedIndexChanged);
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(136, 70);
            this.txtStudentId.MaxLength = 8;
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(100, 20);
            this.txtStudentId.TabIndex = 0;
            this.txtStudentId.TextChanged += new System.EventHandler(this.txtStudentId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Sudent Mark Form";
            // 
            // frmStudentMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 395);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtMarks);
            this.Controls.Add(this.dgvStudentMark);
            this.Controls.Add(this.lblMarks);
            this.Controls.Add(this.lblSubjectd);
            this.Controls.Add(this.lblStudentId);
            this.Name = "frmStudentMark";
            this.Text = "frmStudentMark";
            this.Load += new System.EventHandler(this.frmStudentMark_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentMark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label lblSubjectd;
        private System.Windows.Forms.Label lblMarks;
        private System.Windows.Forms.DataGridView dgvStudentMark;
        private System.Windows.Forms.TextBox txtMarks;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marks;
        private System.Windows.Forms.Label label1;
    }
}