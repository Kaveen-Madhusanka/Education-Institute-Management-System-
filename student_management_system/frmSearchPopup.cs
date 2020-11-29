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
    public partial class frmSearchPopup : Form
    {
        private StudentBL oStudentBL = new StudentBL();

        public string stuName;

        public frmSearchPopup()
        {
            InitializeComponent();
            dgvSearch.AutoGenerateColumns = false;
        }

        #region Events

        private void frmSearchPopup_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchData();
        }
        private void dgvSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                stuName = dgvSearch.Rows[e.RowIndex].Cells[0].Value.ToString();

                //frmMain frm = new frmMain();
                //frm.name = value;
                this.Dispose();
            }
        }

        #endregion Events

        #region Methods
        private void loadData()
        {
            try
            {
                List<StudentDTO> oStudentList = oStudentBL.GetStudents();
                dgvSearch.DataSource = oStudentList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void searchData()
        {
            try
            {
                List<StudentDTO> oStudentList = oStudentBL.SearchStudents(txtSearch.Text);
                dgvSearch.DataSource = oStudentList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion Methods

    }
}
