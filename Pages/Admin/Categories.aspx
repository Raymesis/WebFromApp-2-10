<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="WebApplication2.Pages.Admin.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
         <div class="gap-3 d-md-flex justify-content-md-end " style="margin-top:10px">
			<a  class="btn btn-primary btn-lg" href="CategoryEdit.aspx">افزودن دسته جدید</a>
            
		</div>
    <asp:ListView ID="productList" runat="server" 
                DataKeyNames="CategoryId" 
                ItemType="WebApplication2.Model.Category" SelectMethod="GetCategories">

                    <ItemTemplate>
                        <a href="/Pages/Admin/CategoryEdit.aspx?catId=<%#:Item.CategoryId%>">
                        <div class="column card" >                        
                            <div>
                                <p class="post_desc">ID:<%#:Item.CategoryId%> </p>
                                <p class="post_desc">نام دسته: <%#Item.CategoryName %> </p>
                              

                             </div>
                        </div> 
                        </a>

                    </ItemTemplate>

        </asp:ListView>


</asp:Content>
