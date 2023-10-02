namespace WordGuessApplication
{
    partial class MainMenu
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
            label1 = new Label();
            playBtn = new Button();
            exitBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(41, 39);
            label1.Name = "label1";
            label1.Size = new Size(203, 117);
            label1.TabIndex = 0;
            label1.Text = "DUX's WORD GUESSING GAME";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playBtn
            // 
            playBtn.BackColor = Color.Gray;
            playBtn.FlatAppearance.BorderColor = Color.Gray;
            playBtn.FlatStyle = FlatStyle.Flat;
            playBtn.Location = new Point(325, 39);
            playBtn.Name = "playBtn";
            playBtn.Size = new Size(139, 40);
            playBtn.TabIndex = 1;
            playBtn.Text = "PLAY";
            playBtn.UseVisualStyleBackColor = false;
            playBtn.Click += playBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Gray;
            exitBtn.FlatAppearance.BorderColor = Color.Gray;
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.Location = new Point(325, 116);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(139, 40);
            exitBtn.TabIndex = 2;
            exitBtn.Text = "EXIT";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(524, 191);
            Controls.Add(exitBtn);
            Controls.Add(playBtn);
            Controls.Add(label1);
            Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MaximumSize = new Size(540, 230);
            MinimumSize = new Size(540, 230);
            Name = "MainMenu";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dux's Word Guessing Game";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button playBtn;
        private Button exitBtn;
    }
}