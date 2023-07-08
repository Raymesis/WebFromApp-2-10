using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.Model;
using WebApplication2.BusinessLogic;

namespace WebApplication2.Pages.Admin
{
    public partial class StateEdit : System.Web.UI.Page
    {
        AttrListLogic attrListLogic = new AttrListLogic();
        int attrId;
        List<AttrList> attrList;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Request.QueryString["attrId"] != null)
            {
                
                attrId = Int32.Parse(Request.QueryString["attrId"]);          
                attrList = attrListLogic.GetByCatId(attrId).ToList();
            }


        }
        public List<AttrList> GetAttributeValues()
        {
            
            return attrList;
        }
        protected void InsertValue(object sender, EventArgs e)
        {
            attrListLogic.Insert(
                new AttrList
                {
                    Attrid=attrId,
                    Value = txtboxNewValue.Text
                });
            
        }

        protected void listviewCategoryAttr_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            ListViewItem item = e.Item;

            ListViewDataItem dataItem = (ListViewDataItem)e.Item;
            string employeeID =
              listviewCategoryAttr.DataKeys[dataItem.DisplayIndex].Value.ToString();

            AttrList attr = attrList[dataItem.DisplayIndex];
            TextBox txtBox = (TextBox)item.FindControl("txtboxValueName");
            if (e.CommandName == "SaveAttr")
            {
                attrListLogic.Edit(new AttrList
                {
                    Attrid = attr.Attrid,
                    Id = attr.Id,
                    Value = txtBox.Text
                });
            }
            if (e.CommandName == "DeleteAttr")
            {
                attrListLogic.Delete(attr.Id);
            }
        }
    }
}