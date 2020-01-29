using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiKala.Model.Helper.SPHelper.Category
{
  public   class CategorySpHelper
    {
        #region [- ctor -]
        public CategorySpHelper()
        {

        }
        #endregion
        public const string Usp_Category_Select = "Exec dbo.usp_Select_Category";
        public const string Usp_Category_Insert = "dbo.usp_Insert_Category @CategoryInfo";
        public const string Usp_Category_Update = "dbo.usp_Update_Category @CategoryInfoUpdate";
        public const string Usp_Category_Delete = "dbo.usp_Delete_Category @CategoryInfoDelete";

        #region [-  SetInsertParameters(List<InsertCategory> listInsertCategory) -]
        public static object[] SetInsertParameters(List<InsertCategory> listInsertCategory)
        {
            #region [- SqlParameter -]
            SqlParameter categoryListParameter = new SqlParameter()
            {
                ParameterName = "@CategoryInfo",
                SqlDbType = System.Data.SqlDbType.Structured,
                TypeName = "dbo.udt_Insert_Category",
                Value = listInsertCategory.ToDataTable()
            };

            
            #endregion
            #region [- parameters  -]
            object[] parameters =
               {
                categoryListParameter
            };
            #endregion
            return parameters;
        }
        #endregion
        #region [-  SetUpdateParameters(List<UpdateCategory> listUpdateCategory) -]
        public static object[] SetUpdateParameters(List<UpdateCategory> listUpdateCategory)
        {
            #region [- SqlParameter -]
            SqlParameter categoryListParameter = new SqlParameter()
            {
                ParameterName = "@CategoryInfoUpdate",
                SqlDbType = System.Data.SqlDbType.Structured,
                TypeName = "dbo.udt_Update_Category",
                Value = listUpdateCategory.ToDataTable()
            };
            #endregion
            #region [- parameters  -]
            object[] parameters =
               {
                categoryListParameter
            };
            #endregion
            return parameters;
        }
        #endregion
        #region [-  SetDeleteParameters(List<DeleteCategory> listDeleteCategory) -]
        public static object[] SetDeleteParameters(List<DeleteCategory> listDeleteCategory)
        {
            #region [- SqlParameter -]
            SqlParameter categoryListParameter = new SqlParameter()
            {
                ParameterName = "@CategoryInfoDelete",
                SqlDbType = System.Data.SqlDbType.Structured,
                TypeName = "dbo.udt_Delete_Category",
                Value = listDeleteCategory.ToDataTable()
            };
            #endregion
            #region [- parameters  -]
            object[] parameters =
               {
                categoryListParameter
            };
            #endregion
            return parameters;
        }
        #endregion
    }
}
