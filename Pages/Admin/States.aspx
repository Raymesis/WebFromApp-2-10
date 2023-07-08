<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="States.aspx.cs" Inherits="WebApplication2.Pages.Admin.States" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

             <div class="gap-3 d-md-flex justify-content-md-end " style="margin-top:10px">
			<a  class="btn btn-primary btn-lg" href="StateEdit.aspx">افزودن دسته جدید</a>
            
		</div>
    <asp:ListView ID="stateList" runat="server" 
                DataKeyNames="StateId" 
                ItemType="WebApplication2.Model.State" SelectMethod="GetStates">

                    <ItemTemplate>
                        <a href="/Pages/Admin/StateEdit.aspx?stateId=<%#:Item.StateId%>">
                        <div class="column card" >                        
                            <div>
                                <p class="post_desc">ID:<%#:Item.StateId%> </p>
                                <p class="post_desc">نام وضعیت: <%#Item.StateName %> </p>
                              
                             </div>
                        </div> 
                        </a>

                    </ItemTemplate>

        </asp:ListView>

</asp:Content>
