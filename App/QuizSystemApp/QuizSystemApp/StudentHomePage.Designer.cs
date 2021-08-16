
namespace QuizSystemApp
{
    partial class StudentHomePage
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
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.btnUpdate);
            this.pnlContent.Controls.Add(this.lblTitle);
            this.pnlContent.Controls.Add(this.lblSurname);
            this.pnlContent.Controls.Add(this.lblName);
            this.pnlContent.Controls.Add(this.lblEmail);
            this.pnlContent.Controls.Add(this.tbPassword);
            this.pnlContent.Controls.Add(this.lblPassword);
            this.pnlContent.Controls.Add(this.tbSurname);
            this.pnlContent.Controls.Add(this.tbName);
            this.pnlContent.Controls.Add(this.tbEmail);
            this.pnlContent.Location = new System.Drawing.Point(94, 58);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(349, 269);
            this.pnlContent.TabIndex = 5;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(201, 214);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 34);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Dəyiş";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(125, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(109, 21);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Xoş gəlmisiniz";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(19, 90);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(65, 21);
            this.lblSurname.TabIndex = 0;
            this.lblSurname.Text = "Soyadı:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(42, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 21);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Adı:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(19, 134);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(64, 21);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "E-Poçt:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(105, 172);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(196, 27);
            this.tbPassword.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(39, 172);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(44, 21);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Şifrə:";
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(105, 90);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(196, 27);
            this.tbSurname.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(105, 49);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(196, 27);
            this.tbName.TabIndex = 1;
            // 
            // tbEmail
            // 
            this.tbEmail.Enabled = false;
            this.tbEmail.Location = new System.Drawing.Point(105, 134);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(196, 27);
            this.tbEmail.TabIndex = 1;
            // 
            // StudentHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 384);
            this.Controls.Add(this.pnlContent);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "StudentHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentHomePage";
            this.Load += new System.EventHandler(this.StudentHomePage_Load);
            this.Resize += new System.EventHandler(this.StudentHomePage_Resize);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbEmail;
    }
}