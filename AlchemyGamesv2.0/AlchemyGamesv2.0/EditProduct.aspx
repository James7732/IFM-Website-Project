<%@ Page Title="" Language="C#" MasterPageFile="~/AlchemyGames.Master" AutoEventWireup="true" CodeBehind="EditProduct.aspx.cs" Inherits="AlchemyGamesv2._0.EditAProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />

    <div runat="server" id="editname" class="container">
        
        <div runat="server" class="container" id="actualname"></div>

        <br />

         <input type="text" placeholder="Name" runat="server" id="newname">

         <br />
         <br />

         <asp:Button runat="server" class="button" Text="Update" ID="btnName" OnClick="btnName_Click"/>

    </div>

    <br />

    <div runat="server" id="editprice" class="container">
        
        <div runat="server" class="container" id="actualprice"></div>

        <br />

         <input type="number" placeholder="Price" runat="server" id="newprice">

         <br />
         <br />

         <asp:Button runat="server" class="button" Text="Update" ID="btnPrice" OnClick="btnPrice_Click"/>

    </div>

    <br />

    <div runat="server" id="editdescription" class="container">
        
        <div runat="server" class="container" id="actualdescription"></div>

        <br />

         <input type="text" placeholder="Description" runat="server" id="newdescription">

         <br />
         <br />

         <asp:Button runat="server" class="button" Text="Update" ID="btnDes" OnClick="btnDes_Click"/>

    </div>

    <br />

    <div runat="server" id="editimage" class="container">
        
        <div runat="server" class="container" id="actualimage"></div>

        <br />

         <input type="text" placeholder="Image Link" runat="server" id="newimage">

         <br />
         <br />

         <asp:Button runat="server" class="button" Text="Update" ID="btnImage" OnClick="btnImage_Click"/>

    </div>

    <br />

     <div runat="server" id="editstock" class="container">
        
        <div runat="server" class="container" id="actualstock"></div>

        <br />

         <input type="number" placeholder="Stock Levels" runat="server" id="newstock">

         <br />
         <br />

         <asp:Button runat="server" class="button" Text="Update" ID="btnStock" OnClick="btnStock_Click"/>

    </div>

    <br />

    <div runat="server" id="editplatform" class="container">
        
        <div runat="server" class="container" id="actualplatform"></div>

        <br />

         <input type="text" placeholder="Platform" runat="server" id="newplatform">
         <label> (PS, PS, Xbox, Nintendo) </label>

         <br />
         <br />

         <asp:Button runat="server" class="button" Text="Update" ID="btnPlatform" OnClick="btnPlatform_Click"/>

    </div>

    <br />

     <div runat="server" id="edittype" class="container">
        
        <div runat="server" class="container" id="actualtype"></div>

        <br />

         <input type="text" placeholder="Type" runat="server" id="newtype">
         <label> (H = Hardcopy D = Digital) </label>

         <br />
         <br />

         <asp:Button runat="server" class="button" Text="Update" ID="btnType" OnClick="btnType_Click"/>

    </div>

    <br />

     <div runat="server" id="editgenre" class="container">
        
        <div runat="server" class="container" id="actualgenre"></div>

        <br />

         <input type="text" placeholder="Genre" runat="server" id="newgenre">

         <br />
         <br />

         <asp:Button runat="server" class="button" Text="Update" ID="btnGenre" OnClick="btnGenre_Click"/>

    </div>

    <br />

</asp:Content>
