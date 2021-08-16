
namespace QuizSystemApp
{
    partial class AdminExamsPage
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
            this.dgrvTeachers = new System.Windows.Forms.DataGridView();
            this.btnGoToExams = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvTeachers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrvTeachers
            // 
            this.dgrvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvTeachers.Location = new System.Drawing.Point(31, 244);
            this.dgrvTeachers.Name = "dgrvTeachers";
            this.dgrvTeachers.Size = new System.Drawing.Size(558, 161);
            this.dgrvTeachers.TabIndex = 16;
            // 
            // btnGoToExams
            // 
            this.btnGoToExams.Location = new System.Drawing.Point(498, 133);
            this.btnGoToExams.Name = "btnGoToExams";
            this.btnGoToExams.Size = new System.Drawing.Size(91, 46);
            this.btnGoToExams.TabIndex = 17;
            this.btnGoToExams.Text = "button1";
            this.btnGoToExams.UseVisualStyleBackColor = true;
            this.btnGoToExams.Click += new System.EventHandler(this.btnGoToExams_Click);
            // 
            // AdminExamsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 445);
            this.Controls.Add(this.btnGoToExams);
            this.Controls.Add(this.dgrvTeachers);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AdminExamsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminExamsPage";
            ((System.ComponentModel.ISupportInitialize)(this.dgrvTeachers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrvTeachers;
        private System.Windows.Forms.Button btnGoToExams;
    }
}