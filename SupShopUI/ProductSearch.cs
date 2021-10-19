using SupShopUI;
using System;
using SupplyShopModels;
using SupplyShopBL;
using System.Collections.Generic;

namespace SupShopUi
{
    public class ProductSearch : IStoreFront
    {
        public static string _finditemname;
        private static Items _items = new Items();
        private IItemsBL _itemsBL;


        public ProductSearch(IItemsBL p_itemsBL)
        {
            _itemsBL = p_itemsBL;


        }  
        
        public void Display()
        {
          Console.WriteLine("[1] To enter the name of the product you want to search for.");
            Console.WriteLine("[0] To go back. ");
        }

        public DirectoryChoice YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch(userChoice)
            {
                case "1":
                    Console.WriteLine("Enter the name of the product you want to find");
                    _finditemname = Console.ReadLine();
                    return DirectoryChoice.ProdSearchResult;
                
                case "0":
                return DirectoryChoice.StoreFront;
                default:
                Console.WriteLine("Please Enter a valid Choice");
                Console.ReadLine();
                return DirectoryChoice.SearchCustomer;
            }
        }
    }
}