namespace EmployeeApplication
{
    partial class frmComputeSalary
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
            Txt_FName = new TextBox();
            Lbl_FName1 = new Label();
            Lbl_LName1 = new Label();
            Lbl_Dpt = new Label();
            Lbl_JobTitle = new Label();
            Lbl_RPH = new Label();
            Lbl_Hrs = new Label();
            Lbl_FName2 = new Label();
            Lbl_LName2 = new Label();
            Lbl_Salary = new Label();
            Lbl_UsrFName = new Label();
            Lbl_UsrLName = new Label();
            Lbl_UsrSalary = new Label();
            Txt_LName = new TextBox();
            Txt_Dpt = new TextBox();
            Txt_JobTitle = new TextBox();
            Txt_RPH = new TextBox();
            Txt_Hrs = new TextBox();
            btn_ComputeSalary = new Button();
            SuspendLayout();
            // 
            // Txt_FName
            // 
            Txt_FName.BackColor = Color.Black;
            Txt_FName.BorderStyle = BorderStyle.FixedSingle;
            Txt_FName.ForeColor = Color.White;
            Txt_FName.Location = new Point(40, 70);
            Txt_FName.Name = "Txt_FName";
            Txt_FName.Size = new Size(200, 26);
            Txt_FName.TabIndex = 0;
            // 
            // Lbl_FName1
            // 
            Lbl_FName1.AutoSize = true;
            Lbl_FName1.Location = new Point(40, 40);
            Lbl_FName1.Name = "Lbl_FName1";
            Lbl_FName1.Size = new Size(93, 18);
            Lbl_FName1.TabIndex = 1;
            Lbl_FName1.Text = "First Name :";
            // 
            // Lbl_LName1
            // 
            Lbl_LName1.AutoSize = true;
            Lbl_LName1.Location = new Point(280, 40);
            Lbl_LName1.Name = "Lbl_LName1";
            Lbl_LName1.Size = new Size(92, 18);
            Lbl_LName1.TabIndex = 2;
            Lbl_LName1.Text = "Last Name :";
            // 
            // Lbl_Dpt
            // 
            Lbl_Dpt.AutoSize = true;
            Lbl_Dpt.Location = new Point(40, 120);
            Lbl_Dpt.Name = "Lbl_Dpt";
            Lbl_Dpt.Size = new Size(98, 18);
            Lbl_Dpt.TabIndex = 3;
            Lbl_Dpt.Text = "Department :";
            // 
            // Lbl_JobTitle
            // 
            Lbl_JobTitle.AutoSize = true;
            Lbl_JobTitle.Location = new Point(280, 120);
            Lbl_JobTitle.Name = "Lbl_JobTitle";
            Lbl_JobTitle.Size = new Size(74, 18);
            Lbl_JobTitle.TabIndex = 4;
            Lbl_JobTitle.Text = "Job Title :";
            // 
            // Lbl_RPH
            // 
            Lbl_RPH.AutoSize = true;
            Lbl_RPH.Location = new Point(40, 240);
            Lbl_RPH.Name = "Lbl_RPH";
            Lbl_RPH.Size = new Size(115, 18);
            Lbl_RPH.TabIndex = 5;
            Lbl_RPH.Text = "Rate Per Hour :";
            // 
            // Lbl_Hrs
            // 
            Lbl_Hrs.AutoSize = true;
            Lbl_Hrs.Location = new Point(280, 240);
            Lbl_Hrs.Name = "Lbl_Hrs";
            Lbl_Hrs.Size = new Size(152, 18);
            Lbl_Hrs.TabIndex = 6;
            Lbl_Hrs.Text = "Total Hours Worked :";
            // 
            // Lbl_FName2
            // 
            Lbl_FName2.AutoSize = true;
            Lbl_FName2.Location = new Point(40, 400);
            Lbl_FName2.Name = "Lbl_FName2";
            Lbl_FName2.Size = new Size(93, 18);
            Lbl_FName2.TabIndex = 7;
            Lbl_FName2.Text = "First Name :";
            // 
            // Lbl_LName2
            // 
            Lbl_LName2.AutoSize = true;
            Lbl_LName2.Location = new Point(40, 440);
            Lbl_LName2.Name = "Lbl_LName2";
            Lbl_LName2.Size = new Size(92, 18);
            Lbl_LName2.TabIndex = 8;
            Lbl_LName2.Text = "Last Name :";
            // 
            // Lbl_Salary
            // 
            Lbl_Salary.AutoSize = true;
            Lbl_Salary.Location = new Point(40, 480);
            Lbl_Salary.Name = "Lbl_Salary";
            Lbl_Salary.Size = new Size(104, 18);
            Lbl_Salary.TabIndex = 9;
            Lbl_Salary.Text = "Basic Salary :";
            // 
            // Lbl_UsrFName
            // 
            Lbl_UsrFName.AutoSize = true;
            Lbl_UsrFName.Location = new Point(180, 400);
            Lbl_UsrFName.Name = "Lbl_UsrFName";
            Lbl_UsrFName.Size = new Size(149, 18);
            Lbl_UsrFName.TabIndex = 10;
            Lbl_UsrFName.Text = "< First Name Here >";
            // 
            // Lbl_UsrLName
            // 
            Lbl_UsrLName.AutoSize = true;
            Lbl_UsrLName.Location = new Point(180, 440);
            Lbl_UsrLName.Name = "Lbl_UsrLName";
            Lbl_UsrLName.Size = new Size(148, 18);
            Lbl_UsrLName.TabIndex = 11;
            Lbl_UsrLName.Text = "< Last Name Here >";
            // 
            // Lbl_UsrSalary
            // 
            Lbl_UsrSalary.AutoSize = true;
            Lbl_UsrSalary.Location = new Point(180, 480);
            Lbl_UsrSalary.Name = "Lbl_UsrSalary";
            Lbl_UsrSalary.Size = new Size(48, 18);
            Lbl_UsrSalary.TabIndex = 12;
            Lbl_UsrSalary.Text = "00.00";
            // 
            // Txt_LName
            // 
            Txt_LName.BackColor = Color.Black;
            Txt_LName.BorderStyle = BorderStyle.FixedSingle;
            Txt_LName.ForeColor = Color.White;
            Txt_LName.Location = new Point(280, 70);
            Txt_LName.Name = "Txt_LName";
            Txt_LName.Size = new Size(200, 26);
            Txt_LName.TabIndex = 13;
            // 
            // Txt_Dpt
            // 
            Txt_Dpt.BackColor = Color.Black;
            Txt_Dpt.BorderStyle = BorderStyle.FixedSingle;
            Txt_Dpt.ForeColor = Color.White;
            Txt_Dpt.Location = new Point(40, 150);
            Txt_Dpt.Name = "Txt_Dpt";
            Txt_Dpt.Size = new Size(200, 26);
            Txt_Dpt.TabIndex = 14;
            // 
            // Txt_JobTitle
            // 
            Txt_JobTitle.BackColor = Color.Black;
            Txt_JobTitle.BorderStyle = BorderStyle.FixedSingle;
            Txt_JobTitle.ForeColor = Color.White;
            Txt_JobTitle.Location = new Point(280, 150);
            Txt_JobTitle.Name = "Txt_JobTitle";
            Txt_JobTitle.Size = new Size(200, 26);
            Txt_JobTitle.TabIndex = 15;
            // 
            // Txt_RPH
            // 
            Txt_RPH.BackColor = Color.Black;
            Txt_RPH.BorderStyle = BorderStyle.FixedSingle;
            Txt_RPH.ForeColor = Color.White;
            Txt_RPH.Location = new Point(40, 270);
            Txt_RPH.Name = "Txt_RPH";
            Txt_RPH.Size = new Size(200, 26);
            Txt_RPH.TabIndex = 16;
            // 
            // Txt_Hrs
            // 
            Txt_Hrs.BackColor = Color.Black;
            Txt_Hrs.BorderStyle = BorderStyle.FixedSingle;
            Txt_Hrs.ForeColor = Color.White;
            Txt_Hrs.Location = new Point(280, 270);
            Txt_Hrs.Name = "Txt_Hrs";
            Txt_Hrs.Size = new Size(200, 26);
            Txt_Hrs.TabIndex = 17;
            // 
            // btn_ComputeSalary
            // 
            btn_ComputeSalary.BackColor = Color.Black;
            btn_ComputeSalary.FlatStyle = FlatStyle.Flat;
            btn_ComputeSalary.Location = new Point(185, 330);
            btn_ComputeSalary.Name = "btn_ComputeSalary";
            btn_ComputeSalary.Size = new Size(150, 40);
            btn_ComputeSalary.TabIndex = 18;
            btn_ComputeSalary.Text = "Compute Salary";
            btn_ComputeSalary.UseVisualStyleBackColor = false;
            btn_ComputeSalary.Click += btn_ComputeSalary_Click;
            // 
            // frmComputeSalary
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(524, 541);
            Controls.Add(btn_ComputeSalary);
            Controls.Add(Txt_Hrs);
            Controls.Add(Txt_RPH);
            Controls.Add(Txt_JobTitle);
            Controls.Add(Txt_Dpt);
            Controls.Add(Txt_LName);
            Controls.Add(Lbl_UsrSalary);
            Controls.Add(Lbl_UsrLName);
            Controls.Add(Lbl_UsrFName);
            Controls.Add(Lbl_Salary);
            Controls.Add(Lbl_LName2);
            Controls.Add(Lbl_FName2);
            Controls.Add(Lbl_Hrs);
            Controls.Add(Lbl_RPH);
            Controls.Add(Lbl_JobTitle);
            Controls.Add(Lbl_Dpt);
            Controls.Add(Lbl_LName1);
            Controls.Add(Lbl_FName1);
            Controls.Add(Txt_FName);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frmComputeSalary";
            ShowIcon = false;
            Text = "Employee Salary Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Txt_FName;
        private Label Lbl_FName1;
        private Label Lbl_LName1;
        private Label Lbl_Dpt;
        private Label Lbl_JobTitle;
        private Label Lbl_RPH;
        private Label Lbl_Hrs;
        private Label Lbl_FName2;
        private Label Lbl_LName2;
        private Label Lbl_Salary;
        private Label Lbl_UsrFName;
        private Label Lbl_UsrLName;
        private Label Lbl_UsrSalary;
        private TextBox Txt_LName;
        private TextBox Txt_Dpt;
        private TextBox Txt_JobTitle;
        private TextBox Txt_RPH;
        private TextBox Txt_Hrs;
        private Button btn_ComputeSalary;
    }
}