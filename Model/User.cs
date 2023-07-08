using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity.EntityFramework;  
 
namespace WebApplication2.Model
{
    public class ApplicationUser : IdentityUser
    {
        [MaxLength(20)]
        public string FullName { get; set; }


    }
}