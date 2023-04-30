<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication2.Pages.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">

   <style>
        body {
            font-family: Arial, Helvetica, sans-serif;
        }
        * {
            box-sizing: border-box;
        }
        /* style the container */
        .container1 {
            position: relative;
            border-radius: 5px;
            
            background-color: #f2f2f2;
            padding: 20px 0 30px 0;
        }
        /* style inputs and link buttons */
        input,
        .btn1 {
            width: 100%;
            padding: 12px;
            border: none;
            border-radius: 4px;
            margin: 5px 0;
            opacity: 0.85;
            display: inline-block;
            font-size: 17px;
            line-height: 20px;
            text-decoration: none; /* remove underline from anchors */
            box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
        }
            input:hover,
            .btn:hover {
                opacity: 1;
            }
        /*.google {
            background-color: #45a049;
            color: white;
            box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
            direction: ltr;
        }*/
        /* style the submit button */
        input[type=submit] {
            background-color: #04AA6D;
            color: white;
            cursor: pointer;
        }
            input[type=submit]:hover {
                background-color: #45a049;
            }
        /* Two-column layout */
        .col1 {
            float: left;
            width: 50%;
            margin: auto;
            padding: 0 50px;
            margin-top: 6px;
            direction: rtl;
        }
        /* Clear floats after the columns */
        .row1:after {
            content: "";
            display: table;
            clear: both;
        }
        /* vertical line */
        .vl1 {
            position: absolute;
            left: 50%;
            transform: translate(-50%);
            border: 2px solid #ddd;
            height: 175px;
        }
        /* text inside the vertical line */
        .vl-innertext1 {
            position: absolute;
            top: 50%;
            transform: translate(-50%, -50%);
            background-color: #f1f1f1;
            border: 1px solid #ccc;
            border-radius: 50%;
            padding: 8px 10px;
        }
        /* hide some text on medium and large screens */
        .hide-md-lg1 {
            display: none;
        }
        /* bottom container */
        .bottom-container1 {
            text-align: center;
            position:relative;
            background-color: #666;
            border-radius: 0px 0px 4px 4px;
            box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
        }
        /* hide the vertical line */
        .vl1 {
            display: none;
        }
        /* show the hidden text on small screens */
        .hide-md-lg1 {
            display: block;
            text-align: center;
            direction: ltr;
        }
        
    </style> 


  
    <div class="container1">
        
            <div class="row1">
                <h2 style="text-align:center"></h2>
                <div class="vl1">
                    <span class="vl-innertext1">or</span>
                </div>

                <div class="col1">
                    <div class="hide-md-lg1">
                        <p>ثبت نام</p>
                    </div>

                    <input type="text" name="fname" placeholder="نام " required>
                    <input type="text" name="lname" placeholder="نام خانوادگی" required>
                    <input type="text" name="username" placeholder="نام کاربری" required>
                    <input type="password" name="pass" placeholder="رمز ورود" required>
                    <input type="text" name="telephone" placeholder=" تلفن همراه" required>
                    <input type="submit" value="ثبت نام">

                </div>

                <div class="col1">
                    <div class="hide-md-lg1">
                        <p>ورود به حساب کاربری </p>
                    </div>

                    <input type="text" name="نام کاربری" placeholder="نام کاربری" required>
                    <input type="password" name="رمز" placeholder="رمز ورود" required>
                    <input type="submit" value="ورود">
                    <!-- <a href="#" class="google btn">
                        <i class="fa fa-google fa-fw">
                        </i>  Googleوارد شدن با
                    </a> -->

                </div>

            </div>
        
    </div>

    <div class="bottom-container1">
        <div class="row1">
            <div class="col1">
                <a href="#" style="color: white" class="btn1">تست</a>
            </div>
            <div class="col1">
                <a href="#" style="color:white" class="btn1">فراموشی رمزعبور</a>
            </div>
        </div>
    </div>



</asp:Content>
