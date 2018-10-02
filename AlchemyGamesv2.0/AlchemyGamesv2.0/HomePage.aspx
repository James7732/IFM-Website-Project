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
                        <h2 class="section-title">New Products</h2>
                        <a href="#" class="all">Show All</a>
                    </header>

                    <div class="product-list">
                        <div class="product">
                            <div class="inner-product">
                                <div class="figure-image">
                                    <a href="Single.aspx">
                                        <img src="dummy/game-1.jpg" alt="Game 1"></a>
                                </div>
                                <h3 class="product-title"><a href="Single.aspx">Alpha Protocol</a></h3>
                                <small class="price">$19.00</small>
                                <p>Lorem ipsum dolor sit consectetur adipiscing elit do eiusmod tempor...</p>
                                <a href="cart.aspx" class="button">Add to cart</a>
                                <a href="Single.aspx" class="button muted">Read Details</a>
                            </div>
                        </div>
                        <!-- .product -->

                        <div class="product">
                            <div class="inner-product">
                                <div class="figure-image">
                                    <a href="Single.aspx">
                                        <img src="dummy/game-2.jpg" alt="Game 2"></a>
                                </div>
                                <h3 class="product-title"><a href="Single.aspx">Grand Theft Auto V</a></h3>
                                <small class="price">$19.00</small>
                                <p>Lorem ipsum dolor sit consectetur adipiscing elit do eiusmod tempor...</p>
                                <a href="cart.aspx" class="button">Add to cart</a>
                                <a href="Single.aspx" class="button muted">Read Details</a>
                            </div>
                        </div>
                        <!-- .product -->

                        <div class="product">
                            <div class="inner-product">
                                <div class="figure-image">
                                    <a href="Single.aspx">
                                        <img src="dummy/game-3.jpg" alt="Game 3"></a>
                                </div>
                                <h3 class="product-title"><a href="Single.aspx">Need for Speed rivals</a></h3>
                                <small class="price">$19.00</small>
                                <p>Lorem ipsum dolor sit consectetur adipiscing elit do eiusmod tempor...</p>
                                <a href="cart.aspx" class="button">Add to cart</a>
                                <a href="Single.aspx" class="button muted">Read Details</a>
                            </div>
                        </div>
                        <!-- .product -->

                        <div class="product">
                            <div class="inner-product">
                                <div class="figure-image">
                                    <a href="Single.aspx">
                                        <img src="dummy/game-4.jpg" alt="Game 4"></a>
                                </div>
                                <h3 class="product-title"><a href="Single.aspx">Big game hunter</a></h3>
                                <small class="price">$19.00</small>
                                <p>Lorem ipsum dolor sit consectetur adipiscing elit do eiusmod tempor...</p>
                                <a href="cart.aspx" class="button">Add to cart</a>
                                <a href="Single.aspx" class="button muted">Read Details</a>
                            </div>
                        </div>
                        <!-- .product -->

                    </div>
                    <!-- .product-list -->

                </section>

                <section>
                    <header>
                        <h2 class="section-title">Promotion</h2>
                        <a href="#" class="all">Show All</a>
                    </header>

                    <div class="product-list">

                        <div class="product">
                            <div class="inner-product">
                                <div class="figure-image">
                                    <a href="Single.aspx">
                                        <img src="dummy/game-5.jpg" alt="Game 1"></a>
                                </div>
                                <h3 class="product-title"><a href="Single.aspx">Watch Dogs</a></h3>
                                <small class="price">$19.00</small>
                                <p>Lorem ipsum dolor sit consectetur adipiscing elit do eiusmod tempor...</p>
                                <a href="cart.aspx" class="button">Add to cart</a>
                                <a href="Single.aspx" class="button muted">Read Details</a>
                            </div>
                        </div>
                        <!-- .product -->


                        <div class="product">
                            <div class="inner-product">
                                <div class="figure-image">
                                    <a href="Single.aspx">
                                        <img src="dummy/game-6.jpg" alt="Game 2"></a>
                                </div>
                                <h3 class="product-title"><a href="Single.aspx">Mortal Kombat X</a></h3>
                                <small class="price">$19.00</small>
                                <p>Lorem ipsum dolor sit consectetur adipiscing elit do eiusmod tempor...</p>
                                <a href="cart.aspx" class="button">Add to cart</a>
                                <a href="Single.aspx" class="button muted">Read Details</a>
                            </div>
                        </div>
                        <!-- .product -->


                        <div class="product">
                            <div class="inner-product">
                                <div class="figure-image">
                                    <a href="single.aspx">
                                        <img src="dummy/game-7.jpg" alt="Game 3"></a>
                                </div>
                                <h3 class="product-title"><a href="#">Metal Gear Solid V</a></h3>
                                <small class="price">$19.00</small>
                                <p>Lorem ipsum dolor sit consectetur adipiscing elit do eiusmod tempor...</p>
                                <a href="cart.aspx" class="button">Add to cart</a>
                                <a href="Single.aspx" class="button muted">Read Details</a>
                            </div>
                        </div>
                        <!-- .product -->


                        <div class="product">
                            <div class="inner-product">
                                <div class="figure-image">
                                    <a href="single.aspx">
                                        <img src="dummy/game-8.jpg" alt="Game 4"></a>
                                </div>
                                <h3 class="product-title"><a href="Single.aspx">Nascar '14</a></h3>
                                <small class="price">$19.00</small>
                                <p>Lorem ipsum dolor sit consectetur adipiscing elit do eiusmod tempor...</p>
                                <a href="cart.aspx" class="button">Add to cart</a>
                                <a href="Single.aspx" class="button muted">Read Details</a>
                            </div>
                        </div>
                        <!-- .product -->

                    </div>
                    <!-- .product-list -->

                </section>
            </div>
        </div>
        <!-- .container -->
    </main>
    <!-- .main-content -->
</asp:Content>
