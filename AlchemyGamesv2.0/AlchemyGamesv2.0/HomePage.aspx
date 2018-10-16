<%@ Page Title="" Language="C#" MasterPageFile="~/AlchemyGames.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="AlchemyGamesv2._0.LandinPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="container" class="c-container">
        <div class="left-col" id="left-col">
            <div id="left-slider"></div>
        </div>
        <ul class="nav">
            <li class="slide-up">
                <a id="up_button" href="#"><</a>
            </li>
            <li class="slide-down">
                <a id="down_button" href="#">></a>
            </li>
        </ul>
        <script type="text/javascript" src="js/bannerslider.js"></script>
    </div>

    <main class="main-content" style="background-color: #1a374b">
        <div class="container">
            <div class="page">
                <section>
                    <header>
                        <h2 class="section-title"> <font size="10"> Welcome </font> </h2>

                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />

                         <p>
                            <font size="6">

                                Alchemy Games is not your average online gaming store. What makes us
                                different from the rest is that we offer games from the four major
                                platforms namely : PC, PlayStation, Xbox and Nintendo. All our
                                games are either available in a digital or hard copy.

                            </font>
                        </p>
                    </header>
                </section>
            </div>
        </div>
    </main>
</asp:Content>
