using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.BusinessLogic;
using WebApplication2.Model;
using WebApplication2.Repository;
using WebApplication2.Repository.StoredProducers;

namespace WebApplication2.BusinessLogic
{
    public class PostAttributeLogic
    {
        IPostAttributesDao postAttrDao = new PostAttrSpImp();


        internal void InsertCategoryAttr(Model.PostAttributes categoryAttributes)
        {
            postAttrDao.InsertPostAttr(categoryAttributes);
        }
        internal List<Model.PostAttributes> GetAll()
        {
            return postAttrDao.GetPostAttrs();
        }
        internal Model.PostAttributes GetById(int id)
        {
            return postAttrDao.GetPostAttrsById(id);
        }
        internal List<Model.PostAttributes> GetByCategoryId(int catId)
        {
            return postAttrDao.GetPostAttrsByPostId(catId);
        }
        internal void Delete(int AttrId)
        {
            postAttrDao.DeletePostAttr(AttrId);
        }
        internal void Insert(Model.PostAttributes obj)
        {
            postAttrDao.InsertPostAttr(obj);
        }
        internal void Edit(Model.PostAttributes obj)
        {
            postAttrDao.EditPostAttr(obj);
        }
    }
}