using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiKala.Model.Helper.SPHelper.Order
{
  public  class InsertOrderDetail
    {
        #region [- ctor -]
        public InsertOrderDetail()
        {

        }
        #endregion
        public int Product_Ref { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantiy { get; set; }
        public decimal Discount { get; set; }
    }
}
