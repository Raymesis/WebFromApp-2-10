using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
namespace WebApplication2.Routing
{
    public class Routes
    {
        public void RegisterCustomRoutes(RouteCollection routes)
        {
            routes.MapPageRoute(
                "HomeRoute",
                "Index/{catId}",
                "~/Default.aspx"
            );

            routes.MapPageRoute(
                "PostDetails",
                "Posts/{postId}",
                "~/Pages/PostDetails.aspx"
            );
            routes.RouteExistingFiles = true;
        }
    }
}