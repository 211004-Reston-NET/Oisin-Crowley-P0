using System;
using SupplyShopModels;
using SupplyShopBL;
using System.Collections.Generic;
using SupShopUI;

namespace SupShopUI
{
    public class AddOrders : IStoreFront
    {
        public static string _finditemname;
        private static Orders _orders = new Orders();
        private IOrdersBL _ordersBL;


        public AddOrders(IOrdersBL p_ordersBL)
        {
            _ordersBL = p_ordersBL;


        }

         private IItemsBL _itemsBL;

        

        public void Display()
        {

            Console.WriteLine("Would you like to place an order?");
            Console.WriteLine("[1] to view products");
            Console.WriteLine("[2] Select an item to buy");
            
            Console.WriteLine("[0] to return to store front");



        }
        public DirectoryChoice YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                
                case "1":
                Console.WriteLine("Product List");
                 List<Items>listOfItems = _itemsBL.GetAllItems();

            foreach (Items items in listOfItems)
            {
                Console.WriteLine("================");
                Console.WriteLine(items);
                Console.WriteLine("==============");
            }
                
                return DirectoryChoice.AddOrder;
                case "2":
                    Console.WriteLine("Enter the name of the item ");
                    _finditemname = Console.ReadLine();
                    List<Items>listOfItem = _itemsBL.GetItems(_finditemname);
                   
                   
                    
                    
                    
                    return DirectoryChoice.AddOrder;
              
                    
                case "0":
                    return DirectoryChoice.StoreFrontMain;
                default:
                    Console.WriteLine("Please enter a valid choice");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    return DirectoryChoice.StoreFrontMain;




            }
        }






    }
}