<%@ Page Title="" Language="C#" MasterPageFile="~/AlchemyGames.Master" AutoEventWireup="true" CodeBehind="Single.aspx.cs" Inherits="AlchemyGamesv2._0.ProductPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="main-content">
        <div class="container" style="margin-top: 10%;">
            <div class="page">


                <div>
                    <div runat="server" class="cheader" id="iheader">

                    </div>
                    <div class="entry-content">
                    <div class="row">
                    <div class="col-sm-6 col-md-8">
                    <div class="addtocart-bar">
                         <label for="#">Quantity</label>
                         <select id="prodQuant" runat="server" name="prodQuant">
                            <option value="1">1</option>
                            <option value="2">2</option>
                            <option value="3">3</option>
                         </select>
                        <asp:Button ID="addToCart" runat="server" Text="Add To Cart" OnClick="AddToCart_Click" />
                    </div>
                    </div>
                    </div>
                    </div>
                </div>

               

                
                <%--<div class="entry-content">
                    <div class="row">
                        <div class="col-sm-6 col-md-4">
                            <div class="product-images">
                                <figure class="large-image">
                                    <a href="dummy/image-1.jpg">
                                        <img src="dummy/single-game-cover.jpg" alt=""></a>
                                </figure>

                            </div>
                        </div>
                        <div class="col-sm-6 col-md-8">
                            <h2 class="entry-title">Need for Speed Rivals</h2>
                            <small class="price">$190.00</small>

                            <p>descr</p>
                            <p>descr</p>
                            <p>descr</p>

                            <div class="addtocart-bar">
                                    <label for="#">Quantity</label>
                                    <select id="prodQuant" runat="server" name="prodQuant">
                                        <option value="1">1</option>
                                        <option value="2">2</option>
                                        <option value="3">3</option>
                                    </select>
                                    <p id="dispQuant" runat="server">Value: </p>
                                    <input type="submit" value="Add to cart">

                                
                                <div class="social-links square">
                                    <strong>Share</strong>
                                    <a href="#" class="facebook"><i class="fa fa-facebook"></i></a>
                                    <a href="#" class="twitter"><i class="fa fa-twitter"></i></a>
                                    <a href="#" class="google-plus"><i class="fa fa-google-plus"></i></a>
                                    <a href="#" class="pinterest"><i class="fa fa-pinterest"></i></a>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>--%>

                
                <%--<section>
                    <header>
                        <h2 class="section-title">Similiar Product</h2>
                    </header>
                    <div class="product-list">
                        <div class="product">
                            <div class="inner-product">
                                <div class="figure-image">
                                    <img src="dummy/game-1.jpg" alt="Game 1">
                                </div>
                                <h3 class="product-title"><a href="#">Alpha Protocol</a></h3>
                                <small class="price">$20.00</small>
                                <p>Lorem ipsum dolor sit consectetur adipiscing elit do eiusmod tempor...</p>
                                <a href="#" class="button">Add to cart</a>
                                <a href="#" class="button muted">Read Details</a>
                            </div>
                        </div>

                        <div class="product">
                            <div class="inner-product">
                                <div class="figure-image">
                                    <img src="dummy/game-2.jpg" alt="Game 2">
                                </div>
                                <h3 class="product-title"><a href="#">Grand Theft Auto V</a></h3>
                                <small class="price">$20.00</small>
                                <p>Lorem ipsum dolor sit consectetur adipiscing elit do eiusmod tempor...</p>
                                <a href="#" class="button">Add to cart</a>
                                <a href="#" class="button muted">Read Details</a>
                            </div>
                        </div>

                        <div class="product">
                            <div class="inner-product">
                                <div class="figure-image">
                                    <img src="dummy/game-3.jpg" alt="Game 3">
                                </div>
                                <h3 class="product-title"><a href="#">Need for Speed rivals</a></h3>
                                <small class="price">$20.00</small>
                                <p>Lorem ipsum dolor sit consectetur adipiscing elit do eiusmod tempor...</p>
                                <a href="#" class="button">Add to cart</a>
                                <a href="#" class="button muted">Read Details</a>
                            </div>
                        </div>

                        <div class="product">
                            <div class="inner-product">
                                <div class="figure-image">
                                    <img src="dummy/game-4.jpg" alt="Game 4">
                                </div>
                                <h3 class="product-title"><a href="#">Big game hunter</a></h3>
                                <small class="price">$20.00</small>
                                <p>Lorem ipsum dolor sit consectetur adipiscing elit do eiusmod tempor...</p>
                                <a href="#" class="button">Add to cart</a>
                                <a href="#" class="button muted">Read Details</a>
                            </div>
                        </div>

                    </div>
                </section>--%>
                

            </div>
        </div>
    </main>
</asp:Content>
