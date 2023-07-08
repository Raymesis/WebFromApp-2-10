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
    public partial class CategoryEdit : System.Web.UI.Page
    {
        Category cat=new Category();
        CategoryLogic categoryLogic = new CategoryLogic();
        CategoryAttributeLogic catAttrLogic = new CategoryAttributeLogic();
        int catId=-1;
        protected void Page_Load(object sender, EventArgs e)
        {
            string action;

            if (Request.QueryString["catId"] != null)
            {

                catId = Int32.Parse(Request.QueryString["catId"]);
                cat = categoryLogic.GetById(catId);

            }

            if ( Request.QueryString["action"]!= null)
            {
                action = Request.QueryString["action"];
                string attrId = Request.QueryString["attrId"] ;

                switch (action){
                    case "delete":
                        catAttrLogic.Delete(Int32.Parse(attrId));
                        Refresh();
                        break;
                    case "edit":
                        Response.Redirect("/");
                        break;
                    default:
                        break;
                }  
            }



            if (catId != -1)
            {


                txtboxCatName.Text = cat.CategoryName;
                categoryId.Text = cat.CategoryId.ToString();
                saveBtn.Visible = false;
            }
            else
            {
                deleteBtn.Visible = false;
                editBtn.Visible = false;
                saveBtn.Visible = true;
            }

        }
        public IQueryable<Model.CategoryAttributes> GetAttributes()
        {
            return cat.Attributes;
        }
        protected void DeleteCategory(object sender, EventArgs e)
        {
            categoryLogic.Delete(cat.CategoryId, User.Identity);

            Response.Redirect("/Pages/Admin/Categories");
        }
        protected void AddCategoryAttr(object sender, EventArgs e)
        {
            catAttrLogic.InsertCategoryAttr(new CategoryAttributes { 
             AttrName = txtboxAttrName.Text,
             CategoryId = cat.CategoryId,
             Type=int.Parse(CheckBoxListType.SelectedValue)
            });
            Refresh(); 
        }
        protected void EditCategory(object sender, EventArgs e)
        {
            categoryLogic.Edit(new Category
            {
                CategoryName = txtboxCatName.Text,
                CategoryId = Convert.ToInt32(catId),           
            }, User.Identity);
            Refresh();
        }
        protected void AddCategory(object sender, EventArgs e)
        {
            categoryLogic.Insert(new Category
            {
                CategoryName = txtboxCatName.Text      
            });
            Response.Redirect("/Pages/Admin/Categories");   
        }
        private void Refresh()
        {
            Response.Redirect(Page.Request.Url.AbsolutePath+"?catId="+catId, true); 
        }
    }
}