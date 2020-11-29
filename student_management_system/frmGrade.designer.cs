namespace StudentManagementSystem
{
    partial class frmGrade
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblLowrLimit = new System.Windows.Forms.Label();
            this.lblUpperLimit = new System.Windows.Forms.Label();
            this.txtGradeId = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtLowerLimit = new System.Windows.Forms.TextBox();
            this.txtUpperLimit = new System.Windows.Forms.TextBox();
            this.lblGradeId = new System.Windows.Forms.Label();
            this.dgvGrade = new System.Windows.Forms.DataGridView();
            this.GradeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LowerLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpperLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.lblSubjectd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(40, 105);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(66, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description :";
            // 
            // lblLowrLimit
            // 
            this.lblLowrLimit.AutoSize = true;
            this.lblLowrLimit.Location = new System.Drawing.Point(40, 138);
            this.lblLowrLimit.Name = "lblLowrLimit";
            this.lblLowrLimit.Size = new System.Drawing.Size(66, 13);
            this.lblLowrLimit.TabIndex = 2;
            this.lblLowrLimit.Text = "Lower Limit :";
            // 
            // lblUpperLimit
            // 
            this.lblUpperLimit.AutoSize = true;
            this.lblUpperLimit.Location = new System.Drawing.Point(40, 170);
            this.lblUpperLimit.Name = "lblUpperLimit";
            this.lblUpperLimit.Size = new System.Drawing.Size(66, 13);
            this.lblUpperLimit.TabIndex = 3;
            this.lblUpperLimit.Text = "Upper Limit :";
            // 
            // txtGradeId
            // 
            this.txtGradeId.Location = new System.Drawing.Point(170, 73);
            this.txtGradeId.Name = "txtGradeId";
            this.txtGradeId.Size = new System.Drawing.Size(100, 20);
            this.txtGradeId.TabIndex = 1;
            this.txtGradeId.Leave += new System.EventHandler(this.txtGradeId_Leave);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(170, 102);
            this.txtDescription.MaxLength = 50;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDescription.TabIndex = 2;
            // 
            // txtLowerLimit
            // 
            this.txtLowerLimit.Location = new System.Drawing.Point(170, 135);
            this.txtLowerLimit.Name = "txtLowerLimit";
            this.txtLowerLimit.Size = new System.Drawing.Size(100, 20);
            this.txtLowerLimit.TabIndex = 3;
            this.txtLowerLimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLowerLimit_KeyPress);
            // 
            // txtUpperLimit
            // 
            this.txtUpperLimit.Location = new System.Drawing.Point(170, 167);
            this.txtUpperLimit.Name = "txtUpperLimit";
            this.txtUpperLimit.Size = new System.Drawing.Size(100, 20);
            this.txtUpperLimit.TabIndex = 4;
            this.txtUpperLimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpperLimit_KeyPress);
            // 
            // lblGradeId
            // 
            this.lblGradeId.AutoSize = true;
            this.lblGradeId.Location = new System.Drawing.Point(40, 76);
            this.lblGradeId.Name = "lblGradeId";
            this.lblGradeId.Size = new System.Drawing.Size(56, 13);
            this.lblGradeId.TabIndex = 1;
            this.lblGradeId.Text = "Grade ID :";
            // 
            // dgvGrade
            // 
            this.dgvGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GradeId,
            this.Description,
            this.LowerLimit,
            this.UpperLimit});
            this.dgvGrade.Location = new System.Drawing.Point(309, 73);
            this.dgvGrade.Name = "dgvGrade";
            this.dgvGrade.Size = new System.Drawing.Size(515, 283);
            this.dgvGrade.TabIndex = 11;
            this.dgvGrade.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrade_CellClick);
            // 
            // GradeId
            // 
            this.GradeId.DataPropertyName = "GradeId";
            this.GradeId.HeaderText = "Grade Id";
            this.GradeId.Name = "GradeId";
            this.GradeId.Width = 120;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Width = 160;
            // 
            // LowerLimit
            // 
            this.LowerLimit.DataPropertyName = "LowerLimit";
            this.LowerLimit.HeaderText = "Lower Limit";
            this.LowerLimit.Name = "LowerLimit";
            // 
            // UpperLimit
            // 
            this.UpperLimit.DataPropertyName = "UpperLimit";
            this.UpperLimit.HeaderText = "Upper Limit";
            this.UpperLimit.Name = "UpperLimit";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(47, 400);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(668, 400);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(128, 400);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(209, 400);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(749, 400);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(599, 41);
            this.txtSearch.MaxLength = 5;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(225, 20);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(522, 44);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(47, 13);
            this.lblSearch.TabIndex = 19;
            this.lblSearch.Text = "Search :";
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(170, 45);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(100, 21);
            this.cmbSubject.TabIndex = 0;
            this.cmbSubject.SelectedIndexChanged += new System.EventHandler(this.cmbSubject_SelectedIndexChanged);
            // 
            // lblSubjectd
            // 
            this.lblSubjectd.AutoSize = true;
            this.lblSubjectd.Location = new System.Drawing.Point(40, 48);
            this.lblSubjectd.Name = "lblSubjectd";
            this.lblSubjectd.Size = new System.Drawing.Size(49, 13);
            this.lblSubjectd.TabIndex = 21;
            this.lblSubjectd.Text = "Subject :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Grade Form";
            // 
            // frmGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 435);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.lblSubjectd);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dgvGrade);
            this.Controls.Add(this.txtUpperLimit);
            this.Controls.Add(this.txtLowerLimit);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtGradeId);
            this.Controls.Add(this.lblUpperLimit);
            this.Controls.Add(this.lblLowrLimit);
            this.Controls.Add(this.lblGradeId);
            this.Controls.Add(this.lblDescription);
            this.Name = "frmGrade";
            this.Text = "frmGrade";
            this.Load += new System.EventHandler(this.frmGrade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblLowrLimit;
        private System.Windows.Forms.Label lblUpperLimit;
        private System.Windows.Forms.TextBox txtGradeId;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtLowerLimit;
        private System.Windows.Forms.TextBox txtUpperLimit;
        private System.Windows.Forms.Label lblGradeId;
        private System.Windows.Forms.DataGridView dgvGrade;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn LowerLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpperLimit;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.Label lblSubjectd;
        private System.Windows.Forms.Label label1;
    }
}