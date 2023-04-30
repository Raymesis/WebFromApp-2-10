<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PostDetails.aspx.cs" Inherits="WebApplication2.Pages.PostDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:FormView ID="productDetail" runat="server" ItemType="WebApplication2.Model.PostModel" SelectMethod="getPost" RenderOuterTable="false">
        <ItemTemplate>
            <div>
                <h1><%#:Item.onvan %></h1>
            </div>
            <br />
            <table>
                <tr>
                    <td>
                        <img src="/images/test_image.png" style="border:solid; height:300px" alt="<%#:Item.onvan %>"/>
                    </td>
                    <td>&nbsp;</td>  
                    <td style="vertical-align: top; text-align:left;">
                        <b>Description:</b><br /><%#:Item.tozihat %>
                        <br />
                        <span><b>Price:</b>&nbsp;<%#: String.Format("{0:c}", Item.gheimat) %></span>
                        <br />
                        <span><b>Product Number:</b>&nbsp;<%#:Item.shomare_tamas %></span>
                        <br />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>

</asp:Content>
