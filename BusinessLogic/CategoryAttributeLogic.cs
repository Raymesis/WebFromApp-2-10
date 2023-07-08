using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Repository;
using WebApplication2.Repository.StoredProducers;
namespace WebApplication2.BusinessLogic
{
    public class CategoryAttributeLogic
    {
        ICategoryAttributesDao categoryAttrDao = new CategoryAttrSpImp();


        internal void InsertCategoryAttr(Model.CategoryAttributes categoryAttributes)
        {
            categoryAttrDao.InsertCategoryAttr(categoryAttributes);
        }
        internal List<Model.CategoryAttributes> GetAll()
        {
           return categoryAttrDao.GetCategoryAttrs();
        }
        internal Model.CategoryAttributes GetById(int id)
        {
           return categoryAttrDao.GetCategoryAttrsById(id);
        }
        internal List<Model.CategoryAttributes> GetByCategoryId(int catId)
        {
            return categoryAttrDao.GetCategoryAttrsByCategoryId(catId);
        }
        internal void Delete(int AttrId)
        {
            categoryAttrDao.DeleteCategoryAttr(AttrId);
        }
        internal void Insert(Model.CategoryAttributes obj)
        {
            categoryAttrDao.InsertCategoryAttr(obj);
        }
        internal void Edit(Model.CategoryAttributes obj)
        {
            categoryAttrDao.EditCategoryAttr(obj);
        }
    }
}