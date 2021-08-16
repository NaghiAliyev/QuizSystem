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
    public partial class AdminTeachersPage : Form
    {
        public AdminTeachersPage()
        {
            InitializeComponent();
        }
        //Global Variables
        Teacher teacher = new Teacher();

        //Methods
        private void PopulateDGV()
        {
            dgrvTeachers.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                dgrvTeachers.DataSource = db.Teachers.ToList<Teacher>();
            }
        }

        private void FillInputs()
        {
            tbName.Text = teacher.name;
            tbSurname.Text = teacher.surname;
            tbEmail.Text = teacher.email;
            tbPassword.Text = teacher.password;
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
                teacher.name = tbName.Text;
                teacher.surname = tbSurname.Text;
                teacher.email = tbEmail.Text;
                teacher.password = tbPassword.Text;
                db.Teachers.Add(teacher);
                db.SaveChanges();

                PopulateDGV();

                btnClear_Click(sender,e);

                MessageBox.Show("Qeydiyyat uğurla həyata keçirildi!");
            }
            btnSave.Text = "Dəyiş";
            btnDelete.Enabled = true;
        }

        private void dgrvTeachers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (DBEntities db = new DBEntities())
            {
                teacher.id = Convert.ToInt32(dgrvTeachers.CurrentRow.Cells["ID"].Value);
                teacher = db.Teachers.Where(x => x.id == teacher.id).FirstOrDefault();
                FillInputs();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbName.Text = "";
            tbSurname.Text = "";
            tbEmail.Text = "";
            tbPassword.Text = "";
        }
    }
}
