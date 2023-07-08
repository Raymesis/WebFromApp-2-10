using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication2.Model;
namespace WebApplication2.Repository
{
    interface IPostAttributesDao
    {
        List<PostAttributes> GetPostAttrs();
        PostAttributes GetPostAttrsById(int postAttrId);
        List<PostAttributes> GetPostAttrsByPostId(int postId);
        int EditPostAttr(PostAttributes postAttr);
        int DeletePostAttr(int postAttrId);
        int InsertPostAttr(PostAttributes postAttr);
    }
}
