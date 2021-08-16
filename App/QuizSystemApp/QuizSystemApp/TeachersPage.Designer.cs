
namespace QuizSystemApp
{
    partial class TeachersPage
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
            this.pnlActions = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblExams = new System.Windows.Forms.Label();
            this.lblHomePage = new System.Windows.Forms.Label();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlActions
            // 
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActions.Location = new System.Drawing.Point(200, 0);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(512, 527);
            this.pnlActions.TabIndex = 1;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.lblExams);
            this.pnlMenu.Controls.Add(this.lblHomePage);
            this.pnlMenu.Controls.Add(this.btnBackToLogin);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 527);
            this.pnlMenu.TabIndex = 2;
            // 
            // lblExams
            // 
            this.lblExams.AutoSize = true;
            this.lblExams.Location = new System.Drawing.Point(42, 174);
            this.lblExams.Name = "lblExams";
            this.lblExams.Size = new System.Drawing.Size(98, 21);
            this.lblExams.TabIndex = 4;
            this.lblExams.Text = "İmtahanlar";
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
            // TeachersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 527);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "TeachersPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeachersPage";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblExams;
        private System.Windows.Forms.Label lblHomePage;
        private System.Windows.Forms.Button btnBackToLogin;
    }
}