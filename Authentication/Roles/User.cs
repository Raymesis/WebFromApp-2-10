using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using WebApplication2.DatabaseModel;
using WebApplication2.Model;

namespace WebApplication2.Authentication.Roles
{
    internal class RoleActions
    {
        ApplicationDbContext context = ApplicationDbContext.Instance;

        UserManager<ApplicationUser> userMgr;
        RoleStore<IdentityRole> roleStore;
        RoleManager<IdentityRole> roleMgr;


        public RoleActions()
        {
            userMgr = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            roleStore = new RoleStore<IdentityRole>(context);
            roleMgr = new RoleManager<IdentityRole>(roleStore);

            

        }
        internal void AddUserAndRole()
        {
            IdentityResult IdRoleResult;
            IdentityResult IdUserResult;

            //if (!roleMgr.RoleExists("canEdit"))
            //{
                IdRoleResult = roleMgr.Create(new IdentityRole { Name = "canEdit" });

           // }        

            var appUser = new ApplicationUser
            {
                UserName = "canEdit@something.com",
                Email = "canEdit@something.com"
            };

            IdUserResult = userMgr.Create(appUser, "123456");

            if (!userMgr.IsInRole(userMgr.FindByEmail("canEdit@something.com").Id, "canEdit"))
            {
                IdUserResult = userMgr.AddToRole(userMgr.FindByEmail("canEdit@something.com").Id, "canEdit");
            }

        }
        static internal bool IsAdmin(String userId)
        {
            UserManager<ApplicationUser> userMgr = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(ApplicationDbContext.Instance));
            if (userId != null)
                try
                {
                    return userMgr.IsInRole(userId, "canEdit");
                }
                catch(Exception e)
                {
                    return false;
                }
            else
                return false;
        }

        
    }
}