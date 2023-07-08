<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication2.Pages.Authentication.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">

    <body>

        <asp:PlaceHolder runat="server" ID="LoginForm" Visible="false">

            <div class="container1">
                <h4 style="font-size: medium">خوش آمدید</h4>
                <p>اگر حساب کاربری دارید از فرم زیر استفاده کنید </p>
                <hr>

                <p>
                    <asp:Literal runat="server" ID="StatusMessage" />
                </p>

                <div>

                    <asp:Label runat="server" AssociatedControlID="txtboxUserName">نام کاربری</asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Text="* نام کاربری را وارد نمایید" ControlToValidate="txtboxUserName" SetFocusOnError="true" Display="Dynamic"  CssClass="validator"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator Display="Dynamic" ControlToValidate="txtboxUserName" ID="RegularExpressionValidator4" ValidationExpression="^[\s\S]{5,}$" runat="server" ErrorMessage="* نام کاربری باید بیشتر از 5 حرف باشد"  CssClass="validator"></asp:RegularExpressionValidator>
                   
                     <asp:TextBox runat="server" Text="" ID="txtboxUserName" />

                </div>
                <div>
                    <asp:Label runat="server" AssociatedControlID="txtboxPassword">کلمه عبور</asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Text="* کلمه عبور را وارد نمایید" ControlToValidate="txtboxPassword" SetFocusOnError="true" Display="Dynamic"  CssClass="validator"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator Display="Dynamic" ControlToValidate="txtboxPassword" ID="RegularExpressionValidator1" ValidationExpression="^[\s\S]{6,}$" runat="server" ErrorMessage="کلمه عبور باید بیشتر از 8 رقم باشد"  CssClass="validator"></asp:RegularExpressionValidator>

                    <asp:TextBox runat="server" ID="txtboxPassword" TextMode="Password" />

                </div>
                <hr>
                <%--<p> قوانین سایت را مطالعه کرده و قبول میکنم.نین سایت را مطالعه کرده و قبول میکنم.<a href="#">شرایط و قوانین</a>.</p>--%>
                <asp:Button runat="server" OnClick="SignIn" CssClass="registerbtn" Text="ورود" />
            </div>

            <div class="container1 signin">
                <p>حساب کاربری ندارید؟<a runat="server" href="~/Pages/Signin"> ثبت نام </a>.</p>
            </div>
        </asp:PlaceHolder>

    </body>
    </html>
</asp:Content>
