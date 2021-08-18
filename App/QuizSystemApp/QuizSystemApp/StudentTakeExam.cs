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
    public partial class StudentTakeExam : Form
    {
        public StudentTakeExam(Exam _currentExam, Student _currentStudent)
        {
            InitializeComponent();
            currentExam = _currentExam;
            currentStudent = _currentStudent;
        }
        // Global Variables
        Exam currentExam;
        Student currentStudent;
        Question currentQuestion;
        int correctAnswerCounter = 0;
        int wrongAnswerCounter = 0;
        List<Question> examQuestions = new List<Question>();
        List<Variant> questionVariants = new List<Variant>();
        List<Panel> currentVariants = new List<Panel>();

        // Methods
        private void WriteVariant(Variant currentVariant)
        {
            Panel variant = new Panel();
            variant.Width = pnlVariantTemplate.Width;
            variant.Height = pnlVariantTemplate.Height;
            variant.Location = new Point(pnlVariantTemplate.Location.X, pnlVariantTemplate.Location.Y + (pnlVariantTemplate.Height) * questionVariants.IndexOf(currentVariant) + 5);
            Label label = new Label();
            label.Location = pnlVariantTemplate.Controls[1].Location;
            label.Text = currentVariant.variantType;
            label.Size = pnlVariantTemplate.Controls[1].Size;
            TextBox textBox = new TextBox();
            textBox.Size = pnlVariantTemplate.Controls[0].Size;
            textBox.Text = currentVariant.variantText;
            textBox.Enabled = false;
            textBox.Location = pnlVariantTemplate.Controls[0].Location;
            variant.Controls.Add(label);
            variant.Controls.Add(textBox);
            pnlQuestion.Controls.Add(variant);
            currentVariants.Add(variant);
            cmbVariants.Items.Add(currentVariant.variantType);
        }

        private void GetExamQuestion(Question _currentQuesion)
        {
            tbQuestionText.Text = _currentQuesion.Text;
            GetVariants(_currentQuesion.id);
            foreach (Variant variant in questionVariants)
            {
                WriteVariant(variant);
            }
        }

        private void GetVariants(int questionId)
        {
            using (DBEntities db = new DBEntities())
            {
                questionVariants = db.Variants.Where(x => x.questionId == questionId).ToList<Variant>();
            }
        }

        private void ClearQuestionPanel()
        {
            for (int i = questionVariants.Count - 1; i >= 0; i--)
            {
                pnlQuestion.Controls.Remove(currentVariants[i]);
                currentVariants.RemoveAt(i);
                cmbVariants.Items.RemoveAt(i);
            }
            tbQuestionText.Clear();
        }
        // Forms Events
        private void StudentTakeExam_Load(object sender, EventArgs e)
        {
            tbExamTitle.Text = currentExam.title;
            using (DBEntities db = new DBEntities())
            {
                examQuestions = db.Questions.Where(x => x.ExamID == currentExam.id).ToList<Question>();
            }
            currentQuestion = examQuestions[0];
            GetExamQuestion(currentQuestion);
        }

        private void btnConfirmQuestion_Click(object sender, EventArgs e)
        {
            if (cmbVariants.SelectedIndex != -1)
            {
                if (currentQuestion.correctVariant == cmbVariants.SelectedItem.ToString())
                {
                    correctAnswerCounter++;
                }
                else
                {
                    wrongAnswerCounter++;
                }
                btnConfirmQuestion.Enabled = false;
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa düzgün variantı seçin.", "Bildiriş");
            }
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if (examQuestions.IndexOf(currentQuestion) + 1 == examQuestions.Count)
            {
                MessageBox.Show("Bu son sualdır");
                btnNext.Enabled = false;
            }
            else if (cmbVariants.SelectedIndex == -1)
            {
                if (MessageBox.Show("Bu sualı ötürmək istədiyinizdən əminsinizmi? Əgər növbəti suala keçsəz bu suala geri dönə bilməyəcəksiniz", "Sorğu", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    currentQuestion = examQuestions[examQuestions.IndexOf(currentQuestion) + 1];
                    ClearQuestionPanel();
                    GetExamQuestion(currentQuestion);
                }
            }
            else
            {
                currentQuestion = examQuestions[examQuestions.IndexOf(currentQuestion) + 1];
                ClearQuestionPanel();
                GetExamQuestion(currentQuestion);
            }
            btnConfirmQuestion.Enabled = true;
        }

        private void btnConfirmExam_Click(object sender, EventArgs e)
        {
            TakeExam takeExam = new TakeExam();
            takeExam.student_id = currentStudent.id;
            takeExam.exam_id = currentExam.id;
            takeExam.amountCorrectAnswer = correctAnswerCounter;
            takeExam.amountWrongAnswer = wrongAnswerCounter;
            takeExam.date = DateTime.Now;
            using (DBEntities db = new DBEntities())
            {
                db.TakeExams.Add(takeExam);
                db.SaveChanges();
            }
            this.Hide();
            StudentsPage studentsPage = new StudentsPage(currentStudent);
            studentsPage.Show();
        }
    }
    
    
}
