using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using WebApplication2.Model;
using WebApplication2.BusinessLogic;

namespace WebApplication2.Pages.Admin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        bool active;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["active"] != null)
            {

                active = bool.Parse(Request.QueryString["active"]);
            }
        }
        public List<Post> GetPosts()
        {
            PostsLogic postsLogic = new PostsLogic();

            return postsLogic.GetPostsByActivationState(active);
        }
        protected string CalculateTime(DateTime now)
        {
            return Utilities.Utils.CalculateTime(now);
        }
    }
}