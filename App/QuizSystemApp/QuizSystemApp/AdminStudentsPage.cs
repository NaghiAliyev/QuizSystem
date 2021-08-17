using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Net;
using System.Net.Mail;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizSystemApp
{
    public partial class AdminStudentsPage : Form
    {
        public AdminStudentsPage()
        {
            InitializeComponent();
        }
        //Global Variables
        Student student = new Student();

        //Methods
        private void PopulateDGV()
        {
            dgrvStudents.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                dgrvStudents.DataSource = db.Students.ToList<Student>();
            }
        }

        private void FillInputs()
        {
            tbName.Text = student.name;
            tbSurname.Text = student.surname;
            tbEmail.Text = student.email;
            tbPassword.Text = student.password;
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

        private void GetNewData(string pswrd)
        {
            student.name = tbName.Text;
            student.surname = tbSurname.Text;
            student.email = tbEmail.Text;
            student.password = pswrd;
        }

        //Form events
        private void AdminStudentsPage_Load(object sender, EventArgs e)
        {
            PopulateDGV();
            btnClear_Click(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                using (DBEntities db = new DBEntities())
                {
                    if (student.id == 0)
                    {
                        GetNewData(tbName.Text + tbSurname.Text + CreatePassword(4));

                        if (IsEmail(tbEmail.Text))
                        {
                            db.Students.Add(student);
                            db.SaveChanges();
                            PopulateDGV();
                            MailSender(student.email, student.password);
                            MessageBox.Show("Əlavə etmə uğurla yerinə yetirildi!", "Bildiriş", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("E-poçt adresi uyğun deyil!", "Xəta");
                        }
                    }
                    else
                    {
                        GetNewData(tbPassword.Text);
                        db.Entry(student).State = EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Dəyişilmə uğurla yerinə yetirildi!", "Bildiriş", MessageBoxButtons.OK);

                        btnSave.Text = "Əlavə et";
                        btnDelete.Enabled = false;
                    }

                }
                btnClear_Click(sender, e);
                PopulateDGV();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Əlavə etmə uğursuz oldu!", "Bildiriş", MessageBoxButtons.OK);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbName.Text = "";
            tbSurname.Text = "";
            tbEmail.Text = "";
            tbPassword.Text = "";
            btnSave.Text = "Əlavə et";
            btnDelete.Enabled = false;
            student.id = 0;
        }

        private void dgrvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (DBEntities db = new DBEntities())
            {
                student.id = Convert.ToInt32(dgrvStudents.CurrentRow.Cells["ID"].Value);
                student = db.Students.Where(x => x.id == student.id).FirstOrDefault();
                FillInputs();
            }

            btnSave.Text = "Dəyiş";
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show($"{student.name.Trim()} adlı tələbəni sistemdən silmək istədiyinizə əminsinizmi?", "Sorğu", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    using (DBEntities db = new DBEntities())
                    {
                        var entry = db.Entry(student);
                        if (entry.State == EntityState.Detached)
                        {
                            db.Students.Attach(student);
                        }
                        db.Students.Remove(student);
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
    }
}