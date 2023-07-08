using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using WebApplication2.DatabaseModel;
using WebApplication2.Adapter;
using System.Collections.Generic;

namespace WebApplication2.Repository.StoredProducers
{
    public class CategorySpImp:ICategoryDao
    {
        SpImp<List<Model.Category>> spImp = new SpImp<List<Model.Category>>();
        public List<Model.Category> GetCategories()
        {
            SqlParameter[] parameters = { };

            return spImp.Read(
                "dbo.GetCategories",
                parameters,
                new CategoryAdapter().ToList
                );
        }

        public Model.Category GetCategoryById(int catId)
        {
            SqlParameter[] parameters = { new SqlParameter("@CategoryId", catId) };

            return spImp.Read(
                "dbo.GetCategoryById",
                parameters,
                new CategoryAdapter().ToList
                ).First();
        }

        public int EditCategory(Model.Category category, string userId)
        {

            SqlParameter[] parameters = 
            {                                            
                new SqlParameter("@CategoryId", category.CategoryId),         
                new SqlParameter("@CategoryName", category.CategoryName) 
            };

            return spImp.Write("dbo.EditCategory", parameters);

        }

        public int DeleteCategory(int catId, string userId)
        {
            SqlParameter[] parameters = 
            {                                            
               new SqlParameter("@CategoryId", catId)
            };

            return spImp.Write("dbo.DeleteCategory", parameters);

        }

        public int InsertCategory(Model.Category category)
        {

            SqlParameter[] parameters = 
            {                                            
               new SqlParameter("@CategoryName", category.CategoryName)
            };

            return spImp.Write("dbo.InsertCategory", parameters);

        }
    }
}