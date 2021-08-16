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
        Admin admin = new Admin();
        Teacher teacher = new Teacher();
        Student student = new Student();

        public Login(string _status)
        {
            InitializeComponent();
            status = _status;
        }
        string status;
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
            if (IsAdmin())
            {

            }
        }

        private void SetToTeacher()
        {
            //lblRegister.Visible = false;
        }

        private void SetToStudent()
        {
            lblRegister.Visible = false;
        }

        private bool IsAdmin()
        {
            try
            {
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        private bool IsTeacher()
        {
            try
            {
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        private bool IsStudent()
        {
            try
            {
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        
        private void Login_Load(object sender, EventArgs e)
        {
            Center(pnlContent,this);
            lblTitle.Text = $"{status} {lblTitle.Text}";
            switch (status)
            {
                case "Admin":
                    SetToAdmin();
                    break;
                case "Teacher":
                    SetToTeacher();
                    break;
                case "Student":
                    SetToStudent();
                    break;
                default:
                    MessageBox.Show("Test");
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
            if (lblRegister.Text == "Qeydiyyat")
            {
                switch (status)
                {
                    case "Admin":
                        using (DBEntities db = new DBEntities())
                        {
                            admin = db.Admins.Where(x => x.email == "admin@admin.com").FirstOrDefault();
                            if (tbEmail.Text == admin.email)
                            {
                                if (tbPassword.Text == admin.password)
                                {
                                    AdminPage adminPage = new AdminPage();
                                    this.Hide();
                                    adminPage.Show();
                                }
                                else
                                {
                                    tbPassword.Text = "";
                                    MessageBox.Show("Şifrəni yalnış daxil etmisiniz!");

                                }
                            }
                            else
                            {
                                MessageBox.Show("Elektron poçt ünvanını yalnış daxil etmisiniz!");
                            }
                        }
                        break;
                    case "Teacher":
                        using (DBEntities db = new DBEntities())
                        {
                            teacher = db.Teachers.Where(x => x.email == tbEmail.Text).FirstOrDefault();
                            if (teacher != null)
                            {
                                if (tbPassword.Text == teacher.password)
                                {
                                    //AdminPage adminPage = new AdminPage();
                                    //this.Hide();
                                    //adminPage.Show();
                                    MessageBox.Show("Isleyir");
                                }
                                else
                                {
                                    MessageBox.Show("Şifrəni yalnış daxil etmisiniz!");
                                    tbPassword.Text = "";
                                }
                            }
                            else
                            {
                                MessageBox.Show("Elektron poçt ünvanını yalnış daxil etmisiniz!");
                            }
                        }
                        break;
                    case "Student":
                        using (DBEntities db = new DBEntities())
                        {
                            student = db.Students.Where(x => x.email == tbEmail.Text).FirstOrDefault();
                            if (student != null)
                            {
                                if (tbPassword.Text == student.password)
                                {
                                    //AdminPage adminPage = new AdminPage();
                                    //this.Hide();
                                    //adminPage.Show();
                                    MessageBox.Show("Isleyir");
                                }
                                else
                                {
                                    MessageBox.Show("Şifrəni yalnış daxil etmisiniz!");
                                    tbPassword.Text = "";
                                }
                            }
                            else
                            {
                                MessageBox.Show("Elektron poçt ünvanını yalnış daxil etmisiniz!");
                            }
                        }
                        break;
                }
            }
            else if(lblRegister.Text == "Daxil ol")
            {
                switch (status)
                {
                    case "Teacher":
                        using (DBEntities db = new DBEntities())
                        {
                            teacher.name = tbName.Text;
                            teacher.surname = tbSurname.Text;
                            teacher.email = tbEmail.Text;
                            db.Teachers.Add(teacher);
                            db.SaveChanges();
                            MessageBox.Show("Qeydiyyat uğurla həyata keçirildi!");
                        }
                        break;
                    case "Student":
                        break;
                }
            }
            else
            {
                MessageBox.Show("keçirildi!");
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
