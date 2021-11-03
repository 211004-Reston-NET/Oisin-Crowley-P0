using System;
using SupplyShopModels;
using SupplyShopBL;
using System.Collections.Generic;
using SupShopUI;

namespace SupShopUI
{
    public class InitiateOrder : IStoreFront
    {
        
        public static Orders _orders;
        private IOrdersBL _ordersBL;


        public InitiateOrder(IOrdersBL p_ordersBL)
        {
            _ordersBL = p_ordersBL;
            

        }
         


        

         public void Display()
        {
            _orders = new Orders();
            Console.WriteLine("Would you like to place an order?");
            Console.WriteLine("[1]Enter the Store ID");
            
           
            
            Console.WriteLine();
            Console.WriteLine("[1] to go to line items");

        }
        public DirectoryChoice YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":    
                
                     try
            {
                SingletonFields._orders.StoreId = int.Parse(Console.ReadLine());
                
            }
            catch (System.Exception)
            {
                
                Console.WriteLine("Please enter a valid number");
                return DirectoryChoice.InitiateOrder;
            }
                return DirectoryChoice.InitiateOrder;
                
            
            
            
                
                
                
                   
                   
                    
                    
                    
                    
              
                    
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