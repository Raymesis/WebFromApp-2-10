using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Model;

namespace WebApplication2.Repository
{
    interface IAttrListDao
    {
        List<AttrList> GetAttrsList();
        AttrList GetAttrListsById(int attrListId);
        List<AttrList> GetAttrsListByCategoryId(int catId);
        int EditAttrList(AttrList attList);
        int DeleteAttrList(int postAttrId);
        int InsertAttrList(AttrList attrList);
    }
}