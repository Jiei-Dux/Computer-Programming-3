namespace WordGuessApplication
{
    partial class frmGuessWord
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
            daWord = new Label();
            wrongGuessesLabel = new Label();
            guessTxtBox = new TextBox();
            guessBtn = new Button();
            wrongGuesses = new Label();
            BackBtn = new Button();
            NextBtn = new Button();
            SuspendLayout();
            // 
            // daWord
            // 
            daWord.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            daWord.Location = new Point(36, 9);
            daWord.Name = "daWord";
            daWord.Size = new Size(351, 42);
            daWord.TabIndex = 0;
            daWord.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // wrongGuessesLabel
            // 
            wrongGuessesLabel.AutoSize = true;
            wrongGuessesLabel.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            wrongGuessesLabel.Location = new Point(400, 9);
            wrongGuessesLabel.Name = "wrongGuessesLabel";
            wrongGuessesLabel.Size = new Size(172, 26);
            wrongGuessesLabel.TabIndex = 1;
            wrongGuessesLabel.Text = "WRONG GUESSES:";
            wrongGuessesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guessTxtBox
            // 
            guessTxtBox.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            guessTxtBox.Location = new Point(36, 73);
            guessTxtBox.Name = "guessTxtBox";
            guessTxtBox.Size = new Size(351, 31);
            guessTxtBox.TabIndex = 2;
            // 
            // guessBtn
            // 
            guessBtn.BackColor = Color.DarkSeaGreen;
            guessBtn.FlatStyle = FlatStyle.Flat;
            guessBtn.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guessBtn.Location = new Point(60, 137);
            guessBtn.Name = "guessBtn";
            guessBtn.Size = new Size(140, 34);
            guessBtn.TabIndex = 3;
            guessBtn.Text = "GUESS";
            guessBtn.UseVisualStyleBackColor = false;
            guessBtn.Click += guessBtn_Click;
            // 
            // wrongGuesses
            // 
            wrongGuesses.Location = new Point(410, 44);
            wrongGuesses.Name = "wrongGuesses";
            wrongGuesses.Size = new Size(162, 208);
            wrongGuesses.TabIndex = 4;
            // 
            // BackBtn
            // 
            BackBtn.FlatStyle = FlatStyle.Flat;
            BackBtn.Location = new Point(12, 226);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(75, 23);
            BackBtn.TabIndex = 5;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // NextBtn
            // 
            NextBtn.BackColor = Color.DarkSlateBlue;
            NextBtn.FlatStyle = FlatStyle.Flat;
            NextBtn.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NextBtn.Location = new Point(219, 137);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(140, 34);
            NextBtn.TabIndex = 6;
            NextBtn.Text = "NEXT";
            NextBtn.UseVisualStyleBackColor = false;
            NextBtn.Click += NextBtn_Click;
            // 
            // frmGuessWord
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(584, 261);
            Controls.Add(NextBtn);
            Controls.Add(BackBtn);
            Controls.Add(wrongGuesses);
            Controls.Add(guessBtn);
            Controls.Add(guessTxtBox);
            Controls.Add(wrongGuessesLabel);
            Controls.Add(daWord);
            Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            MaximizeBox = false;
            MaximumSize = new Size(600, 300);
            MinimumSize = new Size(600, 300);
            Name = "frmGuessWord";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dux's Word Guessing Game";
            Load += frmGuessWord_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label daWord;
        private Label wrongGuessesLabel;
        private TextBox guessTxtBox;
        private Button guessBtn;
        private Label wrongGuesses;
        private Button BackBtn;
        private Button NextBtn;
    }
}