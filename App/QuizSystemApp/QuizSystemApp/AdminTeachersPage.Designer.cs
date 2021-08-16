
namespace QuizSystemApp
{
    partial class AdminTeachersPage
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
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElektronPoçt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Şifrə = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvTeachers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrvTeachers
            // 
            this.dgrvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvTeachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ad,
            this.Soyad,
            this.ElektronPoçt,
            this.Şifrə});
            this.dgrvTeachers.Location = new System.Drawing.Point(31, 269);
            this.dgrvTeachers.Name = "dgrvTeachers";
            this.dgrvTeachers.Size = new System.Drawing.Size(558, 161);
            this.dgrvTeachers.TabIndex = 15;
            this.dgrvTeachers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrvTeachers_CellContentClick);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(190, 162);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(212, 27);
            this.tbPassword.TabIndex = 11;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(190, 115);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(212, 27);
            this.tbEmail.TabIndex = 12;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(110, 165);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 21);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Şifrəsi:";
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(190, 70);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(212, 27);
            this.tbSurname.TabIndex = 13;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(110, 118);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(74, 21);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "E-Poçtu:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(190, 26);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(212, 27);
            this.tbName.TabIndex = 14;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(119, 73);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(65, 21);
            this.lblSurname.TabIndex = 6;
            this.lblSurname.Text = "Soyadı:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(379, 212);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 39);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Təmizlə";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(267, 212);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 39);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(157, 212);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 39);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Əlavə et";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(143, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 21);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Adı:";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Id";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Ad
            // 
            this.Ad.DataPropertyName = "name";
            this.Ad.HeaderText = "Ad";
            this.Ad.Name = "Ad";
            // 
            // Soyad
            // 
            this.Soyad.DataPropertyName = "surname";
            this.Soyad.HeaderText = "Soyad";
            this.Soyad.Name = "Soyad";
            // 
            // ElektronPoçt
            // 
            this.ElektronPoçt.DataPropertyName = "email";
            this.ElektronPoçt.HeaderText = "Elektron Poçt";
            this.ElektronPoçt.Name = "ElektronPoçt";
            // 
            // Şifrə
            // 
            this.Şifrə.DataPropertyName = "password";
            this.Şifrə.HeaderText = "Şifrə";
            this.Şifrə.Name = "Şifrə";
            // 
            // AdminTeachersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 485);
            this.Controls.Add(this.dgrvTeachers);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AdminTeachersPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminTeachersPage";
            this.Load += new System.EventHandler(this.AdminTeachersPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvTeachers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrvTeachers;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElektronPoçt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Şifrə;
    }
}