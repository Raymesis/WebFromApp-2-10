using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.DatabaseModel;
using System.Data.SqlClient;
using System.Data;
using WebApplication2.Model;
using WebApplication2.Adapter;

namespace WebApplication2.Repository.StoredProducers
{
    public class PostSpImp:IPostDao
    {
        SpImp<List<Model.Post>> spImp = new SpImp<List<Model.Post>>();

        public List<Post> GetPosts()
        {

            SqlParameter[] parameters = { };

            return spImp.Read(
                "dbo.GetPosts",
                parameters,
                new PostAdapter().ToList
                );
        }


        public List<Post> GetPostsByActivationState(bool activeState)
        {

            SqlParameter[] parameters = { new SqlParameter("@ActiveState",activeState)};

            return spImp.Read(
                "dbo.GetPostsByActivationState",
                parameters,
                new PostAdapter().ToList
                );

        }


        public List<Post> GetPostByUserId(string userId)
        {

            SqlParameter[] parameters = 
            {
                new SqlParameter("@UserId", userId)
            };

            return spImp.Read(
                "dbo.GetPostByUserId",
                parameters,
                new PostAdapter().ToList
                );

        }

        public List<Post> GetPostByCategory(int categoryId)
        {

            SqlParameter[] parameters = 
            {
                new SqlParameter("@CategoryId", categoryId)
            };

            return spImp.Read(
                "dbo.GetPostByCategoryId",
                parameters,
                new PostAdapter().ToList
                );
        }

        public Post GetPostById(int id)
        {
            SqlParameter[] parameters = 
            {
                new SqlParameter("@PostId", id)
            };

            return spImp.Read(
                "dbo.GetPostById",
                parameters,
                new PostAdapter().ToList
                ).First();
        }

        public List<Post> SearchPosts(string searchString)
        {

            SqlParameter[] parameters = 
            {
                new SqlParameter("@SearchTxt", searchString)
            };

            return spImp.Read(
                "dbo.SearchPosts",
                parameters,
                new PostAdapter().ToList
                );
        }

        public int DeletePost(int id, string userId)
        {

            SqlParameter[] parameters = 
            {                                            
              new SqlParameter("@PostId", id)
            };

            return spImp.Write("dbo.DeletePost", parameters);
        }

        public int InsertPost(Post post)
        {      

            SqlParameter[] parameters = 
            {                                            
              new SqlParameter("@Title", post.Title),
              new SqlParameter("@StateId", post.StateId),
              new SqlParameter("@Price", post.Price),
              new SqlParameter("@PhoneNumber", post.PhoneNumber),
              new SqlParameter("@CategoryId", post.CategoryId),
              new SqlParameter("@Created_Date", post.Created_Date),
              new SqlParameter("@Description", post.Description),
              new SqlParameter("@Image", post.Image),
              new SqlParameter("@Is_Active", post.Is_Active),
              new SqlParameter("@CreatedById", post.CreatedById)
            };

            return spImp.Write("dbo.InsertPost", parameters);


        }

        public int EditPost(Post post, string userId)
        {


            SqlParameter[] parameters = 
            {   
              new SqlParameter("@Postid", post.PostId),                         
              new SqlParameter("@Title", post.Title),
              new SqlParameter("@StateId", post.StateId),
              new SqlParameter("@Price", post.Price),
              new SqlParameter("@PhoneNumber", post.PhoneNumber),
              new SqlParameter("@CategoryId", post.CategoryId),
              new SqlParameter("@ModifiedByUserId", userId),
              new SqlParameter("@Description", post.Description),
              new SqlParameter("@Image", post.Image),
              new SqlParameter("@Is_Active", post.Is_Active),
              new SqlParameter("@Modified_Date", post.Modified_Date),
            };

            return spImp.Write("dbo.EditPost", parameters);

        }
    }
}

