<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="comingsoonTest.aspx.cs" Inherits="WebApplication2.Pages.comingsoon" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    ><div class="bgimg">
        <div class="topleft">
            <p>ثبت آگهی</p>
        </div>
        <div class="middle">
            <h1>coming soon به زودی</h1>
            <
            <p>30 days left</p>
        </div>
        <div class="bottomleft">
            <p></p>
        </div>
    </div>

    <style>
        body, html {
            height: 100%;
            margin: 0;
        }

        .bgimg {
            background-image: url('https://www.rhsmith.umd.edu/sites/default/files/research/2021/how-covid-19-has-changed-the-retail-experience-forever.jpg');
            height: 100%;
            background-position: center;
            background-size: cover;
            position: relative;
            color: white;
            font-family: "Courier New", Courier, monospace;
            font-size: 25px;
        }

        .topleft {
            position: absolute;
            top: 0;
            left: 16px;
        }

        .bottomleft {
            position: absolute;
            bottom: 0;
            left: 16px;
        }

        .middle {
            position: absolute;
            top: 50%;
            left: 50%;
            transform: translate(-50%, -50%);
            text-align: center;
        }

        hr {
            margin: auto;
            width: 40%;
        }
    </style>

</body>
</html>
