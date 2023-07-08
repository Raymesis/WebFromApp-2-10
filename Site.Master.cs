using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Routing;
using WebApplication2.BusinessLogic;
using WebApplication2.Model;
using WebApplication2.Authentication.Roles;

namespace WebApplication2
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             
            if (!IsPostBack)
            {
                if (HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    RegisterLink.Visible = false;
                    LoginLink.Visible = false;
                    ProfileLink.Visible = true;
                    NewPost.Visible = true;
                    UserPosts.Visible = true;
                }
                if(RoleActions.IsAdmin(Utilities.Utils.GetUserId(HttpContext.Current.User.Identity))){
                    Admin.Visible=true;
                }
            }
            else
            {
                if (search.Text != "")
                {
                    Response.Redirect("/Default.aspx?search="+search.Text);
                }
            }
        }
        public List<Category> GetCategories()
        {
            CategoryLogic categoryLogic = new CategoryLogic();
            return categoryLogic.GetAll();
        }
    }
}