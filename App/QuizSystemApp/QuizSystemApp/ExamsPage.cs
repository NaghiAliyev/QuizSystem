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
    public partial class ExamsPage : Form
    {
        private string status;
        public ExamsPage(string _status)
        {
            InitializeComponent();
            status = _status;
        }
        //Global Variables
        Exam exam = new Exam();
        Dictionary<string, int> period = new Dictionary<string, int>
        {
            { "Bütün vaxtlar", 0 },
            { "Son 1 il", 365 },
            { "Son 1 həftə", 7 },
            { "Son gün", 1 }
        };

        //Methods
        private void FillInputs()
        {
            tbTitle.Text = exam.title;
            tbTitle.Enabled = false;
        }

        private void WriteExamsUsage(DateTime lowerLimit, DateTime upperLimit)
        {
            int usageCount = 0;
            using (DBEntities db = new DBEntities())
            {
                usageCount = db.TakeExams.Where(x => x.date <= upperLimit && x.date >= lowerLimit).Count();
            }

            tbTotalExamUsage.Text = usageCount.ToString();
        }

        public void PopulateDGV()
        {
            using (DBEntities db = new DBEntities())
            {
                dgrvAllExams.AutoGenerateColumns = false;
                var allExams = db.Exams.Select(x => x).ToList();
                foreach (var exam in allExams)
                {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dgrvAllExams);
                        row.Cells[0].Value = exam.id;
                        row.Cells[1].Value = exam.title;
                        row.Cells[2].Value = exam.Questions.Count;
                        row.Cells[3].Value = exam.TakeExams.Count == 0 ? false: true;
                        
                        if (exam.TakeExams.Count != 0)
                        {
                            row.Cells[4].Value = exam.TakeExams.Count;
                        }
                        else
                        {
                            row.Cells[4].Value = "-";
                        }
                        dgrvAllExams.Rows.Add(row);
                    
                }


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
            btnGoToExam.Text = "Düzəliş et";
            btnDelete.Enabled = true;
        }

        private void ExamsPage_Load(object sender, EventArgs e)
        {
            btnClear_Click(sender, e);
            PopulateDGV();
            cmbSelectInterval.SelectedIndex = 0;
            if (status == "Teacher")
            {
                lblSelectInterval.Visible = false;
                tbTotalExamUsage.Visible = false;
                cmbSelectInterval.Visible = false;
            }
            else if (status == "Admin")
            {
                lblSelectInterval.Visible = true;
                tbTotalExamUsage.Visible = true;
                cmbSelectInterval.Visible = true;
            }
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
            btnGoToExam.Text = "Tərtib et";
            btnDelete.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show($"{exam.title} adlı imtahanı silmək istədiyinizə əminsinizmi?", "Sorğu", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    using (DBEntities db = new DBEntities())
                    {
                        var questions = db.Questions.Where(x => x.ExamID == exam.id).ToList();
                        foreach (var currentQuestion in questions)
                    {
                        var variants = db.Variants.Where(x => x.questionId == currentQuestion.id).ToList();
                        foreach (var variant in variants)
                        {
                            var entryVariant = db.Entry(variant);
                            if (entryVariant.State == EntityState.Detached)
                            {
                                db.Variants.Attach(variant);
                            }
                            db.Variants.Remove(variant);
                        }

                        var entryQuestions = db.Entry(currentQuestion);
                        if (entryQuestions.State == EntityState.Detached)
                        {
                            db.Questions.Attach(currentQuestion);
                        }
                        db.Questions.Remove(currentQuestion);

                    }
                                            
                        var entryExam = db.Entry(exam);
                        if (entryExam.State == EntityState.Detached)
                        {
                            db.Exams.Attach(exam);
                        }
                        db.Exams.Remove(exam);
                        db.SaveChanges();
                        PopulateDGV();
                        btnClear_Click(sender, e);
                        MessageBox.Show("Seçilmiş tələbə sistemdən silindi!", "Bildiriş");
                    }
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show("Silmə uğursuz oldu!", "Bildiriş", MessageBoxButtons.OK);
            }
        }

        private void cmbSelectInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime lowerLimit;
            DateTime upperLimit;
            string key = cmbSelectInterval.SelectedItem.ToString();
            switch (key)
            {
                case "Bütün vaxtlar":
                    upperLimit = DateTime.Now;
                    lowerLimit = DateTime.Today.AddYears(-5);
                    break;
                case "Son 1 il":
                    upperLimit = DateTime.Now;
                    lowerLimit = DateTime.Today.AddYears(-1);
                    break;
                case "Son 1 həftə":
                    upperLimit = DateTime.Now;
                    lowerLimit = DateTime.Today.AddDays(-7);
                    break;
                case "Son gün":
                    upperLimit = DateTime.Now;
                    lowerLimit = DateTime.Today.AddDays(-1);
                    break;
                default:
                    upperLimit = DateTime.Now;
                    lowerLimit = DateTime.Today.AddYears(-5);
                    break;
            }
            WriteExamsUsage(lowerLimit, upperLimit);
        }

    }
}
