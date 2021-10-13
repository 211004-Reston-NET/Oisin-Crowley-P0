using System;
using SupplyShopModels;


namespace SupShopUI
{
    public class EnterInventory : IStoreFront
    {
        public static object printInventory { get; private set; }

        public void Display()
        {
            Console.WriteLine("Welcome to the Inventory floor");
            Console.WriteLine("Please choose what you want to do");
            Console.WriteLine("Do you want to Stock the shelves?[1]");
            Console.WriteLine("Go back to the main menu [2]");
            
        }
        public DirectoryChoice YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                //this will return inventory and do something
                 //  return StockShelves();
                case "2":
                    return DirectoryChoice.StoreFront;
                case "0":
                    return DirectoryChoice.Exit;
                    default:
                    Console.WriteLine("Please enter a valid choice");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    return DirectoryChoice.MainInventory;
                
                   


            }
        }

        private void StockShelves()
        {
            string userChoice = Console.ReadLine();

            string itemName = "";
            int itemPrice = 0;
            int itemQuantity = 0;
            Console.WriteLine("Please enter the inventory to be stocked.[1]");
            Console.WriteLine("Or [2] to exit ");
         Items newItem = new Items();
            bool repeat = true;
            while (repeat)
            {
                switch(userChoice)
                {
                    case "1":

                Console.Clear();

                ///
                ///this is asking for the items to be entered into 
                /// for inventory managment toDO a printinventory()
                /// /// 
                Console.WriteLine("What is the item name?");
                itemName = Console.ReadLine();

                Console.WriteLine("How much is the item?");
                itemPrice = int.Parse(Console.ReadLine());

                Console.WriteLine("How many are in stock?");
                itemQuantity = int.Parse(Console.ReadLine());

               // SupplyShop Items = new SupplyShop(itemName,itemPrice,itemQuantity);
                
                break;
                case "2":
                  //  return DirectoryChoice.EnterInventory;
                 default : 
                Console.WriteLine("you forgot something");
                repeat = false;
                break;
                
                 
                





}



            }

            
        }

      
    }
}