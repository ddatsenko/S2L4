
namespace LabWork4
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.CompanyNameValue = new System.Windows.Forms.Label();
            this.ResearchTopicLabel = new System.Windows.Forms.Label();
            this.ResearchTopicValue = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CostValue = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DateValue = new System.Windows.Forms.Label();
            this.PublicationsListBox = new System.Windows.Forms.ListBox();
            this.PublicationsListLabel = new System.Windows.Forms.Label();
            this.ShortDataLable = new System.Windows.Forms.Label();
            this.ShortDataValue = new System.Windows.Forms.Label();
            this.btnAddPublication = new System.Windows.Forms.Button();
            this.btnEditPublication = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompanyNameLabel.Location = new System.Drawing.Point(40, 30);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(66, 13);
            this.CompanyNameLabel.TabIndex = 0;
            this.CompanyNameLabel.Text = "Замовник";
            // 
            // CompanyNameValue
            // 
            this.CompanyNameValue.AutoSize = true;
            this.CompanyNameValue.Location = new System.Drawing.Point(175, 30);
            this.CompanyNameValue.Name = "CompanyNameValue";
            this.CompanyNameValue.Size = new System.Drawing.Size(16, 13);
            this.CompanyNameValue.TabIndex = 1;
            this.CompanyNameValue.Text = "---";
            // 
            // ResearchTopicLabel
            // 
            this.ResearchTopicLabel.AutoSize = true;
            this.ResearchTopicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResearchTopicLabel.Location = new System.Drawing.Point(40, 60);
            this.ResearchTopicLabel.Name = "ResearchTopicLabel";
            this.ResearchTopicLabel.Size = new System.Drawing.Size(117, 13);
            this.ResearchTopicLabel.TabIndex = 0;
            this.ResearchTopicLabel.Text = "Тема дослідження";
            // 
            // ResearchTopicValue
            // 
            this.ResearchTopicValue.AutoSize = true;
            this.ResearchTopicValue.Location = new System.Drawing.Point(175, 60);
            this.ResearchTopicValue.Name = "ResearchTopicValue";
            this.ResearchTopicValue.Size = new System.Drawing.Size(16, 13);
            this.ResearchTopicValue.TabIndex = 1;
            this.ResearchTopicValue.Text = "---";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CostLabel.Location = new System.Drawing.Point(40, 90);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(58, 13);
            this.CostLabel.TabIndex = 0;
            this.CostLabel.Text = "Вартість";
            // 
            // CostValue
            // 
            this.CostValue.AutoSize = true;
            this.CostValue.Location = new System.Drawing.Point(175, 90);
            this.CostValue.Name = "CostValue";
            this.CostValue.Size = new System.Drawing.Size(16, 13);
            this.CostValue.TabIndex = 1;
            this.CostValue.Text = "---";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateLabel.Location = new System.Drawing.Point(40, 120);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(85, 13);
            this.DateLabel.TabIndex = 0;
            this.DateLabel.Text = "Дата підпису";
            // 
            // DateValue
            // 
            this.DateValue.AutoSize = true;
            this.DateValue.Location = new System.Drawing.Point(175, 120);
            this.DateValue.Name = "DateValue";
            this.DateValue.Size = new System.Drawing.Size(16, 13);
            this.DateValue.TabIndex = 1;
            this.DateValue.Text = "---";
            // 
            // PublicationsListBox
            // 
            this.PublicationsListBox.FormattingEnabled = true;
            this.PublicationsListBox.Location = new System.Drawing.Point(40, 170);
            this.PublicationsListBox.Name = "PublicationsListBox";
            this.PublicationsListBox.Size = new System.Drawing.Size(420, 147);
            this.PublicationsListBox.TabIndex = 2;
            this.PublicationsListBox.SelectedIndexChanged += new System.EventHandler(this.PublicationSelected);
            // 
            // PublicationsListLabel
            // 
            this.PublicationsListLabel.AutoSize = true;
            this.PublicationsListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PublicationsListLabel.Location = new System.Drawing.Point(40, 150);
            this.PublicationsListLabel.Name = "PublicationsListLabel";
            this.PublicationsListLabel.Size = new System.Drawing.Size(119, 13);
            this.PublicationsListLabel.TabIndex = 0;
            this.PublicationsListLabel.Text = "Перелік публікацій";
            // 
            // ShortDataLable
            // 
            this.ShortDataLable.AutoSize = true;
            this.ShortDataLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShortDataLable.Location = new System.Drawing.Point(40, 390);
            this.ShortDataLable.Name = "ShortDataLable";
            this.ShortDataLable.Size = new System.Drawing.Size(150, 13);
            this.ShortDataLable.TabIndex = 0;
            this.ShortDataLable.Text = "Коротке представлення";
            // 
            // ShortDataValue
            // 
            this.ShortDataValue.AutoSize = true;
            this.ShortDataValue.Location = new System.Drawing.Point(40, 410);
            this.ShortDataValue.Name = "ShortDataValue";
            this.ShortDataValue.Size = new System.Drawing.Size(16, 13);
            this.ShortDataValue.TabIndex = 1;
            this.ShortDataValue.Text = "---";
            // 
            // btnAddPublication
            // 
            this.btnAddPublication.Location = new System.Drawing.Point(40, 330);
            this.btnAddPublication.Name = "btnAddPublication";
            this.btnAddPublication.Size = new System.Drawing.Size(150, 30);
            this.btnAddPublication.TabIndex = 3;
            this.btnAddPublication.Text = "Додати публікацію";
            this.btnAddPublication.UseVisualStyleBackColor = true;
            this.btnAddPublication.Click += new System.EventHandler(this.btnAddPublication_Click);
            // 
            // btnEditPublication
            // 
            this.btnEditPublication.Enabled = false;
            this.btnEditPublication.Location = new System.Drawing.Point(200, 330);
            this.btnEditPublication.Name = "btnEditPublication";
            this.btnEditPublication.Size = new System.Drawing.Size(150, 30);
            this.btnEditPublication.TabIndex = 3;
            this.btnEditPublication.Text = "Редагувати дані";
            this.btnEditPublication.UseVisualStyleBackColor = true;
            this.btnEditPublication.Click += new System.EventHandler(this.btnEditPublication_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 463);
            this.Controls.Add(this.btnEditPublication);
            this.Controls.Add(this.btnAddPublication);
            this.Controls.Add(this.PublicationsListBox);
            this.Controls.Add(this.ShortDataValue);
            this.Controls.Add(this.DateValue);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.CostValue);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.ResearchTopicValue);
            this.Controls.Add(this.ResearchTopicLabel);
            this.Controls.Add(this.CompanyNameValue);
            this.Controls.Add(this.ShortDataLable);
            this.Controls.Add(this.PublicationsListLabel);
            this.Controls.Add(this.CompanyNameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CompanyNameLabel;
        private System.Windows.Forms.Label CompanyNameValue;
        private System.Windows.Forms.Label ResearchTopicLabel;
        private System.Windows.Forms.Label ResearchTopicValue;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label CostValue;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label DateValue;
        private System.Windows.Forms.ListBox PublicationsListBox;
        private System.Windows.Forms.Label PublicationsListLabel;
        private System.Windows.Forms.Label ShortDataLable;
        private System.Windows.Forms.Label ShortDataValue;
        private System.Windows.Forms.Button btnAddPublication;
        private System.Windows.Forms.Button btnEditPublication;
    }
}

