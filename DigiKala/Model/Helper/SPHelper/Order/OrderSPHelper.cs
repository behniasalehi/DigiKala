using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiKala.Model.Helper.SPHelper.Order
{
  public  class OrderSPHelper
    {
        #region [- ctor -]
        public OrderSPHelper()
        {

        }
        #endregion
        public const string Usp_Order_Insert = "dbo.usp_Insert_Order @OrderMaster , @OrderDetail";
        #region [-  SetInsertParameters(List<InsertCategory> listInsertCategory) -]
        public static object[] SetInsertParameters(List<InsertOrderMaster> listInsertOrderMaster 
            , List<InsertOrderDetail> listInsertOrderDetail)
        {
            #region [- SqlParameter -]
            SqlParameter OrderMasterListParameter = new SqlParameter()
            {
                ParameterName = "@OrderMaster",
                SqlDbType = System.Data.SqlDbType.Structured,
                TypeName = "dbo.udt_Insert_OrderMaster",
                Value = listInsertOrderMaster.ToDataTable()
            };
            SqlParameter OrderDetailListParameter = new SqlParameter()
            {
                ParameterName = "@OrderDetail",
                SqlDbType = System.Data.SqlDbType.Structured,
                TypeName = "dbo.udt_Insert_OrderDetail",
                Value = listInsertOrderMaster.ToDataTable()
            };
            #endregion

            #region [- parameters  -]
            object[] parameters =
               {
                OrderMasterListParameter,
                OrderDetailListParameter
            };
            #endregion
            return parameters;
        }
        #endregion
    }
}
