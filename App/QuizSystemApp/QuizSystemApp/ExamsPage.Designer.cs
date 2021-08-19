
namespace QuizSystemApp
{
    partial class ExamsPage
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
            this.btnGoToExam = new System.Windows.Forms.Button();
            this.dgrvAllExams = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsUsed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TotalStudents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbSelectInterval = new System.Windows.Forms.ComboBox();
            this.lblSelectInterval = new System.Windows.Forms.Label();
            this.tbTotalExamUsage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvAllExams)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGoToExam
            // 
            this.btnGoToExam.Location = new System.Drawing.Point(511, 35);
            this.btnGoToExam.Name = "btnGoToExam";
            this.btnGoToExam.Size = new System.Drawing.Size(108, 39);
            this.btnGoToExam.TabIndex = 3;
            this.btnGoToExam.Text = "Tərtib et";
            this.btnGoToExam.UseVisualStyleBackColor = true;
            this.btnGoToExam.Click += new System.EventHandler(this.btnGoToExam_Click);
            // 
            // dgrvAllExams
            // 
            this.dgrvAllExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvAllExams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Title,
            this.QuestionCount,
            this.IsUsed,
            this.TotalStudents});
            this.dgrvAllExams.Location = new System.Drawing.Point(23, 284);
            this.dgrvAllExams.Name = "dgrvAllExams";
            this.dgrvAllExams.Size = new System.Drawing.Size(622, 230);
            this.dgrvAllExams.TabIndex = 2;
            this.dgrvAllExams.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrvAllExams_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Id";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "title";
            this.Title.HeaderText = "Mövzusu";
            this.Title.Name = "Title";
            // 
            // QuestionCount
            // 
            this.QuestionCount.DataPropertyName = "questionCount";
            this.QuestionCount.HeaderText = "Sual sayı";
            this.QuestionCount.Name = "QuestionCount";
            // 
            // IsUsed
            // 
            this.IsUsed.DataPropertyName = "IsUsed";
            this.IsUsed.HeaderText = "IsUsed";
            this.IsUsed.Name = "IsUsed";
            this.IsUsed.Visible = false;
            // 
            // TotalStudents
            // 
            this.TotalStudents.DataPropertyName = "totalStudent";
            this.TotalStudents.HeaderText = "İstifadə edən Tələbə sayı";
            this.TotalStudents.Name = "TotalStudents";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(511, 97);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 39);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Təmizlə";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(217, 53);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(200, 27);
            this.tbTitle.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(120, 53);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(57, 21);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Başlıq:";
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(511, 152);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 39);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbSelectInterval
            // 
            this.cmbSelectInterval.FormattingEnabled = true;
            this.cmbSelectInterval.Items.AddRange(new object[] {
            "Bütün vaxtlar",
            "Son 1 il",
            "Son 1 həftə",
            "Son gün"});
            this.cmbSelectInterval.Location = new System.Drawing.Point(314, 235);
            this.cmbSelectInterval.Name = "cmbSelectInterval";
            this.cmbSelectInterval.Size = new System.Drawing.Size(121, 29);
            this.cmbSelectInterval.TabIndex = 6;
            this.cmbSelectInterval.SelectedIndexChanged += new System.EventHandler(this.cmbSelectInterval_SelectedIndexChanged);
            // 
            // lblSelectInterval
            // 
            this.lblSelectInterval.AutoSize = true;
            this.lblSelectInterval.Location = new System.Drawing.Point(441, 238);
            this.lblSelectInterval.Name = "lblSelectInterval";
            this.lblSelectInterval.Size = new System.Drawing.Size(117, 21);
            this.lblSelectInterval.TabIndex = 7;
            this.lblSelectInterval.Text = "İstifadə edilən";
            // 
            // tbTotalExamUsage
            // 
            this.tbTotalExamUsage.Enabled = false;
            this.tbTotalExamUsage.Location = new System.Drawing.Point(565, 235);
            this.tbTotalExamUsage.Name = "tbTotalExamUsage";
            this.tbTotalExamUsage.Size = new System.Drawing.Size(80, 27);
            this.tbTotalExamUsage.TabIndex = 8;
            // 
            // ExamsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 541);
            this.Controls.Add(this.tbTotalExamUsage);
            this.Controls.Add(this.lblSelectInterval);
            this.Controls.Add(this.cmbSelectInterval);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGoToExam);
            this.Controls.Add(this.dgrvAllExams);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ExamsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherExamsPage";
            this.Load += new System.EventHandler(this.ExamsPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvAllExams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoToExam;
        private System.Windows.Forms.DataGridView dgrvAllExams;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionCount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsUsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalStudents;
        private System.Windows.Forms.ComboBox cmbSelectInterval;
        private System.Windows.Forms.Label lblSelectInterval;
        private System.Windows.Forms.TextBox tbTotalExamUsage;
    }
}