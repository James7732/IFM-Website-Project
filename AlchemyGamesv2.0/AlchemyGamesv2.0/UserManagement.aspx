<%@ Page Title="" Language="C#" MasterPageFile="~/AlchemyGames.Master" AutoEventWireup="true" CodeBehind="UserManagement.aspx.cs" Inherits="AlchemyGamesv2._0.UserManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <br>
        <h1 class="section-title"> New Account Details</h1>
        <h3> Fill out the fields you wish to change</h3>
        <asp:Label ID="label1" runat="server"><font size="5">Email</font></asp:Label>
        <br>
        <input type="email" placeholder="New email address" runat="server" id="email">
        <br>
        <asp:Label ID="label2" runat="server"><font size="5">Password</font></asp:Label>
        <br>
        <input type="password" placeholder="New password" runat="server" id="password">
        <br>
        <asp:Label ID="label7" runat="server"><font size="5">Confirm Password</font></asp:Label>
        <br>
        <input type="password" placeholder="Confirm new password" runat="server" id="cPassword">
        <br>
        <asp:Label ID="label3" runat="server"><font size="5">First Name</font></asp:Label>
        <br>
        <input type="text" placeholder="New first name" runat="server" id="fName">
        <br>
        <asp:Label ID="label4" runat="server"><font size="5">Surname</font></asp:Label>
        <br>
        <input type="text" placeholder="New surname" runat="server" id="sName">
        <br>
        <asp:Label ID="label5" runat="server"><font size="5">Phone</font></asp:Label>
        <br> 
        <input type="number" placeholder="New phone number" runat="server" id="pNumber">
        <br>
        <asp:Label ID="label6" runat="server"><font size="5">Username</font></asp:Label>
        <br>
        <input type="text" placeholder="New username" runat="server" id="uName">
        <br>
        <br>
        <button id="btnChange" type="submit" onserverclick="Change_Click" runat="server">
		 Submit Details
		</button>
        <br>
        <div id="changeMsg" runat="server">   </div>
     </div>
            
</asp:Content>
