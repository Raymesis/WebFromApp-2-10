using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Model;
using WebApplication2.Repository;
using WebApplication2.Repository.StoredProducers;

namespace WebApplication2.BusinessLogic
{
    public class PostsLogic
    {
        //IPostDao postDao = new PostDaoImp();
        IPostDao postDao = new PostSpImp();

        public Post GetById(int postId)
        {  
                return postDao.GetPostById(postId);
        }

        public List<Post> GetByUserId(System.Security.Principal.IIdentity user)
        {           
            string userId = Utilities.Utils.GetUserId(user);
            List<Post> posts = postDao.GetPostByUserId(userId);
         
            return posts;
        }

        internal int Insert(Post post)
        {
            return postDao.InsertPost(post);
        }

        internal void Edit(Post post, System.Security.Principal.IIdentity user)
        {

            post.Modified_Date = System.DateTime.Now;
            postDao.EditPost(post, Utilities.Utils.GetUserId(user));
        }

        internal void Delete(int id, System.Security.Principal.IIdentity user)
        {
            postDao.DeletePost(id, Utilities.Utils.GetUserId(user));
        }

        internal List<Post> GetPostsByActivationState(bool activeState)
        {
            return postDao.GetPostsByActivationState(activeState);
        }

        internal List<Post> GetByCategoryId(int selectedCategory)
        {
            return postDao.GetPostByCategory(selectedCategory);
        }

        internal List<Post> SearchPosts(string search)
        {
            return postDao.SearchPosts(search);
        }

        internal List<Post> GetAll()
        {
            return postDao.GetPosts();
        }
    }
}