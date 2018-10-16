<%@ Page Title="" Language="C#" MasterPageFile="~/AlchemyGames.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="AlchemyGamesv2._0.Products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        function doReload(obj) {
            var cmbValue = document.getElementById(obj).value;
            __doPostBack(obj, cmbValue);
        }
    </script>
    <main class="main-content">
        <div class="container">
            <div class="page">
                <div class="filter-bar">
                    <h1 id="errmsg" runat="server"></h1>
							<div class="filter">
                                <span>
									<label>Type:</label>
									<select id="gameType" runat="server">
										<option value="D">Digital</option>
										<option value="H">Hard Copy</option>
									</select>
								</span>
								<span>
									<label>Sort by:</label>
									<select id="SortBy" runat="server">
										<option value="Pop">Popularity</option>
										<option value="High">Highest Price</option>
										<option value="Low">Lowest Price</option>
									</select>
								</span>
								<span>
									<label>Genre</label>
									<select id="GameGenre" runat="server" >
										<option value="none">Show All</option>
                                        <option value="FPS">FPS</option>
                                        <option value="RPG">RPG</option>
										<option value="Sport">Sport</option>
										<option value="Strategy">Strategy</option>
									</select>
								</span>
								<%--<span>
									<label>Show:</label>
									<select id="NumGames" runat="server">
										<option value="8">8</option>
										<option value="16">16</option>
										<option value="24">24</option>
									</select>
								</span>--%>
                                <asp:Button ID="btnFilter" runat="server" Text="Filter" OnClick="Page_Load" />
							</div>

							<%--<div class="pagination" id="pageNumsTop" runat="server">
								
							</div>--%>
                           </div>

                <div id="prodList" runat="server" class="product-list">
                   <h1 id="testMsg" runat="server"></h1>

                </div>

                <%--<div class="pagination-bar">
                    <div class="pagination" id="pageNumsBtm" runat="server">
                        <a href="#" class="page-number"><i class="fa fa-angle-left"></i></a>
                        <span class="page-number current">1</span>
                        <a href="#" class="page-number">2</a>
                        <a href="#" class="page-number">3</a>
                        <a href="#" class="page-number">...</a>
                        <a href="#" class="page-number">12</a>
                        <a href="#" class="page-number"><i class="fa fa-angle-right"></i></a>
                    </div>
                </div>--%>
            </div>
        </div>
    </main>
</asp:Content>
