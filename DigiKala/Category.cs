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
            Categories = new List<Model.Helper.SPHelper.Category.InsertCategory>();
            Ref_validation = new View.Validation();
           
            DeleteCategories = new List<Model.Helper.SPHelper.Category.DeleteCategory>();
            //Ref_UpdateCategory = new Model.Helper.SPHelper.Category.UpdateCategory();
            Updates = new List<Model.Helper.SPHelper.Category.UpdateCategory>();
        }
        #endregion
        #region [- props -]
        public ViewModel.Category.CategoryViewModel Ref_CategoryViewModel { get; set; }
        public Model.Helper.SPHelper.Category.InsertCategory Ref_InsertCategory { get; set; }
        public List<Model.Helper.SPHelper.Category.InsertCategory> Categories { get; set; }
        public View.Validation Ref_validation { get; set; }
        public Model.Helper.SPHelper.Category.DeleteCategory Ref_Category_Delete { get; set; }
        public List<Model.Helper.SPHelper.Category.DeleteCategory> DeleteCategories { get; set; }
        public Model.Helper.SPHelper.Category.UpdateCategory Ref_UpdateCategory { get; set; }
        public List<Model.Helper.SPHelper.Category.UpdateCategory> Updates { get; set; }
        #endregion

        #region [- ClearAll() -]
        public void ClearAll()
        {
            txtName.Text = string.Empty;
            txtDescriptions.Text = string.Empty;
            lblerrName.Text = null;
            lblerrDescriptions.Text = null;

        } 
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
                Ref_InsertCategory = new Model.Helper.SPHelper.Category.InsertCategory();
                Ref_InsertCategory.CategoryName = txtName.Text;
                Ref_InsertCategory.Descriptions = txtDescriptions.Text;
                Categories.Add(Ref_InsertCategory);
                Ref_CategoryViewModel.Save(Categories);
                Categories.Clear();
                dataGridView1.DataSource = Ref_CategoryViewModel.FillGrid();
                ClearAll();
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

        #region [- btnDelete_Click -]
        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int value = Convert.ToInt32(row.Cells[0].Value);
                Ref_Category_Delete = new Model.Helper.SPHelper.Category.DeleteCategory();
                Ref_Category_Delete.Id = value;
                DeleteCategories.Add(Ref_Category_Delete);
               
            }
            Ref_CategoryViewModel.Delete(DeleteCategories);
            dataGridView1.DataSource = Ref_CategoryViewModel.FillGrid();
        }

        #endregion

        #region [- btnEdit_Click -]
        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtName.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            txtDescriptions.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            btnSaveChanges.Enabled = true;
        }
        #endregion

        #region [- btnSaveChanges_Click -]
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (Ref_validation.CategoryNameValidation(txtName.Text) &&
                Ref_validation.CategorydescriptionsValidation(txtDescriptions.Text))
            {
                Ref_UpdateCategory = new Model.Helper.SPHelper.Category.UpdateCategory();
                Ref_UpdateCategory.Id = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
                Ref_UpdateCategory.CategoryName = txtName.Text;
                Ref_UpdateCategory.Descriptions = txtDescriptions.Text;
                Updates.Add(Ref_UpdateCategory);
                Ref_CategoryViewModel.Edit(Updates);
                Updates.Clear();
                dataGridView1.DataSource = Ref_CategoryViewModel.FillGrid();
                ClearAll();
                btnSaveChanges.Enabled = false;
            }
            else
            {
                MessageBox.Show("please check fields");
            }
            
        } 
        #endregion
    }
}
