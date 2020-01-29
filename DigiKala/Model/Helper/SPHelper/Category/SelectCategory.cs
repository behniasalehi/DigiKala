using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiKala.Model.Helper.SPHelper.Category
{
    public class SelectCategory
    {
        #region [- ctor -]
        public SelectCategory()
        {

        }
        #endregion
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Descriptions { get; set; }
    }
}
