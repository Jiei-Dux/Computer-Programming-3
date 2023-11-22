namespace CashierApplication
{
    partial class frmLoginAccount
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
            Btn_Login = new Button();
            Lbl_UsrName = new Label();
            Lbl_Passwd = new Label();
            Txt_usrName = new TextBox();
            Txt_Passwd = new TextBox();
            SuspendLayout();
            // 
            // Btn_Login
            // 
            Btn_Login.BackColor = Color.Black;
            Btn_Login.Location = new Point(40, 230);
            Btn_Login.Name = "Btn_Login";
            Btn_Login.Size = new Size(298, 51);
            Btn_Login.TabIndex = 0;
            Btn_Login.Text = "LOGIN";
            Btn_Login.UseVisualStyleBackColor = false;
            Btn_Login.Click += Btn_Login_Click;
            // 
            // Lbl_UsrName
            // 
            Lbl_UsrName.AutoSize = true;
            Lbl_UsrName.Location = new Point(40, 40);
            Lbl_UsrName.Name = "Lbl_UsrName";
            Lbl_UsrName.Size = new Size(123, 25);
            Lbl_UsrName.TabIndex = 1;
            Lbl_UsrName.Text = "Username :";
            // 
            // Lbl_Passwd
            // 
            Lbl_Passwd.AutoSize = true;
            Lbl_Passwd.Location = new Point(40, 130);
            Lbl_Passwd.Name = "Lbl_Passwd";
            Lbl_Passwd.Size = new Size(120, 25);
            Lbl_Passwd.TabIndex = 2;
            Lbl_Passwd.Text = "Password :";
            // 
            // Txt_usrName
            // 
            Txt_usrName.Location = new Point(40, 80);
            Txt_usrName.Name = "Txt_usrName";
            Txt_usrName.Size = new Size(300, 32);
            Txt_usrName.TabIndex = 3;
            // 
            // Txt_Passwd
            // 
            Txt_Passwd.Location = new Point(42, 170);
            Txt_Passwd.Name = "Txt_Passwd";
            Txt_Passwd.Size = new Size(300, 32);
            Txt_Passwd.TabIndex = 4;
            // 
            // frmLoginAccount
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(384, 321);
            Controls.Add(Txt_Passwd);
            Controls.Add(Txt_usrName);
            Controls.Add(Lbl_Passwd);
            Controls.Add(Lbl_UsrName);
            Controls.Add(Btn_Login);
            Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "frmLoginAccount";
            ShowIcon = false;
            Text = "User Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Login;
        private Label Lbl_UsrName;
        private Label Lbl_Passwd;
        private TextBox Txt_usrName;
        private TextBox Txt_Passwd;
    }
}