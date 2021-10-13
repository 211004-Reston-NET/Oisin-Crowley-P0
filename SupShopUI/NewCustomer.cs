using System;
using SupplyShopModels;
using SupplyShopBL;

namespace SupShopUI
{
    public class NewCustomer : IStoreFront
    {
        private static Customers _cust = new Customers();
        private ICustomersBL _custBL;


        public NewCustomer(ICustomersBL p_custBL)
        {
            _custBL = p_custBL;


        }

        public void Display()
        {

            Console.WriteLine("Adding a new customer");
            Console.WriteLine("Name " + _cust.Name);
            Console.WriteLine("City " + _cust.City);
            Console.WriteLine("State " + _cust.State);
            Console.WriteLine("Phone " + _cust.Phone);
            Console.WriteLine("Email " + _cust.Email);
            Console.WriteLine("[1] to enter the Name.");
            Console.WriteLine("[2] to enter the City.");
            Console.WriteLine("[3] To enter the State.");
            Console.WriteLine("[4] to enter the phone number.");
            Console.WriteLine("[5] to enter the email.");
            Console.WriteLine("[0] to return to store front");
        }
        public DirectoryChoice YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                /// <summary>
                /// gathering input of the new customers
                /// </summary>
                /// <returns></returns>
                case "1":

                    Console.WriteLine("Enter the name");
                    _cust.Name = Console.ReadLine();
                    return DirectoryChoice.NewCustomer;
                case "2":
                    Console.WriteLine("Enter the City");
                    _cust.City = Console.ReadLine();
                    return DirectoryChoice.NewCustomer;
                case "3":
                    Console.WriteLine("Enter the State");
                    _cust.State = Console.ReadLine();
                    return DirectoryChoice.NewCustomer;
                case "4":
                    Console.WriteLine("Enter the Phone Number");
                    _cust.Phone = Console.ReadLine();
                    return DirectoryChoice.NewCustomer;
                case "5":
                    Console.WriteLine("Enter the Email");
                    _cust.Email = Console.ReadLine();
                    return DirectoryChoice.NewCustomer;
                case "0":
                    return DirectoryChoice.StoreFront;
                default:
                    Console.WriteLine("Please enter a valid choice");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    return DirectoryChoice.StoreFront;




            }
        }







    }
}
