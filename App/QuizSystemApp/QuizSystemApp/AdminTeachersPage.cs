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
    public partial class AdminTeachersPage : Form
    {
        public AdminTeachersPage()
        {
            InitializeComponent();
        }
        //Global Variables

        Teacher teacher = new Teacher();

        //Methods
        private void PopulateDGV()
        {
            dgrvTeachers.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                dgrvTeachers.DataSource = db.Teachers.ToList<Teacher>();
            }
        }

        private void FillInputs()
        {
            tbName.Text = teacher.name;
            tbSurname.Text = teacher.surname;
            tbEmail.Text = teacher.email;
            tbPassword.Text = teacher.password;
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
            teacher.name = tbName.Text;
            teacher.surname = tbSurname.Text;
            teacher.email = tbEmail.Text;
            teacher.password = pswrd;
        }

        //Form events
        private void AdminTeachersPage_Load(object sender, EventArgs e)
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
                    if (teacher.id == 0)
                    {
                        GetNewData(tbName.Text + tbSurname.Text + CreatePassword(4));

                        if (IsEmail(tbEmail.Text))
                        {
                            db.Teachers.Add(teacher);
                            db.SaveChanges();
                            PopulateDGV();
                            MailSender(teacher.email, teacher.password);
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
                        db.Entry(teacher).State = EntityState.Modified;
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

        private void dgrvTeachers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (DBEntities db = new DBEntities())
            {
                teacher.id = Convert.ToInt32(dgrvTeachers.CurrentRow.Cells["ID"].Value);
                teacher = db.Teachers.Where(x => x.id == teacher.id).FirstOrDefault();
                FillInputs();
            }
            btnSave.Text = "Dəyiş";
            btnDelete.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbName.Text = "";
            tbSurname.Text = "";
            tbEmail.Text = "";
            tbPassword.Text = "";
            btnSave.Text = "Əlavə et";
            btnDelete.Enabled = false;
            teacher.id = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show($"{teacher.name.Trim()} adlı müəllimi sistemdən silmək istədiyinizə əminsinizmi?", "Sorğu", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    using (DBEntities db = new DBEntities())
                    {
                        var entry = db.Entry(teacher);
                        if (entry.State == EntityState.Detached)
                        {
                            db.Teachers.Attach(teacher);
                        }
                        db.Teachers.Remove(teacher);
                        db.SaveChanges();
                        PopulateDGV();
                        btnClear_Click(sender, e);
                        MessageBox.Show("Seçilmiş müəllim sistemdən silindi!", "Bildiriş");
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