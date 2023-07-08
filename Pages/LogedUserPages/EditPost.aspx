<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditPost.aspx.cs" Inherits="WebApplication2.Pages.LogedUserPages.EditPost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class="newpost-div">
<h2>فرم ویرایش آگهی</h2>

    <div class="new-post-row">
      <div class="col-75">
        <div class="new-post-container">
      
            <div class="new-post-row">
              <div class="col-50">
             
                 <p></p>
                            <label for="txtboxTitle"><i class="fa "></i>عنوان</label>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Text="* عنوان را وارد کنید" ControlToValidate="txtboxTitle" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator Display = "Dynamic" ControlToValidate = "txtboxTitle" ID="RegularExpressionValidator3" ValidationExpression = "^[\s\S]{4,50}$" runat="server" ErrorMessage="عنوان حداقل 4 و حداکثر 50 کاراکتر باشد"></asp:RegularExpressionValidator>
                            <asp:TextBox runat="server" class="new-post-input" type="text" ID="txtboxTitle" name="title" placeholder="عنوان"></asp:TextBox>

                            <label for="txtboxPrice"><i class="fa "></i>قیمت</label>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Text="* قیمت را وارد کنید" ControlToValidate="txtboxPrice" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" Text="* قیمت را بصورت عددی وارد کنید" ControlToValidate="txtboxPrice" SetFocusOnError="True" Display="Dynamic"  ValidationExpression="^[0-9]*(\.)?[0-9]?[0-9]?$"></asp:RegularExpressionValidator>
                            <asp:TextBox runat="server" class="new-post-input" type="text" ID="txtboxPrice" name="price" placeholder="قیمت"></asp:TextBox>
                            

                            <label for="txtboxDesc"><i class="fa"></i>توضیحات</label>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Text="* توضیحات خود را وارد کنید" ControlToValidate="txtboxDesc" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:TextBox runat="server" class="new-post-input" ID="txtboxDesc" Rows="12" Columns="60" name="description" placeholder=" توضیحات"></asp:TextBox>
                            
                            
                            <label for="txtboxPhNumber"><i class="fa "></i>شماره تلفن</label>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Text="* توضیحات خود را وارد کنید" ControlToValidate="txtboxPhNumber" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator Display = "Dynamic" ControlToValidate = "txtboxPhNumber" ID="RegularExpressionValidator4" ValidationExpression = "^[\s\S]{12,}$" runat="server" ErrorMessage="شماره تلفن باید 12 رقم باشد"></asp:RegularExpressionValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" Text="* قیمت را بصورت عددی وارد کنید" ControlToValidate="txtboxPhNumber" SetFocusOnError="True" Display="Dynamic"  ValidationExpression="^[0-9]*(\.)?[0-9]?[0-9]?$"></asp:RegularExpressionValidator>
                            <asp:TextBox runat="server" class="new-post-input" type="text" ID="txtboxPhNumber" name="phnumber" placeholder="شماره تلفن"></asp:TextBox>

                            <div>
                                <label for="AttributesList" runat="server"><i class="fa"></i>ویژگی ها:</label>
                                <asp:ListView ID="AttributesList" runat="server"
                                    DataKeyNames="AttrId"
                                    ItemType="WebApplication2.Model.CategoryAttributes" 
                                    SelectMethod="GetAttributes"
                                    >

                                    <ItemTemplate>
                                        <div class="column card">
                                            <div>
                                                <h4><b><%#:Item.AttrName%></b></h4>
                                                <asp:TextBox runat="server" ID="txtboxAttrValue" class="post_desc" Visible="<%#Item.Type==2 %>" ></asp:TextBox>

                                                <asp:DropDownList ID="DropDownAttrList" runat="server"
                                                    ItemType="WebApplication2.Model.AttrList"
                                                    DataSource="<%#GetAttributesValues(Item.AttrId) %>"
                                                    DataTextField="Value"
                                                    DataValueField="Id"
                                                    Visible="<%#Item.Type==1 %>"
                                                    >
                                                </asp:DropDownList>
                                            </div>
                                        </div>
                                    </ItemTemplate>
                                </asp:ListView>
                            </div>

                            <label for="ProductImage" runat="server"><i class="fa"></i>تصویر:</label>
                            <label for="ProductImage" id="ImageError" runat="server"><i class="fa"></i></label>
                            <asp:FileUpload ID="ProductImage" runat="server" />
                           <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Text="*" ControlToValidate="ProductImage" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>--%>
                        </div>

                    </div>
                    <asp:Button ID="btnSubmit" runat="server" Text="ثبت" class="btn"  OnClick="EditPosts" CausesValidation="true"></asp:Button>                
            <asp:Button text="حذف" class="btn" runat="server" onclick="DeletePosts" BackColor="PaleVioletRed"></asp:Button>
            <asp:Button ID="btnActivation" text="فعال سازی" class="btn" runat="server" onclick="PostActivation" BackColor="PaleVioletRed"></asp:Button>
        </div>
      </div>
    </div>
    </div>

</asp:Content>
