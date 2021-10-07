using System;

namespace SupShopUI
{
    public class StoreFront : IStoreFront
    {
      

        public void Display()
        {
            Console.WriteLine("Welcome to the Supply Store");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1 - Enter the Store");
            Console.WriteLine("[2] Handle inventory");
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
