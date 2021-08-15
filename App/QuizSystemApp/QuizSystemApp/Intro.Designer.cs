
namespace QuizSystemApp
{
    partial class Intro
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
            this.lblText = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnStudent = new System.Windows.Forms.Button();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(96, 15);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(56, 21);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Mən...";
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(37, 63);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(161, 51);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Adminəm";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnTeacher
            // 
            this.btnTeacher.Location = new System.Drawing.Point(37, 137);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(161, 51);
            this.btnTeacher.TabIndex = 2;
            this.btnTeacher.Text = "Müəlliməm";
            this.btnTeacher.UseVisualStyleBackColor = true;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.btnStudent);
            this.pnlContent.Controls.Add(this.lblText);
            this.pnlContent.Controls.Add(this.btnTeacher);
            this.pnlContent.Controls.Add(this.btnAdmin);
            this.pnlContent.Location = new System.Drawing.Point(141, 75);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(235, 286);
            this.pnlContent.TabIndex = 3;
            // 
            // btnStudent
            // 
            this.btnStudent.Location = new System.Drawing.Point(37, 211);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(161, 50);
            this.btnStudent.TabIndex = 3;
            this.btnStudent.Text = "Tələbəyəm";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 430);
            this.Controls.Add(this.pnlContent);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Intro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Intro_FormClosed);
            this.Load += new System.EventHandler(this.Intro_Load);
            this.Resize += new System.EventHandler(this.Intro_Resize);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnTeacher;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnStudent;
    }
}

