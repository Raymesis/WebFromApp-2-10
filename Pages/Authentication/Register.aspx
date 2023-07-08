<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication2.Pages.Authentication.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">
    <head>
        <title></title>
    </head>
    <body>
        <p>
            <asp:Literal runat="server" ID="StatusMessage" />
        </p>
        <div class="container1">

            <h4 style="font-size: medium">خوش آمدید</h4>
            <p>اگر حساب کاربری ندارید از فرم زیر استفاده کنید </p>
            <hr />

            <asp:Label runat="server" AssociatedControlID="txtboxUserName">نام کاربری</asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Text="* نام کاربری را وارد کنید" ControlToValidate="txtboxUserName" SetFocusOnError="true" Display="Dynamic"  CssClass="validator"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator Display = "Dynamic" ControlToValidate = "txtboxUserName" ID="RegularExpressionValidator4" ValidationExpression = "^[\s\S]{5,}$" runat="server" ErrorMessage="نام کاربری باید بیشتر از 5 کارکتر باشد"  CssClass="validator"></asp:RegularExpressionValidator>
            <asp:TextBox runat="server" ID="txtboxUserName" />


            <asp:Label runat="server" AssociatedControlID="txtboxEmail">آدرس ایمیل</asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Text="* ایمیل خود را وارد کنید" ControlToValidate="txtboxEmail" SetFocusOnError="true" Display="Dynamic"  CssClass="validator"></asp:RequiredFieldValidator>
            <asp:TextBox runat="server" ID="txtboxEmail" TextMode="Email" />


            <asp:Label runat="server" AssociatedControlID="txtboxPassword">کلمه عبور</asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" Text="* کلمه عبور را وارد کنید" ControlToValidate="txtboxPassword" SetFocusOnError="true" Display="Dynamic"  CssClass="validator"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator Display = "Dynamic" ControlToValidate = "txtboxPassword" ID="RegularExpressionValidator3" ValidationExpression = "^[\s\S]{6,}$" runat="server" ErrorMessage="کلمه عبور باید بیشتر از 6 کارکتر باشد"  CssClass="validator"></asp:RegularExpressionValidator>       
            <asp:TextBox runat="server" ID="txtboxPassword" TextMode="Password" />


            <asp:Label runat="server" AssociatedControlID="txtboxFamilyName">نام و نام خانوادگی</asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Text="* نام و نام خانوادگی خود را وارد کنید" ControlToValidate="txtboxFamilyName" SetFocusOnError="true" Display="Dynamic"  CssClass="validator"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator Display = "Dynamic" ControlToValidate = "txtboxFamilyName" ID="RegularExpressionValidator1" ValidationExpression = "^[\s\S]{5,}$" runat="server" ErrorMessage="نام خانوادگی باید بیشتر از 6 کارکتر باشد"  CssClass="validator"></asp:RegularExpressionValidator>
            <asp:TextBox runat="server" ID="txtboxFamilyName" />


            <asp:Label runat="server" AssociatedControlID="txtboxPhoneNumber">شماره موبایل</asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Text="* شماره تلفن خود را وارد کنید" ControlToValidate="txtboxPhoneNumber" SetFocusOnError="true" Display="Dynamic"  CssClass="validator"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator Display = "Dynamic" ControlToValidate = "txtboxPhoneNumber" ID="RegularExpressionValidator2" ValidationExpression = "^[\s\S]{12,}$" runat="server" ErrorMessage="شماره تلفن شما باید بیشتر از 11 کارکتر باشد"  CssClass="validator"></asp:RegularExpressionValidator>
            <asp:TextBox runat="server" ID="txtboxPhoneNumber" />

            <asp:Button runat="server" CssClass="container1 registerbtn" OnClick="CreateUser" Text="ثبت نام" />

        </div>


    </body>
    </html>
</asp:Content>

