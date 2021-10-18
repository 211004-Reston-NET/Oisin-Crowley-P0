using SupShopUI;
using System;
using SupplyShopModels;
using SupplyShopBL;
using System.Collections.Generic;

namespace SupShopUi
{
    public class SearchCustomer : IStoreFront
    {
        
        private static Customers _cust = new Customers();
        private ICustomersBL _custBL;


        public SearchCustomer(ICustomersBL p_custBL)
        {
            _custBL = p_custBL;


        }  
        
        public void Display()
        {
            Console.WriteLine("Search for a customer");
            List<Customers> customerList = _custBL.GetAllCustomers();
            string userChoice = Console.ReadLine();

            foreach (Customers customer in customerList)
            {
                if( customer.Name == userChoice )
                {
                    Console.WriteLine(customer);
                }
                else
                {
                    Console.WriteLine("No Match Found");
                    
                }
            }
            
        }

        public DirectoryChoice YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch(userChoice)
            {
                case "1":
                return DirectoryChoice.SearchCustomer;
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