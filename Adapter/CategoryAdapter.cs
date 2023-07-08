using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Adapter
{
    public class CategoryAdapter : DataAdapter<Model.Category>
    {
        protected override Model.Category ReadSingleRow()
        {

            Model.Category category = new Model.Category
            {
                CategoryName = data["CategoryName"].ToString(),
                CategoryId = Int32.Parse(data["CategoryId"].ToString()),


            };

            if (Utilities.Utils.HasColumn(data, "AttrId"))
            {
                if (data["AttrId"] != DBNull.Value) { 
                    List<Model.CategoryAttributes> list = new List<Model.CategoryAttributes>();
                    do
                    {
                         list.Add(new CategoryAttrAdapter().GetSingleRow(data));
                    }
                    while (data.Read());
                    category.Attributes = list.AsQueryable();
                }
            }

            return category;
        }
    }
}