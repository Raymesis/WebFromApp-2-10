using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.BusinessLogic;


namespace WebApplication2.Pages.Authentication
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (User.Identity.IsAuthenticated)
                {

                    Response.Redirect("/");
                }
                else
                {
                    LoginForm.Visible = true;
                }
            }
        }
        protected void SignIn(object sender, EventArgs e)
        {
            if (Page.IsValid) { 

                bool is_Signed = new UserLogic().SignIn(txtboxUserName.Text, txtboxPassword.Text);

                if (is_Signed)
                    Response.Redirect("/");
                else
                    Response.Write("حساب کاربری وجود ندارد یا غیر فعال شده است");
            }
        }


    }

}
