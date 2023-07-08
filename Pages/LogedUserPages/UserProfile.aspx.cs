using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.Model;
using WebApplication2.Repository;
using WebApplication2.BusinessLogic;

namespace WebApplication2.Pages.LogedUserPages
{
    public partial class UserProfile : System.Web.UI.Page
    {
        UserDao userdao = new UserDao();
        UserLogic userLogic = new UserLogic();
        ApplicationUser user;
        protected void Page_Load(object sender, EventArgs e)
        {
            user = userdao.GetUserById(Utilities.Utils.GetUserId(User.Identity));
            if (!IsPostBack)
            {
                txtboxFamilyName.Text = user.FullName;
                txtboxUserName.Text = user.UserName;
                txtboxEmail.Text = user.Email;
                txtboxPhNumber.Text = user.PhoneNumber;
            }
            

        }
        protected void SignOut(object sender, EventArgs e)
        {
            userLogic.SignOut(HttpContext.Current.GetOwinContext().Authentication);
            Response.Redirect("/");
        }
        protected void ChangePass(object sender, EventArgs e)
        {
            if (Page.IsValid) { 
                userLogic.ChangePass(
                    user.Id,
                    txtboxOldPass.Text,
                    txtboxNewPass1.Text,
                    txtboxNewPass2.Text);
            }
        }
        protected void SaveChanges(object sender, EventArgs e)
        {
            if (Page.IsValid) { 
                bool Succeeded = userLogic.UpdateProfile( new ApplicationUser() {

                    UserName = txtboxUserName.Text,
                    FullName = txtboxFamilyName.Text,
                    PhoneNumber = txtboxPhNumber.Text,
                    Email = txtboxEmail.Text
                }, user.Id);
                if (Succeeded)
                {
                    Response.Write("تغییرات با موفقیت ذخیره شد");
                }
            }
        }


    }
}