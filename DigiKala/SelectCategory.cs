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
    public partial class SelectCategory : Form
    {
        #region [- ctor -]
        public SelectCategory()
        {
            InitializeComponent();
            Ref_ProductViewModel = new ViewModel.Product.ProductViewModel();
        }
        #endregion
        public ViewModel.Product.ProductViewModel Ref_ProductViewModel { get; set; }
        public Product Ref_Product { get; set; }

        #region [- SelectCategory_Load -]
        private void SelectCategory_Load(object sender, EventArgs e)
        {
            ParentCategory.DataSource = Ref_ProductViewModel.SelectCategoryName();
        }
        #endregion

        private void btnSelectCategory_Click(object sender, EventArgs e)
        {
            Ref_Product = new Product();
            
            
            //ParentCategory[0, ParentCategory.CurrentRow.Index].Value.ToString();
            this.Close();
            Ref_Product.txtCategory.Text = "ali";
        }
    }
}
