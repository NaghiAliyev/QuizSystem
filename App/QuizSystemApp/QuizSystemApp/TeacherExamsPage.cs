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
    public partial class TeacherExamsPage : Form
    {
        public TeacherExamsPage(TeachersPage _parent)
        {
            InitializeComponent();
            parent = _parent;
        }
        //Global Variables
        TeachersPage parent;
        Exam exam = new Exam();

        //Methods
        private void FillInputs()
        {
            tbTitle.Text = exam.title;
            tbTitle.Enabled = false;
        }

        private void PopulateDGV()
        {
            dgrvAllExams.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                dgrvAllExams.DataSource = db.Exams.ToList<Exam>();
            }
        }

        //Form events
        private void dgrvAllExams_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (DBEntities db = new DBEntities())
            {
                exam.id = Convert.ToInt32(dgrvAllExams.CurrentRow.Cells["id"].Value);
                exam = db.Exams.Where(x => x.id == exam.id).FirstOrDefault();
                FillInputs();
            }
        }

        private void TeacherExamsPage_Load(object sender, EventArgs e)
        {
            btnClear_Click(sender, e);
            PopulateDGV();
        }

        private void btnGoToExam_Click(object sender, EventArgs e)
        {
            using (DBEntities db = new DBEntities())
            {
                if (exam.id == 0)
                {
                    exam.title = tbTitle.Text.Trim();
                    db.Exams.Add(exam);
                    MessageBox.Show("add");
                }
                else
                {
                    db.Entry(exam).State = EntityState.Modified;
                    MessageBox.Show("update");
                }
                db.SaveChanges();
                Exams newExam = new Exams("Teacher", exam);
                newExam.Show();
            }
            tbTitle.Clear();
            PopulateDGV();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            exam.id = 0;
            tbTitle.Clear();
            tbTitle.Enabled = true;
        }
    }
}
