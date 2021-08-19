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
    public partial class StudentExamsPage : Form
    {
        public StudentExamsPage(Student _currentStudent, StudentsPage _parent)
        {
            InitializeComponent();
            currentStudent = _currentStudent;
            parent = _parent;
        }
        //Global Variables
        Student currentStudent;
        TakeExam takeExam = new TakeExam();
        Exam selectedExam = new Exam();
        StudentsPage parent;

        //Methods
        private bool IsTakeExam(int examId)
        {
            using (DBEntities db = new DBEntities())
            {
                takeExam = db.TakeExams.Where(x => x.student_id == currentStudent.id && x.exam_id == examId).FirstOrDefault();
            }
            if (takeExam != null)
            {
                return true;
            }
            return false;
        }

        public void PopulateDGV()
        {
            using (DBEntities db = new DBEntities())
            {
                dgrvAllExams.AutoGenerateColumns = false;
                var allExams = db.Exams.Select(x => x).ToList();
                foreach (var exam in allExams)
                {
                    if (exam.Questions.Count!=0)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dgrvAllExams);
                        row.Cells[0].Value = exam.id;
                        row.Cells[1].Value = exam.title;
                        row.Cells[2].Value = IsTakeExam(exam.id);
                        if (IsTakeExam(exam.id))
                        {
                            row.Cells[3].Value = takeExam.date;
                            row.Cells[4].Value = takeExam.amountCorrectAnswer;
                            row.Cells[5].Value = takeExam.amountWrongAnswer;
                        }
                        else
                        {
                            row.Cells[3].Value = "-";
                            row.Cells[4].Value = "-";
                            row.Cells[5].Value = "-";
                        }
                        dgrvAllExams.Rows.Add(row);
                    }
                }


            }
        }

        //Form methods
        private void StudentExamsPage_Load(object sender, EventArgs e)
        {
            PopulateDGV();
        }

        

        private void dgrvAllExams_DoubleClick(object sender, EventArgs e)
        {
            if ((bool)(dgrvAllExams.CurrentRow.Cells["IsAtended"].Value))
            {
                MessageBox.Show("Siz artıq bu imtahanda iştirak etmisiniz, yenidən iştirak etmək mümkün deyil.", "Bildiriş");
            }
            else
            {
                using (DBEntities db = new DBEntities())
                {
                    selectedExam.id = Convert.ToInt32(dgrvAllExams.CurrentRow.Cells["ID"].Value);
                    selectedExam = db.Exams.Where(x => x.id == selectedExam.id).FirstOrDefault();
                }
                StudentTakeExam studentTakeExam = new StudentTakeExam(selectedExam, currentStudent);
                studentTakeExam.Show();
                parent.Hide();
            }
        }
    }
}
