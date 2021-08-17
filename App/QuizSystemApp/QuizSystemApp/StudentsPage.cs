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
    public partial class StudentsPage : Form
    {
        public StudentsPage(Student _currentStudent)
        {
            InitializeComponent();
            currentStudent = _currentStudent;
        }
        //Global Variables
        Student currentStudent;

        //Form events
        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Intro intro = new Intro();
            this.Hide();
            intro.Show();
        }

        private void lblHomePage_Click(object sender, EventArgs e)
        {
            this.pnlActions.Controls.Clear();
            StudentHomePage studentHomePage = new StudentHomePage(currentStudent, this)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            this.pnlActions.Controls.Add(studentHomePage);
            studentHomePage.Show();
        }

        private void StudentsPage_Load(object sender, EventArgs e)
        {
            lblHomePage_Click(sender,e);
        }
    }
}
