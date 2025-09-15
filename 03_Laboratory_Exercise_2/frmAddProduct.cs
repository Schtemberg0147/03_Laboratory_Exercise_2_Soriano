using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _03_Laboratory_Exercise_2
{
    public partial class frmAddProduct : Form
    {
        BindingSource showProductList;
        private int _Quantity;
        private double _SellPrice;
        private string _ProductName, _Category, _MfgDate, _ExpDate, _Description;
        public frmAddProduct()
        {
            InitializeComponent();
            showProductList = new BindingSource();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _ProductName = Product_Name(txtProductName.Text);
                _Category = cbCategory.Text;
                _MfgDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
                _ExpDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
                _Description = richTxtDescription.Text;
                _Quantity = Quantity(txtQuantity.Text);
                _SellPrice = SellingPrice(txtSellPrice.Text);
                showProductList.Add(new ProductClass(_ProductName, _Category, _MfgDate,
                _ExpDate, _SellPrice, _Quantity, _Description));
                gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                gridViewProductList.DataSource = showProductList;
            }
            catch (StringFormatException sfe)
            {
                MessageBox.Show(sfe.Message);
            }catch(NumberFormatException nfe)
            {
                MessageBox.Show(nfe.Message);
            }catch(CurrencyFormatException cfe)
            {
                MessageBox.Show(cfe.Message);
            }
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            string[] ListOfProductCategory = {"Beverages", "Bread", "Canned/Jarred Goods", "Dairy", "Frozen Goods", "Meat", "Personal Care", "Other"};
            foreach(string variableName in ListOfProductCategory){
                cbCategory.Items.Add(variableName);
            }
        }

        public string Product_Name(string name)
        {
                if (!Regex.IsMatch(name, @"^[a-zA-Z]+$")) 
                    throw new StringFormatException("Invalid String Format");
                    return name;
        }
        public int Quantity(string qty)
        {
                if (!Regex.IsMatch(qty, @"^[0-9]"))
                    //Exception here
                    throw new NumberFormatException("Invalid Number Format");
                    return Convert.ToInt32(qty);
        }

        public double SellingPrice(string price)
        {

            if (!Regex.IsMatch(price.ToString(), @"^(\d*\.)?\d+$"))
                //Exception here
                throw new CurrencyFormatException("Invalid Currency Format");
                return Convert.ToDouble(price);
        }

        class NumberFormatException : Exception
        {
            public NumberFormatException(string message) : base(message) { }
        }
        class StringFormatException : Exception
        {
            public StringFormatException(string message) : base(message) { }
        }
        class CurrencyFormatException : Exception
        {
            public CurrencyFormatException(string message): base(message) { }
        }
    }
}

