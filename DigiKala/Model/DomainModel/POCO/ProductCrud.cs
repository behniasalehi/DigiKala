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
    }
}
