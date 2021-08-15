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
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }

        private void Intro_Load(object sender, EventArgs e)
        {
            Center(pnlContent,this);
        }

        //Methods
        private void Center(Panel inner, Control outer)
        {

            inner.Left = (outer.Width - inner.Width) / 2;
            inner.Top = (outer.Height - inner.Height) / 2;
        }

        private void Intro_Resize(object sender, EventArgs e)
        {
            Center(pnlContent, this);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Login login = new Login("Admin");
            this.Hide();
            login.Show();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            Login login = new Login("Teacher");
            this.Hide();
            login.Show();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            Login login = new Login("Student");
            this.Hide();
            login.Show();
        }

        private void Intro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
