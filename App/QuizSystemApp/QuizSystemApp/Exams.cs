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
    public partial class Exams : Form
    {
        public Exams(string _status, Exam _currentExam)
        {
            InitializeComponent();
            currentExam = _currentExam;
        }
        // Global Variables
        Exam currentExam = new Exam();
        List<Panel> variants = new List<Panel>();
        Panel previousPanel;
        int count = 0;
        int totalQuestion = 0;
        char variantType = 'A';
        List<Variant> currentQuestionVariants = new List<Variant>();

        // Methods
        private void checkCorrectVariant(object sender, EventArgs e)
        {
            foreach (Panel variant in variants)
            {
                if (variant.Controls[0] is CheckBox)
                {
                    CheckBox checkBox = variant.Controls[0] as CheckBox;
                }
            }
        }

        private void CreateVariant()
        {
            Panel variant = new Panel();
            variant.Width = pnlVariantTemplate.Width;
            variant.Height = pnlVariantTemplate.Height;
            variant.Location = new Point(pnlVariantTemplate.Location.X, pnlVariantTemplate.Location.Y + (pnlVariantTemplate.Height) * count++ + 5);
            Label label = new Label();
            label.Location = pnlVariantTemplate.Controls[1].Location;
            label.Text = $"{variantType})";
            label.Size = pnlVariantTemplate.Controls[1].Size;
            TextBox textBox = new TextBox();
            textBox.Size = pnlVariantTemplate.Controls[0].Size;
            textBox.Location = pnlVariantTemplate.Controls[0].Location;
            variant.Controls.Add(label);
            variant.Controls.Add(textBox);
            previousPanel = variant;
            pnlQuestion.Controls.Add(variant);
            variants.Add(variant);
            cmbVariants.Items.Add(variantType++);
        }

        // Form Events
        private void Exams_Load(object sender, EventArgs e)
        {
            tbExamTitle.Text = currentExam.title;
        }

        
        private void btnAddVariant_Click(object sender, EventArgs e)
        {
            if (variants.Count<=4)
            {
                if (variants.Count>=1)
                {
                    btnConfirmQuestion.Visible = true;
                }
                CreateVariant();
            }
            else
            {
                btnAddVariant.Enabled = false;
            }
        }

        private void btnConfirmQuestion_Click(object sender, EventArgs e)
        {
            using (DBEntities db = new DBEntities())
            {

                Question question = new Question();
                question.ExamID = currentExam.id;
                question.Text = tbQuestionText.Text;
                question.correctVariant = cmbVariants.SelectedItem.ToString();
                
                foreach (Panel pnlVariant in variants)
                {
                    Variant variant = new Variant();
                    variant.variantType = pnlVariant.Controls[0].Text[0].ToString();
                    variant.variantText = pnlVariant.Controls[1].Text;
                    variant.questionId = question.id;
                    //currentQuestionVariants.Add(variant);
                    db.Variants.Add(variant);
                }
                db.Questions.Add(question);
                db.SaveChanges();
            }
        }

        private void btnConfirmExam_Click(object sender, EventArgs e)
        {
            currentExam.title = tbExamTitle.Text.Trim();

        }

        private void btnRemoveLastChild_Click(object sender, EventArgs e)
        {
            if (variants.Count < 5 && variants.Count >= 2)
            {
                btnAddVariant.Enabled = true;
                pnlQuestion.Controls.Remove(variants[variants.Count - 1]);
                variants.RemoveAt(variants.Count - 1);
                cmbVariants.Items.RemoveAt(cmbVariants.Items.Count - 1);
            }
            else
            {
                btnConfirmQuestion.Visible = false;
            }
            
        }
    }
}
