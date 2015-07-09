<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student_Entry.aspx.cs" Inherits="University_Management_System.Student_Entry" %>

 <!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Student </title>
    <link href="../Style.css" rel="stylesheet" />

</head>

<body>
 <form id="form1" runat="server">
    <div class="wrapper">
        <header class="header">
             <asp:Button ID="homeButton" runat="server" Text="Home" OnClick="homeButton_Click" />
            <h2> Student Entry</h2>
            <asp:Button ID="departmentButton" runat="server" Text="Department Entry" OnClick="departmentButton_Click" />
        </header>
        <section class="section">
          
           <div class="entry">
               <br /><br />
               <asp:Label ID="Label1" CssClass="lable " runat="server" Text="Department: "></asp:Label>
               <asp:DropDownList ID="departmentDropDownList" CssClass="labal" runat="server" ></asp:DropDownList>
               <br /><br />
             <asp:Label ID="Label2" CssClass="lable" runat="server" Text="Name: "></asp:Label>
              &nbsp &nbsp   <asp:TextBox ID="nameTextBox" CssClass="lable" runat="server" Width="167px"></asp:TextBox>
               <br /><br />
               <asp:Label ID="Label3" CssClass="lable" runat="server" Text="Reg No:"></asp:Label>
              &nbsp  <asp:TextBox ID="regNoTextBox" CssClass="lable" runat="server" Width="167px"></asp:TextBox>
               <br /><br />
               <asp:Label ID="Label4" CssClass="lable" runat="server" Text="Address: "></asp:Label>
               <asp:TextBox ID="addressTextBox" CssClass="lable" runat="server" TextMode="MultiLine" Height="47px"></asp:TextBox>
               <br /><br />
               <asp:Button ID="saveButton" CssClass="lable" runat="server" Text="Save" OnClick="saveButton_Click" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Please wait...'" />
               <br /><br />
                                                                                                                

     </div>
            
            <div class="search">
                <h3>Search</h3>
                <asp:Label ID="Label5" runat="server" Text="Name: "></asp:Label>
               &nbsp <asp:TextBox ID="searchNameTextBox" runat="server"></asp:TextBox>
               &nbsp <asp:Button ID="searchButton" runat="server" Text="Search" OnClick="searchButton_Click" UseSubmitBehavior="false" OnClientClick="this.disabled='true';this.value='Searching....'" />
                <br />  <br />
                <asp:Label ID="Label6" runat="server" Text="Reg No: "></asp:Label>
                <asp:TextBox ID="searchrRegNoTextBox" runat="server"></asp:TextBox>
                   <br />  <br />
                <asp:GridView ID="searchGridView" runat="server"></asp:GridView>

                <br />
                <br />
                <br />
                <br />

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