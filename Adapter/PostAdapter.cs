using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Model;
using WebApplication2.BusinessLogic;
namespace WebApplication2.Adapter
{
    public class PostAdapter : DataAdapter<Post>
    {
        protected override Post ReadSingleRow()
        {
            Post post = new Post
            {
                PostId = Int32.Parse(data["PostId"].ToString()),

                Description = data["Description"].ToString(),
                Title = data["Title"].ToString(),
                Image = data["Image"].ToString(),
                PhoneNumber = data["PhoneNumber"].ToString(),
                Price = data["Price"].ToString(),
                CreatedById = data["CreatedById"].ToString(),
                Created_Date = DateTime.Parse(data["Created_Date"].ToString()),
                Is_Active = Boolean.Parse(data["Is_Active"].ToString()),
                CategoryId = Int32.Parse(data["CategoryId"].ToString()),
                StateId = Int32.Parse(data["StateId"].ToString()),

                Category = new Category
                {
                    CategoryName = data["CategoryName"].ToString(),
                    CategoryId = Int32.Parse(data["CategoryId"].ToString())
                },

                State = new State
                {
                    StateName = data["StateName"].ToString(),
                    StateId = Int32.Parse(data["StateId"].ToString())

                },
                
            };
            
            return post;
        }
    }
}