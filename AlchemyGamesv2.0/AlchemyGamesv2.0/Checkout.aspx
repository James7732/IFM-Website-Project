<%@ Page Title="" Language="C#" MasterPageFile="~/AlchemyGames.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="AlchemyGamesv2._0.Checkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- display invoice details below! -->
    <div runat="server" class="container">
    <br />
    <p id="cartDetails" runat="server">
    </p>
    <br />
    <input type="text" placeholder="Address" runat="server" id="orderaddress" required>
    <br />
    <br />
    <input type="text" placeholder="Suburb" runat="server" id="ordersuburb" required>
    <br />
    <br />
    <input type="text" placeholder="City" runat="server" id="ordercity" required>
    <br />
    <br />
    <input type="text" placeholder="Province" runat="server" id="orderprovince" required>
    <br />
    <br />
    <input type="number" placeholder="Postal Code" runat="server" id="ordercode" required>
    <br />
    <br />
    <asp:Button ID="btnCheckout" runat="server" Text="Check Out" OnClick="BtnCheckout_Click" OnClientClick="this.disabled=true;" UseSubmitBehavior="false"/>
    <br />
    <br />
    <asp:Button ID="btnHome" runat="server" Text="Return To Home" OnClick="BtnHome_Click" />
    <br />
    <br />
    </div>
    
</asp:Content>
