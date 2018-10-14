using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlchemyGamesv2._0
{
    public partial class ProductAddition : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            var database = new AlchemyLinkDataContext();

            var NewProduct = new Product
            {
                Name = productname.Value,
                Price = Convert.ToDecimal(productprice.Value),
                Description = productdescription.Value,
                ImageLink = productimage.Value,
                StockLevels = Convert.ToInt32(productstock.Value),
                Platfrom = productplatform.Value,
                Type = producttype.Value,
                Genre = productgenre.Value
                
            };

            try
            {
                database.Products.InsertOnSubmit(NewProduct);
                database.SubmitChanges();
                Response.Redirect("ProductAddition.aspx");
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1);

            }
        }
    }
}