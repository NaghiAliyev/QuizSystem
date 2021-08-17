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

        private void GetNewData()
        {
            teacher.name = tbName.Text;
            teacher.surname = tbSurname.Text;
            teacher.email = tbEmail.Text;
            teacher.password = tbPassword.Text;
        }

        //Form events
        private void AdminTeachersPage_Load(object sender, EventArgs e)
        {
            PopulateDGV();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                GetNewData();
                using (DBEntities db = new DBEntities())
                {
                    if (teacher.id == 0)
                    {
                        db.Teachers.Add(teacher);
                        db.SaveChanges();

                        PopulateDGV();
                        MessageBox.Show("Əlavə etmə uğurla yerinə yetirildi!", "Bildiriş", MessageBoxButtons.OK);
                    }
                    else
                    {
                        db.Entry(teacher).State = EntityState.Modified;
                        MessageBox.Show("Dəyişilmə uğurla yerinə yetirildi!", "Bildiriş", MessageBoxButtons.OK);
                    }
                    db.SaveChanges();
                }
                btnClear_Click(sender, e);
                PopulateDGV();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Əlavə etmə uğursuz oldu!", "Bildiriş", MessageBoxButtons.OK);
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
            btnSave.Text = "Dəyiş";
            btnDelete.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbName.Text = "";
            tbSurname.Text = "";
            tbEmail.Text = "";
            tbPassword.Text = "";
            btnSave.Text = "Əlavə et";
            btnDelete.Enabled = false;
            teacher.id = 0;
        }
    }
}
