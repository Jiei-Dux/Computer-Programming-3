namespace StudentRegistrationApplication
{
    partial class frmStudentRegistrationValidation
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
            stdNameLabel = new Label();
            stdGenderLabel = new Label();
            stdBdayLabel = new Label();
            okBtn = new Button();
            stdName = new Label();
            stdGender = new Label();
            stdBday = new Label();
            SuspendLayout();
            // 
            // stdNameLabel
            // 
            stdNameLabel.AutoSize = true;
            stdNameLabel.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            stdNameLabel.Location = new Point(44, 37);
            stdNameLabel.Name = "stdNameLabel";
            stdNameLabel.Size = new Size(141, 26);
            stdNameLabel.TabIndex = 0;
            stdNameLabel.Text = "Student Name:";
            stdNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // stdGenderLabel
            // 
            stdGenderLabel.AutoSize = true;
            stdGenderLabel.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            stdGenderLabel.Location = new Point(44, 82);
            stdGenderLabel.Name = "stdGenderLabel";
            stdGenderLabel.Size = new Size(80, 26);
            stdGenderLabel.TabIndex = 1;
            stdGenderLabel.Text = "Gender:";
            stdGenderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // stdBdayLabel
            // 
            stdBdayLabel.AutoSize = true;
            stdBdayLabel.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            stdBdayLabel.Location = new Point(44, 129);
            stdBdayLabel.Name = "stdBdayLabel";
            stdBdayLabel.Size = new Size(126, 26);
            stdBdayLabel.TabIndex = 2;
            stdBdayLabel.Text = "Date of birth:";
            stdBdayLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // okBtn
            // 
            okBtn.Cursor = Cursors.Hand;
            okBtn.Location = new Point(332, 169);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(100, 30);
            okBtn.TabIndex = 3;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // stdName
            // 
            stdName.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            stdName.Location = new Point(191, 37);
            stdName.Name = "stdName";
            stdName.Size = new Size(195, 25);
            stdName.TabIndex = 4;
            stdName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // stdGender
            // 
            stdGender.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            stdGender.Location = new Point(191, 82);
            stdGender.Name = "stdGender";
            stdGender.Size = new Size(195, 25);
            stdGender.TabIndex = 5;
            stdGender.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // stdBday
            // 
            stdBday.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            stdBday.Location = new Point(191, 129);
            stdBday.Name = "stdBday";
            stdBday.Size = new Size(195, 25);
            stdBday.TabIndex = 6;
            stdBday.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmStudentRegistrationValidation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 211);
            Controls.Add(stdBday);
            Controls.Add(stdGender);
            Controls.Add(stdName);
            Controls.Add(okBtn);
            Controls.Add(stdBdayLabel);
            Controls.Add(stdGenderLabel);
            Controls.Add(stdNameLabel);
            MaximizeBox = false;
            MaximumSize = new Size(500, 600);
            MinimizeBox = false;
            Name = "frmStudentRegistrationValidation";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Registration Validation";
            Load += frmStudentRegistrationValidation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label stdNameLabel;
        private Label stdGenderLabel;
        private Label stdBdayLabel;
        private Button okBtn;
        private Label stdName;
        private Label stdGender;
        private Label stdBday;
    }
}