using System;

namespace SupShopUI
{
    public class StoreFront : IStoreFront
    {
      

        public void Display()
        {
            Console.WriteLine("Welcome to the Supply Store");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("[1] - Enter the Store");
            Console.WriteLine("[2] Handle inventory");
            Console.WriteLine("[3] Enter Customer Information");
            Console.WriteLine("[4] View Products.");
            Console.WriteLine("[5] Search for a customer");
            Console.WriteLine("[6] Search for a Product");
            Console.WriteLine("0 - Exit the Store");
        }

        public DirectoryChoice YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                return DirectoryChoice.StoreFloor;

                case "2":
                return DirectoryChoice.MainInventory;
                case "3":
                return DirectoryChoice.NewCustomer;
                case "4":
                return DirectoryChoice.ShowProduct;
                case "5":
                return DirectoryChoice.SearchCustomer;
                case "6": 
                return DirectoryChoice.ProductSearch;
                case "0":
                return DirectoryChoice.Exit;
                default:
                Console.WriteLine   ("Please enter a valid response");
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
                return DirectoryChoice.StoreFront;
            }

        }
    }
}
