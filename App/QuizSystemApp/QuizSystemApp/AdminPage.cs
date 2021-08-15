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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void lblHomePage_Click(object sender, EventArgs e)
        {
            this.pnlActions.Controls.Clear();
            AdminHomePage homePage = new AdminHomePage()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            this.pnlActions.Controls.Add(homePage);
            homePage.Show();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            lblHomePage_Click(sender, e);
        }
    }
}
