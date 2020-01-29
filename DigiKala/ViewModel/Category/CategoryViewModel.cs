using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiKala.ViewModel.Category
{
    public class CategoryViewModel
    {
        #region [- ctor -]
        public CategoryViewModel()
        {
            Ref_CatgoryCrud = new Model.DomainModel.POCO.CategoryCrud();
        }
        #endregion
        public Model.DomainModel.POCO.CategoryCrud Ref_CatgoryCrud { get; set; }
        #region [-  FillGrid() -]
        public dynamic FillGrid()
        {
            return Ref_CatgoryCrud.Select();
        }
        #endregion
        //#region [- Save(List<Model.Helper.SPHelper.Category.InsertCategory> listInsertCategory) -]
        //public void Save(List<Model.Helper.SPHelper.Category.InsertCategory> listInsertCategory)
        //{
        //    Ref_CatgoryCrud.SaveBySp(listInsertCategory);
        //}
        //#endregion
        //#region [- Edit(List<Model.Helper.SPHelper.Category.UpdateCategory> listUpdateCategory) -]
        //public void Edit(List<Model.Helper.SPHelper.Category.UpdateCategory> listUpdateCategory)
        //{
        //    Ref_CatgoryCrud.UpdateBySp(listUpdateCategory);
        //}
        //#endregion
        //#region [- Delete(List<Model.Helper.SPHelper.Category.DeleteCategory> listDeleteCategory) -]
        //public void Delete(List<Model.Helper.SPHelper.Category.DeleteCategory> listDeleteCategory)
        //{
        //    Ref_CatgoryCrud.DeleteBySp(listDeleteCategory);
        //}
        //#endregion

    }
}
