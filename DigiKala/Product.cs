using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            Ref_UpdateProduct = new Model.Helper.SPHelper.Product.UpdateProduct();
            Updates = new List<Model.Helper.SPHelper.Product.UpdateProduct>();
            DeleteProducts = new List<Model.Helper.SPHelper.Product.DeleteProduct>();

        }
        #endregion
        #region [- props -]
        public ViewModel.Product.ProductViewModel Ref_ProductViewModel { get; set; }
        public View.Validation Ref_validation { get; set; }
        public Model.Helper.SPHelper.Product.InsertProduct Ref_InsertProduct { get; set; }
        public List<Model.Helper.SPHelper.Product.InsertProduct> Products { get; set; }
        public Model.Helper.SPHelper.Product.UpdateProduct Ref_UpdateProduct { get; set; }
        public List<Model.Helper.SPHelper.Product.UpdateProduct> Updates { get; set; }
        public Model.Helper.SPHelper.Product.DeleteProduct Ref_DeleteProduct { get; set; }
        public List<Model.Helper.SPHelper.Product.DeleteProduct> DeleteProducts { get; set; }
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
                Ref_InsertProduct.Discount = Convert.ToDecimal(txtDiscount.Text);
                Ref_InsertProduct.ProductImage = ImageToByteArray(pictureBox1.Image);
                Ref_InsertProduct.ProductName = txtName.Text;
                Ref_InsertProduct.Quantiy = Convert.ToInt32(numericUpDown1.Value);
                Ref_InsertProduct.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
                Products.Add(Ref_InsertProduct);
                Ref_ProductViewModel.Save(Products);
                Products.Clear();
                ClearAll();
                dataGridView2.DataSource = Ref_ProductViewModel.FillGrid();
            }
            else
            {
                MessageBox.Show("please check fields");
            }
        }
        #endregion
        #region [- ConverImage(object path) -]
        public Image ConverImage(object path)
        {
            byte[] bytes = (byte[])path;
            MemoryStream ms = new MemoryStream(bytes);
            return Image.FromStream(ms);
        }
        #endregion
        #region [- btnEdit_Click -]
        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtCategory.Text = dataGridView2[1, dataGridView2.CurrentRow.Index].Value.ToString();
            txtName.Text = dataGridView2[5, dataGridView2.CurrentRow.Index].Value.ToString();
            txtUnitPrice.Text = dataGridView2[2, dataGridView2.CurrentRow.Index].Value.ToString();
            numericUpDown1.Value = Convert.ToDecimal(dataGridView2[3, dataGridView2.CurrentRow.Index].Value);
            txtDiscount.Text = dataGridView2[4, dataGridView2.CurrentRow.Index].Value.ToString();
            pictureBox1.Image = ConverImage(dataGridView2[6, dataGridView2.CurrentRow.Index].Value);
            btnSaveChanges.Enabled = true;
        }
        #endregion

        #region [- btnSaveChanges_Click -]
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
           
            Ref_UpdateProduct.ProductID = Convert.ToInt32(dataGridView2[0, dataGridView2.CurrentRow.Index].Value);
            Ref_UpdateProduct.Category_Ref = Convert.ToInt32(txtCategory.Text);
            Ref_UpdateProduct.ProductName = txtName.Text;
            Ref_UpdateProduct.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
            Ref_UpdateProduct.Quantiy = Convert.ToInt32(numericUpDown1.Value);
            Ref_UpdateProduct.Discount = Convert.ToDecimal(txtDiscount.Text);
            Ref_UpdateProduct.ProductImage = ImageToByteArray(pictureBox1.Image);
            Updates.Add(Ref_UpdateProduct);
            Ref_ProductViewModel.Edit(Updates);
            Updates.Clear();
            ClearAll();
            dataGridView2.DataSource = Ref_ProductViewModel.FillGrid();

            btnSaveChanges.Enabled = false;
        }
        #endregion

        #region [- btnDelete_Click -]
        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                int value = Convert.ToInt32(row.Cells[0].Value);

                Ref_DeleteProduct = new Model.Helper.SPHelper.Product.DeleteProduct();
                Ref_DeleteProduct.Id = value;
                DeleteProducts.Add(Ref_DeleteProduct);

            }
            Ref_ProductViewModel.Delete(DeleteProducts);
            dataGridView2.DataSource = Ref_ProductViewModel.FillGrid();
        } 
        #endregion
    }
}
