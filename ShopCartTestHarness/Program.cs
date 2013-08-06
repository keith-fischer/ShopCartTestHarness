using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//using ShopCartTestHarness.
//using ShopCartTestHarness.CostGuardService;
using GreatCall.ShoppingCart.Contracts;
namespace ShopCartTestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            //ShopCartTestHarness.CartService.CartServiceClient shopcart = new CartServiceClient("CartService").ChannelFactory.CreateChannel();
            var cartservice = new GreatCall.ShoppingCart.Contracts.Services.CartServiceClient("CartService").ChannelFactory.CreateChannel();

            var cartid = cartservice.CreateCart();
            var thecart = cartservice.GetCart(cartid);
            GreatCall.ShoppingCart.Contracts.CartUpdateRequest cartupdate=new GreatCall.ShoppingCart.Contracts.CartUpdateRequest();
            cartupdate.CartId = cartid;
            cartupdate.NewQuantity = 1;
            cartupdate.GroupId = "cat";
            cartupdate.ProductId = "dog";
            thecart=cartservice.UpdateCart(cartupdate);





        }
    }
}
