<%@ Page Title="" Language="C#" MasterPageFile="~/AlchemyGames.Master" AutoEventWireup="true" CodeBehind="ProductDeletion.aspx.cs" Inherits="AlchemyGamesv2._0.ProuductDeletion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />

    <div runat="server" class="container">  

        <label> <font size="6"> <b> Delete A Product </b> </font> </label>

    </div>

    <br />

    <div runat="server" id="productlist" class="container">  </div>

    <br />

    <div runat="server" id="productdeletion" class="container">

        <input type="number" placeholder="ID" runat="server" id="productid">

        <br />
        <br />

        <asp:Button runat="server" class="button" Text="Delete" ID="btnDelete" OnClick="btnDelete_Click"/>

        <br />
        <br />

    </div>
    
    

    

</asp:Content>
