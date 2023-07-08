<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="CategoryEdit.aspx.cs" Inherits="WebApplication2.Pages.Admin.CategoryEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  

    <div class="newpost-div">
        <h2>ویرایش دسته</h2>
        <div class="new-post-container">

            <div class="new-post-row">
                <div class="col-50">

                    <label for="id"><i class="fa "></i>ID:</label>
                    <asp:TextBox runat="server" class="new-post-input" type="text" Enabled="false" ID="categoryId" name="ID" placeholder="ID"></asp:TextBox>

                    <label for="title"><i class="fa "></i>عنوان</label>
                    <asp:RequiredFieldValidator ValidationGroup="categoryGp" ID="RequiredFieldValidator3" runat="server" Text="* عنوان دسته را وارد کنید" ControlToValidate="txtboxCatName" SetFocusOnError="true" Display="Dynamic"  CssClass="validator"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ValidationGroup="categoryGp" Display="Dynamic" ControlToValidate="txtboxCatName" ID="RegularExpressionValidator2" ValidationExpression="^[\s\S]{3,}$" runat="server" ErrorMessage="نام دسته باید بیشتر از 3 کارکتر باشد"  CssClass="validator"></asp:RegularExpressionValidator>
                    <asp:TextBox runat="server" class="new-post-input" type="text" ID="txtboxCatName" name="title" placeholder="عنوان"></asp:TextBox>

                    <asp:Label runat="server" AssociatedControlID="listviewCategoryAttr"><i class="fa "></i>ویژگی های دسته:</asp:Label>
                    <asp:ListView ID="listviewCategoryAttr" runat="server"
                        DataKeyNames="AttrId"
                        ItemType="WebApplication2.Model.CategoryAttributes" SelectMethod="GetAttributes">
                        <EmptyDataTemplate>
                            </EmptyDataTemplate>
                        <ItemTemplate>

                            <div class="column card">
                                <div>
                                    <p class="post_desc">ID:<%#:Item.AttrId%> </p>
                                    <p class="post_desc">نام ویژگی: <%#Item.AttrName %> </p>
                                    <a href="?catId=<%#:Item.CategoryId %>&action=delete&attrId=<%#:Item.AttrId %>" class="btn" style ="color:white; Background:palevioletred">
                                        حذف
                                    </a>
                                    <a href="/pages/admin/AttrListEdit?attrId=<%#:Item.AttrId %>" class="btn" style ="color:white; Background:#8a6d3b">
                                        ویرایش
                                    </a>
                                </div>
                            </div>

                        </ItemTemplate>

                    </asp:ListView>
                </div>

                <asp:Button ValidationGroup="categoryGp" ID="editBtn" Text="ثبت" class="btn" runat="server" OnClick="EditCategory"></asp:Button>
                <asp:Button ValidationGroup="categoryGp" ID="saveBtn" Text="ذخیره" class="btn" runat="server" OnClick="AddCategory" ></asp:Button>
                <asp:Button ValidationGroup="categoryGp" ID="deleteBtn" Text="حذف" class="btn" runat="server" OnClick="DeleteCategory" BackColor="PaleVioletRed"></asp:Button>
            </div>

        </div>
    </div>
    <div class="newpost-div">
        <div class="new-post-container">
            <div class="new-post-row">
                <div class="col-50">
                    <h2>افزودن ویژگی</h2>


                    <label for="title"><i class="fa "></i>عنوان ویژگی</label>
                    <asp:RequiredFieldValidator ValidationGroup="featureGp" ID="RequiredFieldValidator1" runat="server" Text="* عنوان ویژگی را وارد کنید" ControlToValidate="txtboxAttrName" SetFocusOnError="true" Display="Dynamic"  CssClass="validator"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ValidationGroup="featureGp" Display="Dynamic" ControlToValidate="txtboxAttrName" ID="RegularExpressionValidator1" ValidationExpression="^[\s\S]{3,}$" runat="server" ErrorMessage="نام دسته باید بیشتر از 3 کارکتر باشد"  CssClass="validator"></asp:RegularExpressionValidator>
                    <asp:TextBox runat="server" class="new-post-input" type="text" ID="txtboxAttrName" name="title" placeholder="عنوان ویژگی"></asp:TextBox>
                    <asp:DropDownList ID="CheckBoxListType" runat="server"  >  
                                <asp:ListItem Value="2" Text="متن"></asp:ListItem>  
                                <asp:ListItem Value="1" Text="لیست"></asp:ListItem>  
                            </asp:DropDownList>  
                    <asp:Button ValidationGroup="featureGp" ID="btnAddAttr" Text="افزودن ویژگی" class="btn" runat="server" OnClick="AddCategoryAttr"></asp:Button>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
