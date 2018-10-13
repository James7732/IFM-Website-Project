<%@ Page Title="" Language="C#" MasterPageFile="~/AlchemyGames.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="AlchemyGamesv2._0.Products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="main-content">
        <div class="container">
            <div class="page">
                <div class="filter-bar">
                    <h1 id="errmsg" runat="server"></h1>
							<div class="filter">
								<span>
									<label>Sort by:</label>
									<select name="#">
										<option value="#">Popularity</option>
										<option value="#">Highest Rating</option>
										<option value="#">Lowest price</option>
									</select>
								</span>
								<span>
									<label>Genre</label>
									<select name="#">
										<option value="#">Show All</option>
										<option value="#">Action</option>
										<option value="#">Racing</option>
										<option value="#">Strategy</option>
									</select>
								</span>
								<span>
									<label>Show:</label>
									<select name="#">
										<option value="#">8</option>
										<option value="#">16</option>
										<option value="#">24</option>
									</select>
								</span>
							</div>

							<div class="pagination">
								<a href="#" class="page-number"><i class="fa fa-angle-left"></i></a>
								<span class="page-number current">1</span>
								<a href="#" class="page-number">2</a>
								<a href="#" class="page-number">3</a>
								<a href="#" class="page-number">...</a>
								<a href="#" class="page-number">12</a>
								<a href="#" class="page-number"><i class="fa fa-angle-right"></i></a>
							</div>

                <div id="prodList" runat="server" class="product-list">
                   <h1 id="testMsg" runat="server"></h1>

                </div>

                <div class="pagination-bar">
                    <div class="pagination">
                        <a href="#" class="page-number"><i class="fa fa-angle-left"></i></a>
                        <span class="page-number current">1</span>
                        <a href="#" class="page-number">2</a>
                        <a href="#" class="page-number">3</a>
                        <a href="#" class="page-number">...</a>
                        <a href="#" class="page-number">12</a>
                        <a href="#" class="page-number"><i class="fa fa-angle-right"></i></a>
                    </div>
                </div>
            </div>
        </div>
    </main>
</asp:Content>
