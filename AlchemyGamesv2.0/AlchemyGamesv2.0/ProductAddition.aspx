<%@ Page Title="" Language="C#" MasterPageFile="~/AlchemyGames.Master" AutoEventWireup="true" CodeBehind="ProductAddition.aspx.cs" Inherits="AlchemyGamesv2._0.ProductAddition" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />

    <div runat="server" id="productdeletion" class="container"> 

        <label> <font size="6"> <b> Add A Product </b> </font> </label>

        <br />
        <br />

        <input type="text" placeholder="Name" runat="server" id="productname" required>

        <br />
        <br />

        <input type="number" placeholder="Price" runat="server" id="productprice" required>

        <br />
        <br />

        <input type="text" placeholder="Description" runat="server" id="productdescription" required>

        <br />
        <br />

        <input type="text" placeholder="Image Link" runat="server" id="productimage" required>

        <br />
        <br />

        <input type="number" placeholder="Stock Levels" runat="server" id="productstock" required>

        <br />
        <br />

        <input type="text" placeholder="Platform" runat="server" id="productplatform" required>
        <label> (PS, PS, Xbox, Nintendo) </label>

        <br />
        <br />

        <input type="text" placeholder="Type" runat="server" id="producttype" required>
        <label> (H = Hardcopy D = Digital) </label>

        <br />
        <br />

        <input type="text" placeholder="Genre" runat="server" id="productgenre" required>

        <br />
        <br />

        <asp:Button runat="server" class="button" Text="Add" ID="btnAdd" OnClick="btnAdd_Click"/>

        <br />
        <br />

    </div>

</asp:Content>
