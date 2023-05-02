using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Repository;
using WebApplication2.Model;
namespace WebApplication2.Pages
{
    public partial class PostDetails : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public PostModel getPost([QueryString("id")] int id)
        {
            PostModel post = new PostDaoImp().getPosts()[id];

            return post;

        }
    }
}