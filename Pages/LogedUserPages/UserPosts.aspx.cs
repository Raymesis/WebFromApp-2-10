using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.BusinessLogic;
using WebApplication2.Model;

namespace WebApplication2.Pages.LogedUserPages
{
    public partial class UserPosts : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
               
        }

        public List<Post> GetUserPosts()
        {
            List<Post> posts = new PostsLogic().GetByUserId(User.Identity);
            no_post_view.Visible = posts.Count() < 0;

            return posts;
        }
        protected string CalculateTime(DateTime now)
        {
            return Utilities.Utils.CalculateTime(now);
        }
    }
}