using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiKala.Model.DomainModel.POCO
{
  public  class OrderCrud
    {
        #region [- ctor -]
        public OrderCrud()
        {

        }
        #endregion
        #region [- SaveBySp(List<Model.Helper.SPHelper.Order.InsertOrderMaster> listInsertOrderMaster,List<Model.Helper.SPHelper.Order.InsertOrderDetail> listInsertOrderDetail) -]
        public void SaveBySp(List<Model.Helper.SPHelper.Order.InsertOrderMaster> listInsertOrderMaster,
            List<Model.Helper.SPHelper.Order.InsertOrderDetail> listInsertOrderDetail)
        {

            using (var context = new DTO.EF.DigiKalaEntities())
            {
                try
                {
                    context.Database.ExecuteSqlCommand(Model.Helper.SPHelper.Order.OrderSPHelper.Usp_Order_Insert,
                     Model.Helper.SPHelper.Order.OrderSPHelper.SetInsertParameters(listInsertOrderMaster, listInsertOrderDetail)).ToString();
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
