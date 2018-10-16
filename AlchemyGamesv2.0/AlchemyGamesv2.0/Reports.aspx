<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reports.aspx.cs" Inherits="AlchemyGamesv2._0.Reports" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
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
    </form>
</body>
</html>
