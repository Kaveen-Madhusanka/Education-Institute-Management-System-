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
    public partial class frmGrade : Form
    {
        private GradeBL oGradeBL = new GradeBL();
        private SubjectBL oSubjectBL = new SubjectBL();
        public frmGrade()
        {
            InitializeComponent();
            dgvGrade.AutoGenerateColumns = false;
        }

        #region Events

                private void btnExit_Click(object sender, EventArgs e)
                {
                    this.Dispose();
                    frmMain ofrmMain = new frmMain();
                    ofrmMain.Show();
                }

                private void btnInsert_Click(object sender, EventArgs e)
                {
                    if (!CheckAvailability() == true)
                    {
                        CreateGrade();
                    }
                }

                private void btnDelete_Click(object sender, EventArgs e)
                {
                    deleteGrade();
                }

                private void btnUpdate_Click(object sender, EventArgs e)
                {
                     updateGrade();
                }

                private void btnClear_Click(object sender, EventArgs e)
                {
                    ClearControls();
                }
                private void frmGrade_Load(object sender, EventArgs e)
                {
                    LoadSubject();
                    filterBySubjectId();
                }

                private void txtSearch_TextChanged(object sender, EventArgs e)
                {
                    SearchGrade();
                }
                private void dgvGrade_CellClick(object sender, DataGridViewCellEventArgs e)
                {
                    if (e.RowIndex != -1)
                    {
                        loadTextBox(e.RowIndex);
                    }
                }

                private void txtGradeId_Leave(object sender, EventArgs e)
                {
                   // CheckAvailability();
                }

        private void txtLowerLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUpperLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearControls();
            filterBySubjectId();
        }

        #endregion Events

        #region Methods
        private void CreateGrade()
        {
            try
            {
                if (!txtGradeId.Text.Trim().Equals(string.Empty))
                {
                    GradeDTO oGradeDTO = new GradeDTO();
                    oGradeDTO.GradeId = Convert.ToInt16(txtGradeId.Text.Trim().ToUpper());
                    oGradeDTO.SubjectId = cmbSubject.SelectedValue.ToString();
                    oGradeDTO.Description = txtDescription.Text.Trim();
                    oGradeDTO.LowerLimit = Convert.ToInt16(txtLowerLimit.Text.Trim());
                    oGradeDTO.UpperLimit = Convert.ToInt16(txtUpperLimit.Text.Trim());
                    oGradeDTO.CreatedBy = "Kaveen";
                    oGradeDTO.CreatedDateTime = DateTime.Now;
                    oGradeDTO.ModifiedBy = "Kaveen";
                    oGradeDTO.ModifiedDateTime = DateTime.Now;

                    if (oGradeBL.InsertGrade(oGradeDTO))
                    {
                        ClearControls();
                        filterBySubjectId();
                        MessageBox.Show("Record inserted successfully.!");
                    }
                }
                else
                {
                    txtGradeId.Focus();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void deleteGrade()
        {
            try
            {
                if (!txtGradeId.Text.Trim().Equals(string.Empty))
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Warning", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {

                        if (oGradeBL.DeleteGrade(Convert.ToInt32(txtGradeId.Text),cmbSubject.SelectedValue.ToString()))
                        {
                            ClearControls();
                            filterBySubjectId();
                            MessageBox.Show("Record deleted successfully.!");
                        }

                    }
                }
                else
                {
                    txtGradeId.Focus();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void updateGrade()
        {
            try
            {
                if (!txtGradeId.Text.Trim().Equals(string.Empty))
                {
                    GradeDTO oGradeDTO = new GradeDTO();
                    oGradeDTO.GradeId = Convert.ToInt16(txtGradeId.Text.Trim());
                    oGradeDTO.SubjectId = cmbSubject.SelectedValue.ToString();
                    oGradeDTO.Description = txtDescription.Text.Trim();
                    oGradeDTO.LowerLimit = Convert.ToInt16(txtLowerLimit.Text.Trim());
                    oGradeDTO.UpperLimit = Convert.ToInt16(txtUpperLimit.Text.Trim());
                    oGradeDTO.ModifiedBy = "Kaveen";
                    oGradeDTO.ModifiedDateTime = DateTime.Now;

                    if (oGradeBL.UpdateGrade(oGradeDTO))
                    {
                        ClearControls();
                        filterBySubjectId();
                        MessageBox.Show("Record Updated successfully.!");
                    }
                }
                else
                {
                    txtGradeId.Focus();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void SearchGrade()
        {
            List<GradeDTO> oGradeList = new List<GradeDTO>();
            try
            {
                if (!txtSearch.Text.Equals(string.Empty))
                {
                    oGradeList = oGradeBL.SearchGrade(cmbSubject.SelectedValue.ToString(), txtSearch.Text.Trim());
                }
                else
                {
                    oGradeList = oGradeBL.filterBySubjectId(cmbSubject.SelectedValue.ToString());
                }
                dgvGrade.DataSource = oGradeList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void filterBySubjectId()
        {
            List<GradeDTO> oGradeList = new List<GradeDTO>();
            try
            {
                oGradeList = oGradeBL.filterBySubjectId(cmbSubject.SelectedValue.ToString());
                dgvGrade.DataSource = oGradeList;
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
                txtGradeId.Text = dgvGrade.Rows[i].Cells[0].Value.ToString();
                txtDescription.Text = dgvGrade.Rows[i].Cells[1].Value.ToString();
                txtLowerLimit.Text = dgvGrade.Rows[i].Cells[2].Value.ToString();
                txtUpperLimit.Text = dgvGrade.Rows[i].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool CheckAvailability()
        {
            bool recordStstus = false;
            try
            {
                if (oGradeBL.CheckAvailability(cmbSubject.SelectedValue.ToString(), Convert.ToInt32(txtGradeId.Text.Trim())))
                {
                    txtGradeId.Clear();
                    txtGradeId.Focus();
                    MessageBox.Show("Record already exist.!");
                    recordStstus = true;
                }
                else
                {
                    txtDescription.Focus();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return recordStstus;
        }

        public void ClearControls()
        {
            txtGradeId.Clear();
            txtSearch.Clear();
            txtDescription.Clear();
            txtLowerLimit.Clear();
            txtUpperLimit.Clear();
        }

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
        #endregion Methods

    }
}
