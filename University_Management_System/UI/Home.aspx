<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="University_Management_System.Home" %>

<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Home</title>
    <link href="../Style.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <div class="wrapper">
        <header class="header">

            <h1> Home</h1>
        </header>

    <div class="home" >
    <div>
            <asp:Button ID="deparmtmentButton" runat="server" Text="Department Entry" OnClick="deparmtmentButton_Click" Height="50px" />
            <asp:Button ID="studentButton" runat="server" Text="Student Entry" OnClick="studentButton_Click" Height="50px" />


    </div>
    </div>
        <footer > 
            <div class="footer2"> 
                 <p > Developed by &copy MiSoft Ltd <br />Name: Md.Mizanur Rahman <br />
                   Phn: +8801915915882 </p> 
            </div>
        </footer>
        </div>

    </form>
</body>
</html>
