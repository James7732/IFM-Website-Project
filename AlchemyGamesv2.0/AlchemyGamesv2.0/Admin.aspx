<%@ Page Title="" Language="C#" MasterPageFile="~/AlchemyGames.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="AlchemyGamesv2._0.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="container">
    <br />
    <div class="tab">
        <br />
        <asp:Button ID="BtnEditProd" runat="server" Text="Edit Product" CssClass="tabButton" OnClick="BtnEditProd_Click" />
        <br />
        <br />
        <asp:Button ID="BtnAddProd" runat="server" Text="Add Product" CssClass="tabButton" OnClick="BtnAddProd_Click" />
        <br />
        <br />
        <asp:Button ID="BtnDeleteProd" runat="server" Text="Delete Product" CssClass="tabButton" OnClick="BtnDeleteProd_Click" />
        <br />
        <br />
        <asp:Button ID="BtnReport" runat="server" Text="Reports" CssClass="tabButton" OnClick="BtnReport_Click" />
    </div>
    <%--=========================================================--%>
    <div id="editProd" runat="server" class="tabcontent">
    <br />
            
    </div>
    <%--=========================================================--%>
    <div id="addProd" runat="server" class="tabcontent">
    <br />
            
    </div>
    <%--=========================================================--%>
    <div id="deleteProd" runat="server" class="tabcontent">
    <br />
            
    </div>
    <%--=========================================================--%>
    <div id="report" runat="server" class="tabcontent">
    <br />
            <div>
            <p id="mostSold" runat="server" style="color: red"></p>
            <asp:GridView ID="GridViewSold" runat="server">
            </asp:GridView>

            <br />

            <asp:GridView ID="GridViewRegistered" runat="server">
            </asp:GridView>

            <br />

            <asp:GridView ID="GridViewSalesPerDay" runat="server">
            </asp:GridView>

            <br />

            <label> Total Sales Per Month </label>

            <br />

            <input type="text" placeholder="Enter Month" runat="server" id="salesmonth"/>

            <asp:Button runat="server" Text="Submit" ID="btnMonth" OnClick="btnMonth_Click"/>

            <br />

            <label> Sales:  </label>

            <div runat="server" class="container" id="salespermonth"></div>

        </div>
    </div>
    <%--=========================================================--%>
</div>
</asp:Content>
