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
        public const string Usp_Product_Update = "dbo.usp_Update_Product @UpdateProduct";
        public const string Usp_Product_Delete = "dbo.usp_Delete_Product @DeleteProduct";


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
        #region [-   SetUpdateParameters(List<UpdateProduct> listUpdateProduct) -]
        public static object[] SetUpdateParameters(List<UpdateProduct> listUpdateProduct)
        {
            #region [- SqlParameter -]
            SqlParameter productListupdateParameter = new SqlParameter()
            {
                ParameterName = "@UpdateProduct",
                SqlDbType = System.Data.SqlDbType.Structured,
                TypeName = "dbo.udt_Update_Product",
                Value = listUpdateProduct.ToDataTable()
            };
            #endregion
            #region [- parameters  -]
            object[] parameters =
               {
                productListupdateParameter
            };
            #endregion
            return parameters;
        }
        #endregion
        #region [-   SetInsertParameters(List<InsertProduct> listInsertProduct) -]
        public static object[] SetDeleteParameters(List<DeleteProduct> listDeleteProduct)
        {
            #region [- SqlParameter -]
            SqlParameter productDeleteParameter = new SqlParameter()
            {
                ParameterName = "@DeleteProduct",
                SqlDbType = System.Data.SqlDbType.Structured,
                TypeName = "dbo.udt_Delete_Product",
                Value = listDeleteProduct.ToDataTable()
            };
            #endregion
            #region [- parameters  -]
            object[] parameters =
               {
                productDeleteParameter
            };
            #endregion
            return parameters;
        }
        #endregion
    }
}
