using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Model;
using WebApplication2.DatabaseModel;
using WebApplication2.Authentication.Roles;
using System.Data.Entity;
using System.Threading.Tasks;

namespace WebApplication2.Repository
{
    public class CategoryDaoImp:ICategoryDao
    {
        ApplicationDbContext Db = ApplicationDbContext.Instance;
        public  IQueryable<Category> GetCategories()
        {

            return Db.Categories;

        }

        public async void DeleteCategory(int catId, string userId)
        {
            Category cat = await Db.Categories.FindAsync(catId);
            Db.Categories.Remove(cat);

            await Db.SaveChangesAsync();
        }

        public async void EditCategory(Category category, string userId)
        {
            
            try
            {
                if ( RoleActions.IsAdmin(userId))
                {
                    Category item = Db.Categories.Find(category.CategoryId);

                    item.CategoryName = category.CategoryName;


                    await Db.SaveChangesAsync();
                    
                }
            }
            catch (Exception e)
            {
                
            }

        }

        public Category GetCategoryById(int catId)
        {
            return Db.Categories.Find(catId);
        }

        public async void InsertCategory(Category cat)
        {
            Db.Categories.Add(cat);
            await Db.SaveChangesAsync();
        }
    }
}