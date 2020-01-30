using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiKala.ViewModel.Product
{
   public class ProductViewModel
    {
        #region [- ctor -]
        public ProductViewModel()
        {
            Ref_ProductCrud = new Model.DomainModel.POCO.ProductCrud();
        }
        #endregion
        public Model.DomainModel.POCO.ProductCrud Ref_ProductCrud { get; set; }
        #region [- SelectCategoryName() -]
        public dynamic SelectCategoryName()
        {
            return Ref_ProductCrud.SelectCategoryName();
        }
        #endregion
        #region [- FillGrid -]
        public dynamic FillGrid()
        {
            return Ref_ProductCrud.SelectProduct();
        }
        #endregion
        #region [- Save(List<Model.Helper.SPHelper.Product.InsertProduct> listInsertProduct) -]
        public void Save(List<Model.Helper.SPHelper.Product.InsertProduct> listInsertProduct)
        {
            Ref_ProductCrud.SaveBySp(listInsertProduct);
        }
        #endregion

        #region [- Edit(List<Model.Helper.SPHelper.Product.UpdateProduct> listUpdateProduct) -]
        public void Edit(List<Model.Helper.SPHelper.Product.UpdateProduct> listUpdateProduct)
        {
            Ref_ProductCrud.UpdateBySp(listUpdateProduct);
        }
        #endregion
    }
}
