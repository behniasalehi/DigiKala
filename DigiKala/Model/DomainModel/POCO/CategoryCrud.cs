using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiKala.Model.DomainModel.POCO
{
   public class CategoryCrud
    {
        #region [- ctor -]
        public CategoryCrud()
        {

        }
        #endregion
        #region [- Select() -]
        public List<Helper.SPHelper.Category.SelectCategory> Select()
        {
            using (var context = new DTO.EF.DigiKalaEntities())
            {
                List<Helper.SPHelper.Category.SelectCategory> list_Category = new List<Helper.SPHelper.Category.SelectCategory>();
                try
                {
                    list_Category = context.Database.SqlQuery<Helper.SPHelper.Category.SelectCategory>
                        (Model.Helper.SPHelper.Category.CategorySpHelper.Usp_Category_Select).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
                return list_Category;
            }
        }
        #endregion
        #region [- SaveBySp(List<Model.Helper.SPHelper.Category.InsertCategory> listInsertCategory) -]
        public void SaveBySp(List<Model.Helper.SPHelper.Category.InsertCategory> listInsertCategory)
        {
          
            using (var context = new DTO.EF.DigiKalaEntities())
            {
                try
                {
                 context.Database.ExecuteSqlCommand(Model.Helper.SPHelper.Category.CategorySpHelper.Usp_Category_Insert,
                  Model.Helper.SPHelper.Category.CategorySpHelper.SetInsertParameters(listInsertCategory)).ToString();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion
        #region [- DeleteBySp(List<Model.Helper.SPHelper.Category.DeleteCategory> listDeleteCategory) -]
        public void DeleteBySp(List<Model.Helper.SPHelper.Category.DeleteCategory> listDeleteCategory)
        {
            using (var context = new DTO.EF.DigiKalaEntities())
            {
                try
                {
                    context.Database.ExecuteSqlCommand(Model.Helper.SPHelper.Category.CategorySpHelper.Usp_Category_Delete,
                  Model.Helper.SPHelper.Category.CategorySpHelper.SetDeleteParameters(listDeleteCategory));
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion
    }
}
