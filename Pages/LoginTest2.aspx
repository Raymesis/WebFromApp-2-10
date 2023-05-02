<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginTest2.aspx.cs" Inherits="WebApplication2.Pages.LoginTest2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>خوش آمدید</h1>
            <p>اگر حساب کاربری دارید از فرم زیر استفاده کنید </p>
            <hr>

            <label for="email"><b>نام کاربری :</b></label>
            <input type="text" placeholder="نام کاربری خود را وارد کنید :" name="username" id="username" required>

            <label for="psw"><b>رمز ورود :</b></label>
            <input type="password" placeholder="رمز عبور خود را وارد کنید :" name="password" id="password" required>

            <%--<label for="psw-repeat"><b>Repeat Password</b></label>
            <input type="password" placeholder=" " name="psw-repeat" id="psw-repeat" required>--%>
            <hr>
            <p> قوانین سایت را مطالعه کرده و قبول میکنم.<a href="#">شرایط و قوانین</a>.</p>
        

            <button type="submit" class="registerbtn">ورود به حساب کاربری</button>
        </div>

        <div class="container signin">
            <p>حساب کاربری ندارید؟<a href="#">ثبت نام</a>.</p>
        </div>
    </form>



    <style>
        body {
            font-family: Arial, Helvetica, sans-serif;
            background-color: black;
        }

        * {
            box-sizing: border-box;
        }


        .container {
            padding: 20px;
            background-color: white;
            direction:rtl;
        }


        input[type=text], input[type=password] {
            width: 100%;
            padding: 20px;
            margin: 5px 0 22px 0;
            display: inline-block;
            border: none;
            background: #f1f1f1;
        }

        input[type=text]:focus, input[type=password]:focus {
            background-color: #ddd;
            outline: none;
        }


        hr {
            border: 1px solid #f1f1f1;
            margin-bottom: 25px;
        }


        .registerbtn {
            background-color: #04AA6D;
            color: white;
            padding: 16px 20px;
            margin: 8px 0;
            border: none;
            cursor: pointer;
            width: 100%;
            opacity: 0.9;
        }

        .registerbtn:hover {
            opacity: 1;
        }


        a {
            color: dodgerblue;
        }


        .signin {
            background-color: #f1f1f1;
            text-align: center;
        }

    </style>
</body>
</html>
