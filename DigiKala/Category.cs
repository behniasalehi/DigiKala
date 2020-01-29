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
    public partial class Category : Form
    {
        #region [- ctor -]
        public Category()
        {
            InitializeComponent();
            Ref_CategoryViewModel = new ViewModel.Category.CategoryViewModel();
        }
        #endregion
        public ViewModel.Category.CategoryViewModel Ref_CategoryViewModel { get; set; }

        #region [- Category_Load -]
        private void Category_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Ref_CategoryViewModel.FillGrid();
        } 
        #endregion
    }
}
