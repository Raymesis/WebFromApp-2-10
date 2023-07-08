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
    public class PostAttrSpImp:IPostAttributesDao
    {
        SpImp<List<Model.PostAttributes>> spImp = new SpImp<List<Model.PostAttributes>>();

        DbConnection db = DbConnection.Instance;
        public List<Model.PostAttributes> GetPostAttrs()
        {
            SqlParameter[] parameters = { };

            return spImp.Read(
                "dbo.GetPostAttributes",
                parameters,
                new PostAttributeAdapter().ToList
                );
        }

        public Model.PostAttributes GetPostAttrsById(int postAttrId)
        {
            SqlParameter[] parameters = 
            { 
            
            };

            return spImp.Read(
                "dbo.GetPostAttributes",
                parameters,
                new PostAttributeAdapter().ToList
                ).First();
        }

        public List<Model.PostAttributes> GetPostAttrsByPostId(int postId)
        {
            SqlParameter[] parameters = 
            { 
                new SqlParameter("@PostId", postId),
                                       
            };

            return spImp.Read(
                "dbo.GetPostAttributesByPostId",
                parameters,
                new PostAttributeAdapter().ToList
                );
        }

        public int EditPostAttr(Model.PostAttributes postAttr)
        {
            string sp = "dbo.EditPostAttribute";

            SqlParameter[] parameters = 
             {
                 new SqlParameter("@AttrValue", postAttr.AttrValue),
                 new SqlParameter("@AttrId", postAttr.AttrId),
                 new SqlParameter("@PostId", postAttr.PostId),
                 
             };
            return spImp.Write(sp, parameters);
        }

        public int DeletePostAttr(int postAttrId)
        {
            SqlParameter[] parameters = { new SqlParameter("@PostAttrId", postAttrId) };
            return spImp.Write("dbo.DeletePostAttribute", parameters);
        }

        public int InsertPostAttr(Model.PostAttributes postAttr)
        {
            string sp = "dbo.InsertPostAttribute";

            SqlParameter[] parameters = 
             {
                 new SqlParameter("@AttrValue", postAttr.AttrValue),
                 new SqlParameter("@AttrId", postAttr.AttrId),
                 new SqlParameter("@PostId", postAttr.PostId)
             };
            return spImp.Write(sp, parameters);
        }
    }
}