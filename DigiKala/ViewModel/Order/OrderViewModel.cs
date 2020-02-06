using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiKala.ViewModel.Order
{
   public class OrderViewModel
    {
        #region [- ctor -]
        public OrderViewModel()
        {
            Ref_OrderCrud = new Model.DomainModel.POCO.OrderCrud();
        }
        #endregion
        public Model.DomainModel.POCO.OrderCrud Ref_OrderCrud { get; set; }
        #region [- Save(List<Model.Helper.SPHelper.Order.InsertOrderMaster> listInsertOrderMaster, List<Model.Helper.SPHelper.Order.InsertOrderDetail> listInsertOrderDetail) -]
        public void Save(List<Model.Helper.SPHelper.Order.InsertOrderMaster> listInsertOrderMaster,
            List<Model.Helper.SPHelper.Order.InsertOrderDetail> listInsertOrderDetail)
        {
            Ref_OrderCrud.SaveBySp(listInsertOrderMaster, listInsertOrderDetail);
        } 
        #endregion
    }
}
