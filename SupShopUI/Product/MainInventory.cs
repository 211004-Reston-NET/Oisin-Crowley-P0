using System;
using SupplyShopModels;
using SupplyShopBL;

namespace SupShopUI
{
    public class MainInventory : IStoreFront
    {
     
   private static Items _items = new Items();
        private IItemsBL _itemsBL;


        public MainInventory(IItemsBL p_itemsBL)
        {
            _itemsBL = p_itemsBL;


        } 

        public void Display()
        {
            Console.WriteLine("Add products to the inventory.");
            Console.WriteLine("[1] Add an ItemId.");
            Console.WriteLine("[2] Please enter the product name.");
            Console.WriteLine("[3] Please enter the products price.");
            Console.WriteLine("[4] Please enter the product quantity.");
            Console.WriteLine("[5] Save Item");
            Console.WriteLine("ItemId " + _items.itemId);
            Console.WriteLine("Product Name: " + _items.itemName);
            Console.WriteLine("Product Price: " + _items.itemPrice);
            Console.WriteLine("Product Quantity: " + _items.itemQuanity);

            
        }
        public DirectoryChoice YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                //this will return inventory and do something
                    try
                    {
                      _items.itemId = int.Parse(Console.ReadLine());
                    }
                    catch (System.Exception)
                    {
                        
                        Console.WriteLine("Please enter a valid Number");
                    }
                    try
                    {
                        _itemsBL.AddItems(_items);
                    }
                    catch (System.Exception)
                    {
                        
                        Console.WriteLine("Please enter a value into the field");
                        Console.WriteLine("Press Enter to Continue");
                        Console.ReadLine();
                        return DirectoryChoice.MainInventory;
                        
                    }
                    return DirectoryChoice.MainInventory;

                case "2":
                    try
                    {
                        _items.itemName = Console.ReadLine();
                    }
                    catch (System.Exception)
                    {
                        
                        Console.WriteLine("Please enter a value into the field");
                        Console.WriteLine("Press Enter to Continue");
                        Console.ReadLine();
                        return DirectoryChoice.MainInventory;
                    }
                    return DirectoryChoice.MainInventory;
                case "3":
                             try
                    {
                      _items.itemPrice = int.Parse(Console.ReadLine());
                    }
                    catch (System.Exception)
                    {
                        
                        Console.WriteLine("Please enter a valid Number");
                    }
                    try
                    {
                        _itemsBL.AddItems(_items);
                    }
                    catch (System.Exception)
                    {
                        
                        Console.WriteLine("Please enter a value into the field");
                        Console.WriteLine("Press Enter to Continue");
                        Console.ReadLine();
                        return DirectoryChoice.MainInventory;
                        
                    }
                    return DirectoryChoice.MainInventory;
                    case "4":
                             try
                    {
                      _items.itemQuanity = int.Parse(Console.ReadLine());
                    }
                    catch (System.Exception)
                    {
                        
                        Console.WriteLine("Please enter a valid Number");
                    }
                    try
                    {
                        _itemsBL.AddItems(_items);
                    }
                    catch (System.Exception)
                    {
                        
                        Console.WriteLine("Please enter a value into the field");
                        Console.WriteLine("Press Enter to Continue");
                        Console.ReadLine();
                        return DirectoryChoice.MainInventory;
                        
                    }
                    return DirectoryChoice.MainInventory;
                    case "5":
                    _itemsBL.AddItems(_items);
                    return DirectoryChoice.MainInventory;
                    
                case "0":
                    return DirectoryChoice.StoreFrontMain;
                    default:
                    Console.WriteLine("Please enter a valid choice");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    return DirectoryChoice.MainInventory;
                
                   


            }
        }
    }
}