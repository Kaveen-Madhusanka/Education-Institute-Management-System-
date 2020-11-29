using StudentManagementSystem;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_management_system
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DMSSWE.Common.ConnectionString = ConfigurationManager.ConnectionStrings["StudentManagementSystemConnString"].ConnectionString;
            Application.Run(new frmMain());
        }
    }
}
