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
        public delegate void status(string msg);
        public static event status Status;
        public string Errors { get; set; }
        public Exception ExceptionError { get; set; }
        public string[] TheShoppingList { get; set; }
        //public ProductCatalogMgr ProductCatalogManager { get; set; }
        public bool TestReady { get; set; }
        private void eventStatus(string msg)
        {
            if (Test.ShopCart.ShopCart.Status != null)
                Test.ShopCart.ShopCart.Status(msg);
        }
        private void eventErrorStatus(string msg)
        {
            msg = msg + "\r\n" + this.Error + "\r\n" + this.Errors;
            if (this.ExceptionError != null)
                msg = msg + "\r\n"+this.ExceptionError.Message;
            if (Test.ShopCart.ShopCart.Status != null)
                Test.ShopCart.ShopCart.Status(msg);
            this.Error = "";
            this.Errors = "";
        }
        public ShopCart()
        {
            this.RunTestStep += new runTeststep(ShopCart_RunTestStep);
            this.TestStart += new testStart(ShopCart_TestStart);
            this.TestStop += new testStop(ShopCart_TestStop);
            this.TestReady = false;
            eventStatus("Starting");
            if (this.TestCasesReady)// = false;
            {
                eventStatus("Loading ProductCatalogPathXML");
                this.ProductCatalogPathXML = Settings1.Default.ProductCatalogPathXML;
                this.ProductCatalogPathXSD = Settings1.Default.ProductCatalogPathXSD;
                try
                {
                    this.ReadData();//load the shopcartCatalog
                }
                catch (Exception e)
                {
                    this.ExceptionError = e;
                    this.Errors = e.Message;
                    eventErrorStatus("FAILED Loading ProductCatalogPathXML");
                }

                if (this.ShopcartCatalog != null && this.ShopcartCatalog.Tables != null && this.ShopcartCatalog.Tables.Count == 5)
                {
                    this.TestReady = true;
                    eventStatus("Ready");
                }
                else
                {
                    this.Errors = "Failed: Shopcart dataset failed to initialize.";
                    this.ExceptionError = new Exception("Failed: Shopcart dataset failed to initialize.");
                    eventErrorStatus("FAILED Loading ShopcartCatalog.Tables");
                }
            }
            else
            {
                this.Error += "Failed to Load All Test Cases in " + Settings1.Default.TestCasePath;
                eventErrorStatus("");
            }
            //this.Loaddata(); refresh xml
        }

        void ShopCart_TestStop()
        {
            throw new NotImplementedException();
        }

        void ShopCart_TestStart(string test)
        {
            throw new NotImplementedException();
        }

        void ShopCart_RunTestStep(TestStep testStep)
        {
            throw new NotImplementedException();
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
