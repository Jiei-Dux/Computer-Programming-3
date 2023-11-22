namespace CashierApplication
{
    partial class frmPurchaseDiscountedItem
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
            Lbl_Item = new Label();
            Lbl_Discount = new Label();
            Lbl_Price = new Label();
            Lbl_Quantity = new Label();
            Lbl_TtlAmount = new Label();
            Display_TtlAmount = new Label();
            Lbl_Payment = new Label();
            Display_Change = new Label();
            Lbl_Change = new Label();
            Txt_Item = new TextBox();
            Txt_Discount = new TextBox();
            Txt_Price = new TextBox();
            Txt_Quantity = new TextBox();
            Txt_Payment = new TextBox();
            Btn_Compute = new Button();
            Btn_Submit = new Button();
            MenuStrip = new MenuStrip();
            menu = new ToolStripMenuItem();
            logout = new ToolStripMenuItem();
            exitApp = new ToolStripMenuItem();
            MenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // Lbl_Item
            // 
            Lbl_Item.AutoSize = true;
            Lbl_Item.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Item.Location = new Point(30, 40);
            Lbl_Item.Name = "Lbl_Item";
            Lbl_Item.Size = new Size(66, 25);
            Lbl_Item.TabIndex = 0;
            Lbl_Item.Text = "Item :";
            // 
            // Lbl_Discount
            // 
            Lbl_Discount.AutoSize = true;
            Lbl_Discount.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Discount.Location = new Point(520, 40);
            Lbl_Discount.Name = "Lbl_Discount";
            Lbl_Discount.Size = new Size(148, 25);
            Lbl_Discount.TabIndex = 1;
            Lbl_Discount.Text = "Discount (%) :";
            // 
            // Lbl_Price
            // 
            Lbl_Price.AutoSize = true;
            Lbl_Price.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Price.Location = new Point(30, 124);
            Lbl_Price.Name = "Lbl_Price";
            Lbl_Price.Size = new Size(74, 25);
            Lbl_Price.TabIndex = 2;
            Lbl_Price.Text = "Price :";
            // 
            // Lbl_Quantity
            // 
            Lbl_Quantity.AutoSize = true;
            Lbl_Quantity.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Quantity.Location = new Point(520, 124);
            Lbl_Quantity.Name = "Lbl_Quantity";
            Lbl_Quantity.Size = new Size(103, 25);
            Lbl_Quantity.TabIndex = 3;
            Lbl_Quantity.Text = "Quantity :";
            // 
            // Lbl_TtlAmount
            // 
            Lbl_TtlAmount.AutoSize = true;
            Lbl_TtlAmount.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_TtlAmount.Location = new Point(30, 230);
            Lbl_TtlAmount.Name = "Lbl_TtlAmount";
            Lbl_TtlAmount.Size = new Size(150, 25);
            Lbl_TtlAmount.TabIndex = 4;
            Lbl_TtlAmount.Text = "Total Amount :";
            // 
            // Display_TtlAmount
            // 
            Display_TtlAmount.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Display_TtlAmount.Location = new Point(190, 230);
            Display_TtlAmount.Name = "Display_TtlAmount";
            Display_TtlAmount.Size = new Size(330, 25);
            Display_TtlAmount.TabIndex = 5;
            // 
            // Lbl_Payment
            // 
            Lbl_Payment.AutoSize = true;
            Lbl_Payment.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Payment.Location = new Point(30, 294);
            Lbl_Payment.Name = "Lbl_Payment";
            Lbl_Payment.Size = new Size(206, 25);
            Lbl_Payment.TabIndex = 6;
            Lbl_Payment.Text = "Payment Received :";
            // 
            // Display_Change
            // 
            Display_Change.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Display_Change.Location = new Point(140, 360);
            Display_Change.Name = "Display_Change";
            Display_Change.Size = new Size(380, 25);
            Display_Change.TabIndex = 7;
            // 
            // Lbl_Change
            // 
            Lbl_Change.AutoSize = true;
            Lbl_Change.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Change.Location = new Point(30, 360);
            Lbl_Change.Name = "Lbl_Change";
            Lbl_Change.Size = new Size(98, 25);
            Lbl_Change.TabIndex = 8;
            Lbl_Change.Text = "Change :";
            // 
            // Txt_Item
            // 
            Txt_Item.BackColor = Color.DarkGray;
            Txt_Item.BorderStyle = BorderStyle.FixedSingle;
            Txt_Item.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_Item.ForeColor = Color.Black;
            Txt_Item.Location = new Point(30, 70);
            Txt_Item.Name = "Txt_Item";
            Txt_Item.Size = new Size(460, 32);
            Txt_Item.TabIndex = 9;
            // 
            // Txt_Discount
            // 
            Txt_Discount.BackColor = Color.DarkGray;
            Txt_Discount.BorderStyle = BorderStyle.FixedSingle;
            Txt_Discount.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_Discount.ForeColor = Color.Black;
            Txt_Discount.Location = new Point(520, 70);
            Txt_Discount.Name = "Txt_Discount";
            Txt_Discount.Size = new Size(230, 32);
            Txt_Discount.TabIndex = 10;
            // 
            // Txt_Price
            // 
            Txt_Price.BackColor = Color.DarkGray;
            Txt_Price.BorderStyle = BorderStyle.FixedSingle;
            Txt_Price.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_Price.ForeColor = Color.Black;
            Txt_Price.Location = new Point(110, 120);
            Txt_Price.Name = "Txt_Price";
            Txt_Price.Size = new Size(380, 32);
            Txt_Price.TabIndex = 11;
            // 
            // Txt_Quantity
            // 
            Txt_Quantity.BackColor = Color.DarkGray;
            Txt_Quantity.BorderStyle = BorderStyle.FixedSingle;
            Txt_Quantity.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_Quantity.ForeColor = Color.Black;
            Txt_Quantity.Location = new Point(630, 120);
            Txt_Quantity.Name = "Txt_Quantity";
            Txt_Quantity.Size = new Size(120, 32);
            Txt_Quantity.TabIndex = 12;
            // 
            // Txt_Payment
            // 
            Txt_Payment.BackColor = Color.DarkGray;
            Txt_Payment.BorderStyle = BorderStyle.FixedSingle;
            Txt_Payment.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_Payment.ForeColor = Color.Black;
            Txt_Payment.Location = new Point(242, 290);
            Txt_Payment.Name = "Txt_Payment";
            Txt_Payment.Size = new Size(248, 32);
            Txt_Payment.TabIndex = 13;
            // 
            // Btn_Compute
            // 
            Btn_Compute.BackColor = Color.Black;
            Btn_Compute.Location = new Point(350, 170);
            Btn_Compute.Name = "Btn_Compute";
            Btn_Compute.Size = new Size(100, 40);
            Btn_Compute.TabIndex = 14;
            Btn_Compute.Text = "Compute";
            Btn_Compute.UseVisualStyleBackColor = false;
            Btn_Compute.Click += Btn_Compute_Click;
            // 
            // Btn_Submit
            // 
            Btn_Submit.BackColor = Color.Black;
            Btn_Submit.Location = new Point(520, 284);
            Btn_Submit.Name = "Btn_Submit";
            Btn_Submit.Size = new Size(100, 40);
            Btn_Submit.TabIndex = 15;
            Btn_Submit.Text = "Submit";
            Btn_Submit.UseVisualStyleBackColor = false;
            Btn_Submit.Click += Btn_Submit_Click;
            // 
            // MenuStrip
            // 
            MenuStrip.BackColor = Color.Black;
            MenuStrip.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MenuStrip.Items.AddRange(new ToolStripItem[] { menu });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(784, 26);
            MenuStrip.TabIndex = 16;
            MenuStrip.Text = "Menu";
            // 
            // menu
            // 
            menu.DisplayStyle = ToolStripItemDisplayStyle.Text;
            menu.DropDownItems.AddRange(new ToolStripItem[] { logout, exitApp });
            menu.ForeColor = Color.White;
            menu.Name = "menu";
            menu.ShortcutKeys = Keys.Control | Keys.Shift | Keys.F1;
            menu.Size = new Size(58, 22);
            menu.Text = "Menu";
            menu.ToolTipText = "Open Menu";
            // 
            // logout
            // 
            logout.BackColor = Color.Black;
            logout.DisplayStyle = ToolStripItemDisplayStyle.Text;
            logout.ForeColor = Color.White;
            logout.Name = "logout";
            logout.ShortcutKeys = Keys.Control | Keys.Shift | Keys.End;
            logout.Size = new Size(288, 22);
            logout.Text = "Log Out";
            logout.Click += logout_Click;
            // 
            // exitApp
            // 
            exitApp.BackColor = Color.Black;
            exitApp.DisplayStyle = ToolStripItemDisplayStyle.Text;
            exitApp.ForeColor = Color.White;
            exitApp.Name = "exitApp";
            exitApp.ShortcutKeys = Keys.Control | Keys.Shift | Keys.Delete;
            exitApp.Size = new Size(288, 22);
            exitApp.Text = "Exit Application";
            exitApp.Click += exitApp_Click;
            // 
            // frmPurchaseDiscountedItem
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(784, 461);
            Controls.Add(Btn_Submit);
            Controls.Add(Btn_Compute);
            Controls.Add(Txt_Payment);
            Controls.Add(Txt_Quantity);
            Controls.Add(Txt_Price);
            Controls.Add(Txt_Discount);
            Controls.Add(Txt_Item);
            Controls.Add(Lbl_Change);
            Controls.Add(Display_Change);
            Controls.Add(Lbl_Payment);
            Controls.Add(Display_TtlAmount);
            Controls.Add(Lbl_TtlAmount);
            Controls.Add(Lbl_Quantity);
            Controls.Add(Lbl_Price);
            Controls.Add(Lbl_Discount);
            Controls.Add(Lbl_Item);
            Controls.Add(MenuStrip);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            MainMenuStrip = MenuStrip;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frmPurchaseDiscountedItem";
            ShowIcon = false;
            Text = "Purchase Discount Item";
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_Item;
        private Label Lbl_Discount;
        private Label Lbl_Price;
        private Label Lbl_Quantity;
        private Label Lbl_TtlAmount;
        private Label Display_TtlAmount;
        private Label Lbl_Payment;
        private Label Display_Change;
        private Label Lbl_Change;
        private TextBox Txt_Item;
        private TextBox Txt_Discount;
        private TextBox Txt_Price;
        private TextBox Txt_Quantity;
        private TextBox Txt_Payment;
        private Button Btn_Compute;
        private Button Btn_Submit;
        private MenuStrip MenuStrip;
        private ToolStripMenuItem menu;
        private ToolStripMenuItem logout;
        private ToolStripMenuItem exitApp;
    }
}