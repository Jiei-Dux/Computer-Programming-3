namespace Inventory
{
    partial class FrmAddProduct
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Lbl_addProduct = new Label();
            Lbl_ProductName = new Label();
            Lbl_Category = new Label();
            Lbl_MfgDate = new Label();
            Lbl_ExpDate = new Label();
            Lbl_Qty = new Label();
            Lbl_SellPrice = new Label();
            txtProductName = new TextBox();
            txtSellPrice = new TextBox();
            txtQuantity = new TextBox();
            cbCategory = new ComboBox();
            dtPickerMfgDate = new DateTimePicker();
            dtPickerExpDate = new DateTimePicker();
            Lbl_Description = new Label();
            richTxtDescription = new RichTextBox();
            btnAddProduct = new Button();
            gridViewProductList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).BeginInit();
            SuspendLayout();
            // 
            // Lbl_addProduct
            // 
            Lbl_addProduct.AutoSize = true;
            Lbl_addProduct.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_addProduct.Location = new Point(16, 18);
            Lbl_addProduct.Margin = new Padding(2, 0, 2, 0);
            Lbl_addProduct.Name = "Lbl_addProduct";
            Lbl_addProduct.Size = new Size(137, 24);
            Lbl_addProduct.TabIndex = 0;
            Lbl_addProduct.Text = "Add Product";
            // 
            // Lbl_ProductName
            // 
            Lbl_ProductName.AutoSize = true;
            Lbl_ProductName.Location = new Point(20, 70);
            Lbl_ProductName.Margin = new Padding(2, 0, 2, 0);
            Lbl_ProductName.Name = "Lbl_ProductName";
            Lbl_ProductName.Size = new Size(56, 16);
            Lbl_ProductName.TabIndex = 1;
            Lbl_ProductName.Text = "Product";
            // 
            // Lbl_Category
            // 
            Lbl_Category.AutoSize = true;
            Lbl_Category.Location = new Point(20, 110);
            Lbl_Category.Margin = new Padding(2, 0, 2, 0);
            Lbl_Category.Name = "Lbl_Category";
            Lbl_Category.Size = new Size(65, 16);
            Lbl_Category.TabIndex = 2;
            Lbl_Category.Text = "Category";
            // 
            // Lbl_MfgDate
            // 
            Lbl_MfgDate.AutoSize = true;
            Lbl_MfgDate.Location = new Point(20, 150);
            Lbl_MfgDate.Margin = new Padding(2, 0, 2, 0);
            Lbl_MfgDate.Name = "Lbl_MfgDate";
            Lbl_MfgDate.Size = new Size(68, 16);
            Lbl_MfgDate.TabIndex = 3;
            Lbl_MfgDate.Text = "Mfg. Date";
            // 
            // Lbl_ExpDate
            // 
            Lbl_ExpDate.AutoSize = true;
            Lbl_ExpDate.Location = new Point(20, 190);
            Lbl_ExpDate.Margin = new Padding(2, 0, 2, 0);
            Lbl_ExpDate.Name = "Lbl_ExpDate";
            Lbl_ExpDate.Size = new Size(68, 16);
            Lbl_ExpDate.TabIndex = 4;
            Lbl_ExpDate.Text = "Exp. Date";
            // 
            // Lbl_Qty
            // 
            Lbl_Qty.AutoSize = true;
            Lbl_Qty.Location = new Point(20, 230);
            Lbl_Qty.Margin = new Padding(2, 0, 2, 0);
            Lbl_Qty.Name = "Lbl_Qty";
            Lbl_Qty.Size = new Size(32, 16);
            Lbl_Qty.TabIndex = 5;
            Lbl_Qty.Text = "Qty.";
            // 
            // Lbl_SellPrice
            // 
            Lbl_SellPrice.AutoSize = true;
            Lbl_SellPrice.Location = new Point(20, 270);
            Lbl_SellPrice.Margin = new Padding(2, 0, 2, 0);
            Lbl_SellPrice.Name = "Lbl_SellPrice";
            Lbl_SellPrice.Size = new Size(66, 16);
            Lbl_SellPrice.TabIndex = 6;
            Lbl_SellPrice.Text = "Sell Price";
            // 
            // txtProductName
            // 
            txtProductName.BackColor = Color.Black;
            txtProductName.BorderStyle = BorderStyle.FixedSingle;
            txtProductName.ForeColor = Color.White;
            txtProductName.Location = new Point(130, 67);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(250, 23);
            txtProductName.TabIndex = 7;
            // 
            // txtSellPrice
            // 
            txtSellPrice.BackColor = Color.Black;
            txtSellPrice.BorderStyle = BorderStyle.FixedSingle;
            txtSellPrice.ForeColor = Color.White;
            txtSellPrice.Location = new Point(130, 267);
            txtSellPrice.Name = "txtSellPrice";
            txtSellPrice.Size = new Size(250, 23);
            txtSellPrice.TabIndex = 8;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.Black;
            txtQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtQuantity.ForeColor = Color.White;
            txtQuantity.Location = new Point(130, 227);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(250, 23);
            txtQuantity.TabIndex = 9;
            // 
            // cbCategory
            // 
            cbCategory.BackColor = Color.Black;
            cbCategory.FlatStyle = FlatStyle.Flat;
            cbCategory.ForeColor = Color.White;
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(130, 107);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(250, 24);
            cbCategory.TabIndex = 10;
            // 
            // dtPickerMfgDate
            // 
            dtPickerMfgDate.CalendarForeColor = Color.White;
            dtPickerMfgDate.CalendarMonthBackground = Color.Black;
            dtPickerMfgDate.CalendarTitleForeColor = Color.White;
            dtPickerMfgDate.CalendarTrailingForeColor = Color.Black;
            dtPickerMfgDate.Location = new Point(130, 145);
            dtPickerMfgDate.Name = "dtPickerMfgDate";
            dtPickerMfgDate.Size = new Size(250, 23);
            dtPickerMfgDate.TabIndex = 11;
            // 
            // dtPickerExpDate
            // 
            dtPickerExpDate.CalendarForeColor = Color.White;
            dtPickerExpDate.CalendarMonthBackground = Color.Black;
            dtPickerExpDate.CalendarTitleForeColor = Color.White;
            dtPickerExpDate.CalendarTrailingForeColor = Color.Black;
            dtPickerExpDate.Location = new Point(130, 185);
            dtPickerExpDate.Name = "dtPickerExpDate";
            dtPickerExpDate.Size = new Size(250, 23);
            dtPickerExpDate.TabIndex = 12;
            // 
            // Lbl_Description
            // 
            Lbl_Description.AutoSize = true;
            Lbl_Description.Location = new Point(421, 70);
            Lbl_Description.Margin = new Padding(2, 0, 2, 0);
            Lbl_Description.Name = "Lbl_Description";
            Lbl_Description.Size = new Size(78, 16);
            Lbl_Description.TabIndex = 13;
            Lbl_Description.Text = "Description";
            // 
            // richTxtDescription
            // 
            richTxtDescription.BackColor = Color.Black;
            richTxtDescription.BorderStyle = BorderStyle.FixedSingle;
            richTxtDescription.ForeColor = Color.White;
            richTxtDescription.Location = new Point(421, 107);
            richTxtDescription.Name = "richTxtDescription";
            richTxtDescription.Size = new Size(351, 183);
            richTxtDescription.TabIndex = 14;
            richTxtDescription.Text = "";
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.Black;
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.Location = new Point(649, 296);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(123, 23);
            btnAddProduct.TabIndex = 15;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // gridViewProductList
            // 
            gridViewProductList.BackgroundColor = Color.Black;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridViewProductList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridViewProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridViewProductList.DefaultCellStyle = dataGridViewCellStyle2;
            gridViewProductList.GridColor = Color.Black;
            gridViewProductList.Location = new Point(12, 325);
            gridViewProductList.Name = "gridViewProductList";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            gridViewProductList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.Black;
            dataGridViewCellStyle4.ForeColor = Color.White;
            gridViewProductList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            gridViewProductList.RowTemplate.Height = 25;
            gridViewProductList.Size = new Size(760, 224);
            gridViewProductList.TabIndex = 16;
            // 
            // FrmAddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Black;
            ClientSize = new Size(784, 561);
            Controls.Add(gridViewProductList);
            Controls.Add(btnAddProduct);
            Controls.Add(richTxtDescription);
            Controls.Add(Lbl_Description);
            Controls.Add(dtPickerExpDate);
            Controls.Add(dtPickerMfgDate);
            Controls.Add(cbCategory);
            Controls.Add(txtQuantity);
            Controls.Add(txtSellPrice);
            Controls.Add(txtProductName);
            Controls.Add(Lbl_SellPrice);
            Controls.Add(Lbl_Qty);
            Controls.Add(Lbl_ExpDate);
            Controls.Add(Lbl_MfgDate);
            Controls.Add(Lbl_Category);
            Controls.Add(Lbl_ProductName);
            Controls.Add(Lbl_addProduct);
            Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(800, 600);
            Name = "FrmAddProduct";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory";
            Load += FrmAddProduct_Load;
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_addProduct;
        private Label Lbl_ProductName;
        private Label Lbl_Category;
        private Label Lbl_MfgDate;
        private Label Lbl_ExpDate;
        private Label Lbl_Qty;
        private Label Lbl_SellPrice;
        private TextBox txtProductName;
        private TextBox txtSellPrice;
        private TextBox txtQuantity;
        private ComboBox cbCategory;
        private DateTimePicker dtPickerMfgDate;
        private DateTimePicker dtPickerExpDate;
        private Label Lbl_Description;
        private RichTextBox richTxtDescription;
        private Button btnAddProduct;
        private DataGridView gridViewProductList;
    }
}