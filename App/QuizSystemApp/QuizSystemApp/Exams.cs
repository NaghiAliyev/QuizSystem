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
        public Exams(string _status)
        {
            InitializeComponent();
        }
        // Global Variables
        Exam exam = new Exam();
        List<Panel> variants = new List<Panel>();
        Panel previousPanel;
        private void Exams_Load(object sender, EventArgs e)
        {

        }

        private void tbExamTitle_TextChanged(object sender, EventArgs e)
        {
            exam.title = tbExamTitle.Text.Trim();
        }
        int count = 0;
        char variantType = 'A';
        private void btnAddVariant_Click(object sender, EventArgs e)
        {
            Panel variantA = new Panel();
            variantA.Width = pnlVariantTemplate.Width;
            variantA.Height = pnlVariantTemplate.Height;
            variantA.Location = new Point(pnlVariantTemplate.Location.X, pnlVariantTemplate.Location.Y + (pnlVariantTemplate.Height)*count++ + 5);
            Label label = new Label();
            label.Location = pnlVariantTemplate.Controls[2].Location;
            label.Text = $"{variantType++})";
            label.Size = pnlVariantTemplate.Controls[2].Size;
            TextBox textBox = new TextBox();
            textBox.Size = pnlVariantTemplate.Controls[1].Size;
            textBox.Location = pnlVariantTemplate.Controls[1].Location;
            RadioButton radioButton = new RadioButton();
            radioButton.Location = pnlVariantTemplate.Controls[0].Location;
            radioButton.Text = pnlVariantTemplate.Controls[0].Text;
            variantA.Controls.Add(label);
            variantA.Controls.Add(textBox);
            variantA.Controls.Add(radioButton);
            previousPanel = variantA;
            pnlQuestion.Controls.Add(variantA);
            variants.Add(variantA);
        }
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
    }
}
