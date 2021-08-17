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
    public partial class AdminStudentsPage : Form
    {
        public AdminStudentsPage()
        {
            InitializeComponent();
        }
        //Global Variables
        Student student  = new Student();

        //Methods
        private void PopulateDGV()
        {
            dgrvStudents.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                dgrvStudents.DataSource = db.Students.ToList<Student>();
            }
        }

        private void FillInputs()
        {
            tbName.Text = student.name;
            tbSurname.Text = student.surname;
            tbEmail.Text = student.email;
            tbPassword.Text = student.password;
        }

        //Form events
        private void AdminTeachersPage_Load(object sender, EventArgs e)
        {
            PopulateDGV();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (DBEntities db = new DBEntities())
            {
                student.name = tbName.Text;
                student.surname = tbSurname.Text;
                student.email = tbEmail.Text;
                student.password = tbPassword.Text;
                db.Students.Add(student);
                db.SaveChanges();

                PopulateDGV();

                btnClear_Click(sender, e);

                MessageBox.Show("Qeydiyyat uğurla həyata keçirildi!");
            }
            btnSave.Text = "Dəyiş";
            btnDelete.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbName.Text = "";
            tbSurname.Text = "";
            tbEmail.Text = "";
            tbPassword.Text = "";
        }

        private void dgrvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (DBEntities db = new DBEntities())
            {
                student.id = Convert.ToInt32(dgrvStudents.CurrentRow.Cells["ID"].Value);
                student = db.Students.Where(x => x.id == student.id).FirstOrDefault();
                FillInputs();
            }
        }
    }
}
