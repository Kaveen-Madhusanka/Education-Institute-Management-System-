using StudentManagementSystem.BL;
using StudentManagementSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class frmStudentMark : Form
    {
        private StudentMarkBL oStudentMarkBL = new StudentMarkBL();
        private SubjectBL oSubjectBL = new SubjectBL();
        private bool isRow = false;
        public frmStudentMark()
        {
            InitializeComponent();
            dgvStudentMark.AutoGenerateColumns = false;
        }

        #region Events
        private void frmStudentMark_Load(object sender, EventArgs e)
        {
            LoadSubject();
            LoadStudentmarks();
            HandleControls(true);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain ofrmMain = new frmMain();
            ofrmMain.FormClosed += (s, args) => this.Dispose();
            ofrmMain.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            CreateStudentMark();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateStudentMark();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteStudentMark();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void dgvStudentMark_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                loadTextBox(e.RowIndex);
            }
        }

        private void txtStudentId_TextChanged(object sender, EventArgs e)
        {
            SearchStudentMark(txtStudentId.Text.Trim());
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchStudentMark(txtSearch.Text.Trim());
        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchStudentMark(cmbSubject.SelectedValue.ToString().Trim());
        }

        #endregion Events

        #region Methods

        private void LoadSubject()
        {
            try
            {
                List<SubjectDTO> oSubjectList = oSubjectBL.GetSubjects();
                cmbSubject.DataSource = oSubjectList;
                cmbSubject.DisplayMember = "SubjectName";
                cmbSubject.ValueMember = "SubjectId";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ClearControls()
        {
            txtStudentId.Clear();
            txtMarks.Clear();
            txtSearch.Clear();
            HandleControls(true);
        }

        private void HandleControls(bool value)
        {
            txtStudentId.Enabled = value;
            cmbSubject.Enabled = value;
        }
        private void CreateStudentMark()
        {
            try
            {
                if (!txtStudentId.Text.Trim().Equals(string.Empty))
                {
                    if (!oStudentMarkBL.CheckAvailability(txtStudentId.Text.Trim(), cmbSubject.SelectedValue.ToString()))
                    {
                        StudentMarkDTO oStudentMarkDTO = new StudentMarkDTO();
                        oStudentMarkDTO.StudentId = txtStudentId.Text.Trim().ToUpper();
                        oStudentMarkDTO.SubjectId = cmbSubject.SelectedValue.ToString();
                        oStudentMarkDTO.Marks = Convert.ToInt32(txtMarks.Text.Trim());
                        oStudentMarkDTO.CreatedBy = "Kaveen";
                        oStudentMarkDTO.CreatedDateTime = DateTime.Now;
                        oStudentMarkDTO.ModifiedBy = "Kaveen";
                        oStudentMarkDTO.ModifiedDateTime = DateTime.Now;

                        if (oStudentMarkBL.InsertStudentMark(oStudentMarkDTO))
                        {
                            ClearControls();
                            LoadStudentmarks();
                            MessageBox.Show("Record inserted successfully.!");
                        }
                    }
                    else
                    {
                        txtStudentId.Clear();
                        txtStudentId.Focus();
                        MessageBox.Show("Record already exist.!");
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

        private void deleteStudentMark()
        {
            try
            {
                if (!txtStudentId.Text.Trim().Equals(string.Empty))
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Warning", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (oStudentMarkBL.DeleteStudentMark(txtStudentId.Text.Trim(), cmbSubject.SelectedValue.ToString()))
                        {
                            ClearControls();
                            HandleControls(true);
                            LoadStudentmarks();
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

        private void updateStudentMark()
        {
            try
            {
                if (!txtStudentId.Text.Trim().Equals(string.Empty))
                {
                    StudentMarkDTO oStudentMarkDTO = new StudentMarkDTO();
                    oStudentMarkDTO.StudentId = txtStudentId.Text.Trim();
                    oStudentMarkDTO.SubjectId = cmbSubject.SelectedValue.ToString();
                    oStudentMarkDTO.Marks = Convert.ToInt32(txtMarks.Text.Trim());
                    oStudentMarkDTO.ModifiedBy = "Kaveen";
                    oStudentMarkDTO.ModifiedDateTime = DateTime.Now;

                    if (oStudentMarkBL.UpdateStudentMark(oStudentMarkDTO))
                    {
                        ClearControls();
                        HandleControls(true);
                        LoadStudentmarks();
                        MessageBox.Show("Record updated successfully.!");
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

        private void LoadStudentmarks()
        {
            try
            {
                List<StudentMarkCustomDTO> oStudentMarkList = oStudentMarkBL.GetStudentmarks();
                dgvStudentMark.DataSource = oStudentMarkList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void loadTextBox(int i)
        {
            try
            {
                isRow = true;
                txtStudentId.Text = dgvStudentMark.Rows[i].Cells[0].Value.ToString();
                cmbSubject.Text = dgvStudentMark.Rows[i].Cells[1].Value.ToString();
                txtMarks.Text = dgvStudentMark.Rows[i].Cells[2].Value.ToString();
                HandleControls(false);
                isRow = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void SearchStudentMark(string searchField)
        {
            try
            {
                if (!isRow)
                {
                    List<StudentMarkCustomDTO> oStudentMarkList = oStudentMarkBL.SearchStudentMark(searchField);
                    dgvStudentMark.DataSource = oStudentMarkList;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion Methods
    }
}
