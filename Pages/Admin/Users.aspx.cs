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
    public partial class Users: System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public List<ApplicationUser> getUsers()
        {
            return new UserLogic().GetUsers();
        }

    }
}