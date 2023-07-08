using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Adapter
{
    public class PostAttributeAdapter : DataAdapter<Model.PostAttributes>
    {
        protected override Model.PostAttributes ReadSingleRow()
        {
            return new Model.PostAttributes
            {
                PostAttrId = Int32.Parse(data["PostAttrId"].ToString()),
                AttrId = Int32.Parse(data["AttrId"].ToString()),
                AttrValue = data["AttrValue"].ToString(),
                PostId =  Int32.Parse(data["PostId"].ToString()),
                AttrName = data["AttrName"].ToString()
            };

        }
    }
}