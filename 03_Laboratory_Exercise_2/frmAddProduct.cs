using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Laboratory_Exercise_2
{
    public partial class frmAddProduct : Form
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            string[] ListOfProductCategory = {"Beverages", "Bread", "Canned/Jarred Goods", "Dairy", "Frozen Goods", "Meat", "Personal Care", "Other"};
        }
    }
}
