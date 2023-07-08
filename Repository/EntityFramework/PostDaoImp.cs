using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Model;
using WebApplication2.DatabaseModel;
using System.Data.Entity;
using WebApplication2.Authentication.Roles;

namespace WebApplication2.Repository
{
    //متد های مربوط به عملیات های مورد نیاز در دیتابس
    public class PostDaoImp : IPostDao
    {

        ApplicationDbContext Db = ApplicationDbContext.Instance;

        public void EditPost(Post post, string userId)
        {
            try
            {
                if (post.CreatedBy.Id == userId || RoleActions.IsAdmin(userId))
                {
                    Post item = Db.Posts.Find(post.PostId);

                    item.Title = post.Title;
                    item.Price = post.Price;
                    item.Description = post.Description;
                    item.StateId = post.StateId;
                    item.PhoneNumber = post.PhoneNumber;
                    item.CategoryId = post.CategoryId;

                    Db.SaveChangesAsync();

                }
            }
            catch (Exception e)
            {

            }

        }

        public void InsertPost(Post post)
        {
            Db.Posts.Add(post);
            try
            {
                Db.SaveChangesAsync();

            }
            catch (Exception e)
            {

            }

        }

        public void DeletePost(int id, string userId)
        {
            try
            {
                Post post = Db.Posts.Find(id);
                if (post.CreatedBy.Id == userId || RoleActions.IsAdmin(userId))
                {
                    Db.Posts.Remove(post);
                    Db.SaveChangesAsync();


                }

            }
            catch (Exception e)
            {

            }

        }

        public IQueryable<Post> SearchPosts(string searchString)
        {

            IQueryable<Post> _posts = GetPosts()
                    .Where(s => s.Title.Contains(searchString));
            return _posts;

        }

        public Post GetPostById(int id)
        {

            Post _post = Db.Posts
                       .Where(b => b.PostId == id)
                       .Include(b => b.Category)
                       .Include(b => b.State)
                       .FirstOrDefault();

            return _post;

        }

        public IQueryable<Post> GetPosts()
        {
            IQueryable<Post> _posts = Db.Posts
                        .Include(b => b.Category)
                        .Include(d => d.State);

            return _posts;

        }

        public IQueryable<Post> GetPostByCategory(int selectedCategory)
        {
            return GetPosts().Where(b => b.Category.CategoryId == selectedCategory);
        }

        public IQueryable<Post> GetPostByUserId(string userId)
        {
            return GetPosts().Where(b => b.CreatedById == userId);
        }

        public IQueryable<Post> GetNonActivePosts()
        {
            return GetPosts().Where(b => b.Is_Active == false);
        }
    }


}

