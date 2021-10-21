using System;



namespace SupShopUI
{
    public class ProductPage : IStoreFront
    {
        public void Display()
        {
            Console.WriteLine("Enter inventory [1]");
            Console.WriteLine("View Products [2]");
            Console.WriteLine("Search Products [3]");
            Console.WriteLine("Go back [0]");
        }

        public DirectoryChoice YourChoice()
        {
           string userChoice = Console.ReadLine();
            switch(userChoice)
            {
                case "1":
                   return DirectoryChoice.MainInventory;
                case "2":
                    return DirectoryChoice.ShowProduct;
                case "3":
                    return DirectoryChoice.ProductSearch;
                
                case "0":
                return DirectoryChoice.StoreFrontMain;
                default:
                Console.WriteLine("Please Enter a valid Choice");
                Console.ReadLine();
                return DirectoryChoice.SearchCustomer;
        }
    }
}}