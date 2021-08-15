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
    public partial class AdminExamsPage : Form
    {
        public AdminExamsPage()
        {
            InitializeComponent();
        }

        private void btnGoToExams_Click(object sender, EventArgs e)
        {
            Exams exams = new Exams("admin");
            exams.Show();
        }
    }
}
