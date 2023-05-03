<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="WebApplication2.Pages.Users2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../Content/sitecss.css" rel="stylesheet" />

    <div class="row gutters-sm">
        <div class="col-md-4 mb-3">
            <div class="card">
                <div class="card-body">
                    <div class="d-flex flex-column align-items-center text-center">
                        <img src="https://bootdey.com/img/Content/avatar/avatar7.png" alt="Admin" class="rounded-circle" width="150">
                        <div class="mt-3">
                            <h4>محمد نادری</h4>
                            <p class="text-secondary mb-1">مشخصات</p>
                            
                        </div>
                    </div>
                </div>
            </div>
            
        <div class="col-md-8">
            <div class="card mb-3">
                <div class="card-body">
                    <div class="row">
                        <div class="col-sm-3">
                            <h6 class="mb-0">نام </h6>
                        </div>
                        <div class="col-sm-9 text-secondary">
                            محمد 
                        </div>
                    </div>
                    <hr>
                    <div class="row">
                        <div class="col-sm-3">
                            <h6 class="mb-0">نام خانوادگی</h6>
                        </div>
                        <div class="col-sm-9 text-secondary">
                            نامداری
                        </div>
                    </div>
                    <hr>
                    <div class="row">
                        <div class="col-sm-3">
                            <h6 class="mb-0">شماره تماس</h6>
                        </div>
                        <div class="col-sm-9 text-secondary">
                            0999 999 9999
                        </div>
                    </div>
                    <hr>
                    <div class="row">
                        <div class="col-sm-3">
                            <h6 class="mb-0">نام کاربری</h6>
                        </div>
                        <div class="col-sm-9 text-secondary">
                            MohamadNaderi9
                        </div>
                    </div>
                    <hr>
                    <div class="row">
                        <div class="col-sm-3">
                            <h6 class="mb-0">گذرواژه</h6>
                        </div>
                        <div class="col-sm-9 text-secondary">
                            12345678
                        </div>
                    </div>
                    <hr>
                    <div class="row">
                        <div class="col-sm-12">
                            <a class="btn btn-info " target="__blank" href="#">ویرایش مشخصات</a>
                        </div>
                    </div>
                </div>
            </div>
    </div>
</asp:Content>
