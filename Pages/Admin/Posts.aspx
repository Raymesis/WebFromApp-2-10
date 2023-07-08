<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Posts.aspx.cs" Inherits="WebApplication2.Pages.Admin.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ListView ID="productList" runat="server" 
                DataKeyNames="PostId" 
                ItemType="WebApplication2.Model.Post" SelectMethod="GetPosts">

                <ItemTemplate>
                    <a href="/Pages/LogedUserPages/EditPost.aspx?postId=<%#:Item.PostId%>" style="color:black">
                        <div class="column card" >
                            <img class="post_img" src="<%#:Item.Image%>" alt="Avatar">
                            <div>

                                <h4><b><%#:Item.Title%></b></h4>
                                <p class="post_desc"><%#:Item.Price%> ریال</p>
                                <p class="post_desc"><%#:Item.State.StateName%></p>
                                <p class="post_desc"><%#:CalculateTime(Item.Created_Date)%></p>
                                
                             </div>
                        </div> 
                    </a>
                </ItemTemplate>
            </asp:ListView>
</asp:Content>
