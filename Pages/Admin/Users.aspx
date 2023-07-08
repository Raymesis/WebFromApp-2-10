<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="WebApplication2.Pages.Admin.Users" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <asp:ListView ID="productList" runat="server" 
                DataKeyNames="Id" 
                ItemType="WebApplication2.Model.ApplicationUser" SelectMethod="getUsers">

                    <ItemTemplate>
                        <a href="UserEdit.aspx?user=<%#:Item.Id %>" >
                        <div class="column card" >                        
                            <div>
                                <p class="post_desc">ID:<%#:Item.Id%> </p>
                                <p class="post_desc">نام کاربر : <%#Item.FullName %> </p>
                                
                             </div>
                        </div> 
              
                    </a>
                    </ItemTemplate>

        </asp:ListView>

</asp:Content>
