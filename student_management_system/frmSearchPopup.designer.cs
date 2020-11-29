namespace StudentManagementSystem
{
    partial class frmSearchPopup
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateodBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressLine1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressLine2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressLine3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(330, 6);
            this.txtSearch.MaxLength = 8;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(160, 20);
            this.txtSearch.TabIndex = 26;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(263, 9);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(47, 13);
            this.lblSearch.TabIndex = 25;
            this.lblSearch.Text = "Search :";
            // 
            // dgvSearch
            // 
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentId,
            this.FirstName,
            this.LastName,
            this.DateodBirth,
            this.AddressLine1,
            this.AddressLine2,
            this.AddressLine3});
            this.dgvSearch.Location = new System.Drawing.Point(12, 32);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.Size = new System.Drawing.Size(478, 324);
            this.dgvSearch.TabIndex = 24;
            this.dgvSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearch_CellClick);
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
            // frmSearchPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 368);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvSearch);
            this.Name = "frmSearchPopup";
            this.Text = "frmSearchPopup";
            this.Load += new System.EventHandler(this.frmSearchPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateodBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressLine1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressLine2;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressLine3;
    }
}