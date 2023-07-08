using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Model
{
    public class CategoryAttributes
    {
        public int AttrId { get; set; }
        public int CategoryId { get; set; }
        public String AttrName { get; set; }
        public int Type { get; set; }
        public List<AttrList> Values { get; set; }
    }
}