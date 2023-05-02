<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Logint4.aspx.cs" Inherits="WebApplication2.Pages.WebForm2" %>
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
        .container {
            position:relative;
            border-radius: 2px;
            
            background-color: #f2f2f2;
            padding: 20px 0 30px 0;
        }
        /* style inputs and link buttons */
        input,
        .btn {
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

        input[type=submit] {
            background-color: #04AA6D;
            color: white;
            cursor: pointer;
        }
        input[type=submit]:hover {
            background-color: #45a049;
        }
        /* Two-column layout */
        .col {
            float: left;
            width: 50%;
            margin: auto;
            padding: 0 50px;
            margin-top: 6px;
            direction: rtl;
        }
        /* Clear floats after the columns */
        .row:after {
            content: "";
            display: table;
            clear: both;
        }
        /* vertical line */
        .vl {
            position:center;
            left: 50%;
            transform: translate(-50%);
            border: 2px solid #ddd;
            height: 175px;
        }
        /* text inside the vertical line */
        .vl-innertext {
            position: absolute;
            top: 50%;
            transform: translate(-50%, -50%);
            background-color: #f1f1f1;
            border: 1px solid #ccc;
            border-radius: 50%;
            padding: 8px 10px;
        }
        /* hide some text on medium and large screens */
        .hide-md-lg {
            display: none;
        }
        /* bottom container */
        .bottom-container {
            text-align: center;
            position:relative;
            background-color: #666;
            border-radius: 0px 0px 4px 4px;
            box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
        }
        /* hide the vertical line */
        .vl {
            display: none;
        }
        /* show the hidden text on small screens */
        .hide-md-lg {
            display: block;
            text-align: center;
            direction: ltr;
        }
        
       .auto-style1 {
           width: 1170px;
           position: relative;
           border-radius: 2px;
           right: 0px;
           top: 108px;
           height: 333px;
           margin-left: auto;
           margin-right: auto;
           padding-left: 0;
           padding-right: 0;
           padding-top: 20px;
           padding-bottom: 30px;
           background-color: #f2f2f2;
       }
        
    </style> 


  
    <div class="auto-style1">
        
            <div class="row">
                <h2 style="text-align:center"></h2>
                <div class="vl">
                    <span class="vl-innertext">or</span>
                </div>

                <div class="col">
                    <div class="hide-md-lg">
                        <p>ثبت نام</p>
                    </div>

                    <input type="text" name="fname" placeholder="نام " required>
                    <input type="text" name="lname" placeholder="نام خانوادگی" required>
                    <input type="text" name="username" placeholder="نام کاربری" required>
                    <input type="password" name="pass" placeholder="رمز ورود" required>
                    <input type="text" name="telephone" placeholder=" تلفن همراه" required>
                    <input type="submit" value="ثبت نام">

                </div>

                <div class="col">
                    <div class="hide-md-lg">
                        <p>ورود به حساب کاربری </p>
                    </div>

                    <input type="text" name="نام کاربری" placeholder="نام کاربری" required>
                    <input type="password" name="رمز" placeholder="رمز ورود" required>
                    <input type="submit" value="ورود">
                    

                </div>

            </div>
        
    </div>

    <div class="bottom-container">
        <div class="row">
            <div class="col">
                <a href="#" style="color: white" class="btn1">تست</a>
            </div>
            <div class="col">
                <a href="#" style="color:white" class="btn1">فراموشی رمزعبور</a>
            </div>
        </div>
    </div>



</asp:Content>
