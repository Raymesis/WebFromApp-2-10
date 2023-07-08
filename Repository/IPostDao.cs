using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication2.Model;

namespace WebApplication2.Repository
{
    interface IPostDao
    {
        List<Post> GetPosts();
        List<Post> GetPostsByActivationState(bool activeState);
        List<Post> GetPostByUserId(string userId);
        List<Post> GetPostByCategory(int selectedCategory);
        Post GetPostById(int id);
        List<Post> SearchPosts(string searchString);
        int DeletePost(int id, string userId);
        int InsertPost(Post post);
        int EditPost(Post post, string userId);
    }
}
