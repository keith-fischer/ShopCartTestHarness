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
            Test.ShopCart.ShopCart sh = new Test.ShopCart.ShopCart();
            if (!sh.TestReady)
            {
                goto ExitTests;
            }
            sh.QuickTest();

            ExitTests:
            Console.ReadLine();
        }
    }
}
