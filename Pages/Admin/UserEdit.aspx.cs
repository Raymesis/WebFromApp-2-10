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
    public partial class UserEdit : System.Web.UI.Page
    {
        UserLogic userLogic = new UserLogic();
        ApplicationUser user;

        protected void Page_Load(object sender, EventArgs e)
        {
            string userId;
            if (Request.QueryString["user"] != null)
            {

                userId = Request.QueryString["user"];
                user = userLogic.GetUserById(userId);

            }
            if (!IsPostBack && user != null)
            {
                txtboxFamilyName.Text = user.FullName;
                txtboxUserName.Text = user.UserName;
                txtboxEmail.Text = user.Email;
                txtboxPhNumber.Text = user.PhoneNumber;

                deactiveUserBtn.Visible = !user.LockoutEnabled;
                activeUserBtn.Visible = user.LockoutEnabled;
            }
        }
        protected void DeleteUser(object sender, EventArgs e)
        {
            userLogic.DeleteUser(user.Id);
            Response.Redirect("/");
        }
        protected void ChangePass(object sender, EventArgs e)
        {
            userLogic.ResetPass(
                user.Id,
                txtboxNewPass1.Text,
                txtboxNewPass2.Text);
           
        }
        protected void DeactiveUser(object sender, EventArgs e)
        {
            userLogic.UserActivation(
                user.Id,true);
        }
        protected void ActiveUser(object sender, EventArgs e)
        {
            userLogic.UserActivation(
                user.Id,false);
        }
        protected void SaveChanges(object sender, EventArgs e)
        {
            bool Succeeded = userLogic.UpdateProfile(new ApplicationUser()
            {

                UserName = txtboxUserName.Text,
                FullName = txtboxFamilyName.Text,
                PhoneNumber = txtboxPhNumber.Text,
                Email = txtboxEmail.Text
            }, user.Id);
            if (Succeeded)
            {
                //Response.Write("doneeeeeeeeeeeeeeeeee");
            }
        }
    }
}