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
    public partial class AdminHomePage : Form
    {

        Admin admin = new Admin();
        public AdminHomePage()
        {
            InitializeComponent();
        }

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
                admin = db.Admins.Where(x => x.email == "admin@admin.com").FirstOrDefault();
                tbEmail.Text = admin.email;
                tbPassword.Text = admin.password;
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
                admin = db.Admins.Where(x => x.email == "admin@admin.com").FirstOrDefault();
                admin.password = tbPassword.Text;
                db.SaveChanges();
                MessageBox.Show("Şifrə uğurla yeniləndi!");
            }
        }
    }

}
