using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using WebApplication2.Model;
using System.Data.SqlClient;
using System.Data.Entity;

namespace WebApplication2.DatabaseModel
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
       
         
        private ApplicationDbContext()
            : base("DefaultConnection")
        {
            
        }
        //public DbSet<Post> Posts { get; set; }
        //public DbSet<Category> Categories { get; set; }
        //public DbSet<State> States { get; set; }
        //public DbSet<CategoryAttributes> CatAttributes { get; set; }
        //public DbSet<PostAttributes> PostAttributes { get; set; }
        private static readonly Lazy<ApplicationDbContext> lazy = new Lazy<ApplicationDbContext>(() => new ApplicationDbContext());
        public static ApplicationDbContext Instance
        {
            get
            {
                return lazy.Value;
            }
        }


    }
}