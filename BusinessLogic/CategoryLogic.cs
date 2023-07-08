using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Repository;
using WebApplication2.Model;
using WebApplication2.Repository.StoredProducers;

namespace WebApplication2.BusinessLogic
{
    public class CategoryLogic
    {
        ICategoryDao categoryDao = new CategorySpImp();
        internal List<Category> GetAll()
        {
           return categoryDao.GetCategories();
        }

        internal void Edit(Category category, System.Security.Principal.IIdentity user)
        {
            categoryDao.EditCategory(category, Utilities.Utils.GetUserId(user));
        }

        internal void Insert(Category category)
        {
            categoryDao.InsertCategory(category);
        }

        internal void Delete(int catId, System.Security.Principal.IIdentity user)
        {
            categoryDao.DeleteCategory(catId, Utilities.Utils.GetUserId(user));
        }

        internal Category GetById(int catId)
        {
            return categoryDao.GetCategoryById(catId);
        }

    }
}