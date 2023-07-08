<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="UserEdit.aspx.cs" Inherits="WebApplication2.Pages.Admin.UserEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="col-12" style="padding:30px">
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
                         <asp:RegularExpressionValidator Display="Dynamic" ControlToValidate="txtboxUserName" ID="RegularExpressionValidator4" ValidationExpression="^[\s\S]{5,}$" runat="server" ErrorMessage="نام کاربری باید بیشتر از 5 کارکتر باشد"></asp:RegularExpressionValidator>
                        <label class="form-label">نام کاربری *</label>
                        <asp:TextBox runat="server" ID="txtboxUserName" type="text" class="form-control" placeholder="" aria-label="نام کاربری" value=""></asp:TextBox>
                    </div>
                    <!-- Last name -->
                    <div class="col-md-6">
                          <asp:RegularExpressionValidator Display="Dynamic" ControlToValidate="txtboxFamilyName" ID="RegularExpressionValidator1" ValidationExpression="^[\s\S]{5,}$" runat="server" ErrorMessage="نام خانوادگی باید بیشتر از 6 کارکتر باشد"></asp:RegularExpressionValidator>

                        <label class="form-label">نام و نام خانوادگی *</label>
                        <asp:TextBox runat="server" ID="txtboxFamilyName" type="text" class="form-control" placeholder="" aria-label="نام و نام خانوادگی" value=""></asp:TextBox>
                    </div>
                    <!-- Phone number -->
                    <div class="col-md-6">
                         <asp:RegularExpressionValidator Display="Dynamic" ControlToValidate="txtboxPhNumber" ID="RegularExpressionValidator2" ValidationExpression="^[\s\S]{12,}$" runat="server" ErrorMessage="شماره تلفن شما باید بیشتر از 11 کارکتر باشد"></asp:RegularExpressionValidator>

                        <label class="form-label">شماره تماس *</label>
                        <asp:TextBox runat="server" ID="txtboxPhNumber" type="text" class="form-control" placeholder="" aria-label="Phone number" value=""></asp:TextBox>
                    </div>

                    <!-- Email -->
                    <div class="col-md-6">
                        <label for="inputEmail4" class="form-label">آدرس ایمیل *</label>
                        <asp:TextBox runat="server" ID="txtboxEmail" type="email" class="form-control" value="test@gmail.com"></asp:TextBox>
                    </div>
								
				</div> <!-- Row END -->
			</div>
		</div>
		<div class="col-xxl-6">
			<div class="bg-secondary-soft px-4 py-5 rounded">
				<div class="row g-3">
					<h4 class="my-4">تغییر کلمه عبور</h4>
				
					<!-- New password -->
					<div class="col-md-6">
						<label for="newPass1" class="form-label">کلمه عبور جدید *</label>
                        <asp:RegularExpressionValidator Display="Dynamic" ControlToValidate="txtboxPhNumber" ID="RegularExpressionValidator3" ValidationExpression="^[\s\S]{6,}$" runat="server" ErrorMessage="کلمه عبور باید بیشتر از 6 کارکتر باشد"></asp:RegularExpressionValidator>

						<asp:TextBox runat="server" TextMode="Password" class="form-control" id="txtboxNewPass1"></asp:TextBox>
					</div>
					<!-- Confirm password -->
                    <div class="col-md-6"> 
                        <p class="form-label"></p>  
                        <asp:Button runat="server" type="button" class="btn btn-success-soft" Text="تغییر کلمه عبور" OnClick="ChangePass"></asp:Button>
		            </div>
					<div class="col-md-6">
						<label for="newPass2" class="form-label">تکرار کلمه عبور جدید *</label>
                        <asp:RegularExpressionValidator Display="Dynamic" ControlToValidate="txtboxPhNumber" ID="RegularExpressionValidator5" ValidationExpression="^[\s\S]{6,}$" runat="server" ErrorMessage="کلمه عبور باید بیشتر از 6 کارکتر باشد"></asp:RegularExpressionValidator>

						<asp:TextBox runat="server"  TextMode="Password" class="form-control" id="txtboxNewPass2"></asp:TextBox>
					</div>

                        
				</div>
			</div>
		</div>				
				<!-- button -->
		<div class="gap-3 d-md-flex justify-content-md-end text-center">
			<asp:Button runat="server" type="button" class="btn btn-primary btn-lg" Text="ذخیره تغییرات" OnClick="SaveChanges"></asp:Button>
            <asp:Button runat="server" id="activeUserBtn" type="button" class="btn btn-primary btn-lg" Text="فعالسازی حساب کاربری" OnClick="ActiveUser"></asp:Button>
            <asp:Button runat="server" id="deactiveUserBtn" type="button" class="btn btn-danger btn-lg" Text="غیرفعالسازی حساب کاربری" OnClick="DeactiveUser"></asp:Button>
            <asp:Button runat="server" type="button" class="btn btn-danger btn-lg" Text="حذف حساب کاربری" OnClick="DeleteUser"></asp:Button>
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
