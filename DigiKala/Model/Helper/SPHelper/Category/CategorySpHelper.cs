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
    }
}
