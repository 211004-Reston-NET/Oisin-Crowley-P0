using SupplyShopBL;
using SupplyShopModels;
using System.Collections.Generic;
using System;


namespace SupShopUI
{
    public class ShowStore : IStoreFront
    {

         
        private static StoreFront _store = new StoreFront();
        private IStoreFrontBL _storeBL;


        public ShowStore(IStoreFrontBL p_storeBL)
        {
            _storeBL = p_storeBL;


        }  
        public void Display()
        {
            //List<StoreFront> listOfStore = _storeBL.GetStoreByID(StoreSelect._findStore.StoreID);
           // foreach (StoreFront store in listOfStore)
            {
                Console.WriteLine("==============");
             //   Console.WriteLine(store);
                Console.WriteLine("===============");
            }
            Console.WriteLine("[0] Go Back");
        }

        public DirectoryChoice YourChoice()
        {
           string userChoice = Console.ReadLine();

           switch(userChoice)
           {
               case "0":
               return DirectoryChoice.StoreSelect;
               default:
               Console.WriteLine("Please enter a valid response");
               Console.WriteLine("Press enter to continue");
               Console.ReadLine();
               return DirectoryChoice.SearchResult;
           }
        }
    }
}