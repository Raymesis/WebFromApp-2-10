using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.ModelBinding;
using System.Web.UI.WebControls;
using WebApplication2.Model;
using WebApplication2.BusinessLogic;
using WebApplication2.Repository.StoredProducers;
using System.Web.Routing;

namespace WebApplication2.Pages
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int selectedCategory = 0;
        string search = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["cat"] != null)
            {               
                selectedCategory = Int32.Parse(Request.QueryString["cat"]);
            }
            else if (Request.QueryString["search"] != null)
            {
                search = Request.QueryString["search"];
            }
        }
        public List<Post> GetPosts()
        {

            
            PostsLogic postsLogic = new PostsLogic();

            if (selectedCategory != 0)
                return postsLogic.GetByCategoryId(selectedCategory);
            else if (search != "")
               return postsLogic.SearchPosts(search);
            else
                return postsLogic.GetPostsByActivationState(true);

        }
        protected string CalculateTime(DateTime now)
        {
            return Utilities.Utils.CalculateTime(now);
        }
    }
}