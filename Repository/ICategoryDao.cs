using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Model;

namespace WebApplication2.Repository
{
    interface ICategoryDao
    {
         List<Category> GetCategories();

         Category GetCategoryById(int catId);

         int EditCategory(Category category, string userId);

         int DeleteCategory(int catId, string userId);

         int InsertCategory(Category cat);
    }
}