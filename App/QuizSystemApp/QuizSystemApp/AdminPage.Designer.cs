
namespace QuizSystemApp
{
    partial class AdminPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblTests = new System.Windows.Forms.Label();
            this.lblTeachers = new System.Windows.Forms.Label();
            this.lblStudents = new System.Windows.Forms.Label();
            this.lblHomePage = new System.Windows.Forms.Label();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.lblTests);
            this.pnlMenu.Controls.Add(this.lblTeachers);
            this.pnlMenu.Controls.Add(this.lblStudents);
            this.pnlMenu.Controls.Add(this.lblHomePage);
            this.pnlMenu.Controls.Add(this.btnBackToLogin);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 602);
            this.pnlMenu.TabIndex = 0;
            // 
            // lblTests
            // 
            this.lblTests.AutoSize = true;
            this.lblTests.Location = new System.Drawing.Point(59, 246);
            this.lblTests.Name = "lblTests";
            this.lblTests.Size = new System.Drawing.Size(58, 21);
            this.lblTests.TabIndex = 4;
            this.lblTests.Text = "Testlər";
            this.lblTests.Click += new System.EventHandler(this.lblTests_Click);
            // 
            // lblTeachers
            // 
            this.lblTeachers.AutoSize = true;
            this.lblTeachers.Location = new System.Drawing.Point(50, 208);
            this.lblTeachers.Name = "lblTeachers";
            this.lblTeachers.Size = new System.Drawing.Size(85, 21);
            this.lblTeachers.TabIndex = 3;
            this.lblTeachers.Text = "Müəllimlər";
            this.lblTeachers.Click += new System.EventHandler(this.lblTeachers_Click);
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Location = new System.Drawing.Point(50, 161);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(76, 21);
            this.lblStudents.TabIndex = 2;
            this.lblStudents.Text = "Tələbələr";
            this.lblStudents.Click += new System.EventHandler(this.lblStudents_Click);
            // 
            // lblHomePage
            // 
            this.lblHomePage.AutoSize = true;
            this.lblHomePage.Location = new System.Drawing.Point(44, 118);
            this.lblHomePage.Name = "lblHomePage";
            this.lblHomePage.Size = new System.Drawing.Size(91, 21);
            this.lblHomePage.TabIndex = 1;
            this.lblHomePage.Text = "Əsas səhifə";
            this.lblHomePage.Click += new System.EventHandler(this.lblHomePage_Click);
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.Location = new System.Drawing.Point(12, 12);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(48, 45);
            this.btnBackToLogin.TabIndex = 0;
            this.btnBackToLogin.Text = "<-";
            this.btnBackToLogin.UseVisualStyleBackColor = true;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // pnlActions
            // 
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActions.Location = new System.Drawing.Point(200, 0);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(734, 602);
            this.pnlActions.TabIndex = 0;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 602);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminPage_FormClosed);
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblTests;
        private System.Windows.Forms.Label lblTeachers;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.Label lblHomePage;
        private System.Windows.Forms.Button btnBackToLogin;
        private System.Windows.Forms.Panel pnlActions;
    }
}