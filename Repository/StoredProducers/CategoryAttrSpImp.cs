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
    public class CategoryAttrSpImp : ICategoryAttributesDao
    {
        SpImp<List<Model.CategoryAttributes>> spImp = new SpImp<List<Model.CategoryAttributes>>();

        public List<Model.CategoryAttributes> GetCategoryAttrs()
        {
            SqlParameter[] parameters = { };
            
            return spImp.Read(
                "dbo.GetCategoryAttributes",
                parameters,
                new CategoryAttrAdapter().ToList
                );
        }

        public Model.CategoryAttributes GetCategoryAttrsById(int AttrId)
        {

            SqlParameter[] parameters = 
            { 
                new SqlParameter("@AttrId", AttrId)
            };

            return spImp.
                Read(
                "dbo.GetCategoryAttributesById",
                parameters,
                new CategoryAttrAdapter().ToList
                ).First();
        }

        public List<Model.CategoryAttributes> GetCategoryAttrsByCategoryId(int catId)
        {
            SqlParameter[] parameters = { new SqlParameter("@CategoryId", catId) };

            return spImp.Read(
                "dbo.GetCategoryAttributesByCategoryId",
                parameters,
                new CategoryAttrAdapter().ToList
                );
        }

        public int EditCategoryAttr(Model.CategoryAttributes CategoryAttr)
        {
            SqlParameter[] parameters = 
            {                                            
                new SqlParameter("@CategoryId", CategoryAttr.CategoryId),         
                new SqlParameter("@AttrName", CategoryAttr.AttrName) };

            return spImp.Write("dbo.EditCategoryAttributes", parameters);

        }

        public int DeleteCategoryAttr(int AttrId)
        {
            SqlParameter[] parameters = { new SqlParameter("@AttrId", AttrId) };
            return spImp.Write("dbo.DeleteCategoryAttribute", parameters );
            
        }

        public int InsertCategoryAttr(Model.CategoryAttributes CategoryAttr)
        {
           
           SqlParameter[] parameters = 
           {
                new SqlParameter("@CategoryId", CategoryAttr.CategoryId),
                new SqlParameter("@AttrName", CategoryAttr.AttrName),
                new SqlParameter("@Type", CategoryAttr.Type)
           };

           return spImp.Write("dbo.InsertCategoryAttribute", parameters);
        }
    }
}