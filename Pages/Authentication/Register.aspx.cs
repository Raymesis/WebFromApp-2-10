using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.BusinessLogic;
using WebApplication2.Model;

namespace WebApplication2.Pages.Authentication
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    Response.Redirect("/Pages/Authentication/Login.aspx");
                }
            }

        }
        protected void CreateUser(object sender, EventArgs e)
        {
            if (Page.IsValid) {
            bool _user = new UserLogic().SignUp(
                new ApplicationUser() { 
                    UserName=txtboxUserName.Text,
                    FullName=txtboxFamilyName.Text,
                    PhoneNumber = txtboxPhoneNumber.Text,
                    Email = txtboxEmail.Text
                }, txtboxPassword.Text);

            if (_user)
                Response.Redirect("/");
            }

        }
    }
}
