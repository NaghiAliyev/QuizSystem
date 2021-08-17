using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
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

        private bool MailSender(string email, string password)
        {
            try
            {
                string from = "quizsystem3556@gmail.com";
                string pass = "Quiz_System3556!";
                string to = email;
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress(from, "Quiz System");
                mailMessage.To.Add(new MailAddress(to));
                mailMessage.Subject = "Confirm Account";
                mailMessage.IsBodyHtml = true;
                mailMessage.Body = "<h3>Sizin müvəqqəti şifrəniz : " + password + " </h3>";
                NetworkCredential nCredential = new NetworkCredential();
                nCredential.UserName = from;
                nCredential.Password = pass;

                SmtpClient sClient = new SmtpClient();
                sClient.Host = "smtp.gmail.com";
                sClient.EnableSsl = true;
                sClient.Port = 587;
                sClient.UseDefaultCredentials = false;
                sClient.Credentials = nCredential;
                sClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                sClient.Send(mailMessage);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private bool IsEmail(string email)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(email);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        // Form events
        private void Login_Load(object sender, EventArgs e)
        {
            Center(pnlContent,this);
            lblTitle.Text = $"{status} {lblTitle.Text}";
            if (status == "Admin")
            {
                lblRegister.Visible = false;
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
            switch (status)
            {
                case "Admin":
                    using (DBEntities db = new DBEntities())
                    {

                        admin = db.Admins.Where(x => x.email == tbEmail.Text).FirstOrDefault();
                        if (admin != null)
                        {
                            if (tbPassword.Text == admin.password)
                            {
                                AdminPage adminPage = new AdminPage(admin);
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
                                TeachersPage teachersPage = new TeachersPage(teacher);
                                this.Hide();
                                teachersPage.Show();
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
                                StudentsPage studentsPage = new StudentsPage(student);
                                this.Hide();
                                studentsPage.Show();
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

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            switch (status)
            {
                case "Teacher":
                    using (DBEntities db = new DBEntities())
                    {
                        if (IsEmail(tbEmail.Text))
                        {
                            teacher.name = tbName.Text; 
                            teacher.surname = tbSurname.Text;
                            teacher.email = tbEmail.Text;
                            teacher.password = tbName.Text + tbSurname.Text + CreatePassword(4);
                            db.Teachers.Add(teacher);
                            db.SaveChanges();
                            MailSender(teacher.email, teacher.password);
                            MessageBox.Show("Qeydiyyat uğurla həyata keçirildi!");
                            lblRegister_Click(sender,e);
                        }
                        else
                        {
                            MessageBox.Show("E-poçt adresi uyğun deyil!", "Xəta");
                        }
                    }
                    break;
                case "Student":
                    using (DBEntities db = new DBEntities())
                    {
                        if (IsEmail(tbEmail.Text))
                        {
                            student.name = tbName.Text;
                            student.surname = tbSurname.Text;
                            student.email = tbEmail.Text;
                            student.password = tbName.Text + tbSurname.Text + CreatePassword(4);
                            db.Students.Add(student);
                            db.SaveChanges();
                            MailSender(student.email, student.password);
                            MessageBox.Show("Qeydiyyat uğurla həyata keçirildi!");
                            lblRegister_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("E-poçt adresi uyğun deyil!", "Xəta");
                        }
                    }
                    break;
            }
        }


    }
}
