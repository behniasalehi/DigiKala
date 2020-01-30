using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiKala.Model.Helper.SPHelper.Product
{
   public class UpdateProduct
    {
        #region [- ctor -]
        public UpdateProduct()
        {

        }
        #endregion
        public int ProductID { get; set; }
        public int Category_Ref { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantiy { get; set; }
        public decimal Discount { get; set; }
        public byte[] ProductImage { get; set; }
    }
}
