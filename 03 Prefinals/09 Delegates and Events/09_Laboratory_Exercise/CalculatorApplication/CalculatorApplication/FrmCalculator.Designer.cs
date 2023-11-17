namespace CalculatorApplication
{
    partial class FrmCalculator
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
            Lbl_firstNum = new Label();
            txtBoxInput1 = new TextBox();
            cbOperator = new ComboBox();
            Lbl_secondNum = new Label();
            Lbl_Ans = new Label();
            lblDisplayTotal = new Label();
            txtBoxInput2 = new TextBox();
            div = new Label();
            btnEqual = new Button();
            SuspendLayout();
            // 
            // Lbl_firstNum
            // 
            Lbl_firstNum.AutoSize = true;
            Lbl_firstNum.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_firstNum.Location = new Point(60, 26);
            Lbl_firstNum.Name = "Lbl_firstNum";
            Lbl_firstNum.Size = new Size(143, 18);
            Lbl_firstNum.TabIndex = 0;
            Lbl_firstNum.Text = "Enter First Number:";
            // 
            // txtBoxInput1
            // 
            txtBoxInput1.BackColor = Color.Black;
            txtBoxInput1.BorderStyle = BorderStyle.FixedSingle;
            txtBoxInput1.Cursor = Cursors.IBeam;
            txtBoxInput1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxInput1.ForeColor = Color.White;
            txtBoxInput1.Location = new Point(230, 22);
            txtBoxInput1.Name = "txtBoxInput1";
            txtBoxInput1.Size = new Size(212, 26);
            txtBoxInput1.TabIndex = 1;
            txtBoxInput1.TextAlign = HorizontalAlignment.Center;
            // 
            // cbOperator
            // 
            cbOperator.BackColor = Color.Black;
            cbOperator.Cursor = Cursors.Hand;
            cbOperator.FlatStyle = FlatStyle.Flat;
            cbOperator.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbOperator.ForeColor = Color.White;
            cbOperator.FormattingEnabled = true;
            cbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cbOperator.Location = new Point(294, 62);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(80, 27);
            cbOperator.TabIndex = 2;
            // 
            // Lbl_secondNum
            // 
            Lbl_secondNum.AutoSize = true;
            Lbl_secondNum.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_secondNum.Location = new Point(40, 106);
            Lbl_secondNum.Name = "Lbl_secondNum";
            Lbl_secondNum.Size = new Size(166, 18);
            Lbl_secondNum.TabIndex = 3;
            Lbl_secondNum.Text = "Enter Second Number:";
            // 
            // Lbl_Ans
            // 
            Lbl_Ans.AutoSize = true;
            Lbl_Ans.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Ans.Location = new Point(140, 151);
            Lbl_Ans.Name = "Lbl_Ans";
            Lbl_Ans.Size = new Size(64, 18);
            Lbl_Ans.TabIndex = 4;
            Lbl_Ans.Text = "Answer:";
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDisplayTotal.Location = new Point(230, 151);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(212, 16);
            lblDisplayTotal.TabIndex = 5;
            lblDisplayTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxInput2
            // 
            txtBoxInput2.BackColor = Color.Black;
            txtBoxInput2.BorderStyle = BorderStyle.FixedSingle;
            txtBoxInput2.Cursor = Cursors.IBeam;
            txtBoxInput2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxInput2.ForeColor = Color.White;
            txtBoxInput2.Location = new Point(230, 102);
            txtBoxInput2.Name = "txtBoxInput2";
            txtBoxInput2.Size = new Size(212, 26);
            txtBoxInput2.TabIndex = 7;
            txtBoxInput2.TextAlign = HorizontalAlignment.Center;
            // 
            // div
            // 
            div.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            div.Location = new Point(230, 171);
            div.Name = "div";
            div.Size = new Size(212, 16);
            div.TabIndex = 8;
            div.Text = "-----------------------------------";
            div.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.Black;
            btnEqual.FlatStyle = FlatStyle.Flat;
            btnEqual.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnEqual.ForeColor = Color.White;
            btnEqual.Location = new Point(258, 196);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(157, 39);
            btnEqual.TabIndex = 9;
            btnEqual.Text = "Calculate";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // FrmCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(484, 261);
            Controls.Add(btnEqual);
            Controls.Add(div);
            Controls.Add(txtBoxInput2);
            Controls.Add(lblDisplayTotal);
            Controls.Add(Lbl_Ans);
            Controls.Add(Lbl_secondNum);
            Controls.Add(cbOperator);
            Controls.Add(txtBoxInput1);
            Controls.Add(Lbl_firstNum);
            Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            Name = "FrmCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator [ 09_Laboratory_Exercise ]";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_firstNum;
        private TextBox txtBoxInput1;
        private ComboBox cbOperator;
        private Label Lbl_secondNum;
        private Label Lbl_Ans;
        private Label lblDisplayTotal;
        private TextBox txtBoxInput2;
        private Label div;
        private Button btnEqual;
    }
}