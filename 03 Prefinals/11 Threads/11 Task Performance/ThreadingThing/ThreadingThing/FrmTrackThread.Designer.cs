namespace ThreadingThing
{
    partial class FrmTrackThread
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
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(158, 199);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Run";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 89);
            label1.Name = "label1";
            label1.Size = new Size(360, 32);
            label1.TabIndex = 1;
            label1.Text = "- Thread Starts -";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmTrackThread
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(384, 261);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            MaximizeBox = false;
            Name = "FrmTrackThread";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmTrackThread";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label1;
    }
}