using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiKala.Model.Helper.SPHelper.Product
{
  public  class ProductSpHelper
    {
        public const string Usp_Product_SelectCategoryName = "Exec dbo.usp_Select_CategoryName";
        public const string Usp_Product_Select = "Exec dbo.usp_Select_Product";
        public const string Usp_Product_Insert = "dbo.usp_Insert_Product @ProductInfo";
       

        #region [-   SetInsertParameters(List<InsertProduct> listInsertProduct) -]
        public static object[] SetInsertParameters(List<InsertProduct> listInsertProduct)
        {
            #region [- SqlParameter -]
            SqlParameter productListParameter = new SqlParameter()
            {
                ParameterName = "@ProductInfo",
                SqlDbType = System.Data.SqlDbType.Structured,
                TypeName = "dbo.udt_Insert_Product",
                Value = listInsertProduct.ToDataTable()
            };
            #endregion
            #region [- parameters  -]
            object[] parameters =
               {
                productListParameter
            };
            #endregion
            return parameters;
        }
        #endregion
    }
}
