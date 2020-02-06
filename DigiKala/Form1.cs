using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiKala
{
    public partial class Form1 : Form
    {
        #region [- ctor -]
        public Form1()
        {
            InitializeComponent();
        } 
        #endregion

        #region [- btnCategory_Click -]
        private void btnCategory_Click(object sender, EventArgs e)
        {
            Category ref_Category = new Category();
            ref_Category.MdiParent = this;
            ref_Category.Show();
        }
        #endregion

        #region [- btnProduct_Click -]
        private void btnProduct_Click(object sender, EventArgs e)
        {
            Product ref_Product = new Product();
            ref_Product.MdiParent = this;
            ref_Product.Show();
        }
        #endregion

        #region [- btnOrder_Click -]
        private void btnOrder_Click(object sender, EventArgs e)
        {
            Order ref_Order = new Order();
            ref_Order.MdiParent = this;
            ref_Order.Show();
        } 
        #endregion
    }
}
