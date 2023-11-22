namespace EmployeeApplication
{
    partial class frmEmployeeDatabase
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Label_AddEmployee = new Label();
            Label_EmployeeID = new Label();
            Label_FName = new Label();
            Label_LName = new Label();
            Label_Position = new Label();
            Label_EmployeeList = new Label();
            TxtBox_EmployeeID = new TextBox();
            TxtBox_FName = new TextBox();
            TxtBox_LName = new TextBox();
            TxtBox_Position = new TextBox();
            submitBtn = new Button();
            employeeDatabase = new DataGridView();
            employeeID = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)employeeDatabase).BeginInit();
            SuspendLayout();
            // 
            // Label_AddEmployee
            // 
            Label_AddEmployee.AutoSize = true;
            Label_AddEmployee.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point);
            Label_AddEmployee.Location = new Point(30, 30);
            Label_AddEmployee.Name = "Label_AddEmployee";
            Label_AddEmployee.Size = new Size(216, 32);
            Label_AddEmployee.TabIndex = 0;
            Label_AddEmployee.Text = "Add Employee:";
            // 
            // Label_EmployeeID
            // 
            Label_EmployeeID.AutoSize = true;
            Label_EmployeeID.Location = new Point(30, 100);
            Label_EmployeeID.Name = "Label_EmployeeID";
            Label_EmployeeID.Size = new Size(107, 18);
            Label_EmployeeID.TabIndex = 1;
            Label_EmployeeID.Text = "Employee ID *";
            // 
            // Label_FName
            // 
            Label_FName.AutoSize = true;
            Label_FName.Location = new Point(30, 170);
            Label_FName.Name = "Label_FName";
            Label_FName.Size = new Size(95, 18);
            Label_FName.TabIndex = 2;
            Label_FName.Text = "First Name *";
            // 
            // Label_LName
            // 
            Label_LName.AutoSize = true;
            Label_LName.Location = new Point(30, 240);
            Label_LName.Name = "Label_LName";
            Label_LName.Size = new Size(94, 18);
            Label_LName.TabIndex = 3;
            Label_LName.Text = "Last Name *";
            // 
            // Label_Position
            // 
            Label_Position.AutoSize = true;
            Label_Position.Location = new Point(30, 310);
            Label_Position.Name = "Label_Position";
            Label_Position.Size = new Size(75, 18);
            Label_Position.TabIndex = 4;
            Label_Position.Text = "Position *";
            // 
            // Label_EmployeeList
            // 
            Label_EmployeeList.AutoSize = true;
            Label_EmployeeList.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Label_EmployeeList.Location = new Point(300, 30);
            Label_EmployeeList.Name = "Label_EmployeeList";
            Label_EmployeeList.Size = new Size(193, 32);
            Label_EmployeeList.TabIndex = 5;
            Label_EmployeeList.Text = "Employee List:";
            // 
            // TxtBox_EmployeeID
            // 
            TxtBox_EmployeeID.Location = new Point(30, 130);
            TxtBox_EmployeeID.Name = "TxtBox_EmployeeID";
            TxtBox_EmployeeID.Size = new Size(240, 26);
            TxtBox_EmployeeID.TabIndex = 6;
            // 
            // TxtBox_FName
            // 
            TxtBox_FName.Location = new Point(30, 200);
            TxtBox_FName.Name = "TxtBox_FName";
            TxtBox_FName.Size = new Size(240, 26);
            TxtBox_FName.TabIndex = 7;
            // 
            // TxtBox_LName
            // 
            TxtBox_LName.Location = new Point(30, 270);
            TxtBox_LName.Name = "TxtBox_LName";
            TxtBox_LName.Size = new Size(240, 26);
            TxtBox_LName.TabIndex = 8;
            // 
            // TxtBox_Position
            // 
            TxtBox_Position.Location = new Point(30, 340);
            TxtBox_Position.Name = "TxtBox_Position";
            TxtBox_Position.Size = new Size(240, 26);
            TxtBox_Position.TabIndex = 9;
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.Black;
            submitBtn.FlatStyle = FlatStyle.Flat;
            submitBtn.Location = new Point(70, 390);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(160, 50);
            submitBtn.TabIndex = 11;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
            // 
            // employeeDatabase
            // 
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            employeeDatabase.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            employeeDatabase.BackgroundColor = Color.Black;
            employeeDatabase.CellBorderStyle = DataGridViewCellBorderStyle.None;
            employeeDatabase.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            employeeDatabase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            employeeDatabase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeDatabase.Columns.AddRange(new DataGridViewColumn[] { employeeID, FirstName, LastName, Position });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.Black;
            dataGridViewCellStyle7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            employeeDatabase.DefaultCellStyle = dataGridViewCellStyle7;
            employeeDatabase.EnableHeadersVisualStyles = false;
            employeeDatabase.GridColor = Color.Black;
            employeeDatabase.Location = new Point(300, 100);
            employeeDatabase.Name = "employeeDatabase";
            employeeDatabase.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.Black;
            dataGridViewCellStyle8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            employeeDatabase.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.BackColor = Color.Black;
            dataGridViewCellStyle9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            employeeDatabase.RowsDefaultCellStyle = dataGridViewCellStyle9;
            employeeDatabase.RowTemplate.Height = 25;
            employeeDatabase.Size = new Size(510, 340);
            employeeDatabase.TabIndex = 10;
            // 
            // employeeID
            // 
            employeeID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            employeeID.DefaultCellStyle = dataGridViewCellStyle3;
            employeeID.HeaderText = "ID";
            employeeID.Name = "employeeID";
            // 
            // FirstName
            // 
            FirstName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.BackColor = Color.Black;
            dataGridViewCellStyle4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            FirstName.DefaultCellStyle = dataGridViewCellStyle4;
            FirstName.HeaderText = "First Name";
            FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            LastName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.BackColor = Color.Black;
            dataGridViewCellStyle5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            LastName.DefaultCellStyle = dataGridViewCellStyle5;
            LastName.HeaderText = "Last Name";
            LastName.Name = "LastName";
            // 
            // Position
            // 
            Position.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.BackColor = Color.Black;
            dataGridViewCellStyle6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            Position.DefaultCellStyle = dataGridViewCellStyle6;
            Position.HeaderText = "Position";
            Position.Name = "Position";
            // 
            // frmEmployeeDatabase
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(834, 461);
            Controls.Add(submitBtn);
            Controls.Add(employeeDatabase);
            Controls.Add(TxtBox_Position);
            Controls.Add(TxtBox_LName);
            Controls.Add(TxtBox_FName);
            Controls.Add(TxtBox_EmployeeID);
            Controls.Add(Label_EmployeeList);
            Controls.Add(Label_Position);
            Controls.Add(Label_LName);
            Controls.Add(Label_FName);
            Controls.Add(Label_EmployeeID);
            Controls.Add(Label_AddEmployee);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(850, 500);
            MinimumSize = new Size(850, 500);
            Name = "frmEmployeeDatabase";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Database";
            ((System.ComponentModel.ISupportInitialize)employeeDatabase).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_AddEmployee;
        private Label Label_EmployeeID;
        private Label Label_FName;
        private Label Label_LName;
        private Label Label_Position;
        private Label Label_EmployeeList;
        private TextBox TxtBox_EmployeeID;
        private TextBox TxtBox_FName;
        private TextBox TxtBox_LName;
        private TextBox TxtBox_Position;
        private Button submitBtn;
        private DataGridView employeeDatabase;
        private DataGridViewTextBoxColumn employeeID;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Position;
    }
}