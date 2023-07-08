<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserProfile.aspx.cs" Inherits="WebApplication2.Pages.LogedUserPages.UserProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="col-12" style="padding: 30px">
        <!-- Page title -->
        <div class="my-5">
            <h3>پروفایل</h3>
            <hr>
        </div>
        <div class="col-xxl-8 mb-5 mb-xxl-0">
            <div class="bg-secondary-soft px-4 py-5 rounded">
                <div class="row g-3">
                    <h4 class="mb-4 mt-0">اطلاعات شخصی</h4>
                    <!-- First Name -->
                    <div class="col-md-6">
                        <label class="form-label">نام کاربری </label>

                        <asp:RegularExpressionValidator ValidationGroup="personalInfoValidationGp" Display="Dynamic" ControlToValidate="txtboxUserName" ID="RegularExpressionValidator4" ValidationExpression="^[\s\S]{5,}$" runat="server" ErrorMessage="نام کاربری باید بیشتر از 5 کارکتر باشد" CssClass="validator"></asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ValidationGroup="personalInfoValidationGp" ID="RequiredFieldValidator1" runat="server" Text="* نام کاربری خود را وارد کنید" ControlToValidate="txtboxUserName" SetFocusOnError="true" Display="Dynamic"  CssClass="validator"></asp:RequiredFieldValidator>
                        
                        <asp:TextBox runat="server" ID="txtboxUserName" type="text" class="form-control" placeholder="" aria-label="نام کاربری" value=""></asp:TextBox>
                    </div>
                    <!-- Last name -->
                    <div class="col-md-6">
                        <label class="form-label">نام و نام خانوادگی</label>

                         <asp:RegularExpressionValidator ValidationGroup="personalInfoValidationGp" Display="Dynamic" ControlToValidate="txtboxFamilyName" ID="RegularExpressionValidator1" ValidationExpression="^[\s\S]{5,}$" runat="server" ErrorMessage="نام خانوادگی باید بیشتر از 6 کارکتر باشد" CssClass="validator"></asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ValidationGroup="personalInfoValidationGp" ID="RequiredFieldValidator4" runat="server" Text="* نام و نام خانوادگی خود را وارد کنید" ControlToValidate="txtboxFamilyName" SetFocusOnError="true" Display="Dynamic"  CssClass="validator"></asp:RequiredFieldValidator>
                        
                        <asp:TextBox runat="server" ID="txtboxFamilyName" type="text" class="form-control" placeholder="" aria-label="نام و نام خانوادگی" value=""></asp:TextBox>
                    </div>
                    <!-- Phone number -->
                    <div class="col-md-6">
                        <label class="form-label">شماره تماس</label>

                         <asp:RegularExpressionValidator ValidationGroup="personalInfoValidationGp" Display="Dynamic" ControlToValidate="txtboxPhNumber" ID="RegularExpressionValidator2" ValidationExpression="^[\s\S]{12,}$" runat="server" ErrorMessage="شماره تلفن شما باید بیشتر از 11 کارکتر باشد"  CssClass="validator"></asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ValidationGroup="personalInfoValidationGp" ID="RequiredFieldValidator2" runat="server" Text="* شماره تماس خود را وارد کنید" ControlToValidate="txtboxFamilyName" SetFocusOnError="true" Display="Dynamic"  CssClass="validator"></asp:RequiredFieldValidator>
                        
                        <asp:TextBox runat="server" ID="txtboxPhNumber" type="text" class="form-control" placeholder="" aria-label="Phone number" value=""></asp:TextBox>
                    </div>

                    <!-- Email -->
                    <div class="col-md-6">
                        <label for="inputEmail4" class="form-label">آدرس ایمیل</label>

                        <asp:RequiredFieldValidator ValidationGroup="personalInfoValidationGp" ID="RequiredFieldValidator3" runat="server" Text="* ایمیل خود را وارد کنید" ControlToValidate="txtboxEmail" SetFocusOnError="true" Display="Dynamic"  CssClass="validator"></asp:RequiredFieldValidator>
                        <asp:TextBox runat="server" ID="txtboxEmail" type="email" class="form-control" value="test@gmail.com"></asp:TextBox>
                    </div>

                </div>
                <!-- Row END -->
            </div>
        </div>
        <%--		<div class="col-xxl-4">
			<div class="bg-secondary-soft px-4 py-5 rounded">
				<div class="row g-3">
					<h4 class="mb-4 mt-0">آپلود عکس </h4>
					<div class="text-center">
						<!-- Image upload -->
						<div class="square position-relative display-2 mb-3">
							<i class="fas fa-fw fa-user position-absolute top-50 start-50 translate-middle text-secondary"></i>
						</div>
						<!-- Button -->
						<input type="file" id="customFile" name="file" hidden="">
						<asp:Button runat="server" type="button" class="btn btn-success-soft " for="customFile" Text="آپلود" OnClick="ChangeImg"></asp:Button>
						<asp:Button runat="server" type="button" class="btn btn-danger-soft" Text="حذف" OnClick="DeleteImg"></asp:Button>
						<!-- Content -->
						<p class="text-muted mt-3 mb-0"><span class="me-1">Note:</span>Minimum size 300px x 300px</p>
					</div>
				</div>
			</div>
		</div>--%>
        <div class="col-xxl-6">
            <div class="bg-secondary-soft px-4 py-5 rounded">
                <div class="row g-3">
                    <h4 class="my-4">تغییر کلمه عبور</h4>
                    <!-- Old password -->
                    <div class="col-md-6">
                        <label for="oldPass" class="form-label">کلمه عبور </label>

                        <asp:RegularExpressionValidator ValidationGroup="passwordValidationGp" Display="Dynamic" ControlToValidate="txtboxPhNumber" ID="txtboxOldPassRValidator" ValidationExpression="^[\s\S]{6,}$" runat="server" ErrorMessage="کلمه عبور شما باید بیشتر از 6 کارکتر باشد"  CssClass="validator"></asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ValidationGroup="passwordValidationGp" ID="txtboxOldPassFValidator" runat="server" Text="* کلمه عبور خود را وارد کنید" ControlToValidate="txtboxFamilyName" SetFocusOnError="true" Display="Dynamic"  CssClass="validator"></asp:RequiredFieldValidator>
                        
                        <asp:TextBox runat="server" TextMode="Password" class="form-control" ID="txtboxOldPass"></asp:TextBox>
                    </div>
                    <!-- New password -->
                    <div class="col-md-6">
                        <label for="newPass1" class="form-label">کلمه عبور جدید </label>

                        <asp:RegularExpressionValidator ValidationGroup="passwordValidationGp" Display="Dynamic" ControlToValidate="txtboxNewPass1" ID="RegularExpressionValidator3" ValidationExpression="^[\s\S]{6,}$" runat="server" ErrorMessage="کلمه عبور شما باید بیشتر از 6 کارکتر باشد"  CssClass="validator"></asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ValidationGroup="passwordValidationGp" ID="RequiredFieldValidator5" runat="server" Text="* کلمه عبور خود را وارد کنید" ControlToValidate="txtboxNewPass1" SetFocusOnError="true" Display="Dynamic"  CssClass="validator"></asp:RequiredFieldValidator>

                        <asp:TextBox runat="server" TextMode="Password" class="form-control" ID="txtboxNewPass1"></asp:TextBox>
                    </div>
                    <!-- Confirm password -->
                    <div class="col-md-6">
                        <p class="form-label"></p>
                        <asp:Button runat="server" ValidationGroup="passwordValidationGp" type="button" class="btn btn-success-soft" Text="تغییر کلمه عبور" OnClick="ChangePass"></asp:Button>
                    </div>
                    <div class="col-md-6">
                        <label for="newPass2" class="form-label">تکرار کلمه عبور جدید </label>
                        <asp:RegularExpressionValidator ValidationGroup="passwordValidationGp" Display="Dynamic" ControlToValidate="txtboxNewPass2" ID="RegularExpressionValidator5" ValidationExpression="^[\s\S]{6,}$" runat="server" ErrorMessage="کلمه عبور شما باید بیشتر از 6 کارکتر باشد"  CssClass="validator"></asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ValidationGroup="passwordValidationGp" ID="RequiredFieldValidator6" runat="server" Text="* کلمه عبور خود را وارد کنید" ControlToValidate="txtboxNewPass2" SetFocusOnError="true" Display="Dynamic"  CssClass="validator"></asp:RequiredFieldValidator>
                        <asp:TextBox runat="server" TextMode="Password" class="form-control" ID="txtboxNewPass2"></asp:TextBox>
                    </div>


                </div>
            </div>
        </div>
        <!-- button -->
        <div class="gap-3 d-md-flex justify-content-md-end text-center">
            <asp:Button runat="server"  ValidationGroup="personalInfoValidationGp" type="button" class="btn btn-primary btn-lg" Text="ذخیره تغییرات" OnClick="SaveChanges" CausesValidation="true"></asp:Button>
            <asp:Button runat="server" ValidationGroup="personalInfoValidationGp" type="button" class="btn btn-danger btn-lg" Text="خروج از حساب کاربری" OnClick="SignOut"></asp:Button>
        </div>
    </div>
    <style>
        .bg-secondary-soft {
            background-color: rgba(208, 212, 217, 0.1) !important;
        }

        .rounded {
            border-radius: 5px !important;
        }

        .py-5 {
            padding-top: 3rem !important;
            padding-bottom: 3rem !important;
        }

        .px-4 {
            padding-right: 1.5rem !important;
            padding-left: 1.5rem !important;
        }

        .file-upload .square {
            height: 250px;
            width: 250px;
            margin: auto;
            vertical-align: middle;
            border: 1px solid #e5dfe4;
            background-color: #fff;
            border-radius: 5px;
        }

        .text-secondary {
            color: rgba(208, 212, 217, 0.5) !important;
        }

        .btn-success-soft {
            color: #28a745;
            background-color: rgba(40, 167, 69, 0.1);
        }

        .btn-danger-soft {
            color: #dc3545;
            background-color: rgba(220, 53, 69, 0.1);
        }

        .form-control {
            display: block;
            width: 100%;
            padding: 0.5rem 1rem;
            color: #29292e;
            background-color: lavender;
            background-clip: padding-box;
            border: 1px solid #e5dfe4;
            -webkit-appearance: none;
            -moz-appearance: none;
            appearance: none;
            border-radius: 5px;
            -webkit-transition: border-color 0.15s ease-in-out, -webkit-box-shadow 0.15s ease-in-out;
            transition: border-color 0.15s ease-in-out, -webkit-box-shadow 0.15s ease-in-out;
            transition: border-color 0.15s ease-in-out, box-shadow 0.15s ease-in-out;
            transition: border-color 0.15s ease-in-out, box-shadow 0.15s ease-in-out, -webkit-box-shadow 0.15s ease-in-out;
        }
    </style>
</asp:Content>
