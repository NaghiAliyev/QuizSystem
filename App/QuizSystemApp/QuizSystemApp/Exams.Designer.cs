
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
            this.btnConfirmExam = new System.Windows.Forms.Button();
            this.pnlQuestion = new System.Windows.Forms.Panel();
            this.btnRemoveLastChild = new System.Windows.Forms.Button();
            this.btnConfirmQuestion = new System.Windows.Forms.Button();
            this.lblSelectCorrectVariant = new System.Windows.Forms.Label();
            this.cmbVariants = new System.Windows.Forms.ComboBox();
            this.pnlVariantTemplate = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblVariant = new System.Windows.Forms.Label();
            this.btnAddVariant = new System.Windows.Forms.Button();
            this.tbQuestionText = new System.Windows.Forms.TextBox();
            this.lblQuestionTitle = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
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
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblExamTitle);
            this.pnlTop.Controls.Add(this.tbExamTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(777, 74);
            this.pnlTop.TabIndex = 2;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.btnConfirmExam);
            this.pnlContent.Controls.Add(this.pnlQuestion);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 74);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(777, 571);
            this.pnlContent.TabIndex = 2;
            // 
            // btnConfirmExam
            // 
            this.btnConfirmExam.Location = new System.Drawing.Point(549, 519);
            this.btnConfirmExam.Name = "btnConfirmExam";
            this.btnConfirmExam.Size = new System.Drawing.Size(174, 40);
            this.btnConfirmExam.TabIndex = 2;
            this.btnConfirmExam.Text = "İmtahanı Tamamla";
            this.btnConfirmExam.UseVisualStyleBackColor = true;
            this.btnConfirmExam.Visible = false;
            this.btnConfirmExam.Click += new System.EventHandler(this.btnConfirmExam_Click);
            // 
            // pnlQuestion
            // 
            this.pnlQuestion.Controls.Add(this.btnRemoveLastChild);
            this.pnlQuestion.Controls.Add(this.btnConfirmQuestion);
            this.pnlQuestion.Controls.Add(this.lblSelectCorrectVariant);
            this.pnlQuestion.Controls.Add(this.cmbVariants);
            this.pnlQuestion.Controls.Add(this.pnlVariantTemplate);
            this.pnlQuestion.Controls.Add(this.btnAddVariant);
            this.pnlQuestion.Controls.Add(this.tbQuestionText);
            this.pnlQuestion.Controls.Add(this.lblQuestionTitle);
            this.pnlQuestion.Controls.Add(this.btnNext);
            this.pnlQuestion.Controls.Add(this.btnPrevious);
            this.pnlQuestion.Location = new System.Drawing.Point(28, 22);
            this.pnlQuestion.Name = "pnlQuestion";
            this.pnlQuestion.Size = new System.Drawing.Size(712, 491);
            this.pnlQuestion.TabIndex = 0;
            // 
            // btnRemoveLastChild
            // 
            this.btnRemoveLastChild.Location = new System.Drawing.Point(651, 391);
            this.btnRemoveLastChild.Name = "btnRemoveLastChild";
            this.btnRemoveLastChild.Size = new System.Drawing.Size(44, 40);
            this.btnRemoveLastChild.TabIndex = 6;
            this.btnRemoveLastChild.Text = "x";
            this.btnRemoveLastChild.UseVisualStyleBackColor = true;
            this.btnRemoveLastChild.Click += new System.EventHandler(this.btnRemoveLastChild_Click);
            // 
            // btnConfirmQuestion
            // 
            this.btnConfirmQuestion.Location = new System.Drawing.Point(531, 437);
            this.btnConfirmQuestion.Name = "btnConfirmQuestion";
            this.btnConfirmQuestion.Size = new System.Drawing.Size(164, 40);
            this.btnConfirmQuestion.TabIndex = 2;
            this.btnConfirmQuestion.Text = "Testi Tamamla";
            this.btnConfirmQuestion.UseVisualStyleBackColor = true;
            this.btnConfirmQuestion.Visible = false;
            this.btnConfirmQuestion.Click += new System.EventHandler(this.btnConfirmQuestion_Click);
            // 
            // lblSelectCorrectVariant
            // 
            this.lblSelectCorrectVariant.AutoSize = true;
            this.lblSelectCorrectVariant.Location = new System.Drawing.Point(285, 447);
            this.lblSelectCorrectVariant.Name = "lblSelectCorrectVariant";
            this.lblSelectCorrectVariant.Size = new System.Drawing.Size(168, 21);
            this.lblSelectCorrectVariant.TabIndex = 5;
            this.lblSelectCorrectVariant.Text = "Düzgün variantı seç:";
            // 
            // cmbVariants
            // 
            this.cmbVariants.FormattingEnabled = true;
            this.cmbVariants.Location = new System.Drawing.Point(470, 444);
            this.cmbVariants.Name = "cmbVariants";
            this.cmbVariants.Size = new System.Drawing.Size(55, 29);
            this.cmbVariants.TabIndex = 4;
            // 
            // pnlVariantTemplate
            // 
            this.pnlVariantTemplate.Controls.Add(this.textBox3);
            this.pnlVariantTemplate.Controls.Add(this.lblVariant);
            this.pnlVariantTemplate.Location = new System.Drawing.Point(27, 170);
            this.pnlVariantTemplate.Name = "pnlVariantTemplate";
            this.pnlVariantTemplate.Size = new System.Drawing.Size(498, 45);
            this.pnlVariantTemplate.TabIndex = 3;
            this.pnlVariantTemplate.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(35, 10);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(424, 27);
            this.textBox3.TabIndex = 1;
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
            // tbQuestionText
            // 
            this.tbQuestionText.Location = new System.Drawing.Point(104, 26);
            this.tbQuestionText.Multiline = true;
            this.tbQuestionText.Name = "tbQuestionText";
            this.tbQuestionText.Size = new System.Drawing.Size(471, 85);
            this.tbQuestionText.TabIndex = 2;
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
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(673, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(36, 34);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "->";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(3, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(36, 34);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Text = "<-";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Visible = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // Exams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 645);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblVariant;
        private System.Windows.Forms.Button btnAddVariant;
        private System.Windows.Forms.TextBox tbQuestionText;
        private System.Windows.Forms.Label lblQuestionTitle;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnConfirmExam;
        private System.Windows.Forms.Label lblSelectCorrectVariant;
        private System.Windows.Forms.ComboBox cmbVariants;
        private System.Windows.Forms.Button btnConfirmQuestion;
        private System.Windows.Forms.Button btnRemoveLastChild;
    }
}