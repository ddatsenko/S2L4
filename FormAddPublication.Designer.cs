
namespace LabWork4
{
    partial class FormAddPublication
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
            this.tbStudentFirstName = new System.Windows.Forms.TextBox();
            this.tbStudentLastName = new System.Windows.Forms.TextBox();
            this.dtpEnrollmentYear = new System.Windows.Forms.DateTimePicker();
            this.cmAchievement = new System.Windows.Forms.ComboBox();
            this.labelStudentFirstName = new System.Windows.Forms.Label();
            this.labelStudentLastName = new System.Windows.Forms.Label();
            this.labelEnrollmentYear = new System.Windows.Forms.Label();
            this.labelAchievement = new System.Windows.Forms.Label();
            this.labelHeading = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnCloseNoSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbStudentFirstName
            // 
            this.tbStudentFirstName.Location = new System.Drawing.Point(248, 77);
            this.tbStudentFirstName.Name = "tbStudentFirstName";
            this.tbStudentFirstName.Size = new System.Drawing.Size(250, 20);
            this.tbStudentFirstName.TabIndex = 0;
            // 
            // tbStudentLastName
            // 
            this.tbStudentLastName.Location = new System.Drawing.Point(248, 107);
            this.tbStudentLastName.Name = "tbStudentLastName";
            this.tbStudentLastName.Size = new System.Drawing.Size(250, 20);
            this.tbStudentLastName.TabIndex = 0;
            // 
            // dtpEnrollmentYear
            // 
            this.dtpEnrollmentYear.CustomFormat = "yyyy";
            this.dtpEnrollmentYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnrollmentYear.Location = new System.Drawing.Point(248, 137);
            this.dtpEnrollmentYear.MaxDate = new System.DateTime(2021, 6, 9, 4, 30, 17, 0);
            this.dtpEnrollmentYear.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpEnrollmentYear.Name = "dtpEnrollmentYear";
            this.dtpEnrollmentYear.Size = new System.Drawing.Size(250, 20);
            this.dtpEnrollmentYear.TabIndex = 1;
            this.dtpEnrollmentYear.Value = new System.DateTime(2021, 6, 9, 0, 0, 0, 0);
            // 
            // cmAchievement
            // 
            this.cmAchievement.FormattingEnabled = true;
            this.cmAchievement.Location = new System.Drawing.Point(248, 167);
            this.cmAchievement.Name = "cmAchievement";
            this.cmAchievement.Size = new System.Drawing.Size(250, 21);
            this.cmAchievement.TabIndex = 2;
            // 
            // labelStudentFirstName
            // 
            this.labelStudentFirstName.AutoSize = true;
            this.labelStudentFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudentFirstName.Location = new System.Drawing.Point(50, 80);
            this.labelStudentFirstName.Name = "labelStudentFirstName";
            this.labelStudentFirstName.Size = new System.Drawing.Size(87, 13);
            this.labelStudentFirstName.TabIndex = 3;
            this.labelStudentFirstName.Text = "Ім\'я студента";
            // 
            // labelStudentLastName
            // 
            this.labelStudentLastName.AutoSize = true;
            this.labelStudentLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudentLastName.Location = new System.Drawing.Point(50, 110);
            this.labelStudentLastName.Name = "labelStudentLastName";
            this.labelStudentLastName.Size = new System.Drawing.Size(121, 13);
            this.labelStudentLastName.TabIndex = 3;
            this.labelStudentLastName.Text = "Прізвище студента";
            // 
            // labelEnrollmentYear
            // 
            this.labelEnrollmentYear.AutoSize = true;
            this.labelEnrollmentYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnrollmentYear.Location = new System.Drawing.Point(50, 141);
            this.labelEnrollmentYear.Name = "labelEnrollmentYear";
            this.labelEnrollmentYear.Size = new System.Drawing.Size(167, 13);
            this.labelEnrollmentYear.TabIndex = 3;
            this.labelEnrollmentYear.Text = "Рік прийняття на навчання";
            // 
            // labelAchievement
            // 
            this.labelAchievement.AutoSize = true;
            this.labelAchievement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAchievement.Location = new System.Drawing.Point(50, 170);
            this.labelAchievement.Name = "labelAchievement";
            this.labelAchievement.Size = new System.Drawing.Size(167, 13);
            this.labelAchievement.TabIndex = 3;
            this.labelAchievement.Text = "Тип наукового досягнення";
            // 
            // labelHeading
            // 
            this.labelHeading.AutoSize = true;
            this.labelHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Bold);
            this.labelHeading.Location = new System.Drawing.Point(50, 30);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(291, 26);
            this.labelHeading.TabIndex = 3;
            this.labelHeading.Text = "Додання нової публікації";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(50, 210);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(150, 30);
            this.btnSaveChanges.TabIndex = 4;
            this.btnSaveChanges.Text = "Зберегти та вийти";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnCloseNoSave
            // 
            this.btnCloseNoSave.Location = new System.Drawing.Point(220, 210);
            this.btnCloseNoSave.Name = "btnCloseNoSave";
            this.btnCloseNoSave.Size = new System.Drawing.Size(150, 30);
            this.btnCloseNoSave.TabIndex = 4;
            this.btnCloseNoSave.Text = "Скасувати та вийти";
            this.btnCloseNoSave.UseVisualStyleBackColor = true;
            this.btnCloseNoSave.Click += new System.EventHandler(this.btnCloseNoSave_Click);
            // 
            // FormAddPublication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 319);
            this.Controls.Add(this.btnCloseNoSave);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.labelAchievement);
            this.Controls.Add(this.labelEnrollmentYear);
            this.Controls.Add(this.labelStudentLastName);
            this.Controls.Add(this.labelHeading);
            this.Controls.Add(this.labelStudentFirstName);
            this.Controls.Add(this.tbStudentFirstName);
            this.Controls.Add(this.tbStudentLastName);
            this.Controls.Add(this.dtpEnrollmentYear);
            this.Controls.Add(this.cmAchievement);
            this.Name = "FormAddPublication";
            this.Text = "AddPublication";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAddPublication_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbStudentFirstName;
        private System.Windows.Forms.TextBox tbStudentLastName;
        private System.Windows.Forms.DateTimePicker dtpEnrollmentYear;
        private System.Windows.Forms.ComboBox cmAchievement;
        private System.Windows.Forms.Label labelStudentFirstName;
        private System.Windows.Forms.Label labelStudentLastName;
        private System.Windows.Forms.Label labelEnrollmentYear;
        private System.Windows.Forms.Label labelAchievement;
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnCloseNoSave;
    }
}