using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizSystemApp
{
    public partial class TeacherHomePage : Form
    {
        public TeacherHomePage(Teacher _currentTeacher, TeachersPage _parent)
        {
            InitializeComponent();
            parent = _parent;
            currentTeacher = _currentTeacher;
        }
        //Global Variables
        TeachersPage parent;
        Teacher currentTeacher;

        //Methods
        private void Center(Panel inner, Control outer)
        {

            inner.Left = (outer.Width - inner.Width) / 2;
            inner.Top = (outer.Height - inner.Height) / 2;
        }

        //
        private void TeacherHomePage_Load(object sender, EventArgs e)
        {
            Center(pnlContent, this);
            using (DBEntities db = new DBEntities())
            {
                tbName.Text = currentTeacher.name;
                tbSurname.Text = currentTeacher.surname;
                tbEmail.Text = currentTeacher.email;
                tbPassword.Text = currentTeacher.password;
            }
        }

        private void TeacherHomePage_Resize(object sender, EventArgs e)
        {
            Center(pnlContent, this);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (DBEntities db = new DBEntities())
            {
                currentTeacher.password = tbPassword.Text;
                currentTeacher.name = tbName.Text;
                currentTeacher.surname = tbSurname.Text;
                db.Entry(currentTeacher).State = EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Şifrə uğurla yeniləndi!", "Bildiriş", MessageBoxButtons.OK);
                parent.Hide();
                Login login = new Login("Teacher");
                login.Show();
            }
        }
    }
}
