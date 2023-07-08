using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.DatabaseModel;
using WebApplication2.Model;
using System.Data.Entity;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication2.Repository
{
    public class UserDao
    {
        IDbSet<ApplicationUser> users = ApplicationDbContext.Instance.Users;

        public ApplicationUser GetUserById(string id)
        { 
            return users.Find(id);
        }
        public IQueryable<ApplicationUser> GetUsers()
        {
            return users;
        }

    }
}