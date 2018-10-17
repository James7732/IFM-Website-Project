<%@ Page Title="" Language="C#" MasterPageFile="~/AlchemyGames.Master" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="AlchemyGamesv2._0.Pdf" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div runat="server" class="container">

        <br />

        <label> <font size"10"> Please make payment via EFT into the following bank account
                                and email the proof of payment to sales@alchemygames.co.za
                </font>  </label>

        <br />
        <br />

        <label> Bank : FNB </label>
        <br />
        <label> Account Name : Alchemy Games (Pty) Ltd </label>
        <br />
        <label> Account Number : 63791236582 </label>
        <br />
        <label> Account Type : Current </label>
        <br />
        <label> Branch Code : 250999 </label>
        <br />
        <label> Reference : Cutomer Username </label>
        <br />

        <a href="HomePage.aspx"> Click Here to Return to HomePage </a>

        <br />
        <br />

    </div>

</asp:Content>
