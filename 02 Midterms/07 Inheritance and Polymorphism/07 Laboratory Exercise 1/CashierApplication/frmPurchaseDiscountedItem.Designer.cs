namespace CashierApplication
{
    partial class frmPurchaseDiscountedItem
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
            Lbl_Item = new Label();
            Lbl_Discount = new Label();
            Lbl_Price = new Label();
            Lbl_Quantity = new Label();
            Lbl_TtlAmount = new Label();
            Display_TtlAmount = new Label();
            Lbl_Payment = new Label();
            Lbl_Change = new Label();
            Display_Change = new Label();
            Txt_Item = new TextBox();
            Txt_Discount = new TextBox();
            Txt_Price = new TextBox();
            Txt_Qty = new TextBox();
            Txt_Payment = new TextBox();
            Btn_Compute = new Button();
            Btn_Submit = new Button();
            SuspendLayout();
            // 
            // Lbl_Item
            // 
            Lbl_Item.AutoSize = true;
            Lbl_Item.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Item.Location = new Point(40, 40);
            Lbl_Item.Name = "Lbl_Item";
            Lbl_Item.Size = new Size(53, 22);
            Lbl_Item.TabIndex = 0;
            Lbl_Item.Text = "Item:";
            Lbl_Item.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Lbl_Discount
            // 
            Lbl_Discount.AutoSize = true;
            Lbl_Discount.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Discount.Location = new Point(560, 40);
            Lbl_Discount.Name = "Lbl_Discount";
            Lbl_Discount.Size = new Size(128, 22);
            Lbl_Discount.TabIndex = 1;
            Lbl_Discount.Text = "Discount (%) :";
            Lbl_Discount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Lbl_Price
            // 
            Lbl_Price.AutoSize = true;
            Lbl_Price.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Price.Location = new Point(40, 120);
            Lbl_Price.Name = "Lbl_Price";
            Lbl_Price.Size = new Size(64, 22);
            Lbl_Price.TabIndex = 2;
            Lbl_Price.Text = "Price :";
            Lbl_Price.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Lbl_Quantity
            // 
            Lbl_Quantity.AutoSize = true;
            Lbl_Quantity.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Quantity.Location = new Point(560, 120);
            Lbl_Quantity.Name = "Lbl_Quantity";
            Lbl_Quantity.Size = new Size(88, 22);
            Lbl_Quantity.TabIndex = 3;
            Lbl_Quantity.Text = "Quantity :";
            Lbl_Quantity.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Lbl_TtlAmount
            // 
            Lbl_TtlAmount.AutoSize = true;
            Lbl_TtlAmount.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_TtlAmount.Location = new Point(40, 220);
            Lbl_TtlAmount.Name = "Lbl_TtlAmount";
            Lbl_TtlAmount.Size = new Size(129, 22);
            Lbl_TtlAmount.TabIndex = 4;
            Lbl_TtlAmount.Text = "Total Amount :";
            Lbl_TtlAmount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Display_TtlAmount
            // 
            Display_TtlAmount.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Display_TtlAmount.Location = new Point(180, 220);
            Display_TtlAmount.Name = "Display_TtlAmount";
            Display_TtlAmount.Size = new Size(350, 22);
            Display_TtlAmount.TabIndex = 5;
            Display_TtlAmount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Lbl_Payment
            // 
            Lbl_Payment.AutoSize = true;
            Lbl_Payment.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Payment.Location = new Point(40, 280);
            Lbl_Payment.Name = "Lbl_Payment";
            Lbl_Payment.Size = new Size(180, 22);
            Lbl_Payment.TabIndex = 6;
            Lbl_Payment.Text = "Payment Received :";
            Lbl_Payment.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Lbl_Change
            // 
            Lbl_Change.AutoSize = true;
            Lbl_Change.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Change.Location = new Point(40, 340);
            Lbl_Change.Name = "Lbl_Change";
            Lbl_Change.Size = new Size(86, 22);
            Lbl_Change.TabIndex = 7;
            Lbl_Change.Text = "Change :";
            Lbl_Change.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Display_Change
            // 
            Display_Change.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Display_Change.Location = new Point(150, 340);
            Display_Change.Name = "Display_Change";
            Display_Change.Size = new Size(380, 18);
            Display_Change.TabIndex = 8;
            Display_Change.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Txt_Item
            // 
            Txt_Item.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_Item.Location = new Point(40, 70);
            Txt_Item.Name = "Txt_Item";
            Txt_Item.Size = new Size(490, 29);
            Txt_Item.TabIndex = 9;
            // 
            // Txt_Discount
            // 
            Txt_Discount.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_Discount.Location = new Point(560, 70);
            Txt_Discount.Name = "Txt_Discount";
            Txt_Discount.Size = new Size(180, 29);
            Txt_Discount.TabIndex = 10;
            // 
            // Txt_Price
            // 
            Txt_Price.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_Price.Location = new Point(110, 120);
            Txt_Price.Name = "Txt_Price";
            Txt_Price.Size = new Size(420, 29);
            Txt_Price.TabIndex = 11;
            // 
            // Txt_Qty
            // 
            Txt_Qty.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_Qty.Location = new Point(650, 120);
            Txt_Qty.Name = "Txt_Qty";
            Txt_Qty.Size = new Size(90, 29);
            Txt_Qty.TabIndex = 12;
            // 
            // Txt_Payment
            // 
            Txt_Payment.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_Payment.Location = new Point(230, 280);
            Txt_Payment.Name = "Txt_Payment";
            Txt_Payment.Size = new Size(300, 29);
            Txt_Payment.TabIndex = 13;
            // 
            // Btn_Compute
            // 
            Btn_Compute.BackColor = Color.Black;
            Btn_Compute.Location = new Point(348, 163);
            Btn_Compute.Name = "Btn_Compute";
            Btn_Compute.Size = new Size(125, 38);
            Btn_Compute.TabIndex = 14;
            Btn_Compute.Text = "Compute";
            Btn_Compute.UseVisualStyleBackColor = false;
            Btn_Compute.Click += Btn_Compute_Click;
            // 
            // Btn_Submit
            // 
            Btn_Submit.BackColor = Color.Black;
            Btn_Submit.Location = new Point(560, 275);
            Btn_Submit.Name = "Btn_Submit";
            Btn_Submit.Size = new Size(125, 38);
            Btn_Submit.TabIndex = 15;
            Btn_Submit.Text = "Submit";
            Btn_Submit.UseVisualStyleBackColor = false;
            Btn_Submit.Click += Btn_Submit_Click;
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
            Controls.Add(Txt_Qty);
            Controls.Add(Txt_Price);
            Controls.Add(Txt_Discount);
            Controls.Add(Txt_Item);
            Controls.Add(Display_Change);
            Controls.Add(Lbl_Change);
            Controls.Add(Lbl_Payment);
            Controls.Add(Display_TtlAmount);
            Controls.Add(Lbl_TtlAmount);
            Controls.Add(Lbl_Quantity);
            Controls.Add(Lbl_Price);
            Controls.Add(Lbl_Discount);
            Controls.Add(Lbl_Item);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frmPurchaseDiscountedItem";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Purchase Discounted Item";
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
        private Label Lbl_Change;
        private Label Display_Change;
        private TextBox Txt_Item;
        private TextBox Txt_Discount;
        private TextBox Txt_Price;
        private TextBox Txt_Qty;
        private TextBox Txt_Payment;
        private Button Btn_Compute;
        private Button Btn_Submit;
    }
}