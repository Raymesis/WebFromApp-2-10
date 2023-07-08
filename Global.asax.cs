using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using WebApplication2.Authentication.Roles;
using System.Data.Entity;
using WebApplication2.Model;
using WebApplication2.DatabaseModel;
using WebApplication2.Routing;

namespace WebApplication2
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Database.SetInitializer(new DatabaseInitializer());

            //Routes routing = new Routes();
            //routing.RegisterCustomRoutes(RouteTable.Routes);

            RoleActions roleActions = new RoleActions();
            roleActions.AddUserAndRole();

           
        }
    }
}