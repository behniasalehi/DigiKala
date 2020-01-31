using DigiKala.Model.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public string SaveBySp(List<Model.Helper.SPHelper.Category.InsertCategory> listInsertCategory)
        {
          
            using (var context = new DTO.EF.DigiKalaEntities())
            {
                try
                {
                    #region [- SqlParameter -]
                    SqlParameter categoryListParameter = new SqlParameter()
                    {
                        ParameterName = "@CategoryInfo",
                        SqlDbType = System.Data.SqlDbType.Structured,
                        TypeName = "dbo.udt_Insert_Category",
                        Value = listInsertCategory.ToDataTable()
                    };
                    SqlParameter outputParameter = new SqlParameter()
                    {
                        ParameterName = "@message",
                        SqlDbType = SqlDbType.NVarChar,
                        Size = -1,
                        Direction = ParameterDirection.Output,
                        Value = DBNull.Value
                    };

                    #endregion
                    #region [- parameters  -]
                    object[] parameters =
                       {
                categoryListParameter,outputParameter
            };
                    #endregion
                    
                    context.Database.ExecuteSqlCommand("dbo.usp_Insert_Category @CategoryInfo, @message OUTPUT", parameters);
                    var message = outputParameter.Value;
                    return message.ToString() ;
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
        #region [- UpdateBySp(List<Model.Helper.SPHelper.Category.UpdateCategory> listUpdateCategory) -]
        public void UpdateBySp(List<Model.Helper.SPHelper.Category.UpdateCategory> listUpdateCategory)
        {
            using (var context = new DTO.EF.DigiKalaEntities())
            {
                try
                {
                    context.Database.ExecuteSqlCommand(Model.Helper.SPHelper.Category.CategorySpHelper.Usp_Category_Update,
                  Model.Helper.SPHelper.Category.CategorySpHelper.SetUpdateParameters(listUpdateCategory));
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
