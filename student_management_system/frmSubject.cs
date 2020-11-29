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
using System.Data.SqlClient;

namespace StudentManagementSystem
{
    public partial class frmSubject : Form
    {
        private SubjectBL oSubjectBL = new SubjectBL();
        public frmSubject()
        {
            InitializeComponent();
            dgvSubject.AutoGenerateColumns = false;
        }

        #region Events

        private void frmSubject_Load(object sender, EventArgs e)
        {
            LoadSubjects();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            //Form1 fm = new Form1();
            //fm.Show();
            //this.Hide();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
           
            if (!CheckAvailability()== true)
            {
                CreateSubject();
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateSubject();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteSubject();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain ofrmMain = new frmMain();
            ofrmMain.FormClosed += (s, args) => this.Dispose();
            ofrmMain.Show();
        }

        private void txtSubjectId_Leave(object sender, EventArgs e)
        {
            //CheckAvailability();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchSubject();
        }

        private void dgvSubject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                loadTextBox(e.RowIndex);
            }
        }

        #endregion Events

        #region Methods

        private void ClearControls()
        {
            txtSubjectId.Clear();
            txtSubjectName.Clear();
            txtSearch.Clear();
        }

        private bool CheckAvailability()
        {
            bool recordStstus = false;
            try
            {
                if (oSubjectBL.CheckAvailability(txtSubjectId.Text.Trim()))
                {
                    txtSubjectId.Clear();
                    txtSubjectId.Focus();
                    MessageBox.Show("Record already exist.!");
                    recordStstus = true;
                }
                else
                {
                    txtSubjectName.Focus();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return recordStstus;
        }
        private void CreateSubject()
        {
            try
            {
                if (!txtSubjectId.Text.Trim().Equals(string.Empty))
                {
                    SubjectDTO oSubjectDTO = new SubjectDTO();
                    oSubjectDTO.SubjectId = txtSubjectId.Text.Trim().ToUpper();
                    oSubjectDTO.SubjectName = txtSubjectName.Text.Trim();
                    oSubjectDTO.CreatedBy = "Kaveen";
                    oSubjectDTO.CreatedDateTime = DateTime.Now;
                    oSubjectDTO.ModifiedBy = "Kaveen";
                    oSubjectDTO.ModifiedDateTime = DateTime.Now;

                    if (oSubjectBL.InsertSubject(oSubjectDTO))
                    {
                        ClearControls();
                        LoadSubjects();
                        MessageBox.Show("Record inserted successfully.!");
                    }
                }
                else
                {
                    txtSubjectId.Focus();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void deleteSubject()
        {
            try
            {
                if (!txtSubjectId.Text.Trim().Equals(string.Empty))
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Warning", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (oSubjectBL.DeleteSubject(txtSubjectId.Text.Trim()))
                        {
                            ClearControls();
                            LoadSubjects();
                            MessageBox.Show("Record deleted successfully.!");
                        }

                    }                 
                }
                else
                {
                    txtSubjectId.Focus();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void updateSubject()
        {
            try
            {
                if (!txtSubjectId.Text.Trim().Equals(string.Empty))
                {
                    SubjectDTO oSubjectDTO = new SubjectDTO();
                    oSubjectDTO.SubjectId = txtSubjectId.Text.Trim();
                    oSubjectDTO.SubjectName = txtSubjectName.Text.Trim();
                    oSubjectDTO.ModifiedBy = "Kaveen";
                    oSubjectDTO.ModifiedDateTime = DateTime.Now;

                    if (oSubjectBL.UpdateSubject(oSubjectDTO))
                    {
                        ClearControls();
                        LoadSubjects();
                        MessageBox.Show("Record updated successfully.!");
                    }
                }
                else
                {
                    txtSubjectId.Focus();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void LoadSubjects()
        {
            try
            {
                List<SubjectDTO> oSubjectList = oSubjectBL.GetSubjects();
                dgvSubject.DataSource = oSubjectList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void SearchSubject()
        {
            try
            {
                List<SubjectDTO> oSubjectList = oSubjectBL.SearchSubject(txtSearch.Text.Trim());
                dgvSubject.DataSource = oSubjectList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void loadTextBox(int i)
        {
            txtSubjectId.Text = dgvSubject.Rows[i].Cells[0].Value.ToString();
            txtSubjectName.Text = dgvSubject.Rows[i].Cells[1].Value.ToString();
        }

        #endregion Methods
    }
}
