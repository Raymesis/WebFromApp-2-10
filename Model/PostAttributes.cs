using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Model
{
    public class PostAttributes
    {
        public int PostAttrId { get; set; }
        public int PostId { get; set; }
        public int AttrId { get; set; }
        public string AttrValue { get; set; }
        public string AttrName { get; set; }
    }
}