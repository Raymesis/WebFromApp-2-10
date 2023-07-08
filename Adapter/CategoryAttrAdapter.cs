using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Adapter
{
    public class CategoryAttrAdapter :DataAdapter<Model.CategoryAttributes>
    {
        protected override Model.CategoryAttributes ReadSingleRow()
        {
            return new Model.CategoryAttributes
                {
                    AttrName = data["AttrName"].ToString(),
                    AttrId = Int32.Parse(data["AttrId"].ToString()),
                    Type = Int32.Parse(data["Type"].ToString()),                   
                    CategoryId = Int32.Parse(data["CategoryId"].ToString()),
                    
                };

        }

    }
}