
namespace QuizSystemApp
{
    partial class Exams
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
            this.lblExamTitle = new System.Windows.Forms.Label();
            this.tbExamTitle = new System.Windows.Forms.TextBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlQuestion = new System.Windows.Forms.Panel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblQuestionTitle = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnAddVariant = new System.Windows.Forms.Button();
            this.pnlVariantTemplate = new System.Windows.Forms.Panel();
            this.lblVariant = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.rb = new System.Windows.Forms.RadioButton();
            this.btnConfirmExam = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlQuestion.SuspendLayout();
            this.pnlVariantTemplate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblExamTitle
            // 
            this.lblExamTitle.AutoSize = true;
            this.lblExamTitle.Location = new System.Drawing.Point(151, 28);
            this.lblExamTitle.Name = "lblExamTitle";
            this.lblExamTitle.Size = new System.Drawing.Size(133, 21);
            this.lblExamTitle.TabIndex = 0;
            this.lblExamTitle.Text = "İmtahan Başlığı:";
            // 
            // tbExamTitle
            // 
            this.tbExamTitle.Location = new System.Drawing.Point(295, 25);
            this.tbExamTitle.Name = "tbExamTitle";
            this.tbExamTitle.Size = new System.Drawing.Size(206, 27);
            this.tbExamTitle.TabIndex = 1;
            this.tbExamTitle.TextChanged += new System.EventHandler(this.tbExamTitle_TextChanged);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblExamTitle);
            this.pnlTop.Controls.Add(this.tbExamTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(765, 74);
            this.pnlTop.TabIndex = 2;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.btnConfirmExam);
            this.pnlContent.Controls.Add(this.pnlQuestion);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 74);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(765, 495);
            this.pnlContent.TabIndex = 2;
            // 
            // pnlQuestion
            // 
            this.pnlQuestion.Controls.Add(this.pnlVariantTemplate);
            this.pnlQuestion.Controls.Add(this.btnAddVariant);
            this.pnlQuestion.Controls.Add(this.textBox2);
            this.pnlQuestion.Controls.Add(this.lblQuestionTitle);
            this.pnlQuestion.Controls.Add(this.btnNext);
            this.pnlQuestion.Controls.Add(this.btnPrevious);
            this.pnlQuestion.Location = new System.Drawing.Point(28, 22);
            this.pnlQuestion.Name = "pnlQuestion";
            this.pnlQuestion.Size = new System.Drawing.Size(712, 415);
            this.pnlQuestion.TabIndex = 0;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(3, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(36, 34);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Text = "<-";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(673, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(36, 34);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "->";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // lblQuestionTitle
            // 
            this.lblQuestionTitle.AutoSize = true;
            this.lblQuestionTitle.Location = new System.Drawing.Point(41, 38);
            this.lblQuestionTitle.Name = "lblQuestionTitle";
            this.lblQuestionTitle.Size = new System.Drawing.Size(57, 21);
            this.lblQuestionTitle.TabIndex = 1;
            this.lblQuestionTitle.Text = "Başlıq:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 26);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(471, 85);
            this.textBox2.TabIndex = 2;
            // 
            // btnAddVariant
            // 
            this.btnAddVariant.Location = new System.Drawing.Point(635, 117);
            this.btnAddVariant.Name = "btnAddVariant";
            this.btnAddVariant.Size = new System.Drawing.Size(44, 36);
            this.btnAddVariant.TabIndex = 1;
            this.btnAddVariant.Text = "+";
            this.btnAddVariant.UseVisualStyleBackColor = true;
            this.btnAddVariant.Click += new System.EventHandler(this.btnAddVariant_Click);
            // 
            // pnlVariantTemplate
            // 
            this.pnlVariantTemplate.Controls.Add(this.rb);
            this.pnlVariantTemplate.Controls.Add(this.textBox3);
            this.pnlVariantTemplate.Controls.Add(this.lblVariant);
            this.pnlVariantTemplate.Location = new System.Drawing.Point(27, 170);
            this.pnlVariantTemplate.Name = "pnlVariantTemplate";
            this.pnlVariantTemplate.Size = new System.Drawing.Size(637, 45);
            this.pnlVariantTemplate.TabIndex = 3;
            this.pnlVariantTemplate.Visible = false;
            // 
            // lblVariant
            // 
            this.lblVariant.AutoSize = true;
            this.lblVariant.Location = new System.Drawing.Point(3, 14);
            this.lblVariant.Name = "lblVariant";
            this.lblVariant.Size = new System.Drawing.Size(28, 21);
            this.lblVariant.TabIndex = 0;
            this.lblVariant.Text = "A)";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(35, 10);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(424, 27);
            this.textBox3.TabIndex = 1;
            // 
            // rb
            // 
            this.rb.AutoSize = true;
            this.rb.Location = new System.Drawing.Point(485, 10);
            this.rb.Name = "rb";
            this.rb.Size = new System.Drawing.Size(149, 25);
            this.rb.TabIndex = 2;
            this.rb.TabStop = true;
            this.rb.Text = "Düzgün variant";
            this.rb.UseVisualStyleBackColor = true;
            // 
            // btnConfirmExam
            // 
            this.btnConfirmExam.Location = new System.Drawing.Point(595, 443);
            this.btnConfirmExam.Name = "btnConfirmExam";
            this.btnConfirmExam.Size = new System.Drawing.Size(112, 40);
            this.btnConfirmExam.TabIndex = 2;
            this.btnConfirmExam.Text = "Bitir";
            this.btnConfirmExam.UseVisualStyleBackColor = true;
            // 
            // Exams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 569);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Exams";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exams";
            this.Load += new System.EventHandler(this.Exams_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlQuestion.ResumeLayout(false);
            this.pnlQuestion.PerformLayout();
            this.pnlVariantTemplate.ResumeLayout(false);
            this.pnlVariantTemplate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblExamTitle;
        private System.Windows.Forms.TextBox tbExamTitle;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlQuestion;
        private System.Windows.Forms.Panel pnlVariantTemplate;
        private System.Windows.Forms.RadioButton rb;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblVariant;
        private System.Windows.Forms.Button btnAddVariant;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblQuestionTitle;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnConfirmExam;
    }
}