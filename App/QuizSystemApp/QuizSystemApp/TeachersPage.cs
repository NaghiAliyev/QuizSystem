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
    public partial class TeachersPage : Form
    {
        public TeachersPage(Teacher _currentTeacher)
        {
            InitializeComponent();
            currentTeacher = _currentTeacher;
        }
        //Global Variables
        Teacher currentTeacher;
        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Intro intro = new Intro();
            this.Hide();
            intro.Show();
        }

        private void lblHomePage_Click(object sender, EventArgs e)
        {
            this.pnlActions.Controls.Clear();
            TeacherHomePage teacherHomePage = new TeacherHomePage(currentTeacher, this)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            this.pnlActions.Controls.Add(teacherHomePage);
            teacherHomePage.Show();
        }

        private void TeachersPage_Load(object sender, EventArgs e)
        {
            lblHomePage_Click(sender,e);
        }
    }
}
