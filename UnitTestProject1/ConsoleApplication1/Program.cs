using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using Test.ShopCart;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test.ShopCart.ProductCatalogMgr ddb = new ProductCatalogMgr();
            //ddb.Loaddata();
            
            //ddb.ReadData();
            Test.ShopCart.ShopCart sh = null;

            Test.ShopCart.ShopCart.Status += new Test.ShopCart.ShopCart.status(sh_Status);

            sh = new Test.ShopCart.ShopCart();

            if (!sh.TestReady)
            {
                Console.WriteLine(sh.Error);
                Console.WriteLine(sh.Errors);
                if (sh.ExceptionError != null)
                {
                    Console.WriteLine(sh.ExceptionError.Message);
                    Console.WriteLine(sh.ExceptionError.Source);
                    Console.WriteLine(sh.ExceptionError.StackTrace);
                    if(sh.ExceptionError.InnerException!=null)
                        Console.WriteLine(sh.ExceptionError.InnerException.Message);

                }
                goto ExitTests;
            }
            //sh.getSkuFromProductID("VMM");



            sh.QuickTest();

            ExitTests:
            Console.ReadLine();
        }

        static void sh_Status(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
