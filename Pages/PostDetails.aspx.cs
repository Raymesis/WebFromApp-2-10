using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.BusinessLogic;
using WebApplication2.Model;

namespace WebApplication2.Pages
{
    public partial class PostDetails : Page
    {
        Post post;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        public Post GetPost([QueryString("postId")] int? postId)
        {
            post = new PostsLogic().GetById(postId.Value);
            return post;       
        }
        protected string CalculateTime(DateTime now)
        {
            return Utilities.Utils.CalculateTime(now);
        }

        public IEnumerable<WebApplication2.Model.PostAttributes> Repeater1_GetData()
        {
            return new PostAttributeLogic().GetByCategoryId(post.PostId);
        }
    }
}