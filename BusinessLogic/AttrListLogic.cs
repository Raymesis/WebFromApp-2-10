using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Repository;
using WebApplication2.Repository.StoredProducers;

namespace WebApplication2.BusinessLogic
{
    public class AttrListLogic
    {
        IAttrListDao attrListDao = new AttrListSpImp();
        internal List<Model.AttrList> GetAll()
        {
            return attrListDao.GetAttrsList();
        }
        internal Model.AttrList GetById(int id)
        {
            return attrListDao.GetAttrListsById(id);
        }
        internal List<Model.AttrList> GetByCatId(int catId)
        {
            return attrListDao.GetAttrsListByCategoryId(catId);
        }

        internal void Delete(int id)
        {
            attrListDao.DeleteAttrList(id);
        }

        internal void Edit(Model.AttrList attrList)
        {
            attrListDao.EditAttrList(attrList);
        }

        internal void Insert(Model.AttrList attrList)
        {
            attrListDao.InsertAttrList(attrList);
        }
    }
}