using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Adapter
{
    public class StateAdapter:DataAdapter<Model.State>
    {

        protected override Model.State ReadSingleRow()
        {
            
            return new Model.State
               {
                   StateName = data["StateName"].ToString(),
                   StateId = Int32.Parse(data["StateId"].ToString())
               };
        }
    }

}