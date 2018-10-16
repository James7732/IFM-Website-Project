<%@ Page Title="" Language="C#" MasterPageFile="~/AlchemyGames.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="AlchemyGamesv2._0.Checkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- display invoice details below! -->
    <div runat="server" class="container">
    <br />
    <p id="cartDetails" runat="server">
    </p>
    <asp:Button ID="btnCheckout" runat="server" Text="Check Out" OnClick="BtnCheckout_Click" />
    <br />
    <br />
    </div>
    
</asp:Content>
