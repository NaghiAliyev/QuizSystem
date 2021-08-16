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
        Teacher teacher = new Teacher();
        public AdminTeachersPage()
        {
            InitializeComponent();
        }

        private void AdminTeachersPage_Load(object sender, EventArgs e)
        {
            using (DBEntities db = new DBEntities())
            {
                foreach (var teacher in db.Teachers)
                {
                    DataGridViewRow row = (DataGridViewRow)dgrvTeachers.Rows[0].Clone();
                    row.Cells[0].Value = teacher.name;
                    row.Cells[1].Value = teacher.surname;
                    row.Cells[2].Value = teacher.email;
                    row.Cells[3].Value = teacher.password;
                    dgrvTeachers.Rows.Add(row);
                }
            }
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

                DataGridViewRow row = (DataGridViewRow)dgrvTeachers.Rows[0].Clone();
                row.Cells[0].Value = teacher.name;
                row.Cells[1].Value = teacher.surname;
                row.Cells[2].Value = teacher.email;
                row.Cells[3].Value = teacher.password;
                dgrvTeachers.Rows.Add(row);

                tbName.Text = "";
                tbSurname.Text = "";
                tbEmail.Text = "";
                tbPassword.Text = "";

                MessageBox.Show("Qeydiyyat uğurla həyata keçirildi!");
            }
        }

        private void dgrvTeachers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (DBEntities db = new DBEntities())
            {
                teacher = db.Teachers.Where(x => x.email == dgrvTeachers.SelectedRows[0].Cells[2].Value.ToString()).FirstOrDefault();
                tbName.Text = teacher.name;
                tbSurname.Text = teacher.surname;
                tbEmail.Text = teacher.email;
                tbPassword.Text = teacher.password;
            }
        }
    }
}
