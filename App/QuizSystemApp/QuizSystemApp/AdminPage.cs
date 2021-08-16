using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizSystemApp
{
    public partial class AdminPage : Form
    {
        public AdminPage(Admin _currentAdmin)
        {
            InitializeComponent();
            currentAdmin = _currentAdmin;
        }
        //Global Variables
        Admin currentAdmin;

        private void lblHomePage_Click(object sender, EventArgs e)
        {
            this.pnlActions.Controls.Clear();
            AdminHomePage homePage = new AdminHomePage(currentAdmin, this)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            this.pnlActions.Controls.Add(homePage);
            homePage.Show();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            lblHomePage_Click(sender, e);
        }

        private void lblStudents_Click(object sender, EventArgs e)
        {
            this.pnlActions.Controls.Clear();
            AdminStudentsPage studentPage = new AdminStudentsPage()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            this.pnlActions.Controls.Add(studentPage);
            studentPage.Show();
        }

        private void lblTeachers_Click(object sender, EventArgs e)
        {
            this.pnlActions.Controls.Clear();
            AdminTeachersPage teacherPage = new AdminTeachersPage()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            this.pnlActions.Controls.Add(teacherPage);
            teacherPage.Show();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Intro intro = new Intro();
            this.Hide();
            intro.Show();
        }

        private void AdminPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblTests_Click(object sender, EventArgs e)
        {
            this.pnlActions.Controls.Clear();
            AdminExamsPage examsPage = new AdminExamsPage()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            this.pnlActions.Controls.Add(examsPage);
            examsPage.Show();
        }
    }
}
