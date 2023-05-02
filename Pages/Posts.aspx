<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Posts.aspx.cs" Inherits="WebApplication2.Pages.WebForm1" %>






    <asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <meta name="viewport" content="width=device-width, initial-scale=1">

       

           <div>
            <asp:ListView ID="productList" runat="server" 
                DataKeyNames="id" 
                ItemType="WebApplication2.Model.PostModel" SelectMethod="getPosts">





                <ItemTemplate>
                    <a href="PostDetails.aspx?id=<%#:Item.id%>">
                        <div class="column card" >
                            <img class="post_img" src="/images/test_image.png" alt="Avatar">
                            <div class="container">
                                <h4><b><%#:Item.onvan%></b> </h4>
                                <p class="post_desc"><%#:Item.gheimat%></p>
                                <p class="post_desc"><%#:Item.vaziat_forosh%></p>
                                <p class="post_desc"><%#:Item.tarikht_sabt%></p>
                             </div>
                        </div> 
                    </a>
                </ItemTemplate>
            </asp:ListView>
         
        </div>


        <style>
            * {
                box-sizing: border-box;
                
            }

            .card {
                box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
                transition: 0.3s;
                width: 30%;
                border-radius: 5px;
            }

                .card:hover {
                    box-shadow: 0 8px 16px 0 rgba(0,0,0,0.4);
                }

            .post_img {
                border-radius: 5px 5px 0 0;
                width: 100%;
                float: left;
                object-fit: cover
            }

            .container {
                padding: 2px 16px;
            }

            .row:after {
                content: "";
                display: table;
                clear: both;
            }

            .column {
                float: left;
                padding: 10px;
                margin: 10px;
            }

            .post_desc {
                color: darkgray;
                font-size: 14px;
            }

           
        </style>

       


    </asp:Content>


