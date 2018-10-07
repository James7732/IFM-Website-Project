using System;

namespace AlchemyGamesv2._0
{
    public partial class AlchemyGames : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Admin"] != null)
            {
                if (!(bool)Session["Admin"])
                {
                    login.Visible = false;
                    logout.Visible = true;
                    adminPage.Visible = false;
                    account.Visible = true;
                } else
                {
                    logout.Visible = true;
                    login.Visible = false;
                    adminPage.Visible = true;
                    account.Visible = true;
                }
            } else
            {
                login.Visible = true;
                logout.Visible = false;
                register.Visible = true;
                adminPage.Visible = false;
                account.Visible = false;
            }

            if (Session["currentPage"] == null)
            {
                String nav = "<li runat =\"server\" id=\"HomeNavBtn\" class=\"menu-item home current-menu-item\"><a href =\"HomePage.aspx\" ><i class=\"icon-home\"></i></a></li>";
                nav += "<li runat=\"server\" id=\"PCNavBtn\" class=\"menu-item\"><a href=\"Products.aspx?ID=PC\">PC</a></li>";
                nav += "<li runat=\"server\" id=\"PSNavBtn\" class=\"menu-item\"><a href=\"Products.aspx?ID=PS\">PlayStation</a></li>";
                nav += "<li runat=\"server\" id=\"xboxNavBtn\" class=\"menu-item\"><a href=\"Products.aspx?ID=Xbox\">Xbox</a></li>";
                nav += "<li runat=\"server\" id=\"nintendoNavBtn\" class=\"menu-item\"><a href=\"Products.aspx?ID=Nintendo\">Nintendo</a></li>";

                navMenu.InnerHtml = nav;
            } else if (Session["currentPage"].Equals("PC"))
            {
                String nav = "<li runat =\"server\" id=\"HomeNavBtn\" class=\"menu-item home\"><a href =\"HomePage.aspx\" ><i class=\"icon-home\"></i></a></li>";
                nav += "<li runat=\"server\" id=\"PCNavBtn\" class=\"menu-item current-menu-item\"><a href=\"Products.aspx?ID=PC\">PC</a></li>";
                nav += "<li runat=\"server\" id=\"PSNavBtn\" class=\"menu-item\"><a href=\"Products.aspx?ID=PS\">PlayStation</a></li>";
                nav += "<li runat=\"server\" id=\"xboxNavBtn\" class=\"menu-item\"><a href=\"Products.aspx?ID=Xbox\">Xbox</a></li>";
                nav += "<li runat=\"server\" id=\"nintendoNavBtn\" class=\"menu-item\"><a href=\"Products.aspx?ID=Nintendo\">Nintendo</a></li>";

                navMenu.InnerHtml = nav;
            } else if (Session["currentPage"].Equals("PS"))
            {
                String nav = "<li runat =\"server\" id=\"HomeNavBtn\" class=\"menu-item home\"><a href =\"HomePage.aspx\" ><i class=\"icon-home\"></i></a></li>";
                nav += "<li runat=\"server\" id=\"PCNavBtn\" class=\"menu-item\"><a href=\"Products.aspx?ID=PC\">PC</a></li>";
                nav += "<li runat=\"server\" id=\"PSNavBtn\" class=\"menu-item current-menu-item\"><a href=\"Products.aspx?ID=PS\">PlayStation</a></li>";
                nav += "<li runat=\"server\" id=\"xboxNavBtn\" class=\"menu-item\"><a href=\"Products.aspx?ID=Xbox\">Xbox</a></li>";
                nav += "<li runat=\"server\" id=\"nintendoNavBtn\" class=\"menu-item\"><a href=\"Products.aspx?ID=Nintendo\">Nintendo</a></li>";

                navMenu.InnerHtml = nav;
            } else if (Session["currentPage"].Equals("xbox"))
            {
                String nav = "<li runat =\"server\" id=\"HomeNavBtn\" class=\"menu-item home\"><a href =\"HomePage.aspx\" ><i class=\"icon-home\"></i></a></li>";
                nav += "<li runat=\"server\" id=\"PCNavBtn\" class=\"menu-item\"><a href=\"Products.aspx?ID=PC\">PC</a></li>";
                nav += "<li runat=\"server\" id=\"PSNavBtn\" class=\"menu-item\"><a href=\"Products.aspx?ID=PS\">PlayStation</a></li>";
                nav += "<li runat=\"server\" id=\"xboxNavBtn\" class=\"menu-item current-menu-item\"><a href=\"Products.aspx?ID=Xbox\">Xbox</a></li>";
                nav += "<li runat=\"server\" id=\"nintendoNavBtn\" class=\"menu-item\"><a href=\"Products.aspx?ID=Nintendo\">Nintendo</a></li>";

                navMenu.InnerHtml = nav;
            } else if (Session["currentPage"].Equals("nintendo"))
            {
                String nav = "<li runat =\"server\" id=\"HomeNavBtn\" class=\"menu-item home\"><a href =\"HomePage.aspx\" ><i class=\"icon-home\"></i></a></li>";
                nav += "<li runat=\"server\" id=\"PCNavBtn\" class=\"menu-item\"><a href=\"Products.aspx?ID=PC\">PC</a></li>";
                nav += "<li runat=\"server\" id=\"PSNavBtn\" class=\"menu-item\"><a href=\"Products.aspx?ID=PS\">PlayStation</a></li>";
                nav += "<li runat=\"server\" id=\"xboxNavBtn\" class=\"menu-item\"><a href=\"Products.aspx?ID=Xbox\">Xbox</a></li>";
                nav += "<li runat=\"server\" id=\"nintendoNavBtn\" class=\"menu-item current-menu-item\"><a href=\"Products.aspx?ID=Nintendo\">Nintendo</a></li>";

                navMenu.InnerHtml = nav;
            } else if(Session["currentPage"].Equals("home"))
            {
                String nav = "<li runat =\"server\" id=\"HomeNavBtn\" class=\"menu-item home current-menu-item\"><a href =\"HomePage.aspx\" ><i class=\"icon-home\"></i></a></li>";
                nav += "<li runat=\"server\" id=\"PCNavBtn\" class=\"menu-item\"><a href=\"Products.aspx?ID=PC\">PC</a></li>";
                nav += "<li runat=\"server\" id=\"PSNavBtn\" class=\"menu-item\"><a href=\"Products.aspx?ID=PS\">PlayStation</a></li>";
                nav += "<li runat=\"server\" id=\"xboxNavBtn\" class=\"menu-item\"><a href=\"Products.aspx?ID=Xbox\">Xbox</a></li>";
                nav += "<li runat=\"server\" id=\"nintendoNavBtn\" class=\"menu-item\"><a href=\"Products.aspx?ID=Nintendo\">Nintendo</a></li>";

                navMenu.InnerHtml = nav;
            }
        }
    }
}