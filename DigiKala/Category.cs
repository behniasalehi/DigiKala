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
            Ref_InsertCategory = new Model.Helper.SPHelper.Category.InsertCategory();
            Categories = new List<Model.Helper.SPHelper.Category.InsertCategory>();
            Ref_validation = new View.Validation();
        }
        #endregion
        #region [- props -]
        public ViewModel.Category.CategoryViewModel Ref_CategoryViewModel { get; set; }
        public Model.Helper.SPHelper.Category.InsertCategory Ref_InsertCategory { get; set; }
        public List<Model.Helper.SPHelper.Category.InsertCategory> Categories { get; set; }
        public View.Validation Ref_validation { get; set; }
        #endregion

        #region [- Category_Load -]
        private void Category_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Ref_CategoryViewModel.FillGrid();
        }
        #endregion

        #region [- btnRefresh_Click -]
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Ref_CategoryViewModel.FillGrid();
        }
        #endregion

        #region [- btnSave_Click -] 
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Ref_validation.CategoryNameValidation(txtName.Text) && 
                Ref_validation.CategorydescriptionsValidation(txtDescriptions.Text))
            {
                Ref_InsertCategory.CategoryName = txtName.Text;
                Ref_InsertCategory.Descriptions = txtDescriptions.Text;
                Categories.Add(Ref_InsertCategory);
                Ref_CategoryViewModel.Save(Categories);
                dataGridView1.DataSource = Ref_CategoryViewModel.FillGrid();
            }
            else
            {
                MessageBox.Show("please check fields");
            }

        }
        #endregion

        #region [- txtName_TextChanged -]
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (Ref_validation.CategoryNameValidation(txtName.Text) == false)
            {
                lblerrName.Text = "please enter character and numbers";
                lblerrName.ForeColor = Color.Red;
            }
            else
            {
                lblerrName.Text = "correct";
                lblerrName.ForeColor = Color.Green;
            }
        }
        #endregion

        #region [- txtDescriptions_TextChanged -]
        private void txtDescriptions_TextChanged(object sender, EventArgs e)
        {
            if (Ref_validation.CategorydescriptionsValidation(txtDescriptions.Text) == false)
            {
                lblerrDescriptions.Text = "please enter character and numbers";
                lblerrDescriptions.ForeColor = Color.Red;
            }
            else
            {
                lblerrDescriptions.Text = "correct";
                lblerrDescriptions.ForeColor = Color.Green;

            }
        } 
        #endregion
    }
}
