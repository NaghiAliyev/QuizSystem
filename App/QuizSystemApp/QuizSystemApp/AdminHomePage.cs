using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizSystemApp
{
    public partial class AdminHomePage : Form
    {
        public AdminHomePage(Admin _currentAdmin, AdminPage _parent)
        {
            InitializeComponent();
            parent = _parent;
            currentAdmin = _currentAdmin;
        }
        //Global Variables
        Admin currentAdmin;
        AdminPage parent;

        //Methods
        private void Center(Panel inner, Control outer)
        {

            inner.Left = (outer.Width - inner.Width) / 2;
            inner.Top = (outer.Height - inner.Height) / 2;
        }

        private void AdminHomePage_Load(object sender, EventArgs e)
        {
            Center(pnlContent,this);
            using (DBEntities db = new DBEntities())
            {
                tbEmail.Text = currentAdmin.email;
                tbPassword.Text = currentAdmin.password;
            }
        }

        private void AdminHomePage_Resize(object sender, EventArgs e)
        {
            Center(pnlContent, this);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (DBEntities db = new DBEntities())
            {
                currentAdmin.password = tbPassword.Text;
                db.Entry(currentAdmin).State = EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Şifrə uğurla yeniləndi!", "Bildiriş", MessageBoxButtons.OK);
                parent.Hide();
                Login login = new Login("Admin");
                login.Show();
            }
        }
    }

}
