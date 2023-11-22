namespace StudentNamespace
{
    partial class frmStudentInfo
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
            Label_stdID = new Label();
            Label_LName = new Label();
            Label_FName = new Label();
            Label_stdIDList = new Label();
            Label_FNameList = new Label();
            Label_LNameList = new Label();
            TxtBox_stdID = new TextBox();
            TxtBox_LName = new TextBox();
            TxtBox_FName = new TextBox();
            ListBox_stdID = new ListBox();
            ListBox_FName = new ListBox();
            ListBox_LName = new ListBox();
            submitBtn = new Button();
            SuspendLayout();
            // 
            // Label_stdID
            // 
            Label_stdID.AutoSize = true;
            Label_stdID.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Label_stdID.Location = new Point(20, 50);
            Label_stdID.Name = "Label_stdID";
            Label_stdID.Size = new Size(122, 25);
            Label_stdID.TabIndex = 0;
            Label_stdID.Text = "Student ID*";
            // 
            // Label_LName
            // 
            Label_LName.AutoSize = true;
            Label_LName.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Label_LName.Location = new Point(280, 50);
            Label_LName.Name = "Label_LName";
            Label_LName.Size = new Size(126, 25);
            Label_LName.TabIndex = 1;
            Label_LName.Text = "Last Name*";
            // 
            // Label_FName
            // 
            Label_FName.AutoSize = true;
            Label_FName.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Label_FName.Location = new Point(530, 50);
            Label_FName.Name = "Label_FName";
            Label_FName.Size = new Size(127, 25);
            Label_FName.TabIndex = 2;
            Label_FName.Text = "First Name*";
            // 
            // Label_stdIDList
            // 
            Label_stdIDList.AutoSize = true;
            Label_stdIDList.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Label_stdIDList.Location = new Point(20, 200);
            Label_stdIDList.Name = "Label_stdIDList";
            Label_stdIDList.Size = new Size(153, 25);
            Label_stdIDList.TabIndex = 3;
            Label_stdIDList.Text = "Student ID List";
            // 
            // Label_FNameList
            // 
            Label_FNameList.AutoSize = true;
            Label_FNameList.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Label_FNameList.Location = new Point(280, 200);
            Label_FNameList.Name = "Label_FNameList";
            Label_FNameList.Size = new Size(158, 25);
            Label_FNameList.TabIndex = 4;
            Label_FNameList.Text = "First Name List";
            // 
            // Label_LNameList
            // 
            Label_LNameList.AutoSize = true;
            Label_LNameList.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Label_LNameList.Location = new Point(530, 200);
            Label_LNameList.Name = "Label_LNameList";
            Label_LNameList.Size = new Size(157, 25);
            Label_LNameList.TabIndex = 5;
            Label_LNameList.Text = "Last Name List";
            // 
            // TxtBox_stdID
            // 
            TxtBox_stdID.Location = new Point(20, 90);
            TxtBox_stdID.Name = "TxtBox_stdID";
            TxtBox_stdID.Size = new Size(230, 26);
            TxtBox_stdID.TabIndex = 6;
            // 
            // TxtBox_LName
            // 
            TxtBox_LName.Location = new Point(280, 90);
            TxtBox_LName.Name = "TxtBox_LName";
            TxtBox_LName.Size = new Size(230, 26);
            TxtBox_LName.TabIndex = 7;
            // 
            // TxtBox_FName
            // 
            TxtBox_FName.Location = new Point(530, 90);
            TxtBox_FName.Name = "TxtBox_FName";
            TxtBox_FName.Size = new Size(230, 26);
            TxtBox_FName.TabIndex = 8;
            // 
            // ListBox_stdID
            // 
            ListBox_stdID.FormattingEnabled = true;
            ListBox_stdID.ItemHeight = 18;
            ListBox_stdID.Location = new Point(20, 250);
            ListBox_stdID.Name = "ListBox_stdID";
            ListBox_stdID.Size = new Size(230, 220);
            ListBox_stdID.TabIndex = 9;
            // 
            // ListBox_FName
            // 
            ListBox_FName.FormattingEnabled = true;
            ListBox_FName.ItemHeight = 18;
            ListBox_FName.Location = new Point(280, 250);
            ListBox_FName.Name = "ListBox_FName";
            ListBox_FName.Size = new Size(230, 220);
            ListBox_FName.TabIndex = 10;
            // 
            // ListBox_LName
            // 
            ListBox_LName.FormattingEnabled = true;
            ListBox_LName.ItemHeight = 18;
            ListBox_LName.Location = new Point(530, 250);
            ListBox_LName.Name = "ListBox_LName";
            ListBox_LName.Size = new Size(230, 220);
            ListBox_LName.TabIndex = 11;
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.Black;
            submitBtn.Cursor = Cursors.Hand;
            submitBtn.FlatAppearance.BorderColor = Color.Gray;
            submitBtn.FlatAppearance.BorderSize = 2;
            submitBtn.FlatStyle = FlatStyle.Flat;
            submitBtn.Location = new Point(660, 140);
            submitBtn.MaximumSize = new Size(100, 40);
            submitBtn.MinimumSize = new Size(100, 40);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(100, 40);
            submitBtn.TabIndex = 12;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
            // 
            // frmStudentInfo
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(784, 511);
            Controls.Add(submitBtn);
            Controls.Add(ListBox_LName);
            Controls.Add(ListBox_FName);
            Controls.Add(ListBox_stdID);
            Controls.Add(TxtBox_FName);
            Controls.Add(TxtBox_LName);
            Controls.Add(TxtBox_stdID);
            Controls.Add(Label_LNameList);
            Controls.Add(Label_FNameList);
            Controls.Add(Label_stdIDList);
            Controls.Add(Label_FName);
            Controls.Add(Label_LName);
            Controls.Add(Label_stdID);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(800, 550);
            MinimumSize = new Size(800, 550);
            Name = "frmStudentInfo";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Info";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_stdID;
        private Label Label_LName;
        private Label Label_FName;
        private Label Label_stdIDList;
        private Label Label_FNameList;
        private Label Label_LNameList;
        private TextBox TxtBox_stdID;
        private TextBox TxtBox_LName;
        private TextBox TxtBox_FName;
        private ListBox ListBox_stdID;
        private ListBox ListBox_FName;
        private ListBox ListBox_LName;
        private Button submitBtn;
    }
}