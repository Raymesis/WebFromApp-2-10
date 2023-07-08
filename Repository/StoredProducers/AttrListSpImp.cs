using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication2.DatabaseModel;
using WebApplication2.Adapter;
using System.Data;

namespace WebApplication2.Repository.StoredProducers
{
    public class AttrListSpImp:IAttrListDao
    {
        SpImp<List<Model.AttrList>> spImp = new SpImp<List<Model.AttrList>>();

        public List<Model.AttrList> GetAttrsList()
        {
            SqlParameter[] parameters = { };

            return spImp.Read(
                "dbo.GetAttributesList",
                parameters,
                new AttrListAdapter().ToList
                );
        }

        public Model.AttrList GetAttrListsById(int attrListId)
        {
            SqlParameter[] parameters = 
            {
                new SqlParameter("@AttrListId", attrListId)
            };

            return spImp.Read(
                "dbo.GetAttributesListById",
                parameters,
                new AttrListAdapter().ToList
                ).First();
        }

        public List<Model.AttrList> GetAttrsListByCategoryId(int catId)
        {
            SqlParameter[] parameters = 
            {
                new SqlParameter("@AttrId", catId)
            };

            return spImp.Read(
                "dbo.GetAttributesListByCategoryAttrId",
                parameters,
                new AttrListAdapter().ToList
                );
        }

        public int EditAttrList(Model.AttrList attList)
        {
            SqlParameter[] parameters = 
            {                                            
                new SqlParameter("@val", attList.Value),
                new SqlParameter("@Id", attList.Id)
            };

            return spImp.Write("dbo.EditAttributeValues", parameters);
        }

        public int DeleteAttrList(int AttrId)
        {
            SqlParameter[] parameters = 
            {                                            
                new SqlParameter("@Id", AttrId)
            };

            return spImp.Write("dbo.DeleteAttributeValues", parameters);
        }

        public int InsertAttrList(Model.AttrList attrList)
        {
            SqlParameter[] parameters = 
            {                                            
                new SqlParameter("@Value", attrList.Value),
                new SqlParameter("@Attrid", attrList.Attrid)
            };

            return spImp.Write("dbo.InsertAttributeValues", parameters);
        }
    }
}