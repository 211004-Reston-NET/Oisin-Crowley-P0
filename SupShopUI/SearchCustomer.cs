using SupShopUI;
using System;
using SupplyShopModels;
using SupplyShopBL;
using System.Collections.Generic;

namespace SupShopUi
{
    public class SearchCustomer : IStoreFront
    {
        public static string _findcustname;
        private static Customers _cust = new Customers();
        private ICustomersBL _custBL;


        public SearchCustomer(ICustomersBL p_custBL)
        {
            _custBL = p_custBL;


        }  
        
        public void Display()
        {
          Console.WriteLine("[1] To enter the name of the customer you want to search for.");
            Console.WriteLine("[0] To go back. ");
        }

        public DirectoryChoice YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch(userChoice)
            {
                case "1":
                    Console.WriteLine("Enter the name of the customer you want to find");
                    _findcustname = Console.ReadLine();
                    return DirectoryChoice.SearchResult;
                
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