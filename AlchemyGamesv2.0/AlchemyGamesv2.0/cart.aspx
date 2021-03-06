﻿<%@ Page Title="" Language="C#" MasterPageFile="~/AlchemyGames.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="AlchemyGamesv2._0.cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="main-content">
        <div class="container">
            <div class="page">

                <table class="cart" style="margin-top: 5%;">
                    <thead>
                        <tr>
                            <th class="product-name">Product Name</th>
                            <th class="product-price">Price</th>
                            <th class="product-qty">Quantity</th>
                            <th class="product-total">Remove</th>
                            <th class="action"></th>
                        </tr>
                    </thead>
                    <tbody id="cartDisplay" runat="server">
                        
                        <%--<tr>
                            <td class="product-name">
                                <div class="product-thumbnail">
                                    <img src="dummy/cart-thumb-1.jpg" alt="">
                                </div>
                                <div class="product-detail">
                                    <h3 class="product-title">GTA V</h3>
                                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Iure nobis architecto dolorum, alias laborum sit odit, saepe expedita similique eius enim quasi obcaecati voluptates, autem eveniet ratione veniam omnis modi.</p>
                                </div>
                            </td>
                            <td class="product-price">$150.00</td>
                            <td class="product-qty">
                                <select name="#">
                                    <option value="1">1</option>
                                    <option value="2">2</option>
                                    <option value="3">3</option>
                                </select>
                            </td>
                            <td class="product-total">$150.00</td>
                            <td class="action"><a href="#"><i class="fa fa-times"></i></a></td>
                        </tr>
                        <tr>
                            <td class="product-name">
                                <div class="product-thumbnail">
                                    <img src="dummy/cart-thumb-2.jpg" alt="">
                                </div>
                                <div class="product-detail">
                                    <h3 class="product-title">Big Game Hunter</h3>
                                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Iure nobis architecto dolorum, alias laborum sit odit, saepe expedita similique eius enim quasi obcaecati voluptates, autem eveniet ratione veniam omnis modi.</p>
                                </div>
                            </td>
                            <td class="product-price">$150.00</td>
                            <td class="product-qty">
                                <select name="#">
                                    <option value="1">1</option>
                                    <option value="2">2</option>
                                    <option value="3">3</option>
                                </select>
                            </td>
                            <td class="product-total">$150.00</td>
                            <td class="action"><a href="#"><i class="fa fa-times"></i></a></td>
                        </tr>
                        <tr>
                            <td class="product-name">
                                <div class="product-thumbnail">
                                    <img src="dummy/cart-thumb-3.jpg" alt="">
                                </div>
                                <div class="product-detail">
                                    <h3 class="product-title">Meal Gear Solid</h3>
                                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Iure nobis architecto dolorum, alias laborum sit odit, saepe expedita similique eius enim quasi obcaecati voluptates, autem eveniet ratione veniam omnis modi.</p>
                                </div>
                            </td>
                            <td class="product-price">$150.00</td>
                            <td class="product-qty">
                                <select name="#">
                                    <option value="1">1</option>
                                    <option value="2">2</option>
                                    <option value="3">3</option>
                                </select>
                            </td>
                            <td class="product-total">$150.00</td>
                            <td class="action"><a href="#"><i class="fa fa-times"></i></a></td>
                        </tr>--%>
                    </tbody>
                </table>
                <!-- .cart -->

                <div class="cart-total" id="cartTotal" runat="server">
                    <p id="subTotal" runat="server"> </p>
                    <p><strong>Shipment:</strong> R50.00</p>
                    <p id="voucherDiscount" runat="server" visible="false"></p>
                    <p class="total" id="total" runat="server"></p>
                    <p>
                        <a href="HomePage.aspx" class="button muted">Continue Shopping</a>
                        <asp:Button ID="btnCheckout" runat="server" Text="Check out" OnClick="BtnCheckout_Click" />
                    </p>
                </div>
                <!-- .cart-total -->
                <div id="divVoucher" runat="server">
                <asp:Label ID="label1" runat="server"><font size="4">Enter Voucher Code</font></asp:Label><br>
                <input type="text" placeholder="Voucher Code" runat="server" id="vCode">
                <asp:Button ID="btnVoucher" runat="server" Text="Submit Voucher Code" OnClick="BtnVoucher_Click" />
                <p id="voucherErr" runat="server" visible="false"> </p>
                </div>
            </div>
        </div>
        <!-- .container -->
    </main>
    <!-- .main-content -->
</asp:Content>
