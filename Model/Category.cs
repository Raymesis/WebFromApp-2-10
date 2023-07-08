using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Model
{
    public class Category
    {

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public virtual IQueryable<CategoryAttributes> Attributes { get; set; }

    }
}