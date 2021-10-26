using System;

namespace SupShopUI
{
    public class UpdateProd : IStoreFront
    {
        public void Display()
        {
            Console.WriteLine("Update Inventory");
            Console.WriteLine("[1] to update inventory");
            Console.WriteLine("[0] To go back.");
        }

        public DirectoryChoice YourChoice()
        {
            string userChoice = Console.ReadLine();

            switch(userChoice)
            {
                case "1":


                return DirectoryChoice.UpdateProd;
                case "0":
                    return DirectoryChoice.Exit;
                    default:
                    Console.WriteLine("Please enter a valid choice");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    return DirectoryChoice.ProductPage;
            }
            
        }
    }
}