<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserPosts.aspx.cs" Inherits="WebApplication2.Pages.LogedUserPages.UserPosts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<asp:PlaceHolder runat="server" ID="no_post_view" Visible="true">
    <p> شما هیچ آگهی ایی ثبت نکردید</p>
</asp:PlaceHolder>

<div class="row">

        <asp:ListView ID="productList" runat="server" 
            DataKeyNames="PostId" 
            ItemType="WebApplication2.Model.Post" SelectMethod="GetUserPosts">

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
</div>
</asp:Content>
