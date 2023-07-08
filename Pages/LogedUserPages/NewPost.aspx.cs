using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.BusinessLogic;
using WebApplication2.Model;


namespace WebApplication2.Pages
{

    public partial class NewPost : System.Web.UI.Page
    {
        int catId;

        List<CategoryAttributes> catAttrs;
        List<AttrList> catAttrsValues;
        
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.QueryString["catId"] != null)
            {
                catId = Int32.Parse(Request.QueryString["catId"]);
               
                catAttrs = new CategoryAttributeLogic().GetByCategoryId(catId);
                PlaceHolder2.Visible = false;
                PlaceHolder1.Visible = true;
            }
            else
            {
                PlaceHolder2.Visible = true;
                PlaceHolder1.Visible = false;
            }
        }

        protected void NewPosts(object sender, EventArgs e)
        {

            if (Page.IsValid)
            {
                int postId = new PostsLogic().Insert(new Post
                {
                    Title = txtboxTitle.Text,
                    Price = txtboxPrice.Text,
                    Description = txtboxDesc.Text,
                    Created_Date = System.DateTime.Now,
                    Is_Active = false,
                    PhoneNumber = txtboxPhNumber.Text,
                    StateId = 2,
                    CategoryId = Convert.ToInt32(catId),
                    Image = Utilities.Utils.SaveImage(ProductImage, Server.MapPath("/images/")),
                    CreatedById = Utilities.Utils.GetUserId(User.Identity),

                });

                foreach (PostAttributes postAttr in GetSelectedAttributesFromListView(postId))
                {
                    new PostAttributeLogic().Insert(postAttr);

                }            
          
                // Response.Redirect("/");
            }
        }
        public List<CategoryAttributes> GetAttributes()
        {
             
            return catAttrs;

        }
        public List<AttrList> GetAttributesValues(int id)
        {
            catAttrsValues = new AttrListLogic().GetByCatId(id);
            return catAttrsValues;
        }
        public List<Category> GetCategories()
        {
            return new CategoryLogic().GetAll();
        }
        protected List<PostAttributes> GetSelectedAttributesFromListView(int postId)
        {
            List<PostAttributes> list = new List<PostAttributes>();
            foreach (ListViewDataItem lV in AttributesList.Items)
            {
                CategoryAttributes catAttr=catAttrs[lV.DataItemIndex];
                if (catAttr.Type == 1)
                {
                    DropDownList drpdwn = (DropDownList)lV.FindControl("DropDownAttrList");
                    list.Add(new PostAttributes
                    {
                        AttrValue = drpdwn.SelectedItem.Text,
                        PostId = postId,
                        AttrId = catAttr.AttrId
                    });
                }
                else if (catAttr.Type == 2)
                {
                    TextBox txtbox=(TextBox)lV.FindControl("txtboxAttrValue");
                    list.Add(new PostAttributes
                    {
                        AttrValue = txtbox.Text,
                        PostId = postId,
                        AttrId = catAttr.AttrId
                    });
                }
                
            }
            return list;
        }
    }

}
