namespace StudentManagementSystem
{
    partial class frmStudent
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblAddressLine1 = new System.Windows.Forms.Label();
            this.lblAddressLine2 = new System.Windows.Forms.Label();
            this.lblAddressLine3 = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.txtFiestName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtAddress3 = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateodBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressLine1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressLine2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressLine3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(33, 48);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(62, 13);
            this.lblStudentId.TabIndex = 0;
            this.lblStudentId.Text = "Student Id :";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(33, 74);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(63, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name :";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(33, 103);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(64, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name :";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(33, 129);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(74, 13);
            this.lblDateOfBirth.TabIndex = 3;
            this.lblDateOfBirth.Text = "Date Of Birth :";
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.AutoSize = true;
            this.lblAddressLine1.Location = new System.Drawing.Point(33, 155);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Size = new System.Drawing.Size(83, 13);
            this.lblAddressLine1.TabIndex = 4;
            this.lblAddressLine1.Text = "Address Line 1 :";
            // 
            // lblAddressLine2
            // 
            this.lblAddressLine2.AutoSize = true;
            this.lblAddressLine2.Location = new System.Drawing.Point(33, 181);
            this.lblAddressLine2.Name = "lblAddressLine2";
            this.lblAddressLine2.Size = new System.Drawing.Size(83, 13);
            this.lblAddressLine2.TabIndex = 5;
            this.lblAddressLine2.Text = "Address Line 2 :";
            // 
            // lblAddressLine3
            // 
            this.lblAddressLine3.AutoSize = true;
            this.lblAddressLine3.Location = new System.Drawing.Point(33, 207);
            this.lblAddressLine3.Name = "lblAddressLine3";
            this.lblAddressLine3.Size = new System.Drawing.Size(83, 13);
            this.lblAddressLine3.TabIndex = 6;
            this.lblAddressLine3.Text = "Address Line 3 :";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(151, 45);
            this.txtStudentId.MaxLength = 8;
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(197, 20);
            this.txtStudentId.TabIndex = 0;
            // 
            // txtFiestName
            // 
            this.txtFiestName.Location = new System.Drawing.Point(151, 74);
            this.txtFiestName.MaxLength = 50;
            this.txtFiestName.Name = "txtFiestName";
            this.txtFiestName.Size = new System.Drawing.Size(197, 20);
            this.txtFiestName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(151, 100);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(197, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(151, 152);
            this.txtAddress1.MaxLength = 100;
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(197, 20);
            this.txtAddress1.TabIndex = 4;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(151, 178);
            this.txtAddress2.MaxLength = 100;
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(197, 20);
            this.txtAddress2.TabIndex = 5;
            // 
            // txtAddress3
            // 
            this.txtAddress3.Location = new System.Drawing.Point(151, 204);
            this.txtAddress3.MaxLength = 100;
            this.txtAddress3.Name = "txtAddress3";
            this.txtAddress3.Size = new System.Drawing.Size(197, 20);
            this.txtAddress3.TabIndex = 6;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(675, 22);
            this.txtSearch.MaxLength = 8;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(138, 20);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(608, 25);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(47, 13);
            this.lblSearch.TabIndex = 22;
            this.lblSearch.Text = "Search :";
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentId,
            this.FirstName,
            this.LastName,
            this.DateodBirth,
            this.AddressLine1,
            this.AddressLine2,
            this.AddressLine3});
            this.dgvStudents.Location = new System.Drawing.Point(415, 48);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(398, 241);
            this.dgvStudents.TabIndex = 13;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);
            this.dgvStudents.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStudents_RowHeaderMouseClick);
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.HeaderText = "Student Id";
            this.StudentId.Name = "StudentId";
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            // 
            // DateodBirth
            // 
            this.DateodBirth.DataPropertyName = "DateodBirth";
            this.DateodBirth.HeaderText = "Date of Birth";
            this.DateodBirth.Name = "DateodBirth";
            // 
            // AddressLine1
            // 
            this.AddressLine1.DataPropertyName = "AddressLine1";
            this.AddressLine1.HeaderText = "Address Line1";
            this.AddressLine1.Name = "AddressLine1";
            // 
            // AddressLine2
            // 
            this.AddressLine2.DataPropertyName = "AddressLine2";
            this.AddressLine2.HeaderText = "Address Line2";
            this.AddressLine2.Name = "AddressLine2";
            // 
            // AddressLine3
            // 
            this.AddressLine3.DataPropertyName = "AddressLine3";
            this.AddressLine3.HeaderText = "Address Line3";
            this.AddressLine3.Name = "AddressLine3";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(198, 332);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(117, 332);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(36, 332);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(738, 332);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(657, 332);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(151, 129);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(197, 20);
            this.dtpDateOfBirth.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = " Student Form";
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 367);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.txtAddress3);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFiestName);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.lblAddressLine3);
            this.Controls.Add(this.lblAddressLine2);
            this.Controls.Add(this.lblAddressLine1);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblStudentId);
            this.Name = "frmStudent";
            this.Text = "frmStudent";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblAddressLine1;
        private System.Windows.Forms.Label lblAddressLine2;
        private System.Windows.Forms.Label lblAddressLine3;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtFiestName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtAddress3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateodBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressLine1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressLine2;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressLine3;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label label1;
    }
}