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
    }
}
