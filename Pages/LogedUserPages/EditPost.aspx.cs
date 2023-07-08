using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.Model;
using WebApplication2.BusinessLogic;
using WebApplication2.Authentication.Roles;
using System.Collections;

namespace WebApplication2.Pages.LogedUserPages
{
    public partial class EditPost : System.Web.UI.Page
    {
        Post post;
        PostsLogic postLogic = new PostsLogic();

        List<CategoryAttributes> catAttrs;
        List<AttrList> catAttrsValues;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            post = postLogic.GetById(Int32.Parse(Request.QueryString["postId"]));
            string userId = Utilities.Utils.GetUserId(User.Identity);
            if (post != null)
            {
                catAttrs = new CategoryAttributeLogic().GetByCategoryId(post.CategoryId.Value);
                btnActivation.Text = post.Is_Active ? "غیر فعال سازی" : "فعال سازی";
            }
            if (post.CreatedById != userId && !RoleActions.IsAdmin(userId))
            {
                Response.Redirect("/");               
            
            }

            btnActivation.Visible = RoleActions.IsAdmin(userId);

            if (!IsPostBack)
            {
                
                txtboxTitle.Text = post.Title;
                txtboxPrice.Text = post.Price;
                txtboxDesc.Text = post.Description;
                txtboxPhNumber.Text = post.PhoneNumber;
                

            }
            
        }

        protected void EditPosts(object sender, EventArgs e)
        {
            postLogic.Edit(new Post
            {
                PostId = post.PostId,
                Title = txtboxTitle.Text,
                Price = txtboxPrice.Text,
                Description = txtboxDesc.Text,     
                Is_Active = false,
                PhoneNumber = txtboxPhNumber.Text,
                Image = Utilities.Utils.SaveImage(ProductImage, Server.MapPath("/images/")),             
            },User.Identity);
            foreach (PostAttributes postAttr in GetSelectedAttributesFromListView(post.PostId))
            {
                new PostAttributeLogic().Edit(postAttr);

            }
            Response.Redirect(Request.RawUrl);
        }
        protected void DeletePosts(object sender, EventArgs e)
        {
           
            postLogic.Delete(post.PostId, User.Identity);

            Response.Redirect("/", true); 
        }
        public IList GetCategories()
        {
            return new CategoryLogic().GetAll();

        }
        public IList GetStates()
        {
            return new StatesLogic().GetAll();

        }
        public List<CategoryAttributes> GetAttributes()
        {

            return catAttrs;

        }
        protected void PostActivation(object sender, EventArgs e)
        {
            postLogic.Edit(new Post
            {
                PostId = post.PostId,
                Is_Active = !post.Is_Active
            }, User.Identity);
            Response.Redirect(Request.RawUrl);
        }
        public List<AttrList> GetAttributesValues(int id)
        {
            catAttrsValues = new AttrListLogic().GetByCatId(id);
            return catAttrsValues;
        }
        protected List<PostAttributes> GetSelectedAttributesFromListView(int postId)
        {
            List<PostAttributes> list = new List<PostAttributes>();
            foreach (ListViewDataItem lV in AttributesList.Items)
            {
                CategoryAttributes catAttr = catAttrs[lV.DataItemIndex];
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
                    TextBox txtbox = (TextBox)lV.FindControl("txtboxAttrValue");
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