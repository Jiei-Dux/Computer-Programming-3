namespace StudentGradeApplication
{
    partial class frmStudentGradeApplication
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
            name = new Label();
            grade = new Label();
            clve = new Label();
            hist = new Label();
            eng = new Label();
            sci = new Label();
            comp = new Label();
            nameTxt = new TextBox();
            clveTxt = new TextBox();
            histTxt = new TextBox();
            engTxt = new TextBox();
            sciTxt = new TextBox();
            compTxt = new TextBox();
            avgBtn = new Button();
            Popup = new Label();
            SuspendLayout();
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location = new Point(12, 48);
            name.Name = "name";
            name.Size = new Size(74, 30);
            name.TabIndex = 0;
            name.Text = "Name:";
            name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // grade
            // 
            grade.AutoSize = true;
            grade.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            grade.Location = new Point(12, 118);
            grade.Name = "grade";
            grade.Size = new Size(96, 30);
            grade.TabIndex = 1;
            grade.Text = "GRADES:";
            grade.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // clve
            // 
            clve.AutoSize = true;
            clve.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            clve.Location = new Point(12, 173);
            clve.Name = "clve";
            clve.Size = new Size(59, 30);
            clve.TabIndex = 2;
            clve.Text = "CLVE";
            clve.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // hist
            // 
            hist.AutoSize = true;
            hist.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            hist.Location = new Point(12, 227);
            hist.Name = "hist";
            hist.Size = new Size(78, 30);
            hist.TabIndex = 3;
            hist.Text = "History";
            hist.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // eng
            // 
            eng.AutoSize = true;
            eng.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            eng.Location = new Point(12, 281);
            eng.Name = "eng";
            eng.Size = new Size(79, 30);
            eng.TabIndex = 4;
            eng.Text = "English";
            eng.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sci
            // 
            sci.AutoSize = true;
            sci.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            sci.Location = new Point(12, 339);
            sci.Name = "sci";
            sci.Size = new Size(83, 30);
            sci.TabIndex = 5;
            sci.Text = "Science";
            sci.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comp
            // 
            comp.AutoSize = true;
            comp.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            comp.Location = new Point(12, 395);
            comp.Name = "comp";
            comp.Size = new Size(105, 30);
            comp.TabIndex = 6;
            comp.Text = "Computer";
            comp.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nameTxt
            // 
            nameTxt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            nameTxt.Location = new Point(92, 45);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(363, 35);
            nameTxt.TabIndex = 7;
            // 
            // clveTxt
            // 
            clveTxt.BackColor = SystemColors.Control;
            clveTxt.BorderStyle = BorderStyle.FixedSingle;
            clveTxt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            clveTxt.Location = new Point(123, 170);
            clveTxt.Name = "clveTxt";
            clveTxt.Size = new Size(100, 35);
            clveTxt.TabIndex = 8;
            // 
            // histTxt
            // 
            histTxt.BackColor = SystemColors.Control;
            histTxt.BorderStyle = BorderStyle.FixedSingle;
            histTxt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            histTxt.Location = new Point(123, 224);
            histTxt.Name = "histTxt";
            histTxt.Size = new Size(100, 35);
            histTxt.TabIndex = 9;
            // 
            // engTxt
            // 
            engTxt.BackColor = SystemColors.Control;
            engTxt.BorderStyle = BorderStyle.FixedSingle;
            engTxt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            engTxt.Location = new Point(123, 278);
            engTxt.Name = "engTxt";
            engTxt.Size = new Size(100, 35);
            engTxt.TabIndex = 10;
            // 
            // sciTxt
            // 
            sciTxt.BackColor = SystemColors.Control;
            sciTxt.BorderStyle = BorderStyle.FixedSingle;
            sciTxt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            sciTxt.Location = new Point(123, 336);
            sciTxt.Name = "sciTxt";
            sciTxt.Size = new Size(100, 35);
            sciTxt.TabIndex = 11;
            // 
            // compTxt
            // 
            compTxt.BackColor = SystemColors.Control;
            compTxt.BorderStyle = BorderStyle.FixedSingle;
            compTxt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            compTxt.Location = new Point(123, 392);
            compTxt.Name = "compTxt";
            compTxt.Size = new Size(100, 35);
            compTxt.TabIndex = 12;
            // 
            // avgBtn
            // 
            avgBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            avgBtn.Location = new Point(149, 452);
            avgBtn.Name = "avgBtn";
            avgBtn.Size = new Size(180, 76);
            avgBtn.TabIndex = 13;
            avgBtn.Text = "Find out my Average!!";
            avgBtn.UseVisualStyleBackColor = true;
            avgBtn.Click += avgBtn_Click;
            // 
            // Popup
            // 
            Popup.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Popup.Location = new Point(238, 170);
            Popup.Name = "Popup";
            Popup.Size = new Size(217, 257);
            Popup.TabIndex = 14;
            Popup.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmStudentGradeApplication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 561);
            Controls.Add(Popup);
            Controls.Add(avgBtn);
            Controls.Add(compTxt);
            Controls.Add(sciTxt);
            Controls.Add(engTxt);
            Controls.Add(histTxt);
            Controls.Add(clveTxt);
            Controls.Add(nameTxt);
            Controls.Add(comp);
            Controls.Add(sci);
            Controls.Add(eng);
            Controls.Add(hist);
            Controls.Add(clve);
            Controls.Add(grade);
            Controls.Add(name);
            Name = "frmStudentGradeApplication";
            ShowIcon = false;
            Text = "Student Grade Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name;
        private Label grade;
        private Label clve;
        private Label hist;
        private Label eng;
        private Label sci;
        private Label comp;
        private TextBox nameTxt;
        private TextBox clveTxt;
        private TextBox histTxt;
        private TextBox engTxt;
        private TextBox sciTxt;
        private TextBox compTxt;
        private Button avgBtn;
        private Label Popup;
    }
}