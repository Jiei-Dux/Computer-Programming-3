using System.Text.RegularExpressions;

namespace Inventory
{
    public partial class FrmAddProduct : Form
    {
        class NumberFormatException : Exception
        {
            public NumberFormatException(string quantity) : base(quantity) { }
        }

        class StringFormatException : Exception
        {
            public StringFormatException(string name) : base(name) { }
        }

        class CurrencyFormatException : Exception
        {
            public CurrencyFormatException(string price) : base(price) { }
        }

        private int _Quantity;
        private double _SellPrice;
        private string
            _ProductName, _Category, _MfgDate, _ExpDate, _Description;
        BindingSource showProductList;

        public FrmAddProduct()
        {
            InitializeComponent();
            showProductList = new BindingSource();
        }

        private void FrmAddProduct_Load(object sender, EventArgs e)
        {
            string[] ListOfProductCategory = new string[]
            {
                "Beverages", "Bread / Bakery",
                "Canned / Jarred Goods",
                "Dairy",
                "Frozen Goods",
                "Meat",
                "Personal Care",
                "Other"
            };

            foreach (string variableName in ListOfProductCategory)
            {
                cbCategory.Items.Add(variableName);
            }
        }

        public string Product_Name(string name)
        {
            try
            {
                if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
                {
                    throw new StringFormatException(name);
                }
            }
            catch (StringFormatException e)
            {
                MessageBox.Show("Error..." + e.Message);
            }

            return name;
        }

        public int Quantity(string qty)
        {
            try
            {
                if (!Regex.IsMatch(qty, @"^[0-9]"))
                {
                    throw new NumberFormatException(qty);
                }
            }
            catch (NumberFormatException e)
            {
                MessageBox.Show("Error..." + e.Message);
            }

            return Convert.ToInt32(qty);
        }

        public double SellingPrice(string price)
        {
            try
            {
                if (!Regex.IsMatch(price.ToString(), @"^(\d*\.)?\d+$"))
                {
                    throw new CurrencyFormatException(price);
                }
            }
            catch (CurrencyFormatException e)
            {
                MessageBox.Show("Error..." + e.Message);
            }

            return Convert.ToDouble(price);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            _ProductName = Product_Name(txtProductName.Text);
            _Category = cbCategory.Text;

            _MfgDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
            _ExpDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");

            _Description = richTxtDescription.Text;

            _Quantity = Quantity(txtQuantity.Text);
            _SellPrice = SellingPrice(txtSellPrice.Text);

            showProductList.Add(
                new ProductClass(
                    _ProductName,
                    _Category,
                    _MfgDate,
                    _ExpDate,
                    _SellPrice,
                    _Quantity,
                    _Description
                    )
                );

            gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridViewProductList.DataSource = showProductList;
        }

    }
}
