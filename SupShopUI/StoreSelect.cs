using SupShopUI;
using System;
using SupplyShopModels;
using SupplyShopBL;
using System.Collections.Generic;

namespace SupShopUI
{
    public class StoreSelect : IStoreFront
    {
        public static StoreFront _findStore = new StoreFront();
        private static StoreFront _store = new StoreFront();
        private IStoreFrontBL _storeBL;


        public StoreSelect(IStoreFrontBL p_storeBL)
        {
            _storeBL = p_storeBL;


        }  
        
        public void Display()
        {
          Console.WriteLine("[1] To select the store ID you want.");
            Console.WriteLine("[0] To go back. ");
        }

        public DirectoryChoice YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch(userChoice)
            {
                case "1":
                    Console.WriteLine("Please enter the Supply Shop you want to select.");
                    try
                    {
                         _findStore.StoreID = int.Parse(Console.ReadLine());
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("please enter a valid number");
                        return DirectoryChoice.StoreSelect;
                        
                        
                    }
                    
                    return DirectoryChoice.StoreSelect;
                
                case "0":
                return DirectoryChoice.StoreFrontMain;
                default:
                Console.WriteLine("Please Enter a valid Choice");
                Console.ReadLine();
                return DirectoryChoice.ProductSearch;
            }
        }
    }
}