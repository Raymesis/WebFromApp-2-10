<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2.Pages.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div class="row">
            <asp:ListView ID="productList" runat="server" 
                DataKeyNames="PostId" 
                ItemType="WebApplication2.Model.Post" SelectMethod="GetPosts">

                <ItemTemplate>
                    <a href="Pages/PostDetails.aspx?postId=<%#:Item.PostId %>" style="color:black">
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
