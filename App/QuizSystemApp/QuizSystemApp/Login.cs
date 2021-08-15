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
    public partial class Login : Form
    {
        public Login(string _status)
        {
            InitializeComponent();
            status = _status;
        }
        string status;
        string query;
        bool flag = true;
        Point pnlStartLocation;
        Point lblStartLocation;

        //Methods
        private void Center(Panel inner, Control outer)
        {

            inner.Left = (outer.Width - inner.Width) / 2;
            inner.Top = (outer.Height - inner.Height) / 2;
        }

        private void SetToAdmin()
        {
            lblRegister.Visible = false;
        }

        private void SetToTeacher()
        {
            lblRegister.Visible = false;
        }

        private void SetToStudent()
        {
            lblRegister.Visible = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //query = $"select * from {status}";
            Center(pnlContent,this);
            lblTitle.Text = $"{status} {lblTitle.Text}";
            switch (status)
            {
                case "Admin":
                    SetToAdmin();
                    break;
                case "Teacjer":
                    SetToAdmin();
                    break;
                case "Student":
                    SetToAdmin();
                    break;
                default:
                    break;
            }
            pnlStartLocation = pnlButtons.Location;
            lblStartLocation = lblTitle.Location;
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                flag = false;
                lblTitle.Location = new Point(lblStartLocation.X, lblStartLocation.Y);
                pnlButtons.Location = new Point(pnlStartLocation.X, pnlStartLocation.Y-60);
                lblRegister.Text = "Daxil ol";
                lblName.Visible = true;
                lblSurname.Visible = true;
                tbName.Visible = true;
                tbSurname.Visible = true;
                lblPassword.Visible = false;
                tbPassword.Visible = false;
                btnLogin.Visible = false;
                btnSignin.Visible = true;
            }
            else
            {
                flag = true;
                lblTitle.Location = new Point();
                lblTitle.Location = new Point(lblStartLocation.X, lblStartLocation.Y + 90);
                pnlButtons.Location = new Point(pnlStartLocation.X, pnlStartLocation.Y);
                lblRegister.Text = "Qeydiyyat";
                lblName.Visible = false;
                lblSurname.Visible = false;
                tbName.Visible = false;
                tbSurname.Visible = false;
                lblPassword.Visible = true;
                tbPassword.Visible = true;
                btnLogin.Visible = true;
                btnSignin.Visible = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            this.Hide();
            adminPage.Show();
        }
    }
}
