using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin.Security;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using WebApplication2.Model;
using WebApplication2.DatabaseModel;
using WebApplication2.Repository;

namespace WebApplication2.BusinessLogic
{
    public class UserLogic
    {
        UserDao userDao = new UserDao();
        UserStore<ApplicationUser> userStore;
        UserManager<ApplicationUser> userManager;
        public UserLogic()
        {
            userStore = new UserStore<ApplicationUser>(ApplicationDbContext.Instance);
            userManager = new UserManager<ApplicationUser>(userStore);
        }
         public bool SignIn(string username,string password)
        {         
            var user = userManager.Find(username, password);

            if (user != null)
            {
                if (!user.LockoutEnabled)
                {
                    var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                    var userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);

                    authenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = false }, userIdentity);
                    return true;
                }
                else
                    return false;
            }
            else
            {
                return false;
            }
        }
         public bool SignUp(ApplicationUser _user, string password)
         {
             var userStore = new UserStore<ApplicationUser>(ApplicationDbContext.Instance);
             var userManager = new UserManager<ApplicationUser>(userStore);
             
             var user = new ApplicationUser()
             {
                 UserName = _user.UserName,
                 PhoneNumber = _user.PhoneNumber,
                 FullName = _user.FullName,
                 Email = _user.Email
                 
             };

             IdentityResult result = userManager.Create(user, password);

             if (result.Succeeded)
             {
                 var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                 var userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                 authenticationManager.SignIn(new AuthenticationProperties() { }, userIdentity);
                 return true;
             }
             else
             {
                 return false;
             }
         }
         internal void SignOut(IAuthenticationManager authenticationManager)
         {
            authenticationManager.SignOut();
         }
         internal bool ChangePass(string userId, string oldPass, string newPass2, string newPass1)
         {
             if (newPass1 == newPass2)
             {
                 return userManager.ChangePassword(userId, oldPass, newPass1).Succeeded;
             }
             else
             {               
                 return false;
             }
         }
         internal bool ResetPass(string userId, string newPass2, string newPass1)
         {
             if (newPass1 == newPass2)
             {
                 userManager.RemovePassword(userId);
                 userManager.AddPassword(userId, newPass1);
                 return true;
             }
             else
             {
                 return false;
             }
         }
         internal bool DeleteUser(string userId)
         {
             ApplicationUser user = userManager.FindById(userId);

            return userManager.DeleteAsync(user).Result.Succeeded;

         }
         internal bool UpdateProfile(ApplicationUser _user,string userId)
         {
             ApplicationUser user = userManager.FindById(userId);

             if (user.UserName != _user.UserName)
                 user.UserName = _user.UserName;

             if (user.FullName != _user.FullName)
                 user.FullName = _user.FullName;

             if (user.Email != _user.Email)
                 user.Email = _user.Email;

             if (user.PhoneNumber != _user.PhoneNumber)
                 user.PhoneNumber = _user.PhoneNumber;

             return userManager.Update(user).Succeeded;
         }

         internal ApplicationUser GetUserById(string userId)
         {
            return userDao.GetUserById(userId);
         }

         internal List<ApplicationUser> GetUsers()
         {
             return userDao.GetUsers();
         }

         internal void UserActivation(string userId,bool state)
         {
             ApplicationUser user = userManager.FindById(userId);
             user.LockoutEnabled = state;
             userManager.Update(user);
         }
    }
}