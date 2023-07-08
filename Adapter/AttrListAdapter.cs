using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Adapter
{
    public class AttrListAdapter :DataAdapter<Model.AttrList>
    {
        protected override Model.AttrList ReadSingleRow()
        {
            return new Model.AttrList
            {
                Attrid = Int32.Parse(data["Attrid"].ToString()),
                Id = Int32.Parse(data["Id"].ToString()),
                Value = data["val"].ToString()
            };
        }
    }
}