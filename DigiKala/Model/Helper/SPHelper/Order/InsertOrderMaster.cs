using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiKala.Model.Helper.SPHelper.Order
{
  public  class InsertOrderMaster
    {
        #region [- ctor -]
        public InsertOrderMaster()
        {

        }
        #endregion
        public int Person_Ref { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
