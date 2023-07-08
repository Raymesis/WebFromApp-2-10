using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.BusinessLogic;
using WebApplication2.Model;

namespace WebApplication2.Pages.Admin
{
    public partial class States : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public List<State> GetStates()
        {
            StatesLogic statesLogic = new StatesLogic();

            return statesLogic.GetAll();
        }
    }
}