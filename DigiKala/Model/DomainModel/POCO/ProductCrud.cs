using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiKala.Model.DomainModel.POCO
{
   public class ProductCrud
    {
        #region [- ctor -]
        public ProductCrud()
        {

        }
        #endregion

        #region [- SelectProduct() -]
        public List<Helper.SPHelper.Product.SelectProduct> SelectProduct()
        {
            using (var context = new DTO.EF.DigiKalaEntities())
            {
                List<Helper.SPHelper.Product.SelectProduct> list_Category = new List<Helper.SPHelper.Product.SelectProduct>();
                try
                {
                    list_Category = context.Database.SqlQuery<Helper.SPHelper.Product.SelectProduct>
                        (Model.Helper.SPHelper.Product.ProductSpHelper.Usp_Product_Select).ToList();
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

        #region [- SelectCategoryName() -]
        public List<Helper.SPHelper.Product.SelectCategoryName> SelectCategoryName()
        {
            using (var context = new DTO.EF.DigiKalaEntities())
            {
                List<Helper.SPHelper.Product.SelectCategoryName> list_Category = new List<Helper.SPHelper.Product.SelectCategoryName>();
                try
                {
                    list_Category = context.Database.SqlQuery<Helper.SPHelper.Product.SelectCategoryName>
                        (Model.Helper.SPHelper.Product.ProductSpHelper.Usp_Product_SelectCategoryName).ToList();
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

        #region [- SaveBySp(List<Model.Helper.SPHelper.Product.InsertProduct> listInsertProduct) -]
        public void SaveBySp(List<Model.Helper.SPHelper.Product.InsertProduct> listInsertProduct)
        {
            using (var context = new DTO.EF.DigiKalaEntities())
            {
                try
                {
                    context.Database.ExecuteSqlCommand(Model.Helper.SPHelper.Product.ProductSpHelper.Usp_Product_Insert,
                  Model.Helper.SPHelper.Product.ProductSpHelper.SetInsertParameters(listInsertProduct));
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
