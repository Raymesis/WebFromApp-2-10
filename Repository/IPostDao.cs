using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication2.Model;

namespace WebApplication1.Repository
{
    interface IPostDao
    {
        List<PostModel> getPosts();
        void addPost(PostModel post);
    }
}
