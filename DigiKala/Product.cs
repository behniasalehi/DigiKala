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
            Ref_validation = new View.Validation();
            Ref_InsertProduct = new Model.Helper.SPHelper.Product.InsertProduct();
            Products = new List<Model.Helper.SPHelper.Product.InsertProduct>();
        }
        #endregion
        #region [- props -]
        public ViewModel.Product.ProductViewModel Ref_ProductViewModel { get; set; }
        public View.Validation Ref_validation { get; set; }
        public Model.Helper.SPHelper.Product.InsertProduct Ref_InsertProduct { get; set; }
        public List<Model.Helper.SPHelper.Product.InsertProduct> Products { get; set; }
        #endregion
        #region [- ClearAll -]
        public void ClearAll()
        {
            txtCategory.Clear();
            txtDiscount.Clear();
            txtName.Clear();
            txtUnitPrice.Clear();
            numericUpDown1.Value = 0;
            pictureBox1.Image = null;
            lblerrCategoryName.Text = string.Empty;

        } 
        #endregion
        #region [- Product_Load -]
        private void Product_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = Ref_ProductViewModel.FillGrid();
            dataGridView1.DataSource = Ref_ProductViewModel.SelectCategoryName();
        }
        #endregion

        #region [- btnRefresh_Click -]
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = Ref_ProductViewModel.FillGrid();
        }



        #endregion

        #region [- btnSelectCategory_Click -]
        private void btnSelectCategory_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            btnSubmit.Visible = true;
        } 
        #endregion
        #region [- ImageToByteArray -]
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        #endregion

        #region [- btnBrowse_Click -]
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files(*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        #endregion

        #region [- btnSubmit_Click -]
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            txtCategory.Text = Convert.ToString(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
            dataGridView1.Visible = false;
            btnSubmit.Visible = false;
        }
        #endregion

        #region [- txtName_TextChanged -]
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (Ref_validation.CategoryNameValidation(txtName.Text) == false)
            {
                lblerrCategoryName.Text = "please enter character and numbers";
                lblerrCategoryName.ForeColor = Color.Red;
            }
            else
            {
                lblerrCategoryName.Text = "correct";
                lblerrCategoryName.ForeColor = Color.Green;
            }
        }
        #endregion

        #region [- btnSave_Click -]
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text != string.Empty &&
                Ref_validation.CategoryNameValidation(txtName.Text) &&
                txtUnitPrice.Text != string.Empty &&
                txtDiscount.Text != string.Empty
                 && pictureBox1.Image != null &&
                 numericUpDown1.Value > 0
                )
            {
                Ref_InsertProduct.Category_Ref = Convert.ToInt32(txtCategory.Text);
                Ref_InsertProduct.Discount = Convert.ToInt32(txtDiscount.Text);
                Ref_InsertProduct.ProductImage = ImageToByteArray(pictureBox1.Image);
                Ref_InsertProduct.ProductName = txtName.Text;
                Ref_InsertProduct.Quantiy = Convert.ToInt32(numericUpDown1.Value);
                Ref_InsertProduct.UnitPrice = Convert.ToInt32(txtUnitPrice.Text);
                Products.Add(Ref_InsertProduct);
                Ref_ProductViewModel.Save(Products);
                ClearAll();
                dataGridView2.DataSource = Ref_ProductViewModel.FillGrid();
            }
            else
            {
                MessageBox.Show("please check fields");
            }
        } 
        #endregion
    }
}
