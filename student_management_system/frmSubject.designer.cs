namespace StudentManagementSystem
{
    partial class frmSubject
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSubjectId = new System.Windows.Forms.Label();
            this.lblSubjectName = new System.Windows.Forms.Label();
            this.txtSubjectId = new System.Windows.Forms.TextBox();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dgvSubject = new System.Windows.Forms.DataGridView();
            this.SubjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(597, 349);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblSubjectId
            // 
            this.lblSubjectId.AutoSize = true;
            this.lblSubjectId.Location = new System.Drawing.Point(32, 65);
            this.lblSubjectId.Name = "lblSubjectId";
            this.lblSubjectId.Size = new System.Drawing.Size(61, 13);
            this.lblSubjectId.TabIndex = 9;
            this.lblSubjectId.Text = "Subject Id :";
            // 
            // lblSubjectName
            // 
            this.lblSubjectName.AutoSize = true;
            this.lblSubjectName.Location = new System.Drawing.Point(32, 94);
            this.lblSubjectName.Name = "lblSubjectName";
            this.lblSubjectName.Size = new System.Drawing.Size(80, 13);
            this.lblSubjectName.TabIndex = 10;
            this.lblSubjectName.Text = "Subject Name :";
            // 
            // txtSubjectId
            // 
            this.txtSubjectId.Location = new System.Drawing.Point(130, 62);
            this.txtSubjectId.MaxLength = 5;
            this.txtSubjectId.Name = "txtSubjectId";
            this.txtSubjectId.Size = new System.Drawing.Size(100, 20);
            this.txtSubjectId.TabIndex = 0;
            this.txtSubjectId.Leave += new System.EventHandler(this.txtSubjectId_Leave);
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Location = new System.Drawing.Point(130, 91);
            this.txtSubjectName.MaxLength = 50;
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(100, 20);
            this.txtSubjectName.TabIndex = 1;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(35, 349);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dgvSubject
            // 
            this.dgvSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubjectId,
            this.SubjectName});
            this.dgvSubject.Location = new System.Drawing.Point(266, 62);
            this.dgvSubject.Name = "dgvSubject";
            this.dgvSubject.Size = new System.Drawing.Size(406, 203);
            this.dgvSubject.TabIndex = 8;
            this.dgvSubject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubject_CellClick);
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
            this.SubjectName.Width = 250;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(116, 349);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(197, 349);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(516, 349);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(468, 35);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(47, 13);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "Search :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(516, 32);
            this.txtSearch.MaxLength = 5;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(156, 20);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Subject Form";
            // 
            // frmSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 384);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvSubject);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtSubjectName);
            this.Controls.Add(this.txtSubjectId);
            this.Controls.Add(this.lblSubjectName);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblSubjectId);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Name = "frmSubject";
            this.Text = "Subject";
            this.Load += new System.EventHandler(this.frmSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSubjectId;
        private System.Windows.Forms.Label lblSubjectName;
        private System.Windows.Forms.TextBox txtSubjectId;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dgvSubject;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.Label label1;
    }
}