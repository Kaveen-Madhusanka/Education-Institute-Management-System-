namespace StudentManagementSystem
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentMarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.SubjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblStudenName = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Orange;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gradeToolStripMenuItem,
            this.subjectsToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.studentMarkToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(657, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gradeToolStripMenuItem
            // 
            this.gradeToolStripMenuItem.Name = "gradeToolStripMenuItem";
            this.gradeToolStripMenuItem.Size = new System.Drawing.Size(67, 25);
            this.gradeToolStripMenuItem.Text = "Grade";
            this.gradeToolStripMenuItem.Click += new System.EventHandler(this.gradeToolStripMenuItem_Click);
            // 
            // subjectsToolStripMenuItem
            // 
            this.subjectsToolStripMenuItem.Name = "subjectsToolStripMenuItem";
            this.subjectsToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.subjectsToolStripMenuItem.Text = "Subjects";
            this.subjectsToolStripMenuItem.Click += new System.EventHandler(this.subjectsToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
            this.studentToolStripMenuItem.Text = "Student";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // studentMarkToolStripMenuItem
            // 
            this.studentMarkToolStripMenuItem.Name = "studentMarkToolStripMenuItem";
            this.studentMarkToolStripMenuItem.Size = new System.Drawing.Size(125, 25);
            this.studentMarkToolStripMenuItem.Text = "Student Mark";
            this.studentMarkToolStripMenuItem.Click += new System.EventHandler(this.studentMarkToolStripMenuItem_Click);
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(125, 61);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(175, 20);
            this.txtStudentName.TabIndex = 1;
            this.txtStudentName.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(316, 59);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubjectId,
            this.SubjectName,
            this.Mark,
            this.Grade});
            this.dgvMain.Location = new System.Drawing.Point(32, 120);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.Size = new System.Drawing.Size(548, 182);
            this.dgvMain.TabIndex = 3;
            // 
            // SubjectId
            // 
            this.SubjectId.DataPropertyName = "SubjectId";
            this.SubjectId.HeaderText = "Subject Id";
            this.SubjectId.Name = "SubjectId";
            // 
            // SubjectName
            // 
            this.SubjectName.DataPropertyName = "SubjectName";
            this.SubjectName.HeaderText = "Subject Name";
            this.SubjectName.Name = "SubjectName";
            // 
            // Mark
            // 
            this.Mark.DataPropertyName = "Marks";
            this.Mark.HeaderText = "Mark";
            this.Mark.Name = "Mark";
            // 
            // Grade
            // 
            this.Grade.DataPropertyName = "Grade";
            this.Grade.HeaderText = "Grade";
            this.Grade.Name = "Grade";
            // 
            // lblStudenName
            // 
            this.lblStudenName.AutoSize = true;
            this.lblStudenName.Location = new System.Drawing.Point(29, 64);
            this.lblStudenName.Name = "lblStudenName";
            this.lblStudenName.Size = new System.Drawing.Size(62, 13);
            this.lblStudenName.TabIndex = 4;
            this.lblStudenName.Text = "Student Id :";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 407);
            this.Controls.Add(this.lblStudenName);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gradeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentMarkToolStripMenuItem;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Label lblStudenName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mark;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
    }
}