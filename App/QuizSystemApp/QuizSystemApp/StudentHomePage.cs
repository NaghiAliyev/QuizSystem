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
    public partial class StudentHomePage : Form
    {
        public StudentHomePage(Student _currentStudent, StudentsPage _parent)
        {
            InitializeComponent();
            parent = _parent;
            currentStudent = _currentStudent;
        }
        //Global Variables
        StudentsPage parent;
        Student currentStudent;

        //Methods
        private void Center(Panel inner, Control outer)
        {

            inner.Left = (outer.Width - inner.Width) / 2;
            inner.Top = (outer.Height - inner.Height) / 2;
        }

        //
        private void StudentHomePage_Load(object sender, EventArgs e)
        {
            Center(pnlContent, this);
            using (DBEntities db = new DBEntities())
            {
                tbName.Text = currentStudent.name;
                tbSurname.Text = currentStudent.surname;
                tbEmail.Text = currentStudent.email;
                tbPassword.Text = currentStudent.password;
            }
        }

        private void StudentHomePage_Resize(object sender, EventArgs e)
        {
            Center(pnlContent, this);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (DBEntities db = new DBEntities())
            {
                currentStudent.password = tbPassword.Text;
                currentStudent.name = tbName.Text;
                currentStudent.surname = tbSurname.Text;
                db.Entry(currentStudent).State = EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Şifrə uğurla yeniləndi!", "Bildiriş", MessageBoxButtons.OK);
                parent.Hide();
                Login login = new Login("Student");
                login.Show();
            }
        }
    }
}
