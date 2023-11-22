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
            Label_stdRegFrom = new Label();
            Label_LName = new Label();
            Label_FName = new Label();
            Label_MName = new Label();
            Label_Gender = new Label();
            Label_Birthdate = new Label();
            label6 = new Label();
            TxtBox_LName = new TextBox();
            TxtBox_FName = new TextBox();
            TxtBox_MName = new TextBox();
            GenderContainer = new Panel();
            femaleBtn = new RadioButton();
            maleBtn = new RadioButton();
            cmbBox_Day = new ComboBox();
            cmbBox_Month = new ComboBox();
            cmbBox_Year = new ComboBox();
            cmbBox_Program = new ComboBox();
            regBtn = new Button();
            PB_userPFP = new PictureBox();
            browseBtn = new Button();
            GenderContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PB_userPFP).BeginInit();
            SuspendLayout();
            // 
            // Label_stdRegFrom
            // 
            Label_stdRegFrom.AutoSize = true;
            Label_stdRegFrom.Font = new Font("Arial", 22F, FontStyle.Bold, GraphicsUnit.Point);
            Label_stdRegFrom.Location = new Point(20, 20);
            Label_stdRegFrom.Margin = new Padding(5, 0, 5, 0);
            Label_stdRegFrom.Name = "Label_stdRegFrom";
            Label_stdRegFrom.Size = new Size(391, 35);
            Label_stdRegFrom.TabIndex = 0;
            Label_stdRegFrom.Text = "Student Registration Form";
            // 
            // Label_LName
            // 
            Label_LName.AutoSize = true;
            Label_LName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Label_LName.Location = new Point(60, 80);
            Label_LName.Margin = new Padding(5, 0, 5, 0);
            Label_LName.Name = "Label_LName";
            Label_LName.Size = new Size(96, 19);
            Label_LName.TabIndex = 1;
            Label_LName.Text = "Last Name*";
            Label_LName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label_FName
            // 
            Label_FName.AutoSize = true;
            Label_FName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Label_FName.Location = new Point(60, 130);
            Label_FName.Margin = new Padding(5, 0, 5, 0);
            Label_FName.Name = "Label_FName";
            Label_FName.Size = new Size(97, 19);
            Label_FName.TabIndex = 2;
            Label_FName.Text = "First Name*";
            // 
            // Label_MName
            // 
            Label_MName.AutoSize = true;
            Label_MName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Label_MName.Location = new Point(60, 180);
            Label_MName.Margin = new Padding(5, 0, 5, 0);
            Label_MName.Name = "Label_MName";
            Label_MName.Size = new Size(107, 19);
            Label_MName.TabIndex = 3;
            Label_MName.Text = "Middle Name";
            // 
            // Label_Gender
            // 
            Label_Gender.AutoSize = true;
            Label_Gender.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Label_Gender.Location = new Point(60, 240);
            Label_Gender.Margin = new Padding(5, 0, 5, 0);
            Label_Gender.Name = "Label_Gender";
            Label_Gender.Size = new Size(71, 19);
            Label_Gender.TabIndex = 4;
            Label_Gender.Text = "Gender*";
            // 
            // Label_Birthdate
            // 
            Label_Birthdate.AutoSize = true;
            Label_Birthdate.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Label_Birthdate.Location = new Point(60, 280);
            Label_Birthdate.Margin = new Padding(5, 0, 5, 0);
            Label_Birthdate.Name = "Label_Birthdate";
            Label_Birthdate.Size = new Size(110, 19);
            Label_Birthdate.TabIndex = 5;
            Label_Birthdate.Text = "Date of Birth*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(60, 340);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(147, 19);
            label6.TabIndex = 6;
            label6.Text = "Program to Apply*";
            // 
            // TxtBox_LName
            // 
            TxtBox_LName.Anchor = AnchorStyles.Left;
            TxtBox_LName.BackColor = Color.FromArgb(64, 64, 64);
            TxtBox_LName.BorderStyle = BorderStyle.None;
            TxtBox_LName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBox_LName.ForeColor = Color.White;
            TxtBox_LName.Location = new Point(60, 100);
            TxtBox_LName.MaximumSize = new Size(400, 20);
            TxtBox_LName.MinimumSize = new Size(400, 20);
            TxtBox_LName.Name = "TxtBox_LName";
            TxtBox_LName.Size = new Size(400, 20);
            TxtBox_LName.TabIndex = 7;
            // 
            // TxtBox_FName
            // 
            TxtBox_FName.Anchor = AnchorStyles.Left;
            TxtBox_FName.BackColor = Color.FromArgb(64, 64, 64);
            TxtBox_FName.BorderStyle = BorderStyle.None;
            TxtBox_FName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBox_FName.ForeColor = Color.White;
            TxtBox_FName.Location = new Point(60, 150);
            TxtBox_FName.MaximumSize = new Size(400, 20);
            TxtBox_FName.MinimumSize = new Size(400, 20);
            TxtBox_FName.Name = "TxtBox_FName";
            TxtBox_FName.Size = new Size(400, 20);
            TxtBox_FName.TabIndex = 8;
            // 
            // TxtBox_MName
            // 
            TxtBox_MName.Anchor = AnchorStyles.Left;
            TxtBox_MName.BackColor = Color.FromArgb(64, 64, 64);
            TxtBox_MName.BorderStyle = BorderStyle.None;
            TxtBox_MName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBox_MName.ForeColor = Color.White;
            TxtBox_MName.Location = new Point(60, 200);
            TxtBox_MName.MaximumSize = new Size(400, 20);
            TxtBox_MName.MinimumSize = new Size(400, 20);
            TxtBox_MName.Name = "TxtBox_MName";
            TxtBox_MName.Size = new Size(400, 20);
            TxtBox_MName.TabIndex = 9;
            // 
            // GenderContainer
            // 
            GenderContainer.Controls.Add(femaleBtn);
            GenderContainer.Controls.Add(maleBtn);
            GenderContainer.Location = new Point(140, 230);
            GenderContainer.Name = "GenderContainer";
            GenderContainer.Size = new Size(320, 40);
            GenderContainer.TabIndex = 10;
            // 
            // femaleBtn
            // 
            femaleBtn.AutoSize = true;
            femaleBtn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            femaleBtn.Location = new Point(120, 10);
            femaleBtn.Name = "femaleBtn";
            femaleBtn.Size = new Size(79, 22);
            femaleBtn.TabIndex = 1;
            femaleBtn.TabStop = true;
            femaleBtn.Text = "Female";
            femaleBtn.UseVisualStyleBackColor = true;
            // 
            // maleBtn
            // 
            maleBtn.AutoSize = true;
            maleBtn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maleBtn.Location = new Point(20, 10);
            maleBtn.Name = "maleBtn";
            maleBtn.Size = new Size(60, 22);
            maleBtn.TabIndex = 0;
            maleBtn.TabStop = true;
            maleBtn.Text = "Male";
            maleBtn.UseVisualStyleBackColor = true;
            // 
            // cmbBox_Day
            // 
            cmbBox_Day.BackColor = Color.FromArgb(64, 64, 64);
            cmbBox_Day.FlatStyle = FlatStyle.Flat;
            cmbBox_Day.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBox_Day.ForeColor = Color.White;
            cmbBox_Day.FormattingEnabled = true;
            cmbBox_Day.Location = new Point(60, 300);
            cmbBox_Day.Name = "cmbBox_Day";
            cmbBox_Day.Size = new Size(121, 26);
            cmbBox_Day.TabIndex = 11;
            cmbBox_Day.Text = "-Day-";
            cmbBox_Day.DropDown += cmbDay_Dropdown;
            // 
            // cmbBox_Month
            // 
            cmbBox_Month.BackColor = Color.FromArgb(64, 64, 64);
            cmbBox_Month.FlatStyle = FlatStyle.Flat;
            cmbBox_Month.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBox_Month.ForeColor = Color.White;
            cmbBox_Month.FormattingEnabled = true;
            cmbBox_Month.Location = new Point(200, 300);
            cmbBox_Month.Name = "cmbBox_Month";
            cmbBox_Month.Size = new Size(121, 26);
            cmbBox_Month.TabIndex = 12;
            cmbBox_Month.Text = "-Month-";
            cmbBox_Month.DropDown += cmbMonth_Dropdown;
            // 
            // cmbBox_Year
            // 
            cmbBox_Year.BackColor = Color.FromArgb(64, 64, 64);
            cmbBox_Year.FlatStyle = FlatStyle.Flat;
            cmbBox_Year.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBox_Year.ForeColor = Color.White;
            cmbBox_Year.FormattingEnabled = true;
            cmbBox_Year.Location = new Point(340, 300);
            cmbBox_Year.Name = "cmbBox_Year";
            cmbBox_Year.Size = new Size(121, 26);
            cmbBox_Year.TabIndex = 13;
            cmbBox_Year.Text = "-Year-";
            cmbBox_Year.DropDown += cmbYear_Dropdown;
            // 
            // cmbBox_Program
            // 
            cmbBox_Program.BackColor = Color.FromArgb(64, 64, 64);
            cmbBox_Program.FlatStyle = FlatStyle.Flat;
            cmbBox_Program.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBox_Program.ForeColor = Color.White;
            cmbBox_Program.FormattingEnabled = true;
            cmbBox_Program.Location = new Point(60, 360);
            cmbBox_Program.Name = "cmbBox_Program";
            cmbBox_Program.Size = new Size(550, 26);
            cmbBox_Program.TabIndex = 14;
            cmbBox_Program.Text = "-Select Program-";
            cmbBox_Program.DropDown += SchoolProgram_Dropdown;
            // 
            // regBtn
            // 
            regBtn.BackColor = Color.Crimson;
            regBtn.FlatStyle = FlatStyle.Flat;
            regBtn.Location = new Point(60, 400);
            regBtn.MaximumSize = new Size(200, 50);
            regBtn.MinimumSize = new Size(200, 50);
            regBtn.Name = "regBtn";
            regBtn.Size = new Size(200, 50);
            regBtn.TabIndex = 15;
            regBtn.Text = "Register Student";
            regBtn.UseVisualStyleBackColor = false;
            regBtn.Click += regBtn_Click;
            // 
            // PB_userPFP
            // 
            PB_userPFP.BackColor = Color.FromArgb(64, 64, 64);
            PB_userPFP.Location = new Point(530, 80);
            PB_userPFP.Name = "PB_userPFP";
            PB_userPFP.Size = new Size(200, 200);
            PB_userPFP.SizeMode = PictureBoxSizeMode.Zoom;
            PB_userPFP.TabIndex = 16;
            PB_userPFP.TabStop = false;
            // 
            // browseBtn
            // 
            browseBtn.BackColor = Color.Gray;
            browseBtn.FlatStyle = FlatStyle.Flat;
            browseBtn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            browseBtn.Location = new Point(580, 300);
            browseBtn.Name = "browseBtn";
            browseBtn.Size = new Size(100, 30);
            browseBtn.TabIndex = 17;
            browseBtn.Text = "Browse";
            browseBtn.UseVisualStyleBackColor = false;
            browseBtn.Click += browseBtn_Click;
            // 
            // frmStudentRegistration
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Black;
            ClientSize = new Size(784, 481);
            Controls.Add(browseBtn);
            Controls.Add(PB_userPFP);
            Controls.Add(regBtn);
            Controls.Add(cmbBox_Program);
            Controls.Add(cmbBox_Year);
            Controls.Add(cmbBox_Month);
            Controls.Add(cmbBox_Day);
            Controls.Add(GenderContainer);
            Controls.Add(TxtBox_MName);
            Controls.Add(TxtBox_FName);
            Controls.Add(TxtBox_LName);
            Controls.Add(label6);
            Controls.Add(Label_Birthdate);
            Controls.Add(Label_Gender);
            Controls.Add(Label_MName);
            Controls.Add(Label_FName);
            Controls.Add(Label_LName);
            Controls.Add(Label_stdRegFrom);
            Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Location = new Point(90, 65);
            Margin = new Padding(5);
            MaximizeBox = false;
            MaximumSize = new Size(800, 520);
            MinimumSize = new Size(800, 520);
            Name = "frmStudentRegistration";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Registration";
            GenderContainer.ResumeLayout(false);
            GenderContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PB_userPFP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_stdRegFrom;
        private Label Label_LName;
        private Label Label_FName;
        private Label Label_MName;
        private Label Label_Gender;
        private Label Label_Birthdate;
        private Label label6;
        private TextBox TxtBox_LName;
        private TextBox TxtBox_FName;
        private TextBox TxtBox_MName;
        private Panel GenderContainer;
        private ComboBox cmbBox_Day;
        private ComboBox cmbBox_Month;
        private ComboBox cmbBox_Year;
        private RadioButton femaleBtn;
        private RadioButton maleBtn;
        private ComboBox cmbBox_Program;
        private Button regBtn;
        private PictureBox PB_userPFP;
        private Button browseBtn;
    }
}