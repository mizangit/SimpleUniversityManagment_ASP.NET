<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Department_Entry.aspx.cs" Inherits="University_Management_System.Department_Entry" %>

<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Department</title>
    <link href="../Style.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
     <div class="wrapper">
        <header class="header">
            <asp:Button ID="homeButton" runat="server" Text="Home" OnClick="homeButton_Click" />
            
            <h2> Department Entry </h2>
            <asp:Button ID="studentEntryButton" runat="server" Text="Student Entry" OnClick="studentEntryButton_Click" />
        </header>
        <section class="section2">
            <div>
                <table>     
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label3" runat="server" CssClass="SectionCenter" Text="Department Name: "></asp:Label>
                </td>
                <td class="auto-style1" >
                    <asp:TextBox ID="departmentNameTextBox" CssClass="SectionCenter" runat="server" OnTextChanged="departmentNameTextBox_TextChanged" AutoPostBack="true"></asp:TextBox>
                </td>
            </tr>
        </table>
        &nbsp
        <asp:Button ID="insertButton" CssClass="SectionCenter" runat="server" Text="Save" OnClick="insertButton_Click"  UseSubmitBehavior="false" OnClientClick="this.disabled='true'; this.value='Please wait...'" /> 
        &nbsp;&nbsp
            </div>
            <div>
            <br />
           <asp:GridView ID="departmentGridView" CssClass="SectionCenter" runat="server" ></asp:GridView>
        </div>
        </section>
       
            <footer class="footer" > 
            <div > 
                 <p > Developed by &copy MiSoft Ltd <br />Name: Md.Mizanur Rahman <br />
                   Phn: +8801915915882 </p> 
            </div>
            </footer>
    </div>
    
        
    </form>
</body>
</html>
