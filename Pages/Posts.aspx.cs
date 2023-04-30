using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.Model;
using WebApplication1.Repository;
namespace WebApplication2.Pages
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public List<PostModel> getPosts()
        {
            List<PostModel> posts = new PostDaoImp().getPosts();

            return posts;
        }
    }
}