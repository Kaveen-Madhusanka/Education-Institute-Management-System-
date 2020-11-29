using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagementSystem.BL;
using StudentManagementSystem.Data.Models;

namespace StudentManagementSystem
{
    public partial class frmStudent : Form
    {
        private StudentBL oStudentBL = new StudentBL();
        public frmStudent()
        {
            InitializeComponent();
            dgvStudents.AutoGenerateColumns = false;
        }

        #region Events
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!CheckAvailability() == true)
            {
                CreateStudent();
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteStudent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateStudent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchStudents();
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                loadTextBox(e.RowIndex);
            }
        }

        private void dgvStudents_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //loadTextBox();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmMain ofrmMain = new frmMain();
            ofrmMain.Show();
        }

        #endregion Events

        #region Methods

        private void CreateStudent()
        {
            try
            {
                if (!txtStudentId.Text.Trim().Equals(string.Empty))
                {
                    StudentDTO oStudentDTO = new StudentDTO();
                    oStudentDTO.StudentId = txtStudentId.Text.Trim().ToUpper();
                    oStudentDTO.FirstName = txtFiestName.Text.Trim();
                    oStudentDTO.LastName = txtLastName.Text.Trim();
                    oStudentDTO.DateodBirth = dtpDateOfBirth.Value.ToString();
                    oStudentDTO.AddressLine1 = txtAddress1.Text.Trim();
                    oStudentDTO.AddressLine2 = txtAddress2.Text.Trim();
                    oStudentDTO.AddressLine3 = txtAddress3.Text.Trim();
                    oStudentDTO.CreatedBy = "Kaveen";
                    oStudentDTO.CreatedDateTime = DateTime.Now;
                    oStudentDTO.ModifiedBy = "Kaveen";
                    oStudentDTO.ModifiedDateTime = DateTime.Now;

                    if (oStudentBL.InsertStudent(oStudentDTO))
                    {
                        ClearControls();
                        LoadStudents();
                        MessageBox.Show("Record inserted successfully.!");
                    }
                }
                else
                {
                    txtStudentId.Focus();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void deleteStudent()
        {
            try
            {
                if (!txtStudentId.Text.Trim().Equals(string.Empty))
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Warning", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                       
                        if (oStudentBL.DeleteStudent(txtStudentId.Text))
                        {
                            ClearControls();
                            LoadStudents();
                            MessageBox.Show("Record deleted successfully.!");
                        }

                    }
                }
                else
                {
                    txtStudentId.Focus();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void updateStudent()
        {
            try
            {
                if (!txtStudentId.Text.Trim().Equals(string.Empty))
                {
                    StudentDTO oStudentDTO = new StudentDTO();
                    oStudentDTO.StudentId = txtStudentId.Text.Trim();
                    oStudentDTO.FirstName = txtFiestName.Text.Trim();
                    oStudentDTO.LastName = txtLastName.Text.Trim();
                    oStudentDTO.DateodBirth = dtpDateOfBirth.Value.ToString();
                    oStudentDTO.AddressLine1 = txtAddress1.Text.Trim();
                    oStudentDTO.AddressLine2 = txtAddress2.Text.Trim();
                    oStudentDTO.AddressLine3 = txtAddress3.Text.Trim();
                    oStudentDTO.ModifiedBy = "Kaveen";
                    oStudentDTO.ModifiedDateTime = DateTime.Now;

                    if (oStudentBL.UpdateStudent(oStudentDTO))
                    {
                        ClearControls();
                        LoadStudents();
                        MessageBox.Show("Record Updated successfully.!");
                    }
                }
                else
                {
                    txtStudentId.Focus();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void LoadStudents()
        {
            try
            {
                List<StudentDTO> oStudentList = oStudentBL.GetStudents();
                dgvStudents.DataSource = oStudentList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void SearchStudents()
        {
            try
            {
                List<StudentDTO> oStudentList = oStudentBL.SearchStudents(txtSearch.Text);
                dgvStudents.DataSource = oStudentList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void loadTextBox(int i)
        {
            txtStudentId.Text = dgvStudents.Rows[i].Cells[0].Value + String.Empty;
            txtFiestName.Text = dgvStudents.Rows[i].Cells[1].Value + String.Empty;
            txtLastName.Text = dgvStudents.Rows[i].Cells[2].Value + String.Empty;
            dtpDateOfBirth.Text = dgvStudents.Rows[i].Cells[3].Value + String.Empty;
            txtAddress1.Text = dgvStudents.Rows[i].Cells[4].Value + String.Empty;
            txtAddress2.Text = dgvStudents.Rows[i].Cells[5].Value + String.Empty;
            txtAddress3.Text = dgvStudents.Rows[i].Cells[6].Value + String.Empty;
        }

        private void ClearControls()
        {
            txtStudentId.Clear();
            txtFiestName.Clear();
            txtLastName.Clear();
            txtAddress1.Clear();
            txtAddress2.Clear();
            txtAddress3.Clear();
            txtSearch.Clear();
        }

        private bool CheckAvailability()
        {
            bool recordStstus = false;
            try
            {
                if (oStudentBL.CheckAvailability(txtStudentId.Text.Trim()))
                {
                    txtStudentId.Clear();
                    txtStudentId.Focus();
                    MessageBox.Show("Record already exist.!");
                    recordStstus = true;
                }
                else
                {
                    txtStudentId.Focus();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return recordStstus;
        }
        #endregion Methods

    }
}
