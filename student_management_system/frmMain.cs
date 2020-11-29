using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagementSystem.Data.Models;
using DMSSWE;
using DMSSWE.DATA;
using StudentManagementSystem.BL;

namespace StudentManagementSystem
{
    public partial class frmMain : Form
    {
        private MainBL oMainBL = new MainBL();
        public frmMain()
        {
            InitializeComponent();
            dgvMain.AutoGenerateColumns = false;
        }

        #region Events

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void gradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGrade ofrmGrade = new frmGrade();
            ofrmGrade.FormClosed += (s, args) => this.Dispose();
            ofrmGrade.Show();
        }

        private void subjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSubject ofrmSubject = new frmSubject();
            ofrmSubject.FormClosed += (s, args) => this.Dispose();
            ofrmSubject.Show();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudent ofrmStudent = new frmStudent();
            ofrmStudent.FormClosed += (s, args) => this.Dispose();
            ofrmStudent.Show();
        }

        private void studentMarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudentMark ofrmStudentMark = new frmStudentMark();
            ofrmStudentMark.FormClosed += (s, args) => this.Dispose();
            ofrmStudentMark.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            filterData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (frmSearchPopup ofrmSearchPopup = new frmSearchPopup())
            {
                ofrmSearchPopup.ShowDialog();
                if (ofrmSearchPopup.stuName != null)
                {
                    txtStudentName.Text = ofrmSearchPopup.stuName;
                }
            }
        }

        #endregion Events

        #region Methods
        public void filterData()
        {
            try
            {
                List<StudentMarkCustomDTO> oStudentMarkList = oMainBL.filterData(txtStudentName.Text.Trim());
                dgvMain.DataSource = oStudentMarkList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion Methods

    }
}
