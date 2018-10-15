<%@ Page Title="" Language="C#" MasterPageFile="~/AlchemyGames.Master" AutoEventWireup="true" CodeBehind="UserAccount.aspx.cs" Inherits="AlchemyGamesv2._0.UserAccount" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div style="background-color: ivory">
    <div class="tab">
        <asp:Button ID="BtnInvoice" runat="server" Text="Invoices" CssClass="tabButton" OnClick="BtnInvoice_Click" />
        <asp:Button ID="BtnUserInfo" runat="server" Text="User Info" CssClass="tabButton" OnClick="BtnUserInfo_Click" />
    </div>

<div id="Invoices" runat="server" class="tabcontent">
            <div class="product-list" id="invList" runat="server">
                
            </div>
</div>

<div id="UserInfo" runat="server" class="tabcontent">
  <h3>User Info</h3>
  <p>User's info here</p>
    <div id="infoDisplay" runat="server">
        <div class="container">
        <h1 class="section-title"> Current Account Details</h1>
        <div id="accountInfo" runat="server">   </div>
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
    </div>
</div>
</div>
</asp:Content>
