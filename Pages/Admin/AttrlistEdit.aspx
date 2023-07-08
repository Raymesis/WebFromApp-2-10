<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AttrlistEdit.aspx.cs" Inherits="WebApplication2.Pages.Admin.StateEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="newpost-div">
        <h2>ویرایش وضعیت ها</h2>



        <div class="new-post-row">

            <div class="col-75">


                <div class="new-post-row">

                    <div class="col-50">

                        <asp:ListView ID="listviewCategoryAttr" runat="server"
                            DataKeyNames="Id"
                            ItemType="WebApplication2.Model.AttrList" SelectMethod="GetAttributeValues"
                            OnItemCommand="listviewCategoryAttr_ItemCommand">
                            <ItemTemplate>

                                <div class="new-post-container">
                                    <asp:TextBox runat="server" Enabled="false" class="new-post-input" type="text" ID="txtboxValueId" name="ID" placeholder="ID" Text="<%#:Item.Id %>"></asp:TextBox>

                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Text="* عنوان وضعیت کالا را وارد کنید" ControlToValidate="txtboxValueName" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator Display="Dynamic" ControlToValidate="txtboxValueName" ID="RegularExpressionValidator2" ValidationExpression="^[\s\S]{3,}$" runat="server" ErrorMessage="عنوان وضعیت کالا باید بیشتر از 3 کارکتر باشد"></asp:RegularExpressionValidator>

                                    <asp:TextBox runat="server" class="new-post-input" type="text" ID="txtboxValueName" name="title" placeholder="مقدار" Text="<%#:Item.Value%>"></asp:TextBox>
                                    <div class="row g-3">
                                        <div class="col-md-6">
                                            <asp:Button runat="server"
                                                Class="btn"
                                                ID="SaveBtn"
                                                Text="ذخیره"
                                                CommandName="SaveAttr" />
                                        </div>

                                        <div class="col-md-6">
                                            <asp:Button runat="server"
                                                Class="btn"
                                                ID="DeleteBtn"
                                                Text="حذف"
                                                CommandName="DeleteAttr"
                                                Style="background-color: palevioletred;" />

                                        </div>
                                    </div>
                                </div>

                            </ItemTemplate>
                        </asp:ListView>



                    </div>

                    <div class="col-50">

                        <asp:TextBox runat="server" class="new-post-input" type="text" ID="txtboxNewValue" placeholder="نام مقدار" Text=""></asp:TextBox>

                        <asp:Button runat="server"
                            Class="btn"
                            ID="insertValueBtn"
                            Text="افزودن مقدار جدید"
                            OnClick="InsertValue" />

                    </div>
                </div>

            </div>

        </div>
    </div>

</asp:Content>
