<%@ Page Title="" Language="C#" MasterPageFile="~/AlchemyGames.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="AlchemyGamesv2._0.Admin" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
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
        <div runat="server" id="editList" class="container">  </div>
    <div id="editPage" runat="server">
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
    </div>
    </div>
    <%--=========================================================--%>
    <div id="addProd" runat="server" class="tabcontent">
        <br />

    <div runat="server" id="productdeletion" class="container"> 

        <label> <font size="6"> <b> Add A Product </b> </font> </label>

        <br />
        <br />

        <input type="text" placeholder="Name" runat="server" id="productname">

        <br />
        <br />

        <input type="number" placeholder="Price" runat="server" id="productprice">

        <br />
        <br />

        <input type="text" placeholder="Description" runat="server" id="productdescription">

        <br />
        <br />

        <input type="text" placeholder="Image Link" runat="server" id="productimage">

        <br />
        <br />

        <input type="number" placeholder="Stock Levels" runat="server" id="productstock">

        <br />
        <br />

        <input type="text" placeholder="Platform" runat="server" id="productplatform">
        <label> (PS, PS, Xbox, Nintendo) </label>

        <br />
        <br />

        <input type="text" placeholder="Type" runat="server" id="producttype">
        <label> (H = Hardcopy D = Digital) </label>

        <br />
        <br />

        <input type="text" placeholder="Genre" runat="server" id="productgenre">

        <br />
        <br />

        <asp:Button runat="server" class="button" Text="Add" ID="btnAdd" OnClick="btnAdd_Click"/>

        <br />
        <br />

    </div>        
    </div>
    <%--=========================================================--%>
    <div id="deleteProd" runat="server" class="tabcontent">
        <div runat="server" class="container">  

        <label> <font size="6"> <b> Delete A Product </b> </font> </label>

    </div>

    <br />

    <div runat="server" id="productlist" class="container">  </div>

    <br />

    <div runat="server" id="Div1" class="container">

        <input type="number" placeholder="ID" runat="server" id="productid">

        <br />
        <br />

        <asp:Button runat="server" class="button" Text="Delete" ID="btnDelete" OnClick="btnDelete_Click"/>

        <br />
        <br />

    </div>
            
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

            <asp:GridView ID="CopiesPerGame" runat="server">
               <%-- <Columns>
                    <asp:BoundField DataField="GameID" FooterText="Game ID"/>
                    <asp:BoundField DataField="GameName" FooterText="Game Name"/>
                    <asp:BoundField DataField="CopiesSold" FooterText="Copies Sold"/>
                </Columns>--%>
            </asp:GridView>

            <br/>

            <label> Total Sales Per Month </label>

            <br />

            <input type="text" placeholder="Enter Month Number" runat="server" id="salesmonth"/>

            <asp:Button runat="server" Text="Submit" ID="btnMonth" OnClick="btnMonth_Click"/>

            <br />

            <label> Sales:  </label>

            <div runat="server" class="container" id="salespermonth"></div>

              

                <%--<asp:Chart ID="MonthUsers" runat="server">
                    <Titles>
                        <asp:Title Text="Total Users Per Day of Month">
                        </asp:Title>
                    </Titles>
                    <Series>
                        <asp:Series Name="DaysOfMonth" ChartType="Column" ChartArea="ChartArea1">
                        </asp:Series>
                    </Series>
                    <ChartAreas>
                        <asp:ChartArea Name="ChartArea1">
                            <AxisX Title="Game">
                            </AxisX>
                            <AxisY Title="Total copies sold">
                            </AxisY>
                            </asp:ChartArea>
                    </ChartAreas>
                </asp:Chart>--%>
        </div>
    </div>
    <%--=========================================================--%>
</div>
</asp:Content>
