namespace StudentRegistrationApplication
{
    partial class frmStudentRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            stdRegLabel = new Label();
            lnLabel = new Label();
            mnLabel = new Label();
            fnLabel = new Label();
            birthLabel = new Label();
            genderLabel = new Label();
            lnTxtBox = new TextBox();
            fnTxtBox = new TextBox();
            mnTxtBox = new TextBox();
            cmbDay = new ComboBox();
            cmbYear = new ComboBox();
            cmbMonth = new ComboBox();
            button1 = new Button();
            femaleBtn = new RadioButton();
            maleBtn = new RadioButton();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // stdRegLabel
            // 
            stdRegLabel.Font = new Font("Calibri", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            stdRegLabel.Location = new Point(12, 9);
            stdRegLabel.Name = "stdRegLabel";
            stdRegLabel.Size = new Size(460, 45);
            stdRegLabel.TabIndex = 0;
            stdRegLabel.Text = "STUDENT REGISTRATION";
            stdRegLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lnLabel
            // 
            lnLabel.AutoSize = true;
            lnLabel.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lnLabel.Location = new Point(48, 90);
            lnLabel.Name = "lnLabel";
            lnLabel.Size = new Size(92, 19);
            lnLabel.TabIndex = 1;
            lnLabel.Text = "Last Name *";
            lnLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // mnLabel
            // 
            mnLabel.AutoSize = true;
            mnLabel.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mnLabel.Location = new Point(50, 220);
            mnLabel.Name = "mnLabel";
            mnLabel.Size = new Size(101, 19);
            mnLabel.TabIndex = 2;
            mnLabel.Text = "Middle Name";
            mnLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // fnLabel
            // 
            fnLabel.AutoSize = true;
            fnLabel.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            fnLabel.Location = new Point(50, 155);
            fnLabel.Name = "fnLabel";
            fnLabel.Size = new Size(94, 19);
            fnLabel.TabIndex = 3;
            fnLabel.Text = "First Name *";
            fnLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // birthLabel
            // 
            birthLabel.AutoSize = true;
            birthLabel.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            birthLabel.Location = new Point(50, 337);
            birthLabel.Name = "birthLabel";
            birthLabel.Size = new Size(109, 19);
            birthLabel.TabIndex = 4;
            birthLabel.Text = "Date of birth *";
            birthLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            genderLabel.Location = new Point(50, 294);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(71, 19);
            genderLabel.TabIndex = 5;
            genderLabel.Text = "Gender *";
            genderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lnTxtBox
            // 
            lnTxtBox.BackColor = SystemColors.Control;
            lnTxtBox.BorderStyle = BorderStyle.FixedSingle;
            lnTxtBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lnTxtBox.Location = new Point(50, 119);
            lnTxtBox.Name = "lnTxtBox";
            lnTxtBox.Size = new Size(385, 27);
            lnTxtBox.TabIndex = 6;
            lnTxtBox.WordWrap = false;
            // 
            // fnTxtBox
            // 
            fnTxtBox.BackColor = SystemColors.Control;
            fnTxtBox.BorderStyle = BorderStyle.FixedSingle;
            fnTxtBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fnTxtBox.Location = new Point(50, 184);
            fnTxtBox.Name = "fnTxtBox";
            fnTxtBox.Size = new Size(385, 27);
            fnTxtBox.TabIndex = 7;
            fnTxtBox.WordWrap = false;
            // 
            // mnTxtBox
            // 
            mnTxtBox.BackColor = SystemColors.Control;
            mnTxtBox.BorderStyle = BorderStyle.FixedSingle;
            mnTxtBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mnTxtBox.Location = new Point(50, 249);
            mnTxtBox.Name = "mnTxtBox";
            mnTxtBox.Size = new Size(385, 27);
            mnTxtBox.TabIndex = 8;
            mnTxtBox.WordWrap = false;
            // 
            // cmbDay
            // 
            cmbDay.Cursor = Cursors.Hand;
            cmbDay.DropDownHeight = 80;
            cmbDay.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDay.FormattingEnabled = true;
            cmbDay.IntegralHeight = false;
            cmbDay.Location = new Point(50, 366);
            cmbDay.Name = "cmbDay";
            cmbDay.Size = new Size(110, 27);
            cmbDay.TabIndex = 10;
            cmbDay.Text = " --- Day ---";
            cmbDay.DropDown += cmbDay_DropDown;
            // 
            // cmbYear
            // 
            cmbYear.Cursor = Cursors.Hand;
            cmbYear.DropDownHeight = 80;
            cmbYear.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbYear.FormattingEnabled = true;
            cmbYear.IntegralHeight = false;
            cmbYear.ItemHeight = 19;
            cmbYear.Location = new Point(305, 366);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(130, 27);
            cmbYear.TabIndex = 11;
            cmbYear.Text = " --- Year ---";
            cmbYear.DropDown += cmbYear_DropDown;
            // 
            // cmbMonth
            // 
            cmbMonth.Cursor = Cursors.Hand;
            cmbMonth.DropDownHeight = 80;
            cmbMonth.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbMonth.FormattingEnabled = true;
            cmbMonth.IntegralHeight = false;
            cmbMonth.Location = new Point(166, 366);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(133, 27);
            cmbMonth.TabIndex = 12;
            cmbMonth.Text = " --- Month ---";
            cmbMonth.DropDown += cmbMonth_DropDown;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = SystemColors.Control;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(48, 449);
            button1.Name = "button1";
            button1.Size = new Size(387, 66);
            button1.TabIndex = 13;
            button1.Text = "REGISTER ME!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += regBtn_Click;
            // 
            // femaleBtn
            // 
            femaleBtn.AutoSize = true;
            femaleBtn.Cursor = Cursors.Hand;
            femaleBtn.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            femaleBtn.Location = new Point(96, 3);
            femaleBtn.Name = "femaleBtn";
            femaleBtn.Size = new Size(74, 23);
            femaleBtn.TabIndex = 1;
            femaleBtn.TabStop = true;
            femaleBtn.Text = "Female";
            femaleBtn.UseVisualStyleBackColor = true;
            // 
            // maleBtn
            // 
            maleBtn.AutoSize = true;
            maleBtn.Cursor = Cursors.Hand;
            maleBtn.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maleBtn.Location = new Point(3, 3);
            maleBtn.Name = "maleBtn";
            maleBtn.Size = new Size(60, 23);
            maleBtn.TabIndex = 0;
            maleBtn.TabStop = true;
            maleBtn.Text = "Male";
            maleBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(maleBtn);
            panel1.Controls.Add(femaleBtn);
            panel1.Location = new Point(144, 291);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 38);
            panel1.TabIndex = 14;
            // 
            // frmStudentRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 561);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(cmbMonth);
            Controls.Add(cmbYear);
            Controls.Add(cmbDay);
            Controls.Add(mnTxtBox);
            Controls.Add(fnTxtBox);
            Controls.Add(lnTxtBox);
            Controls.Add(genderLabel);
            Controls.Add(birthLabel);
            Controls.Add(fnLabel);
            Controls.Add(mnLabel);
            Controls.Add(lnLabel);
            Controls.Add(stdRegLabel);
            MaximizeBox = false;
            MaximumSize = new Size(500, 600);
            MinimumSize = new Size(500, 600);
            Name = "frmStudentRegistration";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Registration";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label stdRegLabel;
        private Label lnLabel;
        private Label mnLabel;
        private Label fnLabel;
        private Label birthLabel;
        private Label genderLabel;
        private TextBox lnTxtBox;
        private TextBox fnTxtBox;
        private TextBox mnTxtBox;
        private ComboBox cmbDay;
        private ComboBox cmbYear;
        private ComboBox cmbMonth;
        private Button button1;
        private RadioButton femaleBtn;
        private RadioButton maleBtn;
        private Panel panel1;
    }
}