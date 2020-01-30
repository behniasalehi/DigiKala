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
    public partial class Product : Form
    {
        #region [- ctor -]
        public Product()
        {
            InitializeComponent();
            Ref_ProductViewModel = new ViewModel.Product.ProductViewModel();
        }
        #endregion
        public ViewModel.Product.ProductViewModel Ref_ProductViewModel { get; set; }

        #region [- Product_Load -]
        private void Product_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Ref_ProductViewModel.FillGrid();
        }
        #endregion

        #region [- btnRefresh_Click -]
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Ref_ProductViewModel.FillGrid();
        } 
        #endregion
    }
}
