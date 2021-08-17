
namespace QuizSystemApp
{
    partial class StudentExamsPage
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
            this.dgrvAllExams = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsAtended = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountCorrectAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountWrongAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvAllExams)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrvAllExams
            // 
            this.dgrvAllExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvAllExams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Title,
            this.IsAtended,
            this.Date,
            this.AmountCorrectAnswer,
            this.AmountWrongAnswer});
            this.dgrvAllExams.Location = new System.Drawing.Point(24, 63);
            this.dgrvAllExams.Name = "dgrvAllExams";
            this.dgrvAllExams.Size = new System.Drawing.Size(564, 389);
            this.dgrvAllExams.TabIndex = 0;
            this.dgrvAllExams.DoubleClick += new System.EventHandler(this.dgrvAllExams_DoubleClick);
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
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Başlıq";
            this.Title.Name = "Title";
            // 
            // IsAtended
            // 
            this.IsAtended.DataPropertyName = "IsAtended";
            this.IsAtended.HeaderText = "IsAtended";
            this.IsAtended.Name = "IsAtended";
            this.IsAtended.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsAtended.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsAtended.Visible = false;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Tarix";
            this.Date.Name = "Date";
            // 
            // AmountCorrectAnswer
            // 
            this.AmountCorrectAnswer.DataPropertyName = "AmountCorrectAnswer";
            this.AmountCorrectAnswer.HeaderText = "Düzgün Cavab Sayı";
            this.AmountCorrectAnswer.Name = "AmountCorrectAnswer";
            // 
            // AmountWrongAnswer
            // 
            this.AmountWrongAnswer.DataPropertyName = "AmountWrongAnswer";
            this.AmountWrongAnswer.HeaderText = "Səhv Cavab Sayı";
            this.AmountWrongAnswer.Name = "AmountWrongAnswer";
            // 
            // StudentExamsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 486);
            this.Controls.Add(this.dgrvAllExams);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "StudentExamsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentExamsPage";
            this.Load += new System.EventHandler(this.StudentExamsPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvAllExams)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrvAllExams;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsAtended;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountCorrectAnswer;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountWrongAnswer;
    }
}