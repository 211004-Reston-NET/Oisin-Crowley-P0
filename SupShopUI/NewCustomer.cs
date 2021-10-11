using System;
using SupplyShopModels;

namespace SupShopUI
{
    public class NewCustomer : IStoreFront
    {
     

        public void Display()
        {
            Console.WriteLine("Welcome to the inventory shelf");
            Console.WriteLine("Please choose what you want to do");
            Console.WriteLine("See what is in stock [1]");
            Console.WriteLine("Go back to the main menu [2]");
            Console.WriteLine("Go to the front of the shop and see what is on sale? [3]");
            Console.WriteLine("Enter new Customer Information[4]");
            Console.WriteLine("Exit appliction [0]");
        }
        public DirectoryChoice YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                //this will return inventory and do something
                    return DirectoryChoice.MainInventory;
                case "2":
                    return DirectoryChoice.StoreFront;
                case "3":
                    return DirectoryChoice.StoreFloor;
                case "4":
                        return EnterCustomerInfo();
                case "0":
                    return DirectoryChoice.Exit;
                    default:
                    Console.WriteLine("Please enter a valid choice");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    return DirectoryChoice.MainInventory;
                
                   


            }
        }

        private void EnterCustomerInfo()
        {
            Customers cust = new Customers();
            Console.Clear();
            Console.WriteLine("Please get ready to enter the customer information");
            Console.WriteLine("what is the customers first name?")
            cust.FName = Console.ReadLine();

            Console.WriteLine("Please Enter the customers Last name?");
            cust.Lname = Console.ReadLine();

            Console.WriteLine("Please enter their city?");
            cust.city = Console.ReadLine();

            Console.WriteLine("Please enter their state?");
            cust.state = Console.ReadLine();

            Console.WriteLine("Please enter their Email.");
            cust.Email = Console.ReadLine();

            Console.WriteLine("Please Enter their Phone number");
            cust.Phone = Console.ReadLine();

            

            

        }
    }
}