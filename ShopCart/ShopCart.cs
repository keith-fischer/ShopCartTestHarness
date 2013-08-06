using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using GreatCall.ShoppingCart.Contracts.Services;
using GreatCall.ShoppingCart.Contracts;
using ShopCart.ServiceReferenceCartService;

namespace Test.ShopCart
{
    public class ShopCart : TestCaseMgr
    {
        public string Errors { get; set; }
        public Exception ExceptionError { get; set; }
        public string[] TheShoppingList { get; set; }
        //public ProductCatalogMgr ProductCatalogManager { get; set; }
        public bool TestReady { get; set; }
        public ShopCart()
        {
            this.TestReady = false;
            this.ProductCatalogPathXML = Settings1.Default.ProductCatalogPathXML;
            this.ProductCatalogPathXSD = Settings1.Default.ProductCatalogPathXSD;
            try
            {
                this.ReadData();//load the shopcartCatalog
            }
            catch(Exception e)
            {
                this.ExceptionError=e;
                this.Errors=e.Message;
            }

            if (this.ShopcartCatalog != null && this.ShopcartCatalog.Tables != null && this.ShopcartCatalog.Tables.Count == 5)
                this.TestReady = true;
            else
            {
                this.Errors = "Failed: Shopcart dataset failed to initialize.";
                this.ExceptionError = new Exception("Failed: Shopcart dataset failed to initialize.");
            }
            //this.Loaddata(); refresh xml
        }
        public void QuickTest()
        {
            DBQuickTest(null);
        }

        public void RunAlltests()
        {
                        //this.TheShoppingList = shoppinglist;

            GreatCall.ShoppingCart.Contracts.Services.ICartService cartservice = new GreatCall.ShoppingCart.Contracts.Services.CartServiceClient("CartService").ChannelFactory.CreateChannel();

            var cartId = cartservice.CreateCart();
            //var thecart = cartservice.GetCart(cartid);
            //GreatCall.ShoppingCart.Contracts.CartUpdateRequest cartupdate = new GreatCall.ShoppingCart.Contracts.CartUpdateRequest();
            //cartupdate.CartId = cartId;
            //cartupdate.NewQuantity = 1;
            string groupId = Guid.NewGuid().ToString();
            
            //cartupdate.ProductId = "1819";

            string[] shopcartlist=new string[]{//default simple list
                "JitterbugPlusRed",//Phones	62	GC001A-W-PLTNM	1819	Jitterbug Plus Phone - Silver		TRUE		Active              
                "Basic14"//Services	1	GC504A	1820	Basic 14 - Monthly		TRUE	50	Active              	<Binary data>	Less	1	BOTH

            };
            if (this.TheShoppingList == null || this.TheShoppingList.Length == 0)
                this.TheShoppingList = shopcartlist;

            GreatCall.ShoppingCart.Contracts.Cart updatedCart=null;
            foreach (string productId in shopcartlist)
            {
                try
                {
                    Console.WriteLine("Add to cart: {0}", productId);
                    updatedCart = cartservice.UpdateCart(new CartUpdateRequest()
                    {
                        CartId = cartId,
                        GroupId = groupId,
                        ProductId = productId,
                        NewQuantity = 1
                    });


                    Console.WriteLine("Cart Items Count = {0}", updatedCart.Groups[0].Items.Count);
                }
                catch (Exception e)
                {

                    Console.WriteLine("{0} {1}", "", e.ToString());

                }

            }
        }
        public void DBQuickTest(string[] shoppinglist)
        {
            this.TheShoppingList = shoppinglist;

            GreatCall.ShoppingCart.Contracts.Services.ICartService cartservice = new GreatCall.ShoppingCart.Contracts.Services.CartServiceClient("CartService").ChannelFactory.CreateChannel();

            var cartId = cartservice.CreateCart();
            //var thecart = cartservice.GetCart(cartid);
            //GreatCall.ShoppingCart.Contracts.CartUpdateRequest cartupdate = new GreatCall.ShoppingCart.Contracts.CartUpdateRequest();
            //cartupdate.CartId = cartId;
            //cartupdate.NewQuantity = 1;
            string groupId = Guid.NewGuid().ToString();
            
            //cartupdate.ProductId = "1819";

            string[] shopcartlist=new string[]{//default simple list
                "JitterbugPlusRed",//Phones	62	GC001A-W-PLTNM	1819	Jitterbug Plus Phone - Silver		TRUE		Active              
                "Basic14"//Services	1	GC504A	1820	Basic 14 - Monthly		TRUE	50	Active              	<Binary data>	Less	1	BOTH

            };
            if (this.TheShoppingList == null || this.TheShoppingList.Length == 0)
                this.TheShoppingList = shopcartlist;

            GreatCall.ShoppingCart.Contracts.Cart updatedCart=null;
            foreach (string productId in shopcartlist)
            {
                try
                {
                    Console.WriteLine("Add to cart: {0}", productId);
                    updatedCart = cartservice.UpdateCart(new CartUpdateRequest()
                    {
                        CartId = cartId,
                        GroupId = groupId,
                        ProductId = productId,
                        NewQuantity = 1
                    });


                    Console.WriteLine("Cart Items Count = {0}", updatedCart.Groups[0].Items.Count);
                }
                catch (Exception e)
                {

                    Console.WriteLine("{0} {1}", "", e.ToString());

                }

            }

            foreach (CartGroup grp in updatedCart.Groups)
            {
                foreach (CartItem inCart in grp.Items)
                {
                    Console.WriteLine("{0} {1}", inCart.Quantity, inCart.Product.Description);
                }
            }
        }
    }
}
