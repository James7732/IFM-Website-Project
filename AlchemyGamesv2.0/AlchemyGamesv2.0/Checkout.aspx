<%@ Page Title="" Language="C#" MasterPageFile="~/AlchemyGames.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="AlchemyGamesv2._0.Checkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- display invoice details below! -->
    <p id="cartDetails" runat="server">
    </p>
    <asp:Button ID="btnCheckout" runat="server" Text="Check out" OnClick="BtnCheckout_Click" />
</asp:Content>
